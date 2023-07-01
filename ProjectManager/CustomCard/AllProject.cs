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
    public partial class AllProject : UserControl
    {
        public AllProject()
        {
            InitializeComponent();
        }

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
    }
}
