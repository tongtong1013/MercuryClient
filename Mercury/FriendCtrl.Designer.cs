namespace Mercury
{
    partial class FriendCtrl
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
            this.pbPortrait = new System.Windows.Forms.PictureBox();
            this.lbName = new System.Windows.Forms.Label();
            this.lbSign = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbPortrait)).BeginInit();
            this.SuspendLayout();
            // 
            // pbPortrait
            // 
            this.pbPortrait.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pbPortrait.Location = new System.Drawing.Point(5, 5);
            this.pbPortrait.Name = "pbPortrait";
            this.pbPortrait.Size = new System.Drawing.Size(90, 90);
            this.pbPortrait.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPortrait.TabIndex = 0;
            this.pbPortrait.TabStop = false;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(102, 24);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(44, 18);
            this.lbName.TabIndex = 1;
            this.lbName.Text = "昵称";
            // 
            // lbSign
            // 
            this.lbSign.AutoSize = true;
            this.lbSign.Location = new System.Drawing.Point(102, 65);
            this.lbSign.Name = "lbSign";
            this.lbSign.Size = new System.Drawing.Size(80, 18);
            this.lbSign.TabIndex = 2;
            this.lbSign.Text = "个性签名";
            // 
            // FriendCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbSign);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.pbPortrait);
            this.Name = "FriendCtrl";
            this.Size = new System.Drawing.Size(300, 100);
            ((System.ComponentModel.ISupportInitialize)(this.pbPortrait)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbPortrait;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbSign;
    }
}
