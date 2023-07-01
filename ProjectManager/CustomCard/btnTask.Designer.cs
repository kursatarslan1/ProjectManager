
namespace ProjectManager.CustomCard
{
    partial class btnTask
    {
        /// <summary> 
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(btnTask));
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.lblTaskDueDate = new System.Windows.Forms.Label();
            this.lblTaskStatus = new System.Windows.Forms.Label();
            this.lblTaskAuthor = new System.Windows.Forms.Label();
            this.lblTaskContent = new System.Windows.Forms.Label();
            this.lblTaskPriority = new System.Windows.Forms.Label();
            this.lblTaskProject = new System.Windows.Forms.Label();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2GradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.BackColor = System.Drawing.Color.White;
            this.guna2GradientPanel1.Controls.Add(this.lblTaskDueDate);
            this.guna2GradientPanel1.Controls.Add(this.lblTaskStatus);
            this.guna2GradientPanel1.Controls.Add(this.lblTaskAuthor);
            this.guna2GradientPanel1.Controls.Add(this.lblTaskContent);
            this.guna2GradientPanel1.Controls.Add(this.lblTaskPriority);
            this.guna2GradientPanel1.Controls.Add(this.lblTaskProject);
            this.guna2GradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2GradientPanel1.Location = new System.Drawing.Point(4, 4);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.Size = new System.Drawing.Size(377, 381);
            this.guna2GradientPanel1.TabIndex = 0;
            // 
            // lblTaskDueDate
            // 
            this.lblTaskDueDate.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTaskDueDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTaskDueDate.ForeColor = System.Drawing.Color.Red;
            this.lblTaskDueDate.Location = new System.Drawing.Point(0, 237);
            this.lblTaskDueDate.Name = "lblTaskDueDate";
            this.lblTaskDueDate.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.lblTaskDueDate.Size = new System.Drawing.Size(377, 57);
            this.lblTaskDueDate.TabIndex = 6;
            this.lblTaskDueDate.Text = "Task Due Date: 2023-06-10 16:58:08.473";
            this.lblTaskDueDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTaskStatus
            // 
            this.lblTaskStatus.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTaskStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTaskStatus.ForeColor = System.Drawing.Color.Red;
            this.lblTaskStatus.Location = new System.Drawing.Point(0, 180);
            this.lblTaskStatus.Name = "lblTaskStatus";
            this.lblTaskStatus.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.lblTaskStatus.Size = new System.Drawing.Size(377, 57);
            this.lblTaskStatus.TabIndex = 5;
            this.lblTaskStatus.Text = "Task Status: In Progress";
            this.lblTaskStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTaskAuthor
            // 
            this.lblTaskAuthor.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTaskAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTaskAuthor.ForeColor = System.Drawing.Color.Red;
            this.lblTaskAuthor.Location = new System.Drawing.Point(0, 123);
            this.lblTaskAuthor.Name = "lblTaskAuthor";
            this.lblTaskAuthor.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.lblTaskAuthor.Size = new System.Drawing.Size(377, 57);
            this.lblTaskAuthor.TabIndex = 3;
            this.lblTaskAuthor.Text = "Task Author: kursat.arslan@tringle.io";
            this.lblTaskAuthor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTaskContent
            // 
            this.lblTaskContent.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTaskContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTaskContent.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTaskContent.Location = new System.Drawing.Point(0, 41);
            this.lblTaskContent.Name = "lblTaskContent";
            this.lblTaskContent.Padding = new System.Windows.Forms.Padding(35, 20, 30, 20);
            this.lblTaskContent.Size = new System.Drawing.Size(377, 82);
            this.lblTaskContent.TabIndex = 2;
            this.lblTaskContent.Text = resources.GetString("lblTaskContent.Text");
            this.lblTaskContent.Click += new System.EventHandler(this.lblTaskContent_Click);
            // 
            // lblTaskPriority
            // 
            this.lblTaskPriority.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblTaskPriority.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTaskPriority.ForeColor = System.Drawing.Color.LightCoral;
            this.lblTaskPriority.Location = new System.Drawing.Point(0, 345);
            this.lblTaskPriority.Name = "lblTaskPriority";
            this.lblTaskPriority.Padding = new System.Windows.Forms.Padding(5);
            this.lblTaskPriority.Size = new System.Drawing.Size(377, 36);
            this.lblTaskPriority.TabIndex = 1;
            this.lblTaskPriority.Text = "High";
            this.lblTaskPriority.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTaskProject
            // 
            this.lblTaskProject.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTaskProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTaskProject.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTaskProject.Location = new System.Drawing.Point(0, 0);
            this.lblTaskProject.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblTaskProject.Name = "lblTaskProject";
            this.lblTaskProject.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.lblTaskProject.Size = new System.Drawing.Size(377, 41);
            this.lblTaskProject.TabIndex = 0;
            this.lblTaskProject.Text = "DenizBank AG- SMS Delivery";
            this.lblTaskProject.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            this.guna2Elipse1.TargetControl = this.guna2GradientPanel1;
            // 
            // btnTask
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.Controls.Add(this.guna2GradientPanel1);
            this.Name = "btnTask";
            this.Padding = new System.Windows.Forms.Padding(4);
            this.Size = new System.Drawing.Size(385, 389);
            this.guna2GradientPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Label lblTaskDueDate;
        private System.Windows.Forms.Label lblTaskStatus;
        private System.Windows.Forms.Label lblTaskAuthor;
        private System.Windows.Forms.Label lblTaskContent;
        private System.Windows.Forms.Label lblTaskPriority;
        private System.Windows.Forms.Label lblTaskProject;
    }
}
