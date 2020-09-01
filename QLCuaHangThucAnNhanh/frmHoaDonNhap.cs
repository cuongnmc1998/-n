using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;

namespace QLCuaHangThucAnNhanh
{
    public partial class frmHoaDonNhap : Form
    {
        private static frmHoaDonNhap _Instance = null;
        private HDNhapDTO hd = null;
        private CTHDNhapDTO cthd = null;
        private string _tenTK;
        public frmHoaDonNhap()
        {
            InitializeComponent();
        }
        public frmHoaDonNhap(string tenTK) : this()
        {
            this._tenTK = tenTK;
        }
        public static frmHoaDonNhap Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new frmHoaDonNhap();
                }
                return _Instance;
            }
        }

        private void frmHoaDonNhap_FormClosed(object sender, FormClosedEventArgs e)
        {
            _Instance = null;
        }

        private void frmHoaDonNhap_Load(object sender, EventArgs e)
        {
            dgvDSHDNhap.AutoGenerateColumns = dgvDSCTHDNhap.AutoGenerateColumns = false;
            gboTTCTHDNhap.Enabled = false;
            txtDonGia.Enabled = false;
            btnXoaHD.Enabled = false;
            txtMaHD.Enabled = false;
            txtTenTaiKhoan.Enabled = false;
            txtTongTien.Enabled = false;
            radTTChuaThanhToan.Enabled = radTTDaThanhToan.Enabled = false;
            radTTChuaThanhToan.Checked = true;

            DataGridViewComboBoxColumn dgvcolNCC = (DataGridViewComboBoxColumn)dgvDSHDNhap.Columns["colNhaCungCap"];
            DataTable dtNhaCungCap = NhaCungCapBUS.LayDSNhaCungCap();
            // Đỗ dữ liệu cho cbo trong dgv
            dgvcolNCC.DataSource = dtNhaCungCap;
            dgvcolNCC.DisplayMember = "TenNhaCC";
            dgvcolNCC.ValueMember = "MaNCC";
            // Đỗ dữ liệu cho cbo NhaCungCap
            cboNhaCC.DataSource = dtNhaCungCap;
            cboNhaCC.DisplayMember = "TenNhaCC";
            cboNhaCC.ValueMember = "MaNCC";

            DataGridViewComboBoxColumn dgvcolNL = (DataGridViewComboBoxColumn)dgvDSCTHDNhap.Columns["colMaNL_CTHD"];
            DataTable dtNguyenLieu = NguyenLieuBUS.LoadDSNguyenLieu();
            // Đỗ dữ liệu cho cbo trong dgv
            dgvcolNL.DataSource = dtNguyenLieu;
            dgvcolNL.DisplayMember = "TenNL";
            dgvcolNL.ValueMember = "MaNL";
            // Đỗ dữ liệu cho cbo MaNguyenLieu
            cboMaNL.DataSource = dtNguyenLieu;
            cboMaNL.DisplayMember = "TenNL";
            cboMaNL.ValueMember = "MaNL";

            cboMaNL.SelectedValue = -1;
            txtDonGia.Text = "";

            LoadDSHDNhap();
            LamMoi();
            AddStatus(-1);
        }

        #region Events
        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            ((frmMain)(this.ParentForm)).Controls["pnlDashboard"].Visible = true;
            this.Close();
        }

        private void dgvDSHDNhap_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDSHDNhap.SelectedRows.Count > 0)
            {
                DataGridViewRow dgvRow = dgvDSHDNhap.CurrentRow;
                hd = new HDNhapDTO();
                hd.MaHDNhap = Convert.ToInt32(dgvRow.Cells["colMaHDNhap"].Value.ToString());
                //hd.TongTien = Convert.ToInt32(dgvRow.Cells["colTongTien"].Value.ToString());
                hd.TongTien = HDNhapBUS.LayTongTienHDNhap(hd.MaHDNhap);
                hd.TenTaiKhoan = dgvRow.Cells["colTenTK"].Value.ToString();
                hd.MaNCC = dgvRow.Cells["colNhaCungCap"].Value.ToString();
                hd.NgayNhap = Convert.ToDateTime(dgvRow.Cells["colNgayNhap"].Value.ToString());
                hd.TrangThai = Convert.ToInt32(dgvRow.Cells["colTrangThai"].Value);
                SetInfoHD();
                if (chkTrangThaiHDHuy.Checked)
                {
                    AddStatus(3);
                }
                else
                    AddStatus(1);
            }
        }

        private void dgvDSHDNhap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDSHDNhap.SelectedRows.Count > 0)
            {
                int numRow;
                numRow = e.RowIndex;
                txtMaHD_CTHD.Text = dgvDSHDNhap.Rows[numRow].Cells["colMaHDNhap"].Value.ToString();
                LoadDSCTHDNhap(hd.MaHDNhap);
                AddStatus(-2);
            }
        }

        private void btnLamMoiHD_Click(object sender, EventArgs e)
        {
            LamMoi();
            AddStatus(-1);
        }

        private void btnTaoHD_Click(object sender, EventArgs e)
        {
            if (hd == null)
            {
                GetInfoResultHDNhap();
                if (HDNhapBUS.ThemHDNhap(hd))
                {
                    //MessageBox.Show("Thêm hóa đơn thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.None);
                    LoadDSHDNhap();
                    AddStatus(1);
                }
                else
                {
                    MessageBox.Show("Thêm hóa đơn thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnXoaHD_Click(object sender, EventArgs e)
        {
            //TrangThai: 0: chưa thanh toán || 1: đã thanh toán 
            //TonTai: 0: đã hủy || 1: chưa hủy
            if (hd != null)
            {
                DialogResult ds = DialogResult.Yes;
                if (ds == MessageBox.Show("Bạn có chắc muốn xóa hóa đơn này không!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    if (HDNhapBUS.CapNhatTrangThaiHuy(hd.MaHDNhap, 0))
                    {
                        LoadDSHDNhap();
                        //MessageBox.Show("Xóa hóa đơn thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.None);
                        LamMoi();
                        AddStatus(-1);         
                    }
                    else
                        MessageBox.Show("Xóa hóa đơn thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnKhoiPhuc_Click(object sender, EventArgs e)
        {
            if(chkTrangThaiHDHuy.Checked == true)
            {
                if (hd != null)
                {
                    if (HDNhapBUS.CapNhatTrangThaiHuy(hd.MaHDNhap, 1))
                    {
                        LoadDSHDNhap();
                        //MessageBox.Show("Khôi phục hóa đơn thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.None);
                    }
                    else
                        MessageBox.Show("Khôi phục hóa đơn thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnHoanTat_Click(object sender, EventArgs e)
        {
            if (dgvDSCTHDNhap.Rows.Count == 0)
            {
                MessageBox.Show("Bạn chưa thêm thông CTHD nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                if (hd != null)
                {
                    hd.MaNCC = cboNhaCC.SelectedValue.ToString();
                    hd.NgayNhap = dtpNgayNhap.Value;
                    if (HDNhapBUS.CapNhatTrangThaiHD(hd.MaHDNhap, 1) && HDNhapBUS.HoanTatHD(hd))
                    {
                        LoadDSHDNhap();
                        //MessageBox.Show("Tạo hóa đơn thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.None);


                        // Cập nhật nguyên liệu số lượng tồn kho - tăng
                        for (int i = 0; i < dgvDSCTHDNhap.Rows.Count; i++)
                        {
                            DataTable dt = NguyenLieuBUS.LayDSMaNL();
                            foreach (DataRow dr in dt.Rows)
                            {
                                NguyenLieuDTO nl = new NguyenLieuDTO();
                                nl.MaNL = dr["MaNL"].ToString();
                                if (dgvDSCTHDNhap.Rows[i].Cells["colMaNL_CTHD"].Value.ToString() == nl.MaNL)
                                {
                                    cthd = new CTHDNhapDTO();
                                    cthd.MaHDNhap = Convert.ToInt32(dgvDSCTHDNhap.Rows[i].Cells["colMaHDNhap_CTHD"].Value);
                                    cthd.MaNL = dgvDSCTHDNhap.Rows[i].Cells["colMaNL_CTHD"].Value.ToString();
                                    int sltk = NguyenLieuBUS.LaySoLuongTKNL(cthd.MaNL) + CTHDNhapBUS.LaySoLuongHienTai(cthd.MaHDNhap, cthd.MaNL);
                                    if (NguyenLieuBUS.CapNhatSoLuongTonKhoTang(cthd.MaHDNhap, cthd.MaNL, sltk))
                                    {
                                        //MessageBox.Show("Cập nhật số lượng tồn kho thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.None);
                                    }
                                    else
                                    {
                                        MessageBox.Show("Cập nhật số lượng tồn kho thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                            }
                        }
                    }
                    else
                        MessageBox.Show("Tạo hóa đơn thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }   
        }

        private void chkTrangThaiHDHuy_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTrangThaiHDHuy.Checked)
            {
                SetEnableInfoHD(1);
                AddStatus(3);
                LoadDSHDNhap();
            }
            else
            {
                btnHoanTat.Visible = false;
                btnTaoHD.Visible = true;
                AddStatus(-3);
                LoadDSHDNhap();
            }
        }
        // Events of CTHDNhap
        #region Events of CTHDNhap
        private void btnLamMoiCTHD_Click(object sender, EventArgs e)
        {
            LamMoiCTHD();
        }

        private void cboMaNL_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboMaNL.SelectedIndex == 0)
            {
                txtDonGia.Text = NguyenLieuBUS.LayDonGiaTuMaNL("NL001").ToString();
            }
            else if (cboMaNL.SelectedIndex > 0)
            {
                string maNL = cboMaNL.SelectedValue.ToString();
                txtDonGia.Text = NguyenLieuBUS.LayDonGiaTuMaNL(maNL).ToString();
            }
        }

        private void dgvDSCTHDNhap_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDSCTHDNhap.SelectedRows.Count > 0)
            {
                DataGridViewRow dgvRow = dgvDSCTHDNhap.CurrentRow;
                cthd = new CTHDNhapDTO();
                cthd.MaHDNhap = Convert.ToInt32(dgvRow.Cells["colMaHDNhap_CTHD"].Value.ToString());
                cthd.MaNL = dgvRow.Cells["colMaNL_CTHD"].Value.ToString();
                cthd.SoLuong = Convert.ToInt32(dgvRow.Cells["colSoLuong"].Value.ToString());
                cthd.DonGia = Convert.ToInt32(dgvRow.Cells["colDonGia"].Value.ToString());
                SetInfoCTHD();
            }
            else
                SetInfoCTHD();
            AddStatus(2);
        }

        private void btnThemCTHD_Click(object sender, EventArgs e)
        {
            if (txtMaHD_CTHD.Text == "" || txtSoLuong.Text == "" || txtDonGia.Text == "")
            {
                MessageBox.Show("Mời bạn nhập đầy đủ thông tin CTHD nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (cthd == null)
                {
                    GetInfoResultCTHDNhap();
                    if (!CTHDNhapBUS.KiemTraMaNLTonTai(cthd.MaHDNhap, cthd.MaNL))
                    {
                        if (CTHDNhapBUS.ThemCTHDHDNhap(cthd))
                        {
                            if (hd != null)
                            {
                                hd.MaHDNhap = Convert.ToInt32(txtMaHD_CTHD.Text);
                                //Tổng tiền = tổng tiền HD + vs Tiền mới của 1 món ăn mói thêm vào
                                hd.TongTien = HDNhapBUS.LayTongTienHDNhap(hd.MaHDNhap) + (Convert.ToInt32(Convert.ToInt32(txtDonGia.Text) * Convert.ToInt32(txtSoLuong.Text)));
                                hd.TrangThai = 1;
                                if (HDNhapBUS.CapNhatHDNhap(hd.MaHDNhap, hd.TongTien))
                                {
                                    //MessageBox.Show("Thêm thông tin CTHD nhập thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.None);           
                                    LoadDSCTHDNhap(hd.MaHDNhap);
                                    txtTongTien.Text = HDNhapBUS.LayTongTienHDNhap(cthd.MaHDNhap).ToString();
                                }

                            }
                            cthd = null;
                        }
                        else
                        {
                            MessageBox.Show("Thêm thông tin CTHD nhập thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        cthd.SoLuong = Convert.ToInt32(txtSoLuong.Text) + CTHDNhapBUS.LaySoLuongHienTai(cthd.MaHDNhap, cthd.MaNL);
                        if (CTHDNhapBUS.CapNhatSoLuong(cthd.SoLuong, cthd.MaHDNhap, cthd.MaNL))
                        {
                            hd.TongTien = HDNhapBUS.LayTongTienHDNhap(hd.MaHDNhap) + (Convert.ToInt32(Convert.ToInt32(txtDonGia.Text) * Convert.ToInt32(txtSoLuong.Text)));
                            if (HDNhapBUS.CapNhatHDNhap(hd.MaHDNhap, hd.TongTien))
                            {
                                LoadDSCTHDNhap(hd.MaHDNhap);
                                txtTongTien.Text = HDNhapBUS.LayTongTienHDNhap(cthd.MaHDNhap).ToString("0,0 VND");
                                
                                //MessageBox.Show("Thêm số lượng thông tin CTHD nhập thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.None);
                            }
                        }
                        cthd = null;
                    }
                    AddStatus(-2);
                }
            }
        }

        private void btnCapNhatCTHD_Click(object sender, EventArgs e)
        {
            if (cthd != null)
            {
                GetInfoResultCTHDNhap();
                int slHienTai = cthd.SoLuong;
                int slBanDau = CTHDNhapBUS.LaySoLuongHienTai(cthd.MaHDNhap, cthd.MaNL);
                if (slHienTai > 0)
                {
                    int slThayDoi = slHienTai - slBanDau;
                    if (slThayDoi < 0)
                    {
                        hd.TongTien = HDNhapBUS.LayTongTienHDNhap(cthd.MaHDNhap) - (Math.Abs(slThayDoi) * Convert.ToInt32(txtDonGia.Text));
                    }
                    else
                        hd.TongTien = HDNhapBUS.LayTongTienHDNhap(cthd.MaHDNhap) + (Math.Abs(slThayDoi) * Convert.ToInt32(txtDonGia.Text));
                    if (CTHDNhapBUS.CapNhatCTHDNhap(cthd))
                    {
                        if (HDNhapBUS.CapNhatHDNhap(hd.MaHDNhap, hd.TongTien))
                        {
                            LoadDSCTHDNhap(cthd.MaHDNhap);
                            LoadDSHDNhap();
                            AddStatus(-2);
                            //MessageBox.Show("Cập nhật CTHD nhập thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.None);
                        }
                    }
                    else
                        MessageBox.Show("Cập nhật CTHD nhập thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                    MessageBox.Show("Số lượng không được dưới 1", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnXoaCTHD_Click(object sender, EventArgs e)
        {
            DialogResult rs = DialogResult.Yes;
            if (rs == MessageBox.Show("Bạn có chắc muốn xóa nguyên liệu này!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                if (cthd != null)
                {
                    hd.TongTien = HDNhapBUS.LayTongTienHDNhap(hd.MaHDNhap) - (Convert.ToInt32(txtDonGia.Text) * Convert.ToInt32(txtSoLuong.Text));
                    if (CTHDNhapBUS.XoaCTHDNhap(cthd.MaHDNhap, cthd.MaNL))
                    {
                        LoadDSCTHDNhap(hd.MaHDNhap);
                        hd.MaHDNhap = Convert.ToInt32(txtMaHD_CTHD.Text);
                        hd.TrangThai = 1;
                        if (HDNhapBUS.CapNhatHDNhap(hd.MaHDNhap, hd.TongTien))
                        {
                            LoadDSHDNhap();
                            AddStatus(-2);
                            //MessageBox.Show("Xóa CTHD nhập thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.None);
                        }
                    }
                    else
                        MessageBox.Show("Xóa CTHD nhập thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtDonGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        #endregion

        #endregion

        #region Functions
        void LoadDSHDNhap()
        {
            if (!chkTrangThaiHDHuy.Checked)//DS HD chưa thanh toán và đã thanh toán
            {
                dgvDSHDNhap.DataSource = HDNhapBUS.LayDSHDNhap(_tenTK);
            }
            else//DS HD bị xóa
            {
                dgvDSHDNhap.DataSource = HDNhapBUS.LayDSHDNhapBiXoa(_tenTK);
                dgvDSHDNhap.CurrentCell = null;
                AddStatus(3);
            }
        }

        void LoadDSCTHDNhap(int maHD)
        {
            dgvDSCTHDNhap.DataSource = CTHDNhapBUS.LayDSCTHDNhap(maHD);
            dgvDSCTHDNhap.CurrentCell = null;
        }

        void GetInfoResultHDNhap()
        {
            if (hd == null)
            {
                hd = new HDNhapDTO();
            }
            hd.MaHDNhap = Convert.ToInt32(txtMaHD.Text);
            hd.TenTaiKhoan = txtTenTaiKhoan.Text;
            hd.MaNCC = cboNhaCC.SelectedValue.ToString();
            hd.NgayNhap = Convert.ToDateTime(dtpNgayNhap.Value.ToString());
            hd.TongTien = 0;
            if (radTTChuaThanhToan.Checked)
            {
                hd.TrangThai = 0;
            }
            hd.TonTai = 1;
        }

        void GetInfoResultCTHDNhap()
        {
            if (cthd == null)
            {
                cthd = new CTHDNhapDTO();
            }
            cthd.MaHDNhap = Convert.ToInt32(txtMaHD_CTHD.Text);
            cthd.MaNL = cboMaNL.SelectedValue.ToString();
            cthd.SoLuong = Convert.ToInt32(txtSoLuong.Text);
            cthd.DonGia = Convert.ToInt32(txtDonGia.Text);
        }

        void SetInfoHD()
        {
            if (hd == null)
                hd = new HDNhapDTO();
            txtMaHD.Text = hd.MaHDNhap.ToString();
            txtTenTaiKhoan.Text = hd.TenTaiKhoan;
            dtpNgayNhap.Text = hd.NgayNhap.ToString();
            cboNhaCC.Text = hd.MaNCC;
            txtTongTien.Text = hd.TongTien.ToString();
            if (hd.TrangThai == 1)
            {
                radTTDaThanhToan.Checked = true;
            }
            else
            {
                radTTChuaThanhToan.Checked = true;
            }
        }

        void SetForm()
        {
            frmMain frm = new frmMain();
            txtMaHD.Text = HDNhapBUS.LayMaHDNhapLonNhat().ToString();
            txtTenTaiKhoan.Text = ((frmMain)this.ParentForm).getTenTK();
            dtpNgayNhap.Value = DateTime.Now;
        }

        void SetFormCTHD()
        {
            txtDonGia.Text = txtSoLuong.Text = string.Empty;
            cboMaNL.SelectedValue = -1;
            txtMaHD_CTHD.Text = txtMaHD.Text;
        }

        private void SetInfoCTHD()
        {
            if (dgvDSCTHDNhap.SelectedRows.Count > 0)
            {
                if (cthd == null)
                    cthd = new CTHDNhapDTO();
                txtMaHD_CTHD.Text = cthd.MaHDNhap.ToString();
                cboMaNL.SelectedValue = cthd.MaNL;
                txtDonGia.Text = cthd.DonGia.ToString();
                txtSoLuong.Text = cthd.SoLuong.ToString();
            }
            else
                SetFormCTHD();
        }

        void LamMoi()
        {
            SetForm();
            // Clear Form HDNhap
            txtTongTien.Clear();
            cboNhaCC.SelectedValue = "NCC001";
            radTTChuaThanhToan.Checked = true;

            // Clear Form CTHDNhap
            txtMaHD_CTHD.Clear();
            cboMaNL.SelectedValue = -1;
            txtDonGia.Clear();
            dgvDSCTHDNhap.DataSource = null;
            dgvDSHDNhap.CurrentCell = null;
        }

        void LamMoiCTHD()
        {
            AddStatus(-2);
            cboMaNL.SelectedValue = -1;
            txtSoLuong.Clear();
            txtDonGia.Clear();
        }

        void SetEnableInfoHD(int k)
        {
            //Khi chkTrangThaiHuyHD.Checked = true 
            if (k == 1)
            {
                cboNhaCC.Enabled = false;
                dtpNgayNhap.Enabled = false;
            }
            //Khi chkTrangThaiHuyHD.Checked = false 
            else if (k == -1)
            {
                cboNhaCC.Enabled = true;
                dtpNgayNhap.Enabled = true;
            }
        }

        void AddStatus(int k)
        {
            if (k == 1) // Khi chọn 1 dòng - thông tin hóa đơn nhập
            {   
                bool t = true;
                gboTTCTHDNhap.Enabled = t;
                btnTaoHD.Hide();
                btnHoanTat.Show();
                btnCapNhatCTHD.Hide();
                btnXoaCTHD.Enabled = !t;             
                if (hd.TrangThai == 0) // Trạng thái hóa đơn chưa thanh toán
                {
                    panel2.Enabled = t;
                    txtMaHD_CTHD.Enabled = !t;
                    dtpNgayNhap.Enabled = t;
                    cboNhaCC.Enabled = t;
                    btnHoanTat.Enabled = t;
                    btnXoaHD.Enabled = !t;
                    btnLamMoiHD.Enabled = !t;
                }
                else 
                {
                    panel2.Enabled = !t;
                    dtpNgayNhap.Enabled = !t;
                    cboNhaCC.Enabled = !t;
                    btnHoanTat.Enabled = !t;
                    btnXoaHD.Enabled = t;
                    btnLamMoiHD.Enabled = t;
                }
                

            }
            else if (k == -1) // Khi làm mới tạo để tạo hóa đơn nhập
            {
                hd = null;
                bool t = true;
                gboTTCTHDNhap.Enabled = !t;
                btnTaoHD.Enabled = t;
                btnTaoHD.Show();
                btnHoanTat.Hide();
                btnXoaHD.Enabled = !t;
                btnLamMoiHD.Enabled = t;
                txtMaHD_CTHD.Enabled = !t;
                btnHoanTat.Enabled = !t;
                cboNhaCC.Enabled = t;
                dtpNgayNhap.Enabled = t;
            }
            else if (k == 2) //Khi chọn 1 dòng CTHD
            {
                bool t = false;
                btnThemCTHD.Enabled = t;
                btnXoaCTHD.Enabled = !t;
                cboMaNL.Enabled = t;
                btnThemCTHD.Visible = t;
                btnCapNhatCTHD.Visible = !t;
            }
            else if (k == -2)// Khi làm mới cthd nhập
            {
                cthd = null;
                bool t = true;
                btnThemCTHD.Enabled = t;
                btnXoaCTHD.Enabled = !t;
                cboMaNL.Enabled = t;
                btnThemCTHD.Visible = t;
                btnCapNhatCTHD.Visible = !t;
            }
            else if(k == 3) // chkTrangThaiHDHuy == true -> LoadHDBiHuy
            {
                bool t = false;
                btnTaoHD.Visible = t;
                btnXoaHD.Visible = t;
                btnLamMoiHD.Visible = t;
                btnHoanTat.Visible = t;
                btnKhoiPhuc.Visible = !t;
                if (dgvDSHDNhap.Rows.Count > 0)
                    btnKhoiPhuc.Enabled = !t;
                else
                {
                    btnKhoiPhuc.Enabled = t;
                }
                    
            }
            else if(k == -3) // chkTrangThaiHDHuy == false -> LoadHDTonTai
            {
                bool t = true;
                btnKhoiPhuc.Visible = !t;
                btnXoaHD.Visible = t;
                btnLamMoiHD.Visible = t;
                btnHoanTat.Visible = t;
                btnHoanTat.Enabled = t;
            }
        }


        #endregion

        private void btnAddMaNCC_Click(object sender, EventArgs e)
        {
            frmNhaCC frm = new frmNhaCC(_tenTK,2);
            frm.MdiParent = this.MdiParent;
            frm.Dock = DockStyle.Fill;
            frm.Show();
            this.Hide();
        }

        private void btnAddMaNL_Click(object sender, EventArgs e)
        {
            frmNguyenLieu frm = new frmNguyenLieu(_tenTK,1);
            frm.MdiParent = this.MdiParent;
            frm.Dock = DockStyle.Fill;
            frm.Show();
            this.Hide();
        }
    }
}
