using DevExpress.XtraEditors;
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
    public partial class frmThi : DevExpress.XtraEditors.XtraForm
    {
        BindingSource bds_DSLop = new BindingSource();
        String maLop, tenLop, hoTen, maMH, lanThi;
        int phut, giay = 59;
        CauHoi[] listCauHoi;
        String TRINHDO;
        Int16 SOCAUTHI;
        Int16 THOIGIAN;
        DateTime NGAYTHI;
        int cauHienTai = 1;
        float diem;
        Boolean isStudent = true;
        public frmThi()
        {
            InitializeComponent();
        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lOPBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.lOPBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.tRACNGHIEMDataSet);

        }

        private void frmThi_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tRACNGHIEMDataSet1.GIAOVIEN_DANGKY' table. You can move, or remove it, as needed.
            tRACNGHIEMDataSet1.EnforceConstraints = false;
            this.gIAOVIEN_DANGKYTableAdapter.Connection.ConnectionString = Program.StrConn;
            this.gIAOVIEN_DANGKYTableAdapter.Fill(this.tRACNGHIEMDataSet1.GIAOVIEN_DANGKY);
            //
            if(gIAOVIEN_DANGKYBindingSource.Count == 0)
            {
                MessageBox.Show("Không có môn học đăng ký thi trắc nghiệm!", "", MessageBoxButtons.OK);
                this.btnLayBaiThi.Enabled = false;
                LayThongTinSinhVienThi();
                return;
            }

            var LanThi = new BindingList<KeyValuePair<string, string>>();
            LanThi.Add(new KeyValuePair<string, string>("1", "1"));
            LanThi.Add(new KeyValuePair<string, string>("2", "2"));
            this.comboBox1.DataSource = LanThi;
            this.comboBox1.ValueMember = "Key";
            this.comboBox1.DisplayMember = "Value";
            this.comboBox1.SelectedIndex = 0;
            //
            DataTable dt_DSLop = new DataTable();
            Program.connection();
            SqlDataAdapter myAdapter = new SqlDataAdapter("exec SP_DSMHSV_GVDK '" + Program.MaNV + "'", Program.conn);
            myAdapter.Fill(dt_DSLop);  //  fill và;o table 
            bds_DSLop.DataSource = dt_DSLop;
            cbb_TenMH.DataSource = bds_DSLop;
            cbb_TenMH.DisplayMember = "TENMH";
            cbb_TenMH.ValueMember = "MAMH";
            if (dt_DSLop.Rows.Count == 0) {
                MessageBox.Show("Không có môn học nào đăng ký thi trắc nghiệm!");
            }
            else
            {
                cbb_TenMH.SelectedIndex = 0;
                this.txtMaMH.Text = cbb_TenMH.SelectedValue.ToString();
                //
            }
            LayThongTinSinhVienThi();

        }

        private void summarylistview_MouseClick(object sender, MouseEventArgs e)
        {
            for (int i = 0; i < summarylistview.Items.Count; i++)
            {
                var rectangle = summarylistview.GetItemRect(i);
                if (rectangle.Contains(e.Location))
                {
                    this.lbNoiDungCH.Text = listCauHoi[i].NoiDung;
                    this.rbA.Text = listCauHoi[i].A;
                    this.rbB.Text = listCauHoi[i].B;
                    this.rbC.Text = listCauHoi[i].C;
                    this.rbD.Text = listCauHoi[i].D;
                    cauHienTai = i + 1;
                    this.lbCauSo.Text = "Câu số " + (cauHienTai) + " :";
                    if (listCauHoi[i].Chon.Equals("A")) rbA.Checked = true;
                    else if (listCauHoi[i].Chon.Equals("B")) rbB.Checked = true;
                    else if (listCauHoi[i].Chon.Equals("C")) rbC.Checked = true;
                    else if(listCauHoi[i].Chon.Equals("D")) rbD.Checked = true;
                    else rbA.Checked = rbB.Checked = rbC.Checked = rbD.Checked = false;

                    return;
                }
            }
        }

        private void rbA_CheckedChanged(object sender, EventArgs e)
        {
            if(rbA.Checked == true)
            {
                listCauHoi[cauHienTai-1].Chon = "A";
                summarylistview.Items[cauHienTai-1].SubItems[1].Text = "A";

            }
        }

        private void rbB_CheckedChanged(object sender, EventArgs e)
        {

            if (rbB.Checked == true)
            {
                listCauHoi[cauHienTai-1].Chon = "B";
                summarylistview.Items[cauHienTai - 1].SubItems[1].Text = "B";

            }

        }

        private void rbC_CheckedChanged(object sender, EventArgs e)
        {
            if (rbC.Checked == true)
            {
                listCauHoi[cauHienTai-1].Chon = "C";
                summarylistview.Items[cauHienTai - 1].SubItems[1].Text = "C";

            }
        }

        private void rbD_CheckedChanged(object sender, EventArgs e)
        {
            if (rbD.Checked == true)
            {
                listCauHoi[cauHienTai-1].Chon = "D";
                summarylistview.Items[cauHienTai - 1].SubItems[1].Text = "D";

            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNopBai_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc muốn nộp bài sớm không? Hãy kiểm tra đã chọn hết câu trả lời chưa?", "", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {

                if (isStudent)
                {
                    Program.frmSVMain.rbSinhVien.Enabled = true;
                }
                timer1.Stop();
                for(int i = 0; i< SOCAUTHI; i++)
                {
                    summarylistview.Items[i].SubItems.Add(listCauHoi[i].DapAn);
                }
                TinhDiem();

            }

        }

        private void TinhDiem()
        {
            this.btnThoat.Enabled = true;
            int caudung = 0;
            for (int i = 0; i < listCauHoi.Length; i++)
            {
                if (listCauHoi[i].Chon.Trim().CompareTo(listCauHoi[i].DapAn.Trim()) == 0)
                    caudung++;
            }

            if (caudung == 0) diem = 0;

            else diem = (float)Math.Round((double)(10 * caudung) / SOCAUTHI, 2);
            MessageBox.Show("Số câu đúng: " + caudung + "/" + SOCAUTHI + "\nĐiểm: " + diem, "Kết Quả", MessageBoxButtons.OK);
            btnNopBai.Visible = false;
            btnBatDau.Visible = true;
           
            // insert diem
            if(isStudent) insertdiemsv();
        }

        private void insertdiemsv()
        {
            String sql = "INSERT INTO dbo.BANGDIEM (MASV, MAMH, LAN, NGAYTHI, DIEM ) "
                + "VALUES (" +  "'" + Program.MaNV+ "', " + "'" + maMH + "', " + lanThi + ",'" + NGAYTHI.ToString("yyyy-MM-dd HH:MM") + "', " + diem
                            + ")";

            Console.WriteLine(sql);

            try
            {
                int kq = Program.ExecuteSqlNonQuery(sql);
                if(kq == 0 ) ghiDapAn();
                else MessageBox.Show("Lỗi ghi điểm thi!", "", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }
        private void ghiDapAn()
        {
            String sql = "";
            for (int i = 0; i < listCauHoi.Length; i++)
            {
                sql+="INSERT INTO dbo.BAITHI (MASV, MAMH, LAN, CAUHOI, NOIDUNG, A, B, C, D, DAP_AN, DACHON ) "
                + "VALUES (" + "'" + Program.MaNV + "', " + "'" + maMH + "', " + lanThi + ", "
                + listCauHoi[i].CauHoiID + ",N'" + listCauHoi[i].NoiDung + "', N'" + listCauHoi[i].A + "', N'"
                + listCauHoi[i].B + "', N'" + listCauHoi[i].C + "', N'" + listCauHoi[i].D + "', '" + listCauHoi[i].DapAn + "', '" + listCauHoi[i].Chon +
                            "');";
            }
            Console.WriteLine("causql :" + sql);
            try
            {
                Program.connection();
                Program.ExecuteSqlNonQuery(sql);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (cauHienTai == listCauHoi.Length) return;
            cauHienTai++;
            this.lbNoiDungCH.Text = listCauHoi[cauHienTai - 1].NoiDung;
            this.rbA.Text = listCauHoi[cauHienTai - 1].A;
            this.rbB.Text = listCauHoi[cauHienTai - 1].B;
            this.rbC.Text = listCauHoi[cauHienTai - 1].C;
            this.rbD.Text = listCauHoi[cauHienTai - 1].D;
            this.lbCauSo.Text = "Câu số " + (cauHienTai) + " :";
            if (listCauHoi[cauHienTai - 1].Chon.Equals("A")) rbA.Checked = true;
            else if (listCauHoi[cauHienTai - 1].Chon.Equals("B")) rbB.Checked = true;
            else if (listCauHoi[cauHienTai - 1].Chon.Equals("C")) rbC.Checked = true;
            else if (listCauHoi[cauHienTai - 1].Chon.Equals("D")) rbD.Checked = true;
            else rbA.Checked = rbB.Checked = rbC.Checked = rbD.Checked = false;
        }

        private void panelControl4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cauHienTai == 1) return;
            cauHienTai--;
            this.lbNoiDungCH.Text = listCauHoi[cauHienTai-1].NoiDung;
            this.rbA.Text = listCauHoi[cauHienTai - 1].A;
            this.rbB.Text = listCauHoi[cauHienTai - 1].B;
            this.rbC.Text = listCauHoi[cauHienTai - 1].C;
            this.rbD.Text = listCauHoi[cauHienTai - 1].D;
            this.lbCauSo.Text = "Câu số " + (cauHienTai) + " :";
            if (listCauHoi[cauHienTai - 1].Chon.Equals("A")) rbA.Checked = true;
            else if (listCauHoi[cauHienTai - 1].Chon.Equals("B")) rbB.Checked = true;
            else if (listCauHoi[cauHienTai - 1].Chon.Equals("C")) rbC.Checked = true;
            else if (listCauHoi[cauHienTai - 1].Chon.Equals("D")) rbD.Checked = true;
            else rbA.Checked = rbB.Checked = rbC.Checked = rbD.Checked = false;
        }

        private void cbb_TenMH_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbb_TenMH.SelectedValue.ToString() == "System.Data.DataRowView")
            {
                return;
            }

            this.txtMaMH.Text = cbb_TenMH.SelectedValue.ToString();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void LayThongTinSinhVienThi()
        {
            if(!Program.groupNV.Equals("SINHVIEN"))
            {
                isStudent = false;
                this.txtMaLop.Text = "MALOP";
                this.txtTenLop.Text = "TENLOP";
                this.txtHoTenSV.Text = Program.MaNV;
            }
            else
            {
                String sql = "exec SP_THONGTINSINHVIENTHI " +"'" + Program.MaNV + "'";
                SqlDataReader reader = Program.ExecuteSqlReader(sql);
                if(reader != null)
                {
                    reader.Read();
                    maLop = reader.GetString(0);
                    tenLop = reader.GetString(1);
                    hoTen = reader.GetString(2);
                    this.txtMaLop.Text = maLop;
                    this.txtTenLop.Text = tenLop;
                    this.txtHoTenSV.Text = hoTen;
                }

            }
        }

        private void btnLayBaiThi_Click(object sender, EventArgs e)
        {
            maMH = this.txtMaMH.Text.Trim();
            lanThi = this.comboBox1.Text;
            if (!isStudent)
            {
                String sql1 = "select top(1) MALOP from GIAOVIEN_DANGKY where MAMH = '" + this.txtMaMH.Text + "' AND MAGV = '" + Program.MaNV + "'";
                SqlDataReader readerMaLop = Program.ExecuteSqlReader(sql1);
                readerMaLop.Read();
                maLop = readerMaLop.GetString(0);
            }
            String sql = "exec SP_THONGTINTHI " + "'" + maLop + "', " + "'" + maMH + "', " + lanThi;
            SqlDataReader reader = Program.ExecuteSqlReader(sql);
            if (reader != null)
            {
                reader.Read();
                TRINHDO = reader.GetString(0);
                SOCAUTHI = reader.GetInt16 (1);
                THOIGIAN = reader.GetInt16(2);
                NGAYTHI = reader.GetDateTime(3);
                this.txtTrinhDo.Text = TRINHDO;
                this.txtSoLuongCau.Text = SOCAUTHI + "";
                this.txtThoiGian.Text = THOIGIAN+"";
                this.textNgayThi.Text = NGAYTHI.ToString("dd-MM-yyyy HH:MM");
                this.lbTime.Text = THOIGIAN - 1 + ":59";
                this.phut = THOIGIAN - 1;

            }
            else
            {
                MessageBox.Show("Mã môn học không có đăng ký thi trắc nghiệm!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.cbb_TenMH.Focus();
                this.txtTrinhDo.Text = "";
                this.txtSoLuongCau.Text = "";
                this.txtThoiGian.Text =  "";
                this.textNgayThi.Text = "";
                this.lbTime.Text = "00:00";
                this.panelControl2.Enabled = false;
                return;
            }


            layCauHoiThi();
         /*   MessageBox.Show(listCauHoi[0].NoiDung);*/
            this.panelControl2.Enabled = true;
        }
            
        private void layCauHoiThi()
        {
            listCauHoi = new CauHoi[SOCAUTHI];
            String sql_layCauHoiTHi = "exec sp_LAYCAUHOITHI " + "'" + maMH + "', " + "'" + this.txtTrinhDo.Text.Trim() + "', " + this.txtSoLuongCau.Text.Trim();
            
            SqlDataReader reader = Program.ExecuteSqlReader(sql_layCauHoiTHi);
            if (reader != null)
            {
                if(summarylistview.Items.Count > 0)
                {
                    summarylistview.Items.Clear();
                }
                int i = 0;
                while (reader.Read())
                {
                        Int32 CauHoiID = reader.GetInt32(0);
                        String NoiDung = reader.GetString(1);
                        String A = reader.GetString(2);
                        String B = reader.GetString(3);
                        String C = reader.GetString(4);
                        String D = reader.GetString(5);
                        String DapAn = reader.GetString(6);
                        String Chon = " ";
                    listCauHoi[i] = new CauHoi(CauHoiID,NoiDung,A,B,C,D,DapAn,Chon);
                    i++;
                        ListViewItem itm = new ListViewItem(new String[] { i+"", "" });
                        summarylistview.Items.Add(itm);
                }
            }


        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (giay != 0) giay -= 1;
            else if (phut == 0 && giay == 0)
            {
                Program.frmSVMain.rbSinhVien.Enabled = true;
                timer1.Stop();
                for (int i = 0; i < SOCAUTHI; i++)
                {
                    summarylistview.Items[i].SubItems.Add(listCauHoi[i].DapAn);
                }
                TinhDiem();
            }
            else
            {
                giay = 59;
                phut -= 1;
            }
            if(giay < 10 && phut < 10) this.lbTime.Text = "0" + phut + ":0" + giay;
            else if(phut < 10) this.lbTime.Text = "0" + phut + ":" + giay;
            else if (giay < 10) this.lbTime.Text = phut + ":0" + giay;
            else this.lbTime.Text = phut + ":" + giay;
        }


        private void btnBatDau_Click(object sender, EventArgs e)
        {
            if (isStudent)
            {
                DateTime today = DateTime.Today;
                if (today.Year != NGAYTHI.Year || today.Month != NGAYTHI.Month || today.Day != NGAYTHI.Day)
                {
                    Console.WriteLine("Ngay thi : " + NGAYTHI + " ngay hien tai: " + today);
                    MessageBox.Show("Ngày thi chưa đến hoặc đã quá hạn!", "Thông báo", MessageBoxButtons.OK);
                    return;
                }

                String ktlan = "exec sp_ktlanthi '"
                        + Program.MaNV + "', '"
                        + maMH + "', "
                        + lanThi;
                int kq = Program.ExecuteSqlNonQuery(ktlan);
                if (kq != 0)
                {
                    return;
                }
                Program.frmSVMain.rbSinhVien.Enabled = false;

            }


            this.cbb_TenMH.Enabled = false;
            this.btnBatDau.Enabled = false;
            this.btnNopBai.Enabled = true;
            this.panelControl3.Enabled = true;
            this.btnThoat.Enabled = this.btnLayBaiThi .Enabled= false;
            timer1.Start();
            this.lbNoiDungCH.Text = listCauHoi[0].NoiDung;
            this.rbA.Text = listCauHoi[0].A;
            this.rbB.Text = listCauHoi[0].B;
            this.rbC.Text = listCauHoi[0].C;
            this.rbD.Text = listCauHoi[0].D;
           
        }
    }
}