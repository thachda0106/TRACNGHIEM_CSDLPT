using CSDLPT_TRACNGHIEM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QUANLYNGANHANG
{

    public partial class FrmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public FrmMain()
        {
            InitializeComponent();
        }
        private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            
        }
        public void HienThiMenu()
        {
            
                this.ribbonBaoCao.Visible = true;
                this.ribbonCauHinh.Visible = true;
                this.btnTaoTaiKhoan.Enabled = true;
                this.ribbonDanhMuc.Visible = true;
                this.btnDangXuat.Enabled = true;
                this.btnDangNhap.Enabled = false;
                /* if (Program.groupNV.Equals("CHINHANH")) // login thuộc chi nhánh toàn quyền bật hết các chức nắng (buttons)
                 {
                     this.btnGuiRutTien.Enabled = true;
                     this.btnChuyenTien.Enabled = true;
                     this.btnKhachHang.Enabled = true;
                     this.btnNhanVien.Enabled = true;
                     this.btnMoTaiKhoan.Enabled = true;
                 }*/
                /* if (Program.groupNV.Equals("NGANHANG")) // login thuộc chi nhánh toàn quyền bật hết các chức nắng (buttons)
                 {
                     this.btnKhachHang.Enabled = true;
                     // hide các button cập nhật dữ liệu chỉ cho xem
                     //...
                     this.btnNhanVien.Enabled = true;
                     // hide các button cập nhật dữ liệu chỉ cho xem
                     this.btnMoTaiKhoan.Enabled = true;
                     this.ribbonDanhMuc.Visible = false;

                 }*/



        }
        private void btnDangNhap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FrmDangNhap));
            if (frm != null)
            {
                frm.Visible = true;
                frm.Activate();
            }
            else
            {
                FrmDangNhap frmDangNhap = new FrmDangNhap();
                frmDangNhap.MdiParent = this;
                frmDangNhap.Visible = true;

            }


        }


        private void btnDangXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            foreach (Form frm in this.MdiChildren)
            {
                if (frm != null)
                {
                    frm.Close();
                }
            }

            this.ribbonBaoCao.Visible = false;
            this.ribbonDanhMuc.Visible = false;
            this.btnTaoTaiKhoan.Enabled = false;
            this.btnDangXuat.Enabled = false;
            this.btnDangNhap.Enabled = true;
            lbHoTen.Text = "";
            lbMaNV.Text = "";
            lbGroup.Text = "";
        }

      

     
    }
}
