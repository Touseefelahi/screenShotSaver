namespace screenShotSaver
{
    partial class screenShotSaver
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
            this.buttonCapture = new System.Windows.Forms.Button();
            this.pictureBoxDisplay = new System.Windows.Forms.PictureBox();
            this.borderPanel1 = new Microsoft.TeamFoundation.Client.BorderPanel();
            this.buttonSelectLocation = new System.Windows.Forms.Button();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.labelCurrentDirecoty = new System.Windows.Forms.Label();
            this.textBoxImageName = new System.Windows.Forms.TextBox();
            this.labelFileName = new System.Windows.Forms.Label();
            this.comboBoxExtension = new System.Windows.Forms.ComboBox();
            this.labelExtension = new System.Windows.Forms.Label();
            this.checkBoxByDate = new System.Windows.Forms.CheckBox();
            this.label = new System.Windows.Forms.Label();
            this.buttonMail = new System.Windows.Forms.Button();
            this.textBoxEmailID = new System.Windows.Forms.TextBox();
            this.checkBoxMultipleShots = new System.Windows.Forms.CheckBox();
            this.buttonRegionSelection = new System.Windows.Forms.Button();
            this.checkBoxEmail = new System.Windows.Forms.CheckBox();
            this.labelShotCounter = new System.Windows.Forms.Label();
            this.labelFrequency = new System.Windows.Forms.Label();
            this.numericFrequency = new System.Windows.Forms.NumericUpDown();
            this.numericTotalShots = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonResetCounter = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.checkBoxMinMode = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDisplay)).BeginInit();
            this.borderPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericFrequency)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericTotalShots)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCapture
            // 
            this.buttonCapture.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonCapture.Location = new System.Drawing.Point(518, 366);
            this.buttonCapture.Name = "buttonCapture";
            this.buttonCapture.Size = new System.Drawing.Size(125, 65);
            this.buttonCapture.TabIndex = 0;
            this.buttonCapture.Text = "Take ScreenShot";
            this.buttonCapture.UseVisualStyleBackColor = false;
            this.buttonCapture.Click += new System.EventHandler(this.buttonCapture_Click);
            // 
            // pictureBoxDisplay
            // 
            this.pictureBoxDisplay.Location = new System.Drawing.Point(2, 2);
            this.pictureBoxDisplay.Name = "pictureBoxDisplay";
            this.pictureBoxDisplay.Size = new System.Drawing.Size(640, 360);
            this.pictureBoxDisplay.TabIndex = 2;
            this.pictureBoxDisplay.TabStop = false;
            // 
            // borderPanel1
            // 
            this.borderPanel1.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.borderPanel1.BorderPadding = new System.Windows.Forms.Padding(0);
            this.borderPanel1.BorderSides = ((Microsoft.TeamFoundation.Client.BorderPanel.Sides)((((Microsoft.TeamFoundation.Client.BorderPanel.Sides.Top | Microsoft.TeamFoundation.Client.BorderPanel.Sides.Bottom) 
            | Microsoft.TeamFoundation.Client.BorderPanel.Sides.Left) 
            | Microsoft.TeamFoundation.Client.BorderPanel.Sides.Right)));
            this.borderPanel1.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.borderPanel1.Controls.Add(this.pictureBoxDisplay);
            this.borderPanel1.InnerColor = System.Drawing.SystemColors.Control;
            this.borderPanel1.Location = new System.Drawing.Point(2, 2);
            this.borderPanel1.Name = "borderPanel1";
            this.borderPanel1.Size = new System.Drawing.Size(644, 364);
            this.borderPanel1.TabIndex = 3;
            this.borderPanel1.UseInnerColor = false;
            // 
            // buttonSelectLocation
            // 
            this.buttonSelectLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSelectLocation.Location = new System.Drawing.Point(1, 433);
            this.buttonSelectLocation.Name = "buttonSelectLocation";
            this.buttonSelectLocation.Size = new System.Drawing.Size(89, 23);
            this.buttonSelectLocation.TabIndex = 6;
            this.buttonSelectLocation.Text = "Select Directory";
            this.buttonSelectLocation.UseVisualStyleBackColor = true;
            this.buttonSelectLocation.Click += new System.EventHandler(this.buttonSelectLocation_Click);
            // 
            // labelCurrentDirecoty
            // 
            this.labelCurrentDirecoty.AutoSize = true;
            this.labelCurrentDirecoty.Location = new System.Drawing.Point(89, 440);
            this.labelCurrentDirecoty.Name = "labelCurrentDirecoty";
            this.labelCurrentDirecoty.Size = new System.Drawing.Size(89, 13);
            this.labelCurrentDirecoty.TabIndex = 8;
            this.labelCurrentDirecoty.Text = "Current Directory:";
            // 
            // textBoxImageName
            // 
            this.textBoxImageName.Location = new System.Drawing.Point(2, 387);
            this.textBoxImageName.Name = "textBoxImageName";
            this.textBoxImageName.Size = new System.Drawing.Size(85, 20);
            this.textBoxImageName.TabIndex = 9;
            this.textBoxImageName.Text = "screenShot";
            // 
            // labelFileName
            // 
            this.labelFileName.AutoSize = true;
            this.labelFileName.Location = new System.Drawing.Point(0, 373);
            this.labelFileName.Name = "labelFileName";
            this.labelFileName.Size = new System.Drawing.Size(86, 13);
            this.labelFileName.TabIndex = 10;
            this.labelFileName.Text = "ScreenShot Title";
            // 
            // comboBoxExtension
            // 
            this.comboBoxExtension.FormattingEnabled = true;
            this.comboBoxExtension.Items.AddRange(new object[] {
            "Png",
            "Jpg",
            "Bmp"});
            this.comboBoxExtension.Location = new System.Drawing.Point(92, 387);
            this.comboBoxExtension.Name = "comboBoxExtension";
            this.comboBoxExtension.Size = new System.Drawing.Size(86, 21);
            this.comboBoxExtension.TabIndex = 11;
            this.comboBoxExtension.Text = "Jpg";
            this.comboBoxExtension.SelectedIndexChanged += new System.EventHandler(this.comboBoxExtension_SelectedIndexChanged);
            // 
            // labelExtension
            // 
            this.labelExtension.AutoSize = true;
            this.labelExtension.Location = new System.Drawing.Point(91, 373);
            this.labelExtension.Name = "labelExtension";
            this.labelExtension.Size = new System.Drawing.Size(53, 13);
            this.labelExtension.TabIndex = 14;
            this.labelExtension.Text = "Extension";
            // 
            // checkBoxByDate
            // 
            this.checkBoxByDate.AutoSize = true;
            this.checkBoxByDate.Location = new System.Drawing.Point(2, 410);
            this.checkBoxByDate.Name = "checkBoxByDate";
            this.checkBoxByDate.Size = new System.Drawing.Size(86, 17);
            this.checkBoxByDate.TabIndex = 15;
            this.checkBoxByDate.Text = "Title by Date";
            this.checkBoxByDate.UseVisualStyleBackColor = true;
            this.checkBoxByDate.CheckedChanged += new System.EventHandler(this.checkBoxByDate_CheckedChanged);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.ForeColor = System.Drawing.Color.Maroon;
            this.label.Location = new System.Drawing.Point(406, 417);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(109, 13);
            this.label.TabIndex = 16;
            this.label.Text = "Purchase Full Version";
            // 
            // buttonMail
            // 
            this.buttonMail.Enabled = false;
            this.buttonMail.Location = new System.Drawing.Point(310, 409);
            this.buttonMail.Name = "buttonMail";
            this.buttonMail.Size = new System.Drawing.Size(75, 23);
            this.buttonMail.TabIndex = 18;
            this.buttonMail.Text = "Send Mail";
            this.buttonMail.UseVisualStyleBackColor = true;
            this.buttonMail.Click += new System.EventHandler(this.buttonMail_Click);
            // 
            // textBoxEmailID
            // 
            this.textBoxEmailID.Location = new System.Drawing.Point(311, 387);
            this.textBoxEmailID.Name = "textBoxEmailID";
            this.textBoxEmailID.Size = new System.Drawing.Size(100, 20);
            this.textBoxEmailID.TabIndex = 19;
            this.textBoxEmailID.Text = "Enter Email";
            // 
            // checkBoxMultipleShots
            // 
            this.checkBoxMultipleShots.AutoSize = true;
            this.checkBoxMultipleShots.Location = new System.Drawing.Point(191, 370);
            this.checkBoxMultipleShots.Name = "checkBoxMultipleShots";
            this.checkBoxMultipleShots.Size = new System.Drawing.Size(103, 17);
            this.checkBoxMultipleShots.TabIndex = 20;
            this.checkBoxMultipleShots.Text = "Continous Shots";
            this.checkBoxMultipleShots.UseVisualStyleBackColor = true;
            this.checkBoxMultipleShots.CheckedChanged += new System.EventHandler(this.checkBoxMultipleShots_CheckedChanged);
            // 
            // buttonRegionSelection
            // 
            this.buttonRegionSelection.Enabled = false;
            this.buttonRegionSelection.Location = new System.Drawing.Point(422, 433);
            this.buttonRegionSelection.Name = "buttonRegionSelection";
            this.buttonRegionSelection.Size = new System.Drawing.Size(75, 23);
            this.buttonRegionSelection.TabIndex = 21;
            this.buttonRegionSelection.Text = "Region";
            this.buttonRegionSelection.UseVisualStyleBackColor = true;
            // 
            // checkBoxEmail
            // 
            this.checkBoxEmail.AutoSize = true;
            this.checkBoxEmail.Location = new System.Drawing.Point(312, 370);
            this.checkBoxEmail.Name = "checkBoxEmail";
            this.checkBoxEmail.Size = new System.Drawing.Size(76, 17);
            this.checkBoxEmail.TabIndex = 22;
            this.checkBoxEmail.Text = "Auto Email";
            this.checkBoxEmail.UseVisualStyleBackColor = true;
            // 
            // labelShotCounter
            // 
            this.labelShotCounter.AutoSize = true;
            this.labelShotCounter.Location = new System.Drawing.Point(564, 440);
            this.labelShotCounter.Name = "labelShotCounter";
            this.labelShotCounter.Size = new System.Drawing.Size(44, 13);
            this.labelShotCounter.TabIndex = 23;
            this.labelShotCounter.Text = "Counter";
            // 
            // labelFrequency
            // 
            this.labelFrequency.AutoSize = true;
            this.labelFrequency.Location = new System.Drawing.Point(184, 410);
            this.labelFrequency.Name = "labelFrequency";
            this.labelFrequency.Size = new System.Drawing.Size(57, 26);
            this.labelFrequency.TabIndex = 24;
            this.labelFrequency.Text = "Frequency\r\n      (s)";
            // 
            // numericFrequency
            // 
            this.numericFrequency.Location = new System.Drawing.Point(184, 389);
            this.numericFrequency.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericFrequency.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericFrequency.Name = "numericFrequency";
            this.numericFrequency.Size = new System.Drawing.Size(59, 20);
            this.numericFrequency.TabIndex = 26;
            this.numericFrequency.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericFrequency.ValueChanged += new System.EventHandler(this.numericTotalShots_ValueChanged);
            this.numericFrequency.MouseClick += new System.Windows.Forms.MouseEventHandler(this.numericTotalShots_MouseClick);
            // 
            // numericTotalShots
            // 
            this.numericTotalShots.Location = new System.Drawing.Point(244, 389);
            this.numericTotalShots.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericTotalShots.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericTotalShots.Name = "numericTotalShots";
            this.numericTotalShots.Size = new System.Drawing.Size(60, 20);
            this.numericTotalShots.TabIndex = 27;
            this.numericTotalShots.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericTotalShots.ValueChanged += new System.EventHandler(this.numericTotalShots_ValueChanged);
            this.numericTotalShots.MouseClick += new System.Windows.Forms.MouseEventHandler(this.numericTotalShots_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(253, 411);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 26);
            this.label1.TabIndex = 28;
            this.label1.Text = "Total\r\nShots";
            // 
            // buttonResetCounter
            // 
            this.buttonResetCounter.Location = new System.Drawing.Point(518, 433);
            this.buttonResetCounter.Name = "buttonResetCounter";
            this.buttonResetCounter.Size = new System.Drawing.Size(48, 23);
            this.buttonResetCounter.TabIndex = 29;
            this.buttonResetCounter.Text = "Reset";
            this.buttonResetCounter.UseVisualStyleBackColor = true;
            this.buttonResetCounter.Click += new System.EventHandler(this.buttonResetCounter_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Location = new System.Drawing.Point(0, 456);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(652, 10);
            this.panel1.TabIndex = 30;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Location = new System.Drawing.Point(-7, -1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(11, 530);
            this.panel2.TabIndex = 31;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Location = new System.Drawing.Point(644, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(11, 530);
            this.panel3.TabIndex = 32;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(652, 10);
            this.panel4.TabIndex = 31;
            // 
            // checkBoxMinMode
            // 
            this.checkBoxMinMode.AutoSize = true;
            this.checkBoxMinMode.Location = new System.Drawing.Point(420, 370);
            this.checkBoxMinMode.Name = "checkBoxMinMode";
            this.checkBoxMinMode.Size = new System.Drawing.Size(91, 30);
            this.checkBoxMinMode.TabIndex = 33;
            this.checkBoxMinMode.Text = "Minimal Mode\r\n(no delay)\r\n";
            this.checkBoxMinMode.UseVisualStyleBackColor = true;
            this.checkBoxMinMode.CheckedChanged += new System.EventHandler(this.checkBoxMinMode_CheckedChanged);
            // 
            // screenShotSaver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(648, 461);
            this.Controls.Add(this.checkBoxMinMode);
            this.Controls.Add(this.buttonCapture);
            this.Controls.Add(this.buttonResetCounter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericTotalShots);
            this.Controls.Add(this.numericFrequency);
            this.Controls.Add(this.labelFrequency);
            this.Controls.Add(this.labelShotCounter);
            this.Controls.Add(this.checkBoxEmail);
            this.Controls.Add(this.buttonRegionSelection);
            this.Controls.Add(this.checkBoxMultipleShots);
            this.Controls.Add(this.textBoxEmailID);
            this.Controls.Add(this.buttonMail);
            this.Controls.Add(this.label);
            this.Controls.Add(this.checkBoxByDate);
            this.Controls.Add(this.labelExtension);
            this.Controls.Add(this.comboBoxExtension);
            this.Controls.Add(this.textBoxImageName);
            this.Controls.Add(this.labelCurrentDirecoty);
            this.Controls.Add(this.buttonSelectLocation);
            this.Controls.Add(this.borderPanel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.labelFileName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "screenShotSaver";
            this.Text = "Screen Shot Saver";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.screenShotSaver_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDisplay)).EndInit();
            this.borderPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericFrequency)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericTotalShots)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCapture;
        private System.Windows.Forms.PictureBox pictureBoxDisplay;
        private Microsoft.TeamFoundation.Client.BorderPanel borderPanel1;
        private System.Windows.Forms.Button buttonSelectLocation;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.Label labelCurrentDirecoty;
        private System.Windows.Forms.TextBox textBoxImageName;
        private System.Windows.Forms.Label labelFileName;
        private System.Windows.Forms.ComboBox comboBoxExtension;
        private System.Windows.Forms.Label labelExtension;
        private System.Windows.Forms.CheckBox checkBoxByDate;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Button buttonMail;
        private System.Windows.Forms.TextBox textBoxEmailID;
        private System.Windows.Forms.CheckBox checkBoxMultipleShots;
        private System.Windows.Forms.Button buttonRegionSelection;
        private System.Windows.Forms.CheckBox checkBoxEmail;
        private System.Windows.Forms.Label labelShotCounter;
        private System.Windows.Forms.Label labelFrequency;
        private System.Windows.Forms.NumericUpDown numericFrequency;
        private System.Windows.Forms.NumericUpDown numericTotalShots;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonResetCounter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.CheckBox checkBoxMinMode;
    }
}

