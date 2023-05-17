using QLKS.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKS.Forms
{
    public partial class HoaDonDCForm : Form
    {
        public HoaDonDCForm(double tienCoc, double tongTienPhong)
        {
            InitializeComponent();

            cbbHDDP_PhuongThucThanhToan.SelectedIndex = 0;
            grbxTrucTuyen.Enabled = false;
            grbxThe.Enabled = false;
            //TextBox tienCoc = PhieuDatPhong.GetTienCoc();
            //txtHDDP_TienCoc = tienCoc;

            txtHDDP_TienCoc.Text = tienCoc.ToString();
            txtHDDP_TongTienPhong.Text = tongTienPhong.ToString();
        }

        private int maHD = -1;

        private CheckBox thanhToanHDDC = new();
        private void btnHDDP_ThanhToan_Click(object sender, EventArgs e)
        {
            if (cbbHDDP_PhuongThucThanhToan.SelectedIndex == 1)
            {
                if (txtHDDP_SoThe.Text == "" || txtHDDP_TenChuThe.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin thanh toán thẻ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            if (cbbHDDP_PhuongThucThanhToan.SelectedIndex == 2)
            {
                if (txtHDDP_SoTaiKhoan.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập thông tin thanh toán trực tuyến", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            var now = DateTime.Now;
            var ngay = now.ToString("yyyy-dd-MM");
            var gio = now.ToString("HH:mm:ss");
            var trangThai = "Thành công";
            var tongTien = txtHDDP_TongTienPhong.Text;
            var pttt = cbbHDDP_PhuongThucThanhToan.Text;
            var maNV = 1;

            var maHD = DataAccess.ExecuteScalar($@"
                INSERT INTO HOADON(NGAY, GIO, TRANGTHAI, TONGTIEN, PTTHANHTOAN, MANV, MALSDP)
                OUTPUT INSERTED.MAHD
                VALUES ('{ngay}', '{gio}', N'{trangThai}', {tongTien}, N'{pttt}', {maNV}, NULL)
            ");

            if (cbbHDDP_PhuongThucThanhToan.SelectedIndex == 1)
            {
                var maGiaoDich = new Random().NextInt64(100000, 999999);
                var loaiThe = "Visa";
                var soThe = txtHDDP_SoThe.Text;
                var tenChuThe = txtHDDP_TenChuThe.Text;

                DataAccess.ExecuteNonQuery($@"
                    INSERT INTO HOADONTRUCTUYEN(MAHD, MAGIAODICH, LOAITHE, SOTHE, NGAYHETHAN, MABAOMAT, TENCHUTHE)
                    VALUES ({maHD}, {maGiaoDich}, N'{loaiThe}', '{soThe}', NULL, NULL, N'{tenChuThe}')
                ");
            }

            if (cbbHDDP_PhuongThucThanhToan.SelectedIndex == 2)
            {
                var maGiaoDich = new Random().NextInt64(100000, 999999);
                var loaiThe = "Trực tuyến";
                var soTK = txtHDDP_SoTaiKhoan.Text;
                var tenChuTK = txtChuTaiKhoan.Text;

                DataAccess.ExecuteNonQuery($@"
                    INSERT INTO HOADONTRUCTUYEN(MAHD, MAGIAODICH, LOAITHE, SOTHE, NGAYHETHAN, MABAOMAT, TENCHUTHE)
                    VALUES ({maHD}, {maGiaoDich}, N'{loaiThe}', '{soTK}', NULL, NULL, N'{tenChuTK}')
                ");
            }

            this.maHD = maHD;

            cbx_PDP_ThanhToan.Checked = true;
            Close();
        }

        public CheckBox getThanhToan()
        {
            thanhToanHDDC = cbx_PDP_ThanhToan;
            return thanhToanHDDC;
        }

        public int GetMaHD()
        {
            return maHD;
        }

        private void cbbHDDP_PhuongThucThanhToan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbHDDP_PhuongThucThanhToan.SelectedIndex == 1)
            {
                grbxTrucTuyen.Enabled = false;
                grbxThe.Enabled = true;
                txtHDDP_SoTaiKhoan.Clear();
            }
            if (cbbHDDP_PhuongThucThanhToan.SelectedIndex == 2)
            {
                grbxTrucTuyen.Enabled = true;
                grbxThe.Enabled = false;
                txtHDDP_SoThe.Clear();
                txtHDDP_TenChuThe.Clear();
            }
            if (cbbHDDP_PhuongThucThanhToan.SelectedIndex == 0)
            {
                grbxTrucTuyen.Enabled = false;
                grbxThe.Enabled = false;
                txtHDDP_SoThe.Clear();
                txtHDDP_TenChuThe.Clear();
                txtHDDP_SoTaiKhoan.Clear();
            }
        }
    }
}
