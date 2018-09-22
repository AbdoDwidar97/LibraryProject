using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Library.DAL;

namespace Library.OP
{
    public partial class VenAccountData : Form
    {

        void Bindcombo()
        {
            Cmb_Search.DataSource = RetriveData.ExcuteQuery("Sp_Vendors_SelectAll", CommandType.StoredProcedure);
            Cmb_Search.DisplayMember = "Ven_Name";
            Cmb_Search.ValueMember = "Ven_ID";
            Cmb_Search.Text = "";

        }

        bool AddNew = false;

        public VenAccountData()
        {
            InitializeComponent();
        }

        private void VenAccountData_Load(object sender, EventArgs e)
        {
            Bindcombo();
        }

        private void Btn_Search_Click(object sender, EventArgs e)
        {
            if (Cmb_Search.Text != "")
            {
                DataTable Dt = new DataTable();
                Dt = RetriveData.ExcuteQuery("Sp_Vendors_SelectByID", CommandType.StoredProcedure, new Pararmter("@Ven_ID", SqlDbType.Int, int.Parse(Cmb_Search.SelectedValue.ToString())));
                Lbl_Find.Text = Dt.Rows[0]["Ven_ID"].ToString();
                Txt_RemainValue.Text = Dt.Rows[0]["Ven_Debit"].ToString();


            }
        }

        private void Btn_New_Click(object sender, EventArgs e)
        {


            if (MessageBox.Show("هل انت متأكد من اضافة هذه العملية ؟", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Cl_Validate Txtclr = new Cl_Validate();
                Txtclr.TxtClear(this, panelControl1);
                AddNew = true;

            }



        }

        private void Btn_Close_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Btn_Save_Click(object sender, EventArgs e)
        {

            if (AddNew == false) { MessageBox.Show("عفوا ، يجب الضغط على زر جديد اولا", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            if (Double.Parse(Txt_RemainValue.Text) == 0) { MessageBox.Show("عفوا ، هذا العميل ليس عليه دين", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
            if (Txt_PayedValue.Text == "") { MessageBox.Show("من فضلك ادخل المبلغ المدفوع", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
            if (Double.Parse(Txt_PayedValue.Text) > double.Parse(Txt_RemainValue.Text)) { MessageBox.Show("المبلغ المدفوع اكبر من المبلغ المتبقى", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }

            if (MessageBox.Show("هل انت متأكد من حفظ هذه العملية ؟", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                RetriveData.ExcuteNonQuery("Sp_Ven_Account_Insert",
                    new Pararmter("@Ven_ID", SqlDbType.Int, int.Parse(Cmb_Search.SelectedValue.ToString())),
                    new Pararmter("@Payed_Value", SqlDbType.Decimal, decimal.Parse(Txt_PayedValue.Text)),
                    new Pararmter("@Payed_Date", SqlDbType.Date, DTP.Text),
                    new Pararmter("@Account_Notes", SqlDbType.NVarChar, Txt_Notes.Text),
                    new Pararmter("@User_ID", SqlDbType.NVarChar, Login.UserID));

                MessageBox.Show("تم الحفظ بنجاح", "تم", MessageBoxButtons.OK, MessageBoxIcon.Information);
                AddNew = false;
                Lbl_Find.Text = "L01";


            }
        }
    }
}
