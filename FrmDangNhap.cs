using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;
using CSDLPT_TRACNGHIEM;

namespace CSDLPT_TRACNGHIEM
{
    public partial class FrmDangNhap : DevExpress.XtraEditors.XtraForm
    {
        private SqlConnection conn_ServerPublisher = new SqlConnection();

        private int ConnTo_ServerPublisher()
        {
            if (conn_ServerPublisher != null && conn_ServerPublisher.State == ConnectionState.Open)
            {
                conn_ServerPublisher.Close();  // nếu connection đã mở thì đóng lại
            }
            try
            {
                conn_ServerPublisher.ConnectionString = Program.StrConn_ServerPublisher;  // gán chuối kết nối server publisher vào connection
                conn_ServerPublisher.Open();   // mở kết nối
                return 1;

            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi kết nối tới cơ sở dữ liệu gốc.\nHãy xem lại tên của server Publisher, CSDL, Tài khoản và mật khẩu của CSDL" + e.Message);
                return 0;
            }
        }
        private void GetListSubscriber(String sql_getDSPM) // lấy ds phân mảnh
        {

            DataTable dt_ViewSubscriber = new DataTable();
            if (conn_ServerPublisher.State == ConnectionState.Closed) conn_ServerPublisher.Open();
            SqlDataAdapter myAdapter = new SqlDataAdapter(sql_getDSPM, conn_ServerPublisher);
            myAdapter.Fill(dt_ViewSubscriber);  //  fill vào table 
            conn_ServerPublisher.Close();
            Program.bds_LisSubscriber.DataSource = dt_ViewSubscriber; // giữ dt_ViewSubscriber trong suốt chương trình khi đăng nhập
            cbbChiNhanh.DataSource = dt_ViewSubscriber;
            cbbChiNhanh.DisplayMember = "TENCN";
            cbbChiNhanh.ValueMember = "TENSERVER";

        }
        public FrmDangNhap()
        {
            InitializeComponent();
        }

        private void cbbChiNhanh_SelectedIndexChanged(object sender, EventArgs e)
        {
            Program.serverName = cbbChiNhanh.SelectedValue.ToString();
        }

        private void FrmDangNhap_Load(object sender, EventArgs e)
        {
            if (ConnTo_ServerPublisher() == 0) return;
            GetListSubscriber("SELECT * FROM Get_Subscribes");
            cbbChiNhanh.SelectedIndex = 1; cbbChiNhanh.SelectedIndex = 0;
           

        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (txtTaiKhoan.Text.Trim() == "" || txtMatKhau.Text.Trim() == "")
            {
                MessageBox.Show("Tài khoản và Mật khẩu không được để trống!", "LOGIN", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Program.TestLogin = txtTaiKhoan.Text.Trim();
            Program.TestPassword = txtMatKhau.Text.Trim();
            if (Program.connection() == 0) return;  // Lỗi kết nối csdl vs thông tin đăng nhập

            Program.CBBSelectedIndexChiNhanh = cbbChiNhanh.SelectedIndex;
            Program.chiNhanh = cbbChiNhanh.Text;
            Program.loginDN = Program.TestLogin;
            Program.passwordDN = Program.TestPassword;

            String strSql = "EXEC SP_Lay_Thong_Tin_GVSV_Tu_Login" + "'" + Program.loginDN + "'";
            Program.myReader = Program.ExecuteSqlReader(strSql);  // lấy thông tin nhân viên
            if (Program.myReader == null) return;

            Program.myReader.Read();  // thông tin nhân viên có 1 hàng nên đọc 1 lần

            Program.MaNV = Program.myReader.GetString(0);
            if (Convert.IsDBNull(Program.MaNV))
            {
                MessageBox.Show("Login đăng nhập không có quyền truy cập dữ liệu!", "SECURITY!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            Program.hoTenNV = Program.myReader.GetString(1);
            Program.groupNV = Program.myReader.GetString(2);


            if (Program.groupNV.Equals("SINHVIEN"))
            {
                frmSinhVienMain frm = new frmSinhVienMain();
                frm.HOTEN.Text = Program.hoTenNV;
                frm.NHOM.Text = Program.groupNV;
                frm.MASO.Text = Program.MaNV;
                Program.frmMain.Visible = false;
                frm.Visible = true;
            }
            else
            {
                // Show Thông tin nhân viên trong form chính 
                Program.frmMain.lbMaNV.Text = "Mã NV: " + Program.MaNV;
                Program.frmMain.lbHoTen.Text = "Họ Tên: " + Program.hoTenNV;
                Program.frmMain.lbGroup.Text = "Nhóm: " + Program.groupNV;

                // Phân quyền Nhân Viên trên form chính
                Program.frmMain.HienThiMenu();
            }
               
            
            MessageBox.Show("Đăng nhập thành công.", "LOGIN", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            this.Close();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            
            this.Close();
            
        }
    }
}