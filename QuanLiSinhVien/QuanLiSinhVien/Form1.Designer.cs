namespace QuanLiSinhVien
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGV = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_MaKhoa = new System.Windows.Forms.TextBox();
            this.cb_GT = new System.Windows.Forms.ComboBox();
            this.dt_Ngaysinh = new System.Windows.Forms.DateTimePicker();
            this.txt_TenSV = new System.Windows.Forms.TextBox();
            this.txt_HoSV = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_MaSV = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_Them = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Luu = new System.Windows.Forms.Button();
            this.btn_Huy = new System.Windows.Forms.Button();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGV)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGV);
            this.groupBox1.Location = new System.Drawing.Point(63, 319);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(875, 300);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Sinh Viên";
            // 
            // dataGV
            // 
            this.dataGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGV.Location = new System.Drawing.Point(18, 25);
            this.dataGV.Name = "dataGV";
            this.dataGV.RowTemplate.Height = 25;
            this.dataGV.Size = new System.Drawing.Size(838, 259);
            this.dataGV.TabIndex = 0;
            this.dataGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGV_CellContentClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_MaKhoa);
            this.groupBox2.Controls.Add(this.cb_GT);
            this.groupBox2.Controls.Add(this.dt_Ngaysinh);
            this.groupBox2.Controls.Add(this.txt_TenSV);
            this.groupBox2.Controls.Add(this.txt_HoSV);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txt_MaSV);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(63, 109);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(625, 204);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Điền Thông Tin Sinh Viên";
            // 
            // txt_MaKhoa
            // 
            this.txt_MaKhoa.Location = new System.Drawing.Point(124, 160);
            this.txt_MaKhoa.Name = "txt_MaKhoa";
            this.txt_MaKhoa.Size = new System.Drawing.Size(151, 26);
            this.txt_MaKhoa.TabIndex = 11;
            // 
            // cb_GT
            // 
            this.cb_GT.FormattingEnabled = true;
            this.cb_GT.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cb_GT.Location = new System.Drawing.Point(379, 117);
            this.cb_GT.Name = "cb_GT";
            this.cb_GT.Size = new System.Drawing.Size(151, 27);
            this.cb_GT.TabIndex = 10;
            // 
            // dt_Ngaysinh
            // 
            this.dt_Ngaysinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_Ngaysinh.Location = new System.Drawing.Point(124, 120);
            this.dt_Ngaysinh.Name = "dt_Ngaysinh";
            this.dt_Ngaysinh.Size = new System.Drawing.Size(96, 26);
            this.dt_Ngaysinh.TabIndex = 9;
            // 
            // txt_TenSV
            // 
            this.txt_TenSV.Location = new System.Drawing.Point(379, 77);
            this.txt_TenSV.Name = "txt_TenSV";
            this.txt_TenSV.Size = new System.Drawing.Size(151, 26);
            this.txt_TenSV.TabIndex = 8;
            // 
            // txt_HoSV
            // 
            this.txt_HoSV.Location = new System.Drawing.Point(102, 77);
            this.txt_HoSV.Name = "txt_HoSV";
            this.txt_HoSV.Size = new System.Drawing.Size(187, 26);
            this.txt_HoSV.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(301, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 19);
            this.label6.TabIndex = 6;
            this.label6.Text = "Giới tính:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 19);
            this.label5.TabIndex = 5;
            this.label5.Text = "Mã Khoa:";
            // 
            // txt_MaSV
            // 
            this.txt_MaSV.Location = new System.Drawing.Point(102, 38);
            this.txt_MaSV.Name = "txt_MaSV";
            this.txt_MaSV.Size = new System.Drawing.Size(108, 26);
            this.txt_MaSV.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ngày Sinh:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(310, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên SV:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Họ SV:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã SV:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Yellow;
            this.label7.Font = new System.Drawing.Font("Segoe Script", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(202, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(657, 51);
            this.label7.TabIndex = 10;
            this.label7.Text = "CHƯƠNG TRÌNH QUẢN LÍ SINH VIÊN";
            // 
            // btn_Them
            // 
            this.btn_Them.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Them.ForeColor = System.Drawing.Color.Red;
            this.btn_Them.Location = new System.Drawing.Point(63, 635);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(92, 34);
            this.btn_Them.TabIndex = 11;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Sua.ForeColor = System.Drawing.Color.Red;
            this.btn_Sua.Location = new System.Drawing.Point(202, 635);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(92, 34);
            this.btn_Sua.TabIndex = 12;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Xoa.ForeColor = System.Drawing.Color.Red;
            this.btn_Xoa.Location = new System.Drawing.Point(364, 635);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(92, 34);
            this.btn_Xoa.TabIndex = 13;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Luu
            // 
            this.btn_Luu.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Luu.ForeColor = System.Drawing.Color.Red;
            this.btn_Luu.Location = new System.Drawing.Point(519, 635);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Size = new System.Drawing.Size(92, 34);
            this.btn_Luu.TabIndex = 14;
            this.btn_Luu.Text = "Lưu";
            this.btn_Luu.UseVisualStyleBackColor = true;
            // 
            // btn_Huy
            // 
            this.btn_Huy.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Huy.ForeColor = System.Drawing.Color.Red;
            this.btn_Huy.Location = new System.Drawing.Point(680, 635);
            this.btn_Huy.Name = "btn_Huy";
            this.btn_Huy.Size = new System.Drawing.Size(92, 34);
            this.btn_Huy.TabIndex = 15;
            this.btn_Huy.Text = "Hủy";
            this.btn_Huy.UseVisualStyleBackColor = true;
            this.btn_Huy.Click += new System.EventHandler(this.btn_Huy_Click);
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Thoat.ForeColor = System.Drawing.Color.Red;
            this.btn_Thoat.Location = new System.Drawing.Point(846, 635);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(92, 34);
            this.btn_Thoat.TabIndex = 16;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(1029, 681);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.btn_Huy);
            this.Controls.Add(this.btn_Luu);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGV)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox groupBox1;
        private DataGridView dataGV;
        private GroupBox groupBox2;
        private DateTimePicker dt_Ngaysinh;
        private TextBox txt_TenSV;
        private TextBox txt_HoSV;
        private Label label6;
        private Label label5;
        private TextBox txt_MaSV;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox cb_GT;
        private Label label7;
        private TextBox txt_MaKhoa;
        private Button btn_Them;
        private Button btn_Sua;
        private Button btn_Xoa;
        private Button btn_Luu;
        private Button btn_Huy;
        private Button btn_Thoat;
    }
}