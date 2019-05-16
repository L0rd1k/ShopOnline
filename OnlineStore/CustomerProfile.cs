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
    public partial class CustomerProfile : Form
    {
        CustomerInfo custInfo = new CustomerInfo();

        public CustomerProfile()
        {
            InitializeComponent();
        }

        private void CustomerProfile_Load(object sender, EventArgs e)
        {
            custInfo = CustomerInfo.getSample();
            picBox_ProfileImage.Image = custInfo.Customerimage;
            txtBox_Address.Text = custInfo.Customeraddress;
            txtBox_Login.Text = custInfo.Customerusername;
            txtBox_Mail.Text = custInfo.Customeremail;
            txtBox_Name.Text = custInfo.Customername;
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Smooth_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_MainMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainAppForm appForm = new MainAppForm();
            appForm.ShowDialog();
        }
    }
}
