using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AirBNB.Model;
using AirBNB.View;
using System.Data.SqlClient;

namespace AirBNB.View
{
    public partial class Form_cusReserveRoom : Form
    {
        Class_Registration _Registration = new Class_Registration();

        public string ownerID;
        public string roomID;
        public string cusID;
        public string cusPassword;
        public string roomType;

        public Form_cusReserveRoom()
        {
            InitializeComponent();
        }

        private void panel_cusMenuBorder_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
        Point lastPoint;

        private void panel_cusMenuBorder_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }   
        
        private void Form_cusReserveRoom_Load(object sender, EventArgs e)
        {
            label_cusID.Text = cusID;
            label_cusOwnerID.Text = ownerID;
            getCustomer();
            getOwner();
        }

        public void getOwner()
        {
            SqlConnection sqlConnection = new SqlConnection(_Registration.connectionString);

            sqlConnection.Open();
            try
            {
                string query = "SELECT * FROM airbnb_Customers WHERE id_Customer = '" + label_cusOwnerID.Text + "' ";
                using (SqlCommand sqlCommand = new SqlCommand(query, sqlConnection))
                {
                    SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                    if (sqlDataReader.HasRows)
                    {
                        while (sqlDataReader.Read())
                        {
                            if (sqlDataReader[0].ToString() == label_cusOwnerID.Text)
                            {
                                label_cusOwnerName.Text = sqlDataReader[2].ToString() + " " + sqlDataReader[3].ToString();
                                label_cusOwnerAddress.Text = sqlDataReader[4].ToString();
                                label_cusOwnerContact.Text = sqlDataReader[9].ToString();
                                label_cusOwnerEmail.Text = sqlDataReader[10].ToString();
                            }
                        }
                    }
                }
            }
            catch (Exception k)
            {
                MessageBox.Show(k.Message);
            }
            sqlConnection.Close();
        }

        public void getCustomer()
        {
            SqlConnection sqlConnection = new SqlConnection(_Registration.connectionString);

            sqlConnection.Open();
            try
            {
                string query = "SELECT * FROM airbnb_Customers WHERE id_Customer = '" + label_cusID.Text + "' ";
                using (SqlCommand sqlCommand = new SqlCommand(query, sqlConnection))
                {
                    SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                    if (sqlDataReader.HasRows)
                    {
                        while (sqlDataReader.Read())
                        {
                            if (sqlDataReader[0].ToString() == label_cusID.Text)
                            {
                                label_cusFullName.Text = sqlDataReader[2].ToString() + " " + sqlDataReader[3].ToString();
                                label_cusAddress.Text = sqlDataReader[4].ToString();
                                label_cusContact.Text = sqlDataReader[9].ToString();
                                label_cusEmail.Text = sqlDataReader[10].ToString();
                                cusPassword = sqlDataReader[11].ToString();
                            }
                        }
                    }
                }
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
            }
        }

        private void comboBox_cusPayMethod_SelectedValueChanged(object sender, EventArgs e)
        {
            if (comboBox_cusPayMethod.SelectedItem.ToString() == "Credit Card")
            {
                textBox_cusCardNumber.ReadOnly = false;
                textBox_cusCardNumber.Enabled = true;
            }
            else
            {
                textBox_cusCardNumber.Clear();
                textBox_cusCardNumber.ReadOnly = true;
                textBox_cusCardNumber.Enabled = false;
            }
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            //DateTime date = DateTime.Now;
            ////MessageBox.Show(dateTimePicker_cusReservation.Value.Month.ToString());
            //MessageBox.Show(date.ToString("yyyy'-'MM'-'dd"));
            //this.Hide();
            //checkDatesRent();
            //MessageBox.Show(fDate);
            this.Hide();
        }

        public bool dateCheck = false; // 
        public bool secDate = false;

        private void button_Reserve_Click(object sender, EventArgs e)
        {
            checkDates();
            try
            {
                if (comboBox_cusPayMethod.SelectedItem.ToString() == "Credit Card")
                {
                    if (!string.IsNullOrEmpty(textBox_cusCardNumber.Text))
                    {
                        next();
                    }
                    else
                    {
                        MessageBox.Show("Enter Card Number");
                    }
                }
                else if (comboBox_cusPayMethod.SelectedItem.ToString() == "Cash")
                {
                    next();
                }
                else
                {
                    MessageBox.Show("Choose a Payment Method");
                }
            }
            catch (Exception t)
            {
                MessageBox.Show(t.Message);
            }
            
        }

        public void next()
        {
            checkDates();
            if (dateCheck == true && secDate == true)
            {
                dateCheck = false;
                secDate = false;
                if (cusPassword == textBox1.Text)
                {
                    checkDatesRent();
                    if (sCheck == true)
                    {
                        sCheck = false;
                        UpdateReservation();
                        insertRoomHistory();
                        MessageBox.Show("ROOM RESERVED");
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Room Taken");
                    }
                }
                else
                {
                    MessageBox.Show("Incorrect Password");
                }
            }
        }

        public void UpdateReservation()
        {
            SqlConnection sqlConnection = new SqlConnection(_Registration.connectionString);
            string q = "RESERVED";

            try
            {
                using (SqlCommand sqlCommand = new SqlCommand("UPDATE airbnb_Rooms SET room_Availability=@room_Availability, room_Rentee=@room_Rentee, room_DateRented=@room_DateRented, room_DateRentEnd=@room_DateRentEnd WHERE room_ID=@room_ID", sqlConnection))
                {
                    sqlConnection.Open();
                    sqlCommand.Parameters.Add(new SqlParameter("@room_ID", roomID));
                    sqlCommand.Parameters.Add(new SqlParameter("@room_Availability", q));
                    sqlCommand.Parameters.Add(new SqlParameter("@room_Rentee", label_cusID.Text.ToString()));
                    sqlCommand.Parameters.Add(new SqlParameter("@room_DateRented", dateTimePicker_cusReservation.Value.ToString("yyyy'-'MM'-'dd")));
                    sqlCommand.Parameters.Add(new SqlParameter("@room_DateRentEnd", dateTimePicker_cusExpiration.Value.ToString("yyyy'-'MM'-'dd")));
                    sqlCommand.ExecuteNonQuery();
                    sqlConnection.Close();
                }
            }
            catch (Exception c)
            {
                MessageBox.Show(c.Message);
            }
        }

        public void insertRoomHistory()
        {
            DateTime date = DateTime.Now.Date;
            SqlConnection sqlConnection = new SqlConnection(_Registration.connectionString);
            string w = "No Comments/Rates";
            string q = "RESERVED";
            //string fDate = dateTimePicker.Value.ToString("yyyy-")

            try
            {
                string query = "INSERT INTO airbnb_RentHistory (rent_RoomID, rent_OwnerID, rent_RenteeID, rent_PaymenMethod, rent_DateBooked, rent_DateRented, rent_DateRentDue, rent_Score, rent_Comment, rent_RoomType, rent_CustomerName, rent_OwnerName, rent_Status) values ( '" + roomID + "' , '" + label_cusOwnerID.Text + "' , '" + label_cusID.Text + "'  , '" + comboBox_cusPayMethod.SelectedItem.ToString() + "' , '" + date.ToString("yyyy'-'MM'-'dd") + "' , '" + dateTimePicker_cusReservation.Value.ToString("yyyy-MM-dd") + "' , '" + dateTimePicker_cusExpiration.Value.ToString("yyyy-MM-dd") + "' , '" + 0 + "' , '" + w + "' , '" + roomType + "' , '" + label_cusFullName.Text + "' , '" + label_cusOwnerName.Text + "' , '" + q + "')";
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();   
                sqlConnection.Close();
            }
            catch (Exception k)
            {
                MessageBox.Show(k.Message);
            }
        }

        public void checkDates()
        {
            DateTime dt = DateTime.Now;
            int Month = dt.Month;
            int Year = dt.Year;
            int Date = dt.Day;

            int dMonth = dateTimePicker_cusReservation.Value.Month;
            int dYear = dateTimePicker_cusReservation.Value.Year;
            int dDate = dateTimePicker_cusReservation.Value.Day;

            if (Year > dYear) // 2021 > 2019
            {
                MessageBox.Show("ERROR DATE");
            }
            else
            {
                if (Month > dMonth) //  5 > 4
                {
                    MessageBox.Show("ERROR DATE");
                }
                else
                {
                    dateCheck = true;
                }
            }
            secondCheck(dMonth, dDate, dYear);
        }

        public void secondCheck(int m, int d, int y)
        {
            DateTime dt = DateTime.Now;
            int Month = dt.Month;
            int Year = dt.Year;
            int Date = dt.Day;

            int dm = dateTimePicker_cusExpiration.Value.Month;
            int dy = dateTimePicker_cusExpiration.Value.Year;
            int dd = dateTimePicker_cusExpiration.Value.Day;

            if (Year <= dy && dy <= y)
            {
                if (Month <= dm && dm <= m)
                {
                    if (d <= dd)
                    {
                        secDate = true;
                    }
                    else
                    {
                        MessageBox.Show("ERROR DATE");
                    }
                }
                else
                {
                    MessageBox.Show("ERROR DATE");
                }
            }
            else
            {
                MessageBox.Show("ERROR DATE");
            }
        }

        public string fDate;
        public string sDate;
        public bool sCheck = false;

        public void checkDatesRent()
        {
            SqlConnection sqlConnection = new SqlConnection(_Registration.connectionString);

            try
            {
                sqlConnection.Open();
                string query = "SELECT * FROM airbnb_RentHistory WHERE rent_RoomID = '" + roomID + "' ";
                using (SqlCommand sqlCommand = new SqlCommand(query, sqlConnection))
                {
                    SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                    if (sqlDataReader.HasRows)
                    {
                        while (sqlDataReader.Read())
                        {
                            if (sqlDataReader[0].ToString() == roomID)
                            {
                                if (sqlDataReader[5].ToString() != dateTimePicker_cusReservation.Value.ToString())
                                {
                                    if (sqlDataReader[6].ToString() != dateTimePicker_cusExpiration.Value.ToString())
                                    {
                                        sCheck = true;
                                    }
                                }
                            }
                            else
                            {
                                sCheck = true;
                            }
                        }
                    }
                    else
                    {
                        sCheck = true;
                    }
                }
                sqlConnection.Close();
            }
            catch (Exception f)
            {
                MessageBox.Show(f.Message);
            }
        }
    }
}