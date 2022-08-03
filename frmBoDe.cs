using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
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
    public partial class frmBoDe : DevExpress.XtraEditors.XtraForm
    {
        int vitri = 0;
        public frmBoDe()
        {
            InitializeComponent();
        }

        private void frmBoDe_Load(object sender, EventArgs e)
        {
            this.tRACNGHIEMDataSet1.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'tRACNGHIEMDataSet1.BAITHI' table. You can move, or remove it, as needed.
            this.bAITHITableAdapter.Connection.ConnectionString = Program.StrConn;
            this.bAITHITableAdapter.Fill(this.tRACNGHIEMDataSet1.BAITHI);
            // TODO: This line of code loads data into the 'tRACNGHIEMDataSet1.BODE' table. You can move, or remove it, as needed.
            this.bODETableAdapter.Connection.ConnectionString = Program.StrConn;
            this.bODETableAdapter.Fill(this.tRACNGHIEMDataSet1.BODE);

            /* if (Program.groupNV == "NGANHANG")
             {
                 cbbChiNhanh.Enabled = true;
                 btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnPhucHoi.Enabled = groupBox1.Enabled = groupBox1.Visible = false;
             }
             else
             {
                 cbbChiNhanh.Enabled = btnPhucHoi.Enabled = groupBox1.Enabled = groupBox1.Visible = false;
                 btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = true;
             }*/

        }

        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bODEBindingSource.Position;
            bODEBindingSource.CancelEdit();
            this.bODETableAdapter.Fill(this.tRACNGHIEMDataSet1.BODE);
            bODEBindingSource.Position = vitri;
            btnDel.Enabled= btn_edit.Enabled = btnRefresh.Enabled = btnAdd.Enabled = true;
            if (btnSave.Enabled == false) btnSave.Enabled = true;
            btnSave.Enabled =  btnPhuchoi.Enabled = false;
            panelControl1.Enabled = false;
        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.bODETableAdapter.Fill(this.tRACNGHIEMDataSet1.BODE);
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bODEBindingSource.Position;
            panelControl1.Enabled = true;
            btnDel.Enabled = btnClose.Enabled = btnRefresh.Enabled  = btnAdd.Enabled = btn_edit.Enabled = false;
            btnSave.Enabled = btnPhuchoi.Enabled = true;

            bODEBindingSource.AddNew();
            mAMHTextEdit.Text = tRINHDOTextEdit.Text = dAP_ANTextEdit.Text = nOIDUNGRichTextBox.Text =
                aRichTextBox.Text = bRichTextBox.Text = cRichTextBox.Text = dRichTextBox.Text = dAP_ANTextEdit.Text = "";

            string sql = "select max(cauhoi) from bode";
            SqlDataReader reader = Program.ExecuteSqlReader(sql);
            reader.Read();
            cAUHOITextEdit.Text = reader.GetInt32(0) + 1 + "";
            mAGVTextEdit.Text = Program.MaNV; 
        }

        private void btnClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btn_edit_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bODEBindingSource.Position;
            String maGV = ((DataRowView)bODEBindingSource[vitri])["MAGV"].ToString().Trim();
            if (!maGV.Equals(Program.MaNV.Trim()))
            {
                MessageBox.Show("Câu hỏi này do giáo viên khác soạn bạn không thể sửa câu hỏi này!", "", MessageBoxButtons.OK);
                return;
            }

            panelControl1.Enabled = true;
            btnDel.Enabled = btnClose.Enabled = btnRefresh.Enabled = btnAdd.Enabled = btn_edit.Enabled = false;
            btnSave.Enabled = btnPhuchoi.Enabled = true;

        }

        private void btnDel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bODEBindingSource.Position;
            if(bAITHIBindingSource.Count >0 )
            {
                MessageBox.Show("câu hỏi đã được ra đề thi, không thể xóa!", "", MessageBoxButtons.OK);
                return;
            }
            DialogResult dr = MessageBox.Show("Bạn có chắc muốn xóa câu hỏi này?", "", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                try
                {
                    bODEBindingSource.RemoveCurrent();
                    this.bODETableAdapter.Update(this.tRACNGHIEMDataSet1.BODE);
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Lỗi xóa câu hỏi! " + ex.Message, "", MessageBoxButtons.OK);
                    this.bODETableAdapter.Fill(this.tRACNGHIEMDataSet1.BODE);
                    bODEBindingSource.Position = vitri;
                    return;
                }

            }
            if (bODEBindingSource.Count == 0) btnDel.Enabled = false;
        }

        private void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // Check
            if (mAMHTextEdit.Text.Trim().Equals(""))
            {
                MessageBox.Show("Mã môn học không được để trống!","",MessageBoxButtons.OK);
                mAMHTextEdit.Focus();
                return;
            }
           /* if (!tRINHDOTextEdit.Text.Trim().Equals("A") || !tRINHDOTextEdit.Text.Trim().Equals("B") || !tRINHDOTextEdit.Text.Trim().Equals("C"))
            {
                MessageBox.Show("Trình độ học không được để trống! Có giá trị là A,B hoặc C!", "", MessageBoxButtons.OK);
                tRINHDOTextEdit.Focus();
                return;
            }*/
           /* if (dAP_ANTextEdit.Text.Trim().Equals("") || !dAP_ANTextEdit.Text.Trim().Equals("A") || !dAP_ANTextEdit.Text.Trim().Equals("B") || !dAP_ANTextEdit.Text.Trim().Equals("C") || !dAP_ANTextEdit.Text.Trim().Equals("D"))
            {
                MessageBox.Show("Đáp án học không được để trống! Có giá trị là A,B,C hoặc D!", "", MessageBoxButtons.OK);
                dAP_ANTextEdit.Focus();
                return;
            }*/
            if (nOIDUNGRichTextBox.Text.Trim().Equals(""))
            {
                MessageBox.Show("nội dung học không được để trống!", "", MessageBoxButtons.OK);
                nOIDUNGRichTextBox.Focus();
                return;
            }

            if (aRichTextBox.Text.Trim().Equals(""))
            {
                MessageBox.Show(" Đáp án chọn A không được để trống!", "", MessageBoxButtons.OK);
                aRichTextBox.Focus();
                return;
            }
            if (bRichTextBox.Text.Trim().Equals(""))
            {
                MessageBox.Show(" Đáp án chọn B không được để trống!", "", MessageBoxButtons.OK);
                bRichTextBox.Focus();
                return;
            }
            if (cRichTextBox.Text.Trim().Equals(""))
            {
                MessageBox.Show(" Đáp án chọn C không được để trống!", "", MessageBoxButtons.OK);
                cRichTextBox.Focus();
                return;
            }
            if (dRichTextBox.Text.Trim().Equals(""))
            {
                MessageBox.Show(" Đáp án chọn D không được để trống!", "", MessageBoxButtons.OK);
                dRichTextBox.Focus();
                return;
            }
            //
            bODEBindingSource.EndEdit();
            bODEBindingSource.ResetCurrentItem();
            try
            {
                this.bODETableAdapter.Connection.ConnectionString = Program.StrConn;
                this.bODETableAdapter.Update(this.tRACNGHIEMDataSet1.BODE);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("Lỗi ghi bộ đề!" + ex.Message, "", MessageBoxButtons.OK);
            }

            panelControl1.Enabled = false;
            btnDel.Enabled = btnClose.Enabled = btnRefresh.Enabled = btnAdd.Enabled = btn_edit.Enabled = true;
            btnSave.Enabled = btnPhuchoi.Enabled = false;


        }
    }
}