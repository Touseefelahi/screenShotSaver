using screenShotSaver.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Resources;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

/// <forCompression>
/// For Specific Quality to save jpg image file
/// var encoder = ImageCodecInfo.GetImageEncoders().First(c => c.FormatID == ImageFormat.Jpeg.Guid);
/// var encParams = new EncoderParameters() { Param = new[] { new EncoderParameter(Encoder.Quality, 90L) } };
/// image.Save(path, encoder, encParams)
/// </forCompression>
namespace screenShotSaver
{
    public partial class screenShotSaver : Form
    {
        #region Initializations
        Bitmap dstImage, srcImage;
        string pathToImage, defImageName, imgName;
        enum extension
        {
            png = 0,
            jpg,
            bmp,
        }
        extension ext = extension.jpg;
        ushort imgCount = 1,imgCountTotal=0,emailCountTotal=0;
        bool flagByDate = false;
        Stopwatch stopWatch = new Stopwatch();
        Size originalFormSize;
        public screenShotSaver()
        {
            InitializeComponent();
            //loading configurations from settings
            defImageName = Settings.Default.NAME;
            pathToImage = Settings.Default.PATH;
            textBoxEmailID.Text = Settings.Default.Email;
            textBoxImageName.Text = Settings.Default.NAME;
            labelCurrentDirecoty.Text = "Current Directory: " + pathToImage;
            imgName = pathToImage;
        }
        #endregion

        #region General Functions
        private void saveSingleShot()
        {
            //releasing memory
            if (dstImage != null)
            {
                dstImage.Dispose();
            }
            if (srcImage != null)
            {
                srcImage.Dispose();
            }
            //checking if minimal mode is on or not
            if (!checkBoxMinMode.Checked)
            {
                this.Hide();
                Thread.Sleep(200);
            }  
                
          
            Size size = new Size(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width, System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height);
            int width = pictureBoxDisplay.Width, height = pictureBoxDisplay.Height;

            srcImage = new Bitmap(size.Width, size.Height);
            Graphics srcGraphics = Graphics.FromImage(srcImage);

            /* //Selected Region Image
            Bitmap recImage = new Bitmap(100, 100);
            Graphics recGraphics = Graphics.FromImage(recImage);
                
            Point ptStart = new Point(100, 100), ptEnd = new Point(200, 200);
            Size recSize = new Size(100, 100);
          
            recGraphics.CopyFromScreen(ptStart, ptEnd, recSize);
              */

            //this block is for display, this isn't required in minimal mode checking that are we in full mode or not
            if (!checkBoxMinMode.Checked)
            {
                //In this block we will resize the screen-shot to our picture box size for proper display
                bool scaled = (width != size.Width || height != size.Height);

                dstImage = srcImage;
                Graphics dstGraphics = srcGraphics;

                if (scaled)
                {
                    dstImage = new Bitmap(width, height);
                    dstGraphics = Graphics.FromImage(dstImage);
                }

                Rectangle src = new Rectangle(0, 0, size.Width, size.Height);
                Rectangle dst = new Rectangle(0, 0, width, height);

                srcGraphics.CopyFromScreen(0, 0, 0, 0, size);
                if (scaled)
                    dstGraphics.DrawImage(srcImage, dst, src, GraphicsUnit.Pixel);

                pictureBoxDisplay.Image = dstImage;            
                dstGraphics.Dispose();
                this.Show();
            }
            else  
            {
                srcGraphics.CopyFromScreen(0, 0, 0, 0, size);   //taking screen shot
            }
            srcGraphics.Dispose();

            if (checkBoxEmail.Checked) //checking weather to send mail or not
            {               
               Task taskMail=new Task(()=> sendMail());
               taskMail.Start();
               Thread.Sleep(100);
            }
            //in this block we will try to save the image to the required folder
            try
            {
                if (flagByDate) 
                {
                    imgName = pathToImage + DateTime.Now.ToString(@"dd\_MM\_yyyy h\_mm_ss");
                    imgCount++;
                }
                else
                {
                    defImageName = textBoxImageName.Text;
                    imgName = pathToImage + defImageName + Convert.ToString(imgCount);
                    imgCount++;
                }

                switch (ext)
                {
                    case extension.bmp:
                        srcImage.Save(imgName + ".bmp", System.Drawing.Imaging.ImageFormat.Bmp);
                        break;
                    case extension.png:
                        srcImage.Save(imgName + ".png", System.Drawing.Imaging.ImageFormat.Png);
                        break;
                    case extension.jpg:
                        srcImage.Save(imgName + ".jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
                        break;
                    default:
                        break;
                }
                imgCountTotal++;
                labelShotCounter.Text = "Counter " + Convert.ToString(imgCount-1);
                labelCurrentDirecoty.ForeColor = Color.Green;
                labelCurrentDirecoty.Text = "Saved in: " + imgName+"."+Convert.ToString(ext);
            }
            catch (Exception)
            {
                labelCurrentDirecoty.ForeColor = Color.Red;
                labelCurrentDirecoty.Invoke((MethodInvoker)(() => labelCurrentDirecoty.Text = "Directory not found or Enter Proper name"));
            }
            // this.Show();
        }
  
        private void saveMultipleShots()
        {
            uint continousShotCount = 0;
            try
            {
                Int32 time = (Int32)(numericFrequency.Value * 1000);
                while (checkBoxMultipleShots.Checked)
                {
                    stopWatch.Start();  //starting stopwatch to add the runtime delay of this process
                    if (srcImage != null)
                    {
                        srcImage.Dispose();
                    }

                    Size size = new Size(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width, System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height);
                    int width = pictureBoxDisplay.Width, height = pictureBoxDisplay.Height;

                    srcImage = new Bitmap(size.Width, size.Height);
                    Graphics srcGraphics = Graphics.FromImage(srcImage);
                    srcGraphics.CopyFromScreen(0, 0, 0, 0, size);
                    srcGraphics.Dispose();
                    pictureBoxDisplay.Image = srcImage;  //displaying full frame, we can see the portion of image
                    try
                    {
                        if (flagByDate)
                        {
                            imgName = pathToImage + DateTime.Now.ToString(@"dd\_MM\_yyyy h\_mm_ss");
                            imgCount++;
                        }
                        else
                        {
                            defImageName = textBoxImageName.Text;
                            imgName = pathToImage + defImageName + Convert.ToString(imgCount);
                            imgCount++;
                        }

                        switch (ext)
                        {
                            case extension.bmp:
                                srcImage.Save(imgName + ".bmp", System.Drawing.Imaging.ImageFormat.Bmp);
                                break;
                            case extension.png:
                                srcImage.Save(imgName + ".png", System.Drawing.Imaging.ImageFormat.Png);
                                break;
                            case extension.jpg:
                                srcImage.Save(imgName + ".jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
                                break;
                            default:
                                break;
                        }
                        time = (Int32)(numericFrequency.Value * 1000);
                    }

                    catch (Exception)
                    {
                        labelCurrentDirecoty.ForeColor = Color.Red;
                        labelCurrentDirecoty.Invoke((MethodInvoker)(() => labelCurrentDirecoty.Text = "Directory not found or Enter Proper name"));
                    }

                    labelShotCounter.Invoke((MethodInvoker)(() => labelShotCounter.Text = "Counter " + Convert.ToString(imgCount - 1)));
                    labelCurrentDirecoty.Invoke((MethodInvoker)(() => labelCurrentDirecoty.Text = "Saved in: " + imgName + "." + Convert.ToString(ext)));

                    if (checkBoxEmail.Checked&&numericFrequency.Value>60)
                    {
                        Task taskMail = new Task(() => sendMail());
                        taskMail.Start();
                    }

                    imgCountTotal++;
                    continousShotCount++;
                    if (continousShotCount >= numericTotalShots.Value)
                    {
                        MessageBox.Show(Convert.ToString(continousShotCount-1)+" ScreenShots captured", "Ta Da!! Task Done");
                        Invoke(new Action(() => { this.WindowState = FormWindowState.Normal; }));
                        break;
                    }
                    stopWatch.Stop();
                    Thread.Sleep(time-(int)stopWatch.ElapsedMilliseconds);
                    stopWatch.Reset();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + Convert.ToString(ex));
            }        
        }

        private void sendMail()
        {
            var email = textBoxEmailID.Text.ToLower();

            if (email == "telahi@stira.sa"|| email=="touseefelahi@ymail.com")
            {
                if (!authentication.rememberMe)
                {
                    var diagRes = MessageBox.Show("Sorry You cannot Sent Email to Touseef\nAre you Touseef?", "Verification Required", MessageBoxButtons.YesNo);
                    if (diagRes == DialogResult.Yes)
                    {
                        var loc = this.Location;
                        authentication auth = new authentication(); //simple authentication form
                        auth.Location = new Point(loc.X+100, loc.Y+100);
                        auth.ShowDialog();
                                              
                        if (!authentication.verifiedUser)
                        {
                            return;
                        }

                    }
                    else
                        return;
                }            
            }

            try
            {
                MailMessage Msg = new MailMessage();
                Msg.From = new MailAddress("telahi@stira.sa");
                Msg.To.Add(textBoxEmailID.Text);
                Msg.Subject = "ScreenShot Image";
                Msg.Body = "I hope this email finds you in good health.\n Check your Screen Shot";

                var splices = imgName.Split('.');
                var a = splices[splices.Length - 1].Length;
                if (a != 3)//if there is no extension
                    imgName = imgName + "." + Convert.ToString(ext);

                Attachment imageAttachment = new Attachment(imgName);
                Msg.Attachments.Add(imageAttachment);
                SmtpClient smtp = new SmtpClient();
                smtp.Host = "smtp.gmail.com";
                smtp.Port = 587;
                smtp.Credentials = new System.Net.NetworkCredential("touseefelahi07@gmail.com", "t.3874367");
                smtp.EnableSsl = true;
                smtp.Send(Msg);
                emailCountTotal++;
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error Sending Email\n" + Convert.ToString(ex));
            }
        }
        #endregion

        #region ButtonEvents
        private void buttonCapture_Click(object sender, EventArgs e)
        {

            //  Task taskScreenShot = new Task(() => saveScreenShot());
            //  taskScreenShot.Start();
            if (checkBoxMultipleShots.Checked)
            {
                this.WindowState = FormWindowState.Minimized;
                Task taskScreenShots = new Task(() => saveMultipleShots());
                taskScreenShots.Start();
            }
            else
                saveSingleShot();
            buttonMail.Enabled = true;
        }

        private void buttonResetCounter_Click(object sender, EventArgs e)
        {
            var diaResult = MessageBox.Show("Next Screenshots will be overwritten if you didn't changed the title\n\n\n"+
                "\nLifetime Record"+
                "\nTotal Images Taken="+Convert.ToString(Settings.Default.FrameCounter+imgCountTotal)+
                "\nTotal Emails Sent="+Convert.ToString(Settings.Default.EmailCounter+emailCountTotal),
                "Warning", MessageBoxButtons.OKCancel);
            if (diaResult == DialogResult.OK)
            {
                imgCount = 1;
            }
        }

        private void buttonSelectLocation_Click(object sender, EventArgs e)
        {
            DialogResult res = folderBrowserDialog.ShowDialog();
            if (res == DialogResult.OK)
            {
                pathToImage = folderBrowserDialog.SelectedPath + "\\";
                Settings.Default.PATH = pathToImage;
                labelCurrentDirecoty.Text = "Current Directory: " + pathToImage;
            }
        }

        private void buttonMail_Click(object sender, EventArgs e)
        {
            Task taskMail = new Task(() => sendMail());
            taskMail.Start();
        }
        #endregion

        #region other events
        private void comboBoxExtension_SelectedIndexChanged(object sender, EventArgs e)
        {
            ext = (extension)comboBoxExtension.SelectedIndex;
            comboBoxExtension.Text = Convert.ToString(ext);
        }

        private void checkBoxMinMode_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxMinMode.Checked)
            {
                this.TopMost = true;
                //  this.FormBorderStyle = FormBorderStyle.None;
                originalFormSize = this.Size;
                Size s = new Size(150, 60);
                this.Size = s;
                Point loc = new Point(3, 3);
                checkBoxMinMode.Location = loc;
                this.Opacity = 0.5;
                loc = new Point(95, 3);
                buttonCapture.Size = new Size(40, 19);
                buttonCapture.BringToFront();
                buttonCapture.Location = loc;
            }
            else
            {
                this.TopMost = false;
                this.Size = originalFormSize;
                Point loc = new Point(420, 370);
                checkBoxMinMode.Location = loc;
                this.Opacity = 1;
                loc = new Point(518, 366);
                buttonCapture.Size = new Size(125, 65);
                buttonCapture.BringToFront();
                buttonCapture.Location = loc;
                //    this.FormBorderStyle = FormBorderStyle.FixedToolWindow;

            }
        }

        private void checkBoxMultipleShots_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxMultipleShots.Checked)
            {
                buttonCapture.BackColor = SystemColors.Highlight;
                buttonCapture.Text = "Take MultipleShots";
            }
            else
            {
                buttonCapture.Text = "Take ScreenShot";
                buttonCapture.BackColor = SystemColors.ButtonFace;
            }

        }

        private void checkBoxByDate_CheckedChanged(object sender, EventArgs e)
        {
            flagByDate = checkBoxByDate.Checked;
            if (flagByDate)
            {
                textBoxImageName.Enabled = false;
            }
            else textBoxImageName.Enabled = true;
        }

        private void numericTotalShots_MouseClick(object sender, MouseEventArgs e)
        {
            checkBoxMultipleShots.Checked = true;
        }

        private void numericTotalShots_ValueChanged(object sender, EventArgs e)
        {
            checkBoxMultipleShots.Checked = true;
        }

        private void screenShotSaver_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                Settings.Default.FrameCounter += imgCountTotal;
                Settings.Default.EmailCounter += emailCountTotal;
                if (textBoxImageName.Text != null)
                    Settings.Default.NAME = textBoxImageName.Text;
                if (textBoxEmailID.Text != null)
                    Settings.Default.Email = textBoxEmailID.Text;
                Settings.Default.Save();
            }
            catch (Exception) { }
        }

        #endregion
    }
}
