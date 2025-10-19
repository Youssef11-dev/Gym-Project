using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Lifetime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class AddMemberForm : Form
    {
        public AddMemberForm()
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (check(txtId.Text) && check(txtFirstName.Text) && check(txtLastName.Text)
                && check(txtEmail.Text)&& comboBox1.SelectedIndex != -1)
            {
                if (clsClient.Find(txtId.Text) == null) {
                    lblError.Visible = false;
                    clsClient newClient = new clsClient(txtFirstName.Text, txtLastName.Text,txtEmail.Text
                        ,txtId.Text,txtPhone.Text,comboBox1.Text
                        );
                    newClient.AddNew();
                    MessageBox.Show("Member Added Succesfuly", "Here", MessageBoxButtons.OK);
                }
                else
                {
                    lblError.Text = "User is Exist , Enter Another User";
                    lblError.Visible = true;
                }
            }
            else
            {
                lblError.Text = " please fill the form"; 
                lblError.Visible = true;
            }
        }

       
    }
}
