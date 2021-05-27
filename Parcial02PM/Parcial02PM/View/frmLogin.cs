using System;
using System.Windows.Forms;

namespace Parcial02PM.View
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnCreateUser_Click(object sender, EventArgs e)
        {
            FrmCreateUser window = new FrmCreateUser();
            window.ShowDialog();
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            FrmChangePassword window = new FrmChangePassword();
            window.ShowDialog();
        }

        private void btnInitSes_Click(object sender, EventArgs e)
        {
            FrmPrincipal window = new FrmPrincipal();
            window.ShowDialog();
        }
    }
}