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
    public partial class StoreData : Inherit
    {

        bool AddNew = false;

        Cl_Validate TxtClr = new Cl_Validate();

        public void Bind_Emp_Name()
        {
            DataTable Dt = new DataTable();
            Dt = RetriveData.ExcuteQuery("Sp_Emplyees_SelectAll", CommandType.StoredProcedure);

            Cmb_Emp_Name.DataSource = Dt;

            Cmb_Emp_Name.DisplayMember = "Emp_Name";
            Cmb_Emp_Name.ValueMember = "Emp_ID";

            Cmb_Emp_Name.Text = "";
        }

        public void Bind_StoreSearch()
        {
            comboBox1.DataSource = RetriveData.ExcuteQuery("Sp_Store_Data_SelectAll", CommandType.StoredProcedure);
            comboBox1.DisplayMember = "Store_Name";
            comboBox1.ValueMember = "Store_ID";

            comboBox1.Text = "";

        }



        public StoreData()
        {
            InitializeComponent();
        }

        private void StoreData_Load(object sender, EventArgs e)
        {
            Bind_Emp_Name();
            Bind_StoreSearch();
        }

        private void Btn_New_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("هل انت متاكد من اضافة مخزن جديد ؟", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                AddNew = true;
                TxtClr.TxtClear(this, panelControl3);
                Cmb_Emp_Name.Text = "";
            }

        }

        private void Btn_Save_Click(object sender, EventArgs e)
        {
            if (AddNew == false) { MessageBox.Show("من فضلك جيب الضغط على زر جديد اولا", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
            if (Txt_Name.Text == "" || Txt_Address.Text == "" || Cmb_Emp_Name.Text == "") { MessageBox.Show("من فضلك يجب ملىء جميع البيانات", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

            if (MessageBox.Show("هل انت متاكد من حفظ بيانات المخزن جديد ؟", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                RetriveData.ExcuteNonQuery("Sp_Store_Data_Insert",
                    new Pararmter("@Store_Name", SqlDbType.NVarChar, Txt_Name.Text),
                    new Pararmter("@Emp_ID", SqlDbType.Int, Cmb_Emp_Name.SelectedValue),
                    new Pararmter("@Store_Address", SqlDbType.NVarChar, Txt_Address.Text),
                    new Pararmter("@Store_Notes", SqlDbType.NVarChar, Txt_Notes.Text),
                    new Pararmter("@User_ID", SqlDbType.Int, Login.UserID));

                MessageBox.Show("تم حفظ بيانات المخزن بنجاح","تم",MessageBoxButtons.OK,MessageBoxIcon.Information);
                AddNew = false;
                Lbl_Cust_ID.Text = "L01";
                Bind_StoreSearch();

            }
        }

        private void Btn_Close_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Btn_Search_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text != "")
            {
                DataTable Dt = new DataTable();
                Dt = RetriveData.ExcuteQuery("Sp_Store_Data_selectByID", CommandType.StoredProcedure,new Pararmter("@Store_ID",SqlDbType.Int,comboBox1.SelectedValue));

                Lbl_Cust_ID.Text = Dt.Rows[0]["Store_ID"].ToString();
                Txt_Address.Text = Dt.Rows[0]["Store_Address"].ToString();
                Txt_Name.Text = Dt.Rows[0]["store_Name"].ToString();
                Txt_Notes.Text = Dt.Rows[0]["Store_Notes"].ToString();
                Cmb_Emp_Name.SelectedValue = Dt.Rows[0]["Emp_ID"];

            }
        }

        private void Btn_Edit_Click(object sender, EventArgs e)
        {
            if (Lbl_Cust_ID.Text != "l01")
            {
                if (Txt_Name.Text == "" || Txt_Address.Text == "" || Cmb_Emp_Name.Text == "") { MessageBox.Show("من فضلك يجب ملىء جميع البيانات", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
                
                if (MessageBox.Show("هل انت متاكد من تعديل بيانات المخزن ؟", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    RetriveData.ExcuteNonQuery("Sp_Store_Data_Update",
                        new Pararmter("@Store_ID",SqlDbType.Int,int.Parse(Lbl_Cust_ID.Text.ToString())),
                        new Pararmter("@Store_Name", SqlDbType.NVarChar, Txt_Name.Text),
                        new Pararmter("@Emp_ID", SqlDbType.Int, Cmb_Emp_Name.SelectedValue),
                        new Pararmter("@Store_Address", SqlDbType.NVarChar, Txt_Address.Text),
                        new Pararmter("@Store_Notes", SqlDbType.NVarChar, Txt_Notes.Text),
                        new Pararmter("@User_ID", SqlDbType.Int, Login.UserID));

                    MessageBox.Show("تم تعديل بيانات المخزن بنجاح", "تم", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AddNew = false;
                    Lbl_Cust_ID.Text = "L01";
                    Bind_StoreSearch();

                }
            }
        }

        private void Btn_Delete_Click(object sender, EventArgs e)
        {
            if (Lbl_Cust_ID.Text != "L01")
            {
                if (MessageBox.Show("هل انت متاكد من حذف بيانات المخزن ؟", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    RetriveData.ExcuteNonQuery("Sp_Store_Data_Delete", new Pararmter("@Store_ID", SqlDbType.Int, int.Parse(Lbl_Cust_ID.Text.ToString())));

                    MessageBox.Show("تم حذف بيانات المخزن بنجاح", "تم", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AddNew = false;
                    Lbl_Cust_ID.Text = "L01";
                    Bind_StoreSearch();

                    TxtClr.TxtClear(this, panelControl3);
                    Cmb_Emp_Name.Text = "";

                }
            }
        }
    }
}
