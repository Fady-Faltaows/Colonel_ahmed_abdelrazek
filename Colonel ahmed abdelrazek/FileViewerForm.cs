using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Colonel_ahmed_abdelrazek
{
    public partial class FileViewerForm : Form
    {
        private string fusoolPath; // Store selected فصل path

        public FileViewerForm(string path)
        {
            InitializeComponent();
            fusoolPath = path;
            LoadFiles(); // Load files when form opens
        }

        private void LoadFiles()
        {
            lstFiles.Items.Clear(); // Clear list before loading new files

            if (Directory.Exists(fusoolPath))
            {
                string[] files = Directory.GetFiles(fusoolPath);
                foreach (string file in files)
                {
                    lstFiles.Items.Add(Path.GetFileName(file)); // Show only file names
                }
            }
            else
            {
                MessageBox.Show("المجلد غير موجود!", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            if (lstFiles.SelectedItem != null)
            {
                string selectedFile = lstFiles.SelectedItem.ToString();
                string fullPath = Path.Combine(fusoolPath, selectedFile);

                if (File.Exists(fullPath))
                {
                    try
                    {
                        Process.Start(new ProcessStartInfo
                        {
                            FileName = fullPath,
                            UseShellExecute = true // Opens file with the default program
                        });
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"حدث خطأ أثناء فتح الملف:\n{ex.Message}", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("الملف غير موجود!", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("الرجاء اختيار ملف لفتحه.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void FileViewerForm_Load(object sender, EventArgs e)
        {

        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Close(); // Close the current form to return to the previous one
        }

        private void btnDeleteFile_Click(object sender, EventArgs e)
        {
            if (lstFiles.SelectedItem != null)
            {
                string selectedFile = lstFiles.SelectedItem.ToString();
                string fullPath = Path.Combine(fusoolPath, selectedFile);

                DialogResult result = MessageBox.Show($"هل أنت متأكد أنك تريد حذف {selectedFile}؟",
                    "تأكيد الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        File.Delete(fullPath);
                        MessageBox.Show("تم الحذف بنجاح!", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadFiles(); // Refresh file list
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"خطأ أثناء الحذف: {ex.Message}", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("الرجاء اختيار ملف للحذف.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnRenameFile_Click(object sender, EventArgs e)
        {
            if (lstFiles.SelectedItem != null)
            {
                string selectedFile = lstFiles.SelectedItem.ToString();
                string fullPath = Path.Combine(fusoolPath, selectedFile);

                if (File.Exists(fullPath))
                {
                    string newName = Prompt.ShowDialog("أدخل الاسم الجديد:", "إعادة تسمية الملف");

                    if (!string.IsNullOrWhiteSpace(newName))
                    {
                        string newPath = Path.Combine(fusoolPath, newName);

                        try
                        {
                            File.Move(fullPath, newPath);
                            LoadFiles(); // Refresh file list
                            MessageBox.Show("تمت إعادة التسمية بنجاح!", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"حدث خطأ: {ex.Message}", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("يرجى اختيار ملف لإعادة تسميته.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text.ToLower();
            lstFiles.Items.Clear();

            string[] files = Directory.GetFiles(fusoolPath);
            foreach (string file in files)
            {
                string fileName = Path.GetFileName(file);
                if (fileName.ToLower().Contains(searchText))
                {
                    lstFiles.Items.Add(fileName);
                }
            }
        }
    }
}
