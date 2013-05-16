namespace TradeStation.SystemTeam.Tools.WebAPI.MFAWindowsApp
{
	partial class frmLogin
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
			this.MFABrowser = new System.Windows.Forms.WebBrowser();
			this.SuspendLayout();
			// 
			// MFABrowser
			// 
			this.MFABrowser.Dock = System.Windows.Forms.DockStyle.Fill;
			this.MFABrowser.Location = new System.Drawing.Point(0, 0);
			this.MFABrowser.MinimumSize = new System.Drawing.Size(20, 20);
			this.MFABrowser.Name = "MFABrowser";
			this.MFABrowser.Size = new System.Drawing.Size(1196, 540);
			this.MFABrowser.TabIndex = 0;
			// 
			// frmLogin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1196, 540);
			this.Controls.Add(this.MFABrowser);
			this.Name = "frmLogin";
			this.Text = "Login to WebAPI";
			this.Load += new System.EventHandler(this.frmLogin_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.WebBrowser MFABrowser;
	}
}