using ProjectManager.Class;
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
    public partial class CreateTask : UserControl
    {
        Tasks task = new Tasks();
        SqlHelper sqlHelper = new SqlHelper();
        bool checkCreate;
        public CreateTask()
        {
            InitializeComponent();
        }
        public int TaskId { get; set; }
        public string Author { get; set; }
        public string SelectProject
        {
            get { return cbProject.Text; }
            set { cbProject.Text = value; }
        }
        public string SelectTaskOwner
        {
            get { return cbTaskOwner.Text; }
            set { cbTaskOwner.Text = value; }
        }

        public string SelectTaskContent
        {
            get { return txtTaskContent.Text; }
            set { txtTaskContent.Text = value; }
        }
        public string SelectTaskPriority
        {
            get { return cbPriority.Text; }
            set { cbPriority.Text = value; }
        }

        public string SelectTaskDueDate
        {
            get { return dtpDueDate.Text; }
            set { dtpDueDate.Text = value; }
        }
        public string SelectTaskComment
        {
            get { return txtComment.Text; }
            set { txtComment.Text = value; }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(SelectTaskContent) || string.IsNullOrEmpty(SelectTaskOwner))
            {
                MessageBox.Show("Fields cannot be empty.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                task.TaskId = TaskId;
                task.TaskName = SelectTaskContent;
                task.TaskCreateDate = DateTime.Now;
                task.TaskAuthor = Author;
                task.TaskStatus = "Not Started";
                task.TaskDueDate = Convert.ToDateTime(SelectTaskDueDate);
                task.TaskPriority = SelectTaskPriority;
                task.TaskOwner = SelectTaskOwner;
                task.TaskProject = SelectProject;
                checkCreate = sqlHelper.CreateTask(task);
                if (checkCreate)
                    btnClear.PerformClick();
            }
            
        }

        private void CreateTask_Load(object sender, EventArgs e)
        {
            List<Projects> projects = sqlHelper.GetProjects();
            foreach (var item in projects)
            {
                cbProject.Items.Add(item.ProjectName);
            }

            List<User> users = sqlHelper.GetUsers();
            foreach (var item in users)
            {
                cbTaskOwner.Items.Add(item.Username);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            cbProject.Text = "";
            cbTaskOwner.Text = "";
            txtTaskContent.Text = "";
            cbPriority.Text = "";
            dtpDueDate.Text = Convert.ToString(DateTime.Now);
            txtComment.Text = "";
        }
    }
}
