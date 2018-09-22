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
    public partial class CustData : Inherit
    {
        public CustData()
        {
            InitializeComponent();
        }

        Cl_Validate Txtclr = new Cl_Validate();
        
        bool AddNew = false;

        void Bindcombo()
        {
            comboBox1.DataSource = RetriveData.ExcuteQuery("Sp_Customers_SelectAll", CommandType.StoredProcedure);
            comboBox1.DisplayMember = "Cust_Name";
            comboBox1.ValueMember = "cust_ID";
            comboBox1.Text = "";
 
        }

        private void CustData_Load(object sender, EventArgs e)
        {
            Bindcombo();
        }

        private void Btn_New_Click(object sender, EventArgs e)
        {

        }

        private void Btn_New_Click_1(object sender, EventArgs e)
        {
            if(MessageBox.Show("هل انت متاكد من اضافة عميل جديد ؟","تأكيد",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Txtclr.TxtClear(this,panelControl3);
                AddNew = true;
            }
        }

        private void Btn_Save_Click(object sender, EventArgs e)
        {
            if (AddNew == false) { MessageBox.Show("من فضلك اضغط على زر جديد اولا !", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
            if (Txt_Name.Text == "" || Txt_Address.Text == "" || Txt_Mobile.Text == "") { MessageBox.Show("يجب على حضراتكم اكمال البيانات", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            if (MessageBox.Show("هل انت متاكد من حفظ عميل جديد ؟", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                
                RetriveData.ExcuteNonQuery("Sp_Customers_Insert",
                    new Pararmter("@Cust_Name",SqlDbType.NVarChar,Txt_Name.Text),
                    new Pararmter("@Cust_Address",SqlDbType.NVarChar,Txt_Address.Text),
                    new Pararmter("@Mobile",SqlDbType.NVarChar,Txt_Mobile.Text),
                    new Pararmter("@Phone",SqlDbType.NVarChar,Txt_Phone.Text),
                    new Pararmter("@Notes",SqlDbType.NVarChar,Txt_Notes.Text),
                    new Pararmter("@User_ID",SqlDbType.NVarChar,Login.UserID));

                MessageBox.Show("تم حفظ العميل بنجاح","تم",MessageBoxButtons.OK,MessageBoxIcon.Information);
                AddNew = false;
                Lbl_Cust_ID.Text = "L01";
                Bindcombo();
            }
        }

        private void Btn_Search_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text != "")
            {
                DataTable Dt = new DataTable();
                Dt = RetriveData.ExcuteQuery("Sp_Customers_SelectByID", CommandType.StoredProcedure, new Pararmter("@Cust_ID", SqlDbType.Int, int.Parse(comboBox1.SelectedValue.ToString())));
                Lbl_Cust_ID.Text = Dt.Rows[0]["Cust_ID"].ToString();
                Txt_Name.Text = Dt.Rows[0]["cust_Name"].ToString();
                Txt_Address.Text = Dt.Rows[0]["Cust_Address"].ToString();
                Txt_Mobile.Text = Dt.Rows[0]["Mobile"].ToString();
                Txt_Phone.Text = Dt.Rows[0]["Phone"].ToString();
                Txt_Notes.Text = Dt.Rows[0]["Notes"].ToString();

            }
        }

        private void Btn_Close_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Btn_Edit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل انت متاكد من تعديل بيانات العميل ؟", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                if (Txt_Name.Text == "" || Txt_Address.Text == "" || Txt_Mobile.Text == "") { MessageBox.Show("يجب على حضراتكم اكمال البيانات", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
                
                if (Lbl_Cust_ID.Text != "L01")
                {


                    RetriveData.ExcuteNonQuery("Sp_Customers_Update",
                        new Pararmter("@Cust_ID",SqlDbType.Int,int.Parse(Lbl_Cust_ID.Text).ToString()),
                        new Pararmter("@Cust_Name",SqlDbType.NVarChar,Txt_Name.Text),
                        new Pararmter("@Cust_Address",SqlDbType.NVarChar,Txt_Address.Text),
                        new Pararmter("@Mobile",SqlDbType.NVarChar,Txt_Mobile.Text),
                        new Pararmter("@Phone",SqlDbType.NVarChar,Txt_Phone.Text),
                        new Pararmter("@Notes",SqlDbType.NVarChar,Txt_Notes.Text),
                        new Pararmter("@User_ID",SqlDbType.NVarChar,Login.UserID));

                    MessageBox.Show("تم تعديل بيانات العميل بنجاح", "تم", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AddNew = false;
                    Lbl_Cust_ID.Text = "L01";
                    Bindcombo();

                }
            }
        }

        private void Btn_Delete_Click(object sender, EventArgs e)
        {


            if (MessageBox.Show("هل انت متاكد من حذف هذاالعميل ؟", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {



                if (Lbl_Cust_ID.Text != "L01")
                {
                    RetriveData.ExcuteNonQuery("Sp_Customers_Delete",new Pararmter("@Cust_ID",SqlDbType.Int,int.Parse(Lbl_Cust_ID.Text).ToString()));

                    MessageBox.Show("تم حذف العميل بنجاح", "تم", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AddNew = false;
                    Lbl_Cust_ID.Text = "L01";
                    Bindcombo();
                }



            }


        }

        private void panelControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
