namespace Library.BasicData
{
    partial class ItemsData
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
            this.Txt_Mobile = new DevExpress.XtraEditors.TextEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.Txt_Address = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.Txt_Name = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.DVGrid = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Item_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Item_Name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Category_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Category_Name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Item_Minimum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.Lbl_Item_ID = new System.Windows.Forms.Label();
            this.Cmb_Category_Name = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Txt_Min = new DevExpress.XtraEditors.TextEdit();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.Btn_Edit = new System.Windows.Forms.Button();
            this.Btn_Close = new System.Windows.Forms.Button();
            this.Btn_Delete = new System.Windows.Forms.Button();
            this.Btn_Save = new System.Windows.Forms.Button();
            this.Btn_New = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_Mobile.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_Address.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_Name.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DVGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_Min.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Txt_Mobile
            // 
            this.Txt_Mobile.Location = new System.Drawing.Point(185, 116);
            this.Txt_Mobile.Name = "Txt_Mobile";
            this.Txt_Mobile.Properties.Mask.EditMask = "n0";
            this.Txt_Mobile.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.Txt_Mobile.Size = new System.Drawing.Size(226, 20);
            this.Txt_Mobile.TabIndex = 34;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(423, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 13);
            this.label3.TabIndex = 33;
            this.label3.Text = "الحد الادنى لكمية الصنف :";
            // 
            // Txt_Address
            // 
            this.Txt_Address.Location = new System.Drawing.Point(39, 49);
            this.Txt_Address.Name = "Txt_Address";
            this.Txt_Address.Size = new System.Drawing.Size(263, 20);
            this.Txt_Address.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(318, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "رقم الصنف :";
            // 
            // Txt_Name
            // 
            this.Txt_Name.Location = new System.Drawing.Point(423, 49);
            this.Txt_Name.Name = "Txt_Name";
            this.Txt_Name.Size = new System.Drawing.Size(226, 20);
            this.Txt_Name.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(661, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "اسم الصنف :";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.DVGrid);
            this.panelControl1.Controls.Add(this.panelControl3);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(760, 511);
            this.panelControl1.TabIndex = 8;
            // 
            // DVGrid
            // 
            this.DVGrid.Location = new System.Drawing.Point(12, 267);
            this.DVGrid.MainView = this.gridView1;
            this.DVGrid.Name = "DVGrid";
            this.DVGrid.Size = new System.Drawing.Size(729, 228);
            this.DVGrid.TabIndex = 9;
            this.DVGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.DVGrid.EditorKeyDown += new System.Windows.Forms.KeyEventHandler(this.DVGrid_EditorKeyDown);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Item_ID,
            this.Item_Name,
            this.Category_ID,
            this.Category_Name,
            this.Item_Minimum});
            this.gridView1.GridControl = this.DVGrid;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            // 
            // Item_ID
            // 
            this.Item_ID.Caption = "رقم الصنف";
            this.Item_ID.FieldName = "Item_ID";
            this.Item_ID.Name = "Item_ID";
            // 
            // Item_Name
            // 
            this.Item_Name.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Item_Name.AppearanceCell.Options.UseFont = true;
            this.Item_Name.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Item_Name.AppearanceHeader.Options.UseFont = true;
            this.Item_Name.Caption = "اسم الصنف";
            this.Item_Name.FieldName = "Item_Name";
            this.Item_Name.Name = "Item_Name";
            this.Item_Name.Visible = true;
            this.Item_Name.VisibleIndex = 0;
            // 
            // Category_ID
            // 
            this.Category_ID.Caption = "رقم الفئة";
            this.Category_ID.FieldName = "Category_ID";
            this.Category_ID.Name = "Category_ID";
            // 
            // Category_Name
            // 
            this.Category_Name.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Category_Name.AppearanceCell.Options.UseFont = true;
            this.Category_Name.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Category_Name.AppearanceHeader.Options.UseFont = true;
            this.Category_Name.Caption = "فئة الصنف";
            this.Category_Name.FieldName = "Category_Name";
            this.Category_Name.Name = "Category_Name";
            this.Category_Name.Visible = true;
            this.Category_Name.VisibleIndex = 1;
            // 
            // Item_Minimum
            // 
            this.Item_Minimum.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Item_Minimum.AppearanceCell.Options.UseFont = true;
            this.Item_Minimum.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.Item_Minimum.AppearanceHeader.Options.UseFont = true;
            this.Item_Minimum.Caption = "الحد الأدنى";
            this.Item_Minimum.FieldName = "Item_Minimum";
            this.Item_Minimum.Name = "Item_Minimum";
            this.Item_Minimum.Visible = true;
            this.Item_Minimum.VisibleIndex = 2;
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.Lbl_Item_ID);
            this.panelControl3.Controls.Add(this.Cmb_Category_Name);
            this.panelControl3.Controls.Add(this.label6);
            this.panelControl3.Controls.Add(this.Txt_Min);
            this.panelControl3.Controls.Add(this.label5);
            this.panelControl3.Controls.Add(this.label4);
            this.panelControl3.Controls.Add(this.TxtName);
            this.panelControl3.Controls.Add(this.panelControl2);
            this.panelControl3.Location = new System.Drawing.Point(12, 21);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(729, 240);
            this.panelControl3.TabIndex = 8;
            // 
            // Lbl_Item_ID
            // 
            this.Lbl_Item_ID.AutoSize = true;
            this.Lbl_Item_ID.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.Lbl_Item_ID.Location = new System.Drawing.Point(43, 88);
            this.Lbl_Item_ID.Name = "Lbl_Item_ID";
            this.Lbl_Item_ID.Size = new System.Drawing.Size(30, 14);
            this.Lbl_Item_ID.TabIndex = 13;
            this.Lbl_Item_ID.Text = "L01";
            this.Lbl_Item_ID.Visible = false;
            // 
            // Cmb_Category_Name
            // 
            this.Cmb_Category_Name.FormattingEnabled = true;
            this.Cmb_Category_Name.Location = new System.Drawing.Point(389, 88);
            this.Cmb_Category_Name.Name = "Cmb_Category_Name";
            this.Cmb_Category_Name.Size = new System.Drawing.Size(226, 21);
            this.Cmb_Category_Name.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(621, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "فئة الصنف :";
            // 
            // Txt_Min
            // 
            this.Txt_Min.Location = new System.Drawing.Point(43, 32);
            this.Txt_Min.Name = "Txt_Min";
            this.Txt_Min.Size = new System.Drawing.Size(226, 20);
            this.Txt_Min.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(275, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "الحد الادنى :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(621, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "اسم الصنف :";
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(389, 32);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(226, 20);
            this.TxtName.TabIndex = 6;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.Btn_Edit);
            this.panelControl2.Controls.Add(this.Btn_Close);
            this.panelControl2.Controls.Add(this.Btn_Delete);
            this.panelControl2.Controls.Add(this.Btn_Save);
            this.panelControl2.Controls.Add(this.Btn_New);
            this.panelControl2.Location = new System.Drawing.Point(43, 136);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(584, 92);
            this.panelControl2.TabIndex = 4;
            // 
            // Btn_Edit
            // 
            this.Btn_Edit.BackgroundImage = global::Library.Properties.Resources._3edit;
            this.Btn_Edit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_Edit.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.Btn_Edit.Location = new System.Drawing.Point(129, 5);
            this.Btn_Edit.Name = "Btn_Edit";
            this.Btn_Edit.Size = new System.Drawing.Size(104, 81);
            this.Btn_Edit.TabIndex = 4;
            this.Btn_Edit.Text = "تعديل";
            this.Btn_Edit.UseVisualStyleBackColor = true;
            this.Btn_Edit.Click += new System.EventHandler(this.Btn_Edit_Click);
            // 
            // Btn_Close
            // 
            this.Btn_Close.BackgroundImage = global::Library.Properties.Resources._5back;
            this.Btn_Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_Close.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.Btn_Close.Location = new System.Drawing.Point(19, 5);
            this.Btn_Close.Name = "Btn_Close";
            this.Btn_Close.Size = new System.Drawing.Size(104, 81);
            this.Btn_Close.TabIndex = 3;
            this.Btn_Close.Text = "رجوع";
            this.Btn_Close.UseVisualStyleBackColor = true;
            this.Btn_Close.Click += new System.EventHandler(this.Btn_Close_Click);
            // 
            // Btn_Delete
            // 
            this.Btn_Delete.BackgroundImage = global::Library.Properties.Resources._4del;
            this.Btn_Delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_Delete.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.Btn_Delete.Location = new System.Drawing.Point(239, 5);
            this.Btn_Delete.Name = "Btn_Delete";
            this.Btn_Delete.Size = new System.Drawing.Size(105, 81);
            this.Btn_Delete.TabIndex = 2;
            this.Btn_Delete.Text = "حذف";
            this.Btn_Delete.UseVisualStyleBackColor = true;
            this.Btn_Delete.Click += new System.EventHandler(this.Btn_Delete_Click);
            // 
            // Btn_Save
            // 
            this.Btn_Save.BackgroundImage = global::Library.Properties.Resources._2save;
            this.Btn_Save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_Save.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.Btn_Save.Location = new System.Drawing.Point(350, 5);
            this.Btn_Save.Name = "Btn_Save";
            this.Btn_Save.Size = new System.Drawing.Size(105, 81);
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
            this.Btn_New.Location = new System.Drawing.Point(461, 5);
            this.Btn_New.Name = "Btn_New";
            this.Btn_New.Size = new System.Drawing.Size(105, 81);
            this.Btn_New.TabIndex = 0;
            this.Btn_New.Text = "جديد";
            this.Btn_New.UseVisualStyleBackColor = true;
            this.Btn_New.Click += new System.EventHandler(this.Btn_New_Click);
            // 
            // ItemsData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 511);
            this.Controls.Add(this.panelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ItemsData";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "بيانات الاصناف";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ItemsData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Txt_Mobile.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_Address.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_Name.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DVGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            this.panelControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_Min.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit Txt_Mobile;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.TextEdit Txt_Address;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.TextEdit Txt_Name;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraGrid.GridControl DVGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn Item_ID;
        private DevExpress.XtraGrid.Columns.GridColumn Item_Name;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtName;
        public DevExpress.XtraEditors.PanelControl panelControl2;
        public System.Windows.Forms.Button Btn_Edit;
        public System.Windows.Forms.Button Btn_Close;
        public System.Windows.Forms.Button Btn_Delete;
        public System.Windows.Forms.Button Btn_Save;
        public System.Windows.Forms.Button Btn_New;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.TextEdit Txt_Min;
        private System.Windows.Forms.ComboBox Cmb_Category_Name;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraGrid.Columns.GridColumn Category_Name;
        private DevExpress.XtraGrid.Columns.GridColumn Category_ID;
        private DevExpress.XtraGrid.Columns.GridColumn Item_Minimum;
        private System.Windows.Forms.Label Lbl_Item_ID;
    }
}