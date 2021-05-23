namespace AssignmentProject
{
    partial class AddWebsiteForm
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
            this.labelServerName = new System.Windows.Forms.Label();
            this.labelProjectPlatform = new System.Windows.Forms.Label();
            this.labelProjectDeadline = new System.Windows.Forms.Label();
            this.labelProjectClient = new System.Windows.Forms.Label();
            this.labelProejctName = new System.Windows.Forms.Label();
            this.txtBoxServerName = new System.Windows.Forms.TextBox();
            this.txtBoxProjectPlatform = new System.Windows.Forms.TextBox();
            this.txtBoxProjectName = new System.Windows.Forms.TextBox();
            this.txtBoxProjectClient = new System.Windows.Forms.TextBox();
            this.txtBoxProjectDeadline = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.labelNumOfWebPages = new System.Windows.Forms.Label();
            this.txtBoxNumOfPages = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelServerName
            // 
            this.labelServerName.AutoSize = true;
            this.labelServerName.Location = new System.Drawing.Point(12, 196);
            this.labelServerName.Name = "labelServerName";
            this.labelServerName.Size = new System.Drawing.Size(67, 13);
            this.labelServerName.TabIndex = 39;
            this.labelServerName.Text = "Server name";
            // 
            // labelProjectPlatform
            // 
            this.labelProjectPlatform.AutoSize = true;
            this.labelProjectPlatform.Location = new System.Drawing.Point(262, 102);
            this.labelProjectPlatform.Name = "labelProjectPlatform";
            this.labelProjectPlatform.Size = new System.Drawing.Size(80, 13);
            this.labelProjectPlatform.TabIndex = 38;
            this.labelProjectPlatform.Text = "Project platform";
            // 
            // labelProjectDeadline
            // 
            this.labelProjectDeadline.AutoSize = true;
            this.labelProjectDeadline.Location = new System.Drawing.Point(9, 102);
            this.labelProjectDeadline.Name = "labelProjectDeadline";
            this.labelProjectDeadline.Size = new System.Drawing.Size(83, 13);
            this.labelProjectDeadline.TabIndex = 37;
            this.labelProjectDeadline.Text = "Project deadline";
            // 
            // labelProjectClient
            // 
            this.labelProjectClient.AutoSize = true;
            this.labelProjectClient.Location = new System.Drawing.Point(262, 9);
            this.labelProjectClient.Name = "labelProjectClient";
            this.labelProjectClient.Size = new System.Drawing.Size(68, 13);
            this.labelProjectClient.TabIndex = 36;
            this.labelProjectClient.Text = "Project client";
            // 
            // labelProejctName
            // 
            this.labelProejctName.AutoSize = true;
            this.labelProejctName.Location = new System.Drawing.Point(12, 9);
            this.labelProejctName.Name = "labelProejctName";
            this.labelProejctName.Size = new System.Drawing.Size(69, 13);
            this.labelProejctName.TabIndex = 35;
            this.labelProejctName.Text = "Project name";
            // 
            // txtBoxServerName
            // 
            this.txtBoxServerName.Location = new System.Drawing.Point(12, 212);
            this.txtBoxServerName.Name = "txtBoxServerName";
            this.txtBoxServerName.Size = new System.Drawing.Size(126, 20);
            this.txtBoxServerName.TabIndex = 34;
            // 
            // txtBoxProjectPlatform
            // 
            this.txtBoxProjectPlatform.Location = new System.Drawing.Point(265, 118);
            this.txtBoxProjectPlatform.Name = "txtBoxProjectPlatform";
            this.txtBoxProjectPlatform.Size = new System.Drawing.Size(126, 20);
            this.txtBoxProjectPlatform.TabIndex = 33;
            // 
            // txtBoxProjectName
            // 
            this.txtBoxProjectName.Location = new System.Drawing.Point(12, 25);
            this.txtBoxProjectName.Name = "txtBoxProjectName";
            this.txtBoxProjectName.Size = new System.Drawing.Size(126, 20);
            this.txtBoxProjectName.TabIndex = 32;
            // 
            // txtBoxProjectClient
            // 
            this.txtBoxProjectClient.Location = new System.Drawing.Point(265, 25);
            this.txtBoxProjectClient.Name = "txtBoxProjectClient";
            this.txtBoxProjectClient.Size = new System.Drawing.Size(126, 20);
            this.txtBoxProjectClient.TabIndex = 31;
            // 
            // txtBoxProjectDeadline
            // 
            this.txtBoxProjectDeadline.Location = new System.Drawing.Point(12, 118);
            this.txtBoxProjectDeadline.Name = "txtBoxProjectDeadline";
            this.txtBoxProjectDeadline.Size = new System.Drawing.Size(126, 20);
            this.txtBoxProjectDeadline.TabIndex = 30;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(278, 276);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(113, 44);
            this.btnAdd.TabIndex = 29;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // labelNumOfWebPages
            // 
            this.labelNumOfWebPages.AutoSize = true;
            this.labelNumOfWebPages.Location = new System.Drawing.Point(265, 196);
            this.labelNumOfWebPages.Name = "labelNumOfWebPages";
            this.labelNumOfWebPages.Size = new System.Drawing.Size(111, 13);
            this.labelNumOfWebPages.TabIndex = 41;
            this.labelNumOfWebPages.Text = "Number of web pages";
            // 
            // txtBoxNumOfPages
            // 
            this.txtBoxNumOfPages.Location = new System.Drawing.Point(265, 212);
            this.txtBoxNumOfPages.Name = "txtBoxNumOfPages";
            this.txtBoxNumOfPages.Size = new System.Drawing.Size(126, 20);
            this.txtBoxNumOfPages.TabIndex = 40;
            // 
            // AddWebsiteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 328);
            this.Controls.Add(this.labelNumOfWebPages);
            this.Controls.Add(this.txtBoxNumOfPages);
            this.Controls.Add(this.labelServerName);
            this.Controls.Add(this.labelProjectPlatform);
            this.Controls.Add(this.labelProjectDeadline);
            this.Controls.Add(this.labelProjectClient);
            this.Controls.Add(this.labelProejctName);
            this.Controls.Add(this.txtBoxServerName);
            this.Controls.Add(this.txtBoxProjectPlatform);
            this.Controls.Add(this.txtBoxProjectName);
            this.Controls.Add(this.txtBoxProjectClient);
            this.Controls.Add(this.txtBoxProjectDeadline);
            this.Controls.Add(this.btnAdd);
            this.Name = "AddWebsiteForm";
            this.Text = "AddWebsiteForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelServerName;
        private System.Windows.Forms.Label labelProjectPlatform;
        private System.Windows.Forms.Label labelProjectDeadline;
        private System.Windows.Forms.Label labelProjectClient;
        private System.Windows.Forms.Label labelProejctName;
        private System.Windows.Forms.TextBox txtBoxServerName;
        private System.Windows.Forms.TextBox txtBoxProjectPlatform;
        private System.Windows.Forms.TextBox txtBoxProjectName;
        private System.Windows.Forms.TextBox txtBoxProjectClient;
        private System.Windows.Forms.TextBox txtBoxProjectDeadline;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label labelNumOfWebPages;
        private System.Windows.Forms.TextBox txtBoxNumOfPages;
    }
}