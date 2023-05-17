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
    public partial class TimKhachHangForm : Form
    {
        public TimKhachHangForm()
        {
            InitializeComponent();
        }

        public DataGridViewRow khRow = null;

        private void DSKH_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        public void LoadData()
        {
            string query = "SELECT * FROM KHACHHANGCANHAN";
            DataTable dataTable = DataAccess.ExecuteQuery(query);
            dvgDSKH.DataSource = dataTable;
        }

        private void btnDSKH_Them_Click(object sender, EventArgs e)
        {
            txtDSKH_TimKiem_SoDienThoai.Clear();

            if (txtDSKH_CMND.Text == "" || txtDSKH_DiaChi.Text == "" || txtDSKH_HoTen.Text == "" || txtDSKH_SoDienThoai.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin khách hàng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var newIdDataTable = DataAccess.ExecuteQuery("SELECT TOP 1 MAKH FROM KHACHHANG ORDER BY MAKH DESC");

            var newId = 1;

            if (newIdDataTable.Rows.Count > 0)
            {
                newId = (int)newIdDataTable.Rows[0][0] + 1;
            }

            var cmnd = txtDSKH_CMND.Text;
            var hoTen = txtDSKH_HoTen.Text;
            var diaChi = txtDSKH_DiaChi.Text;
            var sdt = txtDSKH_SoDienThoai.Text;

            if (DataAccess.ExecuteNonQuery($"INSERT INTO KHACHHANG (MAKH) VALUES ({newId})") > 0)
            {
                var query = $@"
                    INSERT INTO KHACHHANGCANHAN(MAKHCN, TENKHCN, CMND, SDT, DIACHI, MADOAN)
                    VALUES
                    ({newId}, N'{hoTen}', '{cmnd}', '{sdt}', N'{diaChi}', NULL)";

                DataAccess.ExecuteNonQuery(query);

                LoadData();

                txtDSKH_CMND.Clear();
                txtDSKH_DiaChi.Clear();
                txtDSKH_HoTen.Clear();
                txtDSKH_SoDienThoai.Clear();
            }
        }

        private void btnDSKH_TimKiem_Click(object sender, EventArgs e)
        {
            txtDSKH_CMND.Clear();
            txtDSKH_DiaChi.Clear();
            txtDSKH_HoTen.Clear();
            txtDSKH_SoDienThoai.Clear();

            string query = $"SELECT * FROM KHACHHANGCANHAN WHERE SDT LIKE '%{txtDSKH_TimKiem_SoDienThoai.Text}%'";
            DataTable dataTable = DataAccess.ExecuteQuery(query);
            dvgDSKH.DataSource = dataTable;
        }

        private void btnDSKH_DatPhong_Click(object sender, EventArgs e)
        {
            if (dvgDSKH.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn khách hàng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            khRow = dvgDSKH.CurrentRow;

            txtDSKH_CMND.Clear();
            txtDSKH_DiaChi.Clear();
            txtDSKH_HoTen.Clear();
            txtDSKH_SoDienThoai.Clear();
            txtDSKH_TimKiem_SoDienThoai.Clear();

            this.DialogResult = DialogResult.OK;
            Close();
        }
    }
}
