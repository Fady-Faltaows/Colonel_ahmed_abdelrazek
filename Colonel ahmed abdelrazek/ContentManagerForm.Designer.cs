using System.Windows.Forms;

namespace Colonel_ahmed_abdelrazek
{
    partial class ContentManagerForm
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
            this.back = new System.Windows.Forms.Button();
            this.btnAddBab = new System.Windows.Forms.Button();
            this.btnDeleteBab = new System.Windows.Forms.Button();
            this.btnRenameBab = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.flpAbwab = new System.Windows.Forms.FlowLayoutPanel();
            this.open = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // back
            // 
            this.back.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.back.Location = new System.Drawing.Point(12, 415);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(75, 23);
            this.back.TabIndex = 0;
            this.back.Text = "الرئيسية";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAddBab
            // 
            this.btnAddBab.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddBab.Location = new System.Drawing.Point(615, 95);
            this.btnAddBab.Name = "btnAddBab";
            this.btnAddBab.Size = new System.Drawing.Size(96, 23);
            this.btnAddBab.TabIndex = 2;
            this.btnAddBab.Text = "اضافة باب";
            this.btnAddBab.UseVisualStyleBackColor = true;
            this.btnAddBab.Click += new System.EventHandler(this.btnAddBab_Click);
            // 
            // btnDeleteBab
            // 
            this.btnDeleteBab.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteBab.Location = new System.Drawing.Point(615, 140);
            this.btnDeleteBab.Name = "btnDeleteBab";
            this.btnDeleteBab.Size = new System.Drawing.Size(96, 23);
            this.btnDeleteBab.TabIndex = 3;
            this.btnDeleteBab.Text = "حذف باب";
            this.btnDeleteBab.UseVisualStyleBackColor = true;
            this.btnDeleteBab.Click += new System.EventHandler(this.btnDeleteBab_Click);
            // 
            // btnRenameBab
            // 
            this.btnRenameBab.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRenameBab.Location = new System.Drawing.Point(615, 187);
            this.btnRenameBab.Name = "btnRenameBab";
            this.btnRenameBab.Size = new System.Drawing.Size(96, 23);
            this.btnRenameBab.TabIndex = 4;
            this.btnRenameBab.Text = "تعديل اسم الباب";
            this.btnRenameBab.UseVisualStyleBackColor = true;
            this.btnRenameBab.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(353, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(435, 30);
            this.label1.TabIndex = 5;
            this.label1.Text = "المرجع الموحد عامل تشغيل وصيانة قوي كهربائية";
            // 
            // flpAbwab
            // 
            this.flpAbwab.AutoScroll = true;
            this.flpAbwab.BackColor = System.Drawing.Color.Transparent;
            this.flpAbwab.Location = new System.Drawing.Point(12, 9);
            this.flpAbwab.Name = "flpAbwab";
            this.flpAbwab.Size = new System.Drawing.Size(296, 380);
            this.flpAbwab.TabIndex = 6;
            // 
            // open
            // 
            this.open.Location = new System.Drawing.Point(615, 56);
            this.open.Name = "open";
            this.open.Size = new System.Drawing.Size(96, 23);
            this.open.TabIndex = 7;
            this.open.Text = "فتح الباب";
            this.open.UseVisualStyleBackColor = true;
            this.open.Click += new System.EventHandler(this.open_Click);
            // 
            // ContentManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Colonel_ahmed_abdelrazek.Properties.Resources.images__3_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.open);
            this.Controls.Add(this.flpAbwab);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRenameBab);
            this.Controls.Add(this.btnDeleteBab);
            this.Controls.Add(this.btnAddBab);
            this.Controls.Add(this.back);
            this.Name = "ContentManagerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ادارة الابواب";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button btnAddBab;
        private System.Windows.Forms.Button btnDeleteBab;
        private System.Windows.Forms.Button btnRenameBab;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flpAbwab;
        private Button open;
    }
}
