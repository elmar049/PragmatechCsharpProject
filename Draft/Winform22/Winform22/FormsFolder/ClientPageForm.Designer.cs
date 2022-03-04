namespace Winform22.FormsFolder
{
    partial class ClientPageForm
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
            this.deletebtn = new System.Windows.Forms.Button();
            this.mdfrBtn = new System.Windows.Forms.Button();
            this.labelfordelleteing = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labLog = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(285, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to your own page";
            // 
            // deletebtn
            // 
            this.deletebtn.Location = new System.Drawing.Point(405, 279);
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.Size = new System.Drawing.Size(75, 23);
            this.deletebtn.TabIndex = 3;
            this.deletebtn.Text = "Delete";
            this.deletebtn.UseVisualStyleBackColor = true;
            this.deletebtn.Click += new System.EventHandler(this.deletebtn_Click);
            // 
            // mdfrBtn
            // 
            this.mdfrBtn.Location = new System.Drawing.Point(405, 326);
            this.mdfrBtn.Name = "mdfrBtn";
            this.mdfrBtn.Size = new System.Drawing.Size(75, 23);
            this.mdfrBtn.TabIndex = 4;
            this.mdfrBtn.Text = "Modify";
            this.mdfrBtn.UseVisualStyleBackColor = true;
            this.mdfrBtn.Click += new System.EventHandler(this.mdfrBtn_Click);
            // 
            // labelfordelleteing
            // 
            this.labelfordelleteing.AutoSize = true;
            this.labelfordelleteing.Location = new System.Drawing.Point(211, 286);
            this.labelfordelleteing.Name = "labelfordelleteing";
            this.labelfordelleteing.Size = new System.Drawing.Size(166, 16);
            this.labelfordelleteing.TabIndex = 5;
            this.labelfordelleteing.Text = "You can delete your profile";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(211, 326);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(188, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "You can modify your log/name";
            // 
            // labLog
            // 
            this.labLog.AutoSize = true;
            this.labLog.Location = new System.Drawing.Point(211, 106);
            this.labLog.Name = "labLog";
            this.labLog.Size = new System.Drawing.Size(72, 16);
            this.labLog.TabIndex = 7;
            this.labLog.Text = "Your name";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // ClientPageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.labLog);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelfordelleteing);
            this.Controls.Add(this.mdfrBtn);
            this.Controls.Add(this.deletebtn);
            this.Controls.Add(this.label1);
            this.Name = "ClientPageForm";
            this.Text = "ClientPageForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button deletebtn;
        private System.Windows.Forms.Button mdfrBtn;
        private System.Windows.Forms.Label labelfordelleteing;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labLog;
        private System.Windows.Forms.StatusStrip statusStrip1;
    }
}