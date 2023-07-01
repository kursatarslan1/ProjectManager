using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectManager.CustomCard
{
    public partial class UserDashboard : UserControl
    {
        SqlHelper sqlHelper = new SqlHelper();
        public UserDashboard()
        {
            InitializeComponent();
        }
        public string SelectDate
        {
            get { return ComboDate.Text; }
            set { ComboDate.Text = value; }
        }

        public int ProjectCount { get; set; }
        public string SelectProjectType
        {
            get { return ComboProjectType.Text; }
            set { ComboProjectType.Text = value; }
        }

        public string TitleTask
        {
            get { return lblTitle.Text; }
            set { lblTitle.Text = value; }
        }
        public string CompletedTaskNumber
        {
            get { return lblCompletedTask.Text; }
            set { lblCompletedTask.Text = value; }
        }

        private void ComboProjectType_SelectedIndexChanged(object sender, EventArgs e)
        {
            ProjectCount = sqlHelper.GetDoneTasks(ComboProjectType.Text);
            if(ComboProjectType.Text == "Not Started")
            {
                lblTitle.Text = "Not Started Tasks Count";
            }
            else if (ComboProjectType.Text == "In Progress")
            {
                lblTitle.Text = "In Progress Tasks Count";
            }
            else if (ComboProjectType.Text == "Waiting")
            {
                lblTitle.Text = "Waiting Tasks Count";
            }
            else if (ComboProjectType.Text == "Done")
            {
                lblTitle.Text = "Done Tasks Count";
            }
            else
            {
                lblTitle.Text = "All Tasks Count";
            }
            lblCompletedTask.Text = Convert.ToString(ProjectCount);
        }

        private void UserDashboard_Load(object sender, EventArgs e)
        {
            ProjectCount = sqlHelper.GetDoneTasks("All");
            lblCompletedTask.Text = Convert.ToString(ProjectCount);
        }
    }
}
