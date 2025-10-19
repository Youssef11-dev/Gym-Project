using System;
using System.IO;
using System.Windows.Forms;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using WindowsFormsApp1;

namespace FileTextSearcher
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            GlobalVars.CurrentUser = clsUser.Find(txtUserName.Text, txtPassword.Text);
            if (GlobalVars.CurrentUser != null) { 
                Form Gym = new GymForm();
                Gym.ShowDialog();

            }
            else
            {
                lblError.Visible = true;
            }
        }

       
    }
}
