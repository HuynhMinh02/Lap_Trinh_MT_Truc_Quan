namespace Login
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
            this.cbmale = new System.Windows.Forms.CheckBox();
            this.cbFemale = new System.Windows.Forms.CheckBox();
            this.cbc = new System.Windows.Forms.CheckBox();
            this.cbASP = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.listInfo = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.image = new System.Windows.Forms.PictureBox();
            this.bntPic = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.image)).BeginInit();
            this.SuspendLayout();
            // 
            // cbmale
            // 
            this.cbmale.AutoSize = true;
            this.cbmale.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cbmale.Location = new System.Drawing.Point(399, 92);
            this.cbmale.Margin = new System.Windows.Forms.Padding(4);
            this.cbmale.Name = "cbmale";
            this.cbmale.Size = new System.Drawing.Size(64, 23);
            this.cbmale.TabIndex = 0;
            this.cbmale.Text = "Male";
            this.cbmale.UseVisualStyleBackColor = true;
            this.cbmale.CheckedChanged += new System.EventHandler(this.cbmale_CheckedChanged);
            // 
            // cbFemale
            // 
            this.cbFemale.AutoSize = true;
            this.cbFemale.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cbFemale.Location = new System.Drawing.Point(399, 149);
            this.cbFemale.Margin = new System.Windows.Forms.Padding(4);
            this.cbFemale.Name = "cbFemale";
            this.cbFemale.Size = new System.Drawing.Size(77, 23);
            this.cbFemale.TabIndex = 1;
            this.cbFemale.Text = "Female";
            this.cbFemale.UseVisualStyleBackColor = true;
            // 
            // cbc
            // 
            this.cbc.AutoSize = true;
            this.cbc.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cbc.Location = new System.Drawing.Point(399, 230);
            this.cbc.Margin = new System.Windows.Forms.Padding(4);
            this.cbc.Name = "cbc";
            this.cbc.Size = new System.Drawing.Size(47, 23);
            this.cbc.TabIndex = 2;
            this.cbc.Text = "C#";
            this.cbc.UseVisualStyleBackColor = true;
            // 
            // cbASP
            // 
            this.cbASP.AutoSize = true;
            this.cbASP.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cbASP.Location = new System.Drawing.Point(399, 289);
            this.cbASP.Margin = new System.Windows.Forms.Padding(4);
            this.cbASP.Name = "cbASP";
            this.cbASP.Size = new System.Drawing.Size(57, 23);
            this.cbASP.TabIndex = 3;
            this.cbASP.Text = "ASP";
            this.cbASP.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(30, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 22);
            this.label1.TabIndex = 4;
            this.label1.Text = "User Details";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(50, 98);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(50, 177);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 22);
            this.label3.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(31, 153);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "Address";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(120, 92);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(202, 26);
            this.txtName.TabIndex = 8;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(120, 153);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(4);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(202, 26);
            this.txtAddress.TabIndex = 9;
            // 
            // listInfo
            // 
            this.listInfo.FormattingEnabled = true;
            this.listInfo.ItemHeight = 19;
            this.listInfo.Location = new System.Drawing.Point(41, 225);
            this.listInfo.Name = "listInfo";
            this.listInfo.Size = new System.Drawing.Size(229, 156);
            this.listInfo.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(388, 346);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 35);
            this.button1.TabIndex = 11;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // image
            // 
            this.image.Location = new System.Drawing.Point(482, 177);
            this.image.Name = "image";
            this.image.Size = new System.Drawing.Size(164, 135);
            this.image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.image.TabIndex = 12;
            this.image.TabStop = false;
            this.image.Click += new System.EventHandler(this.image_Click);
            // 
            // bntPic
            // 
            this.bntPic.Location = new System.Drawing.Point(529, 346);
            this.bntPic.Name = "bntPic";
            this.bntPic.Size = new System.Drawing.Size(75, 35);
            this.bntPic.TabIndex = 13;
            this.bntPic.Text = "Add Pic";
            this.bntPic.UseVisualStyleBackColor = true;
            this.bntPic.Click += new System.EventHandler(this.bntPic_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(658, 417);
            this.Controls.Add(this.bntPic);
            this.Controls.Add(this.image);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listInfo);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbASP);
            this.Controls.Add(this.cbc);
            this.Controls.Add(this.cbFemale);
            this.Controls.Add(this.cbmale);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CheckBox cbmale;
        private CheckBox cbFemale;
        private CheckBox cbc;
        private CheckBox cbASP;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtName;
        private TextBox txtAddress;
        private ListBox listInfo;
        private Button button1;
        private PictureBox image;
        private Button bntPic;
    }
}