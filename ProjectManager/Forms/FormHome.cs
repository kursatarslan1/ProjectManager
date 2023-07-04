using Guna.UI2.WinForms;
using ProjectManager.Class;
using ProjectManager.CustomCard;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectManager.Forms
{
    
    public partial class FormHome : Form
    {
        private Guna2Button currentButton;
        private Form activeForm;
        readonly string Username, Password;
        SqlHelper sqlHelper = new SqlHelper();
        User user = new User();
        
        public Tasks task { get; set; }
        public FormHome(string username, string password)
        {
            Username = username;
            Password = password;
            InitializeComponent();
            btnCloseChildForm.Visible = false;
        }



        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int IParam);

        private void FormHome_Load(object sender, EventArgs e)
        {
            user.Username = Username;
            user = sqlHelper.GetData(user);
            btnExit.Text = user.Name + " " + user.LastName;
            if (user.Name.Contains(" "))
            {
                char temp = user.Name[(user.Name.IndexOf(" ") + 1)];
                btnExit.Text = user.Name.Substring(0, user.Name.IndexOf(" ")) + " " + temp + ". " + user.LastName;
            }
            button2.Text = user.Role;
            pbUserImage.Image = byteArrayToImage(user.Photo);

            this.WindowState = FormWindowState.Maximized;
        }


        private void pnlTopSide_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMyTasks_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormMyTask(user.Username, user.Password), sender);
        }
        private void btnCreateTask_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormCreateTask(user.Username), sender);
        }
        private void btnAllTasks_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormAllTask(), sender);
        }
        private void btnProject_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormProject(), sender);
        }
        private void btnCreateProject_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormCreateProject(), sender);
        }

        public Image byteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }

        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Guna2Button)btnSender)
                {
                    currentButton = (Guna2Button)btnSender;
                    btnCloseChildForm.Visible = true;
                }
            }
        }

        private void btnCloseChildForm_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
            Reset();
        }

        private void Reset()
        {
            lblTitle.Text = "T. Project Manager";
            currentButton = null;
            btnCloseChildForm.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(this.WindowState == FormWindowState.Normal) {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.pnlMiddle.Controls.Add(childForm);
            this.pnlMiddle.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitle.Text = childForm.Text;
        }
    }
}
