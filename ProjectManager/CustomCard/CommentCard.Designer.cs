
namespace ProjectManager.CustomCard
{
    partial class CommentCard
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
            this.lblCommentOwner = new System.Windows.Forms.Label();
            this.txtComment = new Guna.UI2.WinForms.Guna2TextBox();
            this.SuspendLayout();
            // 
            // lblCommentOwner
            // 
            this.lblCommentOwner.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCommentOwner.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCommentOwner.Location = new System.Drawing.Point(0, 0);
            this.lblCommentOwner.Name = "lblCommentOwner";
            this.lblCommentOwner.Padding = new System.Windows.Forms.Padding(5);
            this.lblCommentOwner.Size = new System.Drawing.Size(554, 37);
            this.lblCommentOwner.TabIndex = 0;
            this.lblCommentOwner.Text = "Comment Owner";
            this.lblCommentOwner.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtComment
            // 
            this.txtComment.BorderColor = System.Drawing.Color.Maroon;
            this.txtComment.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtComment.DefaultText = "";
            this.txtComment.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtComment.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtComment.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtComment.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtComment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtComment.Enabled = false;
            this.txtComment.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.txtComment.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtComment.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtComment.ForeColor = System.Drawing.Color.Maroon;
            this.txtComment.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtComment.Location = new System.Drawing.Point(0, 37);
            this.txtComment.Name = "txtComment";
            this.txtComment.PasswordChar = '\0';
            this.txtComment.PlaceholderText = "Comment";
            this.txtComment.SelectedText = "";
            this.txtComment.Size = new System.Drawing.Size(554, 64);
            this.txtComment.TabIndex = 1;
            // 
            // CommentCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.Controls.Add(this.txtComment);
            this.Controls.Add(this.lblCommentOwner);
            this.Margin = new System.Windows.Forms.Padding(20);
            this.Name = "CommentCard";
            this.Size = new System.Drawing.Size(554, 101);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblCommentOwner;
        private Guna.UI2.WinForms.Guna2TextBox txtComment;
    }
}
