namespace Library.BasicData
{
    partial class ItemCategoryData
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
            this.Txt_Name = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.DVGrid = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Category_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Item_Category = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.Lbl_Cat_ID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Txt_Category_name = new System.Windows.Forms.TextBox();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.Btn_Edit = new System.Windows.Forms.Button();
            this.Btn_Close = new System.Windows.Forms.Button();
            this.Btn_Delete = new System.Windows.Forms.Button();
            this.Btn_Save = new System.Windows.Forms.Button();
            this.Btn_New = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_Name.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DVGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Txt_Name
            // 
            this.Txt_Name.Location = new System.Drawing.Point(214, 120);
            this.Txt_Name.Name = "Txt_Name";
            this.Txt_Name.Size = new System.Drawing.Size(226, 20);
            this.Txt_Name.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(452, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "اسم الصنف :";
            // 
            // DVGrid
            // 
            this.DVGrid.Location = new System.Drawing.Point(12, 226);
            this.DVGrid.MainView = this.gridView1;
            this.DVGrid.Name = "DVGrid";
            this.DVGrid.Size = new System.Drawing.Size(729, 228);
            this.DVGrid.TabIndex = 7;
            this.DVGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.DVGrid.EditorKeyDown += new System.Windows.Forms.KeyEventHandler(this.DVGrid_EditorKeyDown);
            this.DVGrid.Click += new System.EventHandler(this.DVGrid_Click);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Category_ID,
            this.Item_Category});
            this.gridView1.GridControl = this.DVGrid;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            // 
            // Category_ID
            // 
            this.Category_ID.Caption = "رقم الفئة";
            this.Category_ID.FieldName = "Category_ID";
            this.Category_ID.Name = "Category_ID";
            // 
            // Item_Category
            // 
            this.Item_Category.Caption = "فئة الصنف";
            this.Item_Category.FieldName = "Category_Name";
            this.Item_Category.Name = "Item_Category";
            this.Item_Category.Visible = true;
            this.Item_Category.VisibleIndex = 0;
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.Lbl_Cat_ID);
            this.panelControl3.Controls.Add(this.label2);
            this.panelControl3.Controls.Add(this.Txt_Category_name);
            this.panelControl3.Controls.Add(this.panelControl2);
            this.panelControl3.Location = new System.Drawing.Point(12, 12);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(729, 208);
            this.panelControl3.TabIndex = 6;
            // 
            // Lbl_Cat_ID
            // 
            this.Lbl_Cat_ID.AutoSize = true;
            this.Lbl_Cat_ID.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.Lbl_Cat_ID.Location = new System.Drawing.Point(44, 45);
            this.Lbl_Cat_ID.Name = "Lbl_Cat_ID";
            this.Lbl_Cat_ID.Size = new System.Drawing.Size(30, 14);
            this.Lbl_Cat_ID.TabIndex = 8;
            this.Lbl_Cat_ID.Text = "L01";
            this.Lbl_Cat_ID.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(409, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "اسم الصنف :";
            // 
            // Txt_Category_name
            // 
            this.Txt_Category_name.Location = new System.Drawing.Point(177, 42);
            this.Txt_Category_name.Name = "Txt_Category_name";
            this.Txt_Category_name.Size = new System.Drawing.Size(226, 20);
            this.Txt_Category_name.TabIndex = 6;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.Btn_Edit);
            this.panelControl2.Controls.Add(this.Btn_Close);
            this.panelControl2.Controls.Add(this.Btn_Delete);
            this.panelControl2.Controls.Add(this.Btn_Save);
            this.panelControl2.Controls.Add(this.Btn_New);
            this.panelControl2.Location = new System.Drawing.Point(64, 99);
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
            // ItemCategoryData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 465);
            this.Controls.Add(this.DVGrid);
            this.Controls.Add(this.panelControl3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ItemCategoryData";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "بيانات نوع الاصناف";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ItemCategoryData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Txt_Name.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DVGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            this.panelControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit Txt_Name;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.GridControl DVGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn Category_ID;
        private DevExpress.XtraGrid.Columns.GridColumn Item_Category;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Txt_Category_name;
        public DevExpress.XtraEditors.PanelControl panelControl2;
        public System.Windows.Forms.Button Btn_Edit;
        public System.Windows.Forms.Button Btn_Close;
        public System.Windows.Forms.Button Btn_Delete;
        public System.Windows.Forms.Button Btn_Save;
        public System.Windows.Forms.Button Btn_New;
        private System.Windows.Forms.Label Lbl_Cat_ID;
    }
}