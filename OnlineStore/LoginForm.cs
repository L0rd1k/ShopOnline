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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            InternetConnection(); 

        }

        private void InternetConnection()
        {
            bool checkNet1 = CheckInternet.CheckForInternetConnection_Wininet();
            bool checkNet2 = CheckInternet.CheckForInternetConnection_Ping();
            if (checkNet1 || checkNet2)
                MessageBox.Show("Internet conncetion : ONLINE!");
            else
                MessageBox.Show("Internet conncetion : OFFLINE!");
        }

        private void btn_SignIn_Click(object sender, EventArgs e)
        {
            DataBaseOperations db_operation = DataBaseOperations.getSample(); 
            CustomerInfo customerLogined = CustomerInfo.getSample();
            CustomerInfo customerInfo = db_operation.SelectUser(txtBox_Login.Text,txtBox_Password.Text);
            if(customerInfo != null)
            {
                MessageBox.Show("You have entered!!!");
                MessageBox.Show("" + customerInfo.Customeraddress);
            }
            
            

        }
    }
}
