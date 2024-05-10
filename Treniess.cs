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
    public partial class Treniess : Form
    {
        public Treniess()
        {
            InitializeComponent();
        }

        private void Treniess_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void add_treniee_Click(object sender, EventArgs e)
        {
            string name = treniee_name.Text;
            string job = treniee_job.Text;
            string age = treniee_age.Text;
            bool renew = checkBox1.Checked;

            MessageBox.Show($"name {name} job is {job} age {age} renew {renew}");

        }

        private void treniee_name_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
