using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AirBNB.View;
using AirBNB.Model;
using System.Data.SqlClient;

namespace AirBNB
{
    public partial class Form1 : Form
    {
        Class_Registration _Registration = new Class_Registration();

        public Form1()
        {
            InitializeComponent();
        }

        private void button_Close_MouseHover(object sender, EventArgs e)
        {
            button_Close.BackColor = Color.Red;
        }

        private void button_Close_MouseLeave(object sender, EventArgs e)
        {
            button_Close.BackColor = Color.Transparent;
        }

        private void panel_Border_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        Point lastPoint;

        private void panel_Border_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void button_Close_Click(object sender, EventArgs e)
        {
            this.Close();
            System.Windows.Forms.Application.Exit();
        }

        private void button_Register_Click(object sender, EventArgs e)
        {
            Form_Registration _Registration = new Form_Registration();
            this.Hide();
            _Registration.Show();
        }

        public void Clear()
        {
            _Registration.temp_Email = "";
            _Registration.temp_Password = "";
            label_AccountDoesntExist.Visible = false;
            label_IncorrectPassword.Visible = false;
            label_InvalidEmail.Visible = false;
        }

        private void button_Login_Click(object sender, EventArgs e)
        {
            //SqlConnection connection = new SqlConnection(_Registration.connectionString);
            //connection.Open();

            //Form_customerMenu _CustomerMenu = new Form_customerMenu();
            //this.Hide();
            //_CustomerMenu.Show();

            Clear();
            if (string.IsNullOrEmpty(textBox_EmailContactNo.Text))
            {
                label_InvalidEmail.Visible = true;
            }
            else if (string.IsNullOrEmpty(textBox_Password.Text))
            {
                label_IncorrectPassword.Visible = true;
            }
            else
            {
                Check();
                if (string.IsNullOrEmpty(_Registration.temp_Email))
                {
                    label_AccountDoesntExist.Visible = true;
                }
                else
                {
                    if (string.IsNullOrEmpty(_Registration.temp_Password))
                    {
                        label_IncorrectPassword.Visible = true;
                    }
                    else
                    {
                        if (_Registration.temp_Purpose == "Customer")
                        {
                            Form_customerMenu _CustomerMenu = new Form_customerMenu();
                            _CustomerMenu.email = textBox_EmailContactNo.Text;
                            _CustomerMenu.pass = textBox_Password.Text;
                            _CustomerMenu.ID = _Registration.temp_ID;
                            this.Hide();
                            _CustomerMenu.Show();
                        }
                        else
                        {
                            Form_ownerMenu _OwnerMenu = new Form_ownerMenu();
                            _OwnerMenu.email = textBox_EmailContactNo.Text;
                            _OwnerMenu.pass = textBox_Password.Text;
                            _OwnerMenu.OwnerID = _Registration.temp_ID;
                            this.Hide();
                            _OwnerMenu.Show();
                        }
                    }
                }
            }
        }

        public void Check()
        {
            SqlConnection connection = new SqlConnection(_Registration.connectionString);

            connection.Open();
            try
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM airbnb_Customers", connection))
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            //while (reader["email_Customer"].ToString() == textBox_EmailContactNo.Text)
                            //{
                            //    while ()
                            //    break;
                            //}
                            if (reader["email_Customer"].ToString() == textBox_EmailContactNo.Text)
                            {
                                //MessageBox.Show(reader["email_Customer"].ToString());
                                _Registration.temp_Email = reader["email_Customer"].ToString();
                                if (reader["password_Customer"].ToString() == textBox_Password.Text)
                                {
                                    //MessageBox.Show(reader["password_Customer"].ToString());
                                    _Registration.temp_Password = reader["password_Customer"].ToString();
                                    _Registration.temp_ID = Convert.ToInt32(reader["id_Customer"]);
                                    _Registration.temp_Purpose = reader["purpose_Customer"].ToString();
                                    _Registration.temp_FirstName = reader["fName_Customer"].ToString();
                                    _Registration.temp_LastName = reader["lName_Customer"].ToString();
                                    _Registration.temp_Address = reader["address_Customer"].ToString();
                                    _Registration.temp_Month = reader["bMonth_Customer"].ToString();
                                    _Registration.temp_Date = Convert.ToInt32(reader["bDate_Customer"]);
                                    _Registration.temp_Year = Convert.ToInt32(reader["bYear_Customer"]);
                                    _Registration.temp_Age = Convert.ToInt32(reader["age_Customer"]);
                                    _Registration.temp_ContactNumber = reader["conNumber_Customer"].ToString();
                                }
                            }
                            //else
                            //{
                            //    if (reader["password_Customer"].ToString() != textBox_Password.Text)
                            //    {
                            //        label_IncorrectPassword.Visible = true;
                            //        break;
                            //    }
                            //    else
                            //    {
                            //        MessageBox.Show("Tae");
                            //    }
                            //}
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            connection.Close();

            //if (Convert.ToString(textBox_EmailContactNo).Contains('@'))
            //{
            //    string query = "select * from airbnb_Customers where email_Customer = '" + textBox_EmailContactNo.Text + "'and password_Customer = '" + textBox_Password.Text + "' ";
            //    SqlCommand cmd = new SqlCommand(query, connection);

            //    cmd.Parameters.AddWithValue("email_Customer", textBox1.Text);
            //    SqlDataReader reader;
            //    reader = cmd.ExecuteReader();
            //    if (reader.Read())
            //    {
            //        MessageBox.Show(reader["password_Customer"].ToString());
            //        _Registration.temp_FirstName = reader["fName_Customer"].ToString();
            //        _Registration.temp_Email = reader["email_Customer"].ToString();
            //        _Registration.temp_Password = reader["password_Customer"].ToString();
            //        MessageBox.Show(_Registration.temp_FirstName);
            //        MessageBox.Show(_Registration.temp_Email);
            //        MessageBox.Show(_Registration.temp_Password);
            //    }
            //    else
            //    {
            //        MessageBox.Show("wala");
            //    }
            //}
            // [up] storing
            ////////////////////////////////////////////////////////////////////////////////////////////
            ////////////////////////////////////////////////////////////////////////////////////////////
            ////////////////////////////////////////////////////////////////////////////////////////////
            //try
            //{
            //    connection.Open();
            //    using (SqlCommand cmd = new SqlCommand("SELECT * FROM airbnb_Customers", connection))
            //    {
            //        SqlDataReader reader = cmd.ExecuteReader();
            //        if (reader.HasRows)
            //        {
            //            while (reader.Read())
            //            {
            //                MessageBox.Show("Password is: " + reader["password_Customer"]);
            //            }
            //        }
            //        reader.Close();
            //    }
            //    connection.Close();
            //}
            //catch (Exception e)
            //{
            //    MessageBox.Show("TAE");
            //}
            //SqlCommand sqlCommand = new SqlCommand("Select email_Customer, password_Customer from airbnb_Customers where email_Customer= ");
        }

        public void UpdateLatest()
        {
            Class_Registration class_Registration = new Class_Registration();

            SqlConnection sqlConnection = new SqlConnection(class_Registration.connectionString);

            sqlConnection.Open();
            try
            {
                //string query = "SELECT * FROM airbnb_RentHistory";
                string query = "SELECT * FROM airbnb_Rooms";
                using (SqlCommand sqlCommand = new SqlCommand(query, sqlConnection))
                {
                    SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                    if (sqlDataReader.HasRows)
                    {
                        while (sqlDataReader.Read())
                        {
                            //MessageBox.Show(sqlDataReader[0].ToString() + " and " + sqlDataReader[6].ToString());
                            checkDate(sqlDataReader[6].ToString());
                            {
                                if (checkDate(sqlDataReader[9].ToString()) == true)
                                {
                                    updateRooms(sqlDataReader[0].ToString());
                                   //checkDate(sqlDataReader[6].ToString()) = false;
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception f)
            {
                MessageBox.Show(f.Message);
            }
            sqlConnection.Close();
        }

        public bool checkDate(string dataDate)
        {
            DateTime date = DateTime.Now;   //date now
            string dateNow = date.ToString("yyyy'-'MM'-'dd");   //date now
            string[] dDate = dateNow.Split('-');    //date now

            DateTime daDate = Convert.ToDateTime(dataDate);
            string datDate = daDate.ToString("yyyy'-'MM'-'dd");
            string[] sDate = datDate.Split('-');

            if (Convert.ToInt32(dDate[0]) >= Convert.ToInt32(sDate[0]))
            {
                if (Convert.ToInt32(dDate[1]) >= Convert.ToInt32(sDate[1]))
                {
                    if (Convert.ToInt32(dDate[2]) >= Convert.ToInt32(sDate[2]))
                    {
                        return true;
                    }
                    //else
                    //{
                    //    return false;
                    //}
                    return true;
                }
                return true;
            }
            return false;
        }

        public void updateRooms(string roomID)
        {
            SqlConnection sqlConnection = new SqlConnection(_Registration.connectionString);

            try
            {
                using (SqlCommand sqlCommand = new SqlCommand("UPDATE airbnb_Rooms SET room_Availability=@room_Availability WHERE room_ID=@room_ID", sqlConnection))
                {
                    sqlConnection.Open();
                    sqlCommand.Parameters.Add(new SqlParameter("@room_ID", roomID));
                    sqlCommand.Parameters.Add(new SqlParameter("@room_Availability", "AVAILABLE"));
                    sqlCommand.ExecuteNonQuery();
                    sqlConnection.Close();
                }
            }
            catch (Exception g)
            {
                MessageBox.Show(g.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //UpdateLatest();
        }
    }
}
