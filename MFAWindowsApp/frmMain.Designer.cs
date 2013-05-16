namespace TradeStation.SystemTeam.Tools.WebAPI.MFAWindowsApp
{
	partial class frmMain
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
			this.btnLogin = new System.Windows.Forms.Button();
			this.btnClose = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.lblConnectedUser = new System.Windows.Forms.Label();
			this.lblStatus = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.lblFeedback = new System.Windows.Forms.Label();
			this.grpLogin = new System.Windows.Forms.GroupBox();
			this.grpForms = new System.Windows.Forms.GroupBox();
			this.btnAdHoc = new System.Windows.Forms.Button();
			this.btnQuoteSnapshot = new System.Windows.Forms.Button();
			this.menuStrip1.SuspendLayout();
			this.grpLogin.SuspendLayout();
			this.grpForms.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnLogin
			// 
			this.btnLogin.Location = new System.Drawing.Point(354, 48);
			this.btnLogin.Name = "btnLogin";
			this.btnLogin.Size = new System.Drawing.Size(75, 23);
			this.btnLogin.TabIndex = 0;
			this.btnLogin.Text = "Login";
			this.btnLogin.UseVisualStyleBackColor = true;
			this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
			// 
			// btnClose
			// 
			this.btnClose.Location = new System.Drawing.Point(366, 232);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(75, 23);
			this.btnClose.TabIndex = 1;
			this.btnClose.Text = "Close";
			this.btnClose.UseVisualStyleBackColor = true;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 29);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(37, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Status";
			// 
			// lblConnectedUser
			// 
			this.lblConnectedUser.AutoSize = true;
			this.lblConnectedUser.Location = new System.Drawing.Point(102, 53);
			this.lblConnectedUser.Name = "lblConnectedUser";
			this.lblConnectedUser.Size = new System.Drawing.Size(19, 13);
			this.lblConnectedUser.TabIndex = 3;
			this.lblConnectedUser.Text = "....";
			// 
			// lblStatus
			// 
			this.lblStatus.AutoSize = true;
			this.lblStatus.ForeColor = System.Drawing.Color.Red;
			this.lblStatus.Location = new System.Drawing.Point(102, 29);
			this.lblStatus.Name = "lblStatus";
			this.lblStatus.Size = new System.Drawing.Size(37, 13);
			this.lblStatus.TabIndex = 4;
			this.lblStatus.Text = "Offline";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(6, 53);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(84, 13);
			this.label4.TabIndex = 5;
			this.label4.Text = "Connected User";
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolsToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(468, 24);
			this.menuStrip1.TabIndex = 6;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// toolsToolStripMenuItem
			// 
			this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem});
			this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
			this.toolsToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
			this.toolsToolStripMenuItem.Text = "Tools";
			// 
			// optionsToolStripMenuItem
			// 
			this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
			this.optionsToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
			this.optionsToolStripMenuItem.Text = "Options";
			this.optionsToolStripMenuItem.Click += new System.EventHandler(this.optionsToolStripMenuItem_Click);
			// 
			// lblFeedback
			// 
			this.lblFeedback.AutoSize = true;
			this.lblFeedback.Location = new System.Drawing.Point(12, 237);
			this.lblFeedback.Name = "lblFeedback";
			this.lblFeedback.Size = new System.Drawing.Size(16, 13);
			this.lblFeedback.TabIndex = 7;
			this.lblFeedback.Text = "...";
			// 
			// grpLogin
			// 
			this.grpLogin.Controls.Add(this.label1);
			this.grpLogin.Controls.Add(this.lblConnectedUser);
			this.grpLogin.Controls.Add(this.lblStatus);
			this.grpLogin.Controls.Add(this.label4);
			this.grpLogin.Controls.Add(this.btnLogin);
			this.grpLogin.Location = new System.Drawing.Point(12, 27);
			this.grpLogin.Name = "grpLogin";
			this.grpLogin.Size = new System.Drawing.Size(444, 85);
			this.grpLogin.TabIndex = 8;
			this.grpLogin.TabStop = false;
			this.grpLogin.Text = "Connect To WebAPI";
			// 
			// grpForms
			// 
			this.grpForms.Controls.Add(this.btnQuoteSnapshot);
			this.grpForms.Controls.Add(this.btnAdHoc);
			this.grpForms.Location = new System.Drawing.Point(12, 118);
			this.grpForms.Name = "grpForms";
			this.grpForms.Size = new System.Drawing.Size(444, 100);
			this.grpForms.TabIndex = 0;
			this.grpForms.TabStop = false;
			this.grpForms.Text = "Forms";
			// 
			// btnAdHoc
			// 
			this.btnAdHoc.Location = new System.Drawing.Point(9, 19);
			this.btnAdHoc.Name = "btnAdHoc";
			this.btnAdHoc.Size = new System.Drawing.Size(130, 23);
			this.btnAdHoc.TabIndex = 0;
			this.btnAdHoc.Text = "Quotes and Symbols";
			this.btnAdHoc.UseVisualStyleBackColor = true;
			this.btnAdHoc.Click += new System.EventHandler(this.btnAdHoc_Click);
			// 
			// btnQuoteSnapshot
			// 
			this.btnQuoteSnapshot.Location = new System.Drawing.Point(9, 48);
			this.btnQuoteSnapshot.Name = "btnQuoteSnapshot";
			this.btnQuoteSnapshot.Size = new System.Drawing.Size(130, 23);
			this.btnQuoteSnapshot.TabIndex = 1;
			this.btnQuoteSnapshot.Text = "Quote Snapshots";
			this.btnQuoteSnapshot.UseVisualStyleBackColor = true;
			this.btnQuoteSnapshot.Click += new System.EventHandler(this.btnQuoteSnapshot_Click);
			// 
			// frmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(468, 262);
			this.Controls.Add(this.grpForms);
			this.Controls.Add(this.grpLogin);
			this.Controls.Add(this.lblFeedback);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "frmMain";
			this.Text = "WinForms WebAPI Client";
			this.Load += new System.EventHandler(this.frmMain_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.grpLogin.ResumeLayout(false);
			this.grpLogin.PerformLayout();
			this.grpForms.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnLogin;
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lblConnectedUser;
		private System.Windows.Forms.Label lblStatus;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
		private System.Windows.Forms.Label lblFeedback;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
		private System.Windows.Forms.GroupBox grpLogin;
		private System.Windows.Forms.GroupBox grpForms;
		private System.Windows.Forms.Button btnAdHoc;
		private System.Windows.Forms.Button btnQuoteSnapshot;
	}
}

