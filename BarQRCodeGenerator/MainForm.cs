using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
//
using MetroFramework.Forms;
using System.Drawing;
using System.IO;
using BarcodeLib;
using BarQRCodeGenerator.Helpers;
using BarQRCodeGenerator.Models;
using MetroFramework;
using Zen.Barcode;
using System.Net;
using System.Net.Mail;

namespace BarQRCodeGenerator
{
    public partial class MainForm : MetroForm
    {
        private Barcode barCode;
        private MemoryStream memStream;
        private EncodedImageType encodedImageType;
        private SaveFileDialog saveFileDialog;
        private Image image;

        TYPE typebarCode;

        private string fileName;
        int qrWidth = 0;
        int qrHeight = 0;

        public MainForm()
        {
            InitializeComponent();

            encodedImageType = new EncodedImageType();
            barCode = new Barcode();
            memStream = new MemoryStream();

            if (this.metroTabControl1.TabPages.Contains(metroTabPage3))
            {
                this.metroTabControl1.HideTab(metroTabPage3);
            }

            this.pictureBox.Visible = false;
            this.pictureBox.Visible = false;
            this.pictureBoxQR.Visible = false;
            this.metroBtnImage.Visible = false;
            this.metroTxtWidth.Visible = false;
            this.metroTxtHeight.Visible = false;
            this.metroLabel1.Visible = false;
            this.metroLabel2.Visible = false;
            this.metroBtnCollor.Visible = false;
            this.metroCheckBoxTransparency.Visible = false;
            this.metroBtnSaveQRCode.Visible = false;

            //QR Settings Controls
            this.metroCbxQR.Visible = false;

            this.StyleManager = metroStyleManager1;
        }

        private void metroBtnBarCodeGenerator_Click(object sender, EventArgs e)
        {
            int pictureWith = 0;
            int pictureHeight = 0;

            if (string.IsNullOrWhiteSpace(this.metroTxtBarCode.Text.Trim()))
            {
                MetroMessageBox.Show(this, "Text value field is required.", "Error Notification",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return;

            }
            if (!string.IsNullOrEmpty(this.metroTxtWidth.Text) && !string.IsNullOrEmpty(this.metroTxtHeight.Text))
            {
                pictureWith = Int32.Parse(this.metroTxtWidth.Text.Trim());
                pictureHeight = Int32.Parse(this.metroTxtHeight.Text.Trim());

                if (GeneralHelper.CheckSizes(pictureWith, pictureHeight))
                {
                    MetroMessageBox.Show(this, "Size values should be no less then 99x99 px. Please fill up again",
                        "Error Sizes", MessageBoxButtons.OKCancel, MessageBoxIcon.Hand);

                    this.metroTxtWidth.Text = string.Empty;
                    this.metroTxtHeight.Text = string.Empty;
                    return;
                }

                if (GeneralHelper.SetCorrectPictureBoxSizes(pictureWith, pictureHeight, this.pictureBox))
                {
                    MetroMessageBox.Show(this,
                        "Your size values is too large to create BarCode.\n Would You like to return to previous values?",
                        "Sizes is out of range",
                        MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    this.metroTxtWidth.Text = "";
                    this.metroTxtHeight.Text = "";
                    return;
                }

                this.pictureBox.Visible = true;
                this.metroBtnImage.Visible = true;
                this.metroTxtWidth.Visible = true;
                this.metroTxtHeight.Visible = true;
                this.metroLabel1.Visible = true;
                this.metroLabel2.Visible = true;
                this.metroBtnCollor.Visible = true;
                this.metroCheckBoxTransparency.Visible = true;

                this.pictureBox.Width = pictureWith;
                this.pictureBox.Height = pictureHeight;

                barCode.IncludeLabel = true;
                barCode.Alignment = AlignmentPositions.CENTER;
                barCode.Width = this.pictureBox.Width;
                barCode.Height = this.pictureBox.Height;
                barCode.RawData = this.metroTxtBarCode.Text.Trim();

                image = barCode.Encode(TYPE.CODE128, this.metroTxtBarCode.Text.Trim());
                this.pictureBox.Image = image;
            }

            else
            {
                this.pictureBox.Visible = true;
                this.metroBtnImage.Visible = true;
                this.metroTxtWidth.Visible = true;
                this.metroTxtHeight.Visible = true;
                this.metroLabel1.Visible = true;
                this.metroLabel2.Visible = true;
                this.metroBtnCollor.Visible = true;
                this.metroCheckBoxTransparency.Visible = true;

                barCode.IncludeLabel = true;
                barCode.Alignment = AlignmentPositions.CENTER;
                barCode.Width = this.pictureBox.Width;
                barCode.Height = this.pictureBox.Height;
                barCode.RawData = this.metroTxtBarCode.Text.Trim();
                barCode.LabelPosition = LabelPositions.BOTTOMCENTER;
                barCode.IncludeLabel = true;
                barCode.LabelFont = new Font(FontFamily.GenericSansSerif, 16);

                image = barCode.Encode(typebarCode = TYPE.CODE128, this.metroTxtBarCode.Text.Trim());
                this.pictureBox.Image = image;
            }
        }

        private void metroBtnImage_Click(object sender, EventArgs e)
        {
            try
            {
                using (saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Title = "Save Image";
                    saveFileDialog.Filter = @"Images|*.png ; *.png ; *.jpg ; *.bmp";
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        using (Bitmap bmp = new Bitmap(this.pictureBox.Width, this.pictureBox.Height))
                        {
                            pictureBox.DrawToBitmap(bmp, new Rectangle(0, 0, bmp.Width, bmp.Height));
                            pictureBox.Image = new Bitmap(this.pictureBox.Width, this.pictureBox.Height);
                            pictureBox.Image.Save(saveFileDialog.FileName);
                            if (metroCheckBoxTransparency.Checked)
                                bmp.MakeTransparent();
                            bmp.Save(saveFileDialog.FileName);

                            fileName = saveFileDialog.FileName;

                            MetroMessageBox.Show(this, fileName +
                                                       "was saved successfully", "Saving Image",
                                MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        }
                    }
                }
            }

            catch (Exception)
            {
                throw new ApplicationException("Something is gone wrong. Please try againt");
            }

            finally
            {
                saveFileDialog.Dispose();
            }
        }

        private void metroBtnCollor_Click(object sender, EventArgs e)
        {
            ColorDialog colDialog = new ColorDialog();

            if (colDialog.ShowDialog() == DialogResult.OK)
            {
                barCode.ForeColor = colDialog.Color;
            }
        }

        private void metroTxtWidth_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !(char.IsDigit(e.KeyChar) && (e.KeyChar != '.')))
            {
                e.Handled = true;
                MetroMessageBox.Show(this, " Only numbers avilable", "Type only Numbers",
                 MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            }
            else if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
                MetroMessageBox.Show(this, " Only numbers avilable", "Type only Numbers",
                 MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            }
        }

        private void metroTxtHeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            var se = sender as TextBox;

            if (!char.IsControl(e.KeyChar) && !(char.IsDigit(e.KeyChar)) && (e.KeyChar != '.'))
            {
                e.Handled = true;
                MetroMessageBox.Show(this, " Only numbers avilable", "Type only Numbers",
                 MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            }

            else if (se != null && ((e.KeyChar == '.') && ((se).Text.IndexOf('.') > -1)))
            {
                e.Handled = true;
                MetroMessageBox.Show(this, " Only numbers avilable", "Type only Numbers",
                 MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            }
        }

        //_______________QR CODE_________________________________________//
        private void metroBtbQrCode_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.metroTxtQrCode.Text.Trim()))
            {
                this.pictureBoxQR.Visible = false;
                this.metroTxtQrCode.ShowButton = false;
                MetroMessageBox.Show(this, "Text value can not be null.Please fill the field.",
                    "Value is Empty", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }

            else
            {
                this.metroCbxQR.Visible = true;
                pictureBoxQR.SizeMode = PictureBoxSizeMode.CenterImage;
                qrWidth = this.pictureBoxQR.Width;
                qrHeight = this.pictureBoxQR.Height;

                this.pictureBoxQR.Visible = true;
                this.metroTxtQrCode.ShowButton = true;
                metroBtnSaveQRCode.Visible = true;
                CodeQrBarcodeDraw qrDraw = BarcodeDrawFactory.CodeQr;
                qrDraw.GetDefaultMetrics(this.pictureBoxQR.Height + 25);
                pictureBoxQR.Image = qrDraw.Draw(this.metroTxtQrCode.Text.Trim(), this.pictureBoxQR.Height);
            }
        }

        private void metroBtnSaveQRCode_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog saveFile;
                using (saveFile = new SaveFileDialog())
                {
                    saveFile.Title = @"Save QR Code image";
                    saveFile.Filter = @"Images| *.png; *.png; *.jpg; *.jpeg";

                    if (saveFile.ShowDialog() == DialogResult.OK)
                    {
                        using (Bitmap bmp = new Bitmap(this.pictureBoxQR.Width, this.pictureBoxQR.Height))
                        {
                            if (metroCbxQR.Checked)
                                bmp.MakeTransparent();
                            pictureBoxQR.DrawToBitmap(bmp, new Rectangle(0, 0,
                                this.pictureBoxQR.Width, this.pictureBoxQR.Height));
                            pictureBoxQR.Image = new Bitmap(pictureBoxQR.Width, pictureBoxQR.Height);
                            fileName += saveFile.FileName;
                            pictureBoxQR.Image.Save(saveFile.FileName);
                            bmp.Save(saveFile.FileName);

                            MetroMessageBox.Show(this, fileName +
                                                     "was saved successfully", "Saving Image",
                              MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        }
                    }
                }
            }

            catch (Exception exception)
            {
                throw new ArgumentException(exception.Message);
            }
        }

        //_____________________________THEME & STYLE CHANGING___________________________________
        private void metroComboBoxThemeChanger_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (this.metroComboBoxThemeChanger.SelectedIndex)
            {
                case 0:
                    metroStyleManager1.Theme = MetroThemeStyle.Dark;
                    break;
                case 1:
                    metroStyleManager1.Theme = MetroThemeStyle.Light;
                    break;
            }
        }

        private void comboBoxStyleManager_SelectedIndexChanged(object sender, EventArgs e)
        {
            metroStyleManager1.Style = (MetroColorStyle)Convert.ToInt32(comboBoxStyleManager.SelectedIndex);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            comboBoxStyleManager.SelectedIndex = 4;
            metroComboBoxThemeChanger.SelectedIndex = 1;
        }
    }
}
