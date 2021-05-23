namespace AssignmentProject
{
    partial class AddGameForm
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtBoxProjectDeadline = new System.Windows.Forms.TextBox();
            this.txtBoxProjectClient = new System.Windows.Forms.TextBox();
            this.txtBoxProjectName = new System.Windows.Forms.TextBox();
            this.txtBoxProjectPlatform = new System.Windows.Forms.TextBox();
            this.txtBoxGameRating = new System.Windows.Forms.TextBox();
            this.txtBoxGameGenre = new System.Windows.Forms.TextBox();
            this.labelProejctName = new System.Windows.Forms.Label();
            this.labelProjectClient = new System.Windows.Forms.Label();
            this.labelProjectDeadline = new System.Windows.Forms.Label();
            this.labelProjectPlatform = new System.Windows.Forms.Label();
            this.labelGameRating = new System.Windows.Forms.Label();
            this.labelGameGenre = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(278, 334);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(113, 44);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtBoxProjectDeadline
            // 
            this.txtBoxProjectDeadline.Location = new System.Drawing.Point(15, 131);
            this.txtBoxProjectDeadline.Name = "txtBoxProjectDeadline";
            this.txtBoxProjectDeadline.Size = new System.Drawing.Size(126, 20);
            this.txtBoxProjectDeadline.TabIndex = 1;
            // 
            // txtBoxProjectClient
            // 
            this.txtBoxProjectClient.Location = new System.Drawing.Point(265, 36);
            this.txtBoxProjectClient.Name = "txtBoxProjectClient";
            this.txtBoxProjectClient.Size = new System.Drawing.Size(126, 20);
            this.txtBoxProjectClient.TabIndex = 2;
            // 
            // txtBoxProjectName
            // 
            this.txtBoxProjectName.Location = new System.Drawing.Point(12, 36);
            this.txtBoxProjectName.Name = "txtBoxProjectName";
            this.txtBoxProjectName.Size = new System.Drawing.Size(126, 20);
            this.txtBoxProjectName.TabIndex = 3;
            // 
            // txtBoxProjectPlatform
            // 
            this.txtBoxProjectPlatform.Location = new System.Drawing.Point(265, 131);
            this.txtBoxProjectPlatform.Name = "txtBoxProjectPlatform";
            this.txtBoxProjectPlatform.Size = new System.Drawing.Size(126, 20);
            this.txtBoxProjectPlatform.TabIndex = 5;
            // 
            // txtBoxGameRating
            // 
            this.txtBoxGameRating.Location = new System.Drawing.Point(15, 237);
            this.txtBoxGameRating.Name = "txtBoxGameRating";
            this.txtBoxGameRating.Size = new System.Drawing.Size(126, 20);
            this.txtBoxGameRating.TabIndex = 6;
            // 
            // txtBoxGameGenre
            // 
            this.txtBoxGameGenre.Location = new System.Drawing.Point(265, 237);
            this.txtBoxGameGenre.Name = "txtBoxGameGenre";
            this.txtBoxGameGenre.Size = new System.Drawing.Size(126, 20);
            this.txtBoxGameGenre.TabIndex = 7;
            // 
            // labelProejctName
            // 
            this.labelProejctName.AutoSize = true;
            this.labelProejctName.Location = new System.Drawing.Point(12, 20);
            this.labelProejctName.Name = "labelProejctName";
            this.labelProejctName.Size = new System.Drawing.Size(69, 13);
            this.labelProejctName.TabIndex = 8;
            this.labelProejctName.Text = "Project name";
            // 
            // labelProjectClient
            // 
            this.labelProjectClient.AutoSize = true;
            this.labelProjectClient.Location = new System.Drawing.Point(262, 20);
            this.labelProjectClient.Name = "labelProjectClient";
            this.labelProjectClient.Size = new System.Drawing.Size(68, 13);
            this.labelProjectClient.TabIndex = 10;
            this.labelProjectClient.Text = "Project client";
            // 
            // labelProjectDeadline
            // 
            this.labelProjectDeadline.AutoSize = true;
            this.labelProjectDeadline.Location = new System.Drawing.Point(12, 115);
            this.labelProjectDeadline.Name = "labelProjectDeadline";
            this.labelProjectDeadline.Size = new System.Drawing.Size(83, 13);
            this.labelProjectDeadline.TabIndex = 11;
            this.labelProjectDeadline.Text = "Project deadline";
            // 
            // labelProjectPlatform
            // 
            this.labelProjectPlatform.AutoSize = true;
            this.labelProjectPlatform.Location = new System.Drawing.Point(262, 115);
            this.labelProjectPlatform.Name = "labelProjectPlatform";
            this.labelProjectPlatform.Size = new System.Drawing.Size(80, 13);
            this.labelProjectPlatform.TabIndex = 12;
            this.labelProjectPlatform.Text = "Project platform";
            // 
            // labelGameRating
            // 
            this.labelGameRating.AutoSize = true;
            this.labelGameRating.Location = new System.Drawing.Point(15, 221);
            this.labelGameRating.Name = "labelGameRating";
            this.labelGameRating.Size = new System.Drawing.Size(64, 13);
            this.labelGameRating.TabIndex = 13;
            this.labelGameRating.Text = "Game rating";
            // 
            // labelGameGenre
            // 
            this.labelGameGenre.AutoSize = true;
            this.labelGameGenre.Location = new System.Drawing.Point(262, 221);
            this.labelGameGenre.Name = "labelGameGenre";
            this.labelGameGenre.Size = new System.Drawing.Size(65, 13);
            this.labelGameGenre.TabIndex = 14;
            this.labelGameGenre.Text = "Game genre";
            // 
            // AddGameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 390);
            this.Controls.Add(this.labelGameGenre);
            this.Controls.Add(this.labelGameRating);
            this.Controls.Add(this.labelProjectPlatform);
            this.Controls.Add(this.labelProjectDeadline);
            this.Controls.Add(this.labelProjectClient);
            this.Controls.Add(this.labelProejctName);
            this.Controls.Add(this.txtBoxGameGenre);
            this.Controls.Add(this.txtBoxGameRating);
            this.Controls.Add(this.txtBoxProjectPlatform);
            this.Controls.Add(this.txtBoxProjectName);
            this.Controls.Add(this.txtBoxProjectClient);
            this.Controls.Add(this.txtBoxProjectDeadline);
            this.Controls.Add(this.btnAdd);
            this.Name = "AddGameForm";
            this.Text = "AddGameForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtBoxProjectDeadline;
        private System.Windows.Forms.TextBox txtBoxProjectClient;
        private System.Windows.Forms.TextBox txtBoxProjectName;
        private System.Windows.Forms.TextBox txtBoxProjectPlatform;
        private System.Windows.Forms.TextBox txtBoxGameRating;
        private System.Windows.Forms.TextBox txtBoxGameGenre;
        private System.Windows.Forms.Label labelProejctName;
        private System.Windows.Forms.Label labelProjectClient;
        private System.Windows.Forms.Label labelProjectDeadline;
        private System.Windows.Forms.Label labelProjectPlatform;
        private System.Windows.Forms.Label labelGameRating;
        private System.Windows.Forms.Label labelGameGenre;
    }
}