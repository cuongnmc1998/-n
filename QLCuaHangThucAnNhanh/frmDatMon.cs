using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace QLCuaHangThucAnNhanh
{
    public partial class frmDatMon : Form
    {
       // ListView lsvMon;
        MonDTO monChon = null;
        CTHDBanHangDTO cthd = null;
        HDBanHangDTO hdBH;
        private static frmDatMon _Instance = null;
        public frmDatMon()
        {
            InitializeComponent();
        }

        public static frmDatMon Instance
        {
            get
            {
                if(_Instance == null)
                {
                    _Instance = new frmDatMon();
                }
                return _Instance;
            }
        }
        
        private void frmDatMon_Load(object sender, EventArgs e)
        {
            //tabPTK.Hide();
            tabMonAn.TabPages.Remove(tabTimKiem);
            dgvCTHDThanhToan.AutoGenerateColumns = false;
            btnThanhToan.Enabled = false;
            btnHuy.Enabled = false;
            panel1.Enabled = false;
            lblDonGia.Text = lblTenMon.Text = string.Empty;
            LoadTabMonAn();
            AddStatus(-1);
        }

        private void frmDatMon_FormClosed(object sender, FormClosedEventArgs e)
        {
            _Instance = null;
        }


        #region Events
        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            ((frmMain)(this.ParentForm)).Controls["pnlDashboard"].Visible = true;
            this.Close();
        }

        #region EventHDBanHang
        private void btnTaoHD_Click(object sender, EventArgs e)
        {
            TaoHDBanHang();
        }

        private void txtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            if (dgvCTHDThanhToan.Rows.Count > 0)
            {
                DialogResult dr = DialogResult.Yes;
                if (dr == MessageBox.Show("Bạn có muốn hủy tất cả món ăn hay không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    if (CTHDBanHangBUS.XoaTatCaMonAnHD(hdBH.MaHD))
                    {
                        if (!HDBanHangBUS.CapNhatTongTien(hdBH.MaHD, 0))
                        {
                            MessageBox.Show("Cập nhật tổng tiến thất bại", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        }
                    }
                    else
                        MessageBox.Show("Hủy thất bại", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    LoadDSCTHDBanHang();
                }
            }
            else
                MessageBox.Show("Không có món ăn nào trong chi tiết hóa đơn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion

        #region EventThemCTHD    
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtSoLuong.Text.Trim() == "" || lblTenMon.Text == "" || lblDonGia.Text == "")
            {
                MessageBox.Show("Mời bạn chọn món ăn và nhập số lượng trước khi thêm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                //cthd = null;
                SetCTHDBanHang();
                if (CTHDBanHangBUS.KiemTraMonAnTonTai(hdBH.MaHD, cthd.MaMon))
                {
                    cthd.SoLuong = CTHDBanHangBUS.SoLuongCTHDBanHang(hdBH.MaHD, cthd.MaMon) + (Convert.ToInt32(txtSoLuong.Text));
                    hdBH.TongTien = HDBanHangBUS.TongTienHienTaiHoaDon(hdBH.MaHD) + (Convert.ToInt32(txtSoLuong.Text) * MonBUS.LayDonGiaMonAn(cthd.MaMon));
                    if (CTHDBanHangBUS.CapNhatSLMonAn(hdBH.MaHD, cthd.MaMon, cthd.SoLuong))
                    {
                        if (!HDBanHangBUS.CapNhatTongTien(hdBH.MaHD, hdBH.TongTien))
                        {
                            MessageBox.Show("Cập nhật tổng tiền thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        //MessageBox.Show("Cập nhật món ăn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadDSCTHDBanHang();
                    }
                    else
                        MessageBox.Show("Cập nhật món ăn thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {

                    if (CTHDBanHangBUS.ThemMonAnVaoCTHD(cthd))
                    {
                        hdBH.TongTien = HDBanHangBUS.TongTienHienTaiHoaDon(hdBH.MaHD) + (Convert.ToInt32(txtSoLuong.Text) * Convert.ToInt32(MonBUS.LayDonGiaMonAn(cthd.MaMon)));
                        if (!HDBanHangBUS.CapNhatTongTien(hdBH.MaHD, hdBH.TongTien))
                        {
                            MessageBox.Show("Cập nhật tổng tiền thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        //MessageBox.Show("Thêm món ăn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadDSCTHDBanHang();
                    }
                    else
                        MessageBox.Show("Thêm món ăn thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                AddStatus(-1);
            }
        }
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            SetCTHDBanHang();
            int slHienTai = cthd.SoLuong;
            int slHienCo = CTHDBanHangBUS.SoLuongCTHDBanHang(hdBH.MaHD, cthd.MaMon);
            int tong = slHienTai - slHienCo;//6 4
            if (tong < 0)
            {
                hdBH.TongTien = HDBanHangBUS.TongTienHienTaiHoaDon(hdBH.MaHD) - (Math.Abs(tong) * MonBUS.LayDonGiaMonAn(cthd.MaMon));
            }
            else
                hdBH.TongTien = HDBanHangBUS.TongTienHienTaiHoaDon(hdBH.MaHD) + (Math.Abs(tong) * MonBUS.LayDonGiaMonAn(cthd.MaMon));
            if (CTHDBanHangBUS.CapNhatMonAn(cthd))
            {
                if (HDBanHangBUS.CapNhatTongTien(hdBH.MaHD, hdBH.TongTien))
                {
                    //MessageBox.Show("Cập nhật món ăn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDSCTHDBanHang();
                }
                else
                    MessageBox.Show("Cập nhật món ăn thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dr = DialogResult.Yes;
            if (dr == MessageBox.Show("Bạn có chắc muốn xóa món ăn này?", "Thông bao", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                hdBH.TongTien = HDBanHangBUS.TongTienHienTaiHoaDon(hdBH.MaHD) - (cthd.SoLuong * Convert.ToInt32(lblDonGia.Text));
                if (CTHDBanHangBUS.XoaMonAn(hdBH.MaHD, cthd.MaMon))
                {
                    if (HDBanHangBUS.CapNhatTongTien(hdBH.MaHD, hdBH.TongTien))
                    {
                        LoadDSCTHDBanHang();
                    }
                    AddStatus(-1);
                }
                else
                    MessageBox.Show("Xóa món ăn thất bại", "Thông bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }
        private void dgvCTHDThanhToan_SelectionChanged(object sender, EventArgs e)
        {
            AddStatus(1);
            if (dgvCTHDThanhToan.SelectedRows.Count > 0)
            {
                DataRowView drv = (DataRowView)dgvCTHDThanhToan.SelectedRows[0].DataBoundItem;
                cthd = new CTHDBanHangDTO();
                cthd.MaHD = Convert.ToInt32(drv[0]);
                cthd.MaMon = drv[1].ToString();
                cthd.DonGia = Convert.ToInt32(drv[2]);
                cthd.SoLuong = Convert.ToInt32(drv[3]);
                cthd.GhiChu = drv[4].ToString();
            }
            else
                cthd = null;
            DuaThongTinVaoCTHD();
        }
        #endregion

        #region ThanhToan
        private void btnThanhToan_Click(object sender, EventArgs e)
        {

            if (CTHDBanHangBUS.SoLuongMonAnCTHD(hdBH.MaHD) > 0)
            {
                this.Hide();
                frmBanHang frmBH = new frmBanHang(hdBH);
                frmBH.MdiParent = this.MdiParent;
                frmBH.Dock = DockStyle.Fill;
                frmBH.Show();
            }
            else
                MessageBox.Show("Bạn cần ít nhất 1 món ăn để thanh toán!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion

        #region TimKiem
        private void LoadDSMonAnTimKiem(string strTK)
        {
            lsvTimKiem.Clear();
            lsvTimKiem.LargeImageList = imlMonAn;
            List<MonDTO> ls = MonBUS.LayDanhSachMon(strTK);
            for (int i = 0; i < ls.Count; i++)
            {
                ListViewItem lvi = new ListViewItem(ls[i].TenMon);
                lvi.SubItems.Add(ls[i].MaMon);
                lvi.SubItems.Add(ls[i].DonGia.ToString());
                lvi.SubItems.Add(ls[i].HinhAnh);
                if (File.Exists("image\\" + ls[i].HinhAnh))
                {
                    byte[] byteHA = File.ReadAllBytes("image\\" + ls[i].HinhAnh);
                    MemoryStream ms = new MemoryStream(byteHA);
                    Image img = Image.FromStream(ms);
                    imlMonAn.Images.Add(img);
                    lvi.ImageIndex = imlMonAn.Images.Count - 1;
                }
                lsvTimKiem.Items.Add(lvi);
            }
        }

        //Load lại danh sách tabMonAn khi txtTimKiem rỗng
        private void lsvTimKiem_SelectedIndexChanged(object sender, EventArgs e)
        {
            lsChonThayDoi(sender);
            BindingChiTietMon();
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            string strTK = txtTimKiem.Text;
            if (txtTimKiem.Text.Trim() == "")
            {
                //vì còn tabTimKiem nên phải bé hơn 1
                if (tabMonAn.TabCount <= 1)
                    LoadTabMonAn();
                tabMonAn.TabPages.Remove(tabTimKiem);

            }
        }
        //Tìm kiếm món ăn khi nhấn enter
        private void txtTimKiem_KeyPress(object sender, KeyPressEventArgs e)
        {
            string strTK = txtTimKiem.Text;
            if (e.KeyChar == (char)Keys.Enter)
            {
                RemoveTabPage();
                tabMonAn.TabPages.Insert(0, tabTimKiem);
                LoadDSMonAnTimKiem(strTK);
            }

        }
        #endregion
        #endregion

        #region Functions
        public void TaoHDBanHang()
        {
            btnThanhToan.Enabled = true;
            panel1.Enabled = true;
            btnTaoHD.Enabled = false;
            btnHuy.Enabled = true;
            hdBH = HDBanHangBUS.LayHDTrangThaiChuaThanhToan();
            if (hdBH == null)
            {
                hdBH = new HDBanHangDTO();
                SetHDBanHang();
                if (!HDBanHangBUS.TaoHDBanHang(hdBH))
                {
                    MessageBox.Show("Tạo hóa đơn thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
                LoadDSCTHDBanHang();
        }
        private void LoadTabMonAn()
        {
            List<LoaiMonDTO> lsLoai = LoaiMonBUS.LayDanhSachLoaiMon();
            for (int i = 0; i < lsLoai.Count; i++)
            {
                TabPage tabP = new TabPage();
                tabP.Text = lsLoai[i].TenLoaiMon;
                tabMonAn.Controls.Add(tabP);
                ListView lsvMon = new ListView();
                lsvMon.Dock = DockStyle.Fill;
                lsvMon.LargeImageList = imlMonAn;
                LoadDSMonAn(lsvMon, lsLoai[i].MaLoaiMon);
                lsvMon.ItemSelectionChanged += LsvMon_ItemSelectionChanged;
                tabP.Controls.Add(lsvMon);
            }
        }
        //Remove tabPage
        private void RemoveTabPage()
        {
            foreach (TabPage item in tabMonAn.TabPages)
            {
                tabMonAn.TabPages.Remove(item);
            }   
        }
        private void LoadDSMonAn(ListView lsvMonAn, string maLoai)
        {
            List<MonDTO> ls = MonBUS.LayDSMonAnTheoLoai(maLoai);
            for (int i = 0; i < ls.Count; i++)
            {
                ListViewItem lvi = new ListViewItem(ls[i].TenMon);
                lvi.SubItems.Add(ls[i].MaMon);
                lvi.SubItems.Add(ls[i].DonGia.ToString());
                lvi.SubItems.Add(ls[i].HinhAnh);
                if (File.Exists("image\\" + ls[i].HinhAnh))
                {
                    byte[] byteHA = File.ReadAllBytes("image\\" + ls[i].HinhAnh);
                    MemoryStream ms = new MemoryStream(byteHA);
                    Image img = Image.FromStream(ms);
                    imlMonAn.Images.Add(img);
                    lvi.ImageIndex = imlMonAn.Images.Count - 1;
                }
                lsvMonAn.Items.Add(lvi);
            }
        }
        private void LsvMon_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            lsChonThayDoi(sender);
            BindingChiTietMon();
        }
        private void lsChonThayDoi(object sender)
        {
            AddStatus(-1);
            ListView lsvChon = (ListView)sender;
            if (lsvChon.SelectedItems.Count > 0)
            {
                ListViewItem lvi = lsvChon.SelectedItems[0];
                monChon = new MonDTO();
                monChon.TenMon = lsvChon.SelectedItems[0].Text;
                monChon.DonGia = Convert.ToInt32(lsvChon.SelectedItems[0].SubItems[2].Text);
                cthd = new CTHDBanHangDTO();
                cthd.MaMon = lsvChon.SelectedItems[0].SubItems[1].Text;
            }
            else
                monChon = null;
        }
        private void LoadDSCTHDBanHang()
        {
            //Load Tên món ăn vào cột mã món ăn trong dgvCTHDThanhToan
            DataGridViewComboBoxColumn cboMon = (DataGridViewComboBoxColumn)dgvCTHDThanhToan.Columns["colMaMon"];
            cboMon.DataSource = MonBUS.LayDanhSachMon("");
            cboMon.DisplayMember = "TenMon";
            cboMon.ValueMember = "MaMon";


            //Load vào dữ liệu CTHD vào dgvCTHDThanhToan
            dgvCTHDThanhToan.DataSource = CTHDBanHangBUS.LayDSCTHDBanHang(hdBH.MaHD);
            dgvCTHDThanhToan.CurrentCell = null;
            AddStatus(-1);
        }
        private void SetHDBanHang()
        {
            frmMain frm = new frmMain();
            if (hdBH == null)
                hdBH = new HDBanHangDTO();
            hdBH.MaHD = HDBanHangBUS.LayMaHDLonNhat();
            hdBH.TenTaiKhoan = ((frmMain)this.ParentForm).getTenTK();
            hdBH.NgayLapHD = DateTime.Now;
            hdBH.TongTien = 0;
            hdBH.GhiChu = "";
            hdBH.TrangThai = 0;
            hdBH.TonTai = 1;
        }
        private void SetCTHDBanHang()
        {
            if (cthd == null)
                cthd = new CTHDBanHangDTO();
            cthd.MaHD = hdBH.MaHD;
            cthd.SoLuong = Convert.ToInt32(txtSoLuong.Text);
            cthd.DonGia = MonBUS.LayDonGiaMonAn(cthd.MaMon);
            cthd.GhiChu = (rtbGhiChu.Text == "") ? "" : rtbGhiChu.Text;

        }
        private void BindingChiTietMon()
        {
            if (monChon != null)
            {
                lblTenMon.Text = monChon.TenMon;
                lblDonGia.Text = monChon.DonGia.ToString("#,##0 VND");
            }
        }
        private void DuaThongTinVaoCTHD()
        {
            if (cthd != null)
            {
                lblTenMon.Text = MonBUS.LayTenMonAn(cthd.MaMon);
                lblDonGia.Text = cthd.DonGia.ToString();
                txtSoLuong.Text = cthd.SoLuong.ToString();
                rtbGhiChu.Text = cthd.GhiChu;
            }
            else
            {
                lblTenMon.Text = lblDonGia.Text = txtSoLuong.Text = rtbGhiChu.Text = string.Empty;
            }
        }
        public void AddStatus(int k)
        {
            //Một dòng trong dgvCTHDThanhToan được chọn
            if (k == 1)
            {
                bool chk = true;
                btnThem.Enabled = !chk;
                btnCapNhat.Enabled = chk;
                btnXoa.Enabled = chk;
            }
            //Không có dòng nào được chọn
            else
            {
                bool chk = false;
                btnThem.Enabled = !chk;
                btnCapNhat.Enabled = chk;
                btnXoa.Enabled = chk;
            }
        }
        #endregion

   
    }
}
