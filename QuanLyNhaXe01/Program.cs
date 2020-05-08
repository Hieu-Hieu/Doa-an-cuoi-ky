using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhaXe01
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
            
            loginForm fLogin = new loginForm();

            if (fLogin.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new mainForm());
            }
            else
            {
                Application.Exit();
            }
        }
    }
}
