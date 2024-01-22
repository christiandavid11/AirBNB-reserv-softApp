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
    public partial class UserControl_cusRoomList : UserControl
    {
        Class_Registration _Registration = new Class_Registration();

        public string roomID;
        public string ownerID;
        public string customerid;
        public string roomType;

        public UserControl_cusRoomList()
        {
            InitializeComponent();
        }

        public void userLoad(string cusID, string roomID, string OwnID, string Status, string roomAddress, byte[] img)
        {
            customerid = cusID;
            ownerID = OwnID;
            label_userCusRoomID.Text = roomID;
            label_userCusAddress.Text = roomAddress;
            MemoryStream ms = new MemoryStream(img);
            pictureBox_userCus.Image = Image.FromStream(ms);
            label_Status.Text = Status;
            if (label_Status.Text == "RESERVED")
            {
                label_Status.BackColor = Color.Red;
            }
            else
            {
                label_Status.BackColor = Color.Yellow;
            }
        }

        private void UserControl_cusRoomList_Click(object sender, EventArgs e)
        {
            //string temp = label_userCusRoomID.Text;
            //MessageBox.Show(label_userCusRoomID.Text);
            //Form_customerMenu _CustomerMenu = new Form_customerMenu();
            //_CustomerMenu.label_formCusRoomPrice.Text = label_userCusRoomID.Text;
            Form_cusViewRoom form_ = new Form_cusViewRoom();
            form_.form_cusViewRoomID = label_userCusRoomID.Text;
            form_.customerID = customerid;
            form_.owner_ID = ownerID;
            form_.Status = label_Status.Text;
            form_.Show();
            Form_customerMenu _CustomerMenu = new Form_customerMenu();
            _CustomerMenu.Hide();
        }

        private void UserControl_cusRoomList_Load(object sender, EventArgs e)
        {

        }
    }
}
