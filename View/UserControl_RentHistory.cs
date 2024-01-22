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
    public partial class UserControl_RentHistory : UserControl
    {
        Class_Registration _Registration = new Class_Registration();

        public string OwnerID;

        public UserControl_RentHistory()
        {
            InitializeComponent();
        }

        private void UserControl_RentHistory_Load(object sender, EventArgs e)
        {
            dataGridView_RentHistory.DataSource = load();
        }

        public DataTable load()
        {
            DataTable data = new DataTable();

            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(_Registration.connectionString))
                {
                    using (SqlCommand sqlCommand = new SqlCommand("SELECT * FROM airbnb_RentHistory WHERE rent_OwnerID = '" + OwnerID + "' ",sqlConnection))
                    {
                        sqlConnection.Open();
                        SqlDataReader sql = sqlCommand.ExecuteReader();
                        data.Load(sql);
                    }
                    sqlConnection.Close();
                }
            }
            catch (Exception l)
            {
                MessageBox.Show(l.Message);
            }
            return data;
        }
    }
}
