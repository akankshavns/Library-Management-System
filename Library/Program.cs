using System;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            CreateDatabase();

            Application.Run(new Welcome());
        }

        private static void CreateDatabase()
        {
            string filePath = "C:\\Users\\HP\\Desktop\\LibraryDB.sql";
            File.Create(filePath);
        }
    }
    
}
