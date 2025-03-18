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

namespace Colonel_ahmed_abdelrazek
{
    public partial class ContentManagerForm : Form
    {
        private string contentPath = Path.Combine(Directory.GetParent(Directory.GetParent(Directory.GetParent(Application.StartupPath).FullName).FullName).FullName, "Content");

        private void lstAbwab_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) return;

            // Draw the form's background color (simulates transparency)
            e.Graphics.FillRectangle(new SolidBrush(this.BackColor), e.Bounds);

            // Draw text
            e.Graphics.DrawString(lstAbwab.Items[e.Index].ToString(),
                                  e.Font,
                                  new SolidBrush(lstAbwab.ForeColor),
                                  e.Bounds);
        }

        public ContentManagerForm()
        {
            InitializeComponent();
            LoadAbwab(); // Load existing أبواب when the form opens
        }

        private void LoadAbwab()
        {
            lstAbwab.Items.Clear(); // Clear the list first

            if (!Directory.Exists(contentPath))
            {
                MessageBox.Show("Content folder does not exist! Creating it now...");
                Directory.CreateDirectory(contentPath);
            }

            string[] abwab = Directory.GetDirectories(contentPath);


            foreach (string bab in abwab)
            {
                lstAbwab.Items.Add(Path.GetFileName(bab)); // Add folder names to ListBox
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Close(); // Close this form and return to Form1
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (lstAbwab.SelectedItem != null)
            {
                string oldName = lstAbwab.SelectedItem.ToString();
                string newName = Prompt.ShowDialog("أدخل الاسم الجديد للباب:", "تعديل الباب");

                if (!string.IsNullOrWhiteSpace(newName) && newName != oldName)
                {
                    string oldPath = Path.Combine(contentPath, oldName);
                    string newPath = Path.Combine(contentPath, newName);

                    if (!Directory.Exists(newPath))
                    {
                        Directory.Move(oldPath, newPath); // Rename the folder
                        int index = lstAbwab.SelectedIndex;
                        lstAbwab.Items[index] = newName; // Update ListBox
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

        private void btnAddBab_Click(object sender, EventArgs e)
        {
            string newBab = Prompt.ShowDialog("أدخل اسم الباب الجديد:", "إضافة باب");

            if (!string.IsNullOrWhiteSpace(newBab))
            {
                string newPath = Path.Combine(contentPath, newBab);

                if (!Directory.Exists(newPath))
                {
                    Directory.CreateDirectory(newPath); // Create new باب as a folder
                    lstAbwab.Items.Add(newBab); // Add to the ListBox
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
            if (lstAbwab.SelectedItem != null)
            {
                string selectedBab = lstAbwab.SelectedItem.ToString();
                DialogResult result = MessageBox.Show($"هل أنت متأكد من حذف الباب '{selectedBab}'؟", "تأكيد الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    string path = Path.Combine(contentPath, selectedBab);
                    if (Directory.Exists(path))
                    {
                        Directory.Delete(path, true); // Delete the folder and its contents
                    }

                    lstAbwab.Items.Remove(selectedBab); // Remove from ListBox
                    MessageBox.Show("تم حذف الباب بنجاح!", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("الرجاء اختيار باب لحذفه.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void lstAbwab_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lstAbwab_DoubleClick_1(object sender, EventArgs e)
        {
            if (lstAbwab.SelectedItem != null)
            {
                string selectedBab = lstAbwab.SelectedItem.ToString();
                string babFullPath = Path.Combine(contentPath, selectedBab);


                if (Directory.Exists(babFullPath))
                {
                    FusoolForm fusoolForm = new FusoolForm(babFullPath);
                    this.Hide(); // Hide ContentManagerForm
                    fusoolForm.ShowDialog();
                    this.Show(); // Show ContentManagerForm again after FusoolForm is closed
                }
                else
                {
                    MessageBox.Show("المجلد غير موجود!", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
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
