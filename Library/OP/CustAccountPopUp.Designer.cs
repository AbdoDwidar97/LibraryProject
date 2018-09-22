namespace Library.OP
{
    partial class CustAccountPopUp
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
            this.DVGrid = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Cust_Name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Payed_Value = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Remain_Value = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Payed_Date = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Account_Notes = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DVGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // DVGrid
            // 
            this.DVGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DVGrid.Location = new System.Drawing.Point(0, 0);
            this.DVGrid.MainView = this.gridView1;
            this.DVGrid.Name = "DVGrid";
            this.DVGrid.Size = new System.Drawing.Size(801, 403);
            this.DVGrid.TabIndex = 8;
            this.DVGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Cust_Name,
            this.Payed_Value,
            this.Remain_Value,
            this.Payed_Date,
            this.Account_Notes});
            this.gridView1.GridControl = this.DVGrid;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            // 
            // Cust_Name
            // 
            this.Cust_Name.Caption = "اسم العميل";
            this.Cust_Name.FieldName = "Cust_Name";
            this.Cust_Name.Name = "Cust_Name";
            this.Cust_Name.Visible = true;
            this.Cust_Name.VisibleIndex = 0;
            // 
            // Payed_Value
            // 
            this.Payed_Value.Caption = "المبلغ المدفوع";
            this.Payed_Value.FieldName = "Payed_Value";
            this.Payed_Value.Name = "Payed_Value";
            this.Payed_Value.Visible = true;
            this.Payed_Value.VisibleIndex = 1;
            // 
            // Remain_Value
            // 
            this.Remain_Value.Caption = "المبلغ المتبقى";
            this.Remain_Value.FieldName = "Remain_Value";
            this.Remain_Value.Name = "Remain_Value";
            this.Remain_Value.Visible = true;
            this.Remain_Value.VisibleIndex = 2;
            // 
            // Payed_Date
            // 
            this.Payed_Date.Caption = "تاريخ الدفع";
            this.Payed_Date.FieldName = "Payed_Date";
            this.Payed_Date.Name = "Payed_Date";
            this.Payed_Date.Visible = true;
            this.Payed_Date.VisibleIndex = 3;
            // 
            // Account_Notes
            // 
            this.Account_Notes.Caption = "ملاحظات";
            this.Account_Notes.FieldName = "Account_Notes";
            this.Account_Notes.Name = "Account_Notes";
            this.Account_Notes.Visible = true;
            this.Account_Notes.VisibleIndex = 4;
            // 
            // CustAccountPopUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 403);
            this.Controls.Add(this.DVGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "CustAccountPopUp";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "عرض حركات عميل";
            this.Load += new System.EventHandler(this.CustAccountPopUp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DVGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl DVGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn Cust_Name;
        private DevExpress.XtraGrid.Columns.GridColumn Payed_Value;
        private DevExpress.XtraGrid.Columns.GridColumn Remain_Value;
        private DevExpress.XtraGrid.Columns.GridColumn Payed_Date;
        private DevExpress.XtraGrid.Columns.GridColumn Account_Notes;
    }
}