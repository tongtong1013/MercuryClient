namespace Mercury
{
    partial class MainForm
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if(null != _tempFriend)
            {
                _tempFriend.Dispose();
                _tempFriend = null;
            }
            if(null!= _star)
            {
                _star.Dispose();
                _star = null;
            }
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pbFriendPhoto = new System.Windows.Forms.PictureBox();
            this.plFriend = new System.Windows.Forms.Panel();
            this.lbFriendName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbFriendPhoto)).BeginInit();
            this.plFriend.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbFriendPhoto
            // 
            this.pbFriendPhoto.Location = new System.Drawing.Point(3, 3);
            this.pbFriendPhoto.Name = "pbFriendPhoto";
            this.pbFriendPhoto.Size = new System.Drawing.Size(80, 80);
            this.pbFriendPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFriendPhoto.TabIndex = 0;
            this.pbFriendPhoto.TabStop = false;
            this.pbFriendPhoto.DoubleClick += new System.EventHandler(this.plFriend_DoubleClick);
            // 
            // plFriend
            // 
            this.plFriend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.plFriend.Controls.Add(this.lbFriendName);
            this.plFriend.Controls.Add(this.pbFriendPhoto);
            this.plFriend.Location = new System.Drawing.Point(49, 68);
            this.plFriend.Name = "plFriend";
            this.plFriend.Size = new System.Drawing.Size(200, 86);
            this.plFriend.TabIndex = 1;
            this.plFriend.DoubleClick += new System.EventHandler(this.plFriend_DoubleClick);
            // 
            // lbFriendName
            // 
            this.lbFriendName.AutoSize = true;
            this.lbFriendName.Location = new System.Drawing.Point(89, 40);
            this.lbFriendName.Name = "lbFriendName";
            this.lbFriendName.Size = new System.Drawing.Size(44, 18);
            this.lbFriendName.TabIndex = 2;
            this.lbFriendName.Text = "师父";
            this.lbFriendName.DoubleClick += new System.EventHandler(this.plFriend_DoubleClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 634);
            this.Controls.Add(this.plFriend);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Mercury";
            ((System.ComponentModel.ISupportInitialize)(this.pbFriendPhoto)).EndInit();
            this.plFriend.ResumeLayout(false);
            this.plFriend.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbFriendPhoto;
        private System.Windows.Forms.Panel plFriend;
        private System.Windows.Forms.Label lbFriendName;
    }
}
