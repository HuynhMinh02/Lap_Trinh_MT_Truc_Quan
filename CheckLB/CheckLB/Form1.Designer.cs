namespace CheckLB
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
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.btn_ChonMot = new System.Windows.Forms.Button();
            this.btn_ChonNhieu = new System.Windows.Forms.Button();
            this.btn_XoaMot = new System.Windows.Forms.Button();
            this.btn_XoaNhieu = new System.Windows.Forms.Button();
            this.checkedListBox2 = new System.Windows.Forms.CheckedListBox();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Tí",
            "Tèo",
            "Chuột",
            "Cu",
            "Đen",
            "Đỏ"});
            this.checkedListBox1.Location = new System.Drawing.Point(12, 12);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(188, 244);
            this.checkedListBox1.TabIndex = 0;
            // 
            // btn_ChonMot
            // 
            this.btn_ChonMot.Location = new System.Drawing.Point(234, 41);
            this.btn_ChonMot.Name = "btn_ChonMot";
            this.btn_ChonMot.Size = new System.Drawing.Size(75, 28);
            this.btn_ChonMot.TabIndex = 1;
            this.btn_ChonMot.Text = ">";
            this.btn_ChonMot.UseVisualStyleBackColor = true;
            this.btn_ChonMot.Click += new System.EventHandler(this.btn_ChonMot_Click);
            // 
            // btn_ChonNhieu
            // 
            this.btn_ChonNhieu.Location = new System.Drawing.Point(234, 105);
            this.btn_ChonNhieu.Name = "btn_ChonNhieu";
            this.btn_ChonNhieu.Size = new System.Drawing.Size(75, 28);
            this.btn_ChonNhieu.TabIndex = 2;
            this.btn_ChonNhieu.Text = ">>";
            this.btn_ChonNhieu.UseVisualStyleBackColor = true;
            this.btn_ChonNhieu.Click += new System.EventHandler(this.btn_ChonNhieu_Click);
            // 
            // btn_XoaMot
            // 
            this.btn_XoaMot.Location = new System.Drawing.Point(234, 169);
            this.btn_XoaMot.Name = "btn_XoaMot";
            this.btn_XoaMot.Size = new System.Drawing.Size(75, 28);
            this.btn_XoaMot.TabIndex = 3;
            this.btn_XoaMot.Text = "<";
            this.btn_XoaMot.UseVisualStyleBackColor = true;
            this.btn_XoaMot.Click += new System.EventHandler(this.btn_XoaMot_Click);
            // 
            // btn_XoaNhieu
            // 
            this.btn_XoaNhieu.Location = new System.Drawing.Point(234, 228);
            this.btn_XoaNhieu.Name = "btn_XoaNhieu";
            this.btn_XoaNhieu.Size = new System.Drawing.Size(75, 28);
            this.btn_XoaNhieu.TabIndex = 4;
            this.btn_XoaNhieu.Text = "<<";
            this.btn_XoaNhieu.UseVisualStyleBackColor = true;
            this.btn_XoaNhieu.Click += new System.EventHandler(this.btn_XoaNhieu_Click);
            // 
            // checkedListBox2
            // 
            this.checkedListBox2.FormattingEnabled = true;
            this.checkedListBox2.Location = new System.Drawing.Point(348, 12);
            this.checkedListBox2.Name = "checkedListBox2";
            this.checkedListBox2.Size = new System.Drawing.Size(188, 244);
            this.checkedListBox2.TabIndex = 5;
            // 
            // btn_Exit
            // 
            this.btn_Exit.Location = new System.Drawing.Point(217, 311);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(109, 28);
            this.btn_Exit.TabIndex = 6;
            this.btn_Exit.Text = "EXIT";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(548, 386);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.checkedListBox2);
            this.Controls.Add(this.btn_XoaNhieu);
            this.Controls.Add(this.btn_XoaMot);
            this.Controls.Add(this.btn_ChonNhieu);
            this.Controls.Add(this.btn_ChonMot);
            this.Controls.Add(this.checkedListBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private CheckedListBox checkedListBox1;
        private Button btn_ChonMot;
        private Button btn_ChonNhieu;
        private Button btn_XoaMot;
        private Button btn_XoaNhieu;
        private CheckedListBox checkedListBox2;
        private Button btn_Exit;
    }
}