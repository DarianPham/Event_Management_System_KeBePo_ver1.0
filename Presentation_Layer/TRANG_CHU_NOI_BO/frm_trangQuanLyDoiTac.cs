using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using Presentation_Layer.XuLyGiaoDien;
using Business_Layer;
using Transfer_Object;
using Data_Layer;
using System.Drawing.Text;


namespace Presentation_Layer
{
    public partial class frm_trangQuanLyDoiTac : Form
    {
        private DoiTacBL doiTacBL;
        private DichVuBL dichVuBL;
        private bool isEditing = false; // false: thêm mới, true: cập nhật
        private string maDoiTacDangChon = ""; // lưu mã đối tác đang cập nhật
        public frm_trangQuanLyDoiTac()
        {
            InitializeComponent();
            doiTacBL = new DoiTacBL();
            dichVuBL = new DichVuBL();
        }
        private void LoadLoaiHinhVaoComboBox()
        {
            List<string> danhSachLoaiHinh = doiTacBL.LayDanhSachLoaiHinh(); // Gọi từ BLL
            danhSachLoaiHinh.Insert(0, "Tất cả"); // Thêm "Tất cả" lên đầu
            cbb_trangQuanLyDoiTac_loc.DataSource = danhSachLoaiHinh;
        }
        private void frm_trangQuanLyDoiTac_Load(object sender, EventArgs e)
        {
            UICustom.BoCong(pnl_quanLyDoiTac_nenChucNang, 20);
            LoadLoaiHinhVaoComboBox();
        }
        private void btn_trangQuanLyDoiTac_timKiem_Click(object sender, EventArgs e)
        {
            string keyword = txt_quanLyDoiTac_timKiem.Text.Trim();
            string loaiHinh = cbb_trangQuanLyDoiTac_loc.SelectedItem?.ToString();

            List<DoiTac> danhSach = doiTacBL.TimKiemVaLoc(keyword, loaiHinh);
            dgv_quanLyDoiTac_bangLocTimKiem.DataSource = danhSach;
        }
        private void cbb_trangQuanLyDoiTac_loc_SelectedIndexChanged(object sender, EventArgs e)
        {
            string loaiHinhChon = cbb_trangQuanLyDoiTac_loc.SelectedItem.ToString();
            List<DoiTac> danhSach;

            if (loaiHinhChon == "Tất cả")
            {
                danhSach = doiTacBL.LayTatCaDoiTac();
            }
            else
            {
                danhSach = doiTacBL.LayDoiTacTheoLoaiHinh(loaiHinhChon);
            }

            dgv_quanLyDoiTac_bangLocTimKiem.DataSource = danhSach;
            dgv_quanLyDoiTac_bangLocTimKiem.Columns[0].DefaultCellStyle.ForeColor = Color.Black;
            dgv_quanLyDoiTac_bangLocTimKiem.Columns[1].DefaultCellStyle.ForeColor = Color.Black;
            dgv_quanLyDoiTac_bangLocTimKiem.Columns[2].DefaultCellStyle.ForeColor = Color.Black;
            dgv_quanLyDoiTac_bangLocTimKiem.Columns[3].DefaultCellStyle.ForeColor = Color.Black;
        }

        private void dgv_quanLyDoiTac_bangLocTimKiem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string maDoiTac = dgv_quanLyDoiTac_bangLocTimKiem.CurrentRow.Cells[0].Value.ToString();
            var dsDoiTac = doiTacBL.LayThongTin(maDoiTac);
            if (dsDoiTac.Count > 0)
            {
                var doiTac = dsDoiTac[0];
                txt_trangQuanLyDoiTac_tenDoiTac.Text = doiTac.ten_doi_tac;
                txt_trangQuanLyDoiTac_email.Text = doiTac.email;
                txt_trangQuanLyDoiTac_soDT.Text = doiTac.so_dien_thoai;
                txt_trangQuanLyDoiTac_diaChi.Text = doiTac.dia_chi;
                txt_trangQuanLyDoiTac_maDoiTac.Text = doiTac.ma_doi_tac;
                txt_trangQuanLyDoiTac_loaiHinh.Text = doiTac.loai_hinh;
            }
            else
            {
                MessageBox.Show("Không tìm thấy thông tin đối tác.");
            }

            // Hiển thị dịch vụ
            var dsDichVu = dichVuBL.LayDichVuTheoDoiTac(maDoiTac);
            dgv_trangQuanLyDoiTac_dsDichVu.DataSource = dsDichVu;
            dgv_trangQuanLyDoiTac_dsDichVu.Columns["ma_dich_vu"].Width = 100;
            dgv_trangQuanLyDoiTac_dsDichVu.Columns["ten_dich_vu"].Width = 300;
            dgv_trangQuanLyDoiTac_dsDichVu.Columns["gia"].Width = 100;
            dgv_trangQuanLyDoiTac_dsDichVu.Columns["ma_doi_tac"].Width = 100;
            dgv_trangQuanLyDoiTac_dsDichVu.Columns["gia"].DefaultCellStyle.ForeColor = Color.Black;
            dgv_trangQuanLyDoiTac_dsDichVu.Columns["ma_dich_vu"].DefaultCellStyle.ForeColor = Color.Black;
            dgv_trangQuanLyDoiTac_dsDichVu.Columns["ten_dich_vu"].DefaultCellStyle.ForeColor = Color.Black;
            dgv_trangQuanLyDoiTac_dsDichVu.Columns["ma_doi_tac"].DefaultCellStyle.ForeColor = Color.Black;
        }
        private List<DichVu> LayDanhSachDichVuTuDataGrid()
        {
            List<DichVu> ds = new List<DichVu>();
            foreach (DataGridViewRow row in dgv_trangQuanLyDoiTac_dsDichVu.Rows)
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
        private void btn_trangQuanLyDoiTac_add_Click(object sender, EventArgs e)
        {
            txt_trangQuanLyDoiTac_tenDoiTac.Clear();
            txt_trangQuanLyDoiTac_soDT.Clear();
            txt_trangQuanLyDoiTac_email.Clear();
            txt_trangQuanLyDoiTac_diaChi.Clear();
            txt_trangQuanLyDoiTac_loaiHinh.Clear();

            txt_trangQuanLyDoiTac_tenDoiTac.ReadOnly = false;
            txt_trangQuanLyDoiTac_email.ReadOnly = false;
            txt_trangQuanLyDoiTac_soDT.ReadOnly = false;
            txt_trangQuanLyDoiTac_diaChi.ReadOnly = false;
            txt_trangQuanLyDoiTac_loaiHinh.ReadOnly = false;
            dgv_trangQuanLyDoiTac_dsDichVu.ReadOnly = false;

            // Tạo mã đối tác mới
            txt_trangQuanLyDoiTac_maDoiTac.Text = doiTacBL.GetMaDoiTacMoi();

            // Khởi tạo bảng dịch vụ rỗng (chỉ hiện Tên DV và Đơn giá)
            DataTable table = new DataTable();
            table.Columns.Add("ma_dich_vu"); // thêm cột mã dịch vụ
            dgv_trangQuanLyDoiTac_dsDichVu.Columns["ma_dich_vu"].Visible = false;
            table.Columns.Add("ten_dich_vu");
            table.Columns.Add("gia");
            dgv_trangQuanLyDoiTac_dsDichVu.DataSource = table;
            isEditing = false;
            maDoiTacDangChon = "";
        }
        private void LoadLai()
        {
            List<DoiTac> doiTacs = doiTacBL.GetDoiTacs();
            dgv_quanLyDoiTac_bangLocTimKiem.DataSource = doiTacs;

            cbb_trangQuanLyDoiTac_loc.DataSource = doiTacs;
            cbb_trangQuanLyDoiTac_loc.DisplayMember = "ten_doi_tac";
            cbb_trangQuanLyDoiTac_loc.ValueMember = "ma_doi_tac";

            // Lấy mã đối tác đang được chọn
            string maDoiTac = cbb_trangQuanLyDoiTac_loc.SelectedValue?.ToString();           
            List<DichVu> dichVus = dichVuBL.LayDichVuTheoDoiTac(maDoiTac);
            dgv_trangQuanLyDoiTac_dsDichVu.DataSource = dichVus;
            

            MessageBox.Show("Đã lưu đối tác và dịch vụ!");
            LoadLoaiHinhVaoComboBox();           
        }


        private void btn_trangQuanLyDoiTac_save_Click(object sender, EventArgs e)
        {
            
            try
            {
                DoiTac dt = new DoiTac()
                {
                    ma_doi_tac = isEditing ? maDoiTacDangChon : Guid.NewGuid().ToString(),
                    ten_doi_tac = txt_trangQuanLyDoiTac_tenDoiTac.Text.Trim(),
                    email = txt_trangQuanLyDoiTac_email.Text.Trim(),
                    so_dien_thoai = txt_trangQuanLyDoiTac_soDT.Text.Trim(),
                    dia_chi = txt_trangQuanLyDoiTac_diaChi.Text.Trim(),
                    loai_hinh = txt_trangQuanLyDoiTac_loaiHinh.Text.Trim()
                };

                List<DichVu> dsDV = LayDanhSachDichVuTuDataGrid();
                foreach (var dv in dsDV)
                {
                    if (!isEditing)
                        dv.ma_dich_vu = Guid.NewGuid().ToString(); // gán mã mới nếu thêm mới
                }

                if (isEditing)
                {
                    doiTacBL.CapNhatDoiTac(dt);
                    dichVuBL.CapNhatDanhSachDichVu(dsDV);
                    MessageBox.Show("Cập nhật thành công!");
                }
                else
                {
                    string maDoiTacMoi = doiTacBL.ThemDoiTac(dt);

                    // 2. Lấy danh sách dịch vụ và gán mã đối tác mới
                    List<DichVu> danhSachDV = LayDanhSachDichVuTuDataGrid();
                    foreach (var dv in danhSachDV)
                    {
                        dv.ma_doi_tac = maDoiTacMoi;
                    }

                    // 3. Thêm danh sách dịch vụ
                    dichVuBL.ThemDichVu(danhSachDV);
                    MessageBox.Show("Thêm mới thành công!");
                }

                txt_trangQuanLyDoiTac_tenDoiTac.ReadOnly = true;
                txt_trangQuanLyDoiTac_email.ReadOnly = true;
                txt_trangQuanLyDoiTac_soDT.ReadOnly = true;
                txt_trangQuanLyDoiTac_diaChi.ReadOnly = true;
                txt_trangQuanLyDoiTac_loaiHinh.ReadOnly = true;
                dgv_trangQuanLyDoiTac_dsDichVu.ReadOnly = true;

                LoadLai();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu: " + ex.Message);
            }

        }
        private void btn_trangQuanLyDoiTac_delete_Click(object sender, EventArgs e)
        {

            if (dgv_quanLyDoiTac_bangLocTimKiem.SelectedRows.Count > 0)
            {
                string maDoiTac = dgv_quanLyDoiTac_bangLocTimKiem.SelectedRows[0].Cells["ma_doi_tac"].Value.ToString();
                try
                {
                    doiTacBL.Delete(maDoiTac);
                    MessageBox.Show("Đối tác và dịch vụ liên quan đã được xóa.");
                    LoadLai();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn đối tác cần xóa.");
            }
        }      

        private void btn_trangQuanLyDoiTac_update_Click_1(object sender, EventArgs e)
        {
            if (dgv_quanLyDoiTac_bangLocTimKiem.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một đối tác để sửa.");
                return;
            }

            // Cho phép chỉnh sửa
            txt_trangQuanLyDoiTac_tenDoiTac.ReadOnly = false;
            txt_trangQuanLyDoiTac_email.ReadOnly = false;
            txt_trangQuanLyDoiTac_soDT.ReadOnly = false;
            txt_trangQuanLyDoiTac_diaChi.ReadOnly = false;
            txt_trangQuanLyDoiTac_loaiHinh.ReadOnly = false;
            dgv_trangQuanLyDoiTac_dsDichVu.ReadOnly = false;
            // Cập nhật trạng thái đang chỉnh sửa
            isEditing = true;
            maDoiTacDangChon = dgv_quanLyDoiTac_bangLocTimKiem.SelectedRows[0].Cells["ma_doi_tac"].Value.ToString();

            MessageBox.Show("Bạn có thể chỉnh sửa thông tin. Sau khi hoàn tất, hãy nhấn Lưu.");
        }
    }
}
