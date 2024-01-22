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
    public partial class UserControl_cusLoadComments : UserControl
    {
        Class_Registration _Registration = new Class_Registration();

        public string casID;
        public string casRoomID;

        public UserControl_cusLoadComments()
        {
            InitializeComponent();
        }

        public void displayCommentsScores(string RoomID, string roomType, string dateRented, string Comment, string Score)
        {
            DateTime date = Convert.ToDateTime(dateRented);
            string dDate = date.ToString("yyyy'-'MM'-'dd");
            label_casRoomID.Text = RoomID;
            label_casRoomType.Text = roomType;
            label_casDateRented.Text = dDate;
            label_Comment.Text = Comment;
            label_Score.Text = Score;
        }

        private void button_casCommentScore_Click(object sender, EventArgs e)
        {
            DateTime date = DateTime.Now;
            string d = date.ToString("yyyy'-'MM'-'dd");
            string[] dd = d.Split('-');
            string[] dr = label_casDateRented.Text.ToString().Split('-');

            if (Convert.ToInt32(dd[2]) >= Convert.ToInt32(dr[2]))
            {
                //Form_customerCommentsRates _CustomerCommentsRates = new Form_customerCommentsRates(label_casRoomID.Text, casID);
                Form_casAddCommentScores _CasAddCommentScore = new Form_casAddCommentScores();
                _CasAddCommentScore.addRoomID = label_casRoomID.Text;
                _CasAddCommentScore.addRenteeID = casID;
                _CasAddCommentScore.addDateRented = label_casDateRented.Text;
                _CasAddCommentScore.Show();
            }
            else
            {
                MessageBox.Show("Can't add comments yet.");
            }
        }
    }
}
