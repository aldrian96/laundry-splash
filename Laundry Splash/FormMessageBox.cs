using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laundry_Splash
{

    public partial class FormMessageBox : Form
    {

        public FormMessageBox(string Message)
        {
            InitializeComponent();
            label1.Text = Message;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
