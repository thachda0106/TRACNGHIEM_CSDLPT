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
    public partial class frmGiangVienDangKy : DevExpress.XtraEditors.XtraForm
    {
        public frmGiangVienDangKy()
        {
            InitializeComponent();
        }

        private void gIAOVIEN_DANGKYBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.gIAOVIEN_DANGKYBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.tRACNGHIEMDataSet);

        }

        private void frmGiangVienDangKy_Load(object sender, EventArgs e)
        {
            this.tRACNGHIEMDataSet.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'tRACNGHIEMDataSet.GIAOVIEN_DANGKY' table. You can move, or remove it, as needed.
            this.gIAOVIEN_DANGKYTableAdapter.Connection.ConnectionString = Program.StrConn;
            
            this.gIAOVIEN_DANGKYTableAdapter.Fill(this.tRACNGHIEMDataSet.GIAOVIEN_DANGKY);
            trinhdo_id.SelectedIndex = 0;
            date_id.DateTime = DateTime.Now;
            lan_id.Text = "1";


            cbbChiNhanh.DataSource = Program.bds_LisSubscriber.DataSource;  // đưa bds_dsPhanManh vào combobox
            cbbChiNhanh.DisplayMember = "TENCN";
            cbbChiNhanh.ValueMember = "TENSERVER";
            cbbChiNhanh.SelectedIndex = Program.CBBSelectedIndexChiNhanh;
            Program.serverName = cbbChiNhanh.SelectedValue.ToString();
            if (Program.groupNV.Equals("TRUONG"))
            {
                cbbChiNhanh.Enabled = true;
                // tat nhung fields textbox vs nuts dang ky enable =fasle
                mamh_id.Enabled = false;
                lop_id.Enabled = false;
                gio_id.Enabled = false;
                phut_id.Enabled = false;
                date_id.Enabled = false;
                trinhdo_id.Enabled = false;
                thoigian_id.Enabled = false;
                lan_id.Enabled = false;
                socauthi_id.Enabled = false;
                button1.Enabled = false;

            }else if (Program.groupNV.Equals("GIANGVIEN"))
            {
                cbbChiNhanh.Enabled = false;
                // tat nhung fields textbox vs nuts dang ky enable =fasle
                mamh_id.Enabled = false;
                lop_id.Enabled = false;
                gio_id.Enabled = false;
                phut_id.Enabled = false;
                date_id.Enabled = false;
                trinhdo_id.Enabled = false;
                thoigian_id.Enabled = false;
                lan_id.Enabled = false;
                socauthi_id.Enabled = false;
                button1.Enabled = false;
            }
            else // coso dang nhap vao
            {
                cbbChiNhanh.Enabled = false;
                mamh_id.Enabled = true;
                lop_id.Enabled = true;
                gio_id.Enabled = true;
                phut_id.Enabled = true;
                date_id.Enabled = true;
                trinhdo_id.Enabled = true;
                thoigian_id.Enabled = true;
                lan_id.Enabled = true;
                socauthi_id.Enabled = true;
                // tat nhung fields textbox vs nuts dang ky enable = true
            }

        }

        private void tRINHDOTextEdit_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void tHOIGIANSpinEdit_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void lANSpinEdit_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void mAMHComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        
        private void button1_Click(object sender, EventArgs e)
        {

            if (mamh_id.Text == "")
            {
                MessageBox.Show("Không được để trống MMH");
                /*String sql = 'exec sps_DS '
                Program.ExecuteSqlNonQuery(sql);*/
            }
            else if (lop_id.Text == "")
            {
                MessageBox.Show("Không được để trống LOP");
                /*String sql = 'exec sps_DS '
                Program.ExecuteSqlNonQuery(sql);*/
            }
            else
            {

            DateTime day = date_id.DateTime;
            var yyyy_mm_dd = day.ToString("yyyy-MM-dd");
                String sql = "EXEC SP_GIANGVIEN_DANGKY '" + Program.MaNV + "'";
     
            sql += "," + "'" + mamh_id.Text + "'" + "," + "'" + lop_id.Text + "'" + "," + "'" + trinhdo_id.Text + "'" + "," + "'" + yyyy_mm_dd + "     " + gio_id.Text +
                ":" + phut_id.Text + "'" + "," + lan_id.Text + "," + socauthi_id.Text + "," + thoigian_id.Text;

                if (Program.ExecuteSqlNonQuery(sql) == 0)
                {
                    MessageBox.Show("Đăng Ký Môn học thi trắc nhiệm thành công");
                    this.gIAOVIEN_DANGKYTableAdapter.Fill(this.tRACNGHIEMDataSet.GIAOVIEN_DANGKY);
                }
       
            }
        }

        private void panelControl1_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void timeEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void sOCAUTHISpinEdit_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void nGAYTHIDateEdit_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void date_id_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void spinEdit2_EditValueChanged(object sender, EventArgs e)
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

                this.gIAOVIEN_DANGKYTableAdapter.Connection.ConnectionString = Program.StrConn;
                this.gIAOVIEN_DANGKYTableAdapter.Fill(this.tRACNGHIEMDataSet.GIAOVIEN_DANGKY);

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
    }
}