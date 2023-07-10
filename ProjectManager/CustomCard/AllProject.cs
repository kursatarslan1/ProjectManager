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
    public delegate void MyProjectEventHandler(object source, Tasks t);
    public partial class AllProject : UserControl
    {
        Tasks task = new Tasks();
        SqlHelper sqlHelper = new SqlHelper();
        public AllProject()
        {
            InitializeComponent();
        }
        public event MyProjectEventHandler OnShowProject;
        public string ProjectTitle
        {
            get { return lblTitle.Text; }
            set { lblTitle.Text = value; }
        }
        public string ProjectContent
        {
            get { return lblContent.Text; }
            set { lblContent.Text = value; }
        }
        public string ProjectTaskCount
        {
            get { return lblCount.Text; }
            set { lblCount.Text = value; }
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {
            string OperationType = "406";
            task = sqlHelper.GetTaskDetail(ProjectTitle, OperationType);
            OnShowProject?.Invoke(this, this.task);
        }
    }
}
