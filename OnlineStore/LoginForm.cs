using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
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
        private void LoginForm_Load(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = false;
            panel1.BringToFront();
            txtBox_Password.PasswordChar = 'X';
            tB_SignUp_Password.PasswordChar = 'X';
            tB_SignUp_RePW.PasswordChar = 'X';
            rB_SignUp_male.Checked = true;
            rB_SignUp_Female.Checked = false;
            this.Text = "Autorization form";
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

        //SIGN IN
        private void btn_SignIn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBox_Password.Text) || string.IsNullOrWhiteSpace(txtBox_Login.Text))
            {
                MessageBox.Show("There are an empty field!!!");
            }
            else
            {
                DataBaseOperations db_operation = DataBaseOperations.getSample();
                CustomerInfo customerInfo = db_operation.SelectUser(txtBox_Login.Text, txtBox_Password.Text);
                if (customerInfo != null)
                {
                    MessageBox.Show(customerInfo.Customerid.ToString());
                    db_operation.InsertLogger(0);
                    this.Hide();
                    MessageBox.Show("You have entered!!!");
                    MessageBox.Show("" + customerInfo.Customeraddress);
                    MainAppForm mainForm = new MainAppForm();
                    mainForm.ShowDialog();
                    mainForm = null;
                    txtBox_Login.Clear();
                    txtBox_Password.Clear();
                }
            }
        }

        private void pB_ShowPW_MouseDown(object sender, MouseEventArgs e)
        {
            txtBox_Password.PasswordChar = '\0';
        }
        private void pB_ShowPW_MouseUp(object sender, MouseEventArgs e)
        {
            txtBox_Password.PasswordChar = 'X';
        }
        private void txtBox_Login_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsWhiteSpace(e.KeyChar) || System.Text.Encoding.UTF8.GetByteCount(new char[] { e.KeyChar }) > 1)
            {
                e.Handled = true;
            }
        }

        // SIGN UP
        private void btn_SignUp_Click(object sender, EventArgs e)
        {
            if (CheckValidity())
            {
                MemoryStream memStream = new MemoryStream();
                picBox_ProfileImage.Image.Save(memStream, picBox_ProfileImage.Image.RawFormat);
                byte[] ImageData = memStream.ToArray();

                DataBaseOperations db_operation = DataBaseOperations.getSample();
                bool result = db_operation.InsertUser(tB_SignUp_Adress.Text,
                                                      tB_SignUp_Email.Text,
                                                      tB_SignUp_Login.Text,
                                                      tB_SignUp_Name.Text,
                                                      tB_SignUp_Password.Text,
                                                      rB_SignUp_male.Checked,
                                                      ImageData
                                                      );

                if(result)
                    MessageBox.Show("You was succesfully registrated");

            }
        }
        private bool CheckValidity()
        {
            bool finalResult = true;
            List<bool> falseAlarms = new List<bool> { };
            List<string> messageErrors = new List<string> { };

            if (string.IsNullOrWhiteSpace(tB_SignUp_Adress.Text) || string.IsNullOrWhiteSpace(tB_SignUp_Email.Text) ||
               string.IsNullOrWhiteSpace(tB_SignUp_Login.Text) || string.IsNullOrWhiteSpace(tB_SignUp_Name.Text) ||
               string.IsNullOrWhiteSpace(tB_SignUp_Password.Text) || string.IsNullOrWhiteSpace(tB_SignUp_RePW.Text))
            {
                falseAlarms.Add(false);
                messageErrors.Add("- There are empty fields!\n");
            }
            if(!ValidEmail(tB_SignUp_Email.Text))
            {
                falseAlarms.Add(false);
                messageErrors.Add("- Invalid Email Address!\n");
            }
            if(tB_SignUp_Password.Text != tB_SignUp_RePW.Text)
            {
                falseAlarms.Add(false);
                messageErrors.Add("- Passwords are not matched!\n");
            }

            foreach (var err_item in falseAlarms)
            {
                if (err_item != false)
                    finalResult = true;
                else
                    finalResult = false;
            }

            if(messageErrors.Count != 0)
            {
                var messages = string.Join("", messageErrors);
                MessageBox.Show(messages, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return finalResult;
        }
        private bool ValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
        private void pB_SignUp_Password_MouseUp(object sender, MouseEventArgs e)
        {
            tB_SignUp_Password.PasswordChar = 'X';
        }
        private void pB_SignUp_Password_MouseDown(object sender, MouseEventArgs e)
        {
            tB_SignUp_Password.PasswordChar = '\0';
        }
        private void pB_SignUp_RepPW_MouseUp(object sender, MouseEventArgs e)
        {
            tB_SignUp_RePW.PasswordChar = 'X';
        }
        private void pB_SignUp_RepPW_MouseDown(object sender, MouseEventArgs e)
        {
            tB_SignUp_RePW.PasswordChar = '\0';
        }
        private void tB_SignUp_Name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) || System.Text.Encoding.UTF8.GetByteCount(new char[] { e.KeyChar }) > 1)
            {
                e.Handled = true;
            }
        }
        private void tB_SignUp_Login_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsWhiteSpace(e.KeyChar) || System.Text.Encoding.UTF8.GetByteCount(new char[] { e.KeyChar }) > 1)
            {
                e.Handled = true;
            }
        }
        private void tB_SignUp_Adress_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (System.Text.Encoding.UTF8.GetByteCount(new char[] { e.KeyChar }) > 1)
            {
                e.Handled = true;
            }
        }
        private void tB_SignUp_Email_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (System.Text.Encoding.UTF8.GetByteCount(new char[] { e.KeyChar }) > 1)
            {
                e.Handled = true;
            }
        }
        private void tB_SignUp_Password_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (System.Text.Encoding.UTF8.GetByteCount(new char[] { e.KeyChar }) > 1)
            {
                e.Handled = true;
            }
        }
        private void tB_SignUp_RePW_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (System.Text.Encoding.UTF8.GetByteCount(new char[] { e.KeyChar }) > 1)
            {
                e.Handled = true;
            }
        }
        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void button6_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_Upload_Image_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFile = new OpenFileDialog();
                openFile.Filter = "Choose profile image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
                if (openFile.ShowDialog() == DialogResult.OK)
                {
                    picBox_ProfileImage.Image = Image.FromFile(openFile.FileName);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_SignInPanel_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = false;

            panel1.BringToFront();
        }

        private void btn_SignUpPanel_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = true;
            panel2.BringToFront();
        }
    }
}
