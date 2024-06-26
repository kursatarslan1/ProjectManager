﻿using ProjectManager.Class;
using System;
using System.Collections.Generic;
using ProjectManager.CustomCard;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectManager.Forms
{
    public partial class FormMyTask : Form
    {
        readonly string Username, Password;
        User user = new User();
        SqlHelper sqlHelper = new SqlHelper();
        Tasks task = new Tasks();
        btnTask btnTask;
        Comment comment = new Comment();
        public FormMyTask(string username, string password)
        {
            InitializeComponent();
            Username = username;
            Password = password;
            flowLayoutPanel1.AutoScroll = true;
            btnTask = new btnTask(user); 
        }
        private void FormMyTask_Load(object sender, EventArgs e)
        {
            LoadTasks();
        }

        private void BtnTask_OnShowTasks(object source, Tasks t)
        {
            task = t;
            OpenChildForm(new Forms.FormTaskDetail(t,user));

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

        private void OpenChildForm(Form childForm)
        {
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            this.flowLayoutPanel1.Controls.Clear();
            this.flowLayoutPanel1.Controls.Add(childForm);
            childForm.BringToFront();
            childForm.Show();
        }

        public void LoadTasks()
        {
            user.Username = Username;
            user = sqlHelper.GetData(user);

            List<Tasks> taskler = new List<Tasks>();
            taskler = sqlHelper.GetTasks(user.Username,"");

            foreach (var tasks in taskler)
            {
                btnTask btnTask = new btnTask(user);
                btnTask.OnShowTasks += BtnTask_OnShowTasks;
                btnTask.TaskProject = tasks.TaskProject;
                btnTask.TaskContent = tasks.TaskName;
                btnTask.TaskAuthor = "Task Author: " + tasks.TaskAuthor;
                btnTask.TaskStatus = "Task Status: " + tasks.TaskStatus;
                btnTask.TaskDueDate = "Task Due Date: " + Convert.ToString(tasks.TaskDueDate);
                btnTask.TaskPriority = tasks.TaskPriority;
                flowLayoutPanel1.Controls.Add(btnTask);
            }
        }

    }
}
