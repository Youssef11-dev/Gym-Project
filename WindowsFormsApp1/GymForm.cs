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
    public partial class GymForm : Form
    {
        public GymForm()
        {
            InitializeComponent();
            picSearchMember.Visible = false;
            picNewMember.Visible = false;
            picDeleteMember.Visible = false;
            picNewStaff.Visible = false;
            lblWelcome.Text = $"Hi Mr,{GlobalVars.CurrentUser.Name} Welcome to Gym System";
            if (GlobalVars.CurrentUser.premission == "Manager")
            {
                picSearchMember.Visible = true;
                picNewMember.Visible = true;
                picDeleteMember.Visible = true ;
                picNewStaff.Visible = true ;
            }
            if(GlobalVars.CurrentUser.premission == "Sales")
            {
                picSearchMember.Visible = true;
                picNewMember.Visible = true;
                picDeleteMember.Visible = true;
            }
            if(GlobalVars.CurrentUser.premission == "Reception")
            {
                picSearchMember.Visible = true;
            }
        }

        private void picSearchMember_Click(object sender, EventArgs e)
        {
            Form form = new SearchForm();
            form.ShowDialog();

        }

        private void picLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void picNewMember_Click(object sender, EventArgs e)
        {
            Form form = new AddMemberForm();
            form.ShowDialog();

        }

        private void picDeleteMember_Click(object sender, EventArgs e)
        {
            Form form = new RemoveClientForm();
            form.ShowDialog(); 
        }

        private void picNewStaff_Click(object sender, EventArgs e)
        {
            Form form = new AddStaffForm();
            form.ShowDialog();
        }
    }
}
