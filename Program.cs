using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

static class GlobalValv     //Global variables
{
    public static string user_ = ""; // Name of the user (to store)
    public static string pass_ = "prg455"; // The password of the test (to compare)
    public static string id = ""; // ID of the user (to store)
    public static double mark = 0.00; // User's mark in percentage (to calculate and store)

    public static RichTextBox rchTxt_result; // A richtextbox to store the wrong questions with their correct answers and the user's final mark (in the result form)
}

namespace Lab4
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
            Application.Run(new Form_inst());
        }
    }
}
