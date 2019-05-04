using System;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

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
            return "SERVER = localhost; DATABASE=" + sql_database + ";USER=" + sql_login + ";PASSWORD=" + sql_password;
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
                            if (customer_password.ToString() != (string)reader["customer_password"])
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
