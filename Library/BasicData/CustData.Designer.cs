﻿namespace Library.BasicData
{
    partial class CustData
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
            this.label1 = new System.Windows.Forms.Label();
            this.Txt_Name = new DevExpress.XtraEditors.TextEdit();
            this.Txt_Address = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.Txt_Mobile = new DevExpress.XtraEditors.TextEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.Txt_Phone = new DevExpress.XtraEditors.TextEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Txt_Notes = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_Name.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_Address.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_Mobile.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_Phone.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.panelControl1.Size = new System.Drawing.Size(814, 556);
            this.panelControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.panelControl1_Paint);
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.Options.UseTextOptions = true;
            this.groupControl1.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.groupControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.groupControl1_Paint);
            // 
            // Btn_Search
            // 
            this.Btn_Search.Click += new System.EventHandler(this.Btn_Search_Click);
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.Txt_Notes);
            this.panelControl3.Controls.Add(this.label5);
            this.panelControl3.Controls.Add(this.Txt_Phone);
            this.panelControl3.Controls.Add(this.label4);
            this.panelControl3.Controls.Add(this.Txt_Mobile);
            this.panelControl3.Controls.Add(this.label3);
            this.panelControl3.Controls.Add(this.Txt_Address);
            this.panelControl3.Controls.Add(this.label2);
            this.panelControl3.Controls.Add(this.Txt_Name);
            this.panelControl3.Controls.Add(this.label1);
            this.panelControl3.Controls.SetChildIndex(this.Lbl_Cust_ID, 0);
            this.panelControl3.Controls.SetChildIndex(this.panelControl2, 0);
            this.panelControl3.Controls.SetChildIndex(this.label1, 0);
            this.panelControl3.Controls.SetChildIndex(this.Txt_Name, 0);
            this.panelControl3.Controls.SetChildIndex(this.label2, 0);
            this.panelControl3.Controls.SetChildIndex(this.Txt_Address, 0);
            this.panelControl3.Controls.SetChildIndex(this.label3, 0);
            this.panelControl3.Controls.SetChildIndex(this.Txt_Mobile, 0);
            this.panelControl3.Controls.SetChildIndex(this.label4, 0);
            this.panelControl3.Controls.SetChildIndex(this.Txt_Phone, 0);
            this.panelControl3.Controls.SetChildIndex(this.label5, 0);
            this.panelControl3.Controls.SetChildIndex(this.Txt_Notes, 0);
            // 
            // Btn_Edit
            // 
            this.Btn_Edit.Click += new System.EventHandler(this.Btn_Edit_Click);
            // 
            // Btn_Close
            // 
            this.Btn_Close.Click += new System.EventHandler(this.Btn_Close_Click);
            // 
            // Btn_Delete
            // 
            this.Btn_Delete.Click += new System.EventHandler(this.Btn_Delete_Click);
            // 
            // Btn_Save
            // 
            this.Btn_Save.Click += new System.EventHandler(this.Btn_Save_Click);
            // 
            // Btn_New
            // 
            this.Btn_New.Click += new System.EventHandler(this.Btn_New_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(676, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "اسم العميل :";
            // 
            // Txt_Name
            // 
            this.Txt_Name.Location = new System.Drawing.Point(438, 42);
            this.Txt_Name.Name = "Txt_Name";
            this.Txt_Name.Size = new System.Drawing.Size(226, 20);
            this.Txt_Name.TabIndex = 4;
            // 
            // Txt_Address
            // 
            this.Txt_Address.Location = new System.Drawing.Point(54, 42);
            this.Txt_Address.Name = "Txt_Address";
            this.Txt_Address.Size = new System.Drawing.Size(263, 20);
            this.Txt_Address.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(333, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "العنوان :";
            // 
            // Txt_Mobile
            // 
            this.Txt_Mobile.Location = new System.Drawing.Point(438, 93);
            this.Txt_Mobile.Name = "Txt_Mobile";
            this.Txt_Mobile.Properties.Mask.EditMask = "n0";
            this.Txt_Mobile.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.Txt_Mobile.Size = new System.Drawing.Size(226, 20);
            this.Txt_Mobile.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(676, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "الموبايل :";
            // 
            // Txt_Phone
            // 
            this.Txt_Phone.Location = new System.Drawing.Point(54, 93);
            this.Txt_Phone.Name = "Txt_Phone";
            this.Txt_Phone.Properties.Mask.EditMask = "n0";
            this.Txt_Phone.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.Txt_Phone.Size = new System.Drawing.Size(263, 20);
            this.Txt_Phone.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(333, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "تليفون المنزل :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(676, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "ملاحظات :";
            // 
            // Txt_Notes
            // 
            this.Txt_Notes.Location = new System.Drawing.Point(317, 150);
            this.Txt_Notes.Multiline = true;
            this.Txt_Notes.Name = "Txt_Notes";
            this.Txt_Notes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Txt_Notes.Size = new System.Drawing.Size(346, 87);
            this.Txt_Notes.TabIndex = 12;
            // 
            // CustData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 556);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "CustData";
            this.Text = "بيانات العملاء";
            this.Load += new System.EventHandler(this.CustData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            this.panelControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Txt_Name.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_Address.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_Mobile.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_Phone.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit Txt_Address;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.TextEdit Txt_Name;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit Txt_Phone;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.TextEdit Txt_Mobile;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Txt_Notes;
        private System.Windows.Forms.Label label5;
    }
}