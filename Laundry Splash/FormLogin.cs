﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Luthor.lib;
using MySql.Data.MySqlClient;


namespace Laundry_Splash
{
    public partial class FormLogin : Form
    {
        
        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            lableWelcome.Parent = pictureBox1;
            lableWelcome.BackColor = Color.Transparent;

            lableDeskripsi.Parent = pictureBox1;
            lableDeskripsi.BackColor = Color.Transparent;

            pictureBox2.Parent = pictureBox1;
            pictureBox2.BackColor = Color.Transparent;

        }

        // Membuat Form Login bisa Berpindah pindah
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void password_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
       
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text.Length > 0 && txtPassword.Text.Length > 0)
            {
                if (Auth.Login(txtUsername.Text, txtPassword.Text, "tb_user"))
                {
                    Form Dashboard = new FormMainMenu();
                    MessageBox.Show("Login Berhasil");
                    this.Hide();
                    Dashboard.Show();
                }
                else
                {
                    MessageBox.Show("Username atau Password salah!");
                    
                }
            }
        }

        // Membuat Form Login bisa Berpindah pindah
        private void FormLogin_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
