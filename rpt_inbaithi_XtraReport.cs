using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace CSDLPT_TRACNGHIEM
{
    public partial class rpt_inbaithi_XtraReport : DevExpress.XtraReports.UI.XtraReport
    {
        public rpt_inbaithi_XtraReport(String maSV, String maMH, String lanThi)
        {
            InitializeComponent();
            this.sqlDataSource1.Connection.ConnectionString = Program.StrConn;
            this.sqlDataSource1.Queries[0].Parameters[0].Value = maSV;
            this.sqlDataSource1.Queries[0].Parameters[1].Value = maMH;
            this.sqlDataSource1.Queries[0].Parameters[2].Value = lanThi;
            this.sqlDataSource1.Fill();
            
            

        }
       
    }
}
