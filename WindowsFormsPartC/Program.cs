using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsPartC.Unit5;
using WindowsFormsPartC.Unit7;

namespace WindowsFormsPartC
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

          //  Application.Run(new MenuForm());
            Application.Run(new SketchForm());
        }
    }
}
