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
using System.IO;

namespace QLCuaHangThucAnNhanh
{
    public partial class frmMonAn : Form
    {
        private static frmMonAn _Instance = null;
        private frmLoaiMonAn mon = null;
        private string _tenTK;
        public frmMonAn()
        {
            InitializeComponent();
        }
        public frmMonAn(string tenTK) : this()
        {
            this._tenTK = tenTK;
        }
        public static frmMonAn Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new frmMonAn();
                }
                return _Instance;
            }
        }
        
        private void frmMonAn_FormClosed(object sender, FormClosedEventArgs e)
        {
            _Instance = null;
        }

        private void frmMonAn_Load(object sender, EventArgs e)
        {
            txtMaMon.Enabled = false;
            chkTrangThai.Checked = true;
            dgvDSMon.AutoGenerateColumns = false;
            DataGridViewComboBoxColumn dgvcolLoaiMon = (DataGridViewComboBoxColumn)dgvDSMon.Columns["colMaLoaiMon"];
            List<LoaiMonDTO> dtLoaiMon = LoaiMonBUS.LayDanhSachLoaiMon();
            dgvcolLoaiMon.DataSource = dtLoaiMon;
            dgvcolLoaiMon.DisplayMember = "TenLoaiMon";
            dgvcolLoaiMon.ValueMember = "MaLoaiMon";

            cboLoaiMon.DataSource = dtLoaiMon;
            cboLoaiMon.DisplayMember = "TenLoaiMon";
            cboLoaiMon.ValueMember = "MaLoaiMon";
            LoadDSMon();
            LamMoi();
            XoaForm(true);
        }
        #region Events
        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            ((frmMain)(this.ParentForm)).Controls["pnlDashboard"].Visible = true;
            this.Close();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LamMoi();
            XoaForm(true);
        }

        private void dgvDSMon_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDSMon.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvDSMon.CurrentRow;
                txtMaMon.Enabled = false;
                txtMaMon.Text = row.Cells["colMaMon"].Value.ToString();
                cboLoaiMon.SelectedValue = row.Cells["colMaLoaiMon"].Value;
                txtTenMon.Text = row.Cells["colTenMon"].Value.ToString();
                txtDonGia.Text = row.Cells["colDonGia"].Value.ToString();
                picHinh.Image = (Bitmap)row.Cells["colHinhAnhMon"].FormattedValue;
                chkTrangThai.Checked = Convert.ToBoolean(row.Cells["colTrangThai"].Value);
                LamMoi(false);
                if (chkMAConSuDung.Checked == true)
                {
                    btnCapNhat.Hide();
                    btnThem.Hide();
                    btnXoa.Hide();
                    btnLamMoi.Hide();
                }
            }

        } 

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (mon == null)
            {
                if (txtTenMon.Text == "" || txtDonGia.Text == "" || cboLoaiMon.SelectedValue.ToString() == "" || chkTrangThai.Checked == false || picHinh.Image == null)
                {
                    MessageBox.Show("Bạn chưa nhập đầy đủ hoặc bỏ trống thông tin món ăn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    MonDTO mon = new MonDTO();
                    mon.MaMon = txtMaMon.Text;
                    mon.MaLoaiMon = cboLoaiMon.SelectedValue.ToString();
                    mon.TenMon = txtTenMon.Text;
                    if (txtDonGia.Text == "")
                    {
                        mon.DonGia = 0;
                    }
                    else
                    { mon.DonGia = Convert.ToInt32(txtDonGia.Text); }

                    mon.TrangThai = chkTrangThai.Checked;
                    if (openFileDialog1.FileName != "") // Kiểm tra chọn file chưa
                    {
                        string fileName = txtMaMon.Text + "_" + DateTime.Now.ToFileTime();
                        string extension = Path.GetExtension(openFileDialog1.FileName);
                        mon.HinhAnh = fileName + extension;
                    }

                    if (MonBUS.ThemMon(mon))
                    {
                        File.Copy(openFileDialog1.FileName, "image\\" + mon.HinhAnh, true);
                        //MessageBox.Show("Thêm món ăn mới thành công","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.None);
                        LamMoi();
                        LoadDSMon();
                        XoaForm(true);
                    }
                    else
                    {
                        MessageBox.Show("Thêm món ăn thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        mon = null;
                    }
                }
                
            }     
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (txtTenMon.Text == "" || txtDonGia.Text == "" || cboLoaiMon.SelectedValue.ToString() == "" || chkTrangThai.Checked == false )
            {
                MessageBox.Show("Bạn chưa nhập đầy đủ hoặc bỏ trống thông tin món ăn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                MonDTO mon = new MonDTO();
                mon.MaMon = txtMaMon.Text;
                mon.MaLoaiMon = cboLoaiMon.SelectedValue.ToString();
                mon.TenMon = txtTenMon.Text;
                mon.DonGia = Convert.ToInt32(txtDonGia.Text);
                if(openFileDialog1.FileName != "")
                {
                    string fileName = txtMaMon.Text + '_' + DateTime.Now.ToFileTime() +  ".jpg";
                    mon.HinhAnh = fileName;
                    File.Copy(openFileDialog1.FileName, "image\\" + fileName, true);
                }
                else
                {
                    string fileName = MonBUS.LayTenHinhHienTai(txtMaMon.Text);
                    mon.HinhAnh = fileName;
                }
                mon.TrangThai = chkTrangThai.Checked;
                if (MonBUS.SuaMon(mon))
                {
                    //MessageBox.Show("Cập nhật món ăn thành công","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.None);
                    LamMoi();
                    LoadDSMon();
                    XoaForm(true);
                }
                else
                {
                    MessageBox.Show("Cập nhật món ăn thất bại","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    mon = null;
                }
            }  
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtTenMon.Text == "" || txtDonGia.Text == "" || cboLoaiMon.SelectedValue.ToString() == "" || chkTrangThai.Checked == false || picHinh.Image == null)
            {
                MessageBox.Show("Bạn chưa nhập đầy đủ hoặc bỏ trống thông tin món ăn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                if (DialogResult.Yes == MessageBox.Show("Bạn có chắc chắn muốn xóa món ăn này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    string maMon = txtMaMon.Text;
                    if (MonBUS.XoaMon(maMon))
                    {
                        //MessageBox.Show("Xóa món ăn thành công","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.None);
                        LamMoi();
                        LoadDSMon();
                        XoaForm(true);
                    }
                    else
                    {
                        MessageBox.Show("Xóa món ăn thất bại","Thong báo",MessageBoxButtons.OK,MessageBoxIcon.None);

                    }
                }
            }
             
        }

        private void txtTimKiemMon_TextChanged(object sender, EventArgs e)
        {
            LoadDSMon(txtTimKiemMon.Text);
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            picHinh.ImageLocation = openFileDialog1.FileName;
        }

        private void picHinh_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void dgvDSMon_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvDSMon.Columns[e.ColumnIndex].Name == "colHinhAnhMon")
            {
                if (File.Exists("image\\" + e.Value.ToString()))
                {
                    e.Value = new Bitmap("image\\" + e.Value.ToString());
                }
                else
                {
                    e.Value = new Bitmap("imgMonAn\\San_pham1.jpg");
                }
                e.FormattingApplied = true;
            }
        }

        private void txtDonGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void chkMAConSuDung_CheckedChanged(object sender, EventArgs e)
        {
            LoadDSMon();
            OnlyReadResetStatus();
        }

        private void btnKhoiPhuc_Click(object sender, EventArgs e)
        {
            if (chkMAConSuDung.Checked)
            {
                try
                {
                    MonDTO mon = new MonDTO();
                    mon.MaMon = txtMaMon.Text;
                    mon.MaLoaiMon = cboLoaiMon.SelectedValue.ToString();
                    mon.TenMon = txtTenMon.Text;
                    mon.DonGia = Convert.ToInt32(txtDonGia.Text);
                    mon.TrangThai = true;
                    if (MonBUS.KhoiPhuc(mon))
                    {
                        //MessageBox.Show("Khôi phục món ăn thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.None);
                        LamMoi();
                        LoadDSMon();
                    }
                }
                catch
                {
                    MessageBox.Show("Khôi phục món ăn thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    mon = null;
                }
            }
            
        }

        private void btnAddLM_Click(object sender, EventArgs e)
        {
            frmLoaiMonAn frm = new frmLoaiMonAn(_tenTK, 1);
            frm.MdiParent = this.MdiParent;
            frm.Dock = DockStyle.Fill;
            frm.Show();
            this.Hide();
        }
        #endregion

        #region Functions
        private void LoadDSMon(string timKiem = "", bool trangThai = true)
        {
            if (chkMAConSuDung.Checked == false)
            {
                List<MonDTO> lstMon = MonBUS.LayDanhSachMon(timKiem, trangThai);
                dgvDSMon.DataSource = lstMon;
            }
            else
            {
                dgvDSMon.DataSource = MonBUS.LayDSMonAnBiXoa();
                dgvDSMon.CurrentCell = null;
                XoaForm(false);
                btnCapNhat.Hide();
                btnThem.Hide();
                btnXoa.Hide();
                btnLamMoi.Hide();
                btnKhoiPhuc.Show();
                if (dgvDSMon.Rows.Count > 0)
                {
                    btnKhoiPhuc.Enabled = true;
                }
                else
                {
                    btnKhoiPhuc.Enabled = false;
                }
                chkTrangThai.Checked = false;
                picHinh.Image = null;
            }
            
        }

        private void LamMoi(bool TrangThai = true)
        {
            if (TrangThai == true)
            {
                btnCapNhat.Visible = !TrangThai;
                btnThem.Visible = TrangThai;
                btnKhoiPhuc.Visible = !TrangThai;
                btnXoa.Visible = TrangThai;
                btnXoa.Enabled = !TrangThai;
            }
            else
            {
                btnCapNhat.Visible = !TrangThai;
                btnThem.Visible = TrangThai;
                btnKhoiPhuc.Visible = !TrangThai;
                btnXoa.Visible = !TrangThai;
                btnXoa.Enabled = !TrangThai;
            }
           
        }

        void XoaForm(bool t)
        {
            if (t)
            {
                txtMaMon.Text = MonBUS.LayMaMonLonNhat();
                txtDonGia.Text = txtTenMon.Text = string.Empty;
                cboLoaiMon.SelectedValue = -1;
                picHinh.Image = null;
            }
            else
            {
                txtMaMon.Text= txtDonGia.Text = txtTenMon.Text = string.Empty;
                cboLoaiMon.SelectedValue = -1;
                picHinh.Image = null;
            }
        }

        void OnlyReadResetStatus()
        {
            if (chkMAConSuDung.Checked == true)
            {
                txtTenMon.Enabled = txtDonGia.Enabled = cboLoaiMon.Enabled = chkTrangThai.Enabled = picHinh.Enabled = false;
            }
            else
            {
                txtTenMon.Enabled = txtDonGia.Enabled = cboLoaiMon.Enabled = chkTrangThai.Enabled = picHinh.Enabled = true;
                LoadDSMon();
                btnCapNhat.Show();
                btnThem.Hide();
                btnXoa.Show();
                btnXoa.Enabled = true;
                btnLamMoi.Show();
                btnKhoiPhuc.Hide();
            }
        }


        #endregion

        
    }
}
