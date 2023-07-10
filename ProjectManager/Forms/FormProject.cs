using ProjectManager.Class;
using ProjectManager.CustomCard;
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
    public partial class FormProject : Form
    {
        readonly string Username, Password;
        User user = new User();
        SqlHelper sqlHelper = new SqlHelper();
        Tasks task = new Tasks();
        Comment comment = new Comment();
        public FormProject(string username, string password)
        {
            InitializeComponent();
            flowLayoutPanel1.AutoScroll = true;
            Username = username;
            Password = password;
        }

        private void FormProject_Load(object sender, EventArgs e)
        {
            List<Projects> project = new List<Projects>();
            project = sqlHelper.GetProjects();

            foreach (var item in project)
            {
                AllProject projectCard = new AllProject();
                projectCard.ProjectTitle = item.ProjectName;
                projectCard.ProjectContent = item.ProjectContent;
                projectCard.ProjectTaskCount = Convert.ToString(item.TaskCount);
                projectCard.OnShowProject += ProjectCard_OnShowTasks;
                flowLayoutPanel1.Controls.Add(projectCard);
            }
        }

        private void OpenChildForm(Form childForm)
        {
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            this.flowLayoutPanel1.Controls.Clear();
            this.flowLayoutPanel1.Controls.Add(childForm);
            childForm.BringToFront();
            childForm.Show();
        }
        private void ProjectCard_OnShowTasks(object source, Tasks t)
        {
            task = t;

            LoadTasks();
            
        }
        public void LoadTasks()
        {
            flowLayoutPanel1.Controls.Clear();
            user.Username = Username;
            user = sqlHelper.GetData(user);

            List<Tasks> taskler = new List<Tasks>();
            taskler = sqlHelper.GetTasks(user.Username,"");

            foreach (var tasks in taskler)
            {
                btnTask btnTask = new btnTask(user);
                btnTask.OnShowTasks += ProjectCard_OnShowTasks;
                btnTask.OnShowTasks += btnTask_OnShowTasks;
                btnTask.TaskProject = tasks.TaskProject;
                btnTask.TaskContent = tasks.TaskName;
                btnTask.TaskAuthor = "Task Author: " + tasks.TaskAuthor;
                btnTask.TaskStatus = "Task Status: " + tasks.TaskStatus;
                btnTask.TaskDueDate = "Task Due Date: " + Convert.ToString(tasks.TaskDueDate);
                btnTask.TaskPriority = tasks.TaskPriority;
                flowLayoutPanel1.Controls.Add(btnTask);
            }
        }

        private void btnTask_OnShowTasks(object source, Tasks t)
        {
            task = t;
            OpenChildForm(new Forms.FormTaskDetail(t, user));

            List<Comment> comments = new List<Comment>();
            comments = sqlHelper.GetComment(task);

            foreach (var item in comments)
            {
                CommentCard commentCard = new CommentCard();
                comment.CommentContent = item.CommentContent;
                comment.CommentTask = item.CommentTask;
                comment.CommentOwner = item.CommentOwner;
                commentCard.CommentOwner = comment.CommentOwner;
                commentCard.Comment = comment.CommentContent;
                flowLayoutPanel1.Controls.Add(commentCard);
            }
            flowLayoutPanel1.Dock = DockStyle.Fill;
        }
    }
}
