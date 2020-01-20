using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace ShredShop
{
    static class Program
    {
        static string connectionString = "Data Source = (LocalDB)\\MSSQLLocalDB;AttachDbFilename=K:\\ShredShop-20191216T193757Z-001\\ShredShop\\ShredShop\\Database1.mdf;Integrated Security = True";
        
        // THIS STATEMENT IS TO REGISTER A NEW USER!
        // INSERT INTO Users VALUES(24, N'John Doe', N'tester', N'john.doe@gmail.com')

        // THIS STATEMENT IS TO RETREIVE A VALID USER    
        // SELECT * FROM Users WHERE UserName = @username AND Password = @password;


        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Database database = new Database(connectionString);
            

            WindowsMediaPlayer player = new WindowsMediaPlayer();
            player.URL = "intro.mp3";

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ProductPg(database, player));
            
        }
    }
}
