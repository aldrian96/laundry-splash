using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Laundry_Splash.FormCRUD;
using Luthor.lib;


namespace Laundry_Splash
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Connection.setConnection("localhost", "db_laundry", "root", "");

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            Application.Run(new FormLogin());    

            // tes koneksi terhubung atau tidak
            //if (Connection.Ping()) Application.Run(new FormLogin());
            //else MessageBox.Show("Tidak dapat terhubung ke database. silahkan hubungi tim pengembang.", "DATABASE CONNECTION ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
        public static Image LoadImage(string base64)
        {
            if (base64 != null)
            {
                byte[] bytes = Convert.FromBase64String(base64);

                Image image;
                using (MemoryStream ms = new MemoryStream(bytes))
                {
                    image = Image.FromStream(ms);
                }

                return image;
            }
            else
            {
                return null;
            }
        }
    }
}
