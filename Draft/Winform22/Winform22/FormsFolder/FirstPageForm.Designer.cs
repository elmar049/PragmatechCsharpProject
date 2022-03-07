namespace Winform22.FormsFolder
{
    partial class FirstPageForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FirstPageForm));
            this.regbtn = new System.Windows.Forms.Button();
            this.LogBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // regbtn
            // 
            this.regbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regbtn.Location = new System.Drawing.Point(469, 274);
            this.regbtn.Name = "regbtn";
            this.regbtn.Size = new System.Drawing.Size(107, 47);
            this.regbtn.TabIndex = 7;
            this.regbtn.Text = "Sing Up";
            this.regbtn.UseVisualStyleBackColor = true;
            this.regbtn.Click += new System.EventHandler(this.regbtn_Click);
            // 
            // LogBtn
            // 
            this.LogBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogBtn.Location = new System.Drawing.Point(250, 274);
            this.LogBtn.Name = "LogBtn";
            this.LogBtn.Size = new System.Drawing.Size(120, 47);
            this.LogBtn.TabIndex = 6;
            this.LogBtn.Text = "Login";
            this.LogBtn.UseVisualStyleBackColor = true;
            this.LogBtn.Click += new System.EventHandler(this.LogBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("MV Boli", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(155, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(477, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "PLease Choose what is your next step:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("MV Boli", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(150, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(548, 58);
            this.label1.TabIndex = 4;
            this.label1.Text = "Welcome to our System";
            // 
            // FirstPageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.regbtn);
            this.Controls.Add(this.LogBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FirstPageForm";
            this.Text = "FirstPageForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button regbtn;
        private System.Windows.Forms.Button LogBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}