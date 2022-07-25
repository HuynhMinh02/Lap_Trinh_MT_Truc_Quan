namespace CheckListBox
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
            this.btn_ChonMot = new System.Windows.Forms.Button();
            this.btn_ChonNhieu = new System.Windows.Forms.Button();
            this.btn_BoMot = new System.Windows.Forms.Button();
            this.btn_BoNhieu = new System.Windows.Forms.Button();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.lbChonTen = new System.Windows.Forms.ListBox();
            this.lbTenChon = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btn_ChonMot
            // 
            this.btn_ChonMot.Location = new System.Drawing.Point(299, 51);
            this.btn_ChonMot.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btn_ChonMot.Name = "btn_ChonMot";
            this.btn_ChonMot.Size = new System.Drawing.Size(118, 43);
            this.btn_ChonMot.TabIndex = 2;
            this.btn_ChonMot.Text = ">";
            this.btn_ChonMot.UseVisualStyleBackColor = true;
            this.btn_ChonMot.Click += new System.EventHandler(this.btn_ChonMot_Click);
            // 
            // btn_ChonNhieu
            // 
            this.btn_ChonNhieu.Location = new System.Drawing.Point(299, 117);
            this.btn_ChonNhieu.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btn_ChonNhieu.Name = "btn_ChonNhieu";
            this.btn_ChonNhieu.Size = new System.Drawing.Size(118, 43);
            this.btn_ChonNhieu.TabIndex = 3;
            this.btn_ChonNhieu.Text = ">>";
            this.btn_ChonNhieu.UseVisualStyleBackColor = true;
            this.btn_ChonNhieu.Click += new System.EventHandler(this.btn_ChonNhieu_Click);
            // 
            // btn_BoMot
            // 
            this.btn_BoMot.Location = new System.Drawing.Point(299, 197);
            this.btn_BoMot.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btn_BoMot.Name = "btn_BoMot";
            this.btn_BoMot.Size = new System.Drawing.Size(118, 38);
            this.btn_BoMot.TabIndex = 4;
            this.btn_BoMot.Text = "<";
            this.btn_BoMot.UseVisualStyleBackColor = true;
            this.btn_BoMot.Click += new System.EventHandler(this.btn_BoMot_Click);
            // 
            // btn_BoNhieu
            // 
            this.btn_BoNhieu.Location = new System.Drawing.Point(299, 271);
            this.btn_BoNhieu.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btn_BoNhieu.Name = "btn_BoNhieu";
            this.btn_BoNhieu.Size = new System.Drawing.Size(118, 42);
            this.btn_BoNhieu.TabIndex = 5;
            this.btn_BoNhieu.Text = "<<";
            this.btn_BoNhieu.UseVisualStyleBackColor = true;
            this.btn_BoNhieu.Click += new System.EventHandler(this.btn_BoNhieu_Click);
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Location = new System.Drawing.Point(510, 411);
            this.btn_Thoat.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(118, 42);
            this.btn_Thoat.TabIndex = 6;
            this.btn_Thoat.Text = "EXIT";
            this.btn_Thoat.UseVisualStyleBackColor = true;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // btn_Reset
            // 
            this.btn_Reset.Location = new System.Drawing.Point(67, 411);
            this.btn_Reset.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(118, 42);
            this.btn_Reset.TabIndex = 7;
            this.btn_Reset.Text = "RESET";
            this.btn_Reset.UseVisualStyleBackColor = true;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // lbChonTen
            // 
            this.lbChonTen.FormattingEnabled = true;
            this.lbChonTen.ItemHeight = 22;
            this.lbChonTen.Location = new System.Drawing.Point(19, 18);
            this.lbChonTen.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.lbChonTen.Name = "lbChonTen";
            this.lbChonTen.Size = new System.Drawing.Size(251, 312);
            this.lbChonTen.TabIndex = 0;
            // 
            // lbTenChon
            // 
            this.lbTenChon.FormattingEnabled = true;
            this.lbTenChon.ItemHeight = 22;
            this.lbTenChon.Location = new System.Drawing.Point(449, 18);
            this.lbTenChon.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.lbTenChon.Name = "lbTenChon";
            this.lbTenChon.Size = new System.Drawing.Size(251, 312);
            this.lbTenChon.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(721, 489);
            this.Controls.Add(this.btn_Reset);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.btn_BoNhieu);
            this.Controls.Add(this.btn_BoMot);
            this.Controls.Add(this.btn_ChonNhieu);
            this.Controls.Add(this.btn_ChonMot);
            this.Controls.Add(this.lbTenChon);
            this.Controls.Add(this.lbChonTen);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private Button btn_ChonMot;
        private Button btn_ChonNhieu;
        private Button btn_BoMot;
        private Button btn_BoNhieu;
        private Button btn_Thoat;
        private Button btn_Reset;
        private ListBox lbChonTen;
        private ListBox lbTenChon;
    }
}