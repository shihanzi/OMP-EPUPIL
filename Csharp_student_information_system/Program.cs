using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Csharp_student_information_system
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
             

             Login_From fLogin = new Login_From();
             
            
            if (fLogin.ShowDialog() == DialogResult.OK)
             {
                 Application.Run(new MainForm());
             }
             else
             {
                 Application.Exit();
             }
        }
    }
}
