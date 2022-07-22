namespace TinhTienPhongKham
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.nhoRang = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.trongRang = new System.Windows.Forms.NumericUpDown();
            this.tayRang = new System.Windows.Forms.CheckBox();
            this.niengRang = new System.Windows.Forms.CheckBox();
            this.btn_TinhTien = new System.Windows.Forms.Button();
            this.txt_ten = new System.Windows.Forms.TextBox();
            this.txt_TinhTien = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nhoRang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trongRang)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(77, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(388, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "ỨNG DỤNG TÍNH TIỀN PHÒNG KHÁM";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(50, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Họ và tên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(50, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Giới tính";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(24, 297);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Dịch vụ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(242, 276);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 19);
            this.label6.TabIndex = 5;
            // 
            // nhoRang
            // 
            this.nhoRang.Location = new System.Drawing.Point(242, 394);
            this.nhoRang.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.nhoRang.Name = "nhoRang";
            this.nhoRang.Size = new System.Drawing.Size(67, 26);
            this.nhoRang.TabIndex = 7;
            this.nhoRang.ValueChanged += new System.EventHandler(this.nhoRang_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(113, 394);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 19);
            this.label7.TabIndex = 8;
            this.label7.Text = "Nhổ răng";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(113, 435);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 19);
            this.label8.TabIndex = 9;
            this.label8.Text = "Trồng răng";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // trongRang
            // 
            this.trongRang.Location = new System.Drawing.Point(242, 435);
            this.trongRang.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.trongRang.Name = "trongRang";
            this.trongRang.Size = new System.Drawing.Size(67, 26);
            this.trongRang.TabIndex = 10;
            this.trongRang.ValueChanged += new System.EventHandler(this.trongRang_ValueChanged);
            // 
            // tayRang
            // 
            this.tayRang.AutoSize = true;
            this.tayRang.Location = new System.Drawing.Point(113, 331);
            this.tayRang.Name = "tayRang";
            this.tayRang.Size = new System.Drawing.Size(93, 23);
            this.tayRang.TabIndex = 11;
            this.tayRang.Text = "Tẩy trắng";
            this.tayRang.UseVisualStyleBackColor = true;
            this.tayRang.CheckedChanged += new System.EventHandler(this.tayRang_CheckedChanged);
            // 
            // niengRang
            // 
            this.niengRang.AutoSize = true;
            this.niengRang.Location = new System.Drawing.Point(269, 331);
            this.niengRang.Name = "niengRang";
            this.niengRang.Size = new System.Drawing.Size(102, 23);
            this.niengRang.TabIndex = 12;
            this.niengRang.Text = "Niềng răng";
            this.niengRang.UseVisualStyleBackColor = true;
            this.niengRang.CheckedChanged += new System.EventHandler(this.niengRang_CheckedChanged);
            // 
            // btn_TinhTien
            // 
            this.btn_TinhTien.Location = new System.Drawing.Point(108, 515);
            this.btn_TinhTien.Name = "btn_TinhTien";
            this.btn_TinhTien.Size = new System.Drawing.Size(87, 23);
            this.btn_TinhTien.TabIndex = 13;
            this.btn_TinhTien.Text = "Tính tiền";
            this.btn_TinhTien.UseVisualStyleBackColor = true;
            this.btn_TinhTien.Click += new System.EventHandler(this.btn_TinhTien_Click);
            // 
            // txt_ten
            // 
            this.txt_ten.Location = new System.Drawing.Point(164, 125);
            this.txt_ten.Name = "txt_ten";
            this.txt_ten.Size = new System.Drawing.Size(246, 26);
            this.txt_ten.TabIndex = 14;
            this.txt_ten.TextChanged += new System.EventHandler(this.txt_ten_TextChanged);
            // 
            // txt_TinhTien
            // 
            this.txt_TinhTien.Location = new System.Drawing.Point(219, 515);
            this.txt_TinhTien.Name = "txt_TinhTien";
            this.txt_TinhTien.Size = new System.Drawing.Size(246, 26);
            this.txt_TinhTien.TabIndex = 15;
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteCustomSource.AddRange(new string[] {
            "Nam",
            "Nữ"});
            this.comboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(164, 168);
            this.comboBox1.MaxDropDownItems = 3;
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(108, 27);
            this.comboBox1.TabIndex = 16;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(24, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Thông tin khách hàng";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(544, 570);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.txt_TinhTien);
            this.Controls.Add(this.txt_ten);
            this.Controls.Add(this.btn_TinhTien);
            this.Controls.Add(this.niengRang);
            this.Controls.Add(this.tayRang);
            this.Controls.Add(this.trongRang);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.nhoRang);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nhoRang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trongRang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private NumericUpDown nhoRang;
        private Label label7;
        private Label label8;
        private NumericUpDown trongRang;
        private CheckBox tayRang;
        private CheckBox niengRang;
        private Button btn_TinhTien;
        private TextBox txt_ten;
        private TextBox txt_TinhTien;
        private ComboBox comboBox1;
        private Label label2;
    }
}