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
    public partial class TimPhongForm : Form
    {
        public TimPhongForm()
        {
            InitializeComponent();
        }

        private List<DataGridViewRow> rows = new();
        private DateTime ngayNhanPhong = new();

        public List<DataGridViewRow> getDSPhong()
        {
            return rows;
        }

        public DateTime getNgayNhanPhong()
        {
            return ngayNhanPhong;
        }

        private void DatPhongControl_Load(object sender, EventArgs e)
        {
            cbxDSPT_LoaiPhong.SelectedIndex = 0;
        }

        public void LoadData()
        {
            // Query the Rooms table and store the results in a DataTable
            string query = "SELECT MAPHONG, LOAIPHONG, GIASP FROM PHONG, SANPHAMDICHVU WHERE PHONG.LOAIPHONG = SANPHAMDICHVU.TENSP;";
            DataTable dataTable = DataAccess.ExecuteQuery(query);

            // Bind the DataTable to the DataGridView
            dvgDSPT.DataSource = dataTable;
        }

        private void btnDSPT_DatPhong_Click(object sender, EventArgs e)
        {
            rows = dvgDSPT.SelectedRows.OfType<DataGridViewRow>().ToList();
            ngayNhanPhong = dtDSPT_Date.Value;
            this.DialogResult = DialogResult.OK;
            Close();
        }

        private void dtDSPT_Date_ValueChanged(object sender, EventArgs e)
        {
            dtDSPT_Date.CustomFormat = "dd/MM/yyyy";
        }

        private void btnDSPT_TimKiem_Click(object sender, EventArgs e)
        {
            if (cbxDSPT_LoaiPhong.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn loại phòng cần tìm kiếm", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string roomType = cbxDSPT_LoaiPhong.SelectedItem.ToString();
            string queryRoomType = roomType == "Tất cả" ? "" : $"AND LOAIPHONG = N'{roomType}'";
            string query = $@"
                    SELECT MAPHONG, LOAIPHONG, GIASP 
                    FROM PHONG, SANPHAMDICHVU 
                    WHERE PHONG.LOAIPHONG = SANPHAMDICHVU.TENSP
                    {queryRoomType}
                    AND PHONG.MAPHONG NOT IN (SELECT LSDP.MAPHONG 
						  FROM LICHSUDUNGPHONG LSDP 
						  WHERE '{dtDSPT_Date.Value:yyyy-MM-dd}' BETWEEN NGAYNHAN AND NGAYTRA);              
             ";
            DataTable dataTable = DataAccess.ExecuteQuery(query);

            dvgDSPT.DataSource = dataTable;
        }
    }
}
