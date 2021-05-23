namespace AssignmentProject
{
    partial class DisplayForm
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
            this.btnListGames = new System.Windows.Forms.Button();
            this.btnListWebsites = new System.Windows.Forms.Button();
            this.btnListApplications = new System.Windows.Forms.Button();
            this.btnListAll = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBoxOutput
            // 
            this.txtBoxOutput.Location = new System.Drawing.Point(12, 91);
            this.txtBoxOutput.Multiline = true;
            this.txtBoxOutput.Name = "txtBoxOutput";
            this.txtBoxOutput.Size = new System.Drawing.Size(412, 224);
            this.txtBoxOutput.TabIndex = 2;
            // 
            // btnListGames
            // 
            this.btnListGames.Location = new System.Drawing.Point(12, 12);
            this.btnListGames.Name = "btnListGames";
            this.btnListGames.Size = new System.Drawing.Size(131, 48);
            this.btnListGames.TabIndex = 3;
            this.btnListGames.Text = "List games";
            this.btnListGames.UseVisualStyleBackColor = true;
            this.btnListGames.Click += new System.EventHandler(this.btnListGames_Click);
            // 
            // btnListWebsites
            // 
            this.btnListWebsites.Location = new System.Drawing.Point(201, 12);
            this.btnListWebsites.Name = "btnListWebsites";
            this.btnListWebsites.Size = new System.Drawing.Size(131, 48);
            this.btnListWebsites.TabIndex = 4;
            this.btnListWebsites.Text = "List websites";
            this.btnListWebsites.UseVisualStyleBackColor = true;
            this.btnListWebsites.Click += new System.EventHandler(this.btnListWebsites_Click);
            // 
            // btnListApplications
            // 
            this.btnListApplications.Location = new System.Drawing.Point(389, 12);
            this.btnListApplications.Name = "btnListApplications";
            this.btnListApplications.Size = new System.Drawing.Size(131, 48);
            this.btnListApplications.TabIndex = 5;
            this.btnListApplications.Text = "List applications";
            this.btnListApplications.UseVisualStyleBackColor = true;
            this.btnListApplications.Click += new System.EventHandler(this.btnListApplications_Click);
            // 
            // btnListAll
            // 
            this.btnListAll.Location = new System.Drawing.Point(570, 12);
            this.btnListAll.Name = "btnListAll";
            this.btnListAll.Size = new System.Drawing.Size(121, 48);
            this.btnListAll.TabIndex = 6;
            this.btnListAll.Text = "List all";
            this.btnListAll.UseVisualStyleBackColor = true;
            this.btnListAll.Click += new System.EventHandler(this.btnListAll_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(430, 281);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 34);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(616, 281);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 34);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // DisplayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 327);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnListAll);
            this.Controls.Add(this.btnListApplications);
            this.Controls.Add(this.btnListWebsites);
            this.Controls.Add(this.btnListGames);
            this.Controls.Add(this.txtBoxOutput);
            this.Name = "DisplayForm";
            this.Text = "DisplayForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxOutput;
        private System.Windows.Forms.Button btnListGames;
        private System.Windows.Forms.Button btnListWebsites;
        private System.Windows.Forms.Button btnListApplications;
        private System.Windows.Forms.Button btnListAll;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
    }
}