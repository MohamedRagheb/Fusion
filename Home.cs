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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 check = new Form1();
            check.Show();
            Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Treniess loader = new Treniess();
            loader.Show(this);
            Hide();
        }

        private void admins_form(object sender, EventArgs e)
        {
            Admins loader = new Admins();
            loader.Show(this);
            Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Equipment equipment = new Equipment();
            equipment.Show(this);
            Hide();
        }
    }
}
