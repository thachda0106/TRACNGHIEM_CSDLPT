using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.Skins;
using DevExpress.UserSkins;
using System.Data.SqlClient;
using System.Data;
namespace QUANLYNGANHANG
{
    static class Program
    {
        // khai báo các biến và hàm toàn tục

        public static SqlConnection conn = new SqlConnection();
        public static String StrConn_ServerPublisher = "Data Source=LAPTOP-J7CDJNIV\\MSSQLSERVER_NNT;Initial Catalog=TRACNGHIEM;User ID=sa;Password=1447"; // chuỗi kết nối tới server chủ_ Với máy nào thì thay đổi chuổi kết nối này lại
        public static String StrConn; // chuỗi kết nối tới server phân mảnh của nhân viên đăng nhập tới

        public static SqlDataReader myReader;    // reader chứa thông tin đăng nhập của nhân viên đăng nhập
        public static String serverName;  // server Đăng nhập
        public static String chiNhanh;    // chi nhánh đăng nhập
        public static int CBBSelectedIndexChiNhanh;  // dùng để hiển thị chi nhánh đã chọn khi đăng nhập vào, cbb form khác dùng đến khi show chi nhánh ra
        public static String TestLogin;   // test kết nối csdl login
        public static String TestPassword; // test kết nối csdl pass
        public static String loginDN;  // login name Nhân viên đăng nhập được vào hệ thống
        public static String passwordDN; //pass name Nhân viên đăng nhập được vào hệ thống
        public static String groupNV;
        public static String hoTenNV;
        public static String MaNV;
        public static String database = "TRACNGHIEM";
        public static String remoteLogin = "HTKN";
        public static String remotePassword = "1447";


        public static BindingSource bds_LisSubscriber = new BindingSource(); // giữ danh sách phân mảnh khi đăng nhập được vào hệ thống
        public static FrmMain frmMain; // form chính để tương tác với các form khác


        public static int connection()
        {
            if (Program.conn != null && Program.conn.State == ConnectionState.Open) Program.conn.Close();

            try
            {
                Program.StrConn = "Data Source=" + Program.serverName + ";Initial Catalog=" + Program.database + ";User ID=" + Program.TestLogin + ";Password=" + Program.TestPassword;
                Program.conn.ConnectionString = StrConn;
                Program.conn.Open();
                return 1;
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi kết nối cơ sở dữ liệu. \nHãy xem lại username và password.\n" + e.Message);
                return 0;
            }


        }

        public static SqlDataReader ExecuteSqlReader(String sqlStr)
        {
            SqlDataReader myReader;
            SqlCommand cmd = new SqlCommand(sqlStr, Program.conn);
            cmd.CommandType = CommandType.Text;
            if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
            try
            {
                myReader = cmd.ExecuteReader();
                return myReader;
            }
            catch (Exception e)
            {
                Program.conn.Close();
                MessageBox.Show(e.Message);
                return null;
            }

        }
        public static int ExecuteSqlNonQuery(String sqlStr)
        {
            Program.conn.Close();
            SqlCommand cmd = new SqlCommand(sqlStr, Program.conn);
            cmd.CommandType = CommandType.Text;
            cmd.CommandTimeout = 600; // thời gian thực thi trong 10 phút
            if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
            try
            {
                cmd.ExecuteNonQuery();
                Program.conn.Close();
                return 0;
            }
            catch (SqlException e)
            {
                Program.conn.Close();
                MessageBox.Show(e.Message);
                return e.State;  // trang thai lỗi từ RAISERROR trong sql
            }

        }
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]

        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Program.frmMain = new FrmMain();
            Application.Run(Program.frmMain);

        }
    }
}
