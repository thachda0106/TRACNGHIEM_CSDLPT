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
    public partial class FromKhoa : DevExpress.XtraEditors.XtraForm
    {
        int vitri =0 ;
        public FromKhoa()
        {
            InitializeComponent();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = kHOABindingSource.Position;
            makhoa_id.Enabled = tenkhoa_id.Enabled = true;
            sua_id.Enabled = xoa_id.Enabled = reset_id.Enabled = thoat_id.Enabled = false;
            phuchoi_id.Enabled = ghi_id.Enabled = true;

            // them
            kHOABindingSource.AddNew();
            makhoa_id.Text = tenkhoa_id.Text = "";
            coso_id.Text = ((DataRowView)kHOABindingSource[0])["MACS"].ToString();
        }

        private void FromKhoa_Load(object sender, EventArgs e)
        {
            this.tRACNGHIEMDataSet.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'tRACNGHIEMDataSet1.LOP' table. You can move, or remove it, as needed.
            this.lOPTableAdapter.Connection.ConnectionString = Program.StrConn;
            this.lOPTableAdapter.Fill(this.tRACNGHIEMDataSet1.LOP);
            // TODO: This line of code loads data into the 'tRACNGHIEMDataSet1.GIAOVIEN' table. You can move, or remove it, as needed.
            this.gIAOVIENTableAdapter1.Connection.ConnectionString = Program.StrConn;
            this.gIAOVIENTableAdapter1.Fill(this.tRACNGHIEMDataSet1.GIAOVIEN);
            // TODO: This line of code loads data into the 'tRACNGHIEMDataSet1.KHOA' table. You can move, or remove it, as needed.
            this.kHOATableAdapter.Connection.ConnectionString = Program.StrConn;
            this.kHOATableAdapter.Fill(this.tRACNGHIEMDataSet1.KHOA);

           
            cbbChiNhanh.DataSource = Program.bds_LisSubscriber.DataSource;  // đưa bds_dsPhanManh vào combobox
            cbbChiNhanh.DisplayMember = "TENCN";
            cbbChiNhanh.ValueMember = "TENSERVER";
            cbbChiNhanh.SelectedIndex = Program.CBBSelectedIndexChiNhanh;
            Program.serverName = cbbChiNhanh.Text;
            if (Program.groupNV.Equals("TRUONG"))
            {
                cbbChiNhanh.Enabled = true;
                them_id.Enabled = false;
                xoa_id.Enabled = false;
                sua_id.Enabled = false;
                ghi_id.Enabled = false;
                phuchoi_id.Enabled = false;
                // tat nhung fields textbox vs nuts dang ky enable =fasle
            

            }else if(Program.groupNV.Equals("GIANGVIEN") )
            {
                them_id.Enabled = false;
                xoa_id.Enabled = false;
                sua_id.Enabled = false;
                ghi_id.Enabled = false;
                phuchoi_id.Enabled = false;
            }


        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void tENKHTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void tENKHLabel_Click(object sender, EventArgs e)
        {

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

                this.kHOATableAdapter.Connection.ConnectionString = Program.StrConn;
                this.kHOATableAdapter.Fill(this.tRACNGHIEMDataSet1.KHOA);

            }
        }

        private void reset_id_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.kHOATableAdapter.Fill(this.tRACNGHIEMDataSet1.KHOA);
        }

        private void thoat_id_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void phuchoi_id_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = kHOABindingSource.Position;
            kHOABindingSource.CancelEdit();
            this.kHOATableAdapter.Fill(this.tRACNGHIEMDataSet1.KHOA);
            kHOABindingSource.Position = vitri;
            them_id.Enabled = sua_id.Enabled = xoa_id.Enabled = reset_id.Enabled = true;
            phuchoi_id.Enabled = ghi_id.Enabled = false;
            this.makhoa_id.Enabled = false;
            this.tenkhoa_id.Enabled = false;


        }

        private void xoa_id_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = this.kHOABindingSource.Position;
            if(lOPBindingSource.Count > 0)
            {
                MessageBox.Show("khoa này đã có lớp! Không thể xóa!");
                return;
            }
            if (gIAOVIENBindingSource.Count > 0)
            {
                MessageBox.Show("khoa này đã có giáo viên! Không thể xóa!");
                return;
            }

            DialogResult dr = MessageBox.Show("Bạn có chắc muốn xóa khoa này?", "", MessageBoxButtons.YesNo);
            if(dr == DialogResult.Yes)
            {
                try
                {
                    kHOABindingSource.RemoveCurrent();
                    this.kHOATableAdapter.Update(this.tRACNGHIEMDataSet1.KHOA);
                }catch(Exception ex )
                {
                    MessageBox.Show("Lỗi xóa khoa, " + ex.Message,"",MessageBoxButtons.OK);
                    this.kHOATableAdapter.Update(this.tRACNGHIEMDataSet1.KHOA);
                    kHOABindingSource.Position = vitri;
                    return;
                }
            }
            if (kHOABindingSource.Count == 0) xoa_id.Enabled = false;
        }

        private void sua_id_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = kHOABindingSource.Position;
            makhoa_id.Enabled = tenkhoa_id.Enabled = true;
            them_id.Enabled = xoa_id.Enabled = reset_id.Enabled = thoat_id.Enabled = false;
            phuchoi_id.Enabled = ghi_id.Enabled = true;
            // them
        }

        private void ghi_id_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // makhoa, ten khoa rong


            // luu
            kHOABindingSource.EndEdit();
            kHOABindingSource.ResetCurrentItem();
            try
            {
                kHOATableAdapter.Update(tRACNGHIEMDataSet1.KHOA);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi ghi khoa!" + ex.Message, "", MessageBoxButtons.OK);
            }

            them_id.Enabled = true;
            xoa_id.Enabled = true;
            sua_id.Enabled = true;
            ghi_id.Enabled = false;
            thoat_id.Enabled = true;
            reset_id.Enabled = true;
            phuchoi_id.Enabled = false;
            makhoa_id.Enabled = tenkhoa_id.Enabled = false;

        }
    }
}