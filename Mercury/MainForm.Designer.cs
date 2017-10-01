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
            this.plMyInfo = new System.Windows.Forms.Panel();
            this.lbSign = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.pbPhoto = new System.Windows.Forms.PictureBox();
            this.plTool = new System.Windows.Forms.Panel();
            this.lbAddFriends = new System.Windows.Forms.Label();
            this.tvFriends = new System.Windows.Forms.TreeView();
            this.plMyInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPhoto)).BeginInit();
            this.plTool.SuspendLayout();
            this.SuspendLayout();
            // 
            // plMyInfo
            // 
            this.plMyInfo.Controls.Add(this.lbSign);
            this.plMyInfo.Controls.Add(this.lbName);
            this.plMyInfo.Controls.Add(this.pbPhoto);
            this.plMyInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.plMyInfo.Location = new System.Drawing.Point(0, 0);
            this.plMyInfo.Name = "plMyInfo";
            this.plMyInfo.Size = new System.Drawing.Size(388, 100);
            this.plMyInfo.TabIndex = 0;
            // 
            // lbSign
            // 
            this.lbSign.AutoSize = true;
            this.lbSign.Location = new System.Drawing.Point(117, 61);
            this.lbSign.Name = "lbSign";
            this.lbSign.Size = new System.Drawing.Size(80, 18);
            this.lbSign.TabIndex = 2;
            this.lbSign.Text = "个性签名";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(117, 21);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(80, 18);
            this.lbName.TabIndex = 1;
            this.lbName.Text = "个人名称";
            // 
            // pbPhoto
            // 
            this.pbPhoto.Dock = System.Windows.Forms.DockStyle.Left;
            this.pbPhoto.Location = new System.Drawing.Point(0, 0);
            this.pbPhoto.Name = "pbPhoto";
            this.pbPhoto.Size = new System.Drawing.Size(100, 100);
            this.pbPhoto.TabIndex = 0;
            this.pbPhoto.TabStop = false;
            // 
            // plTool
            // 
            this.plTool.Controls.Add(this.lbAddFriends);
            this.plTool.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.plTool.Location = new System.Drawing.Point(0, 584);
            this.plTool.Name = "plTool";
            this.plTool.Size = new System.Drawing.Size(388, 50);
            this.plTool.TabIndex = 2;
            // 
            // lbAddFriends
            // 
            this.lbAddFriends.AutoSize = true;
            this.lbAddFriends.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbAddFriends.Location = new System.Drawing.Point(12, 16);
            this.lbAddFriends.Name = "lbAddFriends";
            this.lbAddFriends.Size = new System.Drawing.Size(62, 18);
            this.lbAddFriends.TabIndex = 4;
            this.lbAddFriends.Text = "加好友";
            this.lbAddFriends.Click += new System.EventHandler(this.lbAddFriends_Click);
            // 
            // tvFriends
            // 
            this.tvFriends.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvFriends.Location = new System.Drawing.Point(0, 100);
            this.tvFriends.Name = "tvFriends";
            this.tvFriends.Size = new System.Drawing.Size(388, 484);
            this.tvFriends.TabIndex = 3;
            this.tvFriends.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tvFriends_NodeMouseDoubleClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 634);
            this.Controls.Add(this.tvFriends);
            this.Controls.Add(this.plTool);
            this.Controls.Add(this.plMyInfo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Mercury";
            this.TopMost = true;
            this.plMyInfo.ResumeLayout(false);
            this.plMyInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPhoto)).EndInit();
            this.plTool.ResumeLayout(false);
            this.plTool.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel plMyInfo;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.PictureBox pbPhoto;
        private System.Windows.Forms.Label lbSign;
        private System.Windows.Forms.Panel plTool;
        private System.Windows.Forms.Label lbAddFriends;
        private System.Windows.Forms.TreeView tvFriends;
    }
}
