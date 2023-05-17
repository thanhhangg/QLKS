
using System.Drawing.Printing;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;

namespace QLKS.Forms
{
    partial class TimPhongForm
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dvgDSPT = new DataGridView();
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            btnDSPT_TimKiem = new Button();
            cbxDSPT_LoaiPhong = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            dtDSPT_Date = new DateTimePicker();
            label2 = new Label();
            btnDSPT_DatPhong = new Button();
            ((System.ComponentModel.ISupportInitialize)dvgDSPT).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // dvgDSPT
            // 
            dvgDSPT.AllowUserToAddRows = false;
            dvgDSPT.AllowUserToDeleteRows = false;
            dvgDSPT.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dvgDSPT.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgDSPT.Location = new Point(4, 53);
            dvgDSPT.Margin = new Padding(3, 2, 3, 2);
            dvgDSPT.Name = "dvgDSPT";
            dvgDSPT.ReadOnly = true;
            dvgDSPT.RowHeadersVisible = false;
            dvgDSPT.RowHeadersWidth = 51;
            dvgDSPT.RowTemplate.Height = 29;
            dvgDSPT.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dvgDSPT.Size = new Size(684, 545);
            dvgDSPT.TabIndex = 4;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(dvgDSPT);
            panel1.Location = new Point(28, 27);
            panel1.Name = "panel1";
            panel1.Size = new Size(693, 604);
            panel1.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 17F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(3, 16);
            label1.Name = "label1";
            label1.Size = new Size(266, 31);
            label1.TabIndex = 5;
            label1.Text = "Danh sách phòng trống";
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(btnDSPT_TimKiem);
            panel2.Controls.Add(cbxDSPT_LoaiPhong);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(dtDSPT_Date);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(727, 221);
            panel2.Name = "panel2";
            panel2.Size = new Size(295, 180);
            panel2.TabIndex = 6;
            // 
            // btnDSPT_TimKiem
            // 
            btnDSPT_TimKiem.Location = new Point(187, 123);
            btnDSPT_TimKiem.Name = "btnDSPT_TimKiem";
            btnDSPT_TimKiem.Size = new Size(88, 28);
            btnDSPT_TimKiem.TabIndex = 11;
            btnDSPT_TimKiem.Text = "Tìm kiếm";
            btnDSPT_TimKiem.UseVisualStyleBackColor = true;
            btnDSPT_TimKiem.Click += btnDSPT_TimKiem_Click;
            // 
            // cbxDSPT_LoaiPhong
            // 
            cbxDSPT_LoaiPhong.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxDSPT_LoaiPhong.FormattingEnabled = true;
            cbxDSPT_LoaiPhong.Items.AddRange(new object[] { "Tất cả", "Phòng Đơn", "Phòng Đôi" });
            cbxDSPT_LoaiPhong.Location = new Point(21, 127);
            cbxDSPT_LoaiPhong.Name = "cbxDSPT_LoaiPhong";
            cbxDSPT_LoaiPhong.Size = new Size(109, 23);
            cbxDSPT_LoaiPhong.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(21, 109);
            label4.Name = "label4";
            label4.Size = new Size(67, 15);
            label4.TabIndex = 9;
            label4.Text = "Loại phòng";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(21, 50);
            label3.Name = "label3";
            label3.Size = new Size(35, 15);
            label3.TabIndex = 8;
            label3.Text = "Ngày";
            // 
            // dtDSPT_Date
            // 
            dtDSPT_Date.Location = new Point(21, 68);
            dtDSPT_Date.Name = "dtDSPT_Date";
            dtDSPT_Date.Size = new Size(254, 23);
            dtDSPT_Date.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(3, 6);
            label2.Name = "label2";
            label2.Size = new Size(100, 28);
            label2.TabIndex = 6;
            label2.Text = "Tìm kiếm";
            // 
            // btnDSPT_DatPhong
            // 
            btnDSPT_DatPhong.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnDSPT_DatPhong.Location = new Point(915, 435);
            btnDSPT_DatPhong.Name = "btnDSPT_DatPhong";
            btnDSPT_DatPhong.Size = new Size(107, 32);
            btnDSPT_DatPhong.TabIndex = 7;
            btnDSPT_DatPhong.Text = "Đặt phòng";
            btnDSPT_DatPhong.UseVisualStyleBackColor = true;
            btnDSPT_DatPhong.Click += btnDSPT_DatPhong_Click;
            // 
            // TimPhongForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1039, 653);
            Controls.Add(btnDSPT_DatPhong);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "TimPhongForm";
            Load += DatPhongControl_Load;
            Click += DatPhongControl_Load;
            ((System.ComponentModel.ISupportInitialize)dvgDSPT).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataGridView dvgDSPT;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtDSPT_Date;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDSPT_TimKiem;
        private System.Windows.Forms.ComboBox cbxDSPT_LoaiPhong;
        private System.Windows.Forms.Button btnDSPT_DatPhong;
    }
}
