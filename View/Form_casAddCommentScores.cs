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
using System.IO;

namespace AirBNB.View
{
    public partial class Form_casAddCommentScores : Form
    {
        Class_Registration _Registration = new Class_Registration();

        public string addRoomID;
        public string addRenteeID;
        public string addDateRented;

        public Form_casAddCommentScores()
        {
            InitializeComponent();
        }

        private void panel_Border_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
        Point lastPoint;
        private void panel_Border_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void Form_casAddCommentScores_Load(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection(_Registration.connectionString);

            sqlConnection.Open();
            try
            {
                string query = "SELECT * FROM airbnb_RentHistory WHERE rent_RoomID = '" + addRoomID + "' AND rent_RenteeID = '" + addRenteeID + "' ";
                using (SqlCommand sqlCommand = new SqlCommand(query, sqlConnection))
                {
                    SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                    if (sqlDataReader.HasRows)
                    {
                        while (sqlDataReader.Read())
                        {
                            if (!string.IsNullOrEmpty(sqlDataReader[5].ToString()))
                            {
                                DateTime date = Convert.ToDateTime(sqlDataReader[5]);
                                string dDate = date.ToString("yyyy-MM-dd");
                                if (dDate == addDateRented)
                                {
                                    richTextBox_casAddComment.Text = sqlDataReader[8].ToString();
                                    comboBox_casAddScore.Text = sqlDataReader[7].ToString();
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception o)
            {
                MessageBox.Show(o.Message);
            }
            sqlConnection.Close();
        }

        //public void 

        private void label12_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void label12_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection(_Registration.connectionString);

            if (comboBox_casAddScore.Text == "" && richTextBox_casAddComment.Text == "")
            {
                MessageBox.Show("Atleast Add a Score");
            }
            else
            {
                try
                {
                    using (SqlCommand sqlCommand = new SqlCommand("UPDATE airbnb_RentHistory SET rent_Score=@rent_Score, rent_Comment=@rent_Comment WHERE rent_RoomID=@rent_RoomID AND rent_RenteeID=@rent_RenteeID AND rent_DateRented=@rent_DateRented", sqlConnection))
                    {
                        sqlConnection.Open();
                        sqlCommand.Parameters.Add(new SqlParameter("@rent_RoomID", addRoomID));
                        sqlCommand.Parameters.Add(new SqlParameter("@rent_RenteeID", addRenteeID));
                        sqlCommand.Parameters.Add(new SqlParameter("@rent_DateRented", addDateRented));
                        sqlCommand.Parameters.Add(new SqlParameter("@rent_Score", comboBox_casAddScore.SelectedItem.ToString()));
                        sqlCommand.Parameters.Add(new SqlParameter("@rent_Comment", richTextBox_casAddComment.Text));
                        sqlCommand.ExecuteNonQuery();
                        sqlConnection.Close();
                        MessageBox.Show("Comment and Score Added");
                    }
                }
                catch (Exception w)
                {
                    MessageBox.Show(w.Message);
                }
            }
            this.Hide();
        }

        public bool check()
        {
            if (comboBox_casAddScore.Text == "")
            {
                MessageBox.Show("INVALID SCORE");
                return false;
            }
            return true;
        }
    }
}
