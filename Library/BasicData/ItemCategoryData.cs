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
    public partial class ItemCategoryData : Form
    {

        bool AddNew = false;

        public void BindGrid()
        {
            DataTable Dt = new DataTable();
            Dt = RetriveData.ExcuteQuery("Sp_Item_Category_SelectAll", CommandType.StoredProcedure);

            DVGrid.DataSource = Dt;


        }

        public ItemCategoryData()
        {
            InitializeComponent();
        }

        private void ItemCategoryData_Load(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void Btn_New_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("هل انت متأكد من اضافة فئة صنف جديدة ؟", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                AddNew = true;
                Txt_Category_name.Text = "";

            }




        }

        private void Btn_Save_Click(object sender, EventArgs e)
        {


            if (AddNew == false) { MessageBox.Show("من فضلك يجب الضغط على زر جديد اولاً", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }

            if (Txt_Category_name.Text == "") { MessageBox.Show("من فضلك يجب كتابة اسم فئة الصنف", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }

            if (MessageBox.Show("هل انت متأكد من اضافة فئة صنف جديدة ؟", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {


                RetriveData.ExcuteNonQuery("Sp_Item_Category_Insert",
                    new Pararmter("@Category_Name", SqlDbType.NVarChar, Txt_Category_name.Text),
                    new Pararmter("@User_ID", SqlDbType.Int, Login.UserID));

                MessageBox.Show("تم حفظ فئة الصنف بنجاح ", "تم", MessageBoxButtons.OK, MessageBoxIcon.Information);
                AddNew = false;
                BindGrid();

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
                Lbl_Cat_ID.Text = gridView1.GetFocusedRowCellValue("Category_ID").ToString();
                Txt_Category_name.Text = gridView1.GetFocusedRowCellValue("Category_Name").ToString();
            }
        }

        private void Btn_Edit_Click(object sender, EventArgs e)
        {

            if (Lbl_Cat_ID.Text != "L01")
            {

                if (Txt_Category_name.Text == "") { MessageBox.Show("من فضلك يجب كتابة فئة الصنف", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }

                if (MessageBox.Show("هل انت متأكد من تعديل فئة الصنف ؟", "تاكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    
                    RetriveData.ExcuteNonQuery("Sp_Item_Category_Update",
                        new Pararmter("@Category_ID",SqlDbType.Int,int.Parse(Lbl_Cat_ID.Text).ToString()),
                        new Pararmter("@Category_Name", SqlDbType.NVarChar, Txt_Category_name.Text),
                        new Pararmter("@User_ID", SqlDbType.Int, Login.UserID));
                    MessageBox.Show("تم تعديل فئة الصنف بنجاح", "تم", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AddNew = false;
                    Lbl_Cat_ID.Text = "L01";
                    BindGrid();

                }


            }



        }

        private void Btn_Delete_Click(object sender, EventArgs e)
        {

            if (Lbl_Cat_ID.Text != "L01")
            {


                if (MessageBox.Show("هل انت متأكد من حذف فئة الصنف ؟", "تاكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    RetriveData.ExcuteNonQuery("Sp_Item_Category_Delete", new Pararmter("@Category_ID", SqlDbType.Int, int.Parse(Lbl_Cat_ID.Text).ToString()));
                    MessageBox.Show("تم حذف فئة الصنف بنجاح", "تم", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AddNew = false;
                    Lbl_Cat_ID.Text = "L01";
                    BindGrid();
                    Txt_Category_name.Text = "";

                }

            }



        }

        private void DVGrid_Click(object sender, EventArgs e)
        {

        }

    }


}
