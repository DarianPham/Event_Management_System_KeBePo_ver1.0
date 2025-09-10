using Business_Layer;
using Data_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Transfer_Object;

namespace Presentation_Layer.TRANG_CHU_KHACH_HANG.Dat_Su_Kien
{
    public partial class frm_b2chonDiaDiem : Form
    {
        private DoiTacBL doiTacBL;
        private DichVuBL dichVuBL;
        private DichVuSuKienBL dvskBL = new DichVuSuKienBL();
        private string maSuKienHienTai = "SK" + DateTime.Now.Ticks.ToString().Substring(0, 6); // chỉ lấy 6 chữ số

        //maSuKienHienTai = "SK" + DateTime.Now.Ticks.ToString(); // Mã tạm thời tự tạo

        public frm_b2chonDiaDiem()
        {
            InitializeComponent();
            doiTacBL = new DoiTacBL();
            dichVuBL = new DichVuBL();
        }
        private void LoadLoaiHinhVaoComboBox()
        {
            List<string> danhSachLoaiHinh = doiTacBL.LayDanhSachLoaiHinh(); // Gọi từ BLL
            danhSachLoaiHinh.Insert(0, "Tất cả"); // Thêm "Tất cả" lên đầu
            ccb_loaiDichVu.DataSource = danhSachLoaiHinh;
        }
        private void frm_b2chonDiaDiem_Load(object sender, EventArgs e)
        {
            try
            {
                // Tạo các cột cho DataGridView
                CreateColumns();
                List<DoiTac> doiTacs = doiTacBL.GetDoiTacs();
                dgv_doiTac.DataSource = doiTacs;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            //List<DoiTac> doiTacs = doiTacBL.GetDoiTacs();
            //dgv_doiTac.DataSource = doiTacs;
            LoadLoaiHinhVaoComboBox();

            dgv_dichVu_suKien.AutoGenerateColumns = true;
        }
        
        private List<DichVu> LayDanhSachDichVuTuDataGrid()
        {
            List<DichVu> ds = new List<DichVu>();
            foreach (DataGridViewRow row in dgv_dichVu.Rows)
            {
                if (row.IsNewRow) continue;
                string ma = row.Cells["ma_dich_vu"].Value?.ToString();
                string ten = row.Cells["ten_dich_vu"].Value?.ToString();
                string giaStr = row.Cells["gia"].Value?.ToString();

                decimal donGia;
                if (!string.IsNullOrWhiteSpace(ten) &&
                    decimal.TryParse(giaStr, out donGia))
                {
                    ds.Add(new DichVu
                    {
                        ma_dich_vu = ma, // nếu là null thì xử lý sau
                        ten_dich_vu = ten,
                        gia = donGia.ToString()
                    });
                }
            }
            return ds;
        }

        private void dgv_dichVu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_dichVu.Columns[e.ColumnIndex].Name == "btnXacNhan" && e.RowIndex >= 0)
            {
                //string supplierId = dgv_dichVu.Rows[e.RowIndex].Cells["SupplierID"].Value.ToString();

                if (MessageBox.Show("Bạn có chắc chắn muốn chọn dịch vụ này.", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    var row = dgv_dichVu.Rows[e.RowIndex];
                    string maDV = row.Cells["ma_dich_vu"].Value.ToString();
                    decimal gia = Convert.ToDecimal(row.Cells["gia"].Value);

                    var item = new DichVuSuKien()
                    {
                        ma_su_kien = maSuKienHienTai,
                        ma_dich_vu = maDV,
                        gia = gia
                    };

                    dvskBL.Them(item); // cập nhật DB

                    // Hiển thị lại danh sách dịch vụ đã chọn
                    dgv_dichVu_suKien.DataSource = null;
                    dgv_dichVu_suKien.DataSource = dvskBL.LayTheoSuKien(maSuKienHienTai);
                }
               
            }
        }

        private void dgv_doiTac_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            string maDoiTac = dgv_doiTac.CurrentRow.Cells[0].Value.ToString();
            var dsDoiTac = doiTacBL.LayThongTin(maDoiTac);
            // Hiển thị dịch vụ
            var dsDichVu = dichVuBL.LayDichVuTheoDoiTac(maDoiTac);
            dgv_dichVu.DataSource = dsDichVu;
            dgv_dichVu.Columns["ma_dich_vu"].Width = 100;
            dgv_dichVu.Columns["ten_dich_vu"].Width = 300;
            dgv_dichVu.Columns["gia"].Width = 100;
            dgv_dichVu.Columns["ma_doi_tac"].Width = 100;
            dgv_dichVu.Columns["gia"].DefaultCellStyle.ForeColor = Color.Black;
            dgv_dichVu.Columns["ma_dich_vu"].DefaultCellStyle.ForeColor = Color.Black;
            dgv_dichVu.Columns["ten_dich_vu"].DefaultCellStyle.ForeColor = Color.Black;
            dgv_dichVu.Columns["ma_doi_tac"].DefaultCellStyle.ForeColor = Color.Black;
        }

        private void ccb_loaiDichVu_SelectedIndexChanged(object sender, EventArgs e)
        {
            string loaiHinhChon = ccb_loaiDichVu.SelectedItem.ToString();
            List<DoiTac> danhSach;

            if (loaiHinhChon == "Tất cả")
            {
                danhSach = doiTacBL.LayTatCaDoiTac();
            }
            else
            {
                danhSach = doiTacBL.LayDoiTacTheoLoaiHinh(loaiHinhChon);
            }
           dgv_doiTac.DataSource = danhSach;
        }
        private void CreateColumns()
        {
            dgv_dichVu.AutoGenerateColumns = false;
            dgv_dichVu.Columns.Clear();

            dgv_dichVu.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "ma_dich_vu",
                HeaderText = "Mã dịch vụ",
                Name = "ma_dich_vu"
            });

            dgv_dichVu.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "ten_dich_vu",
                HeaderText = "Tên dịch vụ",
                Name = "ten_dich_vu"
            });

            dgv_dichVu.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "gia",
                HeaderText = "Giá",
                Name = "gia"
            });

            dgv_dichVu.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "ma_doi_tac",
                HeaderText = "Mã đối tác",
                Name = "ma_doi_tac"
            });

            // Cột nút Delete
            DataGridViewButtonColumn btnXacNhan = new DataGridViewButtonColumn
            {
                HeaderText = "Xác Nhận",
                Name = "btnXacNhan",
                Text = "Chọn",
                UseColumnTextForButtonValue = true

            };
            btnXacNhan.DefaultCellStyle.BackColor = Color.Blue; // xanh mặc định         
            btnXacNhan.DefaultCellStyle.SelectionBackColor = Color.Black; // khi chọn
            btnXacNhan.DefaultCellStyle.SelectionForeColor = Color.White;
            dgv_dichVu.Columns.Add(btnXacNhan);
        }
    }
}
