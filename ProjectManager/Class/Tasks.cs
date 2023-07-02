using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManager.Class
{
    public class Tasks
    {
        public int TaskId { get; set; }
        public string TaskName { get; set; }
        public DateTime TaskCreateDate { get; set; }
        public string TaskAuthor { get; set; }
        public string TaskStatus { get; set; }
        public DateTime TaskDueDate { get; set; }
        public string TaskPriority { get; set; }
        public string TaskOwner { get; set; }
        public string TaskProject { get; set; }
        public string TaskComment { get; set; }
    }
}
