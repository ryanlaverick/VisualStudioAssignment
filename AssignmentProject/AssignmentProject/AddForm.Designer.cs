namespace AssignmentProject
{
    partial class AddForm
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
            this.txtBoxOutput = new System.Windows.Forms.TextBox();
            this.btnAddGame = new System.Windows.Forms.Button();
            this.btnAddWebsite = new System.Windows.Forms.Button();
            this.btnAddApp = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBoxOutput
            // 
            this.txtBoxOutput.Location = new System.Drawing.Point(12, 322);
            this.txtBoxOutput.Multiline = true;
            this.txtBoxOutput.Name = "txtBoxOutput";
            this.txtBoxOutput.Size = new System.Drawing.Size(414, 119);
            this.txtBoxOutput.TabIndex = 2;
            // 
            // btnAddGame
            // 
            this.btnAddGame.Location = new System.Drawing.Point(12, 12);
            this.btnAddGame.Name = "btnAddGame";
            this.btnAddGame.Size = new System.Drawing.Size(414, 86);
            this.btnAddGame.TabIndex = 3;
            this.btnAddGame.Text = "Add game";
            this.btnAddGame.UseVisualStyleBackColor = true;
            this.btnAddGame.Click += new System.EventHandler(this.btnAddGame_Click);
            // 
            // btnAddWebsite
            // 
            this.btnAddWebsite.Location = new System.Drawing.Point(12, 220);
            this.btnAddWebsite.Name = "btnAddWebsite";
            this.btnAddWebsite.Size = new System.Drawing.Size(414, 86);
            this.btnAddWebsite.TabIndex = 4;
            this.btnAddWebsite.Text = "Add website";
            this.btnAddWebsite.UseVisualStyleBackColor = true;
            this.btnAddWebsite.Click += new System.EventHandler(this.btnAddWebsite_Click);
            // 
            // btnAddApp
            // 
            this.btnAddApp.Location = new System.Drawing.Point(12, 114);
            this.btnAddApp.Name = "btnAddApp";
            this.btnAddApp.Size = new System.Drawing.Size(414, 86);
            this.btnAddApp.TabIndex = 5;
            this.btnAddApp.Text = "Add app";
            this.btnAddApp.UseVisualStyleBackColor = true;
            this.btnAddApp.Click += new System.EventHandler(this.btnAddApp_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(333, 454);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(82, 25);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 490);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAddApp);
            this.Controls.Add(this.btnAddWebsite);
            this.Controls.Add(this.btnAddGame);
            this.Controls.Add(this.txtBoxOutput);
            this.Name = "AddForm";
            this.Text = "AddForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxOutput;
        private System.Windows.Forms.Button btnAddGame;
        private System.Windows.Forms.Button btnAddWebsite;
        private System.Windows.Forms.Button btnAddApp;
        private System.Windows.Forms.Button btnExit;
    }
}