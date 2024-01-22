using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web.UI.WebControls;
using AirBNB.Model;
using AirBNB.View;
using System.Data.SqlClient;
using System.IO;

namespace AirBNB.View
{
    public partial class UserControl_EditRoomFirst : UserControl
    {
        Class_Registration _Registration = new Class_Registration();

        public int ownerID;
        public int roomID;

        Form_ownerMenu _OwnerMenu = new Form_ownerMenu();

        public UserControl_EditRoomFirst()
        {
            InitializeComponent();
            //MessageBox.Show(ownerID.ToString());
        }

        public UserControl_EditRoomFirst(int temp, int ownid)
        {
            Form_ownerManageRooms _OwnerManageRooms = new Form_ownerManageRooms();
            _OwnerManageRooms.ownerManage_roomID = temp;
            _OwnerManageRooms.ownerManage_ownerID = ownid;
            _OwnerManageRooms.Show();       
            //if (indi == "Edit")
            //{
            //    Form_ownerManageRooms = 
            //    //UserControl_ownerEditRoom _OwnerEditRoom = new UserControl_ownerEditRoom(temp, roomID);
            //    //_OwnerMenu.panel_ownerMenuContainer.Controls.Add(_OwnerEditRoom);
            //    //_OwnerEditRoom.Dock = DockStyle.Fill;
            //    //_OwnerEditRoom.BringToFront();
            //}
            //else
            //{
            //    //MessageBox.Show(temp.ToString()+" , "+ownid.ToString());
            //    //deleteRoom(temp);
            //    this.Hide();
            //    //_OwnerMenu
            //    //flowLayoutPanel_ucrlRoomList.Controls.Clear();
            //    //populate();
            //}
        }

        private void UserControl_EditRoomFirst_Load(object sender, EventArgs e)
        {
            populate();
            //populateItems();

            //SqlConnection sqlConnection = new SqlConnection(_Registration.connectionString);
            ////UserControl_roomList _RoomList = new UserControl_roomList();
            //sqlConnection.Open();
            //try
            //{
            //    string sql = "SELECT * FROM airbnb_Rooms WHERE room_OwnerID = '" + ownerID + "' ";
            //    using (SqlCommand sqlCommand = new SqlCommand(sql, sqlConnection))
            //    {
            //        SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            //        if (sqlDataReader.HasRows)
            //        {
            //            while (sqlDataReader.Read())
            //            {
            //                //UserControl_roomList _RoomList = new UserControl_roomList();
            //                //byte[] img = (byte[])(sqlDataReader[13]);
            //                //_RoomList.formLoad(sqlDataReader[0].ToString(), sqlDataReader[2].ToString(), Convert.ToInt32(sqlDataReader[3]), img);
            //                //flowLayoutPanel_ucrlRoomList.Controls.Add(_RoomList);
            //                if (Convert.ToInt32(sqlDataReader["room_OwnerID"]) == ownerID)
            //                {
            //                    UserControl_roomList _RoomList = new UserControl_roomList();
            //                    byte[] img = (byte[])(sqlDataReader[13]);
            //                    _RoomList.formLoad(sqlDataReader[0].ToString(), sqlDataReader[2].ToString(), Convert.ToInt32(sqlDataReader[3]), img);
            //                    flowLayoutPanel_ucrlRoomList.Controls.Add(_RoomList);
            //                }
            //            }
            //        }
            //    }
            //}
            //catch (Exception q)
            //{
            //    MessageBox.Show(q.Message);
            //}
            ////_RoomList.ownID = ownerID;
            //sqlConnection.Close();
        }

        public void populate()
        {
            SqlConnection sqlConnection = new SqlConnection(_Registration.connectionString);
            //UserControl_roomList _RoomList = new UserControl_roomList();
            sqlConnection.Open();
            //flowLayoutPanel_ucrlRoomList.Controls.Clear();
            //MessageBox.Show(ownerID.ToString());
            try
            {
                string sql = "SELECT * FROM airbnb_Rooms WHERE room_OwnerID = '" + ownerID + "' ";
                using (SqlCommand sqlCommand = new SqlCommand(sql, sqlConnection))
                {
                    SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                    if (sqlDataReader.HasRows)
                    {
                        while (sqlDataReader.Read())
                        {
                            //UserControl_roomList _RoomList = new UserControl_roomList();
                            //byte[] img = (byte[])(sqlDataReader[13]);
                            //_RoomList.formLoad(sqlDataReader[0].ToString(), sqlDataReader[2].ToString(), Convert.ToInt32(sqlDataReader[3]), img);
                            //flowLayoutPanel_ucrlRoomList.Controls.Add(_RoomList);
                            if (Convert.ToInt32(sqlDataReader["room_OwnerID"]) == ownerID)
                            {
                                UserControl_roomList _RoomList = new UserControl_roomList();
                                byte[] img = (byte[])(sqlDataReader[13]);
                                _RoomList.formLoad(sqlDataReader[0].ToString(), sqlDataReader[1].ToString(), sqlDataReader[2].ToString(), Convert.ToInt32(sqlDataReader[3]), img);
                                flowLayoutPanel_ucrlRoomList.Controls.Add(_RoomList);
                            }
                        }
                    }
                }
            }
            catch (Exception q)
            {
                MessageBox.Show(q.Message);
            }
            //_RoomList.ownID = ownerID;
            sqlConnection.Close();
        }

        //public void populateItems()
        //{
        //    UserControl_roomList[] _RoomLists = new UserControl_roomList[50];
        //    for ()
        //}

        //public void deleteRoom(int temp)
        //{
        //    SqlConnection sqlConnection = new SqlConnection(_Registration.connectionString);

        //    sqlConnection.Open();
        //    try
        //    {
        //        string query = "DELETE FROM airbnb_Rooms WHERE room_ID = '" + temp.ToString() + "' ";
        //        using (SqlCommand sqlCommand = new SqlCommand(query, sqlConnection))
        //        {
        //            sqlCommand.ExecuteNonQuery();
        //        }
        //        sqlConnection.Close();
        //    }
        //    catch (Exception q)
        //    {
        //        MessageBox.Show(q.Message);
        //    }
        //}
    }
}
