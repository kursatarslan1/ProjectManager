using ProjectManager.Class;
using ProjectManager.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectManager
{
    public partial class Form1 : Form
    {

        User user = new User();
        SqlHelper sqlHelper = new SqlHelper();
        bool checkUser = false;
        public Form1()
        {
            InitializeComponent();
            InitData();
        }

        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int IParam);

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void guna2Panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void InitData()
        {
            if (Properties.Settings.Default.Username != string.Empty)
            {
                if (Properties.Settings.Default.Remember == true)
                {
                    txtUsername.Text = Properties.Settings.Default.Username;
                    txtPassword.Text = Properties.Settings.Default.Password;
                    cbRemember.Checked = true;
                }
                else
                {
                    txtUsername.Text = Properties.Settings.Default.Username;
                }
            }
        }

        private void SaveData()
        {
            if (cbRemember.Checked)
            {
                Properties.Settings.Default.Username = txtUsername.Text;
                Properties.Settings.Default.Password = txtPassword.Text;
                Properties.Settings.Default.Remember = true;
                Properties.Settings.Default.Save();

            }
            else
            {
                Properties.Settings.Default.Username = "";
                Properties.Settings.Default.Password = "";
                Properties.Settings.Default.Remember = false;
                Properties.Settings.Default.Save();
            }
        }

        private void txtLogin_Click(object sender, EventArgs e)
        {
            user.Username = txtUsername.Text;
            user.Password = txtPassword.Text;
            checkUser = sqlHelper.Login(user);
            if (checkUser)
            {
                SaveData();
                FormHome formHome = new FormHome(user.Username, user.Password);
                formHome.Show();
                this.Hide();
                formHome.Closed += (s, args) => this.Close();
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimized_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
