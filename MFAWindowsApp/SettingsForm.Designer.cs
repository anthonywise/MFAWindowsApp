namespace TradeStation.SystemTeam.Tools.WebAPI.MFAWindowsApp
{
	partial class SettingsForm
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.txtClientSecret = new System.Windows.Forms.TextBox();
			this.txtRedirect = new System.Windows.Forms.TextBox();
			this.txtClientId = new System.Windows.Forms.TextBox();
			this.cboEnvironment = new System.Windows.Forms.ComboBox();
			this.btnSave = new System.Windows.Forms.Button();
			this.btnClose = new System.Windows.Forms.Button();
			this.lblFeedback = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(19, 95);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(63, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Redirect Uri";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(16, 66);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(66, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Environment";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 35);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(67, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "Client Secret";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(33, 9);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(45, 13);
			this.label4.TabIndex = 3;
			this.label4.Text = "Client Id";
			// 
			// txtClientSecret
			// 
			this.txtClientSecret.Location = new System.Drawing.Point(92, 32);
			this.txtClientSecret.Name = "txtClientSecret";
			this.txtClientSecret.Size = new System.Drawing.Size(296, 20);
			this.txtClientSecret.TabIndex = 1;
			this.txtClientSecret.TextChanged += new System.EventHandler(this.txtClientSecret_TextChanged);
			// 
			// txtRedirect
			// 
			this.txtRedirect.Location = new System.Drawing.Point(92, 88);
			this.txtRedirect.Name = "txtRedirect";
			this.txtRedirect.Size = new System.Drawing.Size(296, 20);
			this.txtRedirect.TabIndex = 3;
			this.txtRedirect.TextChanged += new System.EventHandler(this.txtRedirect_TextChanged);
			// 
			// txtClientId
			// 
			this.txtClientId.Location = new System.Drawing.Point(92, 6);
			this.txtClientId.Name = "txtClientId";
			this.txtClientId.Size = new System.Drawing.Size(296, 20);
			this.txtClientId.TabIndex = 0;
			this.txtClientId.TextChanged += new System.EventHandler(this.txtClientId_TextChanged);
			// 
			// cboEnvironment
			// 
			this.cboEnvironment.FormattingEnabled = true;
			this.cboEnvironment.Location = new System.Drawing.Point(92, 58);
			this.cboEnvironment.Name = "cboEnvironment";
			this.cboEnvironment.Size = new System.Drawing.Size(121, 21);
			this.cboEnvironment.TabIndex = 2;
			// 
			// btnSave
			// 
			this.btnSave.Location = new System.Drawing.Point(92, 124);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(75, 23);
			this.btnSave.TabIndex = 4;
			this.btnSave.Text = "Save";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// btnClose
			// 
			this.btnClose.Location = new System.Drawing.Point(326, 157);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(75, 23);
			this.btnClose.TabIndex = 5;
			this.btnClose.Text = "Close";
			this.btnClose.UseVisualStyleBackColor = true;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// lblFeedback
			// 
			this.lblFeedback.AutoSize = true;
			this.lblFeedback.ForeColor = System.Drawing.Color.Red;
			this.lblFeedback.Location = new System.Drawing.Point(12, 170);
			this.lblFeedback.Name = "lblFeedback";
			this.lblFeedback.Size = new System.Drawing.Size(16, 13);
			this.lblFeedback.TabIndex = 10;
			this.lblFeedback.Text = "...";
			// 
			// SettingsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(413, 192);
			this.Controls.Add(this.lblFeedback);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.cboEnvironment);
			this.Controls.Add(this.txtClientId);
			this.Controls.Add(this.txtRedirect);
			this.Controls.Add(this.txtClientSecret);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "SettingsForm";
			this.Text = "Application Settings";
			this.Load += new System.EventHandler(this.frmSettings_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtClientSecret;
		private System.Windows.Forms.TextBox txtRedirect;
		private System.Windows.Forms.TextBox txtClientId;
		private System.Windows.Forms.ComboBox cboEnvironment;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.Label lblFeedback;
	}
}