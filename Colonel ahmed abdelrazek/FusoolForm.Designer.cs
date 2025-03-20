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
            this.btnopen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddFasl
            // 
            this.btnAddFasl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddFasl.Location = new System.Drawing.Point(702, 42);
            this.btnAddFasl.Name = "btnAddFasl";
            this.btnAddFasl.Size = new System.Drawing.Size(86, 23);
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
            this.btnDeleteFasl.Location = new System.Drawing.Point(702, 71);
            this.btnDeleteFasl.Name = "btnDeleteFasl";
            this.btnDeleteFasl.Size = new System.Drawing.Size(86, 23);
            this.btnDeleteFasl.TabIndex = 3;
            this.btnDeleteFasl.Text = "حذف فصل";
            this.btnDeleteFasl.UseVisualStyleBackColor = true;
            this.btnDeleteFasl.Click += new System.EventHandler(this.btnDeleteFasl_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(702, 100);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "تعديل اسم فصل";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // flpfsl
            // 
            this.flpfsl.AutoScroll = true;
            this.flpfsl.BackColor = System.Drawing.Color.Transparent;
            this.flpfsl.Location = new System.Drawing.Point(13, 13);
            this.flpfsl.Name = "flpfsl";
            this.flpfsl.Size = new System.Drawing.Size(309, 396);
            this.flpfsl.TabIndex = 5;
            // 
            // btnopen
            // 
            this.btnopen.Location = new System.Drawing.Point(702, 13);
            this.btnopen.Name = "btnopen";
            this.btnopen.Size = new System.Drawing.Size(86, 23);
            this.btnopen.TabIndex = 6;
            this.btnopen.Text = "فتح الفصل";
            this.btnopen.UseVisualStyleBackColor = true;
            this.btnopen.Click += new System.EventHandler(this.btnopen_Click);
            // 
            // FusoolForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImage = global::Colonel_ahmed_abdelrazek.Properties.Resources.images__3_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnopen);
            this.Controls.Add(this.flpfsl);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnDeleteFasl);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnAddFasl);
            this.Name = "FusoolForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "إدارة الفصول";
            this.Load += new System.EventHandler(this.FusoolForm_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAddFasl;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnDeleteFasl;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.FlowLayoutPanel flpfsl;
        private System.Windows.Forms.Button btnopen;
    }
}