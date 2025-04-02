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
        private string selectedPath; // Store selected path
        private string selectedFilePath; // Store selected file path
        private Button selectedFileButton; // Track selected file button


        public FileViewerForm(string path)
        {
            InitializeComponent();
            selectedPath = path;
            LoadFiles(); // Load files when form opens
        }

        private void FileViewerForm_Load(object sender, EventArgs e)
        {
            LoadFiles(); // Ensure files are loaded on form load
            SoundManager.Play(); // Play sound when the form loads
            btnSound.Image = Properties.Resources.play; // Set initial icon
        }

        private void LoadFiles()
        {
            flpfile.SuspendLayout(); // تحسين الأداء عن طريق إيقاف التحديث مؤقتًا
            flpfile.Controls.Clear();

            if (!Directory.Exists(selectedPath))
            {
                MessageBox.Show("المجلد غير موجود!", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string[] files = Directory.GetFiles(selectedPath);
            foreach (string file in files)
            {
                Button btnFile = new Button
                {
                    Text = Path.GetFileName(file),
                    Font = new Font("Tahoma", 12, FontStyle.Bold),
                    Size = new Size(flpfile.ClientSize.Width - 20, 60),
                    TextAlign = ContentAlignment.MiddleCenter,
                    FlatStyle = FlatStyle.Flat,
                    BackColor = Color.LightBlue,
                    ForeColor = Color.Black,
                    FlatAppearance = { BorderSize = 1 },
                    Tag = file // Store file path for reference
                };

                // ✅ Enable both Single & Double Clicks manually
                btnFile.MouseDown += FileButton_MouseDown;

                flpfile.Controls.Add(btnFile);
            }

            flpfile.ResumeLayout(); // استئناف التحديث بعد إضافة جميع الأزرار
        }

        // ✅ Handle Single and Double Clicks
        private void FileButton_MouseDown(object sender, MouseEventArgs e)
        {
            Button clickedButton = sender as Button;
            if (clickedButton == null) return;

            string filePath = clickedButton.Tag.ToString();

            if (e.Clicks == 2) // Double-click detected
            {
                OpenFile(filePath);
            }
            else if (e.Clicks == 1) // Single-click detected
            {
                SelectFile(filePath, clickedButton);
            }
        }

        private void OpenFile(string filePath)
        {
            if (File.Exists(filePath))
            {
                try
                {
                    Process.Start(new ProcessStartInfo { FileName = filePath, UseShellExecute = true });
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




        private void SelectFile(string filePath, Button clickedButton)
        {
            // Reset the previously selected button's appearance
            if (selectedFileButton != null)
            {
                selectedFileButton.BackColor = Color.LightBlue;
            }

            // Set the new selected button and update appearance
            selectedFileButton = clickedButton;
            selectedFileButton.BackColor = Color.DarkBlue; // Highlight selected file
            selectedFileButton.ForeColor = Color.White;

            // Store the selected file path
            selectedFilePath = filePath;
        }

        

        private void btnDeleteFile_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(selectedFilePath) && File.Exists(selectedFilePath))
            {
                DialogResult result = MessageBox.Show($"هل أنت متأكد أنك تريد حذف {Path.GetFileName(selectedFilePath)}؟",
                    "تأكيد الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        File.Delete(selectedFilePath);
                        MessageBox.Show("تم الحذف بنجاح!", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadFiles(); // Refresh file list
                        selectedFilePath = null;
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
            if (!string.IsNullOrEmpty(selectedFilePath) && File.Exists(selectedFilePath))
            {
                string newName = Prompt.ShowDialog("أدخل الاسم الجديد:", "إعادة تسمية الملف");

                if (!string.IsNullOrWhiteSpace(newName))
                {
                    string newPath = Path.Combine(selectedPath, newName);

                    try
                    {
                        File.Move(selectedFilePath, newPath);
                        LoadFiles(); // Refresh file list
                        MessageBox.Show("تمت إعادة التسمية بنجاح!", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"حدث خطأ: {ex.Message}", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("يرجى اختيار ملف لإعادة تسميته.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnUploadFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "اختر ملفًا للتحميل";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string sourceFilePath = openFileDialog.FileName;
                    string destinationFilePath = Path.Combine(selectedPath, Path.GetFileName(sourceFilePath));
                    try
                    {
                        File.Copy(sourceFilePath, destinationFilePath, true);
                        MessageBox.Show("تم تحميل الملف بنجاح!", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadFiles(); // Refresh file list
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"خطأ أثناء تحميل الملف: {ex.Message}", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Close(); // Close the form to go back
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text.ToLower();
            foreach (Control control in flpfile.Controls)
            {
                if (control is Button btnFile)
                {
                    btnFile.Visible = btnFile.Text.ToLower().Contains(searchText);
                }
            }
        }

        private void btnSound_Click(object sender, EventArgs e)
        {
            SoundManager.Toggle(); // Toggle play/pause

            if (SoundManager.IsPlaying)
                btnSound.Image = Properties.Resources.play; // Change to playing icon
            else
                btnSound.Image = Properties.Resources.mute; // Change to mute icon
        }

        
    }
}