using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineStore
{
    public partial class MainAppForm : Form
    {
        CustomerInfo custInfo;
        public MainAppForm()
        {
            custInfo = CustomerInfo.getSample();
            InitializeComponent();
        }

        private void MainAppForm_Load(object sender, EventArgs e)
        {
            sidePanel.Height = btn_MyProfile.Height;
            pictureBox1.Image = custInfo.Customerimage;
        }

        private void btn_MyProfile_Click(object sender, EventArgs e)
        {
            this.Hide();
            sidePanel.Height = btn_MyProfile.Height;
            sidePanel.Top = btn_MyProfile.Top;
            CustomerProfile custProf = new CustomerProfile();
            custProf.ShowDialog();
        }

        private void btn_ShoppingChart_Click(object sender, EventArgs e)
        {
            sidePanel.Height = btn_ShoppingChart.Height;
            sidePanel.Top = btn_ShoppingChart.Top;
        }

        private void btn_MyPurchase_Click(object sender, EventArgs e)
        {
            sidePanel.Height = btn_MyPurchase.Height;
            sidePanel.Top = btn_MyPurchase.Top;
        }

        private void btn_Collection_Click(object sender, EventArgs e)
        {
            sidePanel.Height = btn_Collection.Height;
            sidePanel.Top = btn_Collection.Top;
        }

        private void btn_Delivery_Click(object sender, EventArgs e)
        {
            sidePanel.Height = btn_Delivery.Height;
            sidePanel.Top = btn_Delivery.Top;
        }

        private void btb_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Smooth_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
