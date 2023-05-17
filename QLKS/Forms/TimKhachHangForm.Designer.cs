namespace QLKS.Forms
{
    partial class TimKhachHangForm
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
            btnDSKH_DatPhong = new System.Windows.Forms.Button();
            panel2 = new System.Windows.Forms.Panel();
            txtDSKH_TimKiem_SoDienThoai = new System.Windows.Forms.TextBox();
            btnDSKH_TimKiem = new System.Windows.Forms.Button();
            label4 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            panel1 = new System.Windows.Forms.Panel();
            label1 = new System.Windows.Forms.Label();
            dvgDSKH = new System.Windows.Forms.DataGridView();
            panel3 = new System.Windows.Forms.Panel();
            txtDSKH_DiaChi = new System.Windows.Forms.TextBox();
            label8 = new System.Windows.Forms.Label();
            txtDSKH_CMND = new System.Windows.Forms.TextBox();
            label7 = new System.Windows.Forms.Label();
            txtDSKH_HoTen = new System.Windows.Forms.TextBox();
            label6 = new System.Windows.Forms.Label();
            txtDSKH_SoDienThoai = new System.Windows.Forms.TextBox();
            btnDSKH_Them = new System.Windows.Forms.Button();
            label3 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dvgDSKH).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // btnDSKH_DatPhong
            // 
            btnDSKH_DatPhong.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnDSKH_DatPhong.Location = new System.Drawing.Point(907, 591);
            btnDSKH_DatPhong.Name = "btnDSKH_DatPhong";
            btnDSKH_DatPhong.Size = new System.Drawing.Size(107, 32);
            btnDSKH_DatPhong.TabIndex = 10;
            btnDSKH_DatPhong.Text = "Đặt phòng";
            btnDSKH_DatPhong.UseVisualStyleBackColor = true;
            btnDSKH_DatPhong.Click += btnDSKH_DatPhong_Click;
            // 
            // panel2
            // 
            panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panel2.Controls.Add(txtDSKH_TimKiem_SoDienThoai);
            panel2.Controls.Add(btnDSKH_TimKiem);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label2);
            panel2.Location = new System.Drawing.Point(719, 397);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(295, 156);
            panel2.TabIndex = 9;
            // 
            // txtDSKH_TimKiem_SoDienThoai
            // 
            txtDSKH_TimKiem_SoDienThoai.Location = new System.Drawing.Point(28, 66);
            txtDSKH_TimKiem_SoDienThoai.Name = "txtDSKH_TimKiem_SoDienThoai";
            txtDSKH_TimKiem_SoDienThoai.Size = new System.Drawing.Size(236, 23);
            txtDSKH_TimKiem_SoDienThoai.TabIndex = 12;
            // 
            // btnDSKH_TimKiem
            // 
            btnDSKH_TimKiem.Location = new System.Drawing.Point(176, 110);
            btnDSKH_TimKiem.Name = "btnDSKH_TimKiem";
            btnDSKH_TimKiem.Size = new System.Drawing.Size(88, 28);
            btnDSKH_TimKiem.TabIndex = 11;
            btnDSKH_TimKiem.Text = "Tìm kiếm";
            btnDSKH_TimKiem.UseVisualStyleBackColor = true;
            btnDSKH_TimKiem.Click += btnDSKH_TimKiem_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label4.Location = new System.Drawing.Point(30, 45);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(76, 15);
            label4.TabIndex = 9;
            label4.Text = "Số điện thoại";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(3, 6);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(100, 28);
            label2.TabIndex = 6;
            label2.Text = "Tìm kiếm";
            // 
            // panel1
            // 
            panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(dvgDSKH);
            panel1.Location = new System.Drawing.Point(12, 19);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(683, 604);
            panel1.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(3, 18);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(254, 31);
            label1.TabIndex = 5;
            label1.Text = "Danh sách khách hàng";
            // 
            // dvgDSKH
            // 
            dvgDSKH.AllowUserToAddRows = false;
            dvgDSKH.AllowUserToDeleteRows = false;
            dvgDSKH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dvgDSKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgDSKH.Location = new System.Drawing.Point(4, 53);
            dvgDSKH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            dvgDSKH.MultiSelect = false;
            dvgDSKH.Name = "dvgDSKH";
            dvgDSKH.ReadOnly = true;
            dvgDSKH.RowHeadersVisible = false;
            dvgDSKH.RowHeadersWidth = 51;
            dvgDSKH.RowTemplate.Height = 29;
            dvgDSKH.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dvgDSKH.Size = new System.Drawing.Size(674, 545);
            dvgDSKH.TabIndex = 4;
            // 
            // panel3
            // 
            panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panel3.Controls.Add(txtDSKH_DiaChi);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(txtDSKH_CMND);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(txtDSKH_HoTen);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(txtDSKH_SoDienThoai);
            panel3.Controls.Add(btnDSKH_Them);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label5);
            panel3.Location = new System.Drawing.Point(719, 73);
            panel3.Name = "panel3";
            panel3.Size = new System.Drawing.Size(295, 292);
            panel3.TabIndex = 13;
            // 
            // txtDSKH_DiaChi
            // 
            txtDSKH_DiaChi.Location = new System.Drawing.Point(28, 184);
            txtDSKH_DiaChi.Name = "txtDSKH_DiaChi";
            txtDSKH_DiaChi.Size = new System.Drawing.Size(236, 23);
            txtDSKH_DiaChi.TabIndex = 18;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label8.Location = new System.Drawing.Point(28, 166);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(46, 15);
            label8.TabIndex = 17;
            label8.Text = "Địa chỉ ";
            // 
            // txtDSKH_CMND
            // 
            txtDSKH_CMND.Location = new System.Drawing.Point(28, 125);
            txtDSKH_CMND.Name = "txtDSKH_CMND";
            txtDSKH_CMND.Size = new System.Drawing.Size(97, 23);
            txtDSKH_CMND.TabIndex = 16;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label7.Location = new System.Drawing.Point(31, 104);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(43, 15);
            label7.TabIndex = 15;
            label7.Text = "CMND";
            // 
            // txtDSKH_HoTen
            // 
            txtDSKH_HoTen.Location = new System.Drawing.Point(28, 65);
            txtDSKH_HoTen.Name = "txtDSKH_HoTen";
            txtDSKH_HoTen.Size = new System.Drawing.Size(236, 23);
            txtDSKH_HoTen.TabIndex = 14;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label6.Location = new System.Drawing.Point(28, 47);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(44, 15);
            label6.TabIndex = 13;
            label6.Text = "Họ Tên";
            // 
            // txtDSKH_SoDienThoai
            // 
            txtDSKH_SoDienThoai.Location = new System.Drawing.Point(146, 125);
            txtDSKH_SoDienThoai.Name = "txtDSKH_SoDienThoai";
            txtDSKH_SoDienThoai.Size = new System.Drawing.Size(118, 23);
            txtDSKH_SoDienThoai.TabIndex = 12;
            // 
            // btnDSKH_Them
            // 
            btnDSKH_Them.Location = new System.Drawing.Point(176, 243);
            btnDSKH_Them.Name = "btnDSKH_Them";
            btnDSKH_Them.Size = new System.Drawing.Size(88, 28);
            btnDSKH_Them.TabIndex = 11;
            btnDSKH_Them.Text = "Thêm";
            btnDSKH_Them.UseVisualStyleBackColor = true;
            btnDSKH_Them.Click += btnDSKH_Them_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(146, 104);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(76, 15);
            label3.TabIndex = 9;
            label3.Text = "Số điện thoại";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label5.Location = new System.Drawing.Point(3, 6);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(223, 28);
            label5.TabIndex = 6;
            label5.Text = "Thêm khách hàng mới";
            // 
            // TimKhachHangForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1039, 653);
            Controls.Add(panel3);
            Controls.Add(btnDSKH_DatPhong);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "TimKhachHangForm";
            Text = "TimKhachHangForm";
            Load += DSKH_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dvgDSKH).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button btnDSKH_DatPhong;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtDSKH_TimKiem_SoDienThoai;
        private System.Windows.Forms.Button btnDSKH_TimKiem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dvgDSKH;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtDSKH_SoDienThoai;
        private System.Windows.Forms.Button btnDSKH_Them;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDSKH_DiaChi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDSKH_CMND;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDSKH_HoTen;
        private System.Windows.Forms.Label label6;
    }
}