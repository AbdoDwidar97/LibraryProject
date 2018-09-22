namespace Library.OP
{
    partial class CustAccountData
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
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.Cmb_Search = new System.Windows.Forms.ComboBox();
            this.Btn_Search = new System.Windows.Forms.Button();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.Lbl_Find = new System.Windows.Forms.Label();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.Btn_Close = new System.Windows.Forms.Button();
            this.Btn_Save = new System.Windows.Forms.Button();
            this.Btn_New = new System.Windows.Forms.Button();
            this.Txt_Notes = new System.Windows.Forms.TextBox();
            this.DTP = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Txt_PayedValue = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.Txt_RemainValue = new DevExpress.XtraEditors.TextEdit();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_PayedValue.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_RemainValue.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.Options.UseTextOptions = true;
            this.groupControl1.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.groupControl1.Controls.Add(this.Cmb_Search);
            this.groupControl1.Controls.Add(this.Btn_Search);
            this.groupControl1.Location = new System.Drawing.Point(21, 13);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(309, 107);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "بحث";
            // 
            // Cmb_Search
            // 
            this.Cmb_Search.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.Cmb_Search.FormattingEnabled = true;
            this.Cmb_Search.Location = new System.Drawing.Point(14, 33);
            this.Cmb_Search.Name = "Cmb_Search";
            this.Cmb_Search.Size = new System.Drawing.Size(281, 21);
            this.Cmb_Search.TabIndex = 1;
            // 
            // Btn_Search
            // 
            this.Btn_Search.Location = new System.Drawing.Point(14, 60);
            this.Btn_Search.Name = "Btn_Search";
            this.Btn_Search.Size = new System.Drawing.Size(281, 27);
            this.Btn_Search.TabIndex = 0;
            this.Btn_Search.Text = "بحث";
            this.Btn_Search.UseVisualStyleBackColor = true;
            this.Btn_Search.Click += new System.EventHandler(this.Btn_Search_Click);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.Lbl_Find);
            this.panelControl1.Controls.Add(this.panelControl2);
            this.panelControl1.Controls.Add(this.Txt_Notes);
            this.panelControl1.Controls.Add(this.DTP);
            this.panelControl1.Controls.Add(this.label3);
            this.panelControl1.Controls.Add(this.label2);
            this.panelControl1.Controls.Add(this.Txt_PayedValue);
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Controls.Add(this.Txt_RemainValue);
            this.panelControl1.Controls.Add(this.label5);
            this.panelControl1.Location = new System.Drawing.Point(12, 126);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(327, 300);
            this.panelControl1.TabIndex = 2;
            // 
            // Lbl_Find
            // 
            this.Lbl_Find.AutoSize = true;
            this.Lbl_Find.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.Lbl_Find.Location = new System.Drawing.Point(23, 34);
            this.Lbl_Find.Name = "Lbl_Find";
            this.Lbl_Find.Size = new System.Drawing.Size(27, 13);
            this.Lbl_Find.TabIndex = 32;
            this.Lbl_Find.Text = "L01";
            this.Lbl_Find.Visible = false;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.Btn_Close);
            this.panelControl2.Controls.Add(this.Btn_Save);
            this.panelControl2.Controls.Add(this.Btn_New);
            this.panelControl2.Location = new System.Drawing.Point(23, 227);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(280, 52);
            this.panelControl2.TabIndex = 31;
            // 
            // Btn_Close
            // 
            this.Btn_Close.BackgroundImage = global::Library.Properties.Resources._5back;
            this.Btn_Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_Close.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.Btn_Close.Location = new System.Drawing.Point(12, 8);
            this.Btn_Close.Name = "Btn_Close";
            this.Btn_Close.Size = new System.Drawing.Size(82, 39);
            this.Btn_Close.TabIndex = 3;
            this.Btn_Close.Text = "رجوع";
            this.Btn_Close.UseVisualStyleBackColor = true;
            this.Btn_Close.Click += new System.EventHandler(this.Btn_Close_Click);
            // 
            // Btn_Save
            // 
            this.Btn_Save.BackgroundImage = global::Library.Properties.Resources._2save;
            this.Btn_Save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_Save.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.Btn_Save.Location = new System.Drawing.Point(100, 8);
            this.Btn_Save.Name = "Btn_Save";
            this.Btn_Save.Size = new System.Drawing.Size(82, 39);
            this.Btn_Save.TabIndex = 1;
            this.Btn_Save.Text = "حفظ";
            this.Btn_Save.UseVisualStyleBackColor = true;
            this.Btn_Save.Click += new System.EventHandler(this.Btn_Save_Click);
            // 
            // Btn_New
            // 
            this.Btn_New.BackgroundImage = global::Library.Properties.Resources._1add;
            this.Btn_New.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_New.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.Btn_New.Location = new System.Drawing.Point(188, 8);
            this.Btn_New.Name = "Btn_New";
            this.Btn_New.Size = new System.Drawing.Size(82, 39);
            this.Btn_New.TabIndex = 0;
            this.Btn_New.Text = "جديد";
            this.Btn_New.UseVisualStyleBackColor = true;
            this.Btn_New.Click += new System.EventHandler(this.Btn_New_Click);
            // 
            // Txt_Notes
            // 
            this.Txt_Notes.Location = new System.Drawing.Point(72, 145);
            this.Txt_Notes.Multiline = true;
            this.Txt_Notes.Name = "Txt_Notes";
            this.Txt_Notes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Txt_Notes.Size = new System.Drawing.Size(144, 62);
            this.Txt_Notes.TabIndex = 30;
            // 
            // DTP
            // 
            this.DTP.Location = new System.Drawing.Point(72, 103);
            this.DTP.Name = "DTP";
            this.DTP.Size = new System.Drawing.Size(144, 20);
            this.DTP.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(222, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "ملاحظات :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(222, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "التاريخ :";
            // 
            // Txt_PayedValue
            // 
            this.Txt_PayedValue.EditValue = "0";
            this.Txt_PayedValue.Location = new System.Drawing.Point(72, 65);
            this.Txt_PayedValue.Name = "Txt_PayedValue";
            this.Txt_PayedValue.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.Txt_PayedValue.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.Txt_PayedValue.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Txt_PayedValue.Properties.Appearance.Options.UseBackColor = true;
            this.Txt_PayedValue.Properties.Appearance.Options.UseFont = true;
            this.Txt_PayedValue.Properties.Appearance.Options.UseForeColor = true;
            this.Txt_PayedValue.Properties.Mask.EditMask = "n";
            this.Txt_PayedValue.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.Txt_PayedValue.Size = new System.Drawing.Size(144, 20);
            this.Txt_PayedValue.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(222, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "المبلغ المدفوع :";
            // 
            // Txt_RemainValue
            // 
            this.Txt_RemainValue.EditValue = "0";
            this.Txt_RemainValue.Location = new System.Drawing.Point(72, 27);
            this.Txt_RemainValue.Name = "Txt_RemainValue";
            this.Txt_RemainValue.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.Txt_RemainValue.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.Txt_RemainValue.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Txt_RemainValue.Properties.Appearance.Options.UseBackColor = true;
            this.Txt_RemainValue.Properties.Appearance.Options.UseFont = true;
            this.Txt_RemainValue.Properties.Appearance.Options.UseForeColor = true;
            this.Txt_RemainValue.Properties.Mask.EditMask = "n";
            this.Txt_RemainValue.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.Txt_RemainValue.Properties.ReadOnly = true;
            this.Txt_RemainValue.Size = new System.Drawing.Size(144, 20);
            this.Txt_RemainValue.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(222, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "المبلغ المتبقى :";
            // 
            // CustAccountData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 438);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.groupControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "CustAccountData";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "مدفوعات عميل";
            this.Load += new System.EventHandler(this.CustAccountData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Txt_PayedValue.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_RemainValue.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public DevExpress.XtraEditors.GroupControl groupControl1;
        public System.Windows.Forms.ComboBox Cmb_Search;
        public System.Windows.Forms.Button Btn_Search;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.TextEdit Txt_PayedValue;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit Txt_RemainValue;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker DTP;
        private System.Windows.Forms.TextBox Txt_Notes;
        public DevExpress.XtraEditors.PanelControl panelControl2;
        public System.Windows.Forms.Button Btn_Close;
        public System.Windows.Forms.Button Btn_Save;
        public System.Windows.Forms.Button Btn_New;
        private System.Windows.Forms.Label Lbl_Find;
    }
}