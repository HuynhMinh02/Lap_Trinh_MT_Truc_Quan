namespace DocSoThanhChu
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.bntThoat = new System.Windows.Forms.Button();
            this.bntXoa = new System.Windows.Forms.Button();
            this.bntGiai = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtWrite = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRead = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bntThoat
            // 
            this.bntThoat.BackColor = System.Drawing.Color.Red;
            this.bntThoat.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bntThoat.Location = new System.Drawing.Point(263, 225);
            this.bntThoat.Name = "bntThoat";
            this.bntThoat.Size = new System.Drawing.Size(89, 31);
            this.bntThoat.TabIndex = 0;
            this.bntThoat.Text = "THOÁT";
            this.bntThoat.UseVisualStyleBackColor = false;
            this.bntThoat.Click += new System.EventHandler(this.bntThoat_Click);
            // 
            // bntXoa
            // 
            this.bntXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.bntXoa.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bntXoa.Location = new System.Drawing.Point(138, 225);
            this.bntXoa.Name = "bntXoa";
            this.bntXoa.Size = new System.Drawing.Size(89, 31);
            this.bntXoa.TabIndex = 1;
            this.bntXoa.Text = "XÓA";
            this.bntXoa.UseVisualStyleBackColor = false;
            this.bntXoa.Click += new System.EventHandler(this.bntXoa_Click);
            // 
            // bntGiai
            // 
            this.bntGiai.BackColor = System.Drawing.Color.Lime;
            this.bntGiai.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bntGiai.Location = new System.Drawing.Point(12, 225);
            this.bntGiai.Name = "bntGiai";
            this.bntGiai.Size = new System.Drawing.Size(104, 31);
            this.bntGiai.TabIndex = 2;
            this.bntGiai.Text = "THỰC HIỆN";
            this.bntGiai.UseVisualStyleBackColor = false;
            this.bntGiai.Click += new System.EventHandler(this.bntGiai_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(118, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "ĐỌC SỐ ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtWrite
            // 
            this.txtWrite.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtWrite.Location = new System.Drawing.Point(115, 81);
            this.txtWrite.Multiline = true;
            this.txtWrite.Name = "txtWrite";
            this.txtWrite.Size = new System.Drawing.Size(230, 31);
            this.txtWrite.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nhập số n:";
            // 
            // txtRead
            // 
            this.txtRead.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtRead.Location = new System.Drawing.Point(21, 158);
            this.txtRead.Multiline = true;
            this.txtRead.Name = "txtRead";
            this.txtRead.Size = new System.Drawing.Size(324, 49);
            this.txtRead.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(21, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 22);
            this.label3.TabIndex = 7;
            this.label3.Text = "ĐỌC:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(362, 268);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtRead);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtWrite);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bntGiai);
            this.Controls.Add(this.bntXoa);
            this.Controls.Add(this.bntThoat);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button bntThoat;
        private Button bntXoa;
        private Button bntGiai;
        private Label label1;
        private TextBox txtWrite;
        private Label label2;
        private TextBox txtRead;
        private Label label3;
    }
}