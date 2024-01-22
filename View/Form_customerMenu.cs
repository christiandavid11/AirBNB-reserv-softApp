using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AirBNB.View;
using AirBNB.Model;
using System.Data.SqlClient;
using System.IO;

namespace AirBNB.View
{
    public partial class Form_customerMenu : Form
    {
        Class_Registration _Registration = new Class_Registration();

        public string email;
        public string pass;
        public int ID;

        public Form_customerMenu()
        {
            InitializeComponent();
        }

        //public Form_customerMenu(string temp)
        //{
        //    //panel_cusMenuRoomContainer panel_ = new panel_cusMenuRoomContainer();
        //    //label_cusMenuRoomPrice label = new label_cusMenuRoomPrice;
        //    //panel_cusMenuRoomContainer.Controls.Clear();
        //    //UserControl_cusMenuRoomParttwo _CusMenuRoomParttwo = new UserControl_cusMenuRoomParttwo();
        //    //_CusMenuRoomParttwo.loadThisForm(temp);
        //    //panel_cusMenuRoomContainer.Controls.Add(_CusMenuRoomParttwo);
        //    //_CusMenuRoomParttwo.Dock = DockStyle.Fill;
        //    //_CusMenuRoomParttwo.BringToFront();

        //    //Form_cusViewRoom _CusViewRoom = new Form_cusViewRoom() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
        //    //_CusViewRoom.temp = temp;
        //    //this.panel_cusMenuRoomContainer.Controls.Add(_CusViewRoom);
        //    //_CusViewRoom.Show();
        //}

        //public void loadAnother(string temp)
        //{
        //    //MessageBox.Show(temp);
        //    //panel_cusMenuRoomContainer.Controls.Clear();
        //    //UserControl_cusMenuRoomParttwo _CusMenuRoomParttwo = new UserControl_cusMenuRoomParttwo();
        //    //_CusMenuRoomParttwo.loadThisForm(temp);
        //    //panel_cusMenuRoomContainer.Controls.Add(_CusMenuRoomParttwo);
        //    //_CusMenuRoomParttwo.Dock = DockStyle.Fill;
        //    //_CusMenuRoomParttwo.BringToFront();
        //    Form_cusViewRoom _CusViewRoom = new Form_cusViewRoom();
        //    _CusViewRoom.temp = temp;
        //    _CusViewRoom.TopLevel = false;
        //    _CusViewRoom.AutoScroll = false;
        //    this.panel_cusMenuRoomContainer.Controls.Add(_CusViewRoom);
        //    _CusViewRoom.Show();
        //}

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

        private void button_cusMemuClose_MouseClick(object sender, MouseEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void button_cusMemuClose_MouseHover(object sender, EventArgs e)
        {
            button_cusMemuClose.BackColor = Color.Red;
        }

        private void button_cusMemuClose_MouseLeave(object sender, EventArgs e)
        {
            button_cusMemuClose.BackColor = Color.Transparent;
        }

        private void Form_customerMenu_Load(object sender, EventArgs e)
        {
            flowLayoutPanel_cusMenu.Controls.Clear();
            loadData();
        }

        public void loadData()
        {
            SqlConnection sqlConnection = new SqlConnection(_Registration.connectionString);

            sqlConnection.Open();
            try
            {
                string query = "SELECT * FROM airbnb_Rooms";
                using (SqlCommand sqlCommand = new SqlCommand(query, sqlConnection))
                {
                    SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                    if (sqlDataReader.HasRows)
                    {
                        while (sqlDataReader.Read())
                        {
                            //MessageBox.Show(sqlDataReader[0].ToString() + "  " + sqlDataReader[1].ToString() + "  " + sqlDataReader[2].ToString() + " " + sqlDataReader[6].ToString() + " " + sqlDataReader[7].ToString());
                            UserControl_cusRoomList _CusRoomList = new UserControl_cusRoomList();
                            byte[] img = (byte[])(sqlDataReader[13]);
                            //MessageBox.Show(sqlDataReader[7].ToString());
                            _CusRoomList.userLoad(ID.ToString(), sqlDataReader[0].ToString(), sqlDataReader[1].ToString(), sqlDataReader[7].ToString(), sqlDataReader[12].ToString(), img);
                            flowLayoutPanel_cusMenu.Controls.Add(_CusRoomList);
                        }
                    }
                }
            }
            catch (Exception z)
            {
                MessageBox.Show(z.Message);
            }
            sqlConnection.Close();
        }

        private void comboBox_cusSearchBox_SelectedValueChanged(object sender, EventArgs e)
        {
            flowLayoutPanel_cusMenu.Controls.Clear();
            if (comboBox_cusSearchBox.SelectedItem.ToString() == "VIEW ALL")
            {
                loadData();
            }
            else
            {
                SqlConnection sqlConnection = new SqlConnection(_Registration.connectionString);

                //flowLayoutPanel_cusMenu.Controls.Clear();
                sqlConnection.Open();
                try
                {
                    string query = "SELECT * FROM airbnb_Rooms WHERE room_Location = '" + comboBox_cusSearchBox.SelectedItem.ToString() + "' ";
                    using (SqlCommand sqlCommand = new SqlCommand(query, sqlConnection))
                    {
                        SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                        if (sqlDataReader.HasRows)
                        {
                            while (sqlDataReader.Read())
                            {
                                if (sqlDataReader[11].ToString() == comboBox_cusSearchBox.SelectedItem.ToString())
                                {
                                    UserControl_cusRoomList _CusRoomList = new UserControl_cusRoomList();
                                    byte[] img = (byte[])(sqlDataReader[13]);
                                    _CusRoomList.userLoad(ID.ToString(), sqlDataReader[0].ToString(), sqlDataReader[1].ToString(), sqlDataReader[7].ToString(), sqlDataReader[12].ToString(), img);
                                    flowLayoutPanel_cusMenu.Controls.Add(_CusRoomList);
                                }
                            }
                        }
                    }
                }
                catch (Exception z)
                {
                    MessageBox.Show(z.Message);
                }
                sqlConnection.Close();
            }     
        }

        private void button_cusMakeCommentScores_Click(object sender, EventArgs e)
        {
            Form_customerCommentsRates _CustomerCommentsRates = new Form_customerCommentsRates();
            _CustomerCommentsRates.cusID = ID.ToString();
            _CustomerCommentsRates.cusPassword = pass;
            _CustomerCommentsRates.Show();
        }

        private void button_cusLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void button_Refresh_Click(object sender, EventArgs e)
        {
            flowLayoutPanel_cusMenu.Controls.Clear();
            loadData();
        }

        //public void UpadateLatest()
        //{ 
        //    SqlConnection sqlConnection = new SqlConnection(_Registration.connectionString);

        //    try
        //    {
        //        string query = "SELECT * FROM airbnb_RentHistory";
        //        using (SqlCommand sqlCommand = new SqlCommand(query, sqlConnection))
        //        {
        //            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
        //            if (sqlDataReader.HasRows)
        //            {
        //                while (sqlDataReader.Read())
        //                {

        //                }
        //            }
        //        }
        //    }
        //    catch (Exception f)
        //    {
        //        MessageBox.Show(f.Message);
        //    }
        //}

        //public bool checkDate(string dataDate)
        //{
        //    DateTime date = DateTime.Now;
        //    string dateNow = date.ToString("yyyy'-'MM'-'dd");
        //    string[] dDate = dateNow.Split('-');

        //    DateTime daDate = Convert.ToDateTime(dataDate);
        //    string datDate = daDate.ToString("yyyy'-'MM'-'dd");
        //    string[] sDate = datDate.Split('-');



        //    return false;
        //}

        //public void updateRentHistory()
        //{

        //}
    }
}
