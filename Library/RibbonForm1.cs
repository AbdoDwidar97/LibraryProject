using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraBars;
using Library.BasicData;

namespace Library
{
    public partial class Rfrm1 : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Rfrm1()
        {
            InitializeComponent();
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            CustData frm = new CustData();
            frm.MdiParent = this;
            frm.Show();

        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            VenData frm = new VenData();
            frm.MdiParent = this;
            frm.Show();

        }

        private void barButtonItem12_ItemClick(object sender, ItemClickEventArgs e)
        {
            JobTypeData frm = new JobTypeData();
            frm.MdiParent = this;
            frm.Show();
        }

        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {
            EmpsData frm = new EmpsData();
            frm.MdiParent = this;
            frm.Show();
        }

        private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
        {
            ItemCategoryData frm = new ItemCategoryData();
            frm.MdiParent = this;
            frm.Show();
        }

        private void barButtonItem5_ItemClick(object sender, ItemClickEventArgs e)
        {
            ItemsData frm = new ItemsData();
            frm.MdiParent = this;
            frm.Show();
        }

        private void barButtonItem6_ItemClick(object sender, ItemClickEventArgs e)
        {
            StoreData frm = new StoreData();
            frm.MdiParent = this;
            frm.Show();
        }

        private void barButtonItem7_ItemClick(object sender, ItemClickEventArgs e)
        {
            StoreConvert frm = new StoreConvert();
            frm.MdiParent = this;
            frm.Show();
        }

        private void barButtonItem17_ItemClick(object sender, ItemClickEventArgs e)
        {
            distributeItems frm = new distributeItems();
            frm.MdiParent = this;
            frm.Show();
        }

        private void barButtonItem8_ItemClick(object sender, ItemClickEventArgs e)
        {
            OP.Purchases_Data frm = new OP.Purchases_Data();
            frm.MdiParent = this;
            frm.Show();
        }

        private void barButtonItem10_ItemClick(object sender, ItemClickEventArgs e)
        {
            OP.Sales_Data frm = new OP.Sales_Data();
            frm.MdiParent = this;
            frm.Show();
        }

        private void barButtonItem13_ItemClick(object sender, ItemClickEventArgs e)
        {
            OP.CustAccountData frm = new OP.CustAccountData();
            frm.MdiParent = this;
            frm.Show();
        }

        private void barButtonItem15_ItemClick(object sender, ItemClickEventArgs e)
        {
            OP.VenAccountData frm = new OP.VenAccountData();
            frm.MdiParent = this;
            frm.Show();
        }

        private void barButtonItem14_ItemClick(object sender, ItemClickEventArgs e)
        {
            OP.CustAccountPopUp frm = new OP.CustAccountPopUp();
            frm.MdiParent = this;
            frm.Show();
        }

        private void barButtonItem16_ItemClick(object sender, ItemClickEventArgs e)
        {
            OP.VenAccountPopUp frm = new OP.VenAccountPopUp();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}