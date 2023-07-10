using Guna.UI2.WinForms;
using ProjectManager.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectManager.Forms
{
    public partial class FormSettings : Form
    {
        string filepath = "";
        SqlHelper sqlHelper = new SqlHelper();
        public FormSettings(User user)
        {
            InitializeComponent();
            userInfo = user;
        }
        public User userInfo { get; set; }

        private void btnAccountSetting_Click(object sender, EventArgs e)
        {
            btnAccountSetting.Checked = true;
            btnAddCollabrator.Checked = false;
            FillTextBoxes();
        }
        private void btnAddCollabrator_Click(object sender, EventArgs e)
        {
            btnAccountSetting.Checked = false;
            btnAddCollabrator.Checked = true;
            ClearTextBoxes();
        }

        private void ClearTextBoxes()
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is Guna2TextBox)
                        (control as Guna2TextBox).Clear();
                    else
                        func(control.Controls);
            };

            func(Controls);
            pbPhoto.Image = null;
            btnSave.Text = "Add Collabrator";
            btnDelete.Enabled = false;
        }

        private void FillTextBoxes()
        {
            txtName.Text = userInfo.Name;
            txtSurname.Text = userInfo.LastName;
            txtRole.Text = userInfo.Role;
            txtUsername.Text = userInfo.Username;
            txtExplaination.Text = userInfo.Explaination;
            dtpBirthday.Value = userInfo.Birthday;
            txtPhoneNumber.Text = userInfo.PhoneNumber;
            txtPassword.Text = userInfo.Password;
            pbPhoto.Image = byteArrayToImage(userInfo.Photo);
            btnSave.Text = "Save";
            btnDelete.Enabled = true;
        }

        private void FormSettings_Load(object sender, EventArgs e)
        {
            FillTextBoxes();
        }

        public Image byteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
            if (pbPhoto.Image != null)
            {
                userInfo.Photo = ConvertImageToBytes(pbPhoto.Image);
            }

            if (string.IsNullOrEmpty(txtUsername.Text) || string.IsNullOrEmpty(txtPhoneNumber.Text) || string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Fields cannot be empty.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
            }
            else
            {
                userInfo.Name = txtName.Text;
                userInfo.LastName = txtSurname.Text;
                userInfo.Role = txtRole.Text;
                userInfo.Username = txtUsername.Text;
                userInfo.Explaination = txtExplaination.Text;
                userInfo.Birthday = dtpBirthday.Value;
                userInfo.PhoneNumber = txtPhoneNumber.Text;
                userInfo.Password = txtPassword.Text;
                if (btnSave.Text == "Save")
                {
                    sqlHelper.UpdateEmployee(userInfo);
                }
                else
                {
                    sqlHelper.Create(userInfo);
                }
            }
        }

        private void pbPhoto_Click(object sender, EventArgs e)
        {
            this.openFileDialog1.Filter = "Images (*.BMP;*.JPG;*.GIF,*.PNG,*.TIFF)|*.BMP;*.JPG;*.GIF;*.PNG;*.TIFF|" + "All files (*.*)|*.*";
            this.openFileDialog1.Title = "Select Photo";
            DialogResult dr = this.openFileDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                foreach (String file in openFileDialog1.FileNames)
                {
                    try
                    {
                        filepath = file;

                        Image.GetThumbnailImageAbort myCallback = new Image.GetThumbnailImageAbort(ThumbnailCallback);
                        Bitmap myBitmap = new Bitmap(file);
                        Image myThumbnail = myBitmap.GetThumbnailImage(300, 300, myCallback, IntPtr.Zero);
                        pbPhoto.Image = myThumbnail;

                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show("Error : " + ex.Message);
                    }
                }
            }
        }

        byte[] ConvertImageToBytes(Image img)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                return ms.ToArray();
            }
        }

        private bool ThumbnailCallback()
        {
            return false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            sqlHelper.DeleteEmployee(userInfo);
        }
    }
}
