namespace Mercury
{
    partial class RegisterForm
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
            if(null!= _icon)
            {
                _icon.Dispose();
                _icon = null;
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
            this.components = new System.ComponentModel.Container();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lbID = new System.Windows.Forms.Label();
            this.lbPassword = new System.Windows.Forms.Label();
            this.tbID = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.epError = new System.Windows.Forms.ErrorProvider(this.components);
            this.lbPasswordAgain = new System.Windows.Forms.Label();
            this.tbPasswordAgain = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.epError)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLogin.Location = new System.Drawing.Point(154, 277);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(100, 30);
            this.btnLogin.TabIndex = 6;
            this.btnLogin.Text = "注册";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancel.Location = new System.Drawing.Point(347, 277);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 30);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Location = new System.Drawing.Point(118, 85);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(62, 18);
            this.lbID.TabIndex = 0;
            this.lbID.Text = "账号：";
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Location = new System.Drawing.Point(119, 132);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(62, 18);
            this.lbPassword.TabIndex = 1;
            this.lbPassword.Text = "密码：";
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(186, 82);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(318, 28);
            this.tbID.TabIndex = 3;
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(187, 129);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(318, 28);
            this.tbPassword.TabIndex = 4;
            // 
            // epError
            // 
            this.epError.ContainerControl = this;
            // 
            // lbPasswordAgain
            // 
            this.lbPasswordAgain.AutoSize = true;
            this.lbPasswordAgain.Location = new System.Drawing.Point(48, 184);
            this.lbPasswordAgain.Name = "lbPasswordAgain";
            this.lbPasswordAgain.Size = new System.Drawing.Size(134, 18);
            this.lbPasswordAgain.TabIndex = 2;
            this.lbPasswordAgain.Text = "再次输入密码：";
            // 
            // tbPasswordAgain
            // 
            this.tbPasswordAgain.Location = new System.Drawing.Point(187, 181);
            this.tbPasswordAgain.Name = "tbPasswordAgain";
            this.tbPasswordAgain.PasswordChar = '*';
            this.tbPasswordAgain.Size = new System.Drawing.Size(318, 28);
            this.tbPasswordAgain.TabIndex = 5;
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 334);
            this.Controls.Add(this.tbPasswordAgain);
            this.Controls.Add(this.lbPasswordAgain);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.lbPassword);
            this.Controls.Add(this.lbID);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnLogin);
            this.Name = "RegisterForm";
            this.Text = "注册新用户";
            ((System.ComponentModel.ISupportInitialize)(this.epError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.ErrorProvider epError;
        private System.Windows.Forms.Label lbPasswordAgain;
        private System.Windows.Forms.TextBox tbPasswordAgain;
    }
}
