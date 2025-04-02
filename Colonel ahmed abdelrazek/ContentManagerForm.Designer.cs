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
            this.btnSound = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.btnSound)).BeginInit();
            this.SuspendLayout();
            // 
            // back
            // 
            this.back.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.back.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.Location = new System.Drawing.Point(12, 405);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(93, 34);
            this.back.TabIndex = 0;
            this.back.Text = "الرئيسية";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAddBab
            // 
            this.btnAddBab.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddBab.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddBab.Location = new System.Drawing.Point(591, 148);
            this.btnAddBab.Name = "btnAddBab";
            this.btnAddBab.Size = new System.Drawing.Size(120, 44);
            this.btnAddBab.TabIndex = 2;
            this.btnAddBab.Text = "اضافة باب";
            this.btnAddBab.UseVisualStyleBackColor = true;
            this.btnAddBab.Click += new System.EventHandler(this.btnAddBab_Click);
            // 
            // btnDeleteBab
            // 
            this.btnDeleteBab.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteBab.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteBab.Location = new System.Drawing.Point(591, 48);
            this.btnDeleteBab.Name = "btnDeleteBab";
            this.btnDeleteBab.Size = new System.Drawing.Size(120, 44);
            this.btnDeleteBab.TabIndex = 3;
            this.btnDeleteBab.Text = "حذف الباب";
            this.btnDeleteBab.UseVisualStyleBackColor = true;
            this.btnDeleteBab.Click += new System.EventHandler(this.btnDeleteBab_Click);
            // 
            // btnRenameBab
            // 
            this.btnRenameBab.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRenameBab.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRenameBab.Location = new System.Drawing.Point(591, 98);
            this.btnRenameBab.Name = "btnRenameBab";
            this.btnRenameBab.Size = new System.Drawing.Size(120, 44);
            this.btnRenameBab.TabIndex = 4;
            this.btnRenameBab.Text = "تعديل الاسم";
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
            this.flpAbwab.Location = new System.Drawing.Point(12, 48);
            this.flpAbwab.Name = "flpAbwab";
            this.flpAbwab.Size = new System.Drawing.Size(296, 341);
            this.flpAbwab.TabIndex = 6;
            // 
            // btnSound
            // 
            this.btnSound.BackColor = System.Drawing.Color.Transparent;
            this.btnSound.Image = global::Colonel_ahmed_abdelrazek.Properties.Resources.play;
            this.btnSound.Location = new System.Drawing.Point(12, 9);
            this.btnSound.Name = "btnSound";
            this.btnSound.Size = new System.Drawing.Size(29, 25);
            this.btnSound.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnSound.TabIndex = 8;
            this.btnSound.TabStop = false;
            this.btnSound.Click += new System.EventHandler(this.btnSound_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.AutoEllipsis = true;
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(338, 360);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 79);
            this.button1.TabIndex = 9;
            this.button1.Text = "أن لم تتألم\r\n...\r\nلن تتعلم";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // ContentManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Colonel_ahmed_abdelrazek.Properties.Resources.images__3_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSound);
            this.Controls.Add(this.flpAbwab);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRenameBab);
            this.Controls.Add(this.btnDeleteBab);
            this.Controls.Add(this.btnAddBab);
            this.Controls.Add(this.back);
            this.Name = "ContentManagerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ادارة الابواب";
            ((System.ComponentModel.ISupportInitialize)(this.btnSound)).EndInit();
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
        private PictureBox btnSound;
        private Button button1;
    }
}
