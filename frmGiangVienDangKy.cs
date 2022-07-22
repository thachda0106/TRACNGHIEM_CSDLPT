using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSDLPT_TRACNGHIEM
{
    public partial class frmGiangVienDangKy : DevExpress.XtraEditors.XtraForm
    {
        public frmGiangVienDangKy()
        {
            InitializeComponent();
        }

        private void gIAOVIEN_DANGKYBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.gIAOVIEN_DANGKYBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.tRACNGHIEMDataSet);

        }

        private void frmGiangVienDangKy_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tRACNGHIEMDataSet.GIAOVIEN_DANGKY' table. You can move, or remove it, as needed.
            this.gIAOVIEN_DANGKYTableAdapter.Fill(this.tRACNGHIEMDataSet.GIAOVIEN_DANGKY);

        }

        private void tRINHDOTextEdit_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}