namespace screenShotSaver
{
    partial class authentication
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
            this.labelPassKey = new System.Windows.Forms.Label();
            this.textBoxPassKey = new System.Windows.Forms.TextBox();
            this.buttonSubmitPasskey = new System.Windows.Forms.Button();
            this.checkBoxRememberME = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // labelPassKey
            // 
            this.labelPassKey.AutoSize = true;
            this.labelPassKey.Location = new System.Drawing.Point(3, 9);
            this.labelPassKey.Name = "labelPassKey";
            this.labelPassKey.Size = new System.Drawing.Size(75, 13);
            this.labelPassKey.TabIndex = 0;
            this.labelPassKey.Text = "Enter Passkey";
            // 
            // textBoxPassKey
            // 
            this.textBoxPassKey.Location = new System.Drawing.Point(81, 6);
            this.textBoxPassKey.Name = "textBoxPassKey";
            this.textBoxPassKey.Size = new System.Drawing.Size(100, 20);
            this.textBoxPassKey.TabIndex = 1;
            this.textBoxPassKey.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxPassKey_KeyDown);
            // 
            // buttonSubmitPasskey
            // 
            this.buttonSubmitPasskey.Location = new System.Drawing.Point(105, 30);
            this.buttonSubmitPasskey.Name = "buttonSubmitPasskey";
            this.buttonSubmitPasskey.Size = new System.Drawing.Size(75, 23);
            this.buttonSubmitPasskey.TabIndex = 2;
            this.buttonSubmitPasskey.Text = "Submit";
            this.buttonSubmitPasskey.UseVisualStyleBackColor = true;
            this.buttonSubmitPasskey.Click += new System.EventHandler(this.buttonSubmitPasskey_Click);
            this.buttonSubmitPasskey.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxPassKey_KeyDown);
            // 
            // checkBoxRememberME
            // 
            this.checkBoxRememberME.AutoSize = true;
            this.checkBoxRememberME.Location = new System.Drawing.Point(6, 34);
            this.checkBoxRememberME.Name = "checkBoxRememberME";
            this.checkBoxRememberME.Size = new System.Drawing.Size(92, 17);
            this.checkBoxRememberME.TabIndex = 3;
            this.checkBoxRememberME.Text = "RememberMe";
            this.checkBoxRememberME.UseVisualStyleBackColor = true;
            this.checkBoxRememberME.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxPassKey_KeyDown);
            // 
            // authentication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(185, 56);
            this.Controls.Add(this.checkBoxRememberME);
            this.Controls.Add(this.buttonSubmitPasskey);
            this.Controls.Add(this.textBoxPassKey);
            this.Controls.Add(this.labelPassKey);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "authentication";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Authentication";
            this.TopMost = true;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxPassKey_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPassKey;
        private System.Windows.Forms.TextBox textBoxPassKey;
        private System.Windows.Forms.Button buttonSubmitPasskey;
        private System.Windows.Forms.CheckBox checkBoxRememberME;
    }
}