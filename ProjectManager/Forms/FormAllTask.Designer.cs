
namespace ProjectManager.Forms
{
    partial class FormAllTask
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
            this.allTask1 = new ProjectManager.CustomCard.AllTask();
            this.SuspendLayout();
            // 
            // allTask1
            // 
            this.allTask1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.allTask1.Dock = System.Windows.Forms.DockStyle.Top;
            this.allTask1.Location = new System.Drawing.Point(0, 0);
            this.allTask1.Name = "allTask1";
            this.allTask1.Size = new System.Drawing.Size(1101, 515);
            this.allTask1.TabIndex = 0;
            // 
            // FormAllTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(1101, 515);
            this.Controls.Add(this.allTask1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAllTask";
            this.Text = "FormAllTask";
            this.ResumeLayout(false);

        }

        #endregion

        private CustomCard.AllTask allTask1;
    }
}