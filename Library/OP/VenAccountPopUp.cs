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
    public partial class VenAccountPopUp : Form
    {
        
        public void BindGrid()
        {
            DataTable Dt = new DataTable();
            Dt = RetriveData.ExcuteQuery("Sp_Ven_Account_SelectAll", CommandType.StoredProcedure);

            DVGrid.DataSource = Dt;

        }

        public VenAccountPopUp()
        {
            InitializeComponent();
        }

        private void VenAccountPopUp_Load(object sender, EventArgs e)
        {
            BindGrid();
        }
    }
}
