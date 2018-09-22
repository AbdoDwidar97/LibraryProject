using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Library.DAL;

namespace Library.BasicData
{
    public partial class StoreConvert : Form
    {
        public void Bind_Filter_Items()
        {
            Cmb_Item_Name.DataSource = RetriveData.ExcuteQuery("Sp_Store_Convert_SelectByCategoryID", CommandType.StoredProcedure,
                new Pararmter("@Category_ID", SqlDbType.Int, int.Parse(Cmb_CategoryID.SelectedValue.ToString())));

            Cmb_Item_Name.DisplayMember = "Item_Name";
            Cmb_Item_Name.ValueMember = "Item_ID";

            Cmb_Item_Name.Text = "";
        }

        public void Bind_Cmb_CategoryID()
        {
            Cmb_CategoryID.DataSource = RetriveData.ExcuteQuery("Sp_Item_Category_SelectAll", CommandType.StoredProcedure);

            Cmb_CategoryID.DisplayMember = "Category_Name";
            Cmb_CategoryID.ValueMember = "Category_ID";

            Cmb_CategoryID.Text = "";

        }

        public void Bind_StoreName()
        {
            Cmb_StoreFrom.DataSource = RetriveData.ExcuteQuery("Sp_Store_Data_SelectAll", CommandType.StoredProcedure);
            Cmb_StoreTo.DataSource = RetriveData.ExcuteQuery("Sp_Store_Data_SelectAll", CommandType.StoredProcedure);

            Cmb_StoreFrom.DisplayMember = "Store_Name";
            Cmb_StoreFrom.ValueMember = "Store_ID";

            Cmb_StoreTo.DisplayMember = "Store_Name";
            Cmb_StoreTo.ValueMember = "Store_ID";

            Cmb_StoreFrom.Text = "";
            Cmb_StoreTo.Text = "";

        }

        public void BindDGVGrid()
        {
            DataTable Dt = RetriveData.ExcuteQuery("Sp_Store_Convert_SelectAll", CommandType.StoredProcedure);

            DVGrid.DataSource = Dt;


        }


        bool AddNew = false;

        public StoreConvert()
        {
            InitializeComponent();
        }

        private void StoreConvert_Load(object sender, EventArgs e)
        {
            Bind_Cmb_CategoryID();
            Bind_StoreName();
            BindDGVGrid();
        }

        private void Cmb_CategoryID_SelectedValueChanged(object sender, EventArgs e)
        {
            if (Cmb_CategoryID.SelectedValue.ToString() == "System.Data.DataRowView")
            {
                return;
            }
            Bind_Filter_Items();
        }

        private void Cmb_StoreFrom_SelectedValueChanged(object sender, EventArgs e)
        {
            if (Cmb_StoreFrom.Text == "" || Cmb_Item_Name.Text == "") { return; }
            
            DataTable dt = RetriveData.ExcuteQuery("Sp_StoreQuantity_SelectQuantity", CommandType.StoredProcedure,
                new Pararmter("@Item_ID", SqlDbType.Int, int.Parse(Cmb_Item_Name.SelectedValue.ToString())),
                new Pararmter("@Store_ID", SqlDbType.Int, int.Parse(Cmb_StoreFrom.SelectedValue.ToString())));

            Txt_CurrentQ1.Text = dt.Rows[0][0].ToString();

        }

        private void Cmb_StoreTo_SelectedValueChanged(object sender, EventArgs e)
        {
            if (Cmb_StoreTo.Text == "" || Cmb_Item_Name.Text == "") { return; }

            DataTable dt = RetriveData.ExcuteQuery("Sp_StoreQuantity_SelectQuantity", CommandType.StoredProcedure,
                new Pararmter("@Item_ID", SqlDbType.Int, int.Parse(Cmb_Item_Name.SelectedValue.ToString())),
                new Pararmter("@Store_ID", SqlDbType.Int, int.Parse(Cmb_StoreTo.SelectedValue.ToString())));

            Txt_CurrentQ2.Text = dt.Rows[0][0].ToString();

        }

        private void Btn_Close_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Btn_Con_Click(object sender, EventArgs e)
        {
            if (double.Parse(Txt_QuantityConvert.Text) + double.Parse(Txt_Converted.Text) > double.Parse(Txt_CurrentQ1.Text)) { MessageBox.Show("لا يمكن تحويل هذه الكمية لعدم توافرها", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }

        }

        private void Btn_New_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل انت متأكد من اضافة عملية التحويل ؟", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Cl_Validate Clr = new Cl_Validate();
                Clr.TxtClear(this,panelControl1);
                Cmb_CategoryID.Text = "";
                Cmb_Item_Name.Text = "";
                Cmb_StoreFrom.Text = "";
                Cmb_StoreTo.Text = "";
                AddNew = true;
            }
        }

        private void Btn_Save_Click(object sender, EventArgs e)
        {
            if (AddNew == false) { MessageBox.Show("من فضلك يجب الضغط على زر جديد اولاً", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }

            if (Cmb_CategoryID.Text == "" || Cmb_Item_Name.Text == "" || Cmb_StoreFrom.Text == "" || Cmb_StoreTo.Text == "" || Txt_Converted.Text == "0")
            {
                MessageBox.Show("من فضلك يجب ملىء جميع البيانات", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            if (MessageBox.Show("هل انت متأكد من حفظ عملية التحويل ؟", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                RetriveData.ExcuteNonQuery("Sp_Store_Convert_Insert",
                    new Pararmter("@StoreFrom_ID", SqlDbType.Int, int.Parse(Cmb_StoreFrom.SelectedValue.ToString())),
                    new Pararmter("@StoreTo_ID", SqlDbType.Int, int.Parse(Cmb_StoreTo.SelectedValue.ToString())),
                    new Pararmter("@Item_ID", SqlDbType.Int, int.Parse(Cmb_Item_Name.SelectedValue.ToString())),
                    new Pararmter("@Item_Quantity", SqlDbType.Int, int.Parse(Txt_Converted.Text)),
                    new Pararmter("@Con_Date", SqlDbType.Date, DTP_Con_Date.Text),
                    new Pararmter("@Con_Notes", SqlDbType.NVarChar, Txt_Notes.Text),
                    new Pararmter("@User_ID", SqlDbType.Int, Login.UserID));

                MessageBox.Show("تم تحويل الصنف بنجاح", "تم", MessageBoxButtons.OK, MessageBoxIcon.Information);
                AddNew = false;

            }


        }
    }
}
