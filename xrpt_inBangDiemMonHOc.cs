using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace CSDLPT_TRACNGHIEM
{
    public partial class xrpt_inBangDiemMonHOc : DevExpress.XtraReports.UI.XtraReport
    {
        public xrpt_inBangDiemMonHOc(String maMH, String maLop, String lan)
        {
            InitializeComponent();
            this.sqlDataSource1.Connection.ConnectionString = Program.StrConn;
            this.sqlDataSource1.Queries[0].Parameters[0].Value = maMH;
            this.sqlDataSource1.Queries[0].Parameters[1].Value = maLop;
            this.sqlDataSource1.Queries[0].Parameters[2].Value = lan;
            this.sqlDataSource1.Fill();
        }

    }
}
