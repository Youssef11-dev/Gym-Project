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
    public partial class SearchForm : Form
    {
        public SearchForm()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            clsClient client = clsClient.Find(txtSearch.Text);
            if (client != null) {
                lblError.Visible = true;
                lblError.Text = "Found";
                lblError.ForeColor = Color.Green;
                lblFirstName.Text = client.firstName;
                lblLastName.Text = client.lastName;
                lblEmail.Text = client.email;
                lblPhone.Text = client.phone;
                lblSubscribtion.Text = client.memberShipName;
            }
            else
            {
                lblError.Visible = true;
                lblError.Text = "User is not Exist";
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
        
        }
    }
}
