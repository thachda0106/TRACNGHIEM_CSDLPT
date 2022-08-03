using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSDLPT_TRACNGHIEM
{
    public partial class frm_Lop_SV : DevExpress.XtraEditors.XtraForm
    {
        
        int vitri = 0;
        public frm_Lop_SV()
        {
            InitializeComponent();
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            // luu
            sINHVIENBindingSource.EndEdit();
            sINHVIENBindingSource.ResetCurrentItem();
            try
            {
                sINHVIENTableAdapter.Update(tRACNGHIEMDataSet1.SINHVIEN);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi SINH VIÊN!" + ex.Message, "", MessageBoxButtons.OK);
            }

            mASVTextEdit.Enabled = tENTextEdit.Enabled = hOTextEdit.Enabled = nGAYSINHDateEdit.Enabled = dIACHITextEdit.Enabled = false;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnPhucHoi.Enabled = btnThoat.Enabled = true;
            btnGhi.Enabled = false;

        }

        private void cbbChiNhanh_SelectedIndexChanged(object sender, EventArgs e)
        {
             if (cbbChiNhanh.SelectedValue.ToString() == "System.Data.DataRowView")
            {
                return;
            }
            Program.serverName = cbbChiNhanh.SelectedValue.ToString();
            if (cbbChiNhanh.SelectedIndex != Program.CBBSelectedIndexChiNhanh)
            {
                Program.TestLogin = Program.remoteLogin;
                Program.TestPassword = Program.remotePassword;
            }
            else
            {
                Program.TestLogin = Program.loginDN;
                Program.TestPassword = Program.passwordDN;
            }

            if (Program.connection() == 0)
            {
                MessageBox.Show("Lỗi Kết nối tới chi nhánh!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.sINHVIENTableAdapter.Fill(this.tRACNGHIEMDataSet1.SINHVIEN);
                this.lOPTableAdapter.Fill(this.tRACNGHIEMDataSet1.LOP);

            }
        }

        private void frm_Lop_SV_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tRACNGHIEMDataSet1.BANGDIEM' table. You can move, or remove it, as needed.
            this.bANGDIEMTableAdapter.Fill(this.tRACNGHIEMDataSet1.BANGDIEM);
            this.tRACNGHIEMDataSet1.EnforceConstraints = false;

            // TODO: This line of code loads data into the 'tRACNGHIEMDataSet1.SINHVIEN' table. You can move, or remove it, as needed.
            this.sINHVIENTableAdapter.Connection.ConnectionString = Program.StrConn;
            this.sINHVIENTableAdapter.Fill(this.tRACNGHIEMDataSet1.SINHVIEN);
            // TODO: This line of code loads data into the 'tRACNGHIEMDataSet1.LOP' table. You can move, or remove it, as needed.
            this.lOPTableAdapter.Connection.ConnectionString = Program.StrConn;
            this.lOPTableAdapter.Fill(this.tRACNGHIEMDataSet1.LOP);

            cbbChiNhanh.DataSource = Program.bds_LisSubscriber.DataSource;  // đưa bds_dsPhanManh vào combobox
            cbbChiNhanh.DisplayMember = "TENCN";
            cbbChiNhanh.ValueMember = "TENSERVER";
            cbbChiNhanh.SelectedIndex = Program.CBBSelectedIndexChiNhanh;
            Program.serverName = cbbChiNhanh.SelectedValue.ToString();
            if (Program.groupNV.Equals("TRUONG"))
            {
                cbbChiNhanh.Enabled = true;
                btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = false;
            }
            else if (Program.groupNV.Equals("GIANGVIEN"))
            {
                cbbChiNhanh.Enabled = false;
                btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = false;
            }

        }

        private void panelControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.sINHVIENTableAdapter.Fill(this.tRACNGHIEMDataSet1.SINHVIEN);
            this.lOPTableAdapter.Fill(this.tRACNGHIEMDataSet1.LOP);
        }

        private void btnPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = sINHVIENBindingSource.Position;
            sINHVIENBindingSource.CancelEdit();
            this.sINHVIENTableAdapter.Fill(this.tRACNGHIEMDataSet1.SINHVIEN);
            sINHVIENBindingSource.Position = vitri;
            btnXoa.Enabled = btnSua.Enabled = btnRefresh.Enabled = btnThem.Enabled = true;
            btnGhi.Enabled = btnPhucHoi.Enabled = false;
            mASVTextEdit.Enabled = tENTextEdit.Enabled = hOTextEdit.Enabled = nGAYSINHDateEdit.Enabled = dIACHITextEdit.Enabled = false;
        }

        private void gridControl2_Click(object sender, EventArgs e)
        {

        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = this.sINHVIENBindingSource.Position;
            if (bANGDIEMBindingSource.Count > 0)
            {
                MessageBox.Show("sinh viên này đã thi môn học! Không thể xóa!");
                return;
            }


            DialogResult dr = MessageBox.Show("Bạn có chắc muốn xóa sinh viên này?", "", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                try
                {
                    sINHVIENBindingSource.RemoveCurrent();
                    this.sINHVIENTableAdapter.Update(this.tRACNGHIEMDataSet1.SINHVIEN);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa sinh viên, " + ex.Message, "", MessageBoxButtons.OK);
                    this.sINHVIENTableAdapter.Update(this.tRACNGHIEMDataSet1.SINHVIEN);
                    sINHVIENBindingSource.Position = vitri;
                    return;
                }
            }
            if (sINHVIENBindingSource.Count == 0) btnXoa.Enabled = false;
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = sINHVIENBindingSource.Position;
            mASVTextEdit.Enabled = tENTextEdit.Enabled = hOTextEdit.Enabled = nGAYSINHDateEdit.Enabled = dIACHITextEdit.Enabled = true;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnPhucHoi.Enabled = btnRefresh.Enabled = btnThoat.Enabled = false;
            btnPhucHoi.Enabled = btnGhi.Enabled = true;

            // them
            sINHVIENBindingSource.AddNew();
            mASVTextEdit.Text = tENTextEdit.Text = hOTextEdit.Text = nGAYSINHDateEdit.Text = dIACHITextEdit.Text = "";
            try
            {
                mALOPTextEdit.Text = ((DataRowView)sINHVIENBindingSource[0])["MALOP"].ToString();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = sINHVIENBindingSource.Position;
            mASVTextEdit.Enabled = tENTextEdit.Enabled = hOTextEdit.Enabled = nGAYSINHDateEdit.Enabled = dIACHITextEdit.Enabled = true;
            btnSua.Enabled = btnThem.Enabled = btnXoa.Enabled = btnRefresh.Enabled = btnThoat.Enabled = false;
            btnPhucHoi.Enabled = btnGhi.Enabled = true;
            // them
        }
    }
}