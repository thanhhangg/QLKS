﻿namespace QLKS.UserControls
{
    partial class TourControl
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
            dataGridView1 = new System.Windows.Forms.DataGridView();
            stt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            maphieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dvlh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            NgayDK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            KetQua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Xem = new System.Windows.Forms.DataGridViewButtonColumn();
            button1 = new System.Windows.Forms.Button();
            button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { stt, maphieu, dvlh, NgayDK, KetQua, Xem });
            dataGridView1.Location = new System.Drawing.Point(49, 111);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new System.Drawing.Size(964, 557);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // stt
            // 
            stt.HeaderText = "STT";
            stt.MinimumWidth = 8;
            stt.Name = "stt";
            stt.Width = 150;
            // 
            // maphieu
            // 
            maphieu.HeaderText = "Mã Phiếu";
            maphieu.MinimumWidth = 8;
            maphieu.Name = "maphieu";
            maphieu.Width = 150;
            // 
            // dvlh
            // 
            dvlh.HeaderText = "Đơn vị cung cấp";
            dvlh.MinimumWidth = 8;
            dvlh.Name = "dvlh";
            dvlh.Width = 150;
            // 
            // NgayDK
            // 
            NgayDK.HeaderText = "Ngày Đăng Ký";
            NgayDK.MinimumWidth = 8;
            NgayDK.Name = "NgayDK";
            NgayDK.Width = 150;
            // 
            // KetQua
            // 
            KetQua.HeaderText = "Kết quả ";
            KetQua.MinimumWidth = 8;
            KetQua.Name = "KetQua";
            KetQua.Width = 150;
            // 
            // Xem
            // 
            Xem.HeaderText = "Chọn";
            Xem.MinimumWidth = 8;
            Xem.Name = "Xem";
            Xem.Text = "Xem";
            Xem.Width = 150;
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(49, 34);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(112, 34);
            button1.TabIndex = 1;
            button1.Text = "Tạo mới";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new System.Drawing.Point(194, 33);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(112, 34);
            button2.TabIndex = 2;
            button2.Text = "Xem";
            button2.UseVisualStyleBackColor = true;
            // 
            // TourControl
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Name = "TourControl";
            Size = new System.Drawing.Size(1035, 687);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn stt;
        private System.Windows.Forms.DataGridViewTextBoxColumn maphieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvlh;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayDK;
        private System.Windows.Forms.DataGridViewTextBoxColumn KetQua;
        private System.Windows.Forms.DataGridViewButtonColumn Xem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}
