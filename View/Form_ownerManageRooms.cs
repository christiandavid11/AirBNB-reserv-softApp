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
    public partial class Form_ownerManageRooms : Form
    {
        Class_Registration _Registration = new Class_Registration();

        public int ownerManage_roomID;
        public int ownerManage_ownerID;

        public bool check = false;

        public String first_ImageLocation = "";
        public String second_ImageLocation = "";
        public String third_ImageLocation = "";

        public Form_ownerManageRooms()
        {
            InitializeComponent();
        }

        private void panel_ownManageBorder_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
        Point lastPoint;

        private void panel_ownManageBorder_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void button_ownManageRoomClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_ownManageRoomClose_MouseHover(object sender, EventArgs e)
        {
            this.button_ownManageRoomClose.BackColor = Color.Red;
        }

        private void button_ownManageRoomClose_MouseLeave(object sender, EventArgs e)
        {
            this.button_ownManageRoomClose.BackColor = Color.Transparent;
        }

        private void Form_ownerManageRooms_Load(object sender, EventArgs e)
        {
            label_omRoomID.Text = ownerManage_roomID.ToString();
            SqlConnection sqlConnection = new SqlConnection(_Registration.connectionString);
            sqlConnection.Open();
            try
            {
                string query = "SELECT * FROM airbnb_Rooms WHERE room_ID = '" + ownerManage_roomID + "'";
                using (SqlCommand sqlCommand = new SqlCommand(query, sqlConnection))
                {
                    SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                    if (sqlDataReader.HasRows)
                    {
                        while(sqlDataReader.Read())
                        {
                            if (Convert.ToInt32(sqlDataReader[0]) == ownerManage_roomID)
                            {
                                ownerManage_ownerID = Convert.ToInt32(sqlDataReader[1]);
                                if (sqlDataReader[2].ToString() == "Entire Place")
                                {
                                    checkBox_omEntirePlace.Checked = true;
                                }
                                else if (sqlDataReader[2].ToString() == "Private Room")
                                {
                                    checkBox_omPrvtRoom.Checked = true;
                                }
                                else
                                {
                                    checkBox_omShrdRoom.Checked = true;
                                }
                                textBox_omRoomPrice.Text = sqlDataReader[3].ToString();
                                comboBox_omRoomGuestCap.Text = sqlDataReader[4].ToString();
                                comboBox_omNumRooms.Text = sqlDataReader[5].ToString();
                                richTextBox_omRoomAmenities.Text = sqlDataReader[6].ToString();
                                comboBox_omLocation.Text = sqlDataReader[11].ToString();
                                textBox_omAddress.Text = sqlDataReader[12].ToString();
                                byte[] fimg = (byte[])(sqlDataReader[13]);
                                byte[] simg = (byte[])(sqlDataReader[14]);
                                byte[] timg = (byte[])(sqlDataReader[15]);
                                MemoryStream fms = new MemoryStream(fimg);
                                MemoryStream sms = new MemoryStream(simg);
                                MemoryStream tms = new MemoryStream(timg);
                                pictureBox_omFirstImage.Image = Image.FromStream(fms);
                                pictureBox_omSecondImage.Image = Image.FromStream(sms);
                                pictureBox_omThirdImage.Image = Image.FromStream(tms);
                            }
                        }
                    }
                }
            }
            catch (Exception p)
            {
                MessageBox.Show(p.Message);
            }
            sqlConnection.Close();
        }

        private void button_ownerManageDelete_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection(_Registration.connectionString);

            sqlConnection.Open();
            try
            {
                string query = "DELETE FROM airbnb_Rooms WHERE room_ID = '" + label_omRoomID.Text + "' ";
                using (SqlCommand sqlCommand = new SqlCommand(query, sqlConnection))
                {
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("Room Deleted");
                    this.Hide();
                }
                sqlConnection.Close();
            }
            catch (Exception q)
            {
                MessageBox.Show(q.Message);
            }
        }

        private void pictureBox_omFirstImage_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(*.jpg)|*.jpg| PNG files(*.png)|*.png| All Files(*.*)|*.*";

                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    first_ImageLocation = dialog.FileName;
                    pictureBox_omFirstImage.ImageLocation = first_ImageLocation;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error Image");
            }
        }

        private void pictureBox_omSecondImage_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(*.jpg)|*.jpg| PNG files(*.png)|*.png| All Files(*.*)|*.*";

                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    second_ImageLocation = dialog.FileName;
                    pictureBox_omSecondImage.ImageLocation = second_ImageLocation;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error Image");
            }
        }

        private void pictureBox_omThirdImage_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(*.jpg)|*.jpg| PNG files(*.png)|*.png| All Files(*.*)|*.*";

                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    third_ImageLocation = dialog.FileName;
                    pictureBox_omThirdImage.ImageLocation = third_ImageLocation;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error Image");
            }
        }

        private void checkBox_omEntirePlace_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_omEntirePlace.Checked == true)
            {
                checkBox_omPrvtRoom.Checked = false;
                checkBox_omShrdRoom.Checked = false;
            }
            _Registration.temp_RoomType = checkBox_omEntirePlace.Text;
        }

        private void checkBox_omPrvtRoom_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_omPrvtRoom.Checked == true)
            {
                checkBox_omEntirePlace.Checked = false;
                checkBox_omShrdRoom.Checked = false;
            }
            _Registration.temp_RoomType = checkBox_omPrvtRoom.Text;
        }

        private void checkBox_omShrdRoom_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_omShrdRoom.Checked == true)
            {
                checkBox_omEntirePlace.Checked = false;
                checkBox_omPrvtRoom.Checked = false;
            }
            _Registration.temp_RoomType = checkBox_omShrdRoom.Text;
        }

        public bool checkRoomType()
        {
            if (checkBox_omEntirePlace.Checked == true || checkBox_omPrvtRoom.Checked == true || checkBox_omShrdRoom.Checked == true)
            {
                return true;    //filled up
            }
            return false;       //unfilled up
        }

        public bool checkImages()
        {
            if (pictureBox_omFirstImage.Image != null && pictureBox_omSecondImage.Image != null && pictureBox_omThirdImage.Image != null)
            {
                return true;    //filled up
            }
            return false;       //unfilled up
        }       

        public void checkTextBoxes()
        {
            foreach (Control control in this.Controls)
            {
                if (this.Controls.OfType<TextBox>().Any(t => string.IsNullOrEmpty(t.Text)))
                {
                    check = true;   //unfilled
                    break;
                }
            }
        }
        
        private void button_ownerMenuEditRoom_Click(object sender, EventArgs e)
        {
            checkTextBoxes();
            if (checkRoomType() == true && checkImages() == true && check == false)
            {
                updateItems();
            }
            else
            {
                check = false;
                MessageBox.Show("Fill up Requirements");
            }
        }

        public void updateItems()
        {
            SqlConnection sqlConnection = new SqlConnection(_Registration.connectionString);

            try
            {
                //byte[] fimg = null;
                //byte[] simg = null;
                //byte[] timg = null;
                //FileStream fs = new FileStream(first_ImageLocation, FileMode.Open, FileAccess.Read);
                //FileStream ss = new FileStream(second_ImageLocation, FileMode.Open, FileAccess.Read);
                //FileStream ts = new FileStream(third_ImageLocation, FileMode.Open, FileAccess.Read);
                //BinaryReader fbr = new BinaryReader(fs);
                //BinaryReader sbr = new BinaryReader(ss);
                //BinaryReader tbr = new BinaryReader(ts);
                //fimg = fbr.ReadBytes((int)fs.Length);
                //simg = sbr.ReadBytes((int)ss.Length);
                //timg = tbr.ReadBytes((int)ts.Length);

                //string query = "UPDATE airbnb_Rooms SET room_Type = '" + _Registration.temp_RoomType + "', room_Price = '" + textBox_omRoomPrice.Text + "', room_Capacity = '" + comboBox_omRoomGuestCap.SelectedItem.ToString() + "' , room_Bedrooms = '" + comboBox_omNumRooms.SelectedItem.ToString() + "', room_Amneties = '" + richTextBox_omRoomAmenities.Text + "', room_Location = '" + comboBox_omLocation.SelectedItem.ToString() + "', room_Address = '" + textBox_omAddress + "',      ";
                //string query = "UPDATE airbnb_Rooms SET room_Type=@Type, room_Price=@Price, room_Capacity=@Capacity, room_Bedroom=@Bednum, room_Amenities=@Amenities, room_Location=@Location, room_Address=@Address, room_FirstImage=@fImg, room_SecondImage=@sImg, room_ThirdImage=@tImg";
                //using (SqlCommand sqlCommand = new SqlCommand("UPDATE airbnb_Rooms SET room_Type=@room_Type, room_Price=@room_Price, room_Capacity=@room_Capacity, room_Bedroom=@room_Bedroom, room_Amenities=@room_Amenities, room_Location=@room_Location, room_Address=@room_Address, room_FirstImage=@fimg, room_SecondImage=@simg, room_ThirdImage=@timg" + "WHERE roomID=@roomID", sqlConnection))
                using (SqlCommand sqlCommand = new SqlCommand("UPDATE airbnb_Rooms SET room_Type=@room_Type, room_Price=@room_Price, room_Capacity=@room_Capacity, room_Bedrooms=@room_Bedrooms, room_Amenities=@room_Amenities, room_Location=@room_Location, room_Address=@room_Address WHERE room_ID=@room_ID", sqlConnection))
                {
                    sqlConnection.Open();
                    //sqlCommand.Parameters.AddWithValue("@ID", label_omRoomID.Text);
                    sqlCommand.Parameters.Add(new SqlParameter("@room_ID", label_omRoomID.Text));
                    sqlCommand.Parameters.Add(new SqlParameter("@room_Type", _Registration.temp_RoomType));
                    sqlCommand.Parameters.Add(new SqlParameter("@room_Price", textBox_omRoomPrice.Text));
                    sqlCommand.Parameters.Add(new SqlParameter("@room_Capacity", comboBox_omRoomGuestCap.SelectedItem.ToString()));
                    sqlCommand.Parameters.Add(new SqlParameter("@room_Bedrooms", comboBox_omNumRooms.SelectedItem.ToString()));
                    sqlCommand.Parameters.Add(new SqlParameter("@room_Amenities", richTextBox_omRoomAmenities.Text));
                    sqlCommand.Parameters.Add(new SqlParameter("@room_Location", comboBox_omLocation.SelectedItem.ToString()));
                    sqlCommand.Parameters.Add(new SqlParameter("@room_Address", textBox_omAddress.Text));
                    //sqlCommand.Parameters.Add(new SqlParameter("@room_FirstImage", fimg));
                    //sqlCommand.Parameters.Add(new SqlParameter("@room_SecondImage", simg));
                    //sqlCommand.Parameters.Add(new SqlParameter("@room_ThirdImage", timg));
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("Room Updated"); 
                    sqlConnection.Close();
                    this.Hide();
                }
            }
            catch (Exception o)
            {
                MessageBox.Show(o.Message);
            }
        }
    }   
}
