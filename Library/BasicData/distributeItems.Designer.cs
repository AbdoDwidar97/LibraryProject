namespace Library.BasicData
{
    partial class distributeItems
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
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.Btn_Close = new System.Windows.Forms.Button();
            this.Btn_Save = new System.Windows.Forms.Button();
            this.Btn_Add = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Cmb_StoreName = new System.Windows.Forms.ComboBox();
            this.Cmb_ItemName = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DGV_Grid = new System.Windows.Forms.DataGridView();
            this.Col_Store_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Item_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Store_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Item_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Btn_AutoDistribute = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Grid)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.Btn_Close);
            this.panelControl2.Controls.Add(this.Btn_Save);
            this.panelControl2.Location = new System.Drawing.Point(12, 295);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(220, 52);
            this.panelControl2.TabIndex = 5;
            // 
            // Btn_Close
            // 
            this.Btn_Close.BackgroundImage = global::Library.Properties.Resources._5back;
            this.Btn_Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_Close.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.Btn_Close.Location = new System.Drawing.Point(5, 5);
            this.Btn_Close.Name = "Btn_Close";
            this.Btn_Close.Size = new System.Drawing.Size(101, 39);
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
            this.Btn_Save.Location = new System.Drawing.Point(112, 5);
            this.Btn_Save.Name = "Btn_Save";
            this.Btn_Save.Size = new System.Drawing.Size(102, 39);
            this.Btn_Save.TabIndex = 1;
            this.Btn_Save.Text = "حفظ";
            this.Btn_Save.UseVisualStyleBackColor = true;
            this.Btn_Save.Click += new System.EventHandler(this.Btn_Save_Click);
            // 
            // Btn_Add
            // 
            this.Btn_Add.BackgroundImage = global::Library.Properties.Resources._1add;
            this.Btn_Add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_Add.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.Btn_Add.Location = new System.Drawing.Point(12, 76);
            this.Btn_Add.Name = "Btn_Add";
            this.Btn_Add.Size = new System.Drawing.Size(102, 39);
            this.Btn_Add.TabIndex = 0;
            this.Btn_Add.Text = "إضافة";
            this.Btn_Add.UseVisualStyleBackColor = true;
            this.Btn_Add.Click += new System.EventHandler(this.Btn_Add_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(335, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "اسم الصنف :";
            // 
            // Cmb_StoreName
            // 
            this.Cmb_StoreName.FormattingEnabled = true;
            this.Cmb_StoreName.Location = new System.Drawing.Point(93, 33);
            this.Cmb_StoreName.Name = "Cmb_StoreName";
            this.Cmb_StoreName.Size = new System.Drawing.Size(177, 21);
            this.Cmb_StoreName.TabIndex = 9;
            // 
            // Cmb_ItemName
            // 
            this.Cmb_ItemName.FormattingEnabled = true;
            this.Cmb_ItemName.Location = new System.Drawing.Point(416, 33);
            this.Cmb_ItemName.Name = "Cmb_ItemName";
            this.Cmb_ItemName.Size = new System.Drawing.Size(177, 21);
            this.Cmb_ItemName.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(9, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "اسم المخزن :";
            // 
            // DGV_Grid
            // 
            this.DGV_Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Col_Store_ID,
            this.Col_Item_ID,
            this.Col_Store_Name,
            this.Col_Item_Name});
            this.DGV_Grid.Location = new System.Drawing.Point(12, 121);
            this.DGV_Grid.Name = "DGV_Grid";
            this.DGV_Grid.Size = new System.Drawing.Size(578, 168);
            this.DGV_Grid.TabIndex = 12;
            // 
            // Col_Store_ID
            // 
            this.Col_Store_ID.HeaderText = "رقم المخزن";
            this.Col_Store_ID.Name = "Col_Store_ID";
            this.Col_Store_ID.Visible = false;
            // 
            // Col_Item_ID
            // 
            this.Col_Item_ID.HeaderText = "رقم الصنف";
            this.Col_Item_ID.Name = "Col_Item_ID";
            this.Col_Item_ID.Visible = false;
            // 
            // Col_Store_Name
            // 
            this.Col_Store_Name.HeaderText = "اسم المخزن";
            this.Col_Store_Name.Name = "Col_Store_Name";
            this.Col_Store_Name.Width = 150;
            // 
            // Col_Item_Name
            // 
            this.Col_Item_Name.HeaderText = "اسم الصنف";
            this.Col_Item_Name.Name = "Col_Item_Name";
            this.Col_Item_Name.Width = 150;
            // 
            // Btn_AutoDistribute
            // 
            this.Btn_AutoDistribute.BackgroundImage = global::Library.Properties.Resources._2save;
            this.Btn_AutoDistribute.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_AutoDistribute.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.Btn_AutoDistribute.Location = new System.Drawing.Point(433, 300);
            this.Btn_AutoDistribute.Name = "Btn_AutoDistribute";
            this.Btn_AutoDistribute.Size = new System.Drawing.Size(157, 39);
            this.Btn_AutoDistribute.TabIndex = 13;
            this.Btn_AutoDistribute.Text = "توزيع اوتوماتيكى";
            this.Btn_AutoDistribute.UseVisualStyleBackColor = true;
            this.Btn_AutoDistribute.Click += new System.EventHandler(this.Btn_AutoDistribute_Click);
            // 
            // distributeItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 356);
            this.Controls.Add(this.Btn_AutoDistribute);
            this.Controls.Add(this.DGV_Grid);
            this.Controls.Add(this.Cmb_ItemName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Cmb_StoreName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Btn_Add);
            this.Controls.Add(this.panelControl2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "distributeItems";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "شاشة توزيع الاصناف فى المخازن";
            this.Load += new System.EventHandler(this.distributeItems_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public DevExpress.XtraEditors.PanelControl panelControl2;
        public System.Windows.Forms.Button Btn_Close;
        public System.Windows.Forms.Button Btn_Save;
        public System.Windows.Forms.Button Btn_Add;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Cmb_StoreName;
        private System.Windows.Forms.ComboBox Cmb_ItemName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DGV_Grid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Store_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Item_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Store_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Item_Name;
        public System.Windows.Forms.Button Btn_AutoDistribute;
    }
}