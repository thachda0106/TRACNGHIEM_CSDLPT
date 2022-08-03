
namespace CSDLPT_TRACNGHIEM
{
    partial class testst
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label mALOPLabel;
            System.Windows.Forms.Label tENLOPLabel1;
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.lOPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tRACNGHIEMDataSet = new CSDLPT_TRACNGHIEM.TRACNGHIEMDataSet();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMALOP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENLOP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAKH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colrowguid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lOPTableAdapter = new CSDLPT_TRACNGHIEM.TRACNGHIEMDataSetTableAdapters.LOPTableAdapter();
            this.tableAdapterManager = new CSDLPT_TRACNGHIEM.TRACNGHIEMDataSetTableAdapters.TableAdapterManager();
            this.mALOPComboBoxEdit = new DevExpress.XtraEditors.ComboBoxEdit();
            this.tENLOPComboBoxEdit = new DevExpress.XtraEditors.ComboBoxEdit();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.summarylistview = new System.Windows.Forms.ListView();
            this.cauHoi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dapAn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            mALOPLabel = new System.Windows.Forms.Label();
            tENLOPLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRACNGHIEMDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mALOPComboBoxEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tENLOPComboBoxEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // mALOPLabel
            // 
            mALOPLabel.AutoSize = true;
            mALOPLabel.Location = new System.Drawing.Point(294, 44);
            mALOPLabel.Name = "mALOPLabel";
            mALOPLabel.Size = new System.Drawing.Size(56, 17);
            mALOPLabel.TabIndex = 1;
            mALOPLabel.Text = "MALOP:";
            // 
            // tENLOPLabel1
            // 
            tENLOPLabel1.AutoSize = true;
            tENLOPLabel1.Location = new System.Drawing.Point(319, 142);
            tENLOPLabel1.Name = "tENLOPLabel1";
            tENLOPLabel1.Size = new System.Drawing.Size(63, 17);
            tENLOPLabel1.TabIndex = 4;
            tENLOPLabel1.Text = "TENLOP:";
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.lOPBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(12, 223);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(946, 307);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click);
            // 
            // lOPBindingSource
            // 
            this.lOPBindingSource.DataMember = "LOP";
            this.lOPBindingSource.DataSource = this.tRACNGHIEMDataSet;
            // 
            // tRACNGHIEMDataSet
            // 
            this.tRACNGHIEMDataSet.DataSetName = "TRACNGHIEMDataSet";
            this.tRACNGHIEMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMALOP,
            this.colTENLOP,
            this.colMAKH,
            this.colrowguid});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colMALOP
            // 
            this.colMALOP.FieldName = "MALOP";
            this.colMALOP.MinWidth = 25;
            this.colMALOP.Name = "colMALOP";
            this.colMALOP.Visible = true;
            this.colMALOP.VisibleIndex = 0;
            this.colMALOP.Width = 94;
            // 
            // colTENLOP
            // 
            this.colTENLOP.FieldName = "TENLOP";
            this.colTENLOP.MinWidth = 25;
            this.colTENLOP.Name = "colTENLOP";
            this.colTENLOP.Visible = true;
            this.colTENLOP.VisibleIndex = 1;
            this.colTENLOP.Width = 94;
            // 
            // colMAKH
            // 
            this.colMAKH.FieldName = "MAKH";
            this.colMAKH.MinWidth = 25;
            this.colMAKH.Name = "colMAKH";
            this.colMAKH.Visible = true;
            this.colMAKH.VisibleIndex = 2;
            this.colMAKH.Width = 94;
            // 
            // colrowguid
            // 
            this.colrowguid.FieldName = "rowguid";
            this.colrowguid.MinWidth = 25;
            this.colrowguid.Name = "colrowguid";
            this.colrowguid.Visible = true;
            this.colrowguid.VisibleIndex = 3;
            this.colrowguid.Width = 94;
            // 
            // lOPTableAdapter
            // 
            this.lOPTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BANGDIEMTableAdapter = null;
            this.tableAdapterManager.BODETableAdapter = null;
            this.tableAdapterManager.COSOTableAdapter = null;
            this.tableAdapterManager.GIAOVIEN_DANGKYTableAdapter = null;
            this.tableAdapterManager.GIAOVIENTableAdapter = null;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = this.lOPTableAdapter;
            this.tableAdapterManager.MONHOCTableAdapter = null;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = CSDLPT_TRACNGHIEM.TRACNGHIEMDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // mALOPComboBoxEdit
            // 
            this.mALOPComboBoxEdit.AllowDrop = true;
            this.mALOPComboBoxEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.lOPBindingSource, "MALOP", true));
            this.mALOPComboBoxEdit.Location = new System.Drawing.Point(356, 41);
            this.mALOPComboBoxEdit.Name = "mALOPComboBoxEdit";
            this.mALOPComboBoxEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.mALOPComboBoxEdit.Size = new System.Drawing.Size(125, 22);
            this.mALOPComboBoxEdit.TabIndex = 2;
            this.mALOPComboBoxEdit.SelectedIndexChanged += new System.EventHandler(this.mALOPComboBoxEdit_SelectedIndexChanged);
            // 
            // tENLOPComboBoxEdit
            // 
            this.tENLOPComboBoxEdit.AllowDrop = true;
            this.tENLOPComboBoxEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.lOPBindingSource, "TENLOP", true));
            this.tENLOPComboBoxEdit.Location = new System.Drawing.Point(388, 139);
            this.tENLOPComboBoxEdit.Name = "tENLOPComboBoxEdit";
            this.tENLOPComboBoxEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tENLOPComboBoxEdit.Size = new System.Drawing.Size(125, 22);
            this.tENLOPComboBoxEdit.TabIndex = 5;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // summarylistview
            // 
            this.summarylistview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cauHoi,
            this.dapAn});
            this.summarylistview.Dock = System.Windows.Forms.DockStyle.Right;
            this.summarylistview.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.summarylistview.GridLines = true;
            this.summarylistview.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.summarylistview.HideSelection = false;
            this.summarylistview.Location = new System.Drawing.Point(780, 0);
            this.summarylistview.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.summarylistview.Name = "summarylistview";
            this.summarylistview.Size = new System.Drawing.Size(198, 550);
            this.summarylistview.TabIndex = 20;
            this.summarylistview.UseCompatibleStateImageBehavior = false;
            this.summarylistview.View = System.Windows.Forms.View.Details;
            // 
            // cauHoi
            // 
            this.cauHoi.Text = "Câu hỏi";
            this.cauHoi.Width = 72;
            // 
            // dapAn
            // 
            this.dapAn.Text = "Đáp án";
            this.dapAn.Width = 120;
            // 
            // testst
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 550);
            this.Controls.Add(this.summarylistview);
            this.Controls.Add(tENLOPLabel1);
            this.Controls.Add(this.tENLOPComboBoxEdit);
            this.Controls.Add(mALOPLabel);
            this.Controls.Add(this.mALOPComboBoxEdit);
            this.Controls.Add(this.gridControl1);
            this.Name = "testst";
            this.Text = "testst";
            this.Load += new System.EventHandler(this.testst_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRACNGHIEMDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mALOPComboBoxEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tENLOPComboBoxEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private TRACNGHIEMDataSet tRACNGHIEMDataSet;
        private System.Windows.Forms.BindingSource lOPBindingSource;
        private TRACNGHIEMDataSetTableAdapters.LOPTableAdapter lOPTableAdapter;
        private TRACNGHIEMDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.Columns.GridColumn colMALOP;
        private DevExpress.XtraGrid.Columns.GridColumn colTENLOP;
        private DevExpress.XtraGrid.Columns.GridColumn colMAKH;
        private DevExpress.XtraGrid.Columns.GridColumn colrowguid;
        private DevExpress.XtraEditors.ComboBoxEdit mALOPComboBoxEdit;
        private DevExpress.XtraEditors.ComboBoxEdit tENLOPComboBoxEdit;
        private System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.ListView summarylistview;
        private System.Windows.Forms.ColumnHeader cauHoi;
        private System.Windows.Forms.ColumnHeader dapAn;
    }
}