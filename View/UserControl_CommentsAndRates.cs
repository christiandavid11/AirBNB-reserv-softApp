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
    public partial class UserControl_CommentsAndRates : UserControl
    {
        Class_Registration _Registration = new Class_Registration();

        public UserControl_CommentsAndRates()
        {
            InitializeComponent();
        }

        public void load(string Score, string Comment, string Name)
        {
            richTextBox_Comments.Text = Comment;
            label_Score.Text = "Rating: " + Score + " / 5";
            label_FullName.Text = "Rentee: " + Name;
        }
    }
}
