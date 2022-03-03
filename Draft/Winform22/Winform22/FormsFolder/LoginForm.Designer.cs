namespace Winform22.FormsFolder
{
    partial class LoginForm
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
            this.LoginLogin = new System.Windows.Forms.Label();
            this.LoginPassword = new System.Windows.Forms.Label();
            this.textBoxLog = new System.Windows.Forms.TextBox();
            this.textBoxPass = new System.Windows.Forms.TextBox();
            this.DaxilOlarken = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LoginLogin
            // 
            this.LoginLogin.AutoSize = true;
            this.LoginLogin.Location = new System.Drawing.Point(153, 155);
            this.LoginLogin.Name = "LoginLogin";
            this.LoginLogin.Size = new System.Drawing.Size(40, 16);
            this.LoginLogin.TabIndex = 0;
            this.LoginLogin.Text = "Login";
            // 
            // LoginPassword
            // 
            this.LoginPassword.AutoSize = true;
            this.LoginPassword.Location = new System.Drawing.Point(156, 209);
            this.LoginPassword.Name = "LoginPassword";
            this.LoginPassword.Size = new System.Drawing.Size(67, 16);
            this.LoginPassword.TabIndex = 1;
            this.LoginPassword.Text = "Password";
            // 
            // textBoxLog
            // 
            this.textBoxLog.Location = new System.Drawing.Point(253, 149);
            this.textBoxLog.Name = "textBoxLog";
            this.textBoxLog.Size = new System.Drawing.Size(185, 22);
            this.textBoxLog.TabIndex = 2;
            // 
            // textBoxPass
            // 
            this.textBoxPass.Location = new System.Drawing.Point(253, 203);
            this.textBoxPass.Name = "textBoxPass";
            this.textBoxPass.Size = new System.Drawing.Size(185, 22);
            this.textBoxPass.TabIndex = 3;
            // 
            // DaxilOlarken
            // 
            this.DaxilOlarken.Location = new System.Drawing.Point(389, 269);
            this.DaxilOlarken.Name = "DaxilOlarken";
            this.DaxilOlarken.Size = new System.Drawing.Size(75, 23);
            this.DaxilOlarken.TabIndex = 4;
            this.DaxilOlarken.Text = "Log in";
            this.DaxilOlarken.UseVisualStyleBackColor = true;
            this.DaxilOlarken.Click += new System.EventHandler(this.DaxilOlarken_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(214, 268);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DaxilOlarken);
            this.Controls.Add(this.textBoxPass);
            this.Controls.Add(this.textBoxLog);
            this.Controls.Add(this.LoginPassword);
            this.Controls.Add(this.LoginLogin);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LoginLogin;
        private System.Windows.Forms.Label LoginPassword;
        private System.Windows.Forms.TextBox textBoxLog;
        private System.Windows.Forms.TextBox textBoxPass;
        private System.Windows.Forms.Button DaxilOlarken;
        private System.Windows.Forms.Button button1;
    }
}