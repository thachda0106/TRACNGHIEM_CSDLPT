
namespace CSDLPT_TRACNGHIEM
{
    partial class FromKhoa
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
            System.Windows.Forms.Label mAKHLabel;
            System.Windows.Forms.Label tENKHLabel;
            System.Windows.Forms.Label mACSLabel;
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.them_id = new DevExpress.XtraBars.BarButtonItem();
            this.xoa_id = new DevExpress.XtraBars.BarButtonItem();
            this.sua_id = new DevExpress.XtraBars.BarButtonItem();
            this.ghi_id = new DevExpress.XtraBars.BarButtonItem();
            this.reset_id = new DevExpress.XtraBars.BarButtonItem();
            this.phuchoi_id = new DevExpress.XtraBars.BarButtonItem();
            this.thoat_id = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.tRACNGHIEMDataSet = new CSDLPT_TRACNGHIEM.TRACNGHIEMDataSet();
            this.cbbChiNhanh = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gIAOVIENTableAdapter = new CSDLPT_TRACNGHIEM.TRACNGHIEMDataSetTableAdapters.GIAOVIENTableAdapter();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.tRACNGHIEMDataSet1 = new CSDLPT_TRACNGHIEM.TRACNGHIEMDataSet1();
            this.kHOABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kHOATableAdapter = new CSDLPT_TRACNGHIEM.TRACNGHIEMDataSet1TableAdapters.KHOATableAdapter();
            this.tableAdapterManager = new CSDLPT_TRACNGHIEM.TRACNGHIEMDataSet1TableAdapters.TableAdapterManager();
            this.colMAKH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENKH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gIAOVIENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gIAOVIENTableAdapter1 = new CSDLPT_TRACNGHIEM.TRACNGHIEMDataSet1TableAdapters.GIAOVIENTableAdapter();
            this.lOPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lOPTableAdapter = new CSDLPT_TRACNGHIEM.TRACNGHIEMDataSet1TableAdapters.LOPTableAdapter();
            this.makhoa_id = new DevExpress.XtraEditors.TextEdit();
            this.tenkhoa_id = new DevExpress.XtraEditors.TextEdit();
            this.coso_id = new DevExpress.XtraEditors.TextEdit();
            this.colMACS = new DevExpress.XtraGrid.Columns.GridColumn();
            mAKHLabel = new System.Windows.Forms.Label();
            tENKHLabel = new System.Windows.Forms.Label();
            mACSLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tRACNGHIEMDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRACNGHIEMDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHOABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gIAOVIENBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.makhoa_id.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenkhoa_id.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coso_id.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.them_id,
            this.xoa_id,
            this.sua_id,
            this.ghi_id,
            this.reset_id,
            this.phuchoi_id,
            this.thoat_id});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 7;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.them_id),
            new DevExpress.XtraBars.LinkPersistInfo(this.xoa_id),
            new DevExpress.XtraBars.LinkPersistInfo(this.sua_id),
            new DevExpress.XtraBars.LinkPersistInfo(this.ghi_id),
            new DevExpress.XtraBars.LinkPersistInfo(this.reset_id),
            new DevExpress.XtraBars.LinkPersistInfo(this.phuchoi_id),
            new DevExpress.XtraBars.LinkPersistInfo(this.thoat_id)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // them_id
            // 
            this.them_id.Caption = "Thêm";
            this.them_id.Id = 0;
            this.them_id.Name = "them_id";
            this.them_id.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // xoa_id
            // 
            this.xoa_id.Caption = "Xóa";
            this.xoa_id.Id = 1;
            this.xoa_id.Name = "xoa_id";
            this.xoa_id.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.xoa_id_ItemClick);
            // 
            // sua_id
            // 
            this.sua_id.Caption = "Sửa";
            this.sua_id.Id = 2;
            this.sua_id.Name = "sua_id";
            this.sua_id.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.sua_id_ItemClick);
            // 
            // ghi_id
            // 
            this.ghi_id.Caption = "Ghi";
            this.ghi_id.Enabled = false;
            this.ghi_id.Id = 3;
            this.ghi_id.Name = "ghi_id";
            this.ghi_id.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ghi_id_ItemClick);
            // 
            // reset_id
            // 
            this.reset_id.Caption = "Refresh";
            this.reset_id.Id = 4;
            this.reset_id.Name = "reset_id";
            this.reset_id.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.reset_id_ItemClick);
            // 
            // phuchoi_id
            // 
            this.phuchoi_id.Caption = "Phục hồi";
            this.phuchoi_id.DropDownEnabled = false;
            this.phuchoi_id.Enabled = false;
            this.phuchoi_id.Id = 5;
            this.phuchoi_id.Name = "phuchoi_id";
            this.phuchoi_id.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.phuchoi_id_ItemClick);
            // 
            // thoat_id
            // 
            this.thoat_id.Caption = "Thoát";
            this.thoat_id.Id = 6;
            this.thoat_id.Name = "thoat_id";
            this.thoat_id.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.thoat_id_ItemClick);
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlTop.Size = new System.Drawing.Size(1210, 26);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 618);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlBottom.Size = new System.Drawing.Size(1210, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 26);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 592);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1210, 26);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 592);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(mACSLabel);
            this.panelControl1.Controls.Add(this.coso_id);
            this.panelControl1.Controls.Add(tENKHLabel);
            this.panelControl1.Controls.Add(this.tenkhoa_id);
            this.panelControl1.Controls.Add(mAKHLabel);
            this.panelControl1.Controls.Add(this.makhoa_id);
            this.panelControl1.Controls.Add(this.cbbChiNhanh);
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 26);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1210, 148);
            this.panelControl1.TabIndex = 4;
            // 
            // tRACNGHIEMDataSet
            // 
            this.tRACNGHIEMDataSet.DataSetName = "TRACNGHIEMDataSet";
            this.tRACNGHIEMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cbbChiNhanh
            // 
            this.cbbChiNhanh.CausesValidation = false;
            this.cbbChiNhanh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbChiNhanh.Enabled = false;
            this.cbbChiNhanh.FormattingEnabled = true;
            this.cbbChiNhanh.Location = new System.Drawing.Point(978, 38);
            this.cbbChiNhanh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbChiNhanh.Name = "cbbChiNhanh";
            this.cbbChiNhanh.Size = new System.Drawing.Size(182, 24);
            this.cbbChiNhanh.TabIndex = 13;
            this.cbbChiNhanh.SelectedIndexChanged += new System.EventHandler(this.cbbChiNhanh_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(905, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "Chi Nhánh";
            // 
            // gIAOVIENTableAdapter
            // 
            this.gIAOVIENTableAdapter.ClearBeforeFill = true;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.kHOABindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 174);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.MenuManager = this.barManager1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1210, 444);
            this.gridControl1.TabIndex = 10;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAKH,
            this.colTENKH,
            this.colMACS});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // tRACNGHIEMDataSet1
            // 
            this.tRACNGHIEMDataSet1.DataSetName = "TRACNGHIEMDataSet1";
            this.tRACNGHIEMDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kHOABindingSource
            // 
            this.kHOABindingSource.DataMember = "KHOA";
            this.kHOABindingSource.DataSource = this.tRACNGHIEMDataSet1;
            // 
            // kHOATableAdapter
            // 
            this.kHOATableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BAITHITableAdapter = null;
            this.tableAdapterManager.BANGDIEMTableAdapter = null;
            this.tableAdapterManager.BODETableAdapter = null;
            this.tableAdapterManager.COSOTableAdapter = null;
            this.tableAdapterManager.GIAOVIEN_DANGKYTableAdapter = null;
            this.tableAdapterManager.GIAOVIENTableAdapter = this.gIAOVIENTableAdapter1;
            this.tableAdapterManager.KHOATableAdapter = this.kHOATableAdapter;
            this.tableAdapterManager.LOPTableAdapter = this.lOPTableAdapter;
            this.tableAdapterManager.MONHOCTableAdapter = null;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = CSDLPT_TRACNGHIEM.TRACNGHIEMDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // colMAKH
            // 
            this.colMAKH.FieldName = "MAKH";
            this.colMAKH.MinWidth = 25;
            this.colMAKH.Name = "colMAKH";
            this.colMAKH.OptionsColumn.AllowEdit = false;
            this.colMAKH.Visible = true;
            this.colMAKH.VisibleIndex = 0;
            this.colMAKH.Width = 94;
            // 
            // colTENKH
            // 
            this.colTENKH.FieldName = "TENKH";
            this.colTENKH.MinWidth = 25;
            this.colTENKH.Name = "colTENKH";
            this.colTENKH.OptionsColumn.AllowEdit = false;
            this.colTENKH.Visible = true;
            this.colTENKH.VisibleIndex = 1;
            this.colTENKH.Width = 94;
            // 
            // gIAOVIENBindingSource
            // 
            this.gIAOVIENBindingSource.DataMember = "FK_GIAOVIEN_KHOA";
            this.gIAOVIENBindingSource.DataSource = this.kHOABindingSource;
            // 
            // gIAOVIENTableAdapter1
            // 
            this.gIAOVIENTableAdapter1.ClearBeforeFill = true;
            // 
            // lOPBindingSource
            // 
            this.lOPBindingSource.DataMember = "FK_LOP_KHOA";
            this.lOPBindingSource.DataSource = this.kHOABindingSource;
            // 
            // lOPTableAdapter
            // 
            this.lOPTableAdapter.ClearBeforeFill = true;
            // 
            // mAKHLabel
            // 
            mAKHLabel.AutoSize = true;
            mAKHLabel.Location = new System.Drawing.Point(110, 69);
            mAKHLabel.Name = "mAKHLabel";
            mAKHLabel.Size = new System.Drawing.Size(48, 17);
            mAKHLabel.TabIndex = 14;
            mAKHLabel.Text = "MAKH:";
            // 
            // makhoa_id
            // 
            this.makhoa_id.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.kHOABindingSource, "MAKH", true));
            this.makhoa_id.Enabled = false;
            this.makhoa_id.Location = new System.Drawing.Point(164, 66);
            this.makhoa_id.MenuManager = this.barManager1;
            this.makhoa_id.Name = "makhoa_id";
            this.makhoa_id.Size = new System.Drawing.Size(125, 22);
            this.makhoa_id.TabIndex = 15;
            // 
            // tENKHLabel
            // 
            tENKHLabel.AutoSize = true;
            tENKHLabel.Location = new System.Drawing.Point(112, 23);
            tENKHLabel.Name = "tENKHLabel";
            tENKHLabel.Size = new System.Drawing.Size(55, 17);
            tENKHLabel.TabIndex = 15;
            tENKHLabel.Text = "TENKH:";
            // 
            // tenkhoa_id
            // 
            this.tenkhoa_id.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.kHOABindingSource, "TENKH", true));
            this.tenkhoa_id.Enabled = false;
            this.tenkhoa_id.Location = new System.Drawing.Point(173, 20);
            this.tenkhoa_id.MenuManager = this.barManager1;
            this.tenkhoa_id.Name = "tenkhoa_id";
            this.tenkhoa_id.Size = new System.Drawing.Size(125, 22);
            this.tenkhoa_id.TabIndex = 16;
            // 
            // mACSLabel
            // 
            mACSLabel.AutoSize = true;
            mACSLabel.Location = new System.Drawing.Point(353, 21);
            mACSLabel.Name = "mACSLabel";
            mACSLabel.Size = new System.Drawing.Size(48, 17);
            mACSLabel.TabIndex = 16;
            mACSLabel.Text = "MACS:";
            // 
            // coso_id
            // 
            this.coso_id.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.kHOABindingSource, "MACS", true));
            this.coso_id.Enabled = false;
            this.coso_id.Location = new System.Drawing.Point(407, 18);
            this.coso_id.MenuManager = this.barManager1;
            this.coso_id.Name = "coso_id";
            this.coso_id.Size = new System.Drawing.Size(125, 22);
            this.coso_id.TabIndex = 17;
            // 
            // colMACS
            // 
            this.colMACS.FieldName = "MACS";
            this.colMACS.MinWidth = 25;
            this.colMACS.Name = "colMACS";
            this.colMACS.OptionsColumn.AllowEdit = false;
            this.colMACS.Visible = true;
            this.colMACS.VisibleIndex = 2;
            this.colMACS.Width = 94;
            // 
            // FromKhoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1210, 638);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FromKhoa";
            this.Text = "FromKhoa";
            this.Load += new System.EventHandler(this.FromKhoa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tRACNGHIEMDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRACNGHIEMDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHOABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gIAOVIENBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.makhoa_id.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenkhoa_id.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coso_id.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem them_id;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private TRACNGHIEMDataSet tRACNGHIEMDataSet;
        private System.Windows.Forms.ComboBox cbbChiNhanh;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraBars.BarButtonItem xoa_id;
        private DevExpress.XtraBars.BarButtonItem sua_id;
        private DevExpress.XtraBars.BarButtonItem ghi_id;
        private DevExpress.XtraBars.BarButtonItem reset_id;
        private DevExpress.XtraBars.BarButtonItem phuchoi_id;
        private DevExpress.XtraBars.BarButtonItem thoat_id;
        private TRACNGHIEMDataSetTableAdapters.GIAOVIENTableAdapter gIAOVIENTableAdapter;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private TRACNGHIEMDataSet1 tRACNGHIEMDataSet1;
        private System.Windows.Forms.BindingSource kHOABindingSource;
        private TRACNGHIEMDataSet1TableAdapters.KHOATableAdapter kHOATableAdapter;
        private TRACNGHIEMDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.Columns.GridColumn colMAKH;
        private DevExpress.XtraGrid.Columns.GridColumn colTENKH;
        private TRACNGHIEMDataSet1TableAdapters.GIAOVIENTableAdapter gIAOVIENTableAdapter1;
        private System.Windows.Forms.BindingSource gIAOVIENBindingSource;
        private TRACNGHIEMDataSet1TableAdapters.LOPTableAdapter lOPTableAdapter;
        private System.Windows.Forms.BindingSource lOPBindingSource;
        private DevExpress.XtraEditors.TextEdit coso_id;
        private DevExpress.XtraEditors.TextEdit tenkhoa_id;
        private DevExpress.XtraEditors.TextEdit makhoa_id;
        private DevExpress.XtraGrid.Columns.GridColumn colMACS;
    }
}