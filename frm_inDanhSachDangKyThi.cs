using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
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
    public partial class frm_inDanhSachDangKyThi : DevExpress.XtraEditors.XtraForm
    {
        public frm_inDanhSachDangKyThi()
        {
            InitializeComponent();
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
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frm_inDanhSachDangKyThi_Load(object sender, EventArgs e)
        {
            cbbChiNhanh.DataSource = Program.bds_LisSubscriber.DataSource;  // đưa bds_dsPhanManh vào combobox
            cbbChiNhanh.DisplayMember = "TENCN";
            cbbChiNhanh.ValueMember = "TENSERVER";
            cbbChiNhanh.SelectedIndex = Program.CBBSelectedIndexChiNhanh;
            Program.serverName = cbbChiNhanh.SelectedValue.ToString();
            if (Program.groupNV.Equals("TRUONG"))
            {
                cbbChiNhanh.Enabled = true;
            }
           

        }

        private void dateEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            XtraReport1 rp = new XtraReport1(tungay.Text, denngay.Text);
            rp.lb_tieude.Text = "DANH SÁCH ĐĂNG KÝ THI TRẮC NGHIỆM " + this.cbbChiNhanh.Text + " TỪ NGÀY " + tungay.Text + " ĐẾN NGÀY " + denngay.Text;
            ReportPrintTool report = new ReportPrintTool(rp);
            report.ShowPreviewDialog();

        }
        private void denngay_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}