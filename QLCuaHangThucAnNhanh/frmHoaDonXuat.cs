using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;

namespace QLCuaHangThucAnNhanh
{
    public partial class frmHoaDonXuat : Form
    {
        private static frmHoaDonXuat _Instance = null;
        private HDXuatDTO hd = null;
        private CTHDXuatDTO cthd = null;
        private string _tenTK;
        public frmHoaDonXuat()
        {
            InitializeComponent();
        }
        public frmHoaDonXuat(string tenTK) : this()
        {
            this._tenTK = tenTK;
        }
        public static frmHoaDonXuat Instance
        {
            get
            {
                if(_Instance == null)
                {
                    _Instance = new frmHoaDonXuat();
                }
                return _Instance;
            }
        }

        private void frmHoaDonXuat_FormClosed(object sender, FormClosedEventArgs e)
        {
            _Instance = null;
        }

        private void frmHoaDonXuat_Load(object sender, EventArgs e)
        {
            dgvDSHDXuat.AutoGenerateColumns = dgvDSCTHDXuat.AutoGenerateColumns = false;
            gboTTCTHDXuat.Enabled = false;
            txtDonGia.Enabled = false;
            btnXoaHD.Enabled = false;
            txtMaHD.Enabled = false;
            txtTenTaiKhoan.Enabled = false;
            txtTongTien.Enabled = false;
            radTTChoXuLy.Enabled = radTTDaXuLy.Enabled = false;
            radTTChoXuLy.Checked = true;

            DataGridViewComboBoxColumn dgvcolNL = (DataGridViewComboBoxColumn)dgvDSCTHDXuat.Columns["colMaNL_CTHD"];
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

            LoadDSHDXuat();
            LamMoi();
            AddStatus(-1);
        }
        #region Events
        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            ((frmMain)(this.ParentForm)).Controls["pnlDashboard"].Visible = true;
            this.Close();
        }

        private void dgvDSHDXuat_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDSHDXuat.SelectedRows.Count > 0)
            {
                DataGridViewRow dgvRow = dgvDSHDXuat.CurrentRow;
                hd = new HDXuatDTO();
                hd.MaHDXuat = Convert.ToInt32(dgvRow.Cells["colMaHDXuat"].Value.ToString());
                //hd.TongTien = Convert.ToInt32(dgvRow.Cells["colTongTien"].Value.ToString());
                hd.TongTien = HDXuatBUS.LayTongTienHDXuat(hd.MaHDXuat);
                hd.TenTaiKhoan = dgvRow.Cells["colTenTK"].Value.ToString();
                hd.NgayXuat = Convert.ToDateTime(dgvRow.Cells["colNgayXuat"].Value.ToString());
                hd.TrangThai = Convert.ToInt32(dgvRow.Cells["colTrangThai"].Value);
                SetInfoHD();
                if (chkTrangThaiHDHuy.Checked)
                {
                    AddStatus(3);
                }
                else
                {
                    AddStatus(1);
                }
            }
        }

        private void dgvDSHDXuat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDSHDXuat.SelectedRows.Count > 0)
            {
                int numRow;
                numRow = e.RowIndex;
                txtMaHD_CTHD.Text = dgvDSHDXuat.Rows[numRow].Cells["colMaHDXuat"].Value.ToString();
                LoadDSCTHDXuat(hd.MaHDXuat);
                AddStatus(-2);
                lblSLTK.Text = lblDonViTinh.Text = string.Empty;
                lblSubSoLuongConLai.Text = "SL còn lại:";
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
                GetInfoResultHDXuat();
                if (HDXuatBUS.ThemHDXuat(hd))
                {
                    //MessageBox.Show("Thêm hóa đơn thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.None);
                    LoadDSHDXuat();
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
                    if (HDXuatBUS.CapNhatTrangThaiHuy(hd.MaHDXuat, 0))
                    {
                        LoadDSHDXuat();
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
            if (chkTrangThaiHDHuy.Checked == true)
            {
                if (hd != null)
                {
                    if (HDXuatBUS.CapNhatTrangThaiHuy(hd.MaHDXuat, 1))
                    {
                        LoadDSHDXuat();
                        //MessageBox.Show("Khôi phục hóa đơn thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.None);
                    }
                    else
                        MessageBox.Show("Khôi phục hóa đơn thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnHoanTat_Click(object sender, EventArgs e)
        {
            if (dgvDSCTHDXuat.Rows.Count == 0)
            {
                MessageBox.Show("Bạn chưa thêm thông CTHD xuất!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                if (hd != null)
                {
                    hd.NgayXuat = dtpNgayXuat.Value;          
                    if (HDXuatBUS.CapNhatTrangThaiHD(hd.MaHDXuat, 1) && HDXuatBUS.HoanTatHD(hd))
                    {
                        LoadDSHDXuat();
                        //MessageBox.Show("Tạo hóa đơn thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.None);

                        // Cập nhật nguyên liệu số lượng tồn kho - giảm
                        for (int i = 0; i < dgvDSCTHDXuat.Rows.Count; i++)
                        {
                            DataTable dt = NguyenLieuBUS.LayDSMaNL();
                            foreach (DataRow dr in dt.Rows)
                            {
                                NguyenLieuDTO nl = new NguyenLieuDTO();
                                nl.MaNL = dr["MaNL"].ToString();
                                if (dgvDSCTHDXuat.Rows[i].Cells["colMaNL_CTHD"].Value.ToString() == nl.MaNL)
                                {
                                    cthd = new CTHDXuatDTO();
                                    cthd.MaHDXuat = Convert.ToInt32(dgvDSCTHDXuat.Rows[i].Cells["colMaHDXuat_CTHD"].Value);
                                    cthd.MaNL = dgvDSCTHDXuat.Rows[i].Cells["colMaNL_CTHD"].Value.ToString();
                                    int sltk = NguyenLieuBUS.LaySoLuongTKNL(cthd.MaNL) - CTHDXuatBUS.LaySoLuongHienTai(cthd.MaHDXuat, cthd.MaNL);
                                    if (NguyenLieuBUS.CapNhatSoLuongTonKhoGiam(cthd.MaHDXuat, cthd.MaNL, sltk))
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
                LoadDSHDXuat();
            }
            else
            {
                btnHoanTat.Visible = false;
                btnTaoHD.Visible = true;
                AddStatus(-3);
                LoadDSHDXuat();
            }
        }
        // Events of CTHDXuat
        #region Events of CTHDXuat
        private void btnLamMoiCTHD_Click(object sender, EventArgs e)
        {
            LamMoiCTHD();
            lblSubSoLuongConLai.Text = "SL còn lại:";
        }

        private void cboMaNL_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboMaNL.SelectedIndex == 0)
            {
                txtDonGia.Text = NguyenLieuBUS.LayDonGiaTuMaNL("NL001").ToString();
                if (dgvDSCTHDXuat.Rows.Count > 0)
                {
                    bool result = false;
                    for (int i = 0; i < dgvDSCTHDXuat.Rows.Count; i++)
                    {
                        if (dgvDSCTHDXuat.Rows[i].Cells["colMaNL_CTHD"].Value.ToString() == "NL001")
                        {
                            result = true;
                            break;
                        }
                    }
                    if (result)
                    {
                        lblSLTK.Text = (NguyenLieuBUS.LaySoLuongTKNL("NL001") - CTHDXuatBUS.LaySoLuongHienTai(hd.MaHDXuat, "NL001")).ToString();
                    }
                }
                else
                {
                    lblSLTK.Text = NguyenLieuBUS.LaySoLuongTKNL("NL001").ToString();
                }
                lblDonViTinh.Text = NguyenLieuBUS.LayDonViTinhTuMaNL("NL001").ToString() + ")";
            }
            else if (cboMaNL.SelectedIndex > 0)
            {
                string maNL = cboMaNL.SelectedValue.ToString();
                txtDonGia.Text = NguyenLieuBUS.LayDonGiaTuMaNL(maNL).ToString();
                lblSLTK.Text = NguyenLieuBUS.LaySoLuongTKNL(maNL).ToString();
                if (dgvDSCTHDXuat.Rows.Count > 0)
                {
                    bool result = false;
                    for (int i = 0; i < dgvDSCTHDXuat.Rows.Count; i++)
                    {
                        if (dgvDSCTHDXuat.Rows[i].Cells["colMaNL_CTHD"].Value.ToString() == maNL)
                        {
                            result = true;
                            break;
                        }
                    }
                    if (result)
                    {
                        lblSLTK.Text = (NguyenLieuBUS.LaySoLuongTKNL(maNL) - CTHDXuatBUS.LaySoLuongHienTai(hd.MaHDXuat, maNL)).ToString();
                    }
                }
                else
                {
                    lblSLTK.Text = NguyenLieuBUS.LaySoLuongTKNL(maNL).ToString();
                }
                lblDonViTinh.Text = NguyenLieuBUS.LayDonViTinhTuMaNL(maNL).ToString() + ")";
            }
        }

        private void dgvDSCTHDXuat_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDSCTHDXuat.SelectedRows.Count > 0)
            {
                DataGridViewRow dgvRow = dgvDSCTHDXuat.CurrentRow;
                cthd = new CTHDXuatDTO();
                cthd.MaHDXuat = Convert.ToInt32(dgvRow.Cells["colMaHDXuat_CTHD"].Value.ToString());
                cthd.MaNL = dgvRow.Cells["colMaNL_CTHD"].Value.ToString();
                cthd.SoLuong = Convert.ToInt32(dgvRow.Cells["colSoLuong"].Value.ToString());
                cthd.DonGia = Convert.ToInt32(dgvRow.Cells["colDonGia"].Value.ToString());
                SetInfoCTHD();
                SettingText();
                lblSLTK.Text = NguyenLieuBUS.LaySoLuongTKNL(cthd.MaNL).ToString();
            }
            else
            {
                SetInfoCTHD();
            }            
            AddStatus(2);
            
        }

        private void btnThemCTHD_Click(object sender, EventArgs e)
        {
            if (txtMaHD_CTHD.Text =="" || txtSoLuongConLai.Text == "" || txtDonGia.Text == "")
            {
                MessageBox.Show("Mời bạn nhập đầy đủ thông tin CTHD xuất!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (Convert.ToInt32(txtSoLuongConLai.Text) >= NguyenLieuBUS.LaySoLuongTKNL(cboMaNL.SelectedValue.ToString()) || Convert.ToInt32(txtSoLuongConLai.Text) >= Convert.ToInt32(lblSLTK.Text))
            {
                MessageBox.Show("Số lượng còn lại không được bằng hoặc vượt quá số lượng tồn kho!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (cthd == null)
                {
                    GetInfoResultCTHDXuat();
                    cthd.SoLuong = NguyenLieuBUS.LaySoLuongTKNL(cthd.MaNL) - Convert.ToInt32(txtSoLuongConLai.Text); 
                    if (!CTHDXuatBUS.KiemTraMaNLTonTai(cthd.MaHDXuat, cthd.MaNL))
                    {
                        if (CTHDXuatBUS.ThemCTHDHDXuat(cthd))
                        {
                            if (hd != null)
                            {
                                hd.MaHDXuat = Convert.ToInt32(txtMaHD_CTHD.Text);
                                //Tổng tiền = tổng tiền HD + vs Tiền mới của 1 món ăn mói thêm vào
                                hd.TongTien = HDXuatBUS.LayTongTienHDXuat(hd.MaHDXuat) + (Convert.ToInt32(Convert.ToInt32(txtDonGia.Text) *  cthd.SoLuong));
                                if (HDXuatBUS.CapNhatHDXuat(hd.MaHDXuat, hd.TongTien))
                                {
                                    //MessageBox.Show("Thêm thông tin CTHD xuất thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.None);
                                    LoadDSCTHDXuat(hd.MaHDXuat);
                                    txtTongTien.Text = HDXuatBUS.LayTongTienHDXuat(cthd.MaHDXuat).ToString();
                                }     
                            }                      
                            cthd = null;
                        }
                        else
                        {
                            MessageBox.Show("Thêm thông tin CTHD xuất thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }                      
                    }
                    else
                    {
                        int sltk = NguyenLieuBUS.LaySoLuongTKNL(cthd.MaNL) - CTHDXuatBUS.LaySoLuongHienTai(cthd.MaHDXuat, cthd.MaNL);
                        cthd.SoLuong = (CTHDXuatBUS.LaySoLuongHienTai(cthd.MaHDXuat, cthd.MaNL) +(sltk - Convert.ToInt32(txtSoLuongConLai.Text)));
                        if (CTHDXuatBUS.CapNhatSoLuong(cthd.SoLuong, cthd.MaHDXuat, cthd.MaNL))
                        {
                            hd.TongTien = HDXuatBUS.LayTongTienHDXuat(hd.MaHDXuat) + (Convert.ToInt32(Convert.ToInt32(txtDonGia.Text) * (sltk - Convert.ToInt32(txtSoLuongConLai.Text))));
                            if (HDXuatBUS.CapNhatHDXuat(hd.MaHDXuat, hd.TongTien))
                            {
                                LoadDSCTHDXuat(hd.MaHDXuat);
                                txtTongTien.Text = HDXuatBUS.LayTongTienHDXuat(cthd.MaHDXuat).ToString();      

                                //MessageBox.Show("Thêm số lượng thông tin CTHD xuất thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.None);
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
            if (txtMaHD_CTHD.Text == "" || txtSoLuongConLai.Text == "" || txtDonGia.Text == "")
            {
                MessageBox.Show("Mời bạn nhập đầy đủ thông tin CTHD xuất!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }else if(Convert.ToInt32(txtSoLuongConLai.Text) > Convert.ToInt32(lblSLTK.Text))
            {
                MessageBox.Show("Số lượng xuất không được vượt quá số lượng tồn kho!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (cthd != null)
                {
                    GetInfoResultCTHDXuat();
                    int slHienTai = cthd.SoLuong;
                    int slBanDau = CTHDXuatBUS.LaySoLuongHienTai(cthd.MaHDXuat, cthd.MaNL);
                    if (slHienTai > 0)
                    {
                        int slThayDoi = slHienTai - slBanDau;
                        if (slThayDoi < 0)
                        {
                            hd.TongTien = HDXuatBUS.LayTongTienHDXuat(cthd.MaHDXuat) - (Math.Abs(slThayDoi) * Convert.ToInt32(txtDonGia.Text));
                           
                        }
                        else
                        {
                            hd.TongTien = HDXuatBUS.LayTongTienHDXuat(cthd.MaHDXuat) + (Math.Abs(slThayDoi) * Convert.ToInt32(txtDonGia.Text));
                            
                        }       
                        if (CTHDXuatBUS.CapNhatCTHDXuat(cthd))
                        {
                            if (HDXuatBUS.CapNhatHDXuat(hd.MaHDXuat, hd.TongTien))
                            {
                                //MessageBox.Show("Cập nhật CTHD xuất thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.None);
                                LoadDSCTHDXuat(cthd.MaHDXuat);
                                LoadDSHDXuat();
                                AddStatus(-2);       
                                txtTongTien.Text = HDXuatBUS.LayTongTienHDXuat(hd.MaHDXuat).ToString();
                                LamMoiCTHD();
                            }    
                        }
                        else
                            MessageBox.Show("Cập nhật CTHD xuất thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                        MessageBox.Show("Số lượng không được dưới 1", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            
        }

        private void btnXoaCTHD_Click(object sender, EventArgs e)
        {
            DialogResult rs = DialogResult.Yes;
            if (rs == MessageBox.Show("Bạn có chắc muốn xóa nguyên liệu này!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                if (cthd != null)
                {
                    hd.TongTien = HDXuatBUS.LayTongTienHDXuat(hd.MaHDXuat) - (Convert.ToInt32(txtDonGia.Text) * Convert.ToInt32(txtSoLuongConLai.Text));
                    if (CTHDXuatBUS.XoaCTHDXuat(cthd.MaHDXuat, cthd.MaNL))
                    {
                        LoadDSCTHDXuat(hd.MaHDXuat);
                        hd.MaHDXuat = Convert.ToInt32(txtMaHD_CTHD.Text);
                        if (HDXuatBUS.CapNhatHDXuat(hd.MaHDXuat, hd.TongTien))
                        {
                            LoadDSHDXuat();
                            AddStatus(-2);
                            //MessageBox.Show("Xóa CTHD xuất thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.None);
                            LamMoiCTHD();
                        }
                        SettingText();
                    }
                    else
                        MessageBox.Show("Xóa CTHD xuất thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtSoLuongConLai_KeyPress(object sender, KeyPressEventArgs e)
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
        void LoadDSHDXuat()
        {
            if (!chkTrangThaiHDHuy.Checked)//DS HD chưa thanh toán và đã thanh toán
            {
                dgvDSHDXuat.DataSource = HDXuatBUS.LayDSHDXuat(_tenTK);

            }
            else//DS HD bị xóa
            {
                dgvDSHDXuat.DataSource = HDXuatBUS.LayDSHDXuatBiXoa(_tenTK);
                dgvDSHDXuat.CurrentCell = null;
                AddStatus(3);
            }
        }

        void LoadDSCTHDXuat(int maHD)
        {
            dgvDSCTHDXuat.DataSource = CTHDXuatBUS.LayDSCTHDXuat(maHD);
            dgvDSCTHDXuat.CurrentCell = null;
        }

        void GetInfoResultHDXuat()
        {
            if (hd == null)
            {
                hd = new HDXuatDTO();
            }
            hd.MaHDXuat = Convert.ToInt32(txtMaHD.Text);
            hd.TenTaiKhoan = txtTenTaiKhoan.Text; 
            hd.NgayXuat = Convert.ToDateTime(dtpNgayXuat.Value.ToString());
            hd.TongTien = 0;
            if (radTTChoXuLy.Checked)
            {
                hd.TrangThai = 0;
            }
            hd.TonTai = 1;
        }

        void GetInfoResultCTHDXuat()
        {
            if (cthd == null)
            {
                cthd = new CTHDXuatDTO();
            }
            cthd.MaHDXuat = Convert.ToInt32(txtMaHD_CTHD.Text);
            cthd.MaNL = cboMaNL.SelectedValue.ToString();
            cthd.SoLuong = Convert.ToInt32(txtSoLuongConLai.Text);
            cthd.DonGia = Convert.ToInt32(txtDonGia.Text);
        }

        void SetInfoHD()
        {
            if (hd == null)
                hd = new HDXuatDTO();
            txtMaHD.Text = hd.MaHDXuat.ToString();
            txtTenTaiKhoan.Text = hd.TenTaiKhoan;
            dtpNgayXuat.Text = hd.NgayXuat.ToString();
            txtTongTien.Text = hd.TongTien.ToString();
        }

        void SetForm()
        {
            frmMain frm = new frmMain();
            txtMaHD.Text = HDXuatBUS.LayMaHDXuatLonNhat().ToString();
            txtTenTaiKhoan.Text = ((frmMain)this.ParentForm).getTenTK();
            dtpNgayXuat.Value = DateTime.Now;
        }

        void SetFormCTHD()
        {
            txtDonGia.Text = txtSoLuongConLai.Text = string.Empty;
            cboMaNL.SelectedValue = -1;
            txtMaHD_CTHD.Text = txtMaHD.Text;
        }

        private void SetInfoCTHD()
        {
            if (dgvDSCTHDXuat.SelectedRows.Count > 0)
            {
                if (cthd == null)
                    cthd = new CTHDXuatDTO();
                txtMaHD_CTHD.Text = cthd.MaHDXuat.ToString();
                cboMaNL.SelectedValue = cthd.MaNL;
                txtDonGia.Text = cthd.DonGia.ToString();
                txtSoLuongConLai.Text = cthd.SoLuong.ToString();
            }
            else
                SetFormCTHD();
        }

        void LamMoi()
        {
            SetForm();
            // Clear Form HDXuat
            txtTongTien.Clear();

            // Clear Form CTHDXuat
            txtMaHD_CTHD.Clear();
            cboMaNL.SelectedValue = -1;
            txtDonGia.Clear();
            lblSLTK.Text = string.Empty;
            lblDonViTinh.Text = ")";
            dgvDSCTHDXuat.DataSource = null;
            dgvDSHDXuat.CurrentCell = null;
        }

        void LamMoiCTHD()
        {
            AddStatus(-2);
            cboMaNL.SelectedValue = -1;
            txtSoLuongConLai.Clear();
            txtDonGia.Clear();
            lblSLTK.Text = lblDonViTinh.Text = string.Empty;
        }

        void SetEnableInfoHD(int k)
        {
            //Khi chkTrangThaiHuyHD.Checked = true 
            if (k == 1)
            {
                dtpNgayXuat.Enabled = false;
            }
            //Khi chkTrangThaiHuyHD.Checked = false 
            else if (k == -1)
            {
                dtpNgayXuat.Enabled = true;
            }
        }

        void AddStatus(int k)
        {
            if (k == 1) // Khi chọn 1 dòng - thông tin hóa đơn nhập
            {

                bool t = true;
                gboTTCTHDXuat.Enabled = t;
                btnTaoHD.Hide();
                btnHoanTat.Show();
                btnCapNhatCTHD.Hide();
                btnXoaCTHD.Enabled = !t;
                if (hd.TrangThai == 0)
                {
                    panel2.Enabled = t;
                    dtpNgayXuat.Enabled = t;
                    btnHoanTat.Enabled = t;
                    btnXoaHD.Enabled = !t;
                    btnLamMoiHD.Enabled = !t;
                }
                else
                {
                    panel2.Enabled = !t;
                    dtpNgayXuat.Enabled = !t;
                    btnHoanTat.Enabled = !t;
                    btnXoaHD.Enabled = t;
                    btnLamMoiHD.Enabled = t;
                }
            }
            else if (k == -1) // Khi làm mới tạo để tạo hóa đơn nhập
            {
                hd = null;//Thêm vào để sửa trường hợp mới load frmHDNhap không thể thêm
                bool t = true;
                gboTTCTHDXuat.Enabled = !t;
                btnTaoHD.Enabled = t;
                btnTaoHD.Show();
                btnHoanTat.Hide();
                btnXoaHD.Enabled = !t;
                btnLamMoiHD.Enabled = t;
                txtMaHD_CTHD.Enabled = !t;
                btnHoanTat.Enabled = !t;
                dtpNgayXuat.Enabled = t;
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
            else if (k == 3) //chkTrangThaiHuyHD.Checked = true -> LoadDSHDNhapBiHuy
            {
                bool t = false;
                btnTaoHD.Visible = t;
                btnXoaHD.Visible = t;
                btnLamMoiHD.Visible = t;
                btnHoanTat.Visible = t;
                btnKhoiPhuc.Visible = !t;
                if (dgvDSHDXuat.Rows.Count > 0)
                    btnKhoiPhuc.Enabled = !t;
                else
                    btnKhoiPhuc.Enabled = t;

            }
            else if (k == -3)//chkTrangThaiHuyHD.Checked = false -> LoadDSHDNhap
            {
                bool t = true;
                btnKhoiPhuc.Visible = !t;
                btnXoaHD.Visible = t;
                btnLamMoiHD.Visible = t;
                btnHoanTat.Visible = t;
                btnHoanTat.Enabled = t;
            }
        }

        void SettingText()
        {
            if(dgvDSCTHDXuat.Rows.Count > 0)
            {
                lblSubSoLuongConLai.Text = "SL xuất:";
            }
            else
            {
                lblSubSoLuongConLai.Text = "SL còn lại:";
            }
            
        }


        #endregion

        private void btnAddMaNL_Click(object sender, EventArgs e)
        {
            frmNguyenLieu frm = new frmNguyenLieu(_tenTK, 2);
            frm.MdiParent = this.MdiParent;
            frm.Dock = DockStyle.Fill;
            frm.Show();
            this.Hide();
        }
    }
}
