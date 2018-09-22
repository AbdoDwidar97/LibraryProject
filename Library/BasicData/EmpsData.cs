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
    public partial class EmpsData : Inherit
    {

        bool AddNew = false;

        public void BindCmb_Search()
        {
            
            comboBox1.DataSource = RetriveData.ExcuteQuery("Sp_Emplyees_SelectAll", CommandType.StoredProcedure);
            comboBox1.DisplayMember = "Emp_Name";
            comboBox1.ValueMember = "Emp_ID";
            comboBox1.Text = "";

        }

        public void BindCmb_JobType()
        {
            
            Cmb_Job_Name.DataSource = RetriveData.ExcuteQuery("Sp_Job_Type_SelectAll", CommandType.StoredProcedure);
            Cmb_Job_Name.DisplayMember = "Job_Name";
            Cmb_Job_Name.ValueMember = "Job_ID";
            Cmb_Job_Name.Text = "";

        }
        
        public EmpsData()
        {
            InitializeComponent();
        }

        private void EmpsData_Load(object sender, EventArgs e)
        {

            BindCmb_JobType();
            BindCmb_Search();
            
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Btn_New_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل انت متاكد من اضافة موظف جديد ؟", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Cl_Validate TxtClr = new Cl_Validate();
                TxtClr.TxtClear(this, panelControl3);
                AddNew = true;

            }
        }

        private void Btn_Save_Click(object sender, EventArgs e)
        {
            if (AddNew == false) { MessageBox.Show("من فضلك يجب الضغط على زر جديد اولا", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }

            if (Txt_Name.Text == "" || Txt_Address.Text == "" || Txt_BasicSalary.Text == "" || Txt_Mobile.Text == "" || Txt_PersonalID.Text == "" || Txt_Phone.Text == "" || Cmb_Job_Name.Text == "")
            { MessageBox.Show("من فضلك يجب ملىء جميع البيانات", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

            if (MessageBox.Show("هل انت متاكد من حفظ بيانات الموظف ؟", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                RetriveData.ExcuteNonQuery("Sp_Emplyees_Insert",
                    new Pararmter("@Emp_Name", SqlDbType.NVarChar, Txt_Name.Text),
                    new Pararmter("@Job_ID", SqlDbType.Int, Cmb_Job_Name.SelectedValue),
                    new Pararmter("@Emp_Mobile", SqlDbType.Int,int.Parse(Txt_Mobile.Text)),
                    new Pararmter("@Emp_Phone", SqlDbType.Int,int.Parse(Txt_Phone.Text)),
                    new Pararmter("@Emp_Address", SqlDbType.NVarChar, Txt_Address.Text),
                    new Pararmter("@Personal_ID", SqlDbType.Int,int.Parse(Txt_PersonalID.Text)),
                    new Pararmter("@Basic_Salary", SqlDbType.Int,decimal.Parse(Txt_BasicSalary.Text)),
                    new Pararmter("@User_ID", SqlDbType.Int, Login.UserID));

                MessageBox.Show("تم حفظ بيانات الموظف بنجاح", "تم", MessageBoxButtons.OK, MessageBoxIcon.Information);

                AddNew = false;
                Lbl_Cust_ID.Text = "L01";
                BindCmb_Search();

            }
        }

        private void Btn_Delete_Click(object sender, EventArgs e)
        {
            if (Lbl_Cust_ID.Text != "L01")
            {
                if (MessageBox.Show("هل انت متاكد من حفظ بيانات الموظف ؟", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    RetriveData.ExcuteNonQuery("Sp_Emplyees_Delete", new Pararmter("@Emp_ID", SqlDbType.Int, int.Parse(Lbl_Cust_ID.Text)));

                    MessageBox.Show("تم حذف الموظف بنجاح", "تم", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    AddNew = false;
                    Lbl_Cust_ID.Text = "L01";
                    BindCmb_Search();
                }
            }
        }

        private void Btn_Search_Click(object sender, EventArgs e)
        {

            if (comboBox1.Text == "") { MessageBox.Show("من فضلك يجب اختيار اسم الموظف", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            DataTable Dt = new DataTable();
            Dt = RetriveData.ExcuteQuery("Sp_Emplyees_SelectByID", CommandType.StoredProcedure,
                 new Pararmter("@Emp_ID", SqlDbType.Int,comboBox1.SelectedValue));

            Lbl_Cust_ID.Text = Dt.Rows[0]["Emp_ID"].ToString();
            Txt_Name.Text = Dt.Rows[0]["Emp_Name"].ToString();
            Txt_Address.Text = Dt.Rows[0]["Emp_Address"].ToString();
            Txt_Mobile.Text = Dt.Rows[0]["Emp_Mobile"].ToString();
            Txt_Phone.Text = Dt.Rows[0]["Emp_Phone"].ToString();
            Txt_PersonalID.Text = Dt.Rows[0]["personal_ID"].ToString();
            Txt_BasicSalary.Text = Dt.Rows[0]["Basic_Salary"].ToString();
            Cmb_Job_Name.SelectedValue = Dt.Rows[0]["Job_ID"];


        }

        private void Btn_Edit_Click(object sender, EventArgs e)
        {
            if (Lbl_Cust_ID.Text != "L01")
            {
                if (Txt_Name.Text == "" || Txt_Address.Text == "" || Txt_BasicSalary.Text == "" || Txt_Mobile.Text == "" || Txt_PersonalID.Text == "" || Txt_Phone.Text == "" || Cmb_Job_Name.Text == "")
                { MessageBox.Show("من فضلك يجب ملىء جميع البيانات", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

                if (MessageBox.Show("هل انت متاكد من تعديل بيانات الموظف ؟", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    RetriveData.ExcuteNonQuery("Sp_Emplyees_Update",
                    new Pararmter("@Emp_ID",SqlDbType.Int,int.Parse(Lbl_Cust_ID.Text.ToString())),
                    new Pararmter("@Emp_Name", SqlDbType.NVarChar, Txt_Name.Text),
                    new Pararmter("@Job_ID", SqlDbType.Int, Cmb_Job_Name.SelectedValue),
                    new Pararmter("@Emp_Mobile", SqlDbType.Int, int.Parse(Txt_Mobile.Text)),
                    new Pararmter("@Emp_Phone", SqlDbType.Int, int.Parse(Txt_Phone.Text)),
                    new Pararmter("@Emp_Address", SqlDbType.NVarChar, Txt_Address.Text),
                    new Pararmter("@Personal_ID", SqlDbType.Int, int.Parse(Txt_PersonalID.Text.ToString())),
                    new Pararmter("@Basic_Salary",SqlDbType.Int,decimal.Parse(Txt_BasicSalary.Text)),
                    new Pararmter("@User_ID", SqlDbType.Int, Login.UserID));
                    
                    MessageBox.Show("تم تعديل بيانات الموظف بنجاح", "تم", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    AddNew = false;
                    Lbl_Cust_ID.Text = "L01";
                    BindCmb_Search();
                }
            }
        }

        private void Btn_Close_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
