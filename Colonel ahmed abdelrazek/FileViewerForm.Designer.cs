using System.Windows.Forms;

namespace Colonel_ahmed_abdelrazek
{
    partial class FileViewerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.btnDeleteFile = new System.Windows.Forms.Button();
            this.btnRenameFile = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUploadFile = new System.Windows.Forms.Button();
            this.flpfile = new System.Windows.Forms.FlowLayoutPanel();
            this.btnSound = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnSound)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpenFile.Location = new System.Drawing.Point(627, 81);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(75, 23);
            this.btnOpenFile.TabIndex = 1;
            this.btnOpenFile.Text = "فتح الملف";
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // back
            // 
            this.back.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.back.Location = new System.Drawing.Point(12, 415);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(75, 23);
            this.back.TabIndex = 2;
            this.back.Text = "رجوع";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // btnDeleteFile
            // 
            this.btnDeleteFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteFile.Location = new System.Drawing.Point(627, 110);
            this.btnDeleteFile.Name = "btnDeleteFile";
            this.btnDeleteFile.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteFile.TabIndex = 3;
            this.btnDeleteFile.Text = "حذف الملف";
            this.btnDeleteFile.UseVisualStyleBackColor = true;
            this.btnDeleteFile.Click += new System.EventHandler(this.btnDeleteFile_Click);
            // 
            // btnRenameFile
            // 
            this.btnRenameFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRenameFile.Location = new System.Drawing.Point(627, 139);
            this.btnRenameFile.Name = "btnRenameFile";
            this.btnRenameFile.Size = new System.Drawing.Size(75, 23);
            this.btnRenameFile.TabIndex = 4;
            this.btnRenameFile.Text = "إعادة تسمية";
            this.btnRenameFile.UseVisualStyleBackColor = true;
            this.btnRenameFile.Click += new System.EventHandler(this.btnRenameFile_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Location = new System.Drawing.Point(627, 37);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(100, 20);
            this.txtSearch.TabIndex = 5;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(701, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "بحث";
            // 
            // btnUploadFile
            // 
            this.btnUploadFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUploadFile.Location = new System.Drawing.Point(627, 169);
            this.btnUploadFile.Name = "btnUploadFile";
            this.btnUploadFile.Size = new System.Drawing.Size(75, 23);
            this.btnUploadFile.TabIndex = 7;
            this.btnUploadFile.Text = "اضافة ملف";
            this.btnUploadFile.UseVisualStyleBackColor = true;
            this.btnUploadFile.Click += new System.EventHandler(this.btnUploadFile_Click);
            // 
            // flpfile
            // 
            this.flpfile.AutoScroll = true;
            this.flpfile.BackColor = System.Drawing.Color.Transparent;
            this.flpfile.Location = new System.Drawing.Point(12, 37);
            this.flpfile.Name = "flpfile";
            this.flpfile.Size = new System.Drawing.Size(296, 352);
            this.flpfile.TabIndex = 7;
            // 
            // btnSound
            // 
            this.btnSound.BackColor = System.Drawing.Color.Transparent;
            this.btnSound.Image = global::Colonel_ahmed_abdelrazek.Properties.Resources.play;
            this.btnSound.Location = new System.Drawing.Point(12, 12);
            this.btnSound.Name = "btnSound";
            this.btnSound.Size = new System.Drawing.Size(29, 25);
            this.btnSound.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnSound.TabIndex = 8;
            this.btnSound.TabStop = false;
            this.btnSound.Click += new System.EventHandler(this.btnSound_Click);
            // 
            // FileViewerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Colonel_ahmed_abdelrazek.Properties.Resources.images__3_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSound);
            this.Controls.Add(this.flpfile);
            this.Controls.Add(this.btnUploadFile);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnRenameFile);
            this.Controls.Add(this.btnDeleteFile);
            this.Controls.Add(this.back);
            this.Controls.Add(this.btnOpenFile);
            this.Name = "FileViewerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "المحتوى";
            this.Load += new System.EventHandler(this.FileViewerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnSound)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button btnDeleteFile;
        private System.Windows.Forms.Button btnRenameFile;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label1;
        private Button btnUploadFile;
        private FlowLayoutPanel flpfile;
        private PictureBox btnSound;
    }
}