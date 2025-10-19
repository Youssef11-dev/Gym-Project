using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class AddStaffForm : Form
    {
        public AddStaffForm()
        {
            InitializeComponent();
        }
        private bool check(string text)
        {
            if (string.IsNullOrEmpty(text))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (check(txtName.Text) && check(txtPass.Text) && check(txtUser.Text) && comboBox1.SelectedIndex != -1)
            {
                if (clsUser.Find(txtUser.Text) == null)
                {
                    lblError.Visible = false;
                    clsUser User = new clsUser(txtUser.Text, txtPass.Text,comboBox1.Text,txtName.Text);
                    User.AddNew();
                    MessageBox.Show("Staff Added Succesfuly", "Here", MessageBoxButtons.OK);
                }
                else
                {
                    lblError.Text = "Id is Exist , Enter Another Id";
                    lblError.Visible = true;
                }

            }
            else
            {
                lblError.Visible = true;
            }
        }
    }
}
