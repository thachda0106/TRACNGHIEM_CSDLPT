
namespace CSDLPT_TRACNGHIEM
{
    partial class frmXemKQThi
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
            System.Windows.Forms.Label mAMHLabel;
            System.Windows.Forms.Label lANLabel;
            System.Windows.Forms.Label label1;
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.button2 = new System.Windows.Forms.Button();
            this.lANComboBox = new System.Windows.Forms.ComboBox();
            this.bANGDIEMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tRACNGHIEMDataSet1 = new CSDLPT_TRACNGHIEM.TRACNGHIEMDataSet1();
            this.button1 = new System.Windows.Forms.Button();
            this.bANGDIEMBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.sINHVIENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bAITHIBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bAITHITableAdapter = new CSDLPT_TRACNGHIEM.TRACNGHIEMDataSet1TableAdapters.BAITHITableAdapter();
            this.tableAdapterManager = new CSDLPT_TRACNGHIEM.TRACNGHIEMDataSet1TableAdapters.TableAdapterManager();
            this.bANGDIEMTableAdapter = new CSDLPT_TRACNGHIEM.TRACNGHIEMDataSet1TableAdapters.BANGDIEMTableAdapter();
            this.mONHOCTableAdapter = new CSDLPT_TRACNGHIEM.TRACNGHIEMDataSet1TableAdapters.MONHOCTableAdapter();
            this.sINHVIENTableAdapter = new CSDLPT_TRACNGHIEM.TRACNGHIEMDataSet1TableAdapters.SINHVIENTableAdapter();
            this.mONHOCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mAMHComboBoxEdit = new DevExpress.XtraEditors.TextEdit();
            mAMHLabel = new System.Windows.Forms.Label();
            lANLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bANGDIEMBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRACNGHIEMDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bANGDIEMBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sINHVIENBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bAITHIBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mONHOCBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mAMHComboBoxEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // mAMHLabel
            // 
            mAMHLabel.AutoSize = true;
            mAMHLabel.Location = new System.Drawing.Point(268, 95);
            mAMHLabel.Name = "mAMHLabel";
            mAMHLabel.Size = new System.Drawing.Size(50, 17);
            mAMHLabel.TabIndex = 14;
            mAMHLabel.Text = "MAMH:";
            // 
            // lANLabel
            // 
            lANLabel.AutoSize = true;
            lANLabel.Location = new System.Drawing.Point(281, 37);
            lANLabel.Name = "lANLabel";
            lANLabel.Size = new System.Drawing.Size(37, 17);
            lANLabel.TabIndex = 15;
            lANLabel.Text = "LAN:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(46, 57);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(47, 17);
            label1.TabIndex = 19;
            label1.Text = "MASV:";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(label1);
            this.panelControl1.Controls.Add(this.textEdit1);
            this.panelControl1.Controls.Add(this.button2);
            this.panelControl1.Controls.Add(lANLabel);
            this.panelControl1.Controls.Add(this.lANComboBox);
            this.panelControl1.Controls.Add(mAMHLabel);
            this.panelControl1.Controls.Add(this.button1);
            this.panelControl1.Controls.Add(this.mAMHComboBoxEdit);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1137, 364);
            this.panelControl1.TabIndex = 0;
            this.panelControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.panelControl1_Paint);
            // 
            // textEdit1
            // 
            this.textEdit1.Enabled = false;
            this.textEdit1.Location = new System.Drawing.Point(102, 54);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Size = new System.Drawing.Size(125, 22);
            this.textEdit1.TabIndex = 18;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(702, 57);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(145, 31);
            this.button2.TabIndex = 17;
            this.button2.Text = "Thoát";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lANComboBox
            // 
            this.lANComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bANGDIEMBindingSource, "LAN", true));
            this.lANComboBox.FormattingEnabled = true;
            this.lANComboBox.Location = new System.Drawing.Point(324, 34);
            this.lANComboBox.Name = "lANComboBox";
            this.lANComboBox.Size = new System.Drawing.Size(121, 24);
            this.lANComboBox.TabIndex = 16;
            // 
            // bANGDIEMBindingSource
            // 
            this.bANGDIEMBindingSource.DataMember = "BANGDIEM";
            this.bANGDIEMBindingSource.DataSource = this.tRACNGHIEMDataSet1;
            // 
            // tRACNGHIEMDataSet1
            // 
            this.tRACNGHIEMDataSet1.DataSetName = "TRACNGHIEMDataSet1";
            this.tRACNGHIEMDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(514, 57);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 31);
            this.button1.TabIndex = 13;
            this.button1.Text = "Xem chi tiết bài thi";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bANGDIEMBindingSource1
            // 
            this.bANGDIEMBindingSource1.DataMember = "FK_BANGDIEM_SINHVIEN1";
            this.bANGDIEMBindingSource1.DataSource = this.sINHVIENBindingSource;
            // 
            // sINHVIENBindingSource
            // 
            this.sINHVIENBindingSource.DataMember = "SINHVIEN";
            this.sINHVIENBindingSource.DataSource = this.tRACNGHIEMDataSet1;
            // 
            // bAITHIBindingSource
            // 
            this.bAITHIBindingSource.DataMember = "BAITHI";
            this.bAITHIBindingSource.DataSource = this.tRACNGHIEMDataSet1;
            // 
            // bAITHITableAdapter
            // 
            this.bAITHITableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BAITHITableAdapter = this.bAITHITableAdapter;
            this.tableAdapterManager.BANGDIEMTableAdapter = this.bANGDIEMTableAdapter;
            this.tableAdapterManager.BODETableAdapter = null;
            this.tableAdapterManager.COSOTableAdapter = null;
            this.tableAdapterManager.GIAOVIEN_DANGKYTableAdapter = null;
            this.tableAdapterManager.GIAOVIENTableAdapter = null;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = null;
            this.tableAdapterManager.MONHOCTableAdapter = this.mONHOCTableAdapter;
            this.tableAdapterManager.SINHVIENTableAdapter = this.sINHVIENTableAdapter;
            this.tableAdapterManager.UpdateOrder = CSDLPT_TRACNGHIEM.TRACNGHIEMDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // bANGDIEMTableAdapter
            // 
            this.bANGDIEMTableAdapter.ClearBeforeFill = true;
            // 
            // mONHOCTableAdapter
            // 
            this.mONHOCTableAdapter.ClearBeforeFill = true;
            // 
            // sINHVIENTableAdapter
            // 
            this.sINHVIENTableAdapter.ClearBeforeFill = true;
            // 
            // mONHOCBindingSource
            // 
            this.mONHOCBindingSource.DataMember = "MONHOC";
            this.mONHOCBindingSource.DataSource = this.tRACNGHIEMDataSet1;
            // 
            // mAMHComboBoxEdit
            // 
            this.mAMHComboBoxEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bANGDIEMBindingSource, "MAMH", true));
            this.mAMHComboBoxEdit.Location = new System.Drawing.Point(324, 92);
            this.mAMHComboBoxEdit.Name = "mAMHComboBoxEdit";
            this.mAMHComboBoxEdit.Size = new System.Drawing.Size(125, 22);
            this.mAMHComboBoxEdit.TabIndex = 15;
            // 
            // frmXemKQThi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1137, 484);
            this.Controls.Add(this.panelControl1);
            this.Name = "frmXemKQThi";
            this.Text = "frmXemKQ";
            this.Load += new System.EventHandler(this.frmXemKQThi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bANGDIEMBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRACNGHIEMDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bANGDIEMBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sINHVIENBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bAITHIBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mONHOCBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mAMHComboBoxEdit.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private TRACNGHIEMDataSet1 tRACNGHIEMDataSet1;
        private System.Windows.Forms.BindingSource bAITHIBindingSource;
        private TRACNGHIEMDataSet1TableAdapters.BAITHITableAdapter bAITHITableAdapter;
        private TRACNGHIEMDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private TRACNGHIEMDataSet1TableAdapters.BANGDIEMTableAdapter bANGDIEMTableAdapter;
        private System.Windows.Forms.BindingSource bANGDIEMBindingSource;
        private System.Windows.Forms.Button button1;
        private TRACNGHIEMDataSet1TableAdapters.MONHOCTableAdapter mONHOCTableAdapter;
        private System.Windows.Forms.BindingSource mONHOCBindingSource;
        private TRACNGHIEMDataSet1TableAdapters.SINHVIENTableAdapter sINHVIENTableAdapter;
        private System.Windows.Forms.BindingSource sINHVIENBindingSource;
        private System.Windows.Forms.BindingSource bANGDIEMBindingSource1;
        private System.Windows.Forms.ComboBox lANComboBox;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private System.Windows.Forms.Button button2;
        private DevExpress.XtraEditors.TextEdit mAMHComboBoxEdit;
    }
}