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
    public partial class Form_customerCommentsRates : Form
    {
        Class_Registration _Registration = new Class_Registration();

        public string cusID;
        public string cusPassword;

        public Form_customerCommentsRates()
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

        public void loadCommentsScore()
        {
            SqlConnection sqlConnection = new SqlConnection(_Registration.connectionString);

            sqlConnection.Open();
            try
            {
                string query = "SELECT * FROM airbnb_RentHistory WHERE rent_RenteeID = '" + cusID + "' ";
                using (SqlCommand sqlCommand = new SqlCommand(query, sqlConnection))
                {
                    SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                    if (sqlDataReader.HasRows)
                    {
                        while (sqlDataReader.Read())
                        {
                            if (sqlDataReader[2].ToString() == cusID)
                            {
                                UserControl_cusLoadComments _CusLoadComments = new UserControl_cusLoadComments();
                                _CusLoadComments.casID = cusID;
                                _CusLoadComments.displayCommentsScores(sqlDataReader[0].ToString(), sqlDataReader[9].ToString(), sqlDataReader[5].ToString(), sqlDataReader[8].ToString(), sqlDataReader[7].ToString());
                                flowLayoutPanel_cusLoadComments.Controls.Add(_CusLoadComments);
                            }
                        }
                    }
                }
            }
            catch (Exception f)
            {
                MessageBox.Show(f.Message);
            }
            sqlConnection.Close();
        }

        private void Form_customerCommentsRates_Load(object sender, EventArgs e)
        {
            loadCommentsScore();
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
    }
}
