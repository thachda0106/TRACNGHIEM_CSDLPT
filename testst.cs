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
    public partial class testst : DevExpress.XtraEditors.XtraForm
    {
        public testst()
        {
            InitializeComponent();
        }

        private void lOPBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.lOPBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.tRACNGHIEMDataSet);

        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void testst_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tRACNGHIEMDataSet.LOP' table. You can move, or remove it, as needed.
            this.tRACNGHIEMDataSet.EnforceConstraints = false;

            this.lOPTableAdapter.Fill(this.tRACNGHIEMDataSet.LOP);

            ListViewItem itm = new ListViewItem(new String[] { "Câu hỏi", "X"} );
            summarylistview.Items.Add(itm);



        }

        private void mALOPComboBoxEdit_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
    }
}