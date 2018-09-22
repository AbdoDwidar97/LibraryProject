using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Library.DAL
{
    class Cl_Validate
    {



        public void TxtClear(Form frm , DevExpress.XtraEditors.PanelControl pnl)
        {
            foreach (Control item in frm.Controls)
            {
                if (item is DevExpress.XtraEditors.PanelControl)
                {
                    foreach (Control itemControl in pnl.Controls)
                    {
                        if (itemControl is DevExpress.XtraEditors.TextEdit) { itemControl.Text = ""; }
                        if (itemControl is TextBox) { itemControl.Text = ""; }
                    }

                    
                    if (item is ComboBox) { item.Text = ""; }
                }
                
            }
        }



    }
}
