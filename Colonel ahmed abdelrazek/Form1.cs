using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Colonel_ahmed_abdelrazek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Enter_Click(object sender, EventArgs e)
        {
            this.Hide(); // Hide the main form
            ContentManagerForm contentForm = new ContentManagerForm();
            contentForm.ShowDialog();
            this.Show(); // Show the main form again after closing content manager
        }

        private void AboutUs_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This app helps manage study content.", "About Us", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
