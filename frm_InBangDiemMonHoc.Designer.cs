
namespace CSDLPT_TRACNGHIEM
{
    partial class frm_InBangDiemMonHoc
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
            System.Windows.Forms.Label tENMHLabel;
            System.Windows.Forms.Label mAMHLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label mALOPLabel;
            System.Windows.Forms.Label tENLOPLabel;
            this.tRACNGHIEMDataSet = new CSDLPT_TRACNGHIEM.TRACNGHIEMDataSet();
            this.mONHOCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mONHOCTableAdapter = new CSDLPT_TRACNGHIEM.TRACNGHIEMDataSetTableAdapters.MONHOCTableAdapter();
            this.tableAdapterManager = new CSDLPT_TRACNGHIEM.TRACNGHIEMDataSetTableAdapters.TableAdapterManager();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tRACNGHIEMDataSet1 = new CSDLPT_TRACNGHIEM.TRACNGHIEMDataSet1();
            this.lOPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lOPTableAdapter = new CSDLPT_TRACNGHIEM.TRACNGHIEMDataSet1TableAdapters.LOPTableAdapter();
            this.tableAdapterManager1 = new CSDLPT_TRACNGHIEM.TRACNGHIEMDataSet1TableAdapters.TableAdapterManager();
            this.cbb_tenMH = new System.Windows.Forms.ComboBox();
            this.cbb_TenLOP = new System.Windows.Forms.ComboBox();
            this.txt_MaMh = new DevExpress.XtraEditors.TextEdit();
            this.txt_MaLop = new DevExpress.XtraEditors.TextEdit();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            tENMHLabel = new System.Windows.Forms.Label();
            mAMHLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            mALOPLabel = new System.Windows.Forms.Label();
            tENLOPLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tRACNGHIEMDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mONHOCBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRACNGHIEMDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_MaMh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_MaLop.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // tENMHLabel
            // 
            tENMHLabel.AutoSize = true;
            tENMHLabel.Location = new System.Drawing.Point(37, 55);
            tENMHLabel.Name = "tENMHLabel";
            tENMHLabel.Size = new System.Drawing.Size(57, 17);
            tENMHLabel.TabIndex = 1;
            tENMHLabel.Text = "TENMH:";
            // 
            // mAMHLabel
            // 
            mAMHLabel.AutoSize = true;
            mAMHLabel.Location = new System.Drawing.Point(232, 57);
            mAMHLabel.Name = "mAMHLabel";
            mAMHLabel.Size = new System.Drawing.Size(50, 17);
            mAMHLabel.TabIndex = 3;
            mAMHLabel.Text = "MAMH:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(37, 176);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(54, 17);
            label1.TabIndex = 7;
            label1.Text = "Lần thi:";
            // 
            // mALOPLabel
            // 
            mALOPLabel.AutoSize = true;
            mALOPLabel.Location = new System.Drawing.Point(226, 109);
            mALOPLabel.Name = "mALOPLabel";
            mALOPLabel.Size = new System.Drawing.Size(56, 17);
            mALOPLabel.TabIndex = 7;
            mALOPLabel.Text = "MALOP:";
            // 
            // tENLOPLabel
            // 
            tENLOPLabel.AutoSize = true;
            tENLOPLabel.Location = new System.Drawing.Point(31, 109);
            tENLOPLabel.Name = "tENLOPLabel";
            tENLOPLabel.Size = new System.Drawing.Size(63, 17);
            tENLOPLabel.TabIndex = 9;
            tENLOPLabel.Text = "TENLOP:";
            // 
            // tRACNGHIEMDataSet
            // 
            this.tRACNGHIEMDataSet.DataSetName = "TRACNGHIEMDataSet";
            this.tRACNGHIEMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mONHOCBindingSource
            // 
            this.mONHOCBindingSource.DataMember = "MONHOC";
            this.mONHOCBindingSource.DataSource = this.tRACNGHIEMDataSet;
            // 
            // mONHOCTableAdapter
            // 
            this.mONHOCTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.LOPTableAdapter = null;
            this.tableAdapterManager.MONHOCTableAdapter = this.mONHOCTableAdapter;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = CSDLPT_TRACNGHIEM.TRACNGHIEMDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(100, 173);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 6;
            // 
            // tRACNGHIEMDataSet1
            // 
            this.tRACNGHIEMDataSet1.DataSetName = "TRACNGHIEMDataSet1";
            this.tRACNGHIEMDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lOPBindingSource
            // 
            this.lOPBindingSource.DataMember = "LOP";
            this.lOPBindingSource.DataSource = this.tRACNGHIEMDataSet1;
            // 
            // lOPTableAdapter
            // 
            this.lOPTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.BAITHITableAdapter = null;
            this.tableAdapterManager1.BANGDIEMTableAdapter = null;
            this.tableAdapterManager1.BODETableAdapter = null;
            this.tableAdapterManager1.COSOTableAdapter = null;
            this.tableAdapterManager1.GIAOVIEN_DANGKYTableAdapter = null;
            this.tableAdapterManager1.GIAOVIENTableAdapter = null;
            this.tableAdapterManager1.KHOATableAdapter = null;
            this.tableAdapterManager1.LOPTableAdapter = this.lOPTableAdapter;
            this.tableAdapterManager1.MONHOCTableAdapter = null;
            this.tableAdapterManager1.SINHVIENTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = CSDLPT_TRACNGHIEM.TRACNGHIEMDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // cbb_tenMH
            // 
            this.cbb_tenMH.FormattingEnabled = true;
            this.cbb_tenMH.Location = new System.Drawing.Point(100, 52);
            this.cbb_tenMH.Name = "cbb_tenMH";
            this.cbb_tenMH.Size = new System.Drawing.Size(121, 24);
            this.cbb_tenMH.TabIndex = 10;
            this.cbb_tenMH.SelectedIndexChanged += new System.EventHandler(this.cbb_tenMH_SelectedIndexChanged);
            // 
            // cbb_TenLOP
            // 
            this.cbb_TenLOP.FormattingEnabled = true;
            this.cbb_TenLOP.Location = new System.Drawing.Point(99, 106);
            this.cbb_TenLOP.Name = "cbb_TenLOP";
            this.cbb_TenLOP.Size = new System.Drawing.Size(121, 24);
            this.cbb_TenLOP.TabIndex = 11;
            this.cbb_TenLOP.SelectedIndexChanged += new System.EventHandler(this.cbb_TenLOP_SelectedIndexChanged);
            // 
            // txt_MaMh
            // 
            this.txt_MaMh.Enabled = false;
            this.txt_MaMh.Location = new System.Drawing.Point(288, 54);
            this.txt_MaMh.Name = "txt_MaMh";
            this.txt_MaMh.Size = new System.Drawing.Size(125, 22);
            this.txt_MaMh.TabIndex = 12;
            // 
            // txt_MaLop
            // 
            this.txt_MaLop.Enabled = false;
            this.txt_MaLop.Location = new System.Drawing.Point(288, 108);
            this.txt_MaLop.Name = "txt_MaLop";
            this.txt_MaLop.Size = new System.Drawing.Size(125, 22);
            this.txt_MaLop.TabIndex = 13;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(517, 160);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(162, 56);
            this.button2.TabIndex = 19;
            this.button2.Text = "Thoát";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(288, 162);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(183, 53);
            this.button1.TabIndex = 18;
            this.button1.Text = "Xem bảng điểm MH";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frm_InBangDiemMonHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 447);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_MaLop);
            this.Controls.Add(this.txt_MaMh);
            this.Controls.Add(this.cbb_TenLOP);
            this.Controls.Add(this.cbb_tenMH);
            this.Controls.Add(tENLOPLabel);
            this.Controls.Add(mALOPLabel);
            this.Controls.Add(label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(mAMHLabel);
            this.Controls.Add(tENMHLabel);
            this.Name = "frm_InBangDiemMonHoc";
            this.Text = "frm_InBangDiemMonHoc";
            this.Load += new System.EventHandler(this.frm_InBangDiemMonHoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tRACNGHIEMDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mONHOCBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRACNGHIEMDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_MaMh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_MaLop.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TRACNGHIEMDataSet tRACNGHIEMDataSet;
        private System.Windows.Forms.BindingSource mONHOCBindingSource;
        private TRACNGHIEMDataSetTableAdapters.MONHOCTableAdapter mONHOCTableAdapter;
        private TRACNGHIEMDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox comboBox1;
        private TRACNGHIEMDataSet1 tRACNGHIEMDataSet1;
        private System.Windows.Forms.BindingSource lOPBindingSource;
        private TRACNGHIEMDataSet1TableAdapters.LOPTableAdapter lOPTableAdapter;
        private TRACNGHIEMDataSet1TableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.ComboBox cbb_tenMH;
        private System.Windows.Forms.ComboBox cbb_TenLOP;
        private DevExpress.XtraEditors.TextEdit txt_MaMh;
        private DevExpress.XtraEditors.TextEdit txt_MaLop;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}