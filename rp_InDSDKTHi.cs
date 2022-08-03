using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace CSDLPT_TRACNGHIEM
{
    public partial class rp_InDSDKTHi : DevExpress.XtraReports.UI.XtraReport
    {
        public rp_InDSDKTHi(String TuNgay, String DenNgay)
        {
            InitializeComponent();
            this.sqlDataSource1.Connection.ConnectionString = Program.StrConn;
            this.sqlDataSource1.Queries[0].Parameters[0].Value = TuNgay;
            this.sqlDataSource1.Queries[0].Parameters[1].Value = DenNgay;
            this.sqlDataSource1.Fill();
        }

    }
}
