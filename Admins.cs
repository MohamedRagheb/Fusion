using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FusionProject
{
    public partial class Admins : Form
    {
        public Admins()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Admins_Load(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void handel_add_admin(object sender, EventArgs e)
        {
            string username = admin_name.Text;
            string password = admin_password.Text;
            bool isMale = admin_male.Checked;
            bool isFemale = admin_female.Checked;

            MessageBox.Show($"name is {username} password {password} male {isMale} female {isFemale}");

        }
    }
}
