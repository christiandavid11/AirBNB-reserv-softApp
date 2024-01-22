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
    public partial class UserControl_roomList : UserControl
    {
        Class_Registration _Registration = new Class_Registration();
        //Form_ownerMenu _OwnerMenu = new Form_ownerMenu();

        public int ownID;

        //Form_ownerMenu _OwnerMenu = new Form_ownerMenu();
        //UserControl_AddRoom _AddRoom = new UserControl_AddRoom();
        public UserControl_roomList()
        {
            InitializeComponent();
            //formLoad(string RoomID, string RoomType, int RoomPrice, byte[] image);
        }

        public void formLoad(string RoomID, string OwnID, string RoomType, int RoomPrice, byte[] image)
        {
            label_RoomID.Text = RoomID;
            ownID = Convert.ToInt32(OwnID);
            label_RoomType.Text = RoomType;
            label_RoomPrice.Text = RoomPrice.ToString();
            MemoryStream ms = new MemoryStream(image);
            pictureBox_roomList.Image = Image.FromStream(ms);
        }

        //private void button_ucrlDeleteRoom_Click(object sender, EventArgs e)
        //{
        //    SqlConnection sqlConnection = new SqlConnection(_Registration.connectionString);
        //    UserControl_EditRoomFirst _EditRoomFirst = new UserControl_EditRoomFirst();

        //    sqlConnection.Open();
        //    try
        //    {
        //        string query = "DELETE FROM airbnb_Rooms WHERE room_ID = '" + label_RoomID.Text + "' ";
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
        //    //_OwnerMenu.panel_ownerMenuContainer.Controls.Clear();
        //    //_EditRoomFirst.populate();
        //}

        private void UserControl_roomList_Click(object sender, EventArgs e)
        {
            //Form_ownerManageRooms _OwnerManageRooms = new Form_ownerManageRooms();
            ////_OwnerMenu.formHide();
            //_OwnerManageRooms.ownerManage_roomID = Convert.ToInt32(label_RoomID.Text);

            //_OwnerManageRooms.Show();
            //UserControl_EditRoomFirst user = new UserControl_EditRoomFirst("Delete", Convert.ToInt32(label_RoomID.Text));
        }

        private void button_ucrlDeleteRoom_Click(object sender, EventArgs e)
        {
            UserControl_EditRoomFirst user = new UserControl_EditRoomFirst(Convert.ToInt32(label_RoomID.Text), ownID);
        }


        //#region Properties
        //[Category("Custom Props")]
        //private string ucrl_RoomID;
        //public string _RoomID
        //{
        //    set { ucrl_RoomID = value; textBox_ucrlRoomID.Text = value; }
        //    get { return ucrl_RoomID; }
        //}


        //[Category("Custom Props")]
        //private string ucrl_RoomOwnerID;
        //public string _RoomOwnerID
        //{
        //    set { ucrl_RoomOwnerID = value; label_RoomOwnerID.Text = value; }
        //    get { return ucrl_RoomOwnerID; }
        //}


        //[Category("Custom Props")]
        //private string ucrl_RoomType;
        //public string _RoomType
        //{
        //    set { ucrl_RoomType = value; textBox_ucrlRoomType.Text = value; }
        //    get { return ucrl_RoomType; }
        //}

        //[Category("Custom Props")]
        //private int ucrl_RoomPrice;
        //public int _RoomPrice
        //{
        //    set { ucrl_RoomPrice = value; textBox_ucrlRoomPrice.Text = value.ToString(); }
        //    get { return ucrl_RoomPrice; }
        //}

        //[Category("Custom Props")]
        //private Image ucrl_RoomImage;
        //public Image _RoomImage
        //{
        //    set { ucrl_RoomImage = value; pictureBox_roomList.Image = value; }
        //    get { return ucrl_RoomImage; }
        //}
        //#endregion

        //public void Retrieve()
        //{
        //SqlConnection sqlConnection = new SqlConnection(_Registration.connectionString);
        //try
        //{
        //    string sql = "SESLECT room_UD, room_Type, room_Price, room_FirstImage, FROM airbnb_Rooms WHERE room_OwnerID = " + nID + " ";
        //    sqlConnection.Open();
        //    SqlCommand sqlCommand = new SqlCommand(sql, sqlConnection);
        //    SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
        //    sqlDataReader.Read();
        //    if (sqlDataReader.HasRows)
        //    {
        //        while(sqlDataReader.Read())
        //        {
        //            if (Convert.ToInt32(sqlDataReader["room_OwnerID"]) == nID)
        //            {

        //            }
        //        }
        //    }
        //}
        //catch (Exception q)
        //{
        //    MessageBox.Show(q.Message);
        //}
        //}
    }
}
