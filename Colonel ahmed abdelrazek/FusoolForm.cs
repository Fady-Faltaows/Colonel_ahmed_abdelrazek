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
        public FusoolForm(string babPath)
        {
            InitializeComponent();

            this.babPath = babPath;
            LoadFusool();
        }

        private void LoadFusool()
        {
            lstFusool.Items.Clear();

            if (!Directory.Exists(babPath))
            {
                MessageBox.Show("المجلد غير موجود!");
                return;
            }

            string[] fusool = Directory.GetDirectories(babPath);
            foreach (string fasl in fusool)
            {
                lstFusool.Items.Add(Path.GetFileName(fasl));
            }
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
                    lstFusool.Items.Add(newFasl);
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
            if (lstFusool.SelectedItem != null)
            {
                string selectedFasl = lstFusool.SelectedItem.ToString();
                string path = Path.Combine(babPath, selectedFasl);
                DialogResult result = MessageBox.Show($"هل أنت متأكد من حذف الفصل '{selectedFasl}'؟", "تأكيد الحذف", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes && Directory.Exists(path))
                {
                    Directory.Delete(path, true);
                    lstFusool.Items.Remove(selectedFasl);
                    MessageBox.Show("تم حذف الفصل بنجاح!");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (lstFusool.SelectedItem != null)
            {
                string oldName = lstFusool.SelectedItem.ToString();
                string newName = Prompt.ShowDialog("أدخل الاسم الجديد للفصل:", "تعديل الفصل");

                if (!string.IsNullOrWhiteSpace(newName) && newName != oldName)
                {
                    string oldPath = Path.Combine(babPath, oldName);
                    string newPath = Path.Combine(babPath, newName);

                    if (!Directory.Exists(newPath))
                    {
                        Directory.Move(oldPath, newPath);
                        lstFusool.Items[lstFusool.SelectedIndex] = newName;
                        MessageBox.Show("تم تعديل اسم الفصل بنجاح!");
                    }
                    else
                    {
                        MessageBox.Show("اسم الفصل الجديد موجود بالفعل!");
                    }
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FusoolForm_Load(object sender, EventArgs e)
        {

        }

        private void lstFusool_DoubleClick(object sender, EventArgs e)
        {
            if (lstFusool.SelectedItem != null)
            {
                string selectedFasl = lstFusool.SelectedItem.ToString();
                string faslFullPath = Path.Combine(babPath, selectedFasl);

                if (Directory.Exists(faslFullPath))
                {
                    FileViewerForm fileViewer = new FileViewerForm(faslFullPath);
                    this.Hide(); // Hide the current form
                    fileViewer.ShowDialog(); // Open the new form as a modal dialog
                    this.Close(); // Close the current form after the new form is closed
                }
                else
                {
                    MessageBox.Show("المجلد غير موجود!", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
