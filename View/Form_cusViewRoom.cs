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
    public partial class Form_cusViewRoom : Form
    {
        Class_Registration _Registration = new Class_Registration();

        public string form_cusViewRoomID;
        public string owner_ID;
        public string customerID;
        public string Status;

        public Form_cusViewRoom()
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
        
        private void button_Cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Form_cusViewRoom_Load(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection(_Registration.connectionString);
            label_formCusViewRoomID.Text = form_cusViewRoomID;
            getCommentsRates();

            sqlConnection.Open();
            try
            {
                string query = "SELECT * FROM airbnb_Rooms WHERE room_ID = '" + form_cusViewRoomID + "' ";
                using (SqlCommand sqlCommand = new SqlCommand(query, sqlConnection))
                {
                    SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                    if (sqlDataReader.HasRows)
                    {
                        while (sqlDataReader.Read())
                        {
                            if (sqlDataReader[0].ToString() == label_formCusViewRoomID.Text)
                            {
                                owner_ID = sqlDataReader[1].ToString();
                                label_formCusRoomType.Text = sqlDataReader[2].ToString();
                                label_formCusRoomPrice.Text = sqlDataReader[3].ToString();
                                label_GuestCap.Text = sqlDataReader[4].ToString();
                                label_NumBed.Text = sqlDataReader[5].ToString();
                                richTextBox_formCusAmenities.Text = sqlDataReader[6].ToString();
                                label_Location.Text = sqlDataReader[11].ToString();
                                label_Address.Text = sqlDataReader[12].ToString();
                                byte[] fimg = (byte[])(sqlDataReader[13]);
                                byte[] simg = (byte[])(sqlDataReader[14]);
                                byte[] timg = (byte[])(sqlDataReader[15]);
                                MemoryStream fms = new MemoryStream(fimg);
                                MemoryStream sms = new MemoryStream(simg);
                                MemoryStream tms = new MemoryStream(timg);
                                pictureBox_FirstImage.Image = Image.FromStream(fms);
                                pictureBox_SecondImage.Image = Image.FromStream(sms);
                                pictureBox_ThirdImage.Image = Image.FromStream(tms);
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
            getOwnersName();
        }

        public void getOwnersName()
        {
            SqlConnection sqlConnection = new SqlConnection(_Registration.connectionString);

            sqlConnection.Open();
            try
            {
                string query = "SELECT * FROM airbnb_Customers WHERE id_Customer = '" + owner_ID + "' ";
                using (SqlCommand sqlCommand = new SqlCommand(query, sqlConnection))
                {
                    SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                    if (sqlDataReader.HasRows)
                    {
                        while (sqlDataReader.Read())
                        {
                            if (sqlDataReader[0].ToString() == owner_ID)
                            {
                                label_RoomOwner.Text = sqlDataReader[2].ToString() + " " + sqlDataReader[3].ToString();
                            }
                        }
                    }
                }
            }
            catch (Exception v)
            {
                MessageBox.Show(v.Message);
            }
            sqlConnection.Close();
        }

        public void getCommentsRates()
        {
            SqlConnection sqlConnection = new SqlConnection(_Registration.connectionString);

            sqlConnection.Open();
            try
            {
                string query = "SELECT * FROM airbnb_RentHistory WHERE rent_RoomID = '" + label_formCusViewRoomID.Text + "' ";
                using (SqlCommand sqlCommand = new SqlCommand(query, sqlConnection))
                {
                    SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                    if (sqlDataReader.HasRows)
                    {
                        while (sqlDataReader.Read())
                        {
                            if (sqlDataReader[0].ToString() == label_formCusViewRoomID.Text)
                            {
                                if (sqlDataReader[8].ToString() != "No Comments/Rates" || sqlDataReader[7].ToString() != "0")
                                {
                                    UserControl_CommentsAndRates _CommentsAndRates = new UserControl_CommentsAndRates();
                                    _CommentsAndRates.load(sqlDataReader[7].ToString(), sqlDataReader[8].ToString(), sqlDataReader[10].ToString());
                                    flowLayoutPanel_CommentsRates.Controls.Add(_CommentsAndRates);
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception v)
            {
                MessageBox.Show(v.Message);
            }
            sqlConnection.Close();
        }

        private void button_cusViewRoomReserve_Click(object sender, EventArgs e)
        {
            if (Status == "RESERVED")
            {
                MessageBox.Show("Room is Reserved");
            }
            else
            {
                Form_cusReserveRoom _CusReserveRoom = new Form_cusReserveRoom();
                _CusReserveRoom.ownerID = owner_ID;
                _CusReserveRoom.roomID = label_formCusViewRoomID.Text;
                _CusReserveRoom.cusID = customerID;
                _CusReserveRoom.roomType = label_formCusRoomType.Text;
                this.Hide();
                _CusReserveRoom.Show();
            }          
        }
    }
}
