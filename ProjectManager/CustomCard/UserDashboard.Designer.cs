
namespace ProjectManager.CustomCard
{
    partial class UserDashboard
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
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.ComboDate = new Guna.UI2.WinForms.Guna2ComboBox();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.ComboProjectType = new Guna.UI2.WinForms.Guna2ComboBox();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.guna2GradientPanel2 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCompletedTask = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.guna2GradientPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            this.guna2GradientPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.guna2GradientPanel1.Controls.Add(this.flowLayoutPanel1);
            this.guna2GradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2GradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.Padding = new System.Windows.Forms.Padding(5);
            this.guna2GradientPanel1.Size = new System.Drawing.Size(820, 447);
            this.guna2GradientPanel1.TabIndex = 3;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel2);
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel3);
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel4);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(5, 5);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(810, 430);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            this.guna2Elipse1.TargetControl = this.guna2GradientPanel1;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.flowLayoutPanel2.Controls.Add(this.label1);
            this.flowLayoutPanel2.Controls.Add(this.ComboDate);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(379, 114);
            this.flowLayoutPanel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(20, 20, 20, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(337, 28);
            this.label1.TabIndex = 3;
            this.label1.Text = "Date";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ComboDate
            // 
            this.ComboDate.BackColor = System.Drawing.Color.Transparent;
            this.ComboDate.BorderColor = System.Drawing.Color.Aqua;
            this.ComboDate.BorderRadius = 10;
            this.ComboDate.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ComboDate.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ComboDate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboDate.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ComboDate.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ComboDate.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ComboDate.ForeColor = System.Drawing.Color.Black;
            this.ComboDate.ItemHeight = 30;
            this.ComboDate.Items.AddRange(new object[] {
            "All",
            "Today",
            "This Month",
            "This Year"});
            this.ComboDate.Location = new System.Drawing.Point(20, 53);
            this.ComboDate.Margin = new System.Windows.Forms.Padding(20, 0, 20, 20);
            this.ComboDate.Name = "ComboDate";
            this.ComboDate.Size = new System.Drawing.Size(337, 36);
            this.ComboDate.StartIndex = 0;
            this.ComboDate.TabIndex = 2;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.flowLayoutPanel3.Controls.Add(this.label2);
            this.flowLayoutPanel3.Controls.Add(this.ComboProjectType);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(388, 3);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(379, 114);
            this.flowLayoutPanel3.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.label2.Location = new System.Drawing.Point(20, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(20, 20, 20, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(355, 28);
            this.label2.TabIndex = 3;
            this.label2.Text = "Project Type";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ComboProjectType
            // 
            this.ComboProjectType.BackColor = System.Drawing.Color.Transparent;
            this.ComboProjectType.BorderColor = System.Drawing.Color.Aqua;
            this.ComboProjectType.BorderRadius = 10;
            this.ComboProjectType.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ComboProjectType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ComboProjectType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboProjectType.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ComboProjectType.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ComboProjectType.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ComboProjectType.ForeColor = System.Drawing.Color.Black;
            this.ComboProjectType.ItemHeight = 30;
            this.ComboProjectType.Items.AddRange(new object[] {
            "All",
            "Not Started",
            "In Progress",
            "Waiting",
            "Done"});
            this.ComboProjectType.Location = new System.Drawing.Point(20, 53);
            this.ComboProjectType.Margin = new System.Windows.Forms.Padding(20, 0, 20, 20);
            this.ComboProjectType.Name = "ComboProjectType";
            this.ComboProjectType.Size = new System.Drawing.Size(355, 36);
            this.ComboProjectType.StartIndex = 0;
            this.ComboProjectType.TabIndex = 2;
            this.ComboProjectType.SelectedIndexChanged += new System.EventHandler(this.ComboProjectType_SelectedIndexChanged);
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.Controls.Add(this.guna2GradientPanel2);
            this.flowLayoutPanel4.Location = new System.Drawing.Point(3, 150);
            this.flowLayoutPanel4.Margin = new System.Windows.Forms.Padding(3, 30, 3, 3);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(211, 221);
            this.flowLayoutPanel4.TabIndex = 5;
            // 
            // guna2GradientPanel2
            // 
            this.guna2GradientPanel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.guna2GradientPanel2.Controls.Add(this.label3);
            this.guna2GradientPanel2.Controls.Add(this.lblCompletedTask);
            this.guna2GradientPanel2.Controls.Add(this.lblTitle);
            this.guna2GradientPanel2.Location = new System.Drawing.Point(3, 3);
            this.guna2GradientPanel2.Name = "guna2GradientPanel2";
            this.guna2GradientPanel2.Padding = new System.Windows.Forms.Padding(5);
            this.guna2GradientPanel2.Size = new System.Drawing.Size(204, 215);
            this.guna2GradientPanel2.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(89)))), ((int)(((byte)(133)))));
            this.label3.Location = new System.Drawing.Point(5, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "You are doing well!";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCompletedTask
            // 
            this.lblCompletedTask.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCompletedTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCompletedTask.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(60)))), ((int)(((byte)(104)))));
            this.lblCompletedTask.Location = new System.Drawing.Point(5, 31);
            this.lblCompletedTask.Name = "lblCompletedTask";
            this.lblCompletedTask.Size = new System.Drawing.Size(194, 179);
            this.lblCompletedTask.TabIndex = 1;
            this.lblCompletedTask.Text = "6";
            this.lblCompletedTask.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(18)))), ((int)(((byte)(43)))));
            this.lblTitle.Location = new System.Drawing.Point(5, 5);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(194, 26);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "All Tasks Count";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // UserDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.guna2GradientPanel1);
            this.Name = "UserDashboard";
            this.Size = new System.Drawing.Size(820, 447);
            this.Load += new System.EventHandler(this.UserDashboard_Load);
            this.guna2GradientPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel4.ResumeLayout(false);
            this.guna2GradientPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ComboBox ComboDate;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2ComboBox ComboProjectType;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblCompletedTask;
        private System.Windows.Forms.Label lblTitle;
    }
}
