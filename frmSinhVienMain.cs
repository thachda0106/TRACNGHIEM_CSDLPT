﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace CSDLPT_TRACNGHIEM
{
    public partial class frmSinhVienMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private Boolean checkDangXuat = false;
        public static Boolean checkThi = false;
        public frmSinhVienMain()
        {
            InitializeComponent();
        }

        private void btnThi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
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

        private void btnXemKQ_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form form = this.CheckExists(typeof(frmXemKQThi));
            if (form == null)
            {

                IsMdiContainer = true;
                frmXemKQThi f = new frmXemKQThi();
                f.MdiParent = this;
                f.Show();
            }
            else form.Activate();
        }

        private void btnDangXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
                Program.frmMain.Visible = true;
                this.Close();

        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc muốn thoát chương trình dl", "", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {

                Program.frmMain.Visible = true;
                
                this.Close();
            }

            // Kiểm tra có mẫu tin nào đang ghi dở hk, hỏi người dùng có muốn ghi?
        }

        private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;
        }

        private void frmSVMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (checkDangXuat == true)
            {
                // xác nhận xem có cần lưu lại những thay đổi trước khi đăng xuất không?
                this.Close();
                return;
            }
            
        }

        private void frmSinhVienMain_Load(object sender, EventArgs e)
        {

        }
    }
}