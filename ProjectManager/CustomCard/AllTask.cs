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
    public partial class AllTask : UserControl
    {
        SqlHelper sqlHelper = new SqlHelper();
        public AllTask()
        {
            InitializeComponent();
        }

        private void AllTask_Load(object sender, EventArgs e)
        {
            guna2DataGridView1.DataSource = sqlHelper.LoadData();
        }
    }
}
