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
    public partial class distributeItems : Form
    {
        public void Bind_Cmb_StoreName()
        {
            Cmb_StoreName.DataSource = RetriveData.ExcuteQuery("Sp_Store_Data_SelectAll", CommandType.StoredProcedure);
            Cmb_StoreName.DisplayMember = "Store_Name";
            Cmb_StoreName.ValueMember = "Store_ID";

            Cmb_StoreName.Text = "";

        }

        public void Bind_Cmb_ItemName()
        {
            Cmb_ItemName.DataSource = RetriveData.ExcuteQuery("Sp_Items_SelectAll", CommandType.StoredProcedure);
            Cmb_ItemName.DisplayMember = "Item_Name";
            Cmb_ItemName.ValueMember = "Item_ID";

            Cmb_ItemName.Text = "";

        }

        DataTable PrepareDataTable()
        {
            if (DGV_Grid.RowCount > 0)
            {

                DataTable Dt = new DataTable();
                DataRow Dr;
                Dt.Columns.Add("Store_ID", typeof(int));
                Dt.Columns.Add("Item_ID", typeof(int));

                for (int i = 0; i < DGV_Grid.Rows.Count -1; i++)
                {
                    Dr = Dt.NewRow();
                    Dr[0] = DGV_Grid.Rows[i].Cells[0].Value.ToString();
                    Dr[1] = DGV_Grid.Rows[i].Cells[1].Value.ToString();
                    
                    Dt.Rows.Add(Dr);
                }
                return Dt;

            }
            else { return null; }
        }

        DBConnect Con = new DBConnect();


        public distributeItems()
        {
            InitializeComponent();
        }

        private void Btn_Close_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void distributeItems_Load(object sender, EventArgs e)
        {
            Bind_Cmb_ItemName();
            Bind_Cmb_StoreName();
        }

        private void Btn_Add_Click(object sender, EventArgs e)
        {
            if (Cmb_ItemName.Text == "" || Cmb_StoreName.Text == "") { MessageBox.Show("من فضلك يجب ملىء البيانات", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            DataGridViewRow Row = new DataGridViewRow();

            DataGridViewCell Cell1 = new DataGridViewTextBoxCell();
            DataGridViewCell Cell2 = new DataGridViewTextBoxCell();
            DataGridViewCell Cell3 = new DataGridViewTextBoxCell();
            DataGridViewCell Cell4 = new DataGridViewTextBoxCell();

            Row.Cells.Add(Cell1);
            Row.Cells.Add(Cell2);
            Row.Cells.Add(Cell3);
            Row.Cells.Add(Cell4);

            Row.Cells[0].Value = Cmb_StoreName.SelectedValue.ToString();
            Row.Cells[1].Value = Cmb_ItemName.SelectedValue.ToString();
            Row.Cells[2].Value = Cmb_StoreName.Text;
            Row.Cells[3].Value = Cmb_ItemName.Text;

            DGV_Grid.Rows.Add(Row);

        }

        private void Btn_Save_Click(object sender, EventArgs e)
        {
            DataTable dt = PrepareDataTable();
            if (dt.Rows.Count == 0) { MessageBox.Show("من فضلك يجب ملىء البيانات", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            if (dt.Rows.Count > 0)
            {
                Con.Comm.Connection = DBConnect.Conn;
                Con.Comm.CommandType = CommandType.StoredProcedure;
                Con.Comm.CommandText = "Sp_QuantityInsert";
                Con.Comm.Parameters.AddWithValue("@User_ID", Login.UserID);
                Con.Comm.Parameters.AddWithValue("@DistributeItems", dt);
                Con.Comm.ExecuteNonQuery();
                MessageBox.Show("تم الحفظ بنجاح", "تم", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void Btn_AutoDistribute_Click(object sender, EventArgs e)
        {
            RetriveData.ExcuteNonQuery("Sp_DistributeItemsAuto", new Pararmter("@User_ID", SqlDbType.Int, Login.UserID));

            MessageBox.Show("تم توزيع الاصناف بنجاح","تم",MessageBoxButtons.OK,MessageBoxIcon.Information);

        }
    }
}
