
namespace CSDLPT_TRACNGHIEM
{
    partial class frm_inDanhSachDangKyThi
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
            this.cbbChiNhanh = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tungay = new DevExpress.XtraEditors.DateEdit();
            this.denngay = new DevExpress.XtraEditors.DateEdit();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tungay.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tungay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.denngay.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.denngay.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // cbbChiNhanh
            // 
            this.cbbChiNhanh.CausesValidation = false;
            this.cbbChiNhanh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbChiNhanh.Enabled = false;
            this.cbbChiNhanh.FormattingEnabled = true;
            this.cbbChiNhanh.Location = new System.Drawing.Point(460, 79);
            this.cbbChiNhanh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbChiNhanh.Name = "cbbChiNhanh";
            this.cbbChiNhanh.Size = new System.Drawing.Size(182, 24);
            this.cbbChiNhanh.TabIndex = 13;
            this.cbbChiNhanh.SelectedIndexChanged += new System.EventHandler(this.cbbChiNhanh_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(387, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "Chi Nhánh";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tungay
            // 
            this.tungay.EditValue = new System.DateTime(2022, 7, 1, 0, 0, 0, 0);
            this.tungay.Location = new System.Drawing.Point(183, 93);
            this.tungay.Name = "tungay";
            this.tungay.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tungay.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tungay.Properties.DisplayFormat.FormatString = "yyyy-MM-dd";
            this.tungay.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.tungay.Properties.EditFormat.FormatString = "dd-MM-yyyy";
            this.tungay.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.tungay.Size = new System.Drawing.Size(125, 22);
            this.tungay.TabIndex = 15;
            this.tungay.EditValueChanged += new System.EventHandler(this.dateEdit1_EditValueChanged);
            // 
            // denngay
            // 
            this.denngay.EditValue = new System.DateTime(2022, 7, 31, 11, 44, 12, 0);
            this.denngay.Location = new System.Drawing.Point(183, 148);
            this.denngay.Name = "denngay";
            this.denngay.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.denngay.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.denngay.Properties.DisplayFormat.FormatString = "yyyy-MM-dd";
            this.denngay.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.denngay.Properties.EditFormat.FormatString = "dd-MM-yyyy";
            this.denngay.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.denngay.Size = new System.Drawing.Size(125, 22);
            this.denngay.TabIndex = 16;
            this.denngay.EditValueChanged += new System.EventHandler(this.denngay_EditValueChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(183, 225);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 68);
            this.button1.TabIndex = 17;
            this.button1.Text = "Xem";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(113, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 17);
            this.label2.TabIndex = 18;
            this.label2.Text = "Từ Ngày:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(103, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 17);
            this.label3.TabIndex = 19;
            this.label3.Text = "Đến Ngày:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(347, 225);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(111, 68);
            this.button2.TabIndex = 20;
            this.button2.Text = "Thoát";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // frm_inDanhSachDangKyThi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 518);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.denngay);
            this.Controls.Add(this.tungay);
            this.Controls.Add(this.cbbChiNhanh);
            this.Controls.Add(this.label1);
            this.Name = "frm_inDanhSachDangKyThi";
            this.Text = "frm_inDanhSachDangKyThi";
            this.Load += new System.EventHandler(this.frm_inDanhSachDangKyThi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tungay.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tungay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.denngay.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.denngay.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbbChiNhanh;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.DateEdit tungay;
        private DevExpress.XtraEditors.DateEdit denngay;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
    }
}