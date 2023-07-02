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

namespace ProjectManager.Forms
{
    public partial class FormTaskDetail : Form
    {
        Tasks tasks = new Tasks();
        SqlHelper sqlHelper = new SqlHelper();
        public FormTaskDetail(Tasks task)
        {
            InitializeComponent();
            tasker = task;
        }
        public Tasks tasker { get; set; }
        private void FormTaskDetail_Load(object sender, EventArgs e)
        {
            List<User> users = new List<User>();
            users = sqlHelper.GetUsers();
            foreach(var item in users)
            {
                cbAuthor.Items.Add(item.Username);
                cbOwner.Items.Add(item.Username);
            }
            tasks = tasker;
            cbPriority.Text = tasks.TaskPriority;
            dtpCreateDate.Value = tasks.TaskCreateDate;
            cbStatus.Text = tasks.TaskStatus;
            dtpDueDate.Value = tasks.TaskDueDate;
            cbAuthor.Text = tasks.TaskAuthor;
            cbOwner.Text = tasks.TaskOwner;
            lblProjectName.Text = tasks.TaskProject;
            txtContent.Text = tasks.TaskName;

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            tasks.TaskPriority = cbPriority.Text;
            tasks.TaskCreateDate = dtpCreateDate.Value;
            tasks.TaskStatus = cbStatus.Text;
            tasks.TaskDueDate = dtpDueDate.Value;
            tasks.TaskAuthor = cbAuthor.Text;
            tasks.TaskOwner = cbOwner.Text;
            tasks.TaskProject = lblProjectName.Text;
            tasks.TaskName = txtContent.Text;
            sqlHelper.UpdateTask(tasks);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            sqlHelper.DeleteTask(tasks);
            
        }

    }
}
