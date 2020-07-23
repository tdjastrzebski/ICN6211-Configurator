using System.Windows.Forms;

namespace ICN6211_Configurator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.RegistersTextBox = new System.Windows.Forms.TextBox();
            this.TimerFps = new System.Windows.Forms.Timer(this.components);
            this.MipiPNSwapGroupBox = new System.Windows.Forms.GroupBox();
            this.DisableSwapRadioButton = new System.Windows.Forms.RadioButton();
            this.EnableSwapRadioButton = new System.Windows.Forms.RadioButton();
            this.ClockCheckBox = new System.Windows.Forms.CheckBox();
            this.Lane3SwapCheckBox = new System.Windows.Forms.CheckBox();
            this.Lane2SwapCheckBox = new System.Windows.Forms.CheckBox();
            this.Lane1SwapCheckBox = new System.Windows.Forms.CheckBox();
            this.Lane0SwapCheckBox = new System.Windows.Forms.CheckBox();
            this.RgbOutputGroupBox = new System.Windows.Forms.GroupBox();
            this.OrderLabel = new System.Windows.Forms.Label();
            this.Rgb666ComboBox = new System.Windows.Forms.ComboBox();
            this.Rgb888RadioButton = new System.Windows.Forms.RadioButton();
            this.Rgb888ComboBox = new System.Windows.Forms.ComboBox();
            this.OrderComboBox = new System.Windows.Forms.ComboBox();
            this.Rgb666RadioButton = new System.Windows.Forms.RadioButton();
            this.NoteLabel = new System.Windows.Forms.Label();
            this.Group0NoteLabel = new System.Windows.Forms.Label();
            this.Group2NoteLabel = new System.Windows.Forms.Label();
            this.Group1NoteLabel = new System.Windows.Forms.Label();
            this.BasicSettingsGroupBox = new System.Windows.Forms.GroupBox();
            this.DEPolarityCheckBox = new System.Windows.Forms.CheckBox();
            this.VSyncPolarityCheckBox = new System.Windows.Forms.CheckBox();
            this.HSyncPolarityCheckBox = new System.Windows.Forms.CheckBox();
            this.RefClkTextBox = new System.Windows.Forms.TextBox();
            this.RefClkCheckBox = new System.Windows.Forms.CheckBox();
            this.RgbClkPhaseAdjustComboBox = new System.Windows.Forms.ComboBox();
            this.RgbClkPhaseAdjustLabel = new System.Windows.Forms.Label();
            this.MipiLaneNoComboBox = new System.Windows.Forms.ComboBox();
            this.MipiClkTextBox = new System.Windows.Forms.TextBox();
            this.MipiLaneNoLabel = new System.Windows.Forms.Label();
            this.MipiClkLabel = new System.Windows.Forms.Label();
            this.RgbClkLabel = new System.Windows.Forms.Label();
            this.RgbClkTextBox = new System.Windows.Forms.TextBox();
            this.VbpTextBox = new System.Windows.Forms.TextBox();
            this.VSyncTextBox = new System.Windows.Forms.TextBox();
            this.VfpTextBox = new System.Windows.Forms.TextBox();
            this.HbpTextBox = new System.Windows.Forms.TextBox();
            this.HSyncTextBox = new System.Windows.Forms.TextBox();
            this.HfpTextBox = new System.Windows.Forms.TextBox();
            this.VActiveLineTextBox = new System.Windows.Forms.TextBox();
            this.VbpLabel = new System.Windows.Forms.Label();
            this.VSyncLabel = new System.Windows.Forms.Label();
            this.VfpLabel = new System.Windows.Forms.Label();
            this.HbpLabel = new System.Windows.Forms.Label();
            this.HSyncLabel = new System.Windows.Forms.Label();
            this.HFpLabel = new System.Windows.Forms.Label();
            this.VActiveLineLabel = new System.Windows.Forms.Label();
            this.HActivePixelLabel = new System.Windows.Forms.Label();
            this.HActivePixelTextBox = new System.Windows.Forms.TextBox();
            this.RfcFunctionCheckBox = new System.Windows.Forms.CheckBox();
            this.MipiCommandModeRadioButton = new System.Windows.Forms.RadioButton();
            this.I2CRadioButton = new System.Windows.Forms.RadioButton();
            this.TestModeCheckBox = new System.Windows.Forms.CheckBox();
            this.Settings2RegistryButton = new System.Windows.Forms.Button();
            this.Registry2SettingsButton = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.FpsToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.TestModeComboBox = new System.Windows.Forms.ComboBox();
            this.MipiPNSwapGroupBox.SuspendLayout();
            this.RgbOutputGroupBox.SuspendLayout();
            this.BasicSettingsGroupBox.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // RegistersTextBox
            // 
            this.RegistersTextBox.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.RegistersTextBox.Location = new System.Drawing.Point(1064, 36);
            this.RegistersTextBox.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.RegistersTextBox.Multiline = true;
            this.RegistersTextBox.Name = "RegistersTextBox";
            this.RegistersTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.RegistersTextBox.Size = new System.Drawing.Size(192, 830);
            this.RegistersTextBox.TabIndex = 500;
            // 
            // TimerFps
            // 
            this.TimerFps.Enabled = true;
            this.TimerFps.Tick += new System.EventHandler(this.TimerFps_Tick);
            // 
            // MipiPNSwapGroupBox
            // 
            this.MipiPNSwapGroupBox.Controls.Add(this.DisableSwapRadioButton);
            this.MipiPNSwapGroupBox.Controls.Add(this.EnableSwapRadioButton);
            this.MipiPNSwapGroupBox.Controls.Add(this.ClockCheckBox);
            this.MipiPNSwapGroupBox.Controls.Add(this.Lane3SwapCheckBox);
            this.MipiPNSwapGroupBox.Controls.Add(this.Lane2SwapCheckBox);
            this.MipiPNSwapGroupBox.Controls.Add(this.Lane1SwapCheckBox);
            this.MipiPNSwapGroupBox.Controls.Add(this.Lane0SwapCheckBox);
            this.MipiPNSwapGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.MipiPNSwapGroupBox.Location = new System.Drawing.Point(456, 25);
            this.MipiPNSwapGroupBox.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.MipiPNSwapGroupBox.Name = "MipiPNSwapGroupBox";
            this.MipiPNSwapGroupBox.Padding = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.MipiPNSwapGroupBox.Size = new System.Drawing.Size(473, 197);
            this.MipiPNSwapGroupBox.TabIndex = 200;
            this.MipiPNSwapGroupBox.TabStop = false;
            this.MipiPNSwapGroupBox.Text = "MIPI P/N Swap";
            // 
            // DisableSwapRadioButton
            // 
            this.DisableSwapRadioButton.AutoSize = true;
            this.DisableSwapRadioButton.Checked = true;
            this.DisableSwapRadioButton.Location = new System.Drawing.Point(168, 53);
            this.DisableSwapRadioButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.DisableSwapRadioButton.Name = "DisableSwapRadioButton";
            this.DisableSwapRadioButton.Size = new System.Drawing.Size(95, 26);
            this.DisableSwapRadioButton.TabIndex = 202;
            this.DisableSwapRadioButton.TabStop = true;
            this.DisableSwapRadioButton.Text = "Disable";
            this.DisableSwapRadioButton.UseVisualStyleBackColor = true;
            // 
            // EnableSwapRadioButton
            // 
            this.EnableSwapRadioButton.AutoSize = true;
            this.EnableSwapRadioButton.Location = new System.Drawing.Point(36, 53);
            this.EnableSwapRadioButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.EnableSwapRadioButton.Name = "EnableSwapRadioButton";
            this.EnableSwapRadioButton.Size = new System.Drawing.Size(91, 26);
            this.EnableSwapRadioButton.TabIndex = 201;
            this.EnableSwapRadioButton.Text = "Enable";
            this.EnableSwapRadioButton.UseVisualStyleBackColor = true;
            this.EnableSwapRadioButton.CheckedChanged += new System.EventHandler(this.EnableSwapRadioButton_CheckedChanged);
            // 
            // ClockCheckBox
            // 
            this.ClockCheckBox.AutoSize = true;
            this.ClockCheckBox.Enabled = false;
            this.ClockCheckBox.Location = new System.Drawing.Point(289, 101);
            this.ClockCheckBox.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ClockCheckBox.Name = "ClockCheckBox";
            this.ClockCheckBox.Size = new System.Drawing.Size(81, 26);
            this.ClockCheckBox.TabIndex = 207;
            this.ClockCheckBox.Text = "Clock";
            this.ClockCheckBox.UseVisualStyleBackColor = true;
            // 
            // Lane3SwapCheckBox
            // 
            this.Lane3SwapCheckBox.AutoSize = true;
            this.Lane3SwapCheckBox.Enabled = false;
            this.Lane3SwapCheckBox.Location = new System.Drawing.Point(168, 149);
            this.Lane3SwapCheckBox.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Lane3SwapCheckBox.Name = "Lane3SwapCheckBox";
            this.Lane3SwapCheckBox.Size = new System.Drawing.Size(86, 26);
            this.Lane3SwapCheckBox.TabIndex = 206;
            this.Lane3SwapCheckBox.Text = "Lane3";
            this.Lane3SwapCheckBox.UseVisualStyleBackColor = true;
            // 
            // Lane2SwapCheckBox
            // 
            this.Lane2SwapCheckBox.AutoSize = true;
            this.Lane2SwapCheckBox.Enabled = false;
            this.Lane2SwapCheckBox.Location = new System.Drawing.Point(168, 101);
            this.Lane2SwapCheckBox.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Lane2SwapCheckBox.Name = "Lane2SwapCheckBox";
            this.Lane2SwapCheckBox.Size = new System.Drawing.Size(86, 26);
            this.Lane2SwapCheckBox.TabIndex = 205;
            this.Lane2SwapCheckBox.Text = "Lane2";
            this.Lane2SwapCheckBox.UseVisualStyleBackColor = true;
            // 
            // Lane1SwapCheckBox
            // 
            this.Lane1SwapCheckBox.AutoSize = true;
            this.Lane1SwapCheckBox.Enabled = false;
            this.Lane1SwapCheckBox.Location = new System.Drawing.Point(36, 149);
            this.Lane1SwapCheckBox.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Lane1SwapCheckBox.Name = "Lane1SwapCheckBox";
            this.Lane1SwapCheckBox.Size = new System.Drawing.Size(86, 26);
            this.Lane1SwapCheckBox.TabIndex = 204;
            this.Lane1SwapCheckBox.Text = "Lane1";
            this.Lane1SwapCheckBox.UseVisualStyleBackColor = true;
            // 
            // Lane0SwapCheckBox
            // 
            this.Lane0SwapCheckBox.AutoSize = true;
            this.Lane0SwapCheckBox.Enabled = false;
            this.Lane0SwapCheckBox.Location = new System.Drawing.Point(36, 101);
            this.Lane0SwapCheckBox.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Lane0SwapCheckBox.Name = "Lane0SwapCheckBox";
            this.Lane0SwapCheckBox.Size = new System.Drawing.Size(86, 26);
            this.Lane0SwapCheckBox.TabIndex = 203;
            this.Lane0SwapCheckBox.Text = "Lane0";
            this.Lane0SwapCheckBox.UseVisualStyleBackColor = true;
            // 
            // RgbOutputGroupBox
            // 
            this.RgbOutputGroupBox.Controls.Add(this.OrderLabel);
            this.RgbOutputGroupBox.Controls.Add(this.Rgb666ComboBox);
            this.RgbOutputGroupBox.Controls.Add(this.Rgb888RadioButton);
            this.RgbOutputGroupBox.Controls.Add(this.Rgb888ComboBox);
            this.RgbOutputGroupBox.Controls.Add(this.OrderComboBox);
            this.RgbOutputGroupBox.Controls.Add(this.Rgb666RadioButton);
            this.RgbOutputGroupBox.Controls.Add(this.NoteLabel);
            this.RgbOutputGroupBox.Controls.Add(this.Group0NoteLabel);
            this.RgbOutputGroupBox.Controls.Add(this.Group2NoteLabel);
            this.RgbOutputGroupBox.Controls.Add(this.Group1NoteLabel);
            this.RgbOutputGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.RgbOutputGroupBox.Location = new System.Drawing.Point(456, 234);
            this.RgbOutputGroupBox.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.RgbOutputGroupBox.Name = "RgbOutputGroupBox";
            this.RgbOutputGroupBox.Padding = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.RgbOutputGroupBox.Size = new System.Drawing.Size(473, 321);
            this.RgbOutputGroupBox.TabIndex = 300;
            this.RgbOutputGroupBox.TabStop = false;
            this.RgbOutputGroupBox.Text = "RGB Output";
            // 
            // OrderLabel
            // 
            this.OrderLabel.AutoSize = true;
            this.OrderLabel.Location = new System.Drawing.Point(14, 35);
            this.OrderLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.OrderLabel.Name = "OrderLabel";
            this.OrderLabel.Size = new System.Drawing.Size(119, 22);
            this.OrderLabel.TabIndex = 301;
            this.OrderLabel.Text = "Order (group)";
            // 
            // Rgb666ComboBox
            // 
            this.Rgb666ComboBox.DisplayMember = "Text";
            this.Rgb666ComboBox.FormattingEnabled = true;
            this.Rgb666ComboBox.Location = new System.Drawing.Point(144, 127);
            this.Rgb666ComboBox.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Rgb666ComboBox.Name = "Rgb666ComboBox";
            this.Rgb666ComboBox.Size = new System.Drawing.Size(307, 30);
            this.Rgb666ComboBox.TabIndex = 310;
            this.Rgb666ComboBox.ValueMember = "Value";
            // 
            // Rgb888RadioButton
            // 
            this.Rgb888RadioButton.AutoSize = true;
            this.Rgb888RadioButton.Checked = true;
            this.Rgb888RadioButton.Location = new System.Drawing.Point(18, 81);
            this.Rgb888RadioButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Rgb888RadioButton.Name = "Rgb888RadioButton";
            this.Rgb888RadioButton.Size = new System.Drawing.Size(104, 26);
            this.Rgb888RadioButton.TabIndex = 307;
            this.Rgb888RadioButton.TabStop = true;
            this.Rgb888RadioButton.Text = "RGB888";
            this.Rgb888RadioButton.UseVisualStyleBackColor = true;
            // 
            // Rgb888ComboBox
            // 
            this.Rgb888ComboBox.DisplayMember = "Text";
            this.Rgb888ComboBox.FormattingEnabled = true;
            this.Rgb888ComboBox.Location = new System.Drawing.Point(144, 79);
            this.Rgb888ComboBox.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Rgb888ComboBox.Name = "Rgb888ComboBox";
            this.Rgb888ComboBox.Size = new System.Drawing.Size(307, 30);
            this.Rgb888ComboBox.TabIndex = 308;
            this.Rgb888ComboBox.ValueMember = "Value";
            // 
            // OrderComboBox
            // 
            this.OrderComboBox.DisplayMember = "Text";
            this.OrderComboBox.FormattingEnabled = true;
            this.OrderComboBox.Location = new System.Drawing.Point(144, 33);
            this.OrderComboBox.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.OrderComboBox.Name = "OrderComboBox";
            this.OrderComboBox.Size = new System.Drawing.Size(307, 30);
            this.OrderComboBox.TabIndex = 302;
            this.OrderComboBox.ValueMember = "Value";
            // 
            // Rgb666RadioButton
            // 
            this.Rgb666RadioButton.AutoSize = true;
            this.Rgb666RadioButton.Location = new System.Drawing.Point(18, 128);
            this.Rgb666RadioButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Rgb666RadioButton.Name = "Rgb666RadioButton";
            this.Rgb666RadioButton.Size = new System.Drawing.Size(104, 26);
            this.Rgb666RadioButton.TabIndex = 309;
            this.Rgb666RadioButton.Text = "RGB666";
            this.Rgb666RadioButton.UseVisualStyleBackColor = true;
            // 
            // NoteLabel
            // 
            this.NoteLabel.AutoSize = true;
            this.NoteLabel.Location = new System.Drawing.Point(14, 177);
            this.NoteLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NoteLabel.Name = "NoteLabel";
            this.NoteLabel.Size = new System.Drawing.Size(53, 22);
            this.NoteLabel.TabIndex = 311;
            this.NoteLabel.Text = "Note:";
            // 
            // Group0NoteLabel
            // 
            this.Group0NoteLabel.AutoSize = true;
            this.Group0NoteLabel.Location = new System.Drawing.Point(140, 177);
            this.Group0NoteLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Group0NoteLabel.Name = "Group0NoteLabel";
            this.Group0NoteLabel.Size = new System.Drawing.Size(199, 22);
            this.Group0NoteLabel.TabIndex = 312;
            this.Group0NoteLabel.Text = "Group0[7:0] = Data[7:0]";
            // 
            // Group2NoteLabel
            // 
            this.Group2NoteLabel.AutoSize = true;
            this.Group2NoteLabel.Location = new System.Drawing.Point(142, 271);
            this.Group2NoteLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Group2NoteLabel.Name = "Group2NoteLabel";
            this.Group2NoteLabel.Size = new System.Drawing.Size(219, 22);
            this.Group2NoteLabel.TabIndex = 314;
            this.Group2NoteLabel.Text = "Group2[7:0] = Data[23:16]";
            // 
            // Group1NoteLabel
            // 
            this.Group1NoteLabel.AutoSize = true;
            this.Group1NoteLabel.Location = new System.Drawing.Point(142, 224);
            this.Group1NoteLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Group1NoteLabel.Name = "Group1NoteLabel";
            this.Group1NoteLabel.Size = new System.Drawing.Size(209, 22);
            this.Group1NoteLabel.TabIndex = 313;
            this.Group1NoteLabel.Text = "Group1[7:0] = Data[15:8]";
            // 
            // BasicSettingsGroupBox
            // 
            this.BasicSettingsGroupBox.Controls.Add(this.DEPolarityCheckBox);
            this.BasicSettingsGroupBox.Controls.Add(this.VSyncPolarityCheckBox);
            this.BasicSettingsGroupBox.Controls.Add(this.HSyncPolarityCheckBox);
            this.BasicSettingsGroupBox.Controls.Add(this.RefClkTextBox);
            this.BasicSettingsGroupBox.Controls.Add(this.RefClkCheckBox);
            this.BasicSettingsGroupBox.Controls.Add(this.RgbClkPhaseAdjustComboBox);
            this.BasicSettingsGroupBox.Controls.Add(this.RgbClkPhaseAdjustLabel);
            this.BasicSettingsGroupBox.Controls.Add(this.MipiLaneNoComboBox);
            this.BasicSettingsGroupBox.Controls.Add(this.MipiClkTextBox);
            this.BasicSettingsGroupBox.Controls.Add(this.MipiLaneNoLabel);
            this.BasicSettingsGroupBox.Controls.Add(this.MipiClkLabel);
            this.BasicSettingsGroupBox.Controls.Add(this.RgbClkLabel);
            this.BasicSettingsGroupBox.Controls.Add(this.RgbClkTextBox);
            this.BasicSettingsGroupBox.Controls.Add(this.VbpTextBox);
            this.BasicSettingsGroupBox.Controls.Add(this.VSyncTextBox);
            this.BasicSettingsGroupBox.Controls.Add(this.VfpTextBox);
            this.BasicSettingsGroupBox.Controls.Add(this.HbpTextBox);
            this.BasicSettingsGroupBox.Controls.Add(this.HSyncTextBox);
            this.BasicSettingsGroupBox.Controls.Add(this.HfpTextBox);
            this.BasicSettingsGroupBox.Controls.Add(this.VActiveLineTextBox);
            this.BasicSettingsGroupBox.Controls.Add(this.VbpLabel);
            this.BasicSettingsGroupBox.Controls.Add(this.VSyncLabel);
            this.BasicSettingsGroupBox.Controls.Add(this.VfpLabel);
            this.BasicSettingsGroupBox.Controls.Add(this.HbpLabel);
            this.BasicSettingsGroupBox.Controls.Add(this.HSyncLabel);
            this.BasicSettingsGroupBox.Controls.Add(this.HFpLabel);
            this.BasicSettingsGroupBox.Controls.Add(this.VActiveLineLabel);
            this.BasicSettingsGroupBox.Controls.Add(this.HActivePixelLabel);
            this.BasicSettingsGroupBox.Controls.Add(this.HActivePixelTextBox);
            this.BasicSettingsGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BasicSettingsGroupBox.Location = new System.Drawing.Point(26, 25);
            this.BasicSettingsGroupBox.Name = "BasicSettingsGroupBox";
            this.BasicSettingsGroupBox.Size = new System.Drawing.Size(406, 842);
            this.BasicSettingsGroupBox.TabIndex = 100;
            this.BasicSettingsGroupBox.TabStop = false;
            this.BasicSettingsGroupBox.Text = "Basic Settings";
            // 
            // DEPolarityCheckBox
            // 
            this.DEPolarityCheckBox.AutoSize = true;
            this.DEPolarityCheckBox.Checked = true;
            this.DEPolarityCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.DEPolarityCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DEPolarityCheckBox.Location = new System.Drawing.Point(38, 528);
            this.DEPolarityCheckBox.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.DEPolarityCheckBox.Name = "DEPolarityCheckBox";
            this.DEPolarityCheckBox.Size = new System.Drawing.Size(124, 26);
            this.DEPolarityCheckBox.TabIndex = 121;
            this.DEPolarityCheckBox.Text = "DE polarity";
            this.DEPolarityCheckBox.UseVisualStyleBackColor = true;
            // 
            // VSyncPolarityCheckBox
            // 
            this.VSyncPolarityCheckBox.AutoSize = true;
            this.VSyncPolarityCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.VSyncPolarityCheckBox.Location = new System.Drawing.Point(38, 631);
            this.VSyncPolarityCheckBox.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.VSyncPolarityCheckBox.Name = "VSyncPolarityCheckBox";
            this.VSyncPolarityCheckBox.Size = new System.Drawing.Size(151, 26);
            this.VSyncPolarityCheckBox.TabIndex = 123;
            this.VSyncPolarityCheckBox.Text = "VSync polarity";
            this.VSyncPolarityCheckBox.UseVisualStyleBackColor = true;
            // 
            // HSyncPolarityCheckBox
            // 
            this.HSyncPolarityCheckBox.AutoSize = true;
            this.HSyncPolarityCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.HSyncPolarityCheckBox.Location = new System.Drawing.Point(38, 580);
            this.HSyncPolarityCheckBox.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.HSyncPolarityCheckBox.Name = "HSyncPolarityCheckBox";
            this.HSyncPolarityCheckBox.Size = new System.Drawing.Size(152, 26);
            this.HSyncPolarityCheckBox.TabIndex = 122;
            this.HSyncPolarityCheckBox.Text = "HSync polarity";
            this.HSyncPolarityCheckBox.UseVisualStyleBackColor = true;
            // 
            // RefClkTextBox
            // 
            this.RefClkTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.RefClkTextBox.Location = new System.Drawing.Point(289, 776);
            this.RefClkTextBox.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.RefClkTextBox.MaxLength = 3;
            this.RefClkTextBox.Name = "RefClkTextBox";
            this.RefClkTextBox.Size = new System.Drawing.Size(80, 28);
            this.RefClkTextBox.TabIndex = 129;
            this.RefClkTextBox.Text = "26";
            // 
            // RefClkCheckBox
            // 
            this.RefClkCheckBox.AutoSize = true;
            this.RefClkCheckBox.Checked = true;
            this.RefClkCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.RefClkCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.RefClkCheckBox.Location = new System.Drawing.Point(40, 778);
            this.RefClkCheckBox.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.RefClkCheckBox.Name = "RefClkCheckBox";
            this.RefClkCheckBox.Size = new System.Drawing.Size(162, 26);
            this.RefClkCheckBox.TabIndex = 128;
            this.RefClkCheckBox.Text = "Ref clock (MHz)";
            this.RefClkCheckBox.UseVisualStyleBackColor = true;
            this.RefClkCheckBox.CheckedChanged += new System.EventHandler(this.RefClkCheckBox_CheckedChanged);
            // 
            // RgbClkPhaseAdjustComboBox
            // 
            this.RgbClkPhaseAdjustComboBox.DisplayMember = "Text";
            this.RgbClkPhaseAdjustComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.RgbClkPhaseAdjustComboBox.FormattingEnabled = true;
            this.RgbClkPhaseAdjustComboBox.Location = new System.Drawing.Point(289, 477);
            this.RgbClkPhaseAdjustComboBox.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.RgbClkPhaseAdjustComboBox.Name = "RgbClkPhaseAdjustComboBox";
            this.RgbClkPhaseAdjustComboBox.Size = new System.Drawing.Size(80, 30);
            this.RgbClkPhaseAdjustComboBox.TabIndex = 120;
            this.RgbClkPhaseAdjustComboBox.ValueMember = "Value";
            // 
            // RgbClkPhaseAdjustLabel
            // 
            this.RgbClkPhaseAdjustLabel.AutoSize = true;
            this.RgbClkPhaseAdjustLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.RgbClkPhaseAdjustLabel.Location = new System.Drawing.Point(40, 481);
            this.RgbClkPhaseAdjustLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RgbClkPhaseAdjustLabel.Name = "RgbClkPhaseAdjustLabel";
            this.RgbClkPhaseAdjustLabel.Size = new System.Drawing.Size(202, 22);
            this.RgbClkPhaseAdjustLabel.TabIndex = 119;
            this.RgbClkPhaseAdjustLabel.Text = "RGB clock phase adjust";
            // 
            // MipiLaneNoComboBox
            // 
            this.MipiLaneNoComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.MipiLaneNoComboBox.FormattingEnabled = true;
            this.MipiLaneNoComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.MipiLaneNoComboBox.Location = new System.Drawing.Point(289, 727);
            this.MipiLaneNoComboBox.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.MipiLaneNoComboBox.Name = "MipiLaneNoComboBox";
            this.MipiLaneNoComboBox.Size = new System.Drawing.Size(80, 30);
            this.MipiLaneNoComboBox.TabIndex = 127;
            this.MipiLaneNoComboBox.Text = "2";
            // 
            // MipiClkTextBox
            // 
            this.MipiClkTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.MipiClkTextBox.Location = new System.Drawing.Point(289, 680);
            this.MipiClkTextBox.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.MipiClkTextBox.MaxLength = 3;
            this.MipiClkTextBox.Name = "MipiClkTextBox";
            this.MipiClkTextBox.Size = new System.Drawing.Size(80, 28);
            this.MipiClkTextBox.TabIndex = 125;
            this.MipiClkTextBox.Text = "100";
            // 
            // MipiLaneNoLabel
            // 
            this.MipiLaneNoLabel.AutoSize = true;
            this.MipiLaneNoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.MipiLaneNoLabel.Location = new System.Drawing.Point(40, 730);
            this.MipiLaneNoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MipiLaneNoLabel.Name = "MipiLaneNoLabel";
            this.MipiLaneNoLabel.Size = new System.Drawing.Size(113, 22);
            this.MipiLaneNoLabel.TabIndex = 126;
            this.MipiLaneNoLabel.Text = "MIPI lane no.";
            // 
            // MipiClkLabel
            // 
            this.MipiClkLabel.AutoSize = true;
            this.MipiClkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.MipiClkLabel.Location = new System.Drawing.Point(40, 683);
            this.MipiClkLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MipiClkLabel.Name = "MipiClkLabel";
            this.MipiClkLabel.Size = new System.Drawing.Size(142, 22);
            this.MipiClkLabel.TabIndex = 124;
            this.MipiClkLabel.Text = "MIPI clock (MHz)";
            // 
            // RgbClkLabel
            // 
            this.RgbClkLabel.AutoSize = true;
            this.RgbClkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.RgbClkLabel.Location = new System.Drawing.Point(40, 433);
            this.RgbClkLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RgbClkLabel.Name = "RgbClkLabel";
            this.RgbClkLabel.Size = new System.Drawing.Size(147, 22);
            this.RgbClkLabel.TabIndex = 117;
            this.RgbClkLabel.Text = "RGB clock (MHz)";
            // 
            // RgbClkTextBox
            // 
            this.RgbClkTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.RgbClkTextBox.Location = new System.Drawing.Point(289, 430);
            this.RgbClkTextBox.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.RgbClkTextBox.MaxLength = 6;
            this.RgbClkTextBox.Name = "RgbClkTextBox";
            this.RgbClkTextBox.Size = new System.Drawing.Size(80, 28);
            this.RgbClkTextBox.TabIndex = 118;
            this.RgbClkTextBox.Text = "34.125";
            // 
            // VbpTextBox
            // 
            this.VbpTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.VbpTextBox.Location = new System.Drawing.Point(289, 383);
            this.VbpTextBox.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.VbpTextBox.MaxLength = 3;
            this.VbpTextBox.Name = "VbpTextBox";
            this.VbpTextBox.Size = new System.Drawing.Size(80, 28);
            this.VbpTextBox.TabIndex = 116;
            this.VbpTextBox.Text = "32";
            // 
            // VSyncTextBox
            // 
            this.VSyncTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.VSyncTextBox.Location = new System.Drawing.Point(289, 336);
            this.VSyncTextBox.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.VSyncTextBox.MaxLength = 3;
            this.VSyncTextBox.Name = "VSyncTextBox";
            this.VSyncTextBox.Size = new System.Drawing.Size(80, 28);
            this.VSyncTextBox.TabIndex = 114;
            this.VSyncTextBox.Text = "3";
            // 
            // VfpTextBox
            // 
            this.VfpTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.VfpTextBox.Location = new System.Drawing.Point(289, 288);
            this.VfpTextBox.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.VfpTextBox.MaxLength = 3;
            this.VfpTextBox.Name = "VfpTextBox";
            this.VfpTextBox.Size = new System.Drawing.Size(80, 28);
            this.VfpTextBox.TabIndex = 112;
            this.VfpTextBox.Text = "13";
            // 
            // HbpTextBox
            // 
            this.HbpTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.HbpTextBox.Location = new System.Drawing.Point(289, 241);
            this.HbpTextBox.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.HbpTextBox.MaxLength = 3;
            this.HbpTextBox.Name = "HbpTextBox";
            this.HbpTextBox.Size = new System.Drawing.Size(80, 28);
            this.HbpTextBox.TabIndex = 110;
            this.HbpTextBox.Text = "88";
            // 
            // HSyncTextBox
            // 
            this.HSyncTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.HSyncTextBox.Location = new System.Drawing.Point(289, 194);
            this.HSyncTextBox.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.HSyncTextBox.MaxLength = 3;
            this.HSyncTextBox.Name = "HSyncTextBox";
            this.HSyncTextBox.Size = new System.Drawing.Size(80, 28);
            this.HSyncTextBox.TabIndex = 108;
            this.HSyncTextBox.Text = "48";
            // 
            // HfpTextBox
            // 
            this.HfpTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.HfpTextBox.Location = new System.Drawing.Point(289, 146);
            this.HfpTextBox.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.HfpTextBox.MaxLength = 3;
            this.HfpTextBox.Name = "HfpTextBox";
            this.HfpTextBox.Size = new System.Drawing.Size(80, 28);
            this.HfpTextBox.TabIndex = 106;
            this.HfpTextBox.Text = "40";
            // 
            // VActiveLineTextBox
            // 
            this.VActiveLineTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.VActiveLineTextBox.Location = new System.Drawing.Point(289, 99);
            this.VActiveLineTextBox.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.VActiveLineTextBox.MaxLength = 4;
            this.VActiveLineTextBox.Name = "VActiveLineTextBox";
            this.VActiveLineTextBox.Size = new System.Drawing.Size(80, 28);
            this.VActiveLineTextBox.TabIndex = 104;
            this.VActiveLineTextBox.Text = "480";
            // 
            // VbpLabel
            // 
            this.VbpLabel.AutoSize = true;
            this.VbpLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.VbpLabel.Location = new System.Drawing.Point(40, 386);
            this.VbpLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.VbpLabel.Name = "VbpLabel";
            this.VbpLabel.Size = new System.Drawing.Size(46, 22);
            this.VbpLabel.TabIndex = 115;
            this.VbpLabel.Text = "VBP";
            // 
            // VSyncLabel
            // 
            this.VSyncLabel.AutoSize = true;
            this.VSyncLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.VSyncLabel.Location = new System.Drawing.Point(40, 339);
            this.VSyncLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.VSyncLabel.Name = "VSyncLabel";
            this.VSyncLabel.Size = new System.Drawing.Size(72, 22);
            this.VSyncLabel.TabIndex = 113;
            this.VSyncLabel.Text = "VSYNC";
            // 
            // VfpLabel
            // 
            this.VfpLabel.AutoSize = true;
            this.VfpLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.VfpLabel.Location = new System.Drawing.Point(40, 292);
            this.VfpLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.VfpLabel.Name = "VfpLabel";
            this.VfpLabel.Size = new System.Drawing.Size(45, 22);
            this.VfpLabel.TabIndex = 111;
            this.VfpLabel.Text = "VFP";
            // 
            // HbpLabel
            // 
            this.HbpLabel.AutoSize = true;
            this.HbpLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.HbpLabel.Location = new System.Drawing.Point(40, 244);
            this.HbpLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.HbpLabel.Name = "HbpLabel";
            this.HbpLabel.Size = new System.Drawing.Size(47, 22);
            this.HbpLabel.TabIndex = 109;
            this.HbpLabel.Text = "HBP";
            // 
            // HSyncLabel
            // 
            this.HSyncLabel.AutoSize = true;
            this.HSyncLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.HSyncLabel.Location = new System.Drawing.Point(40, 197);
            this.HSyncLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.HSyncLabel.Name = "HSyncLabel";
            this.HSyncLabel.Size = new System.Drawing.Size(73, 22);
            this.HSyncLabel.TabIndex = 107;
            this.HSyncLabel.Text = "HSYNC";
            // 
            // HFpLabel
            // 
            this.HFpLabel.AutoSize = true;
            this.HFpLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.HFpLabel.Location = new System.Drawing.Point(40, 150);
            this.HFpLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.HFpLabel.Name = "HFpLabel";
            this.HFpLabel.Size = new System.Drawing.Size(46, 22);
            this.HFpLabel.TabIndex = 105;
            this.HFpLabel.Text = "HFP";
            // 
            // VActiveLineLabel
            // 
            this.VActiveLineLabel.AutoSize = true;
            this.VActiveLineLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.VActiveLineLabel.Location = new System.Drawing.Point(40, 102);
            this.VActiveLineLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.VActiveLineLabel.Name = "VActiveLineLabel";
            this.VActiveLineLabel.Size = new System.Drawing.Size(115, 22);
            this.VActiveLineLabel.TabIndex = 103;
            this.VActiveLineLabel.Text = "V Active Line";
            // 
            // HActivePixelLabel
            // 
            this.HActivePixelLabel.AutoSize = true;
            this.HActivePixelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.HActivePixelLabel.Location = new System.Drawing.Point(40, 55);
            this.HActivePixelLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.HActivePixelLabel.Name = "HActivePixelLabel";
            this.HActivePixelLabel.Size = new System.Drawing.Size(121, 22);
            this.HActivePixelLabel.TabIndex = 101;
            this.HActivePixelLabel.Text = "H Active Pixel";
            // 
            // HActivePixelTextBox
            // 
            this.HActivePixelTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.HActivePixelTextBox.Location = new System.Drawing.Point(289, 52);
            this.HActivePixelTextBox.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.HActivePixelTextBox.MaxLength = 4;
            this.HActivePixelTextBox.Name = "HActivePixelTextBox";
            this.HActivePixelTextBox.Size = new System.Drawing.Size(80, 28);
            this.HActivePixelTextBox.TabIndex = 102;
            this.HActivePixelTextBox.Text = "800";
            // 
            // RfcFunctionCheckBox
            // 
            this.RfcFunctionCheckBox.AutoSize = true;
            this.RfcFunctionCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.RfcFunctionCheckBox.Location = new System.Drawing.Point(474, 658);
            this.RfcFunctionCheckBox.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.RfcFunctionCheckBox.Name = "RfcFunctionCheckBox";
            this.RfcFunctionCheckBox.Size = new System.Drawing.Size(141, 26);
            this.RfcFunctionCheckBox.TabIndex = 403;
            this.RfcFunctionCheckBox.Text = "FRC function";
            this.RfcFunctionCheckBox.UseVisualStyleBackColor = true;
            // 
            // MipiCommandModeRadioButton
            // 
            this.MipiCommandModeRadioButton.AutoSize = true;
            this.MipiCommandModeRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.MipiCommandModeRadioButton.Location = new System.Drawing.Point(474, 753);
            this.MipiCommandModeRadioButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.MipiCommandModeRadioButton.Name = "MipiCommandModeRadioButton";
            this.MipiCommandModeRadioButton.Size = new System.Drawing.Size(200, 26);
            this.MipiCommandModeRadioButton.TabIndex = 405;
            this.MipiCommandModeRadioButton.Text = "MIPI command mode";
            this.MipiCommandModeRadioButton.UseVisualStyleBackColor = true;
            // 
            // I2CRadioButton
            // 
            this.I2CRadioButton.AutoSize = true;
            this.I2CRadioButton.Checked = true;
            this.I2CRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.I2CRadioButton.Location = new System.Drawing.Point(474, 703);
            this.I2CRadioButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.I2CRadioButton.Name = "I2CRadioButton";
            this.I2CRadioButton.Size = new System.Drawing.Size(62, 26);
            this.I2CRadioButton.TabIndex = 404;
            this.I2CRadioButton.TabStop = true;
            this.I2CRadioButton.Text = "I2C";
            this.I2CRadioButton.UseVisualStyleBackColor = true;
            // 
            // TestModeCheckBox
            // 
            this.TestModeCheckBox.AutoSize = true;
            this.TestModeCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TestModeCheckBox.Location = new System.Drawing.Point(474, 605);
            this.TestModeCheckBox.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.TestModeCheckBox.Name = "TestModeCheckBox";
            this.TestModeCheckBox.Size = new System.Drawing.Size(121, 26);
            this.TestModeCheckBox.TabIndex = 401;
            this.TestModeCheckBox.Text = "Test mode";
            this.TestModeCheckBox.UseVisualStyleBackColor = true;
            this.TestModeCheckBox.CheckedChanged += new System.EventHandler(this.TestModeCheckBox_CheckedChanged);
            // 
            // Settings2RegistryButton
            // 
            this.Settings2RegistryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Settings2RegistryButton.Font = new System.Drawing.Font("Wingdings", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.Settings2RegistryButton.Location = new System.Drawing.Point(958, 307);
            this.Settings2RegistryButton.Name = "Settings2RegistryButton";
            this.Settings2RegistryButton.Size = new System.Drawing.Size(80, 57);
            this.Settings2RegistryButton.TabIndex = 501;
            this.Settings2RegistryButton.Text = "";
            this.Settings2RegistryButton.UseVisualStyleBackColor = true;
            this.Settings2RegistryButton.Click += new System.EventHandler(this.Settings2RegistryButton_Click);
            // 
            // Registry2SettingsButton
            // 
            this.Registry2SettingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Registry2SettingsButton.Font = new System.Drawing.Font("Wingdings", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.Registry2SettingsButton.Location = new System.Drawing.Point(958, 402);
            this.Registry2SettingsButton.Name = "Registry2SettingsButton";
            this.Registry2SettingsButton.Size = new System.Drawing.Size(80, 57);
            this.Registry2SettingsButton.TabIndex = 502;
            this.Registry2SettingsButton.Text = "";
            this.Registry2SettingsButton.UseVisualStyleBackColor = true;
            this.Registry2SettingsButton.Click += new System.EventHandler(this.Registry2SettingsButton_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FpsToolStripStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 896);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1281, 29);
            this.statusStrip1.TabIndex = 503;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // FpsToolStripStatusLabel
            // 
            this.FpsToolStripStatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FpsToolStripStatusLabel.Name = "FpsToolStripStatusLabel";
            this.FpsToolStripStatusLabel.Size = new System.Drawing.Size(34, 22);
            this.FpsToolStripStatusLabel.Text = "fps";
            // 
            // TestModeComboBox
            // 
            this.TestModeComboBox.DisplayMember = "Text";
            this.TestModeComboBox.Enabled = false;
            this.TestModeComboBox.FormattingEnabled = true;
            this.TestModeComboBox.Location = new System.Drawing.Point(670, 603);
            this.TestModeComboBox.Name = "TestModeComboBox";
            this.TestModeComboBox.Size = new System.Drawing.Size(237, 30);
            this.TestModeComboBox.TabIndex = 402;
            this.TestModeComboBox.ValueMember = "Value";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1281, 925);
            this.Controls.Add(this.TestModeComboBox);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.Registry2SettingsButton);
            this.Controls.Add(this.Settings2RegistryButton);
            this.Controls.Add(this.TestModeCheckBox);
            this.Controls.Add(this.MipiCommandModeRadioButton);
            this.Controls.Add(this.I2CRadioButton);
            this.Controls.Add(this.RfcFunctionCheckBox);
            this.Controls.Add(this.BasicSettingsGroupBox);
            this.Controls.Add(this.RgbOutputGroupBox);
            this.Controls.Add(this.MipiPNSwapGroupBox);
            this.Controls.Add(this.RegistersTextBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "Form1";
            this.Text = "ICN6211 Configurator";
            this.MipiPNSwapGroupBox.ResumeLayout(false);
            this.MipiPNSwapGroupBox.PerformLayout();
            this.RgbOutputGroupBox.ResumeLayout(false);
            this.RgbOutputGroupBox.PerformLayout();
            this.BasicSettingsGroupBox.ResumeLayout(false);
            this.BasicSettingsGroupBox.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox RegistersTextBox;
        private Timer TimerFps;
        private GroupBox MipiPNSwapGroupBox;
        private RadioButton DisableSwapRadioButton;
        private RadioButton EnableSwapRadioButton;
        private CheckBox ClockCheckBox;
        private CheckBox Lane3SwapCheckBox;
        private CheckBox Lane2SwapCheckBox;
        private CheckBox Lane1SwapCheckBox;
        private CheckBox Lane0SwapCheckBox;
        private GroupBox RgbOutputGroupBox;
        private Label OrderLabel;
        private ComboBox Rgb666ComboBox;
        private RadioButton Rgb888RadioButton;
        private ComboBox Rgb888ComboBox;
        private ComboBox OrderComboBox;
        private RadioButton Rgb666RadioButton;
        private Label NoteLabel;
        private Label Group0NoteLabel;
        private Label Group2NoteLabel;
        private Label Group1NoteLabel;
        private GroupBox BasicSettingsGroupBox;
        private CheckBox VSyncPolarityCheckBox;
        private CheckBox HSyncPolarityCheckBox;
        private TextBox RefClkTextBox;
        private CheckBox RefClkCheckBox;
        private ComboBox RgbClkPhaseAdjustComboBox;
        private Label RgbClkPhaseAdjustLabel;
        private ComboBox MipiLaneNoComboBox;
        private TextBox MipiClkTextBox;
        private Label MipiLaneNoLabel;
        private Label MipiClkLabel;
        private Label RgbClkLabel;
        private TextBox RgbClkTextBox;
        private TextBox VbpTextBox;
        private TextBox VSyncTextBox;
        private TextBox VfpTextBox;
        private TextBox HbpTextBox;
        private TextBox HSyncTextBox;
        private TextBox HfpTextBox;
        private TextBox VActiveLineTextBox;
        private Label VbpLabel;
        private Label VSyncLabel;
        private Label VfpLabel;
        private Label HbpLabel;
        private Label HSyncLabel;
        private Label HFpLabel;
        private Label VActiveLineLabel;
        private Label HActivePixelLabel;
        private TextBox HActivePixelTextBox;
        private CheckBox RfcFunctionCheckBox;
        private RadioButton MipiCommandModeRadioButton;
        private RadioButton I2CRadioButton;
        private CheckBox DEPolarityCheckBox;
        private CheckBox TestModeCheckBox;
        private Button Settings2RegistryButton;
        private Button Registry2SettingsButton;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel FpsToolStripStatusLabel;
        private ComboBox TestModeComboBox;
    }
}
