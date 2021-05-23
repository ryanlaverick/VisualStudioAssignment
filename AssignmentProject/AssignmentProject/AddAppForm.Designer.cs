namespace AssignmentProject
{
    partial class AddAppForm
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
            this.labelAppType = new System.Windows.Forms.Label();
            this.labelProjectPlatform = new System.Windows.Forms.Label();
            this.labelProjectDeadline = new System.Windows.Forms.Label();
            this.labelProjectClient = new System.Windows.Forms.Label();
            this.labelProejctName = new System.Windows.Forms.Label();
            this.txtBoxAppType = new System.Windows.Forms.TextBox();
            this.txtBoxProjectPlatform = new System.Windows.Forms.TextBox();
            this.txtBoxProjectName = new System.Windows.Forms.TextBox();
            this.txtBoxProjectClient = new System.Windows.Forms.TextBox();
            this.txtBoxProjectDeadline = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelAppType
            // 
            this.labelAppType.AutoSize = true;
            this.labelAppType.Location = new System.Drawing.Point(12, 209);
            this.labelAppType.Name = "labelAppType";
            this.labelAppType.Size = new System.Drawing.Size(49, 13);
            this.labelAppType.TabIndex = 28;
            this.labelAppType.Text = "App type";
            // 
            // labelProjectPlatform
            // 
            this.labelProjectPlatform.AutoSize = true;
            this.labelProjectPlatform.Location = new System.Drawing.Point(262, 115);
            this.labelProjectPlatform.Name = "labelProjectPlatform";
            this.labelProjectPlatform.Size = new System.Drawing.Size(80, 13);
            this.labelProjectPlatform.TabIndex = 27;
            this.labelProjectPlatform.Text = "Project platform";
            // 
            // labelProjectDeadline
            // 
            this.labelProjectDeadline.AutoSize = true;
            this.labelProjectDeadline.Location = new System.Drawing.Point(9, 115);
            this.labelProjectDeadline.Name = "labelProjectDeadline";
            this.labelProjectDeadline.Size = new System.Drawing.Size(83, 13);
            this.labelProjectDeadline.TabIndex = 26;
            this.labelProjectDeadline.Text = "Project deadline";
            // 
            // labelProjectClient
            // 
            this.labelProjectClient.AutoSize = true;
            this.labelProjectClient.Location = new System.Drawing.Point(262, 22);
            this.labelProjectClient.Name = "labelProjectClient";
            this.labelProjectClient.Size = new System.Drawing.Size(68, 13);
            this.labelProjectClient.TabIndex = 25;
            this.labelProjectClient.Text = "Project client";
            // 
            // labelProejctName
            // 
            this.labelProejctName.AutoSize = true;
            this.labelProejctName.Location = new System.Drawing.Point(12, 22);
            this.labelProejctName.Name = "labelProejctName";
            this.labelProejctName.Size = new System.Drawing.Size(69, 13);
            this.labelProejctName.TabIndex = 23;
            this.labelProejctName.Text = "Project name";
            // 
            // txtBoxAppType
            // 
            this.txtBoxAppType.Location = new System.Drawing.Point(12, 225);
            this.txtBoxAppType.Name = "txtBoxAppType";
            this.txtBoxAppType.Size = new System.Drawing.Size(126, 20);
            this.txtBoxAppType.TabIndex = 21;
            // 
            // txtBoxProjectPlatform
            // 
            this.txtBoxProjectPlatform.Location = new System.Drawing.Point(265, 131);
            this.txtBoxProjectPlatform.Name = "txtBoxProjectPlatform";
            this.txtBoxProjectPlatform.Size = new System.Drawing.Size(126, 20);
            this.txtBoxProjectPlatform.TabIndex = 20;
            // 
            // txtBoxProjectName
            // 
            this.txtBoxProjectName.Location = new System.Drawing.Point(12, 38);
            this.txtBoxProjectName.Name = "txtBoxProjectName";
            this.txtBoxProjectName.Size = new System.Drawing.Size(126, 20);
            this.txtBoxProjectName.TabIndex = 18;
            // 
            // txtBoxProjectClient
            // 
            this.txtBoxProjectClient.Location = new System.Drawing.Point(265, 38);
            this.txtBoxProjectClient.Name = "txtBoxProjectClient";
            this.txtBoxProjectClient.Size = new System.Drawing.Size(126, 20);
            this.txtBoxProjectClient.TabIndex = 17;
            // 
            // txtBoxProjectDeadline
            // 
            this.txtBoxProjectDeadline.Location = new System.Drawing.Point(12, 131);
            this.txtBoxProjectDeadline.Name = "txtBoxProjectDeadline";
            this.txtBoxProjectDeadline.Size = new System.Drawing.Size(126, 20);
            this.txtBoxProjectDeadline.TabIndex = 16;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(280, 212);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(113, 44);
            this.btnAdd.TabIndex = 15;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // AddAppForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 267);
            this.Controls.Add(this.labelAppType);
            this.Controls.Add(this.labelProjectPlatform);
            this.Controls.Add(this.labelProjectDeadline);
            this.Controls.Add(this.labelProjectClient);
            this.Controls.Add(this.labelProejctName);
            this.Controls.Add(this.txtBoxAppType);
            this.Controls.Add(this.txtBoxProjectPlatform);
            this.Controls.Add(this.txtBoxProjectName);
            this.Controls.Add(this.txtBoxProjectClient);
            this.Controls.Add(this.txtBoxProjectDeadline);
            this.Controls.Add(this.btnAdd);
            this.Name = "AddAppForm";
            this.Text = "AddAppForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelAppType;
        private System.Windows.Forms.Label labelProjectPlatform;
        private System.Windows.Forms.Label labelProjectDeadline;
        private System.Windows.Forms.Label labelProjectClient;
        private System.Windows.Forms.Label labelProejctName;
        private System.Windows.Forms.TextBox txtBoxAppType;
        private System.Windows.Forms.TextBox txtBoxProjectPlatform;
        private System.Windows.Forms.TextBox txtBoxProjectName;
        private System.Windows.Forms.TextBox txtBoxProjectClient;
        private System.Windows.Forms.TextBox txtBoxProjectDeadline;
        private System.Windows.Forms.Button btnAdd;
    }
}