// Copyright (c) Tomasz Jastrzebski 2020
// This ICN6211 configurator has been written based on numerous forum discussions and blogs posts,
// rather than on the manufacturer specs so settings may not be 100% accurate.
// Any improvements and suggestions are appreciated.
// https://github.com/tdjastrzebski/ICN6211-Configurator

using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ICN6211_Configurator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            Application.ThreadException += Application_ThreadException;
            InitializeComponent();
        }

        private void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs e)
        {
            if (e.Exception is ApplicationException) {
                MessageBox.Show(this, e.Exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            } else {
                MessageBox.Show(this, "Fatal error. Terminating", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Settings2RegistryButton_Click(object sender, EventArgs e)
        {
            RegistersTextBox.Text = GetRegistrySettings();
        }

        private void Registry2SettingsButton_Click(object sender, EventArgs e)
        {
            ParseRegistrySettings(RegistersTextBox.Text);
        }

        private void RefClkCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            RefClkTextBox.Enabled = RefClkCheckBox.Checked;
        }

        private void TestModeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            TestModeTextBox.Enabled = TestModeCheckBox.Checked;
        }

        private void EnableSwapRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            bool enabled = EnableSwapRadioButton.Checked;
            Lane0SwapCheckBox.Enabled = enabled;
            Lane1SwapCheckBox.Enabled = enabled;
            Lane2SwapCheckBox.Enabled = enabled;
            Lane3SwapCheckBox.Enabled = enabled;
            ClockCheckBox.Enabled = enabled;
        }

        private void TimerFps_Tick(object sender, EventArgs e)
        {
            try {
                double rgbClk = Double.Parse(RgbClkTextBox.Text);
                double hActivePixel = Double.Parse(HActivePixelTextBox.Text);
                double vActiveLine = Double.Parse(VActiveLineTextBox.Text);
                double hSync = Double.Parse(HSyncTextBox.Text);
                double vSync = Double.Parse(VSyncTextBox.Text);
                double hbp = Double.Parse(HbpTextBox.Text);
                double vbp = Double.Parse(VbpTextBox.Text);
                double hfp = Double.Parse(HfpTextBox.Text);
                double vfp = Double.Parse(VfpTextBox.Text);

                double fps = rgbClk * 1000000.0 / ((hActivePixel + hfp + hSync + hbp) * (vActiveLine + vfp + vSync + vbp));

                FpsToolStripStatusLabel.Text = $"{fps:F2} fps";
            } catch (FormatException) {
                FpsToolStripStatusLabel.Text = "fps?";
            }
        }

        private string GetRegistrySettings()
        {
            List<(byte register, byte value)> settings = new List<(byte register, byte value)>();

            if (!I2CRadioButton.Checked) settings.Add((0x7A, 0xC1)); // MIPI Command Mode

            // HACTIVE[7:0]
            ushort hActivePixel = UInt16.Parse(HActivePixelTextBox.Text);
            if (hActivePixel > 4095) throw new ApplicationException("H Active Pixel > 4095");
            settings.Add((0x20, (byte)(hActivePixel & 0xFF)));

            // VACTIVE[7:0]
            ushort vActiveLine = UInt16.Parse(VActiveLineTextBox.Text);
            if (vActiveLine > 4095) throw new ApplicationException("V Active Pixel > 4095");
            settings.Add((0x21, (byte)(vActiveLine & 0xFF)));

            // VACTIVE[11:8] for bit 7-4, HACTIVE[11:8] for bit 3-0
            settings.Add((0x22, (byte)(((vActiveLine & 0xF00) >> 4) | ((hActivePixel & 0xF00) >> 8))));

            ushort hfp = UInt16.Parse(HfpTextBox.Text);
            if (hfp > 4095) throw new ApplicationException("HFP > 1023");
            settings.Add((0x23, (byte)(hfp & 0xFF))); // HFP

            ushort hSync = UInt16.Parse(HSyncTextBox.Text);
            if (hSync > 4095) throw new ApplicationException("H Sync > 1023");
            settings.Add((0x24, (byte)(hSync & 0xFF))); // HSync

            ushort hbp = UInt16.Parse(HbpTextBox.Text);
            if (hbp > 4095) throw new ApplicationException("HBP > 1023");
            settings.Add((0x25, (byte)(hbp & 0xFF))); // HBP

            // HFP[9:8] for bit 5-4, HSync[9:8] for 3-2, HBP[9:8] for bit 1-0
            settings.Add((0x26, (byte)(((hfp & 0x300) >> 4) | ((hSync & 0x300) >> 6) | ((hbp & 0x300) >> 8))));

            ushort vfp = UInt16.Parse(VfpTextBox.Text);
            if (vfp > 255) throw new ApplicationException("VFP > 255");
            settings.Add((0x27, (byte)vfp)); // VFP

            ushort vSync = UInt16.Parse(VSyncTextBox.Text);
            if (vSync > 255) throw new ApplicationException("V Sync > 255");
            settings.Add((0x28, (byte)vSync)); // VSync

            ushort vbp = UInt16.Parse(VbpTextBox.Text);
            if (vbp > 255) throw new ApplicationException("VBP > 255");
            settings.Add((0x29, (byte)vbp)); // VBP

            settings.Add((0x34, 0x80)); // SYNC_EVENT_DLY[7:0]

            // HSW_MIN
            if (hfp <= 255 && hfp != 0x80) {
                settings.Add((0x36, (byte)hfp));
            } else {
                settings.Add((0x36, 0xFF));
            }

            int mipiLaneNo = Byte.Parse(MipiLaneNoComboBox.Text) - 1;
            byte x86 = (byte)(0b_0010_1000 | (mipiLaneNo & 0x03));
            if (x86 != 0x2B) settings.Add((0x86, x86)); // DSI_CTRL register (number of D-PHY lines)

            settings.Add((0xB5, 0xA0)); // MIPI_PD_CK_LANE register

            settings.Add((0x5C, 0xFF)); // PLL_WT_LOCK[7:0]

            int x87 = 0;

            if (EnableSwapRadioButton.Checked) {
                x87 |= ClockCheckBox.Checked ? 0b_0001_0000 : 0;
                x87 |= Lane3SwapCheckBox.Checked ? 0b_0000_1000 : 0;
                x87 |= Lane2SwapCheckBox.Checked ? 0b_0000_0100 : 0;
                x87 |= Lane1SwapCheckBox.Checked ? 0b_0000_0010 : 0;
                x87 |= Lane0SwapCheckBox.Checked ? 0b_0000_0001 : 0;
            }

            if (x87 != 0) settings.Add((0x87, (byte)x87)); // MIPI P/N Swap

            int x2A = 0;
            x2A |= TEPolarityCheckBox.Checked ? 1 : 0;
            x2A |= VSyncPolarityCheckBox.Checked ? 2 : 0;
            x2A |= HSyncPolarityCheckBox.Checked ? 4 : 0;
            x2A |= TestModeCheckBox.Checked ? 8 : 0;

            if (TestModeCheckBox.Checked) {
                byte testMode = Byte.Parse(TestModeTextBox.Text);
                if (testMode > 15) throw new ApplicationException("Test mode > 15");
                x2A |= 8;
                x2A |= testMode << 4;
                settings.Add((0x14, 0x43)); // enable test mode
            }

            settings.Add((0x2A, (byte)x2A)); // H/V Sync, DE Polarity bits 0-2, BIST_GEN bit 3, BIST_MODE bits 4-7

            // Set to 0x93 for the internal clock, 0x92 when MIPI is used as the pixel clock, 0x90 when external clock is used
            settings.Add((0x56, (byte)(RefClkCheckBox.Checked ? 0x90 : 0x92)));

            double rgbClk = Double.Parse(RgbClkTextBox.Text);
            double mipiClk = Double.Parse(MipiClkTextBox.Text);
            double refClk = Double.Parse(RefClkTextBox.Text);
            double x69;
            byte x6B;

            if (RefClkCheckBox.Checked) {
                x69 = rgbClk / refClk; // rgbClk as multiplicity of refClk

                if (rgbClk >= 87.5) {
                    x6B = 0x31;
                    x69 *= 8.0;
                } else if (rgbClk >= 43.75) {
                    x6B = 0x51;
                    x69 *= 16.0;
                } else {
                    x6B = 0x71;
                    x69 *= 32.0;
                }
            } else {
                x69 = rgbClk / mipiClk; // rgbClk as multiplicity of mipiClk

                if (rgbClk >= 87.5) {
                    x6B = 0b_0010_0000;
                    x69 *= 4;
                } else if (rgbClk >= 43.75) {
                    x6B = 0b_0100_0000;
                    x69 *= 8;
                } else {
                    x6B = 0b_0110_0000;
                    x69 *= 16;
                }

                if (mipiClk >= 320.0) {
                    x6B |= 0b_10011;
                    x69 *= 24.0;
                } else if (mipiClk >= 160.0) {
                    x6B |= 0b_10010;
                    x69 *= 16.0;
                } else if (mipiClk >= 80.0) {
                    x6B |= 0b_10001;
                    x69 *= 8.0;
                } else {
                    x6B |= 0b_00001;
                    x69 *= 4.0;
                }
            }

            settings.Add((0x6B, x6B)); // PLL_REF_DIV register (RGB clock)
            x69 = Math.Floor(Math.Floor(x69) == x69 ? x69 : Math.Floor(x69) + 1.0);
            settings.Add((0x69, (byte)x69)); // PLL_INT[7:0] (RGB clock)

            byte x10 = (byte)(RfcFunctionCheckBox.Checked ? 0b_1000_0000 : 0);
            string rgb888Text = Rgb888ComboBox.Text;
            string rgb666Text = Rgb666ComboBox.Text;

            if (Rgb888RadioButton.Checked) {
                switch (rgb888Text) {
                    case "GroupX[7:0] = Color[7:0]": x10 |= 0b_0100_0000; break;
                    case "GroupX[7:0] = Color[0:7]": x10 |= 0b_0101_0000; break;
                    default: throw new ApplicationException("Unexpected RGB 888 params.");
                }
            } else if (Rgb666RadioButton.Checked) {
                switch (rgb666Text) {
                    case "GroupX[5:0] = Color[5:0]": x10 |= 0b_0000_0000; break;
                    case "GroupX[5:0] = Color[0:5]": x10 |= 0b_0001_0000; break;
                    case "GroupX[7:2] = Color[5:0]": x10 |= 0b_0010_0000; break;
                    case "GroupX[7:2] = Color[0:5]": x10 |= 0b_0011_0000; break;
                    default: throw new ApplicationException("Unexpected RGB 666 params");
                }
            } else {
                throw new ApplicationException("Unclear RGB 666/888 mode selection.");
            }

            switch (this.OrderComboBox.Text) {
                case "RGB: Red(0) - Green(1) - Blue(2)": x10 |= 0b_0000_0000; break;
                case "RBG: Red(0) - Blue(1) - Green(2)": x10 |= 0b_0000_0001; break;
                case "GRB: Green(0) - Red(1) - Blue(2)": x10 |= 0b_0000_0010; break;
                case "GBR: Green(0) - Blue(1) - Red(2)": x10 |= 0b_0000_0011; break;
                case "BRG: Blue(0) - Red(1) - Green(2)": x10 |= 0b_0000_0100; break;
                case "BGR: Blue(0) - Green(1) - Red(2)": x10 |= 0b_0000_0101; break;
                default: throw new ApplicationException("Unexpected RGB Output order.");
            }

            settings.Add((0x10, (byte)x10)); // SYS_CTRL_0 register (RGB color mode, line swap & order)

            string rgbClkPhaseAdjust = RgbClkPhaseAdjustComboBox.Text;
            byte x11;

            switch (rgbClkPhaseAdjust) {
                case "0": x11 = 0b_1000_1000; break;
                case "1/4": x11 = 0b_1001_1000; break;
                case "1/2": x11 = 0b_1010_1000; break;
                case "3/4": x11 = 0b_1011_1000; break;
                default: throw new ApplicationException("Unexpected phase adjust value.");
            }

            settings.Add((0x11, x11)); // SYS_CTRL_1 register (phase adjust)
            settings.Add((0xB6, 0x20)); // MIPI_FORCE_0 register
            settings.Add((0x51, 0x20)); // PLL_CTRL_1 register
            settings.Add((0x09, 0x10)); // CONFIG_FINISH register, disply on
            //settings.Add((0x7A, 0x3E)); // MIPI Command Mode - set to 0x3E at the end (why?)

            string outputText = String.Join("\r\n", settings.Select(rv => $"0x{rv.register:X2} = 0x{rv.value:X2}"));
            return outputText;
        }

        private void ParseRegistrySettings(string registersAndValues)
        {
            registersAndValues = registersAndValues.Replace("\r\n", "\n").Trim();
            var list = registersAndValues.Split(new[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);
            var settings = new Dictionary<byte, byte>();

            foreach (var regValuePair in list) {
                var rv = regValuePair.Split(new[] { '=' }, StringSplitOptions.RemoveEmptyEntries);

                if (rv.Length != 2) {
                    throw new ApplicationException($"Error parsing registry value: {regValuePair}.");
                }

                var register = rv[0].Trim();
                var value = rv[1].Trim();
                settings.Add(Convert.ToByte(register, 16), Convert.ToByte(value, 16));
            }

            // hActivePixel
            if (settings.ContainsKey(0x20) && settings.ContainsKey(0x22)) {
                int hActivePixel = settings[0x20] | ((settings[0x22] & 0b_0000_1111) << 8);
                this.HActivePixelTextBox.Text = hActivePixel.ToString();
            } else {
                this.HActivePixelTextBox.Text = "";
            }

            // vActiveLine
            if (settings.ContainsKey(0x21) && settings.ContainsKey(0x22)) {
                int vActiveLine = settings[0x21] | ((settings[0x22] & 0b_1111_0000) << 4);
                this.VActiveLineTextBox.Text = vActiveLine.ToString();
            } else {
                this.VActiveLineTextBox.Text = "";
            }

            // HFP
            if (settings.ContainsKey(0x23) && settings.ContainsKey(0x26)) {
                int hfp = settings[0x23] | ((settings[0x26] & 0b_0011_0000) << 4);
                this.HfpTextBox.Text = hfp.ToString();
            } else {
                this.HfpTextBox.Text = "";
            }

            // hSync
            if (settings.ContainsKey(0x24) && settings.ContainsKey(0x26)) {
                int hSync = settings[0x24] | ((settings[0x26] & 0b_0000_1100) << 6);
                this.HSyncTextBox.Text = hSync.ToString();
            } else {
                this.HSyncTextBox.Text = "";
            }

            // HBP
            if (settings.ContainsKey(0x25) && settings.ContainsKey(0x26)) {
                int hbp = settings[0x25] | ((settings[0x26] & 0b_0000_0011) << 8);
                this.HbpTextBox.Text = hbp.ToString();
            } else {
                this.HbpTextBox.Text = "";
            }

            // VFP
            if (settings.ContainsKey(0x27)) {
                byte vfp = settings[0x27];
                this.VfpTextBox.Text = vfp.ToString();
            } else {
                this.VfpTextBox.Text = "";
            }

            // vSync
            if (settings.ContainsKey(0x28)) {
                byte vfp = settings[0x28];
                this.VSyncTextBox.Text = vfp.ToString();
            } else {
                this.VSyncTextBox.Text = "";
            }

            // VBP
            if (settings.ContainsKey(0x29)) {
                byte vbp = settings[0x29];
                this.VbpTextBox.Text = vbp.ToString();
            } else {
                this.VbpTextBox.Text = "";
            }

            // MIPI Lane No
            if (settings.ContainsKey(0x86)) {
                int mipiLaneNo = settings[0x86] & 0b_0000_0011;
                mipiLaneNo += 1;
                this.MipiLaneNoComboBox.Text = mipiLaneNo.ToString();
            } else {
                this.MipiLaneNoComboBox.Text = "";
            }

            // MIPI P/N Swap
            if (settings.ContainsKey(0x87)) {
                int lineSwap = settings[0x87] & 0b_0001_1111;

                if (lineSwap == 0) {
                    EnableSwapRadioButton.Checked = false;
                    DisableSwapRadioButton.Checked = true;
                } else {
                    EnableSwapRadioButton.Checked = true;
                    DisableSwapRadioButton.Checked = false;
                }

                ClockCheckBox.Checked = (lineSwap & 0b_0001_0000) == 0b_0001_0000;
                Lane3SwapCheckBox.Checked = (lineSwap & 0b_0000_1000) == 0b_0000_1000;
                Lane2SwapCheckBox.Checked = (lineSwap & 0b_0000_0100) == 0b_0000_0100;
                Lane1SwapCheckBox.Checked = (lineSwap & 0b_0000_0010) == 0b_0000_0010;
                Lane0SwapCheckBox.Checked = (lineSwap & 0b_0000_0001) == 0b_0000_0001;

            } else {
                EnableSwapRadioButton.Checked = false;
                DisableSwapRadioButton.Checked = true;
                ClockCheckBox.Checked = false;
                Lane3SwapCheckBox.Checked = false;
                Lane2SwapCheckBox.Checked = false;
                Lane1SwapCheckBox.Checked = false;
                Lane0SwapCheckBox.Checked = false;
            }

            // Ref Clock
            if (settings.ContainsKey(0x56)) {
                byte refClk = settings[0x56];
                RefClkCheckBox.Checked = refClk == 0x90;
            } else {
                RefClkCheckBox.Checked = false;
            }

            // RGB Clock
            if (settings.ContainsKey(0x69) && settings.ContainsKey(0x6B)) {
                double rgbClk = settings[0x69];
                byte range = settings[0x6B];

                if (RefClkCheckBox.Checked && Double.TryParse(RefClkTextBox.Text, out double refClk)) {
                    switch (range) {
                        case 0x71: rgbClk /= 32.0; break; // rgbClk < 43.75
                        case 0x51: rgbClk /= 16.0; break; // 43.75 <= rgbClk < 87.5
                        case 0x31: rgbClk /= 8.0; break;  // rgbClk >= 87.5
                        default:
                            this.RgbClkTextBox.Text = "?";
                            throw new ApplicationException($"Unsupported RGB clock range value 0x6B = 0x{range:X2}.");
                    }

                    rgbClk *= refClk;
                    this.RgbClkTextBox.Text = rgbClk.ToString();
                } else {
                    int rgbClkRange = range & 0b_0110_0000;
                    int mipiClkRange = range & 0b_0001_1111;

                    switch (rgbClkRange) {
                        case 0b_0110_0000: rgbClk /= 16.0; break; // rgbClk < 43.75
                        case 0b_0100_0000: rgbClk /= 8.0; break;  // 43.75 <= rgbClk < 87.5
                        case 0b_0010_0000: rgbClk /= 4.0; break;  // rgbClk >= 87.5
                        default: throw new ApplicationException($"Unsupported RGB clock range value 0x6B = 0x{range:X2}.");
                    }

                    switch (mipiClkRange) {
                        case 0b_00001: rgbClk /= 4.0; break;  // mipiClk < 80
                        case 0b_10001: rgbClk /= 8.0; break;  // 80 <= mipiClk < 160
                        case 0b_10010: rgbClk /= 16.0; break; // 160 <= mipiClk < 320
                        case 0b_10011: rgbClk /= 24.0; break; // mipiClk >= 320
                        default: throw new ApplicationException($"Unsupported MIPI clock range value 0x6B = 0x{range:X2}.");
                    }

                    double mipiClk;

                    if (String.IsNullOrWhiteSpace(MipiClkTextBox.Text)) {
                        // propose mipiClk value within range
                        switch (mipiClkRange) {
                            case 0b_00001: mipiClk = 50; break;  // mipiClk < 80
                            case 0b_10001: mipiClk = 100; break; // 80 <= mipiClk < 160
                            case 0b_10010: mipiClk = 250; break; // 160 <= mipiClk < 320
                            case 0b_10011: mipiClk = 350; break; // mipiClk >= 320
                            default: throw new Exception("This exception should not have happened, MIPI clock range checked before.");
                        }
                    } else {
                        if (Double.TryParse(this.MipiClkTextBox.Text, out mipiClk)) {
                            // validate mipiClk is within the specified range
                            switch (mipiClkRange) {
                                case 0b_00001: if (mipiClk > 80) throw new ApplicationException("MIPI CLK > 80"); break;
                                case 0b_10001: if (80.0 > mipiClk || mipiClk >= 160.0) throw new ApplicationException("80 > MIPI CLK >= 160"); break;
                                case 0b_10010: if (160.0 > mipiClk || mipiClk >= 320.0) throw new ApplicationException("160 > MIPI CLK >= 320"); break;
                                case 0b_10011: if (mipiClk < 320) throw new ApplicationException("MIPI CLK < 320"); break;
                                default: throw new Exception("This exception should not have happened, MIPI clock range checked before.");
                            }
                        } else {
                            throw new ApplicationException("Error parsing MIPI Clock value.");
                        }
                    }

                    rgbClk *= mipiClk;
                    this.RgbClkTextBox.Text = rgbClk.ToString();
                }
            } else {
                this.RgbClkTextBox.Text = "?";
            }

            // Config
            if (settings.ContainsKey(0x10)) {
                byte config = settings[0x10];
                RfcFunctionCheckBox.Checked = (config & 0b_1000_0000) == 0b_1000_0000;

                int rgb = (config & 0b_0111_0000) >> 4;
                Rgb888RadioButton.Checked = (rgb == 0b_100 || rgb == 0b_101);
                Rgb666RadioButton.Checked = (rgb == 0b_000 || rgb == 0b_001 || rgb == 0b_010 || rgb == 0b_011);
                Rgb666ComboBox.Text = "";
                Rgb888ComboBox.Text = "";

                switch (rgb) {
                    case 0b_100: Rgb888ComboBox.Text = "GroupX[7:0] = Color[7:0]"; break;
                    case 0b_101: Rgb888ComboBox.Text = "GroupX[7:0] = Color[0:7]"; break;
                    case 0b_000: Rgb666ComboBox.Text = "GroupX[5:0] = Color[5:0]"; break;
                    case 0b_001: Rgb666ComboBox.Text = "GroupX[5:0] = Color[0:5]"; break;
                    case 0b_010: Rgb666ComboBox.Text = "GroupX[7:2] = Color[5:0]"; break;
                    case 0b_011: Rgb666ComboBox.Text = "GroupX[7:2] = Color[0:5]"; break;
                    default: throw new ApplicationException($"Unsupported RGB lines configuration value 0x10=0x{config:X2}.");
                }

                int group = config & 0b_0000_1111;
                
                switch (group) {
                    case 0b_0000: OrderComboBox.Text = "RGB: Red(0) - Green(1) - Blue(2)";  break;
                    case 0b_0001: OrderComboBox.Text = "RBG: Red(0) - Blue(1) - Green(2)"; break;
                    case 0b_0010: OrderComboBox.Text = "GRB: Green(0) - Red(1) - Blue(2)"; break;
                    case 0b_0011: OrderComboBox.Text = "GBR: Green(0) - Blue(1) - Red(2)"; break;
                    case 0b_0100: OrderComboBox.Text = "BRG: Blue(0) - Red(1) - Green(2)"; break;
                    case 0b_0101: OrderComboBox.Text = "BGR: Blue(0) - Green(1) - Red(2)"; break;
                    default: throw new ApplicationException($"Unsupported RGB line order (0x10=0x{config:X2}).");
                }
            } else {
                RfcFunctionCheckBox.Checked = false;
                Rgb666ComboBox.Text = "";
                Rgb888ComboBox.Text = "";
                OrderComboBox.Text = "";
            }

            // Phase adjust
            if (settings.ContainsKey(0x11)) {
                byte phaseAdjust = settings[0x11];

                switch (phaseAdjust) {
                    case 0b_1000_1000: RgbClkPhaseAdjustComboBox.Text = "0"; break;
                    case 0b_1001_1000: RgbClkPhaseAdjustComboBox.Text = "1/4"; break;
                    case 0b_1010_1000: RgbClkPhaseAdjustComboBox.Text = "1/2"; break;
                    case 0b_1011_1000: RgbClkPhaseAdjustComboBox.Text = "3/4"; break;
                    default: throw new ApplicationException($"Unsupported phase adjust value (0x11=0x{phaseAdjust:X2}).");
                }
            } else {
                RgbClkPhaseAdjustComboBox.Text = "";
            }

            // Polarity
            if (settings.ContainsKey(0x2A)) {
                byte polarity = settings[0x2A];
                TEPolarityCheckBox.Checked = (polarity & 0x01) == 0x01;
                VSyncPolarityCheckBox.Checked = (polarity & 0x02) == 0x02;
                HSyncPolarityCheckBox.Checked = (polarity & 0x04) == 0x04;
            } else {
                TEPolarityCheckBox.Checked = true;
                VSyncPolarityCheckBox.Checked = false;
                HSyncPolarityCheckBox.Checked = false;
            }

            // Test Mode
            if (settings.ContainsKey(0x14) && settings[0x14] == 0x43 && settings.ContainsKey(0x2A) && (settings[0x2A] & 0x8) == 0x8) {
                TestModeCheckBox.Checked = true;
                byte testMode = (byte)(settings[0x2A] >> 4);
                TestModeTextBox.Text = testMode.ToString();
            } else {
                TestModeCheckBox.Checked = false;
            }

            // I2C
            if (settings.ContainsKey(0x7A)) {
                byte i2c = settings[0x7A];
                MipiCommandModeRadioButton.Checked = (i2c == 0xC1);
                I2CRadioButton.Checked = !MipiCommandModeRadioButton.Checked;
            } else {
                MipiCommandModeRadioButton.Checked = false;
                I2CRadioButton.Checked = !MipiCommandModeRadioButton.Checked;
            }
        }
    }
}
