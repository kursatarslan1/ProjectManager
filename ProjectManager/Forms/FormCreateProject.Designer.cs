
namespace ProjectManager.Forms
{
    partial class FormCreateProject
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtProjectName = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnCreateProject = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtProjectContent = new Guna.UI2.WinForms.Guna2TextBox();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.txtProjectName);
            this.flowLayoutPanel1.Controls.Add(this.label2);
            this.flowLayoutPanel1.Controls.Add(this.txtProjectContent);
            this.flowLayoutPanel1.Controls.Add(this.btnCreateProject);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Location = new System.Drawing.Point(30, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 36);
            this.label1.TabIndex = 2;
            this.label1.Text = "Project Name: ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtProjectName
            // 
            this.txtProjectName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtProjectName.DefaultText = "";
            this.txtProjectName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtProjectName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtProjectName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtProjectName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtProjectName.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtProjectName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtProjectName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtProjectName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtProjectName.Location = new System.Drawing.Point(137, 30);
            this.txtProjectName.Margin = new System.Windows.Forms.Padding(0, 30, 30, 30);
            this.txtProjectName.Name = "txtProjectName";
            this.txtProjectName.PasswordChar = '\0';
            this.txtProjectName.PlaceholderText = "Project Name";
            this.txtProjectName.SelectedText = "";
            this.txtProjectName.Size = new System.Drawing.Size(549, 36);
            this.txtProjectName.TabIndex = 6;
            // 
            // btnCreateProject
            // 
            this.btnCreateProject.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCreateProject.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCreateProject.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCreateProject.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCreateProject.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(164)))), ((int)(((byte)(181)))));
            this.btnCreateProject.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCreateProject.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCreateProject.Location = new System.Drawing.Point(30, 222);
            this.btnCreateProject.Margin = new System.Windows.Forms.Padding(30);
            this.btnCreateProject.Name = "btnCreateProject";
            this.btnCreateProject.Size = new System.Drawing.Size(180, 45);
            this.btnCreateProject.TabIndex = 7;
            this.btnCreateProject.Text = "Create Project";
            this.btnCreateProject.Click += new System.EventHandler(this.btnCreateProject_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Location = new System.Drawing.Point(30, 126);
            this.label2.Margin = new System.Windows.Forms.Padding(30, 30, 20, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 36);
            this.label2.TabIndex = 8;
            this.label2.Text = "Project Content: ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtProjectContent
            // 
            this.txtProjectContent.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtProjectContent.DefaultText = "";
            this.txtProjectContent.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtProjectContent.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtProjectContent.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtProjectContent.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtProjectContent.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtProjectContent.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtProjectContent.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtProjectContent.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtProjectContent.Location = new System.Drawing.Point(136, 126);
            this.txtProjectContent.Margin = new System.Windows.Forms.Padding(0, 30, 30, 30);
            this.txtProjectContent.Name = "txtProjectContent";
            this.txtProjectContent.PasswordChar = '\0';
            this.txtProjectContent.PlaceholderText = "Project Content";
            this.txtProjectContent.SelectedText = "";
            this.txtProjectContent.Size = new System.Drawing.Size(550, 36);
            this.txtProjectContent.TabIndex = 9;
            // 
            // FormCreateProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCreateProject";
            this.Text = "FormCreateProject";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtProjectName;
        private Guna.UI2.WinForms.Guna2Button btnCreateProject;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txtProjectContent;
    }
}