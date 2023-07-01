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
    public partial class FormCreateTask : Form
    {
        public FormCreateTask(string username)
        {
            InitializeComponent();
            Author = username;
        }
        public string Author { get; set; }

        private void FormCreateTask_Load(object sender, EventArgs e)
        {
            this.createTask1.Author = Author;
        }
    }
}
