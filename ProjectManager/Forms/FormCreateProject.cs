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
    public partial class FormCreateProject : Form
    {
        SqlHelper sqlHelper = new SqlHelper();
        Projects project = new Projects();
        public FormCreateProject()
        {
            InitializeComponent();
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
                    MessageBox.Show("Successfully created.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
                       
        }
    }
}
