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
    public partial class CreateProject : UserControl
    {
        SqlHelper sqlHelper = new SqlHelper();
        Projects project = new Projects();
        public CreateProject()
        {
            InitializeComponent();
        }

        public string ProjectName
        {
            get { return txtProjectName.Text; }
            set { txtProjectName.Text = value; }
        }
        public string ProjectContent
        {
            get { return txtProjectContent.Text; }
            set { txtProjectContent.Text = value; }
        }

        private void btnCreateProject_Click(object sender, EventArgs e)
        {
            project.ProjectName = txtProjectName.Text;
            project.ProjectContent = txtProjectContent.Text;
            if (string.IsNullOrEmpty(project.ProjectName) || string.IsNullOrEmpty(project.ProjectContent))
            {
                MessageBox.Show("Fields cannot be empty.","Warning",MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                project.TaskCount = 0;
                try
                {
                    sqlHelper.CreateProject(project);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
