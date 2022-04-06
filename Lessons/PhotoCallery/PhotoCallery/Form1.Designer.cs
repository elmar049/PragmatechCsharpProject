namespace PhotoCallery
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.category_button = new System.Windows.Forms.Button();
            this.category_text = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.showTheToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.show5LastUploadedPhotosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showPhotosWithjpgExtentionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(925, 40);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 34);
            this.button1.TabIndex = 3;
            this.button1.Text = "Upload";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // comboBox
            // 
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Location = new System.Drawing.Point(885, 12);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(121, 24);
            this.comboBox.TabIndex = 5;
            // 
            // category_button
            // 
            this.category_button.Location = new System.Drawing.Point(699, 40);
            this.category_button.Name = "category_button";
            this.category_button.Size = new System.Drawing.Size(121, 34);
            this.category_button.TabIndex = 6;
            this.category_button.Text = "Category add";
            this.category_button.UseVisualStyleBackColor = true;
            this.category_button.Click += new System.EventHandler(this.category_button_Click);
            // 
            // category_text
            // 
            this.category_text.Location = new System.Drawing.Point(688, 12);
            this.category_text.Name = "category_text";
            this.category_text.Size = new System.Drawing.Size(132, 22);
            this.category_text.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 157);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2000, 65535);
            this.panel1.TabIndex = 8;
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(128, 26);
            this.closeToolStripMenuItem.Text = "Close";
            // 
            // categoriesToolStripMenuItem
            // 
            this.categoriesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showTheToolStripMenuItem,
            this.show5LastUploadedPhotosToolStripMenuItem,
            this.showPhotosWithjpgExtentionToolStripMenuItem});
            this.categoriesToolStripMenuItem.Name = "categoriesToolStripMenuItem";
            this.categoriesToolStripMenuItem.Size = new System.Drawing.Size(96, 24);
            this.categoriesToolStripMenuItem.Text = "Operations";
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
            this.deleteToolStripMenuItem.Text = "Delete";
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.categoriesToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(1062, 28);
            this.menuStrip2.TabIndex = 10;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 28);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1062, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // showTheToolStripMenuItem
            // 
            this.showTheToolStripMenuItem.Name = "showTheToolStripMenuItem";
            this.showTheToolStripMenuItem.Size = new System.Drawing.Size(305, 26);
            this.showTheToolStripMenuItem.Text = "Show 5 the higest size photos ";
            this.showTheToolStripMenuItem.Click += new System.EventHandler(this.showTheToolStripMenuItem_Click);
            // 
            // show5LastUploadedPhotosToolStripMenuItem
            // 
            this.show5LastUploadedPhotosToolStripMenuItem.Name = "show5LastUploadedPhotosToolStripMenuItem";
            this.show5LastUploadedPhotosToolStripMenuItem.Size = new System.Drawing.Size(305, 26);
            this.show5LastUploadedPhotosToolStripMenuItem.Text = "Show 5 last uploaded photos";
            // 
            // showPhotosWithjpgExtentionToolStripMenuItem
            // 
            this.showPhotosWithjpgExtentionToolStripMenuItem.Name = "showPhotosWithjpgExtentionToolStripMenuItem";
            this.showPhotosWithjpgExtentionToolStripMenuItem.Size = new System.Drawing.Size(305, 26);
            this.showPhotosWithjpgExtentionToolStripMenuItem.Text = "Show photos with .jpg extention";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 542);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.category_text);
            this.Controls.Add(this.category_button);
            this.Controls.Add(this.comboBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Gallery";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.Button category_button;
        private System.Windows.Forms.TextBox category_text;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoriesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem showTheToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem show5LastUploadedPhotosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showPhotosWithjpgExtentionToolStripMenuItem;
    }
}

