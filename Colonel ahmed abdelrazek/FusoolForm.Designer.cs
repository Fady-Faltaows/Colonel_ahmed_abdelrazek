namespace Colonel_ahmed_abdelrazek
{
    partial class FusoolForm
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
            this.btnAddFasl = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnDeleteFasl = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.flpfsl = new System.Windows.Forms.FlowLayoutPanel();
            this.btnSound = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.btnSound)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddFasl
            // 
            this.btnAddFasl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddFasl.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddFasl.Location = new System.Drawing.Point(601, 208);
            this.btnAddFasl.Name = "btnAddFasl";
            this.btnAddFasl.Size = new System.Drawing.Size(119, 41);
            this.btnAddFasl.TabIndex = 1;
            this.btnAddFasl.Text = "إضافة فصل";
            this.btnAddFasl.UseVisualStyleBackColor = true;
            this.btnAddFasl.Click += new System.EventHandler(this.btnAddFasl_Click);
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnBack.Location = new System.Drawing.Point(12, 415);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "رجوع";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnDeleteFasl
            // 
            this.btnDeleteFasl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteFasl.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteFasl.Location = new System.Drawing.Point(601, 112);
            this.btnDeleteFasl.Name = "btnDeleteFasl";
            this.btnDeleteFasl.Size = new System.Drawing.Size(119, 42);
            this.btnDeleteFasl.TabIndex = 3;
            this.btnDeleteFasl.Text = "حذف الفصل";
            this.btnDeleteFasl.UseVisualStyleBackColor = true;
            this.btnDeleteFasl.Click += new System.EventHandler(this.btnDeleteFasl_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(601, 160);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(119, 42);
            this.button2.TabIndex = 4;
            this.button2.Text = "تعديل الاسم";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // flpfsl
            // 
            this.flpfsl.AutoScroll = true;
            this.flpfsl.BackColor = System.Drawing.Color.Transparent;
            this.flpfsl.Location = new System.Drawing.Point(13, 42);
            this.flpfsl.Name = "flpfsl";
            this.flpfsl.Size = new System.Drawing.Size(309, 367);
            this.flpfsl.TabIndex = 5;
            // 
            // btnSound
            // 
            this.btnSound.BackColor = System.Drawing.Color.Transparent;
            this.btnSound.Image = global::Colonel_ahmed_abdelrazek.Properties.Resources.play;
            this.btnSound.Location = new System.Drawing.Point(12, 11);
            this.btnSound.Name = "btnSound";
            this.btnSound.Size = new System.Drawing.Size(29, 25);
            this.btnSound.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnSound.TabIndex = 7;
            this.btnSound.TabStop = false;
            this.btnSound.Click += new System.EventHandler(this.btnSound_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackgroundImage = global::Colonel_ahmed_abdelrazek.Properties.Resources.images__3_;
            this.button1.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(419, 389);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(310, 36);
            this.button1.TabIndex = 8;
            this.button1.Text = "علم     عزم    عزه";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // FusoolForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImage = global::Colonel_ahmed_abdelrazek.Properties.Resources.images__3_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSound);
            this.Controls.Add(this.flpfsl);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnDeleteFasl);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnAddFasl);
            this.Name = "FusoolForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "إدارة الفصول";
            this.Load += new System.EventHandler(this.FusoolForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnSound)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAddFasl;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnDeleteFasl;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.FlowLayoutPanel flpfsl;
        private System.Windows.Forms.PictureBox btnSound;
        private System.Windows.Forms.Button button1;
    }
}