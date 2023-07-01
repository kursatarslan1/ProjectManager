
namespace ProjectManager.Forms
{
    partial class FormHome
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pnlTopSide = new Guna.UI2.WinForms.Guna2Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnCloseChildForm = new Guna.UI2.WinForms.Guna2CircleButton();
            this.button2 = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pbUserImage = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnProject = new Guna.UI2.WinForms.Guna2Button();
            this.btnCreateProject = new Guna.UI2.WinForms.Guna2Button();
            this.btnCreateTask = new Guna.UI2.WinForms.Guna2Button();
            this.btnMyTasks = new Guna.UI2.WinForms.Guna2Button();
            this.btnAllTasks = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.pnlMiddle = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.userDashboard1 = new ProjectManager.CustomCard.UserDashboard();
            this.pnlTopSide.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUserImage)).BeginInit();
            this.guna2Panel2.SuspendLayout();
            this.pnlMiddle.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTopSide
            // 
            this.pnlTopSide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(72)))), ((int)(((byte)(103)))));
            this.pnlTopSide.Controls.Add(this.lblTitle);
            this.pnlTopSide.Controls.Add(this.btnCloseChildForm);
            this.pnlTopSide.Controls.Add(this.button2);
            this.pnlTopSide.Controls.Add(this.btnExit);
            this.pnlTopSide.Controls.Add(this.guna2PictureBox1);
            this.pnlTopSide.Controls.Add(this.pbUserImage);
            this.pnlTopSide.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopSide.Location = new System.Drawing.Point(0, 0);
            this.pnlTopSide.Name = "pnlTopSide";
            this.pnlTopSide.Size = new System.Drawing.Size(1041, 136);
            this.pnlTopSide.TabIndex = 0;
            this.pnlTopSide.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTopSide_MouseDown);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTitle.Location = new System.Drawing.Point(510, 61);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(195, 25);
            this.lblTitle.TabIndex = 7;
            this.lblTitle.Text = "T. Project Manager";
            // 
            // btnCloseChildForm
            // 
            this.btnCloseChildForm.BackColor = System.Drawing.Color.Transparent;
            this.btnCloseChildForm.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCloseChildForm.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCloseChildForm.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCloseChildForm.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCloseChildForm.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(164)))), ((int)(((byte)(181)))));
            this.btnCloseChildForm.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.btnCloseChildForm.ForeColor = System.Drawing.Color.White;
            this.btnCloseChildForm.Location = new System.Drawing.Point(220, 41);
            this.btnCloseChildForm.Name = "btnCloseChildForm";
            this.btnCloseChildForm.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnCloseChildForm.Size = new System.Drawing.Size(45, 45);
            this.btnCloseChildForm.TabIndex = 6;
            this.btnCloseChildForm.Text = "X";
            this.btnCloseChildForm.UseTransparentBackground = true;
            this.btnCloseChildForm.Click += new System.EventHandler(this.btnCloseChildForm_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(859, 106);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(171, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "button1";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExit.Location = new System.Drawing.Point(859, 82);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(171, 23);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "button1";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(18)))), ((int)(((byte)(43)))));
            this.guna2PictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2PictureBox1.Image = global::ProjectManager.Properties.Resources.Adsız;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(0, 0);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(200, 136);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 3;
            this.guna2PictureBox1.TabStop = false;
            // 
            // pbUserImage
            // 
            this.pbUserImage.ImageRotate = 0F;
            this.pbUserImage.Location = new System.Drawing.Point(911, 12);
            this.pbUserImage.Name = "pbUserImage";
            this.pbUserImage.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pbUserImage.Size = new System.Drawing.Size(64, 64);
            this.pbUserImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbUserImage.TabIndex = 2;
            this.pbUserImage.TabStop = false;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(72)))), ((int)(((byte)(103)))));
            this.guna2Panel2.Controls.Add(this.btnProject);
            this.guna2Panel2.Controls.Add(this.btnCreateProject);
            this.guna2Panel2.Controls.Add(this.btnCreateTask);
            this.guna2Panel2.Controls.Add(this.btnMyTasks);
            this.guna2Panel2.Controls.Add(this.btnAllTasks);
            this.guna2Panel2.Controls.Add(this.guna2Button3);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2Panel2.Location = new System.Drawing.Point(0, 136);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(200, 492);
            this.guna2Panel2.TabIndex = 1;
            // 
            // btnProject
            // 
            this.btnProject.Animated = true;
            this.btnProject.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.btnProject.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnProject.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnProject.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnProject.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnProject.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProject.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(62)))));
            this.btnProject.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnProject.ForeColor = System.Drawing.Color.White;
            this.btnProject.Location = new System.Drawing.Point(0, 224);
            this.btnProject.Name = "btnProject";
            this.btnProject.Size = new System.Drawing.Size(200, 56);
            this.btnProject.TabIndex = 10;
            this.btnProject.Text = "All Project";
            this.btnProject.Click += new System.EventHandler(this.btnProject_Click);
            // 
            // btnCreateProject
            // 
            this.btnCreateProject.Animated = true;
            this.btnCreateProject.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.btnCreateProject.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCreateProject.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCreateProject.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCreateProject.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCreateProject.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCreateProject.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(62)))));
            this.btnCreateProject.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCreateProject.ForeColor = System.Drawing.Color.White;
            this.btnCreateProject.Location = new System.Drawing.Point(0, 168);
            this.btnCreateProject.Name = "btnCreateProject";
            this.btnCreateProject.Size = new System.Drawing.Size(200, 56);
            this.btnCreateProject.TabIndex = 9;
            this.btnCreateProject.Text = "Create Project";
            this.btnCreateProject.Click += new System.EventHandler(this.btnCreateProject_Click);
            // 
            // btnCreateTask
            // 
            this.btnCreateTask.Animated = true;
            this.btnCreateTask.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.btnCreateTask.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCreateTask.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCreateTask.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCreateTask.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCreateTask.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCreateTask.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(62)))));
            this.btnCreateTask.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCreateTask.ForeColor = System.Drawing.Color.White;
            this.btnCreateTask.Location = new System.Drawing.Point(0, 112);
            this.btnCreateTask.Name = "btnCreateTask";
            this.btnCreateTask.Size = new System.Drawing.Size(200, 56);
            this.btnCreateTask.TabIndex = 7;
            this.btnCreateTask.Text = "Create Task";
            this.btnCreateTask.Click += new System.EventHandler(this.btnCreateTask_Click);
            // 
            // btnMyTasks
            // 
            this.btnMyTasks.Animated = true;
            this.btnMyTasks.BackColor = System.Drawing.Color.Transparent;
            this.btnMyTasks.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnMyTasks.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnMyTasks.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnMyTasks.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnMyTasks.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMyTasks.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(62)))));
            this.btnMyTasks.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnMyTasks.ForeColor = System.Drawing.Color.White;
            this.btnMyTasks.Location = new System.Drawing.Point(0, 56);
            this.btnMyTasks.Name = "btnMyTasks";
            this.btnMyTasks.Size = new System.Drawing.Size(200, 56);
            this.btnMyTasks.TabIndex = 6;
            this.btnMyTasks.Text = "My Tasks";
            this.btnMyTasks.Click += new System.EventHandler(this.btnMyTasks_Click);
            // 
            // btnAllTasks
            // 
            this.btnAllTasks.Animated = true;
            this.btnAllTasks.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.btnAllTasks.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAllTasks.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAllTasks.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAllTasks.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAllTasks.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAllTasks.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(62)))));
            this.btnAllTasks.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAllTasks.ForeColor = System.Drawing.Color.White;
            this.btnAllTasks.Location = new System.Drawing.Point(0, 0);
            this.btnAllTasks.Name = "btnAllTasks";
            this.btnAllTasks.Size = new System.Drawing.Size(200, 56);
            this.btnAllTasks.TabIndex = 5;
            this.btnAllTasks.Text = "All Tasks";
            this.btnAllTasks.Click += new System.EventHandler(this.btnAllTasks_Click);
            // 
            // guna2Button3
            // 
            this.guna2Button3.Animated = true;
            this.guna2Button3.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.guna2Button3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.guna2Button3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(62)))));
            this.guna2Button3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button3.ForeColor = System.Drawing.Color.White;
            this.guna2Button3.Location = new System.Drawing.Point(0, 436);
            this.guna2Button3.Name = "guna2Button3";
            this.guna2Button3.Size = new System.Drawing.Size(200, 56);
            this.guna2Button3.TabIndex = 4;
            this.guna2Button3.Text = "Settings";
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 60;
            this.guna2Elipse1.TargetControl = this;
            // 
            // pnlMiddle
            // 
            this.pnlMiddle.Controls.Add(this.flowLayoutPanel1);
            this.pnlMiddle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMiddle.Location = new System.Drawing.Point(200, 136);
            this.pnlMiddle.Name = "pnlMiddle";
            this.pnlMiddle.Size = new System.Drawing.Size(841, 492);
            this.pnlMiddle.TabIndex = 2;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.flowLayoutPanel1.Controls.Add(this.userDashboard1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(841, 492);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // userDashboard1
            // 
            this.userDashboard1.CompletedTaskNumber = "31";
            this.userDashboard1.Location = new System.Drawing.Point(3, 3);
            this.userDashboard1.Name = "userDashboard1";
            this.userDashboard1.ProjectCount = 31;
            this.userDashboard1.SelectDate = "All";
            this.userDashboard1.SelectProjectType = "All";
            this.userDashboard1.Size = new System.Drawing.Size(827, 477);
            this.userDashboard1.TabIndex = 0;
            this.userDashboard1.TitleTask = "All Tasks Count";
            // 
            // FormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(67)))), ((int)(((byte)(86)))));
            this.ClientSize = new System.Drawing.Size(1041, 628);
            this.Controls.Add(this.pnlMiddle);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.pnlTopSide);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormHome";
            this.Text = "FormHome";
            this.Load += new System.EventHandler(this.FormHome_Load);
            this.pnlTopSide.ResumeLayout(false);
            this.pnlTopSide.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUserImage)).EndInit();
            this.guna2Panel2.ResumeLayout(false);
            this.pnlMiddle.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnlTopSide;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnExit;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox pbUserImage;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2CircleButton btnCloseChildForm;
        private System.Windows.Forms.Label lblTitle;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
        private System.Windows.Forms.Panel pnlMiddle;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private CustomCard.UserDashboard userDashboard1;
        private Guna.UI2.WinForms.Guna2Button btnAllTasks;
        private Guna.UI2.WinForms.Guna2Button btnCreateTask;
        private Guna.UI2.WinForms.Guna2Button btnMyTasks;
        private Guna.UI2.WinForms.Guna2Button btnProject;
        private Guna.UI2.WinForms.Guna2Button btnCreateProject;
    }
}