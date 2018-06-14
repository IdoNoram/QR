namespace BarQRCodeGenerator
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.metroCheckBoxTransparency = new MetroFramework.Controls.MetroCheckBox();
            this.metroTxtHeight = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroTxtWidth = new MetroFramework.Controls.MetroTextBox();
            this.metroBtnCollor = new MetroFramework.Controls.MetroButton();
            this.metroBtnImage = new MetroFramework.Controls.MetroButton();
            this.metroBtnBarCodeGenerator = new MetroFramework.Controls.MetroButton();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.metroTxtBarCode = new MetroFramework.Controls.MetroTextBox();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.metroCbxQR = new MetroFramework.Controls.MetroCheckBox();
            this.pictureBoxQR = new System.Windows.Forms.PictureBox();
            this.metroBtnSaveQRCode = new MetroFramework.Controls.MetroButton();
            this.metroBtbQrCode = new MetroFramework.Controls.MetroButton();
            this.metroTxtQrCode = new MetroFramework.Controls.MetroTextBox();
            this.metroTabPage3 = new MetroFramework.Controls.MetroTabPage();
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.metroComboBoxThemeChanger = new System.Windows.Forms.ComboBox();
            this.comboBoxStyleManager = new System.Windows.Forms.ComboBox();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.metroTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxQR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Controls.Add(this.metroTabPage2);
            this.metroTabControl1.Controls.Add(this.metroTabPage3);
            this.metroTabControl1.Location = new System.Drawing.Point(5, 77);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(732, 390);
            this.metroTabControl1.TabIndex = 0;
            this.metroTabControl1.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.metroCheckBoxTransparency);
            this.metroTabPage1.Controls.Add(this.metroTxtHeight);
            this.metroTabPage1.Controls.Add(this.metroLabel2);
            this.metroTabPage1.Controls.Add(this.metroLabel1);
            this.metroTabPage1.Controls.Add(this.metroTxtWidth);
            this.metroTabPage1.Controls.Add(this.metroBtnCollor);
            this.metroTabPage1.Controls.Add(this.metroBtnImage);
            this.metroTabPage1.Controls.Add(this.metroBtnBarCodeGenerator);
            this.metroTabPage1.Controls.Add(this.pictureBox);
            this.metroTabPage1.Controls.Add(this.metroTxtBarCode);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(724, 348);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "BarCode";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // metroCheckBoxTransparency
            // 
            this.metroCheckBoxTransparency.AutoSize = true;
            this.metroCheckBoxTransparency.Location = new System.Drawing.Point(311, 140);
            this.metroCheckBoxTransparency.Name = "metroCheckBoxTransparency";
            this.metroCheckBoxTransparency.Size = new System.Drawing.Size(165, 15);
            this.metroCheckBoxTransparency.TabIndex = 12;
            this.metroCheckBoxTransparency.Text = "Make BarCode Transparent";
            this.metroCheckBoxTransparency.UseSelectable = true;
            // 
            // metroTxtHeight
            // 
            // 
            // 
            // 
            this.metroTxtHeight.CustomButton.Image = null;
            this.metroTxtHeight.CustomButton.Location = new System.Drawing.Point(65, 1);
            this.metroTxtHeight.CustomButton.Name = "";
            this.metroTxtHeight.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTxtHeight.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTxtHeight.CustomButton.TabIndex = 1;
            this.metroTxtHeight.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTxtHeight.CustomButton.UseSelectable = true;
            this.metroTxtHeight.CustomButton.Visible = false;
            this.metroTxtHeight.Lines = new string[0];
            this.metroTxtHeight.Location = new System.Drawing.Point(389, 101);
            this.metroTxtHeight.MaxLength = 32767;
            this.metroTxtHeight.Name = "metroTxtHeight";
            this.metroTxtHeight.PasswordChar = '\0';
            this.metroTxtHeight.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTxtHeight.SelectedText = "";
            this.metroTxtHeight.SelectionLength = 0;
            this.metroTxtHeight.SelectionStart = 0;
            this.metroTxtHeight.ShortcutsEnabled = true;
            this.metroTxtHeight.Size = new System.Drawing.Size(87, 23);
            this.metroTxtHeight.TabIndex = 11;
            this.metroTxtHeight.UseSelectable = true;
            this.metroTxtHeight.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTxtHeight.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.metroTxtHeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.metroTxtHeight_KeyPress);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(314, 101);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(69, 19);
            this.metroLabel2.TabIndex = 10;
            this.metroLabel2.Text = "Set Height";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(311, 63);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(66, 19);
            this.metroLabel1.TabIndex = 9;
            this.metroLabel1.Text = "Set Width";
            // 
            // metroTxtWidth
            // 
            // 
            // 
            // 
            this.metroTxtWidth.CustomButton.Image = null;
            this.metroTxtWidth.CustomButton.Location = new System.Drawing.Point(65, 1);
            this.metroTxtWidth.CustomButton.Name = "";
            this.metroTxtWidth.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTxtWidth.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTxtWidth.CustomButton.TabIndex = 1;
            this.metroTxtWidth.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTxtWidth.CustomButton.UseSelectable = true;
            this.metroTxtWidth.CustomButton.Visible = false;
            this.metroTxtWidth.Lines = new string[0];
            this.metroTxtWidth.Location = new System.Drawing.Point(389, 63);
            this.metroTxtWidth.MaxLength = 32767;
            this.metroTxtWidth.Name = "metroTxtWidth";
            this.metroTxtWidth.PasswordChar = '\0';
            this.metroTxtWidth.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTxtWidth.SelectedText = "";
            this.metroTxtWidth.SelectionLength = 0;
            this.metroTxtWidth.SelectionStart = 0;
            this.metroTxtWidth.ShortcutsEnabled = true;
            this.metroTxtWidth.Size = new System.Drawing.Size(87, 23);
            this.metroTxtWidth.TabIndex = 8;
            this.metroTxtWidth.UseSelectable = true;
            this.metroTxtWidth.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTxtWidth.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.metroTxtWidth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.metroTxtWidth_KeyPress);
            // 
            // metroBtnCollor
            // 
            this.metroBtnCollor.Location = new System.Drawing.Point(289, 213);
            this.metroBtnCollor.Name = "metroBtnCollor";
            this.metroBtnCollor.Size = new System.Drawing.Size(118, 60);
            this.metroBtnCollor.TabIndex = 7;
            this.metroBtnCollor.Text = "Set BarCode Color";
            this.metroBtnCollor.UseSelectable = true;
            this.metroBtnCollor.Click += new System.EventHandler(this.metroBtnCollor_Click);
            // 
            // metroBtnImage
            // 
            this.metroBtnImage.Location = new System.Drawing.Point(426, 213);
            this.metroBtnImage.Name = "metroBtnImage";
            this.metroBtnImage.Size = new System.Drawing.Size(118, 60);
            this.metroBtnImage.TabIndex = 5;
            this.metroBtnImage.Text = "Save as Image";
            this.metroBtnImage.UseSelectable = true;
            this.metroBtnImage.Click += new System.EventHandler(this.metroBtnImage_Click);
            // 
            // metroBtnBarCodeGenerator
            // 
            this.metroBtnBarCodeGenerator.Location = new System.Drawing.Point(314, 18);
            this.metroBtnBarCodeGenerator.Name = "metroBtnBarCodeGenerator";
            this.metroBtnBarCodeGenerator.Size = new System.Drawing.Size(220, 23);
            this.metroBtnBarCodeGenerator.TabIndex = 4;
            this.metroBtnBarCodeGenerator.Text = "Generate BarCode";
            this.metroBtnBarCodeGenerator.UseSelectable = true;
            this.metroBtnBarCodeGenerator.Click += new System.EventHandler(this.metroBtnBarCodeGenerator_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(3, 63);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(280, 210);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 3;
            this.pictureBox.TabStop = false;
            // 
            // metroTxtBarCode
            // 
            // 
            // 
            // 
            this.metroTxtBarCode.CustomButton.Image = null;
            this.metroTxtBarCode.CustomButton.Location = new System.Drawing.Point(255, 1);
            this.metroTxtBarCode.CustomButton.Name = "";
            this.metroTxtBarCode.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTxtBarCode.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTxtBarCode.CustomButton.TabIndex = 1;
            this.metroTxtBarCode.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTxtBarCode.CustomButton.UseSelectable = true;
            this.metroTxtBarCode.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.metroTxtBarCode.Lines = new string[0];
            this.metroTxtBarCode.Location = new System.Drawing.Point(3, 18);
            this.metroTxtBarCode.MaxLength = 32767;
            this.metroTxtBarCode.Name = "metroTxtBarCode";
            this.metroTxtBarCode.PasswordChar = '\0';
            this.metroTxtBarCode.PromptText = "Type your value";
            this.metroTxtBarCode.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTxtBarCode.SelectedText = "";
            this.metroTxtBarCode.SelectionLength = 0;
            this.metroTxtBarCode.SelectionStart = 0;
            this.metroTxtBarCode.ShortcutsEnabled = true;
            this.metroTxtBarCode.ShowButton = true;
            this.metroTxtBarCode.ShowClearButton = true;
            this.metroTxtBarCode.Size = new System.Drawing.Size(277, 23);
            this.metroTxtBarCode.TabIndex = 2;
            this.metroTxtBarCode.UseSelectable = true;
            this.metroTxtBarCode.WaterMark = "Type your value";
            this.metroTxtBarCode.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTxtBarCode.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.metroCbxQR);
            this.metroTabPage2.Controls.Add(this.pictureBoxQR);
            this.metroTabPage2.Controls.Add(this.metroBtnSaveQRCode);
            this.metroTabPage2.Controls.Add(this.metroBtbQrCode);
            this.metroTabPage2.Controls.Add(this.metroTxtQrCode);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(724, 348);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "QR Code";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            // 
            // metroCbxQR
            // 
            this.metroCbxQR.AutoSize = true;
            this.metroCbxQR.Location = new System.Drawing.Point(321, 71);
            this.metroCbxQR.Name = "metroCbxQR";
            this.metroCbxQR.Size = new System.Drawing.Size(104, 15);
            this.metroCbxQR.TabIndex = 16;
            this.metroCbxQR.Text = "Set Transparent";
            this.metroCbxQR.UseSelectable = true;
            // 
            // pictureBoxQR
            // 
            this.pictureBoxQR.Location = new System.Drawing.Point(3, 60);
            this.pictureBoxQR.Name = "pictureBoxQR";
            this.pictureBoxQR.Size = new System.Drawing.Size(277, 226);
            this.pictureBoxQR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxQR.TabIndex = 10;
            this.pictureBoxQR.TabStop = false;
            // 
            // metroBtnSaveQRCode
            // 
            this.metroBtnSaveQRCode.Location = new System.Drawing.Point(312, 118);
            this.metroBtnSaveQRCode.Name = "metroBtnSaveQRCode";
            this.metroBtnSaveQRCode.Size = new System.Drawing.Size(210, 41);
            this.metroBtnSaveQRCode.TabIndex = 8;
            this.metroBtnSaveQRCode.Text = "Save as Image";
            this.metroBtnSaveQRCode.UseSelectable = true;
            this.metroBtnSaveQRCode.Click += new System.EventHandler(this.metroBtnSaveQRCode_Click);
            // 
            // metroBtbQrCode
            // 
            this.metroBtbQrCode.Location = new System.Drawing.Point(321, 19);
            this.metroBtbQrCode.Name = "metroBtbQrCode";
            this.metroBtbQrCode.Size = new System.Drawing.Size(210, 23);
            this.metroBtbQrCode.TabIndex = 7;
            this.metroBtbQrCode.Text = "Generate QR Code";
            this.metroBtbQrCode.UseSelectable = true;
            this.metroBtbQrCode.Click += new System.EventHandler(this.metroBtbQrCode_Click);
            // 
            // metroTxtQrCode
            // 
            // 
            // 
            // 
            this.metroTxtQrCode.CustomButton.Image = null;
            this.metroTxtQrCode.CustomButton.Location = new System.Drawing.Point(255, 1);
            this.metroTxtQrCode.CustomButton.Name = "";
            this.metroTxtQrCode.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTxtQrCode.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTxtQrCode.CustomButton.TabIndex = 1;
            this.metroTxtQrCode.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTxtQrCode.CustomButton.UseSelectable = true;
            this.metroTxtQrCode.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.metroTxtQrCode.Lines = new string[0];
            this.metroTxtQrCode.Location = new System.Drawing.Point(3, 19);
            this.metroTxtQrCode.MaxLength = 32767;
            this.metroTxtQrCode.Name = "metroTxtQrCode";
            this.metroTxtQrCode.PasswordChar = '\0';
            this.metroTxtQrCode.PromptText = "Type your value";
            this.metroTxtQrCode.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTxtQrCode.SelectedText = "";
            this.metroTxtQrCode.SelectionLength = 0;
            this.metroTxtQrCode.SelectionStart = 0;
            this.metroTxtQrCode.ShortcutsEnabled = true;
            this.metroTxtQrCode.ShowButton = true;
            this.metroTxtQrCode.ShowClearButton = true;
            this.metroTxtQrCode.Size = new System.Drawing.Size(277, 23);
            this.metroTxtQrCode.TabIndex = 5;
            this.metroTxtQrCode.UseSelectable = true;
            this.metroTxtQrCode.WaterMark = "Type your value";
            this.metroTxtQrCode.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTxtQrCode.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTabPage3
            // 
            this.metroTabPage3.HorizontalScrollbarBarColor = true;
            this.metroTabPage3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.HorizontalScrollbarSize = 10;
            this.metroTabPage3.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage3.Name = "metroTabPage3";
            this.metroTabPage3.Size = new System.Drawing.Size(724, 348);
            this.metroTabPage3.TabIndex = 2;
            this.metroTabPage3.Text = "Mail Sender";
            this.metroTabPage3.VerticalScrollbarBarColor = true;
            this.metroTabPage3.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.VerticalScrollbarSize = 10;
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = this;
            // 
            // metroComboBoxThemeChanger
            // 
            this.metroComboBoxThemeChanger.FormattingEnabled = true;
            this.metroComboBoxThemeChanger.Items.AddRange(new object[] {
            "Dark",
            "Light"});
            this.metroComboBoxThemeChanger.Location = new System.Drawing.Point(601, 31);
            this.metroComboBoxThemeChanger.Name = "metroComboBoxThemeChanger";
            this.metroComboBoxThemeChanger.Size = new System.Drawing.Size(121, 21);
            this.metroComboBoxThemeChanger.TabIndex = 1;
            this.metroComboBoxThemeChanger.Text = "Choose Theme";
            this.metroComboBoxThemeChanger.SelectedIndexChanged += new System.EventHandler(this.metroComboBoxThemeChanger_SelectedIndexChanged);
            // 
            // comboBoxStyleManager
            // 
            this.comboBoxStyleManager.FormattingEnabled = true;
            this.comboBoxStyleManager.Items.AddRange(new object[] {
            "Default ",
            "Black",
            "White",
            "Silver",
            "Blue",
            "Green",
            "Lime",
            "Teal",
            "Orange",
            "Brown",
            "Pink",
            "Magenta",
            "Purple",
            "Red",
            "Yellow"});
            this.comboBoxStyleManager.Location = new System.Drawing.Point(601, 58);
            this.comboBoxStyleManager.Name = "comboBoxStyleManager";
            this.comboBoxStyleManager.Size = new System.Drawing.Size(121, 21);
            this.comboBoxStyleManager.TabIndex = 2;
            this.comboBoxStyleManager.Text = "Choose Color";
            this.comboBoxStyleManager.SelectedIndexChanged += new System.EventHandler(this.comboBoxStyleManager_SelectedIndexChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 490);
            this.Controls.Add(this.comboBoxStyleManager);
            this.Controls.Add(this.metroComboBoxThemeChanger);
            this.Controls.Add(this.metroTabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "BarQR Codes Generator";
            this.TransparencyKey = System.Drawing.Color.SkyBlue;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.metroTabPage2.ResumeLayout(false);
            this.metroTabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxQR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private MetroFramework.Controls.MetroTabPage metroTabPage3;
        private MetroFramework.Controls.MetroTextBox metroTxtBarCode;
        private System.Windows.Forms.PictureBox pictureBox;
        private MetroFramework.Controls.MetroButton metroBtnBarCodeGenerator;
        private MetroFramework.Controls.MetroButton metroBtnImage;
        private MetroFramework.Controls.MetroButton metroBtnCollor;
        private MetroFramework.Controls.MetroTextBox metroTxtHeight;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox metroTxtWidth;
        private MetroFramework.Controls.MetroButton metroBtbQrCode;
        private MetroFramework.Controls.MetroTextBox metroTxtQrCode;
        private MetroFramework.Controls.MetroButton metroBtnSaveQRCode;
        private System.Windows.Forms.PictureBox pictureBoxQR;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private System.Windows.Forms.ComboBox metroComboBoxThemeChanger;
        private System.Windows.Forms.ComboBox comboBoxStyleManager;
        private MetroFramework.Controls.MetroCheckBox metroCheckBoxTransparency;
        private MetroFramework.Controls.MetroCheckBox metroCbxQR;
    }
}