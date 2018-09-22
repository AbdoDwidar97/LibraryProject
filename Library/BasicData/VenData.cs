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
    public partial class VenData : Inherit
    {
        bool AddNew = false;
        Cl_Validate Txtclr = new Cl_Validate();

        void Bindcombo()
        {
            comboBox1.DataSource = RetriveData.ExcuteQuery("Sp_Vendors_SelectAll", CommandType.StoredProcedure);
            comboBox1.DisplayMember = "Ven_Name";
            comboBox1.ValueMember = "Ven_ID";
            comboBox1.Text = "";

        }

        public VenData()
        {
            InitializeComponent();
        }

        private void VenData_Load(object sender, EventArgs e)
        {
            Bindcombo();
        }

        private void Btn_New_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("هل انت متاكد من اضافة مورد جديد ؟", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Txtclr.TxtClear(this, panelControl3);
                AddNew = true;
            }

        }

        private void Btn_Save_Click(object sender, EventArgs e)
        {

            if (AddNew == false) { MessageBox.Show("من فضلك اضغط على زر جديد اولا !", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
            if (Txt_Name.Text == "" || Txt_Address.Text == "" || Txt_Mobile.Text == "") { MessageBox.Show("يجب على حضراتكم اكمال البيانات", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            if (MessageBox.Show("هل انت متاكد من حفظ مورد جديد ؟", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                RetriveData.ExcuteNonQuery("Sp_Vendors_Insert",
                    new Pararmter("@Ven_Name", SqlDbType.NVarChar, Txt_Name.Text),
                    new Pararmter("@Ven_Address", SqlDbType.NVarChar, Txt_Address.Text),
                    new Pararmter("@Ven_Mobile", SqlDbType.NVarChar, Txt_Mobile.Text),
                    new Pararmter("@Ven_Phone", SqlDbType.NVarChar, Txt_Phone.Text),
                    new Pararmter("@Ven_Notes", SqlDbType.NVarChar, Txt_Notes.Text),
                    new Pararmter("@User_ID", SqlDbType.NVarChar, Login.UserID));

                MessageBox.Show("تم حفظ المورد بنجاح", "تم", MessageBoxButtons.OK, MessageBoxIcon.Information);
                AddNew = false;
                Lbl_Cust_ID.Text = "L01";
                Bindcombo();

            }
        }

        private void Btn_Delete_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("هل انت متاكد من حذف هذاالمورد ؟", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {



                if (Lbl_Cust_ID.Text != "L01")
                {
                    RetriveData.ExcuteNonQuery("Sp_Vendors_Delete", new Pararmter("@Ven_ID", SqlDbType.Int, int.Parse(Lbl_Cust_ID.Text).ToString()));

                    MessageBox.Show("تم حذف المورد بنجاح", "تم", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AddNew = false;
                    Lbl_Cust_ID.Text = "L01";
                    Bindcombo();
                }


            }

        }

        private void Btn_Edit_Click(object sender, EventArgs e)
        {


            if (MessageBox.Show("هل انت متاكد من تعديل بيانات المورد ؟", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                if (Txt_Name.Text == "" || Txt_Address.Text == "" || Txt_Mobile.Text == "") { MessageBox.Show("يجب على حضراتكم اكمال البيانات", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

                if (Lbl_Cust_ID.Text != "L01")
                {


                    RetriveData.ExcuteNonQuery("Sp_Vendors_Update",
                        new Pararmter("@Ven_ID", SqlDbType.Int, int.Parse(Lbl_Cust_ID.Text).ToString()),
                        new Pararmter("@Ven_Name", SqlDbType.NVarChar, Txt_Name.Text),
                        new Pararmter("@Ven_Address", SqlDbType.NVarChar, Txt_Address.Text),
                        new Pararmter("@Ven_Mobile", SqlDbType.NVarChar, Txt_Mobile.Text),
                        new Pararmter("@Ven_Phone", SqlDbType.NVarChar, Txt_Phone.Text),
                        new Pararmter("@Ven_Notes", SqlDbType.NVarChar, Txt_Notes.Text),
                        new Pararmter("@User_ID", SqlDbType.NVarChar, Login.UserID));

                    MessageBox.Show("تم تعديل بيانات المورد بنجاح", "تم", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AddNew = false;
                    Lbl_Cust_ID.Text = "L01";
                    Bindcombo();

                }
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
                Dt = RetriveData.ExcuteQuery("Sp_Vendors_SelectByID", CommandType.StoredProcedure, new Pararmter("@Ven_ID", SqlDbType.Int, int.Parse(comboBox1.SelectedValue.ToString())));
                Lbl_Cust_ID.Text = Dt.Rows[0]["Ven_ID"].ToString();
                Txt_Name.Text = Dt.Rows[0]["Ven_Name"].ToString();
                Txt_Address.Text = Dt.Rows[0]["Ven_Address"].ToString();
                Txt_Mobile.Text = Dt.Rows[0]["Ven_Mobile"].ToString();
                Txt_Phone.Text = Dt.Rows[0]["Ven_Phone"].ToString();
                Txt_Notes.Text = Dt.Rows[0]["Ven_Notes"].ToString();

            }

        }





    }

}
