using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laundry_Splash
{
    class msgBox
    {
        public static void Show(string msg)
        {
            Form msgbox = new FormMessageBox(msg);
            msgbox.Show();
        }
    }
}
