namespace Library.BasicData
{
    partial class JobTypeData
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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.DVGrid = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Job_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Job_Name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.Lbl_Job_ID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Txt_Job_Name = new System.Windows.Forms.TextBox();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.Btn_Edit = new System.Windows.Forms.Button();
            this.Btn_Close = new System.Windows.Forms.Button();
            this.Btn_Delete = new System.Windows.Forms.Button();
            this.Btn_Save = new System.Windows.Forms.Button();
            this.Btn_New = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DVGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.DVGrid);
            this.panelControl1.Controls.Add(this.panelControl3);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(753, 521);
            this.panelControl1.TabIndex = 0;
            // 
            // DVGrid
            // 
            this.DVGrid.Location = new System.Drawing.Point(12, 241);
            this.DVGrid.MainView = this.gridView1;
            this.DVGrid.Name = "DVGrid";
            this.DVGrid.Size = new System.Drawing.Size(729, 247);
            this.DVGrid.TabIndex = 5;
            this.DVGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.DVGrid.EditorKeyDown += new System.Windows.Forms.KeyEventHandler(this.DVGrid_EditorKeyDown);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Job_ID,
            this.Job_Name});
            this.gridView1.GridControl = this.DVGrid;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            // 
            // Job_ID
            // 
            this.Job_ID.Caption = "رقم الوظيفة";
            this.Job_ID.FieldName = "Job_ID";
            this.Job_ID.Name = "Job_ID";
            // 
            // Job_Name
            // 
            this.Job_Name.Caption = "اسم الوظيفة";
            this.Job_Name.FieldName = "Job_Name";
            this.Job_Name.Name = "Job_Name";
            this.Job_Name.Visible = true;
            this.Job_Name.VisibleIndex = 0;
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.Lbl_Job_ID);
            this.panelControl3.Controls.Add(this.label1);
            this.panelControl3.Controls.Add(this.Txt_Job_Name);
            this.panelControl3.Controls.Add(this.panelControl2);
            this.panelControl3.Location = new System.Drawing.Point(12, 27);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(729, 208);
            this.panelControl3.TabIndex = 4;
            // 
            // Lbl_Job_ID
            // 
            this.Lbl_Job_ID.AutoSize = true;
            this.Lbl_Job_ID.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.Lbl_Job_ID.Location = new System.Drawing.Point(43, 42);
            this.Lbl_Job_ID.Name = "Lbl_Job_ID";
            this.Lbl_Job_ID.Size = new System.Drawing.Size(30, 14);
            this.Lbl_Job_ID.TabIndex = 8;
            this.Lbl_Job_ID.Text = "L01";
            this.Lbl_Job_ID.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(409, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "اسم الوظيفة :";
            // 
            // Txt_Job_Name
            // 
            this.Txt_Job_Name.Location = new System.Drawing.Point(177, 42);
            this.Txt_Job_Name.Name = "Txt_Job_Name";
            this.Txt_Job_Name.Size = new System.Drawing.Size(226, 20);
            this.Txt_Job_Name.TabIndex = 6;
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
            // JobTypeData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 521);
            this.Controls.Add(this.panelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "JobTypeData";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "بيانات نوع الوظيفة";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.JobTypeData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
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

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        public DevExpress.XtraEditors.PanelControl panelControl2;
        public System.Windows.Forms.Button Btn_Edit;
        public System.Windows.Forms.Button Btn_Close;
        public System.Windows.Forms.Button Btn_Delete;
        public System.Windows.Forms.Button Btn_Save;
        public System.Windows.Forms.Button Btn_New;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txt_Job_Name;
        private DevExpress.XtraGrid.GridControl DVGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn Job_ID;
        private DevExpress.XtraGrid.Columns.GridColumn Job_Name;
        private System.Windows.Forms.Label Lbl_Job_ID;

    }
}