using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using AirBNB.View;
using AirBNB.Model;
using System.IO;

namespace AirBNB.View
{
    public partial class Form_roomRegistration : Form
    {
        Class_Registration _Registration = new Class_Registration();
        SqlCommand command;

        public string roomType;
        public bool check = false;      //for checking before closing button
        public bool check_Sec = false;  //
        public string tempID;

        public String first_ImageLocation = "";
        public String second_ImageLocation = "";
        public String third_ImageLocation = "";


        public Form_roomRegistration()
        {
            InitializeComponent();
        }

        private void button_roomRegClose_Click(object sender, EventArgs e)
        {
            if (check == false)
            {
                MessageBox.Show("Complete the Registration First");
            }
            else
            {
                this.Close();
                System.Windows.Forms.Application.Exit();
            }
        }

        private void button_roomRegClose_MouseHover(object sender, EventArgs e)
        {
            button_roomRegClose.BackColor = Color.Red;
        }

        private void button_roomRegClose_MouseLeave(object sender, EventArgs e)
        {
            button_roomRegClose.BackColor = Color.Transparent;
        }

        private void panel_roomRegBorder_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
        Point lastPoint;

        private void panel_roomRegBorder_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void checkBox_regRoomEntirePlace_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_regRoomEntirePlace.Checked == true)
            {
                checkBox_regRoomPrvtRoom.Checked = false;
                checkBox_regRoomShrdRoom.Checked = false;
            }
            roomType = checkBox_regRoomEntirePlace.Text;
        }

        private void checkBox_regRoomPrvtRoom_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_regRoomPrvtRoom.Checked == true)
            {
                checkBox_regRoomEntirePlace.Checked = false;
                checkBox_regRoomShrdRoom.Checked = false;
            }
            roomType = checkBox_regRoomPrvtRoom.Text;
        }

        private void checkBox_regRoomShrdRoom_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_regRoomShrdRoom.Checked == true)
            {
                checkBox_regRoomEntirePlace.Checked = false;
                checkBox_regRoomPrvtRoom.Checked = false;

            }
            roomType = checkBox_regRoomShrdRoom.Text;
        }

        private void pictureBox_FirstRegImage_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(*.jpg)|*.jpg| PNG files(*.png)|*.png| All Files(*.*)|*.*";

                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    first_ImageLocation = dialog.FileName;
                    pictureBox_FirstRegImage.ImageLocation = first_ImageLocation;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error Image");
            }
        }

        private void pictureBox_SecondRegImage_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(*.jpg)|*.jpg| PNG files(*.png)|*.png| All Files(*.*)|*.*";

                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    second_ImageLocation = dialog.FileName;
                    pictureBox_SecondRegImage.ImageLocation = second_ImageLocation;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error Image");
            }
        }

        private void pictureBox_ThirdRegImage_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(*.jpg)|*.jpg| PNG files(*.png)|*.png| All Files(*.*)|*.*";
                dialog.Title = "Select a Picture for your Airbnb";

                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    third_ImageLocation = dialog.FileName;
                    pictureBox_ThirdRegImage.ImageLocation = third_ImageLocation;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error Image");
            }
        }

        private void Form_roomRegistration_Load(object sender, EventArgs e)
        {
            textBox_RegRoomID.Text = Convert.ToString(_Registration.code.Next(1000,9999));
            textBox_RoomOwnerID.Text = tempID;
            //textBox_Reg_ID.Text = Convert.ToString(class_Registration.code.Next(100000, 999999));
        }

        private void button_RegRoomSubmit_Click(object sender, EventArgs e)
        {
            Check();
            if (check_RoomType() == true && check_Images() == true && check_Sec == false)
            {
                //MessageBox.Show("naay check");
                Save();
            }
            else
            {
                MessageBox.Show("Fill up Requirements");
                check_Sec = false;
            }
        }

        public bool check_RoomType()
        {
            if (checkBox_regRoomEntirePlace.Checked == true || checkBox_regRoomPrvtRoom.Checked == true || checkBox_regRoomShrdRoom.Checked == true)
            {
                return true;
            }
            return false;
        }

        public void Check()
        {
            foreach (Control control in this.Controls)
            {
                if (this.Controls.OfType<TextBox>().Any(t => string.IsNullOrEmpty(t.Text)))
                {
                    check_Sec = true;
                    break;
                }
            }
        }

        public bool check_Images()
        {
            if (pictureBox_FirstRegImage.Image != null && pictureBox_SecondRegImage.Image != null && pictureBox_ThirdRegImage.Image != null && richTextBox_regRoomAmenities.Text != "")
            {
                return true;
            }
            return false;
        }

        public void Save()
        {
            SqlConnection sqlConnection = new SqlConnection(_Registration.connectionString);

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

                string query = "insert into airbnb_Rooms (room_ID, room_OwnerID, room_Type, room_Price, room_Capacity, room_Bedrooms, room_Amenities, room_Availability, room_Rentee, room_DateRented, room_DateRentEnd, room_Location, room_Address, room_FirstImage, room_SecondImage, room_ThirdImage)values('" + this.textBox_RegRoomID.Text + "' , '" + textBox_RoomOwnerID.Text + "' , '" + roomType +"' , '" + this.textBox_regRoomPrice.Text + "' , '" + this.comboBox_regRoomGuestCap.SelectedItem.ToString() + "' , '" + this.comboBox_regNumRooms.SelectedItem.ToString() + "' , '" + this.richTextBox_regRoomAmenities.Text + "' , '" + "Available" + "' , '" + "None" +"' , '" + null + "' , '" + null + "' , '" + this.comboBox_regRoomLocation.SelectedItem.ToString() + "' , '" + this.textBox_regRoomAddress.Text + "' , @f_img , @s_img , @t_img)";
                sqlConnection.Open();
                command = new SqlCommand(query, sqlConnection);
                command.Parameters.Add(new SqlParameter("@f_img",f_img));
                command.Parameters.Add(new SqlParameter("@s_img", s_img));
                command.Parameters.Add(new SqlParameter("@t_img", t_img));
                int q = command.ExecuteNonQuery();
                MessageBox.Show("Registered");
                check = true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            sqlConnection.Close();
            Form1 form = new Form1();
            this.Hide();
            form.Show();
        }
    }
}