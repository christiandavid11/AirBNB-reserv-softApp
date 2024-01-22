using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using AirBNB.View;
using AirBNB.Model;

namespace AirBNB
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            //Application.Run(new Form_roomRegistration());
            //Application.Run(new Form_Registration());
            //Application.Run(new Form_ownerMenu());
        }
    }
}
