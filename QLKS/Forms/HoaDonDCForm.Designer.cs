namespace QLKS.Forms
{
    partial class HoaDonDCForm
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
            components = new System.ComponentModel.Container();
            btnHDDP_ThanhToan = new System.Windows.Forms.Button();
            panel1 = new System.Windows.Forms.Panel();
            cbbHDDP_PhuongThucThanhToan = new System.Windows.Forms.ComboBox();
            label18 = new System.Windows.Forms.Label();
            panel2 = new System.Windows.Forms.Panel();
            label17 = new System.Windows.Forms.Label();
            label16 = new System.Windows.Forms.Label();
            txtHDDP_TienCoc = new System.Windows.Forms.TextBox();
            txtHDDP_TongTienPhong = new System.Windows.Forms.TextBox();
            label14 = new System.Windows.Forms.Label();
            label13 = new System.Windows.Forms.Label();
            grbxTrucTuyen = new System.Windows.Forms.GroupBox();
            txtChuTaiKhoan = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            txtHDDP_SoTaiKhoan = new System.Windows.Forms.TextBox();
            label7 = new System.Windows.Forms.Label();
            cbx_PDP_ThanhToan = new System.Windows.Forms.CheckBox();
            grbxThe = new System.Windows.Forms.GroupBox();
            txtHDDP_TenChuThe = new System.Windows.Forms.TextBox();
            txtHDDP_SoThe = new System.Windows.Forms.TextBox();
            label12 = new System.Windows.Forms.Label();
            label11 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(components);
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            grbxTrucTuyen.SuspendLayout();
            grbxThe.SuspendLayout();
            SuspendLayout();
            // 
            // btnHDDP_ThanhToan
            // 
            btnHDDP_ThanhToan.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnHDDP_ThanhToan.Location = new System.Drawing.Point(725, 477);
            btnHDDP_ThanhToan.Name = "btnHDDP_ThanhToan";
            btnHDDP_ThanhToan.Size = new System.Drawing.Size(117, 32);
            btnHDDP_ThanhToan.TabIndex = 36;
            btnHDDP_ThanhToan.Text = "Thanh toán";
            btnHDDP_ThanhToan.UseVisualStyleBackColor = true;
            btnHDDP_ThanhToan.Click += btnHDDP_ThanhToan_Click;
            // 
            // panel1
            // 
            panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panel1.Controls.Add(cbbHDDP_PhuongThucThanhToan);
            panel1.Controls.Add(label18);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(grbxTrucTuyen);
            panel1.Controls.Add(cbx_PDP_ThanhToan);
            panel1.Controls.Add(grbxThe);
            panel1.Controls.Add(label1);
            panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            panel1.Location = new System.Drawing.Point(37, 10);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(650, 499);
            panel1.TabIndex = 34;
            // 
            // cbbHDDP_PhuongThucThanhToan
            // 
            cbbHDDP_PhuongThucThanhToan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbbHDDP_PhuongThucThanhToan.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            cbbHDDP_PhuongThucThanhToan.FormattingEnabled = true;
            cbbHDDP_PhuongThucThanhToan.Items.AddRange(new object[] { "Tiền mặt", "Thẻ", "Trực tuyến" });
            cbbHDDP_PhuongThucThanhToan.Location = new System.Drawing.Point(178, 73);
            cbbHDDP_PhuongThucThanhToan.Name = "cbbHDDP_PhuongThucThanhToan";
            cbbHDDP_PhuongThucThanhToan.Size = new System.Drawing.Size(121, 23);
            cbbHDDP_PhuongThucThanhToan.TabIndex = 42;
            cbbHDDP_PhuongThucThanhToan.SelectedIndexChanged += cbbHDDP_PhuongThucThanhToan_SelectedIndexChanged;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label18.Location = new System.Drawing.Point(21, 79);
            label18.Name = "label18";
            label18.Size = new System.Drawing.Size(151, 17);
            label18.TabIndex = 26;
            label18.Text = "Phương thức thanh toán:";
            // 
            // panel2
            // 
            panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panel2.Controls.Add(label17);
            panel2.Controls.Add(label16);
            panel2.Controls.Add(txtHDDP_TienCoc);
            panel2.Controls.Add(txtHDDP_TongTienPhong);
            panel2.Controls.Add(label14);
            panel2.Controls.Add(label13);
            panel2.Location = new System.Drawing.Point(219, 355);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(374, 123);
            panel2.TabIndex = 41;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label17.Location = new System.Drawing.Point(301, 77);
            label17.Name = "label17";
            label17.Size = new System.Drawing.Size(37, 17);
            label17.TabIndex = 40;
            label17.Text = "VNĐ";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label16.Location = new System.Drawing.Point(301, 23);
            label16.Name = "label16";
            label16.Size = new System.Drawing.Size(37, 17);
            label16.TabIndex = 39;
            label16.Text = "VNĐ";
            // 
            // txtHDDP_TienCoc
            // 
            txtHDDP_TienCoc.Enabled = false;
            txtHDDP_TienCoc.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            txtHDDP_TienCoc.Location = new System.Drawing.Point(153, 71);
            txtHDDP_TienCoc.Name = "txtHDDP_TienCoc";
            txtHDDP_TienCoc.Size = new System.Drawing.Size(135, 25);
            txtHDDP_TienCoc.TabIndex = 38;
            // 
            // txtHDDP_TongTienPhong
            // 
            txtHDDP_TongTienPhong.Enabled = false;
            txtHDDP_TongTienPhong.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            txtHDDP_TongTienPhong.Location = new System.Drawing.Point(153, 20);
            txtHDDP_TongTienPhong.Name = "txtHDDP_TongTienPhong";
            txtHDDP_TongTienPhong.Size = new System.Drawing.Size(135, 25);
            txtHDDP_TongTienPhong.TabIndex = 37;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            label14.Location = new System.Drawing.Point(27, 26);
            label14.Name = "label14";
            label14.Size = new System.Drawing.Size(116, 17);
            label14.TabIndex = 36;
            label14.Text = "Tổng tiền phòng:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            label13.Location = new System.Drawing.Point(27, 77);
            label13.Name = "label13";
            label13.Size = new System.Drawing.Size(103, 17);
            label13.TabIndex = 35;
            label13.Text = "Số tiền đặt cọc:";
            // 
            // grbxTrucTuyen
            // 
            grbxTrucTuyen.Controls.Add(txtChuTaiKhoan);
            grbxTrucTuyen.Controls.Add(label2);
            grbxTrucTuyen.Controls.Add(txtHDDP_SoTaiKhoan);
            grbxTrucTuyen.Controls.Add(label7);
            grbxTrucTuyen.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            grbxTrucTuyen.Location = new System.Drawing.Point(21, 260);
            grbxTrucTuyen.Name = "grbxTrucTuyen";
            grbxTrucTuyen.Size = new System.Drawing.Size(572, 75);
            grbxTrucTuyen.TabIndex = 26;
            grbxTrucTuyen.TabStop = false;
            grbxTrucTuyen.Text = "THANH TOÁN TRỰC TUYẾN";
            // 
            // txtChuTaiKhoan
            // 
            txtChuTaiKhoan.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtChuTaiKhoan.Location = new System.Drawing.Point(350, 32);
            txtChuTaiKhoan.Name = "txtChuTaiKhoan";
            txtChuTaiKhoan.Size = new System.Drawing.Size(194, 25);
            txtChuTaiKhoan.TabIndex = 27;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(259, 36);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(87, 17);
            label2.TabIndex = 26;
            label2.Text = "Chủ tài khoản";
            // 
            // txtHDDP_SoTaiKhoan
            // 
            txtHDDP_SoTaiKhoan.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtHDDP_SoTaiKhoan.Location = new System.Drawing.Point(90, 33);
            txtHDDP_SoTaiKhoan.Name = "txtHDDP_SoTaiKhoan";
            txtHDDP_SoTaiKhoan.Size = new System.Drawing.Size(153, 25);
            txtHDDP_SoTaiKhoan.TabIndex = 25;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label7.Location = new System.Drawing.Point(9, 36);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(80, 17);
            label7.TabIndex = 11;
            label7.Text = "Số tài khoản";
            // 
            // cbx_PDP_ThanhToan
            // 
            cbx_PDP_ThanhToan.AutoSize = true;
            cbx_PDP_ThanhToan.Enabled = false;
            cbx_PDP_ThanhToan.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            cbx_PDP_ThanhToan.Location = new System.Drawing.Point(21, 355);
            cbx_PDP_ThanhToan.Name = "cbx_PDP_ThanhToan";
            cbx_PDP_ThanhToan.Size = new System.Drawing.Size(98, 21);
            cbx_PDP_ThanhToan.TabIndex = 32;
            cbx_PDP_ThanhToan.Text = "Thanh toán";
            cbx_PDP_ThanhToan.UseVisualStyleBackColor = true;
            // 
            // grbxThe
            // 
            grbxThe.Controls.Add(txtHDDP_TenChuThe);
            grbxThe.Controls.Add(txtHDDP_SoThe);
            grbxThe.Controls.Add(label12);
            grbxThe.Controls.Add(label11);
            grbxThe.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            grbxThe.Location = new System.Drawing.Point(21, 129);
            grbxThe.Name = "grbxThe";
            grbxThe.Size = new System.Drawing.Size(357, 114);
            grbxThe.TabIndex = 12;
            grbxThe.TabStop = false;
            grbxThe.Text = "THANH TOÁN THẺ";
            // 
            // txtHDDP_TenChuThe
            // 
            txtHDDP_TenChuThe.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtHDDP_TenChuThe.Location = new System.Drawing.Point(99, 73);
            txtHDDP_TenChuThe.Name = "txtHDDP_TenChuThe";
            txtHDDP_TenChuThe.Size = new System.Drawing.Size(213, 25);
            txtHDDP_TenChuThe.TabIndex = 25;
            // 
            // txtHDDP_SoThe
            // 
            txtHDDP_SoThe.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtHDDP_SoThe.Location = new System.Drawing.Point(70, 29);
            txtHDDP_SoThe.Name = "txtHDDP_SoThe";
            txtHDDP_SoThe.Size = new System.Drawing.Size(242, 25);
            txtHDDP_SoThe.TabIndex = 25;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label12.Location = new System.Drawing.Point(19, 76);
            label12.Name = "label12";
            label12.Size = new System.Drawing.Size(74, 17);
            label12.TabIndex = 11;
            label12.Text = "Tên chủ thẻ";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label11.Location = new System.Drawing.Point(19, 32);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(45, 17);
            label11.TabIndex = 10;
            label11.Text = "Số thẻ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(219, 15);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(266, 30);
            label1.TabIndex = 0;
            label1.Text = "THÔNG TIN THANH TOÁN";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // HoaDonDCForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(870, 537);
            Controls.Add(btnHDDP_ThanhToan);
            Controls.Add(panel1);
            Name = "HoaDonDCForm";
            Text = "HoaDonDCForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            grbxTrucTuyen.ResumeLayout(false);
            grbxTrucTuyen.PerformLayout();
            grbxThe.ResumeLayout(false);
            grbxThe.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button btnHDDP_ThanhToan;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbbHDDP_PhuongThucThanhToan;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.GroupBox grbxTrucTuyen;
        private System.Windows.Forms.TextBox txtHDDP_SoTaiKhoan;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox cbx_PDP_ThanhToan;
        private System.Windows.Forms.GroupBox grbxThe;
        private System.Windows.Forms.TextBox txtHDDP_TenChuThe;
        private System.Windows.Forms.TextBox txtHDDP_SoThe;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtHDDP_TienCoc;
        private System.Windows.Forms.TextBox txtHDDP_TongTienPhong;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtChuTaiKhoan;
        private System.Windows.Forms.Label label2;
    }
}