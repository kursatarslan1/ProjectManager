using ProjectManager.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ProjectManager.Class;

namespace ProjectManager.CustomCard
{
    public partial class btnTask : UserControl
    {
        Tasks task = new Tasks();
        SqlHelper sqlHelper = new SqlHelper();

        public string ItemId { get; set; }
        public string TaskProject
        {
            get { return lblTaskProject.Text; }
            set { lblTaskProject.Text = value; }
        }
        public string TaskContent
        {
            get { return lblTaskContent.Text; }
            set { lblTaskContent.Text = value; }
        }
        public string TaskPriority
        {
            get { return lblTaskPriority.Text; }
            set { lblTaskPriority.Text = value; }
        }
        public string TaskAuthor
        {
            get { return lblTaskAuthor.Text; }
            set { lblTaskAuthor.Text = value; }
        }
        public string TaskStatus
        {
            get { return lblTaskStatus.Text; }
            set { lblTaskStatus.Text = value; }
        }
        public string TaskDueDate
        {
            get { return lblTaskDueDate.Text; }
            set { lblTaskDueDate.Text = value; }
        }
        public btnTask()
        {
            InitializeComponent();
            
        }
        private void lblTaskContent_Click(object sender, EventArgs e)
        {
            task = sqlHelper.GetTaskDetail(TaskContent);
            FormTaskDetail form = new FormTaskDetail(task);
            form.Show();
        }
    }
}
