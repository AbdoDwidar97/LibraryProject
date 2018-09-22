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
    public partial class ItemsData : Form
    {

        bool AddNew = false;
        Cl_Validate TxtClr = new Cl_Validate();

        public void BindGrid()
        {
            DataTable Dt = new DataTable();
            Dt = RetriveData.ExcuteQuery("Sp_Items_SelectAll", CommandType.StoredProcedure);

            DVGrid.DataSource = Dt;

        }

        public void Bind_Cmb_Category()
        {
            Cmb_Category_Name.DataSource = RetriveData.ExcuteQuery("Sp_Item_Category_SelectAll", CommandType.StoredProcedure);
            Cmb_Category_Name.DisplayMember = "Category_Name";
            Cmb_Category_Name.ValueMember = "Category_ID";

            Cmb_Category_Name.Text = "";
        }




        public ItemsData()
        {
            InitializeComponent();
        }

        private void ItemsData_Load(object sender, EventArgs e)
        {
            Bind_Cmb_Category();
            BindGrid();
        }

        private void Btn_Save_Click(object sender, EventArgs e)
        {
            if (AddNew == false) { MessageBox.Show("من فضلك يجب الضغط على زر جديد اولا", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
            if (TxtName.Text == "" || Txt_Min.Text == "" || Cmb_Category_Name.Text == "") { MessageBox.Show("من فضلك يجب ملىء جميع البيانات", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            if (MessageBox.Show("هل انت متاكد من حفظ بيانات الصنف ؟", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                RetriveData.ExcuteNonQuery("Sp_items_Insert",
                    new Pararmter("@Item_Name", SqlDbType.NVarChar, TxtName.Text),
                    new Pararmter("@Category_ID", SqlDbType.Int, Cmb_Category_Name.SelectedValue),
                    new Pararmter("@Item_Minimum", SqlDbType.Int, int.Parse(Txt_Min.Text)),
                    new Pararmter("@User_ID", SqlDbType.Int, Login.UserID));


                MessageBox.Show("تم حفظ الصنف بنجاح", "تم", MessageBoxButtons.OK, MessageBoxIcon.Information);
                AddNew = false;
                Lbl_Item_ID.Text = "L01";
                BindGrid();

            }
        }

        private void Btn_New_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل انت متاكد من اضافة صنف جديد", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                AddNew = true;
                
                TxtClr.TxtClear(this, panelControl3);
            }
        }

        private void Btn_Close_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void DVGrid_EditorKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Lbl_Item_ID.Text = gridView1.GetFocusedRowCellValue("Item_ID").ToString();
                TxtName.Text = gridView1.GetFocusedRowCellValue("Item_Name").ToString();
                Txt_Min.Text = gridView1.GetFocusedRowCellValue("Item_Minimum").ToString();
                Cmb_Category_Name.SelectedValue = gridView1.GetFocusedRowCellValue("Category_ID");
            }
        }

        private void Btn_Edit_Click(object sender, EventArgs e)
        {
            if (Lbl_Item_ID.Text != "L01")
            {

                if (TxtName.Text == "" || Txt_Min.Text == "" || Cmb_Category_Name.Text == "") { MessageBox.Show("من فضلك يجب ملىء جميع البيانات", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
                if (MessageBox.Show("هل انت متاكد من تعديل بيانات الصنف ؟", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    RetriveData.ExcuteNonQuery("Sp_items_Update",
                        new Pararmter("@Item_ID", SqlDbType.Int, int.Parse(Lbl_Item_ID.Text)),
                        new Pararmter("@Item_Name", SqlDbType.NVarChar, TxtName.Text),
                        new Pararmter("@Category_ID", SqlDbType.Int, Cmb_Category_Name.SelectedValue),
                        new Pararmter("@Item_Minimum", SqlDbType.Int, int.Parse(Txt_Min.Text)),
                        new Pararmter("@User_ID", SqlDbType.Int, Login.UserID));


                    MessageBox.Show("تم تعديل بيانات الصنف بنجاح", "تم", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AddNew = false;
                    Lbl_Item_ID.Text = "L01";
                    BindGrid();

                }

            }
        }

        private void Btn_Delete_Click(object sender, EventArgs e)
        {
            if (Lbl_Item_ID.Text != "L01")
            {

                if (MessageBox.Show("هل انت متاكد من حذف بيانات الصنف ؟", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    RetriveData.ExcuteNonQuery("Sp_Items_Delete", new Pararmter("@Item_ID", SqlDbType.Int, int.Parse(Lbl_Item_ID.Text)));

                    MessageBox.Show("تم حذف بيانات الصنف بنجاح", "تم", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AddNew = false;
                    Lbl_Item_ID.Text = "L01";
                    BindGrid();
                    TxtClr.TxtClear(this, panelControl3);
                }


            }

        }
    }
}
