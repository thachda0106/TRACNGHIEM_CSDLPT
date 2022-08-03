using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
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

namespace CSDLPT_TRACNGHIEM
{
    public partial class frmXemKQThi : DevExpress.XtraEditors.XtraForm
    {
        public frmXemKQThi()
        {
            InitializeComponent();
        }

        private void frmXemKQThi_Load(object sender, EventArgs e)
        {
            this.tRACNGHIEMDataSet1.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'tRACNGHIEMDataSet1.MONHOC' table. You can move, or remove it, as needed.
  /*          this.mONHOCTableAdapter.Connection.ConnectionString = Program.StrConn;*/
            this.mONHOCTableAdapter.Fill(this.tRACNGHIEMDataSet1.MONHOC);
            // TODO: This line of code loads data into the 'tRACNGHIEMDataSet1.BANGDIEM' table. You can move, or remove it, as needed.
/*            this.bANGDIEMTableAdapter.Connection.ConnectionString = Program.StrConn;*/
            this.bANGDIEMTableAdapter.Fill(this.tRACNGHIEMDataSet1.BANGDIEM);
            // TODO: This line of code loads data into the 'tRACNGHIEMDataSet1.BAITHI' table. You can move, or remove it, as needed.
/*            this.bAITHITableAdapter.Connection.ConnectionString = Program.StrConn;*/
            this.bAITHITableAdapter.Fill(this.tRACNGHIEMDataSet1.BAITHI);
            this.textEdit1.Text = Program.MaNV;

            var LanThi = new BindingList<KeyValuePair<string, string>>();
            LanThi.Add(new KeyValuePair<string, string>("1", "1"));
            LanThi.Add(new KeyValuePair<string, string>("2", "2"));
            this.lANComboBox.DataSource = LanThi;
            this.lANComboBox.ValueMember = "Key";
            this.lANComboBox.DisplayMember = "Value";
            this.lANComboBox.SelectedIndex = 0;

        }

        private void panelControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


            String maSV = Program.MaNV,
                    maMH = this.mAMHComboBoxEdit.Text.ToString(),
                    lanThi = this.lANComboBox.Text.ToString();
            String sql = "exec [dbo].[SP_THONGTINKQTHISV] '" + maSV + "', " + "'" + maMH + "', " + lanThi;
            SqlDataReader reader =  Program.ExecuteSqlReader(sql);
            if (reader == null) return;
            reader.Read();
            float diem = 0;
            try
            {
                diem = (float)reader.GetDouble(0);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            DateTime ngayThi = reader.GetDateTime(1);
            String tenMon = reader.GetString(2);
            // tenmon mamon ngaythi lanthi diem
            rpt_inbaithi_XtraReport rpKQT = new rpt_inbaithi_XtraReport(maSV, maMH, lanThi);
            rpKQT.lb_diem.Text = diem + "";
            rpKQT.lb_MSV.Text = maSV;
            rpKQT.lb_Hoten.Text = Program.hoTenNV;
            rpKQT.lb_LanThi.Text = lanThi;
            rpKQT.lb_MaMH.Text = maMH;
            rpKQT.lb_NgayThi.Text = ngayThi.ToString("hh:mm dd-MM-yyyy");
            rpKQT.label_TieuDe.Text = "CHI TIẾT BÀI THI MÔN " + tenMon;


            ReportPrintTool report = new ReportPrintTool(rpKQT);
            report.ShowPreviewDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}