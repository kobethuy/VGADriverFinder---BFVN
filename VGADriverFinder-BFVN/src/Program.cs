using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Auto_Find_Best_Driver_For_BF4___BFVN
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
        }
    }
}
