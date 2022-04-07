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
            this.showTheToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.show5LastUploadedPhotosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showPhotosWithjpgExtentionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.CategoryDeleteButton = new System.Windows.Forms.Button();
            this.ComboxobTodeleteCategory = new System.Windows.Forms.ComboBox();
            this.panelForCategories = new System.Windows.Forms.Panel();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(952, 31);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(64, 29);
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
            this.comboBox.Location = new System.Drawing.Point(895, 4);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(121, 24);
            this.comboBox.TabIndex = 5;
            // 
            // category_button
            // 
            this.category_button.Location = new System.Drawing.Point(492, 28);
            this.category_button.Name = "category_button";
            this.category_button.Size = new System.Drawing.Size(106, 32);
            this.category_button.TabIndex = 6;
            this.category_button.Text = "Category add";
            this.category_button.UseVisualStyleBackColor = true;
            this.category_button.Click += new System.EventHandler(this.category_button_Click);
            // 
            // category_text
            // 
            this.category_text.Location = new System.Drawing.Point(411, 3);
            this.category_text.Name = "category_text";
            this.category_text.Size = new System.Drawing.Size(187, 22);
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
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
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
            this.show5LastUploadedPhotosToolStripMenuItem.Click += new System.EventHandler(this.show5LastUploadedPhotosToolStripMenuItem_Click);
            // 
            // showPhotosWithjpgExtentionToolStripMenuItem
            // 
            this.showPhotosWithjpgExtentionToolStripMenuItem.Name = "showPhotosWithjpgExtentionToolStripMenuItem";
            this.showPhotosWithjpgExtentionToolStripMenuItem.Size = new System.Drawing.Size(305, 26);
            this.showPhotosWithjpgExtentionToolStripMenuItem.Text = "Show photos with .jpg extention";
            this.showPhotosWithjpgExtentionToolStripMenuItem.Click += new System.EventHandler(this.showPhotosWithjpgExtentionToolStripMenuItem_Click);
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.categoriesToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(1141, 28);
            this.menuStrip2.TabIndex = 10;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 28);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1141, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // CategoryDeleteButton
            // 
            this.CategoryDeleteButton.Location = new System.Drawing.Point(700, 31);
            this.CategoryDeleteButton.Name = "CategoryDeleteButton";
            this.CategoryDeleteButton.Size = new System.Drawing.Size(134, 29);
            this.CategoryDeleteButton.TabIndex = 11;
            this.CategoryDeleteButton.Text = "Delete Category";
            this.CategoryDeleteButton.UseVisualStyleBackColor = true;
            this.CategoryDeleteButton.Click += new System.EventHandler(this.CategoryDeleteButton_Click);
            // 
            // ComboxobTodeleteCategory
            // 
            this.ComboxobTodeleteCategory.FormattingEnabled = true;
            this.ComboxobTodeleteCategory.Location = new System.Drawing.Point(666, 1);
            this.ComboxobTodeleteCategory.Name = "ComboxobTodeleteCategory";
            this.ComboxobTodeleteCategory.Size = new System.Drawing.Size(168, 24);
            this.ComboxobTodeleteCategory.TabIndex = 12;
            // 
            // panelForCategories
            // 
            this.panelForCategories.Location = new System.Drawing.Point(0, 73);
            this.panelForCategories.Name = "panelForCategories";
            this.panelForCategories.Size = new System.Drawing.Size(1116, 78);
            this.panelForCategories.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1141, 542);
            this.Controls.Add(this.panelForCategories);
            this.Controls.Add(this.ComboxobTodeleteCategory);
            this.Controls.Add(this.CategoryDeleteButton);
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
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem showTheToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem show5LastUploadedPhotosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showPhotosWithjpgExtentionToolStripMenuItem;
        private System.Windows.Forms.Button CategoryDeleteButton;
        private System.Windows.Forms.ComboBox ComboxobTodeleteCategory;
        private System.Windows.Forms.Panel panelForCategories;
    }
}

