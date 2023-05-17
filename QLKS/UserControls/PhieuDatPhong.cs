using QLKS.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace QLKS.UserControls
{
    public partial class PhieuDatPhong : UserControl
    {
        public PhieuDatPhong()
        {
            InitializeComponent();

            cbbPDP_TinhTrangPDP.SelectedIndex = 1;
            grbxDoanKhach.Enabled = false;
            grbxDVLH.Enabled = false;
            txtPDP_SoDemLuuTru.Text = "0";
        }

        private void btnPDP_TimKhachHang_Click(object sender, EventArgs e)
        {
            TimKhachHangForm tkhDialog = new();
            var result = tkhDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                var customerDataRow = tkhDialog.khRow;

                txtPDP_MaKhachHangCN.Text = customerDataRow.Cells["MAKHCN"].Value.ToString();
                txtPDP_Hoten.Text = customerDataRow.Cells["TENKHCN"].Value.ToString();
                txtPDP_CMND.Text = customerDataRow.Cells["CMND"].Value.ToString();
                txtPDP_DiaChi.Text = customerDataRow.Cells["DIACHI"].Value.ToString();
                txtPDP_SoDienThoai.Text = customerDataRow.Cells["SDT"].Value.ToString();
            }
        }

        private void btnPDP_TimPhongTrong_Click(object sender, EventArgs e)
        {
            TimPhongForm tpDialog = new();
            var result = tpDialog.ShowDialog();
            double totalPrice = 0;
            double deposit = 0;

            if (result == DialogResult.OK)
            {
                var rows = tpDialog.getDSPhong();
                var ngayNhanPhong = tpDialog.getNgayNhanPhong();
                dtPDP_NgayNhan.Value = ngayNhanPhong;

                int night = (dtPDP_NgayTra.Value - dtPDP_NgayNhan.Value).Days;

                if (rows.Count == 0)
                {
                    return;
                }

                lv_PDP_ThongTinPhong.Items.Clear();

                foreach (var row in rows)
                {
                    var roomId = (int)row.Cells["MaPhong"].Value;
                    var roomType = (string)row.Cells["LOAIPHONG"].Value;
                    var roomPrice = (int)row.Cells["GIASP"].Value;

                    var item = new ListViewItem(roomId.ToString());
                    item.SubItems.Add(roomType);
                    item.SubItems.Add(roomPrice.ToString());

                    lv_PDP_ThongTinPhong.Items.Add(item);

                    totalPrice += (double)roomPrice * night;
                }

                txtPDP_SoDemLuuTru.Text = night.ToString();
                deposit = totalPrice * 0.3;
                txtPDP_TongTienPhong.Text = Math.Round(totalPrice, 2).ToString();
                txtPDP_TienCoc.Text = Math.Round(deposit, 2).ToString();
            }
        }

        private void btnPDP_TaoPhieu_Click(object sender, EventArgs e)
        {
            if (txtPDP_MaKhachHangCN.Text == "" || txtPDP_Hoten.Text == "" || txtPDP_SoDienThoai.Text == "" || txtPDP_MaKhachHangCN.Text == "" || txtPDP_DiaChi.Text == "" || txtPDP_CMND.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin khách hàng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (lv_PDP_ThongTinPhong.Items.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn phòng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (int.Parse(txtPDP_SoDemLuuTru.Text) <= 0)
            {
                MessageBox.Show("Ngày nhận phòng, ngày trả phòng không hợp lệ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (rd_PDP_DoanKhach.Checked)
            {
                if (txtPDP_TenDoan.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập tên đoàn khách", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (txtPDP_SoLuongNguoiTrongDoan.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập số lượng người trong đoàn", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            if (rd_PDP_DVLH.Checked)
            {
                if (txtPDP_MaDVLH.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập mã đơn vị lữ hành", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            if (txtPDP_SoDemLuuTru.Text == "0")
            {
                MessageBox.Show("Ngày nhận phòng, ngày trả phòng không hợp lệ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (cbx_PDP_ThanhToan.Checked == false)
            {
                MessageBox.Show("Vui lòng đặt cọc phòng trước khi tạo phiếu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (rd_PDP_DoanKhach.Checked)
            {

            }

            var maNV = 1;
            var ngayNhan = dtPDP_NgayNhan.Value.ToString("yyyy-dd-MM");
            var ngayTra = dtPDP_NgayTra.Value.ToString("yyyy-dd-MM");
            var ngayDatPhong = DateTime.Now.ToString("yyyy-dd-MM");
            var trangThai = cbbPDP_TinhTrangPDP.Text;
            var maKH = txtPDP_MaKhachHangCN.Text;
            var maDVLH = "NULL";

            if (rd_PDP_DVLH.Checked)
            {
                maDVLH = txtPDP_MaDVLH.Text;

                if (DataAccess.ExecuteScalar($"SELECT * FROM DONVILUHANH WHERE MADV = {maDVLH}") == 0)
                {
                    MessageBox.Show("Mã đơn vị lữ hành không tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            var maDP = DataAccess.ExecuteScalar($@"
                INSERT INTO DATPHONG(MANV, NGAYNHAN, NGAYTRA, NGAYDATPHONG, LOAIPHONG, TRANGTHAI, MAKH, MADVLH)
                OUTPUT INSERTED.MADP
                VALUES ({maNV}, '{ngayNhan}', '{ngayTra}', '{ngayDatPhong}', NULL, N'{trangThai}', {maKH}, {maDVLH})
            ");

            for (int i = 0; i < lv_PDP_ThongTinPhong.Items.Count; i++)
            {
                ListViewItem item = lv_PDP_ThongTinPhong.Items[i];

                var maPhong = int.Parse(item.Text);
                var stt = i + 1;

                DataAccess.ExecuteNonQuery($@"
                    INSERT INTO LICHSUDUNGPHONG(MADP, MAPHONG, STT, NGAYNHAN, NGAYTRA)
                    VALUES ({maDP}, {maPhong}, {stt}, '{ngayNhan}', '{ngayTra}')
                ");
            }

            MessageBox.Show("Tạo phiếu thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtPDP_Hoten.Clear();
            txtPDP_SoDienThoai.Clear();
            txtPDP_MaKhachHangCN.Clear();
            txtPDP_DiaChi.Clear();
            txtPDP_CMND.Clear();
            txtPDP_TenDoan.Clear();
            txtPDP_SoLuongNguoiTrongDoan.Clear();
            txtPDP_MaDVLH.Clear();
            txtPDP_SoDemLuuTru.Text = "0";
            txtPDP_TongTienPhong.Clear();
            txtPDP_TienCoc.Clear();
            lv_PDP_ThongTinPhong.Items.Clear();
        }

        private void LoaiKhach_CheckedChanged(object sender, EventArgs e)
        {
            if (rd_PDP_KhachLe.Checked)
            {
                grbxDoanKhach.Enabled = false;
                grbxDVLH.Enabled = false;
            }

            if (rd_PDP_DoanKhach.Checked)
            {
                grbxDoanKhach.Enabled = true;
                grbxDVLH.Enabled = false;
                txtPDP_MaDVLH.Clear();
            }

            if (rd_PDP_DVLH.Checked)
            {
                grbxDVLH.Enabled = true;
                grbxDoanKhach.Enabled = false;
                txtPDP_TenDoan.Clear();
                txtPDP_SoLuongNguoiTrongDoan.Clear();
            }
        }

        private void dtPDP_NgayTra_ValueChanged(object sender, EventArgs e)
        {
            int night = (dtPDP_NgayTra.Value - dtPDP_NgayNhan.Value).Days + 1;
            double totalPrice = 0;
            double deposit = 0;

            foreach (var item in lv_PDP_ThongTinPhong.Items.Cast<ListViewItem>())
            {
                var pricePerNight = double.Parse(item.SubItems[2].Text);
                totalPrice += pricePerNight * night;
            }

            txtPDP_SoDemLuuTru.Text = night.ToString();
            deposit = totalPrice * 0.3;
            txtPDP_TienCoc.Text = Math.Round(deposit, 2).ToString();
            txtPDP_TongTienPhong.Text = Math.Round(totalPrice, 2).ToString();
        }

        private void btnPDP_ThanhToan_Click(object sender, EventArgs e)
        {
            var soNgay = int.Parse(txtPDP_SoDemLuuTru.Text);
            var tienCoc = double.Parse(txtPDP_TienCoc.Text);
            var tongTienPhong = double.Parse(txtPDP_TongTienPhong.Text);

            if (soNgay <= 0)
            {
                MessageBox.Show("Vui lòng chọn phòng trước khi thanh toán", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            HoaDonDCForm dhdcDialog = new(tienCoc, tongTienPhong);
            var result = dhdcDialog.ShowDialog();

            CheckBox thanhToan = dhdcDialog.getThanhToan();
            cbx_PDP_ThanhToan.Checked = thanhToan.Checked;
        }
    }
}
