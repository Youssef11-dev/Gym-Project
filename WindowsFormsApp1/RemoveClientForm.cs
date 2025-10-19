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
    public partial class RemoveClientForm : Form
    {
        public RemoveClientForm()
        {
            InitializeComponent();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
           clsClient clienrt = clsClient.Find(textBox1.Text);
            if (clienrt != null) {
                clienrt.Remove();
                label2.Visible = false;
                MessageBox.Show("Member Removed", "Hi there", MessageBoxButtons.OK);
            }
            else
            {
                label2.Visible = true;
            }
        }
    }
}
