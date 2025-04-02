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
    public partial class FusoolForm : Form
    {
        private string babPath;
        private Button selectedButton = null;

        public FusoolForm(string babPath)
        {
            InitializeComponent();
            this.babPath = babPath;
            LoadFusool();
        }

        private void LoadFusool()
        {
            flpfsl.Controls.Clear();

            if (!Directory.Exists(babPath))
            {
                MessageBox.Show("المجلد غير موجود!");
                return;
            }

            string[] fusool = Directory.GetDirectories(babPath);
            foreach (string fasl in fusool)
            {
                AddFaslButton(Path.GetFileName(fasl));
            }
        }

        // ✅ Create فصل buttons with single & double click support
        private void AddFaslButton(string faslName)
        {
            Button btnFasl = new Button
            {
                Text = faslName,
                Font = new Font("Tahoma", 12, FontStyle.Bold),
                Size = new Size(200, 50),
                TextAlign = ContentAlignment.MiddleCenter,
                FlatStyle = FlatStyle.Flat,
                BackColor = Color.LightBlue,
                ForeColor = Color.Black,
                Tag = faslName // Store name for reference
            };

            // ✅ Enable DoubleClick support
            btnFasl.MouseDown += FaslButton_MouseDown;
            flpfsl.Controls.Add(btnFasl);
        }

        // ✅ Handle Single and Double Clicks
        private void FaslButton_MouseDown(object sender, MouseEventArgs e)
        {
            Button clickedButton = sender as Button;
            if (clickedButton == null) return;

            if (e.Clicks == 2) // Detect double-click manually
            {
                OpenFasl(Path.Combine(babPath, clickedButton.Text));
            }
            else if (e.Clicks == 1)
            {
                SelectFasl(clickedButton);
            }
        }

        // ✅ Handle selection logic
        private void SelectFasl(Button btnFasl)
        {
            if (selectedButton != null)
                selectedButton.BackColor = Color.LightBlue; // Reset previous selection

            selectedButton = btnFasl;
            selectedButton.BackColor = Color.LightGreen; // Highlight selected
        }

        private void btnAddFasl_Click(object sender, EventArgs e)
        {
            string newFasl = Prompt.ShowDialog("أدخل اسم الفصل الجديد:", "إضافة فصل");

            if (!string.IsNullOrWhiteSpace(newFasl))
            {
                string newPath = Path.Combine(babPath, newFasl);
                if (!Directory.Exists(newPath))
                {
                    Directory.CreateDirectory(newPath);
                    LoadFusool();
                    MessageBox.Show("تمت إضافة الفصل بنجاح!");
                }
                else
                {
                    MessageBox.Show("هذا الفصل موجود بالفعل!");
                }
            }
        }

        private void btnDeleteFasl_Click(object sender, EventArgs e)
        {
            if (selectedButton != null)
            {
                string faslName = selectedButton.Text;
                string path = Path.Combine(babPath, faslName);
                DialogResult result = MessageBox.Show($"هل أنت متأكد من حذف الفصل '{faslName}'؟", "تأكيد الحذف", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes && Directory.Exists(path))
                {
                    Directory.Delete(path, true);
                    LoadFusool();
                    MessageBox.Show("تم حذف الفصل بنجاح!");
                }
            }
            else
            {
                MessageBox.Show("يرجى تحديد فصل أولاً!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (selectedButton != null)
            {
                string oldName = selectedButton.Text;
                string newName = Prompt.ShowDialog("أدخل الاسم الجديد للفصل:", "تعديل الفصل");

                if (!string.IsNullOrWhiteSpace(newName) && newName != oldName)
                {
                    string oldPath = Path.Combine(babPath, oldName);
                    string newPath = Path.Combine(babPath, newName);

                    if (!Directory.Exists(newPath))
                    {
                        Directory.Move(oldPath, newPath);
                        LoadFusool();
                        MessageBox.Show("تم تعديل اسم الفصل بنجاح!");
                    }
                    else
                    {
                        MessageBox.Show("اسم الفصل الجديد موجود بالفعل!");
                    }
                }
            }
            else
            {
                MessageBox.Show("يرجى تحديد فصل أولاً!");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FusoolForm_Load(object sender, EventArgs e)
        {
            SoundManager.Play(); // Play sound when the form loads
            btnSound.Image = Properties.Resources.play; // Set initial icon
        }

        private void OpenFasl(string faslPath)
        {
            if (Directory.Exists(faslPath))
            {
                FileViewerForm fileViewer = new FileViewerForm(faslPath);
                this.Hide();
                fileViewer.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("المجلد غير موجود!", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
