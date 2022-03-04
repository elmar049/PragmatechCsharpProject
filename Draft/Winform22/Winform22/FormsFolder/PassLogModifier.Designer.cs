namespace Winform22.FormsFolder
{
    partial class PassLogModifier
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.savebtnmodify = new System.Windows.Forms.Button();
            this.textBoxname = new System.Windows.Forms.TextBox();
            this.textBoxpass = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Write new log:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(103, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Write new pass";
            // 
            // savebtnmodify
            // 
            this.savebtnmodify.Location = new System.Drawing.Point(312, 308);
            this.savebtnmodify.Name = "savebtnmodify";
            this.savebtnmodify.Size = new System.Drawing.Size(75, 23);
            this.savebtnmodify.TabIndex = 2;
            this.savebtnmodify.Text = "save";
            this.savebtnmodify.UseVisualStyleBackColor = true;
            this.savebtnmodify.Click += new System.EventHandler(this.savebtnmodify_Click);
            // 
            // textBoxname
            // 
            this.textBoxname.Location = new System.Drawing.Point(247, 127);
            this.textBoxname.Name = "textBoxname";
            this.textBoxname.Size = new System.Drawing.Size(213, 22);
            this.textBoxname.TabIndex = 3;
            // 
            // textBoxpass
            // 
            this.textBoxpass.Location = new System.Drawing.Point(247, 196);
            this.textBoxpass.Name = "textBoxpass";
            this.textBoxpass.Size = new System.Drawing.Size(213, 22);
            this.textBoxpass.TabIndex = 4;
            // 
            // PassLogModifier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxpass);
            this.Controls.Add(this.textBoxname);
            this.Controls.Add(this.savebtnmodify);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "PassLogModifier";
            this.Text = "PassLogModifier";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button savebtnmodify;
        private System.Windows.Forms.TextBox textBoxname;
        private System.Windows.Forms.TextBox textBoxpass;
    }
}