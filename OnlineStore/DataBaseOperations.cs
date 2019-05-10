using System;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace OnlineStore
{
    class DataBaseOperations
    {
        static private DataBaseOperations db_oper;
        private MySqlConnection sql_connection;
        private MySqlCommand sql_command;
        static private string sql_login, sql_password, sql_server, sql_database;

        public DataBaseOperations()
        {
            sql_login = "root";
            sql_password = "root";
            sql_server = "localhost";
            sql_database = "shoponline";
        }

        public static DataBaseOperations getSample()
        {
            if (db_oper == null)
                db_oper = new DataBaseOperations();
            return db_oper;
        }

        static private string GetConnectionString()
        {
            return "SERVER ="+ sql_server + "; DATABASE=" + sql_database + ";USER=" + sql_login + ";PASSWORD=" + sql_password;
        }

        public bool InsertUser(string customer_address,string customer_email,string customer_login,string customer_name,string customer_password, bool customer_gender)
        {
            string connectionString = GetConnectionString();
            SecurePassword sc_pw = new SecurePassword(customer_password);
            byte[] bytePW = sc_pw.ToArray();
            string passwordBytes = Convert.ToBase64String(bytePW);
            try
            {
                using (sql_connection = new MySqlConnection(connectionString))
                {
                    sql_connection.Open();
                    using (sql_command = new MySqlCommand("INSERT INTO customer(customer_name,customer_adress,customer_email,customer_username,customer_password,customer_gender) VALUES(@Name, @Address, @Email, @Username, @Password, @Gender)", sql_connection))
                    {
                        sql_command.Parameters.AddWithValue("Name", customer_name);
                        sql_command.Parameters.AddWithValue("Address", customer_address);
                        sql_command.Parameters.AddWithValue("Email", customer_email);
                        sql_command.Parameters.AddWithValue("Username", customer_login);
                        sql_command.Parameters.AddWithValue("Password", passwordBytes);
                        sql_command.Parameters.AddWithValue("Gender", customer_gender);
                    }
                    sql_command.ExecuteNonQuery();
                }    
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            db_oper.sql_connection.Close();
            return true;
        }

        public CustomerInfo SelectUser(string customer_username, string customer_password)
        {
            CustomerInfo customer = null;
            string connectionString = GetConnectionString();
            try
            {
                using (sql_connection = new MySqlConnection(connectionString))
                {
                    sql_connection.Open();
                    using (sql_command = new MySqlCommand("Select * from customer where customer_username = @CustomerName", sql_connection))
                    {
                        sql_command.Parameters.AddWithValue("CustomerName", customer_username);
                    }
                    MySqlDataReader reader = sql_command.ExecuteReader();
                    if (reader.HasRows)
					{
                        while (reader.Read())
                        {
                            bool securingResult = false;
                            SecurePassword pw = new SecurePassword();
                            securingResult = pw.Verifing((string)reader["customer_password"], customer_password.ToString());

                            if(securingResult == false)
                            {
                                MessageBox.Show("Password is incorrect");
                            }
                            else
                            {
                                customer = CustomerInfo.getSample();
                                customer.Customerid = (int)reader["customer_id"];
                                customer.Customername = (string)reader["customer_name"];
                                customer.Customeraddress = (string)reader["customer_adress"];
                                customer.Customeremail = (string)reader["customer_email"];
                                customer.Customerusername = (string)reader["customer_username"];
                                customer.Customerpassword = (string)reader["customer_password"];
                                int value = reader.GetByte("customer_gender");
                                if (value == 1)
                                    customer.Customergender = true;
                                else customer.Customergender = false;
                            }
                        }
                        reader.Close();
                        sql_command.ExecuteNonQuery();
                    }
                    else
                    {
                        MessageBox.Show("Login or password is incorect!");
                    }
                }
        }
            catch (Exception ex)
            {
                MessageBox.Show("Connection failed!!! \n" + ex.Message, "FAIL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            db_oper.sql_connection.Close();
            return customer;
        }

    }
}
