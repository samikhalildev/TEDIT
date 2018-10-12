using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TextEditor.Model;

namespace TextEditor
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            UserList user = new UserList();
            string x = "\r\nsami96,123,View,sami,khalil,30-5-1996";

            user.AddToFile(x);
            user.LoadUsers();
            //user.DisplayUsers();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
        }
    }
}
