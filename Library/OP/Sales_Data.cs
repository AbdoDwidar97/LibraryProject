using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Library.DAL;
using System.Data.SqlClient;
using Library.Reports;

namespace Library.OP
{
    public partial class Sales_Data : Form
    {

        bool AddNew = false;

        public void CalcReamin()
        {
            Txt_Remain.Text = (double.Parse(Txt_Total.Text) - double.Parse(Txt_Payed.Text)).ToString();
        }

        public void Bind_Cmbs()
        {
            Cmb_CustName.DataSource = RetriveData.ExcuteQuery("Sp_Customers_SelectAll", CommandType.StoredProcedure);
            Cmb_CustName.DisplayMember = "Cust_Name";
            Cmb_CustName.ValueMember = "Cust_ID";
            Cmb_CustName.Text = "";



            Cmb_StoreName.DataSource = RetriveData.ExcuteQuery("Sp_Store_Data_SelectAll", CommandType.StoredProcedure);
            Cmb_StoreName.DisplayMember = "Store_Name";
            Cmb_StoreName.ValueMember = "Store_ID";
            Cmb_StoreName.Text = "";


            Cmb_CategoryName.DataSource = RetriveData.ExcuteQuery("Sp_Item_Category_selectAll", CommandType.StoredProcedure);
            Cmb_CategoryName.DisplayMember = "Category_Name";
            Cmb_CategoryName.ValueMember = "Category_ID";
            Cmb_CategoryName.Text = "";




        }

        public void Bind_Filter_Items()
        {
            Cmb_ItemName.DataSource = RetriveData.ExcuteQuery("Sp_Store_Convert_SelectByCategoryID", CommandType.StoredProcedure,
                new Pararmter("@Category_ID", SqlDbType.Int, int.Parse(Cmb_CategoryName.SelectedValue.ToString())));

            Cmb_ItemName.DisplayMember = "Item_Name";
            Cmb_ItemName.ValueMember = "Item_ID";

            Cmb_ItemName.Text = "";
        }

        public void calcValue()
        {
            if (Txt_Price.Text == "") { Txt_Price.Text = "0"; }
            if (Txt_Quantity.Text == "") { Txt_Quantity.Text = "0"; }
            double RE = double.Parse(Txt_Price.Text) * double.Parse(Txt_Quantity.Text);
            Txt_Value.Text = RE.ToString();
        }

        public void CalcTotal()
        {
            Txt_Total.Text = "";
            if (Txt_Total.Text == "") { Txt_Total.Text = "0"; }
            for (int i = 0; i < DGV_Grid.Rows.Count; i++)
            {
                Txt_Total.Text = (double.Parse(Txt_Total.Text) + double.Parse(DGV_Grid.Rows[i].Cells[6].Value.ToString())).ToString();
            }
        }

        public DataTable PrepareData()
        {
            if (DGV_Grid.RowCount > 0)
            {
                DataTable Dt = new DataTable();
                DataRow Dr;

                Dt.Columns.Add("Category_ID", typeof(int));
                Dt.Columns.Add("Item_ID", typeof(int));
                Dt.Columns.Add("Sales_Price", typeof(decimal));
                Dt.Columns.Add("Item_quantity", typeof(int));
                Dt.Columns.Add("Item_Value", typeof(decimal));

                for (int i = 0; i < DGV_Grid.Rows.Count; i++)
                {
                    Dr = Dt.NewRow();
                    Dr[0] = DGV_Grid.Rows[i].Cells[0].Value.ToString();
                    Dr[1] = DGV_Grid.Rows[i].Cells[1].Value.ToString();
                    Dr[2] = DGV_Grid.Rows[i].Cells[4].Value.ToString();
                    Dr[3] = DGV_Grid.Rows[i].Cells[5].Value.ToString();
                    Dr[4] = DGV_Grid.Rows[i].Cells[6].Value.ToString();
                    Dt.Rows.Add(Dr);

                }
                return Dt;
            }
            else { return null; }
        }



        public Sales_Data()
        {
            InitializeComponent();
        }

        private void Sales_Data_Load(object sender, EventArgs e)
        {
            Bind_Cmbs();
        }

        private void Cmb_CategoryName_SelectedValueChanged(object sender, EventArgs e)
        {
            if (Cmb_CategoryName.SelectedValue.ToString() == "System.Data.DataRowView")
            {
                return;
            }
            Bind_Filter_Items();
        }

        private void Txt_Price_EditValueChanged(object sender, EventArgs e)
        {
            calcValue();
        }

        private void Txt_Quantity_EditValueChanged(object sender, EventArgs e)
        {
            calcValue();
        }

        private void Txt_Value_EditValueChanged(object sender, EventArgs e)
        {
            calcValue();
        }

        private void Btn_Add_Click(object sender, EventArgs e)
        {

            if (Cmb_ItemName.Text == "" || Cmb_CategoryName.Text == "" || Txt_Quantity.Text == "" || Txt_Price.Text == "" || Txt_Value.Text == "") { MessageBox.Show("من فضلك يجب ملىء البيانات", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            DataGridViewRow Row = new DataGridViewRow();

            DataGridViewCell Cell1 = new DataGridViewTextBoxCell();
            DataGridViewCell Cell2 = new DataGridViewTextBoxCell();
            DataGridViewCell Cell3 = new DataGridViewTextBoxCell();
            DataGridViewCell Cell4 = new DataGridViewTextBoxCell();
            DataGridViewCell Cell5 = new DataGridViewTextBoxCell();
            DataGridViewCell Cell6 = new DataGridViewTextBoxCell();
            DataGridViewCell Cell7 = new DataGridViewTextBoxCell();

            Row.Cells.Add(Cell1);
            Row.Cells.Add(Cell2);
            Row.Cells.Add(Cell3);
            Row.Cells.Add(Cell4);
            Row.Cells.Add(Cell5);
            Row.Cells.Add(Cell6);
            Row.Cells.Add(Cell7);

            Row.Cells[0].Value = Cmb_CategoryName.SelectedValue.ToString();
            Row.Cells[1].Value = Cmb_ItemName.SelectedValue.ToString();
            Row.Cells[2].Value = Cmb_CategoryName.Text;
            Row.Cells[3].Value = Cmb_ItemName.Text;
            Row.Cells[4].Value = Txt_Price.Text;
            Row.Cells[5].Value = Txt_Quantity.Text;
            Row.Cells[6].Value = Txt_Value.Text;

            DGV_Grid.Rows.Add(Row);

            CalcTotal();

        }

        private void Btn_New_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل انت متأكد من اضافة عملية الشراء ؟", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Cl_Validate Clr = new Cl_Validate();
                Clr.TxtClear(this, panelControl1);
                Clr.TxtClear(this, panelControl2);
                AddNew = true;

            }
        }

        DBConnect ccon = new DBConnect();
        private void Btn_Save_Click(object sender, EventArgs e)
        {
            if (AddNew == false) { MessageBox.Show("يجب الضغط على زر جديد اولا", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
            if((MessageBox.Show("هل انت متأكد من حفظ عمليةالشراء ؟", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
            {

            DataTable ddt = PrepareData();
            ccon.Comm.Connection = DBConnect.Conn;
            ccon.Comm.CommandType = CommandType.StoredProcedure;
            ccon.Comm.CommandText = "Sp_SalesInsert";
            ccon.Comm.Parameters.Clear();

            ccon.Comm.Parameters.AddWithValue("@Cust_ID",int.Parse(Cmb_CustName.SelectedValue.ToString()));
            ccon.Comm.Parameters.AddWithValue("@Sales_Date",DateTime.Parse(DTP_Purchase.Text));
            ccon.Comm.Parameters.AddWithValue("@Total_Value", double.Parse(Txt_Total.Text));
            ccon.Comm.Parameters.AddWithValue("@Payed_Value",double.Parse(Txt_Payed.Text));
            ccon.Comm.Parameters.AddWithValue("@Remain_Value", double.Parse(Txt_Remain.Text));
            ccon.Comm.Parameters.AddWithValue("@Sales_Notes", Txt_Notes.Text);
            ccon.Comm.Parameters.AddWithValue("@User_ID", Login.UserID);
            ccon.Comm.Parameters.AddWithValue("@Store_ID", int.Parse(Cmb_StoreName.SelectedValue.ToString()));
            ccon.Comm.Parameters.AddWithValue("@SalesDataTable", PrepareData());
            ccon.Comm.ExecuteNonQuery();
            MessageBox.Show("تم الحفظ بنجاح","تم",MessageBoxButtons.OK,MessageBoxIcon.Information);

            AddNew = false;



            if ((MessageBox.Show("هل تريد طباعة عمليةالشراء ؟", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
            {
                DBConnect Connn = new DBConnect();
                Connn.Comm.Connection = DBConnect.Conn;
                Connn.Comm.CommandType = CommandType.StoredProcedure;
                Connn.Comm.CommandText = "Sp_MainSalesSelectMax";

                SqlDataAdapter Da = new SqlDataAdapter(Connn.Comm);
                DataSet Ds = new DataSet();
                Da.Fill(Ds,"BillSales");

                BillReport_Sales Rpt = new BillReport_Sales();
                Rpt.SetDataSource(Ds.Tables["BillSales"]);

                Frm_Report Frm = new Frm_Report();
                Frm.crystalReportViewer1.ReportSource = Rpt;

                Frm.ShowDialog();


            }


            }
        }

        private void Btn_Close_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Txt_Payed_EditValueChanged(object sender, EventArgs e)
        {
            CalcReamin();
        }

        private void Btn_Report_Click(object sender, EventArgs e)
        {
            DBConnect Connn = new DBConnect();
            Connn.Comm.Connection = DBConnect.Conn;
            Connn.Comm.CommandType = CommandType.StoredProcedure;
            Connn.Comm.CommandText = "Sp_MainSalesSelectMax";

            SqlDataAdapter Da = new SqlDataAdapter(Connn.Comm);
            DataSet Ds = new DataSet();
            Da.Fill(Ds, "BillSales");

            BillReport_Sales Rpt = new BillReport_Sales();
            Rpt.SetDataSource(Ds.Tables["BillSales"]);

            Frm_Report Frm = new Frm_Report();
            Frm.crystalReportViewer1.ReportSource = Rpt;

            Frm.ShowDialog();

        }
    }
}
