using CSDLPT_TRACNGHIEM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CSDLPT_TRACNGHIEM
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
                this.ribbonDanhMuc.Visible = true;
                this.btnDangXuat.Enabled = true;
                this.btnDangNhap.Enabled = false;
                this.btnThoat.Enabled = true;
                this.btnTaoTaiKhoan.Enabled = true;
            if (Program.groupNV.Equals("GIANGVIEN")) // login thuộc chi nhánh toàn quyền bật hết các chức nắng (buttons)
            {
                
            }
            if (Program.groupNV.Equals("TRUONG")) // login thuộc chi nhánh toàn quyền bật hết các chức nắng (buttons)
            {

            }



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

        private void barButtonItem10_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc muốn thoát chương trình!", "", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                this.Close();
            }

            // Kiểm tra có mẫu tin nào đang ghi dở hk, hỏi người dùng có muốn ghi?
        }

        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form form = this.CheckExists(typeof(frmBoDe));
            if (form == null)
            {

                IsMdiContainer = true;
                frmBoDe f = new frmBoDe();
                f.MdiParent = this;
                f.Show();
            }
            else form.Activate();
            /*checkThi = true;*/
        }

        private void barButtonItem9_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form form = this.CheckExists(typeof(frmThi));
            if (form == null)
            {

                IsMdiContainer = true;
                frmThi f = new frmThi();
                f.MdiParent = this;
                f.Show();
            }
            else form.Activate();
            /*checkThi = true;*/
        }

        private void barButtonItem10_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form form = this.CheckExists(typeof(frm_InBangDiemMonHoc));
            if (form == null)
            {

                IsMdiContainer = true;
                frm_InBangDiemMonHoc f = new frm_InBangDiemMonHoc();
                f.MdiParent = this;
                f.Show();
            }
            else form.Activate();
            /*checkThi = true;*/
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FromKhoa));
            if (frm != null)
            {
                frm.Visible = true;
                frm.Activate();
            }
            else
            {
                FromKhoa f = new FromKhoa();
                f.MdiParent = this;
                f.Visible = true;

            }
        }

        private void btn_GVDK_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmGiangVienDangKy));
            if (frm != null)
            {
                frm.Visible = true;
                frm.Activate();
            }
            else
            {
                frmGiangVienDangKy f = new frmGiangVienDangKy();
                f.MdiParent = this;
                f.Visible = true;

            }
        }

        private void btn_DSDK_thi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frm_inDanhSachDangKyThi));
            if (frm != null)
            {
                frm.Visible = true;
                frm.Activate();
            }
            else
            {
                frm_inDanhSachDangKyThi f = new frm_inDanhSachDangKyThi();
                f.MdiParent = this;
                f.Visible = true;

            }
        }

        private void btn_Lop_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frm_Lop_SV));
            if (frm != null)
            {
                frm.Visible = true;
                frm.Activate();
            }
            else
            {
                frm_Lop_SV f = new frm_Lop_SV();
                f.MdiParent = this;
                f.Visible = true;

            }
        }
    }
}
