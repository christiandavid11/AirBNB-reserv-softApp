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
using AirBNB.Model;
using AirBNB.View;

namespace AirBNB.View
{
    public partial class Form_ownerMenu : Form
    {
        public string email;
        public string pass;

        public int RoomID;
        public int OwnerID;

        Class_Registration _Registration = new Class_Registration();

        //UserControl_EditRoomFirst _RoomFirst = new UserControl_EditRoomFirst();
        //UserControl_AddRoom _AddRoom = new UserControl_AddRoom();

        public Form_ownerMenu()
        {
            InitializeComponent();
            //label_ownerMenuRoomID.Text = RoomID.ToString();
        }

        public Form_ownerMenu(int tempRoomID, int tempOwnID)
        {
            Edit(tempRoomID, tempOwnID);
        }

        private void panel_ownerMenuBorder_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
        Point lastPoint;

        private void panel_ownerMenuBorder_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void button_ownerMenuClose_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void button_ownerMenuClose_MouseHover(object sender, EventArgs e)
        {
            this.button_ownerMenuClose.BackColor = Color.Red;
        }

        private void button_ownerMenuClose_MouseLeave(object sender, EventArgs e)
        {
            this.button_ownerMenuClose.BackColor = Color.Transparent;
        }

        private void button_ownerMenuAddRoom_Click(object sender, EventArgs e)
        {
            UserControl_AddRoom _AddRoom = new UserControl_AddRoom();

            _AddRoom.OwnerID = OwnerID;
            //_AddRoom.Indicator = "Add";
            panel_ownerMenuContainer.Controls.Add(_AddRoom);
            _AddRoom.Dock = DockStyle.Fill;
            _AddRoom.BringToFront();
        }

        private void Form_ownerMenu_Load(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(_Registration.connectionString);
            connection.Open();
            try
            {
                string query = "SELECT * FROM airbnb_Customers WHERE id_Customer = '" + OwnerID + "' ";
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            if (Convert.ToInt32(reader["id_Customer"]) == OwnerID)
                            {
                                _Registration.temp_OwnerID = Convert.ToInt32(reader["id_Customer"]);
                                _Registration.temp_Purpose = reader["purpose_Customer"].ToString();
                                _Registration.temp_FirstName = reader["fName_Customer"].ToString();
                                _Registration.temp_LastName = reader["lName_Customer"].ToString();
                                _Registration.temp_Address = reader["address_Customer"].ToString();
                                _Registration.temp_Month = reader["bMonth_Customer"].ToString();
                                _Registration.temp_Date = Convert.ToInt32(reader["bDate_Customer"]);
                                _Registration.temp_Year = Convert.ToInt32(reader["bYear_Customer"]);
                                _Registration.temp_Age = Convert.ToInt32(reader["age_Customer"]);
                                _Registration.temp_ContactNumber = reader["conNumber_Customer"].ToString();
                                _Registration.temp_Email = reader["email_Customer"].ToString();
                                _Registration.temp_Password = reader["password_Customer"].ToString();
                            }
                        }
                    }
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
            connection.Close();
        }

        public void Edit(int rID, int oID)
        {
            //UserControl_ownerEditRoom _OwnerEditRoom = new UserControl_ownerEditRoom(rID, oID);
            //_OwnerEditRoom.edit_RoomID = rID;
            //_OwnerEditRoom.edit_OwnerID = oID;
            //this.Hide();
            //panel_ownerMenuContainer.Controls.Add(_OwnerEditRoom);
            //_OwnerEditRoom.Dock = DockStyle.Fill;
            //_OwnerEditRoom.BringToFront();
            //UserControl_EditRoomFirst _RoomFirst = new UserControl_EditRoomFirst();
            //_RoomFirst.ownerID = OwnerID;
            ////_AddRoom.Hide();
            //panel_ownerMenuContainer.Controls.Add(_RoomFirst);
            //_RoomFirst.Dock = DockStyle.Fill;
            //_RoomFirst.BringToFront();
        }

        private void button_ownerMenuViewRoom_Click(object sender, EventArgs e)
        {
            UserControl_EditRoomFirst _RoomFirst = new UserControl_EditRoomFirst();
            //MessageBox.Show(OwnerID.ToString());
            _RoomFirst.ownerID = OwnerID;
            //_AddRoom.Hide();
            panel_ownerMenuContainer.Controls.Add(_RoomFirst);
            _RoomFirst.Dock = DockStyle.Fill;
            _RoomFirst.BringToFront();

            //Form_FinalEditRoom _FinalEditRoom = new Form_FinalEditRoom();
            //_FinalEditRoom.edit_OwnerID = OwnerID;
            //_FinalEditRoom.TopLevel = false;
            //_FinalEditRoom.AutoScroll = true;
            //panel_ownerMenuContainer.Controls.Add(_FinalEditRoom);
            //_FinalEditRoom.Show();
        }

        private void button_ViewHistory_Click(object sender, EventArgs e)
        {
            UserControl_RentHistory _RentHistory = new UserControl_RentHistory();
            _RentHistory.OwnerID = OwnerID.ToString();
            panel_ownerMenuContainer.Controls.Add(_RentHistory);
            _RentHistory.Dock = DockStyle.Fill;
            _RentHistory.BringToFront();
        }

        private void button_ownerMenuLogout_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
        }

        //public void UpdateLoad(int _roomID)
        //{
        //    UserControl_AddRoom _AddRoom = new UserControl_AddRoom();
        //    UserControl_EditRoomFirst _EditRoomFirst = new UserControl_EditRoomFirst();

        //    //foreach (Control c in _EditRoomFirst.flowLayoutPanel_ucrlRoomList.Controls)
        //    //{
        //    //    _EditRoomFirst.flowLayoutPanel_ucrlRoomList.Controls.Remove(c);
        //    //    c.Dispose();
        //    //}

        //    //_AddRoom.Indicator = "Edit";
        //    ////_AddRoom.OwnerID = OwnerID;
        //    //_RoomFirst.Show();
        //    _AddRoom.RoomID = RoomID;
        //    panel_ownerMenuContainer.Controls.Add(_AddRoom);
        //    _AddRoom.Dock = DockStyle.Fill;
        //    _AddRoom.BringToFront();

        //    //Form_FinalEditRoom _FinalEditRoom = new Form_FinalEditRoom();
        //    //_FinalEditRoom.TopLevel = false;
        //    //_FinalEditRoom.AutoScroll = true;
        //    //panel_ownerMenuContainer.Controls.Add(_FinalEditRoom);
        //    //_FinalEditRoom.Show();
        //}
    }
}
