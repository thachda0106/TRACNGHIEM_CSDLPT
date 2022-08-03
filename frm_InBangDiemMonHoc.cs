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
    public partial class frm_InBangDiemMonHoc : DevExpress.XtraEditors.XtraForm
    {
        public frm_InBangDiemMonHoc()
        {
            InitializeComponent();
        }

        private void mONHOCBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.mONHOCBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.tRACNGHIEMDataSet);

        }

        private void frm_InBangDiemMonHoc_Load(object sender, EventArgs e)
        {
            //
            var LanThi = new BindingList<KeyValuePair<string, string>>();
            LanThi.Add(new KeyValuePair<string, string>("1", "1"));
            LanThi.Add(new KeyValuePair<string, string>("2", "2"));
            this.comboBox1.DataSource = LanThi;
            this.comboBox1.ValueMember = "Key";
            this.comboBox1.DisplayMember = "Value";
            this.comboBox1.SelectedIndex = 0;
            //
            DataTable dt_DSMH = new DataTable();
            Program.connection();
            SqlDataAdapter myAdapter = new SqlDataAdapter("select DISTINCT MH.TENMH, MH.MAMH from GIAOVIEN_DANGKY AS GV_DK, MONHOC as MH WHERE MH.MAMH = GV_DK.MAMH", Program.conn);
            try {
                myAdapter.Fill(dt_DSMH);
            }catch(Exception ex)
            {
                MessageBox.Show("Danh sách môn học đăng ký thi trắc nghiệm không có!", "", MessageBoxButtons.OK);
                this.button1.Enabled = false;
                this.txt_MaLop.Enabled = false;
                this.txt_MaMh.Enabled = false;
                comboBox1.Enabled = false;
                return;
            }
            cbb_tenMH.DataSource = dt_DSMH;
            cbb_tenMH.DisplayMember = "TENMH";
            cbb_tenMH.ValueMember = "MAMH";
            if (dt_DSMH.Rows.Count == 0)
            {
                MessageBox.Show("Không có môn học nào đăng ký thi trắc nghiệm!");
                return;
            }
            else
            {
                cbb_tenMH.SelectedIndex = 0;
                txt_MaMh.Text = cbb_tenMH.SelectedValue.ToString();
            }

            //

            DataTable dt_DSLOP = new DataTable();
            Program.connection();
            SqlDataAdapter myAdapter2 = new SqlDataAdapter("select DISTINCT LOP.TENLOP, LOP.MALOP from GIAOVIEN_DANGKY AS GV_DK, LOP WHERE LOP.MALOP = GV_DK.MALOP", Program.conn);
            myAdapter2.Fill(dt_DSLOP);  //  fill và;o table 
            cbb_TenLOP.DataSource = dt_DSLOP;
            cbb_TenLOP.DisplayMember = "TENLOP";
            cbb_TenLOP.ValueMember = "MALOP";
            cbb_TenLOP.SelectedIndex = 0;
            txt_MaLop.Text = cbb_TenLOP.SelectedValue.ToString();
        }

        private void cbb_tenMH_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_MaMh.Text = cbb_tenMH.SelectedValue.ToString();
        }

        private void cbb_TenLOP_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_MaLop.Text = cbb_TenLOP.SelectedValue.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            xrpt_inBangDiemMonHOc rp = new xrpt_inBangDiemMonHOc(txt_MaLop.Text.Trim(), txt_MaMh.Text.Trim(), comboBox1.SelectedValue.ToString());
            rp.lb_tieuDe.Text = "DANH SÁCH BẢNG ĐIỂM MÔN HỌC " + cbb_tenMH.Text.ToString().ToUpper();
            rp.lb_MaMH.Text = txt_MaMh.Text;
            rp.lb_LanThi.Text = comboBox1.SelectedValue.ToString();
            rp.lb_MaLop.Text = txt_MaLop.Text;
            ReportPrintTool report = new ReportPrintTool(rp);
            report.ShowPreviewDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}