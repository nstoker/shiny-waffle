using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace shiney_waffle
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

            foreach(string resourceName in System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceNames())
            {
                Console.WriteLine($"Resource: {resourceName}");
            }
            try
            {
                Application.Run(new Form1());
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception {ex}");
                throw;
            }
            
        }
    }
}
