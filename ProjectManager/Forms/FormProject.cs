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
        SqlHelper sqlHelper = new SqlHelper();
        public FormProject()
        {
            InitializeComponent();
            flowLayoutPanel1.AutoScroll = true;
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
                projectCard.ProjectTaskCount = Convert.ToString(item.TaskCount)+" Tasks";
                flowLayoutPanel1.Controls.Add(projectCard);
            }
        }
    }
}
