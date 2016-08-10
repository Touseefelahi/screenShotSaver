using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace screenShotSaver
{
    public partial class authentication : Form
    {
        static bool _verifiedUser=false, _rememberMe = false;

        public static bool verifiedUser
        {
            get
            {
                return _verifiedUser;
            }
        }
        public static bool rememberMe
        {
            get
            {
                return _rememberMe;
            }
        }

        public authentication()
        {
            InitializeComponent();
            System.Media.SystemSounds.Asterisk.Play();
            this.FormBorderStyle = FormBorderStyle.Fixed3D;
        }

        private void buttonSubmitPasskey_Click(object sender, EventArgs e)
        {
            if (textBoxPassKey.Text == "387")
            {
                _verifiedUser = true;

                if (checkBoxRememberME.Checked)
                {
                    _rememberMe = true;
                }
                else
                {
                    _rememberMe = false;
                }
               
            }
            this.Close();
        }

        private void textBoxPassKey_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonSubmitPasskey_Click(null, null);
            }
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
