using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

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
            SoundManager.Play(); // Play sound when the form loads
            btnSound.Image = Properties.Resources.play; // Set initial icon to mute (playing state)
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

        private void btnSound_Click(object sender, EventArgs e)
        {
            SoundManager.Toggle(); // Toggle play/pause

            if (SoundManager.IsPlaying)
                btnSound.Image = Properties.Resources.play; // Change to mute icon
            else
                btnSound.Image = Properties.Resources.mute; // Change to play icon
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
