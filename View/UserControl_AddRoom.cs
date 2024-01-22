using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
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
    public partial class UserControl_AddRoom : UserControl
    {
        Class_Registration _Registration = new Class_Registration();

        public string RoomType; //for checkboxes

        public int OwnerID;
        public int RoomID;

        public String first_ImageLocation = "";
        public String second_ImageLocation = "";
        public String third_ImageLocation = "";

        public bool check_textBox = false; //check all textbox

        //public string Indicator;
        public UserControl_AddRoom()
        {
            InitializeComponent();
        }        
        
        private void UserControl_AddRoom_Load(object sender, EventArgs e)
        {
            textBox_addRoomID.Text = Convert.ToString(_Registration.code.Next(1000, 9999));
            //if (Indicator == "Add")
            //{
            //    textBox_addRoomID.Text = Convert.ToString(_Registration.code.Next(1000, 9999));
            //    Indicator = string.Empty;
            //    panel_Status.Visible = false;
            //}
            //else if (Indicator == "Edit")
            //{
            //    panel_Status.Visible = true;
            //    Indicator = string.Empty;
            //    Retrieve();
            //}
            //else
            //{

            //}
        }

        private void checkBox_addRoomEntirePlace_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_addRoomEntirePlace.Checked == true)
            {
                checkBox_addRoomPrvtRoom.Checked = false;
                checkBox_addRoomShrdRoom.Checked = false;
            }
            RoomType = checkBox_addRoomEntirePlace.Text;
        }

        private void checkBox_addRoomPrvtRoom_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_addRoomPrvtRoom.Checked == true)
            {
                checkBox_addRoomEntirePlace.Checked = false;
                checkBox_addRoomShrdRoom.Checked = false;
            }
            RoomType = checkBox_addRoomPrvtRoom.Text;
        }

        private void checkBox_addRoomShrdRoom_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_addRoomShrdRoom.Checked == true)
            {
                checkBox_addRoomEntirePlace.Checked = false;
                checkBox_addRoomPrvtRoom.Checked = false;
            }
            RoomType = checkBox_addRoomShrdRoom.Text;
        }

        private void pictureBox_addFirstImage_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(*.jpg)|*.jpg| PNG files(*.png)|*.png| All Files(*.*)|*.*";

                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    first_ImageLocation = dialog.FileName;
                    pictureBox_addFirstImage.ImageLocation = first_ImageLocation;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error Image");
            }
        }

        private void pictureBox_addSecondImage_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(*.jpg)|*.jpg| PNG files(*.png)|*.png| All Files(*.*)|*.*";

                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    second_ImageLocation = dialog.FileName;
                    pictureBox_addSecondImage.ImageLocation = second_ImageLocation;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error Image");
            }
        }

        private void pictureBox_addThirdImage_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(*.jpg)|*.jpg| PNG files(*.png)|*.png| All Files(*.*)|*.*";

                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    third_ImageLocation = dialog.FileName;
                    pictureBox_addThirdImage.ImageLocation = third_ImageLocation;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error Image");
            }
        }        
        
        private void button_ownerMenuAddRoom_Click(object sender, EventArgs e)
        {
            Check();
            if (check_RoomType() == true && check_Images() == true && check_textBox == false)
            {
                //MessageBox.Show("naay check");
                Save();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Fill up Requirements");
                check_textBox = false;
            }
        }

        public void Check() 
        {
            foreach (Control control in this.Controls)
            {
                if (this.Controls.OfType<TextBox>().Any(t => string.IsNullOrEmpty(t.Text)))
                {
                    check_textBox = true;
                    break;
                }
            }
        }

        public bool check_RoomType()
        {
            if (checkBox_addRoomEntirePlace.Checked == true || checkBox_addRoomPrvtRoom.Checked == true || checkBox_addRoomShrdRoom.Checked == true)
            {
                return true;
            }
            return false;
        }

        public bool check_Images()
        {
            if (pictureBox_addFirstImage.Image != null && pictureBox_addSecondImage.Image != null && pictureBox_addThirdImage.Image != null && richTextBox_addRoomAmenities.Text != "")
            {
                return true;
            }
            return false;
        }

        public void Save()
        {
            SqlConnection sql = new SqlConnection(_Registration.connectionString);
            SqlCommand command;
            try
            {
                byte[] f_img = null;
                byte[] s_img = null;
                byte[] t_img = null;
                FileStream fs = new FileStream(first_ImageLocation, FileMode.Open, FileAccess.Read);
                FileStream ss = new FileStream(second_ImageLocation, FileMode.Open, FileAccess.Read);
                FileStream ts = new FileStream(third_ImageLocation, FileMode.Open, FileAccess.Read);
                BinaryReader f_BinaryReader = new BinaryReader(fs);
                BinaryReader s_BinaryReader = new BinaryReader(ss);
                BinaryReader t_BinaryReader = new BinaryReader(ts);
                f_img = f_BinaryReader.ReadBytes((int)fs.Length);
                s_img = s_BinaryReader.ReadBytes((int)ss.Length);
                t_img = t_BinaryReader.ReadBytes((int)ts.Length);

                string query = "INSERT INTO airbnb_Rooms (room_ID, room_OwnerID, room_Type, room_Price, room_Capacity, room_Bedrooms, room_Amenities, room_Availability, room_Rentee, room_DateRented, room_DateRentEnd, room_Location, room_Address, room_FirstImage, room_SecondImage, room_ThirdImage)values('" + textBox_addRoomID.Text+ "' , '" + OwnerID + "' , '" + RoomType + "' , '" + textBox_addRoomPrice.Text + "' , '" + comboBox_addRoomGuestCap.SelectedItem.ToString() + "' , '" + comboBox_addNumRooms.SelectedItem.ToString() + "' , '" + richTextBox_addRoomAmenities.Text + "' , '" + "AVAILABLE" + "' , '" + "NONE" + "' , '"  + null + "' , '" + null + "' ,  '" + comboBox_addRoomLocation.SelectedItem.ToString() + "' , '" + textBox_addRoomAddress.Text + "' , @f_img, @s_img, @t_img)";

                sql.Open();
                command = new SqlCommand(query, sql);
                command.Parameters.Add(new SqlParameter("@f_img", f_img));
                command.Parameters.Add(new SqlParameter("@s_img", s_img));
                command.Parameters.Add(new SqlParameter("@t_img", t_img));
                int q = command.ExecuteNonQuery();
                MessageBox.Show("Registered");

            }
            catch (Exception w)
            {
                MessageBox.Show(w.Message);
            }
            sql.Close();
            ClearAll();
        }

        public void ClearAll()
        {
            foreach (Control control in this.Controls)
            {
                if (control is TextBox)
                {
                    (control as TextBox).Clear();
                }
            }

            checkBox_addRoomEntirePlace.Checked = false;
            checkBox_addRoomPrvtRoom.Checked = false;
            checkBox_addRoomShrdRoom.Checked = false;

            comboBox_addNumRooms.Text = string.Empty;
            comboBox_addRoomGuestCap.Text = string.Empty;
            comboBox_addRoomLocation.SelectedItem = "";

            pictureBox_addFirstImage.Image = null;
            pictureBox_addSecondImage.Image = null;
            pictureBox_addThirdImage.Image = null;

            richTextBox_addRoomAmenities.Text = "";

            textBox_addRoomID.Text = Convert.ToString(_Registration.code.Next(1000, 9999));
        }

        public void Retrieve()
        {                
            SqlConnection conn = new SqlConnection(_Registration.connectionString);
            conn.Open();
            try
            {
                string query = "SELECT * FROM airbnb_Rooms WHERE room_ID = '" + RoomID + "' ";
                using (SqlCommand sqlCommand = new SqlCommand(query, conn))
                {
                    SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                    if (sqlDataReader.HasRows)
                    {
                        while (sqlDataReader.Read())
                        {
                            if (Convert.ToInt32(sqlDataReader[0]) == RoomID)
                            {
                                textBox_addRoomID.Text = sqlDataReader[0].ToString();
                                RoomType = sqlDataReader[2].ToString();
                                if (RoomType == "Entire Place")
                                {
                                    checkBox_addRoomEntirePlace.Checked = true;
                                }
                                else if (RoomType == "Private Room")
                                {
                                    checkBox_addRoomPrvtRoom.Checked = true;
                                }
                                else
                                {
                                    checkBox_addRoomShrdRoom.Checked = true;
                                }
                                textBox_addRoomPrice.Text = sqlDataReader[3].ToString();
                                comboBox_addRoomGuestCap.SelectedItem = sqlDataReader[4].ToString();
                                comboBox_addNumRooms.SelectedItem = sqlDataReader[5].ToString();
                                richTextBox_addRoomAmenities.Text = sqlDataReader[6].ToString();
                                comboBox_addRoomLocation.SelectedItem = sqlDataReader[11].ToString();
                                textBox_addRoomAddress.Text = sqlDataReader[12].ToString();
                                byte[] f_img = (byte[])(sqlDataReader[13]);
                                byte[] s_img = (byte[])(sqlDataReader[14]);
                                byte[] t_img = (byte[])(sqlDataReader[15]);
                                //MemoryStream ms = new MemoryStream(image);
                                //pictureBox_roomList.Image = Image.FromStream(ms);
                                MemoryStream fms = new MemoryStream(f_img);
                                MemoryStream sms = new MemoryStream(s_img);
                                MemoryStream tms = new MemoryStream(t_img);
                                pictureBox_addFirstImage.Image = Image.FromStream(fms);
                                pictureBox_addSecondImage.Image = Image.FromStream(sms);
                                pictureBox_addThirdImage.Image = Image.FromStream(tms);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
