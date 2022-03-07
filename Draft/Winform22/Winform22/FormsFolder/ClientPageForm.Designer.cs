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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientPageForm));
            this.label1 = new System.Windows.Forms.Label();
            this.deletebtn = new System.Windows.Forms.Button();
            this.mdfrBtn = new System.Windows.Forms.Button();
            this.labelfordelleteing = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(267, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(304, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to your own page";
            // 
            // deletebtn
            // 
            this.deletebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletebtn.Location = new System.Drawing.Point(406, 317);
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.Size = new System.Drawing.Size(98, 32);
            this.deletebtn.TabIndex = 3;
            this.deletebtn.Text = "Delete";
            this.deletebtn.UseVisualStyleBackColor = true;
            this.deletebtn.Click += new System.EventHandler(this.deletebtn_Click);
            // 
            // mdfrBtn
            // 
            this.mdfrBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mdfrBtn.Location = new System.Drawing.Point(406, 364);
            this.mdfrBtn.Name = "mdfrBtn";
            this.mdfrBtn.Size = new System.Drawing.Size(98, 28);
            this.mdfrBtn.TabIndex = 4;
            this.mdfrBtn.Text = "Modify";
            this.mdfrBtn.UseVisualStyleBackColor = true;
            this.mdfrBtn.Click += new System.EventHandler(this.mdfrBtn_Click);
            // 
            // labelfordelleteing
            // 
            this.labelfordelleteing.AutoSize = true;
            this.labelfordelleteing.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelfordelleteing.ForeColor = System.Drawing.Color.Red;
            this.labelfordelleteing.Location = new System.Drawing.Point(31, 317);
            this.labelfordelleteing.Name = "labelfordelleteing";
            this.labelfordelleteing.Size = new System.Drawing.Size(270, 27);
            this.labelfordelleteing.TabIndex = 5;
            this.labelfordelleteing.Text = "You can delete your profile";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(31, 365);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(311, 27);
            this.label3.TabIndex = 6;
            this.label3.Text = "You can modify your log/name";
            this.label3.Click += new System.EventHandler(this.label3_Click);
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
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip1);
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
        private System.Windows.Forms.StatusStrip statusStrip1;
    }
}