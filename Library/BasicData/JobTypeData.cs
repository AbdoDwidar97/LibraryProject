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
    public partial class JobTypeData : Form
    {

        bool AddNew = false;
        public void BindGrid()
        {
            DataTable dt = new DataTable();
            dt = RetriveData.ExcuteQuery("Sp_Job_Type_SelectAll", CommandType.StoredProcedure);

            DVGrid.DataSource = dt;

        }
        public JobTypeData()
        {
            InitializeComponent();
        }

        private void JobTypeData_Load(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void panelControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Btn_New_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل انت متأكد من اضافة وظيفة جديدة؟", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                AddNew = true;
                Txt_Job_Name.Text = "";
                BindGrid();
                Lbl_Job_ID.Text = "L01";

            }
        }

        private void Btn_Save_Click(object sender, EventArgs e)
        {

            if (AddNew == false) { MessageBox.Show("من فضلك يجب الضغط على زر جديد اولا ", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
            if (Txt_Job_Name.Text == "") { MessageBox.Show("من فضلك يجب كتابة اسم الوظيفة","خطأ",MessageBoxButtons.OK,MessageBoxIcon.Error); return; }
            if (MessageBox.Show("هل انت متأكد من حفظ وظيفة جديدة؟", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                RetriveData.ExcuteNonQuery("Sp_Job_Type_Insert",
                    new Pararmter("@Job_Name", SqlDbType.NVarChar, Txt_Job_Name.Text),
                    new Pararmter("@User_ID", SqlDbType.NVarChar, Login.UserID));

                MessageBox.Show("تم حفظ الوظيفة بنجاح","تم",MessageBoxButtons.OK,MessageBoxIcon.Information);
                AddNew = false;
                BindGrid();

            }
        }

        private void DVGrid_EditorKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Lbl_Job_ID.Text = gridView1.GetFocusedRowCellValue("Job_ID").ToString();
                Txt_Job_Name.Text = gridView1.GetFocusedRowCellValue("Job_Name").ToString();
            }
        }

        private void Btn_Edit_Click(object sender, EventArgs e)
        {
            if (Lbl_Job_ID.Text == "L01") { return; }
            if (Txt_Job_Name.Text == "") { MessageBox.Show("من فضلك يجب كتابة اسم الوظيفة", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
            if (MessageBox.Show("هل انت متأكد من تعديل الوظيفة؟", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    RetriveData.ExcuteNonQuery("Sp_Job_Type_Update",
                        new Pararmter("@Job_ID", SqlDbType.Int, int.Parse(Lbl_Job_ID.Text).ToString()),
                        new Pararmter("@Job_Name", SqlDbType.NVarChar, Txt_Job_Name.Text),
                        new Pararmter("@User_ID", SqlDbType.Int, Login.UserID));

                    MessageBox.Show("تم تعديل الوظيفة بنجاح","تم",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    AddNew = false;
                    BindGrid();
                    Lbl_Job_ID.Text = "L01";
                }
        }

        private void Btn_Close_Click(object sender, EventArgs e)
        {
            this.Dispose();

        }

        private void Btn_Delete_Click(object sender, EventArgs e)
        {
            if (Lbl_Job_ID.Text == "L01") { return; }
            if (MessageBox.Show("هل انت متأكد من حذف الوظيفة؟", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                RetriveData.ExcuteNonQuery("Sp_Job_Type_Delete",
                    new Pararmter("@Job_ID", SqlDbType.Int, int.Parse(Lbl_Job_ID.Text).ToString()));
                MessageBox.Show("تم حذف الوظيفة بنجاح","تم",MessageBoxButtons.OK,MessageBoxIcon.Information);
                BindGrid();
                AddNew = false;
                Lbl_Job_ID.Text = "L01";
                Txt_Job_Name.Text = "";
 
            }
        }
    }
}
