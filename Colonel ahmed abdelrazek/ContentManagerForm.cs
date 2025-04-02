using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Colonel_ahmed_abdelrazek
{
    public partial class ContentManagerForm : Form
    {
        
        private Button selectedBabButton = null;
        private string contentPath = Path.Combine(Application.StartupPath, "Content");

        public ContentManagerForm()
        {
            InitializeComponent();
            LoadAbwab(); // Load أبواب as buttons
        }

        private void LoadAbwab()
        {
            flpAbwab.Controls.Clear(); // Clear existing buttons
            

            if (!Directory.Exists(contentPath))
            {
                MessageBox.Show("Content folder does not exist! Creating it now...");
                Directory.CreateDirectory(contentPath);
            }

            string[] abwab = Directory.GetDirectories(contentPath);

            foreach (string bab in abwab)
            {
                AddBabButton(Path.GetFileName(bab)); // Add buttons dynamically
            }
        }

        private void AddBabButton(string babName)
        {
            Button babButton = new Button
            {
                Text = babName,
                Width = 250,
                Height = 50,
                BackColor = Color.LightBlue,
                Font = new Font("Arial", 14, FontStyle.Bold),
                Tag = babName, // Store the name for reference

            };

            // ✅ Enable DoubleClick support
            babButton.MouseDown += BabButton_MouseDown;
            flpAbwab.Controls.Add(babButton);
        }

        // ✅ Handle Single and Double Clicks
        private void BabButton_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Clicks == 2) // Detect double-click manually
            {
                Button clickedButton = sender as Button;
                if (clickedButton != null)
                {
                    OpenBab(clickedButton.Text);
                }
            }
            else if (e.Clicks == 1)
            {
                Button clickedButton = sender as Button;
                if (clickedButton != null)
                {
                    SelectBab(clickedButton);
                }
            }
        }

        private void SelectBab(Button babButton)
        {
            // Deselect previous button
            if (selectedBabButton != null)
            {
                selectedBabButton.BackColor = Color.LightBlue;
            }

            // Select new button
            selectedBabButton = babButton;
            selectedBabButton.BackColor = Color.LightGreen; // Highlight selection
        }

        private void OpenBab(string babName)
        {
            string babFullPath = Path.Combine(contentPath, babName);

            if (Directory.Exists(babFullPath))
            {
                FusoolForm fusoolForm = new FusoolForm(babFullPath);
                this.Hide();
                fusoolForm.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("المجلد غير موجود!", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddBab_Click(object sender, EventArgs e)
        {
            string newBab = Prompt.ShowDialog("أدخل اسم الباب الجديد:", "إضافة باب");

            if (!string.IsNullOrWhiteSpace(newBab))
            {
                string newPath = Path.Combine(contentPath, newBab);

                if (!Directory.Exists(newPath))
                {
                    Directory.CreateDirectory(newPath);
                    AddBabButton(newBab); // Add new button
                    MessageBox.Show("تمت إضافة الباب بنجاح!", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("هذا الباب موجود بالفعل!", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

        }

        private void btnDeleteBab_Click(object sender, EventArgs e)
        {
            if (selectedBabButton != null)
            {
                string selectedBab = selectedBabButton.Text;
                DialogResult result = MessageBox.Show($"هل أنت متأكد من حذف الباب '{selectedBab}'؟", "تأكيد الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    string path = Path.Combine(contentPath, selectedBab);
                    if (Directory.Exists(path))
                    {
                        Directory.Delete(path, true);
                    }

                    flpAbwab.Controls.Remove(selectedBabButton);
                    selectedBabButton = null; // Clear selection
                    MessageBox.Show("تم حذف الباب بنجاح!", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("الرجاء اختيار باب لحذفه.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (selectedBabButton != null)
            {
                string oldName = selectedBabButton.Text;
                string newName = Prompt.ShowDialog("أدخل الاسم الجديد للباب:", "تعديل الباب");

                if (!string.IsNullOrWhiteSpace(newName) && newName != oldName)
                {
                    string oldPath = Path.Combine(contentPath, oldName);
                    string newPath = Path.Combine(contentPath, newName);

                    if (!Directory.Exists(newPath))
                    {
                        Directory.Move(oldPath, newPath);
                        selectedBabButton.Text = newName; // Update button text
                        MessageBox.Show("تم تعديل اسم الباب بنجاح!", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("اسم الباب الجديد مستخدم بالفعل!", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            else
            {
                MessageBox.Show("الرجاء اختيار باب لتعديله.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close(); // Close this form and return to Form1
        }


        private Button GetSelectedButton()
        {
            foreach (Control control in flpAbwab.Controls)
            {
                if (control is Button button && button.Focused)
                {
                    return button;
                }
            }
            return null;
        }
    

        private void flpAbwab_Paint(object sender, PaintEventArgs e)
        {

        }

        

        private void btnSound_Click(object sender, EventArgs e)
        {
            SoundManager.Toggle(); // Toggle the sound using SoundManager

            if (SoundManager.IsPlaying)
            {
                btnSound.Image = Properties.Resources.play; // Change to play icon
            }
            else
            {
                btnSound.Image = Properties.Resources.mute; // Change to mute icon
            }
        }

        private void flpAbwab_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }

    // Custom InputBox Alternative for C#
    public static class Prompt
    {
        public static string ShowDialog(string text, string caption)
        {
            Form prompt = new Form()
            {
                Width = 300,
                Height = 150,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = caption,
                StartPosition = FormStartPosition.CenterScreen
            };

            Label textLabel = new Label() { Left = 10, Top = 20, Text = text };
            TextBox textBox = new TextBox() { Left = 10, Top = 50, Width = 250 };
            Button confirmation = new Button() { Text = "إضافة", Left = 10, Width = 80, Top = 80, DialogResult = DialogResult.OK };

            prompt.Controls.Add(textLabel);
            prompt.Controls.Add(textBox);
            prompt.Controls.Add(confirmation);
            prompt.AcceptButton = confirmation;

            return (prompt.ShowDialog() == DialogResult.OK) ? textBox.Text : "";
        }
    }
}
