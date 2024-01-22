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

namespace AirBNB.View
{
    public partial class Form_Registration : Form
    {
        Class_Registration _Registration = new Class_Registration();
        Form_roomRegistration _RoomRegistration = new Form_roomRegistration();
        public bool check = false;
        //public string conString = "Data Source=DESKTOP-M73T79O\\SQLEXPRESS;Initial Catalog=AirBNB;Integrated Security=True";

        public Form_Registration()
        {
            InitializeComponent();
        }

        private void button_RegistrationClose_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void button_RegistrationClose_MouseHover(object sender, EventArgs e)
        {
            button_RegistrationClose.BackColor = Color.Red;
        }

        private void button_RegistrationClose_MouseLeave(object sender, EventArgs e)
        {
            button_RegistrationClose.BackColor = Color.Transparent;
        }

        private void panel_RegistrationBorder_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }
        Point lastPoint;

        private void panel_RegistrationBorder_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void button_Reg_Submit_Click(object sender, EventArgs e)
        {
            Check();
            if (check == true)
            {
                MessageBox.Show("Fill Up Requirements");
                check = false;
            }
            else
            {
                if (textBox_Reg_Password.Text.ToString() == textBox_Reg_ConPassword.Text.ToString())
                {
                    if (textBox_Reg_Password.Text.Length < 7 && textBox_Reg_ConPassword.Text.Length < 7)
                    {
                        MessageBox.Show("Password's length must be 8");
                        textBox_Reg_Password.Clear();
                        textBox_Reg_ConPassword.Clear();
                    }
                    else
                    {
                        if (comboBox_Reg_Purpose.SelectedItem.ToString() == "Owner")
                        {
                            //MessageBox.Show("Owner");
                            //MessageBox.Show(textBox_Reg_ConPassword.Text);
                            _RoomRegistration.tempID = textBox_Reg_ID.Text;
                            Save_Owner();
                            this.Hide();
                            _RoomRegistration.Show();
                        }
                        else
                        {
                            Save_Customer();
                        }
                    }      
                }
                else if (textBox_Reg_Password.Text.Length < 7 && textBox_Reg_ConPassword.Text.Length < 7)
                {
                    MessageBox.Show("Password's length must be 8");
                    textBox_Reg_Password.Clear();
                    textBox_Reg_ConPassword.Clear();
                }
                else
                {
                    MessageBox.Show("Passwords do not match!");
                    textBox_Reg_Password.Clear();
                    textBox_Reg_ConPassword.Clear();
                }
            }
        }

        private void comboBox_Reg_Purpose_SelectedValueChanged(object sender, EventArgs e)
        {
            if (comboBox_Reg_Purpose.SelectedItem.ToString() == "Owner")
            {
                textBox_Reg_ID.Text = Convert.ToString(_Registration.code.Next(100000, 999999));
            }
            else
            {
                textBox_Reg_ID.Text = Convert.ToString(_Registration.code.Next(10000000, 99999999));
            }
        }

        private void button_Reg_Cancel_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Close();
            form1.Show();
        }

        private void comboBox_Reg_Year_SelectedValueChanged(object sender, EventArgs e)
        {
            DateTime current = DateTime.Now;
            //MessageBox.Show(comboBox_Reg_Month.SelectedIndex.ToString());
            //MessageBox.Show(comboBox_Reg_Month.SelectedItem.ToString());
            //MessageBox.Show(comboBox_Reg_Month.Text.ToString());

            if (Convert.ToInt32(comboBox_Reg_Year.Text) >= current.Year)
            {
                MessageBox.Show("Error Birthdate");
            }
            else
            {
                int age = Convert.ToInt32(comboBox_Reg_Year.SelectedItem);
                if (current.Year - age <= 5)
                {
                    MessageBox.Show("Error Birthdate");
                }
                else
                {
                    textBox_Reg_Age.Text = Convert.ToString(current.Year - age);
                }
            }
        }

        public void Check()
        {
            foreach (Control control in this.Controls)
            {
                if (this.Controls.OfType<TextBox>().Any(t => string.IsNullOrEmpty(t.Text)))
                {
                    check = true;
                    break;
                }
            }
        }

        public void Save_Owner()
        {
            //SqlConnection con = new SqlConnection(conSting);
            //con.Open();
            Form1 form1 = new Form1();
            string Query = "insert into airbnb_Customers (id_Customer, purpose_Customer, fName_Customer, lName_Customer, address_Customer, bMonth_Customer, bDate_Customer, bYear_Customer, age_Customer, conNumber_Customer, email_Customer, password_Customer) values ('" + this.textBox_Reg_ID.Text + "','" + this.comboBox_Reg_Purpose.SelectedItem.ToString() + "','" + this.textBox_Reg_FirstName.Text + "','" + this.textBox_Reg_LastName.Text + "','" + this.textBox_Reg_Address.Text + "','" + this.comboBox_Reg_Month.SelectedItem.ToString() + "','" + this.comboBox_Reg_Date.SelectedItem.ToString() + "','" + this.comboBox_Reg_Year.SelectedItem.ToString() + "','" + this.textBox_Reg_Age.Text + "','" + this.textBox_Reg_ContactNo.Text + "','" + this.textBox_Reg_Enail.Text + "','" + this.textBox_Reg_ConPassword.Text + "')";
            SqlConnection connection = new SqlConnection(_Registration.connectionString);
            SqlCommand sqlCommand = new SqlCommand(Query, connection);
            SqlDataReader sqlDataReader;
            try
            {
                connection.Open();
                sqlDataReader = sqlCommand.ExecuteReader();
                MessageBox.Show("Registration Complete");
                connection.Close();
                this.Close();
                form1.Show();
                //while(sqlDataReader.Read())
                //{

                //}
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public void Save_Customer()
        {
            Form1 form1 = new Form1();
            string Query = "insert into airbnb_Customers (id_Customer, purpose_Customer, fName_Customer, lName_Customer, address_Customer, bMonth_Customer, bDate_Customer, bYear_Customer, age_Customer, conNumber_Customer, email_Customer, password_Customer) values ('" + this.textBox_Reg_ID.Text + "','" + this.comboBox_Reg_Purpose.SelectedItem.ToString() + "','" + this.textBox_Reg_FirstName.Text + "','"+this.textBox_Reg_LastName.Text + "','"+this.textBox_Reg_Address.Text + "','"+this.comboBox_Reg_Month.SelectedItem.ToString()+"','"+this.comboBox_Reg_Date.SelectedItem.ToString()+"','"+this.comboBox_Reg_Year.SelectedItem.ToString()+"','"+this.textBox_Reg_Age.Text + "','"+this.textBox_Reg_ContactNo.Text + "','"+this.textBox_Reg_Enail.Text + "','"+this.textBox_Reg_ConPassword.Text+"')";
            SqlConnection connection = new SqlConnection(_Registration.connectionString);
            SqlCommand sqlCommand = new SqlCommand(Query, connection);
            SqlDataReader sqlDataReader;
            try
            {
                connection.Open();
                sqlDataReader = sqlCommand.ExecuteReader();
                MessageBox.Show("Registration Complete");
                connection.Close();
                this.Close();
                form1.Show();
                //while(sqlDataReader.Read())
                //{

                //}
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
    }
}