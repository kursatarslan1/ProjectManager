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
    public partial class CommentCard : UserControl
    {
        public CommentCard()
        {
            InitializeComponent();
        }
        public string Comment
        {
            get { return txtComment.Text; }
            set { txtComment.Text = value; }
        }
        public string CommentOwner
        {
            get { return lblCommentOwner.Text; }
            set { lblCommentOwner.Text = value; }
        }
    }
}
