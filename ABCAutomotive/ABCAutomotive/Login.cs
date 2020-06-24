using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABCAutomotive
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            txtUserName.Text = "StephenCarter"; // DefaultValue //Password = password1
            txtPassword.Select();
            txtPassword.UseSystemPasswordChar = true;
            lblErrorMessage.ForeColor = Color.Red;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            LoginBL loginBL = new LoginBL();

            Model.Login login = loginBL.GetLogin(txtUserName.Text, txtPassword.Text);

            if(login.LoginUserName == null || login.Password == null)
            {
              lblErrorMessage.Text = "Invalid Password or Login User Name";
              txtUserName.Focus();

            }
            else
            {
                if(login.Password.Trim() == txtPassword.Text && login.LoginUserName.Trim() == txtUserName.Text)
                {
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    lblErrorMessage.Text = "Invalid Password or Login User Name";
                    txtUserName.Focus();

                }
            }
        }
    }
}
