using System;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using TradeStation.SystemTeam.Tools.WebAPI.WebAPIClient.V2;
using TradeStation.SystemTeam.Tools.WebAPI.WebAPIObjects;

namespace TradeStation.SystemTeam.Tools.WebAPI.MFAWindowsApp
{
	public partial class frmMain : Form
	{
		private Settings settings;
		private AccessToken token;

		public frmMain()
		{
			InitializeComponent();			
		}

		#region eventHandlers

		private void btnAdHoc_Click(object sender, EventArgs e)
		{
			new AdHocForm(token, settings.ApiUri).ShowDialog();
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			Close(); 
		}

		private void btnQuoteSnapshot_Click(object sender, EventArgs e)
		{
			new QuoteSnapshotForm(token, settings.ApiUri).ShowDialog();
		}

		private void btnLogin_Click(object sender, EventArgs e)
		{
			Debug.Assert(settings.ApiUri != null, "Unable to retreive ApiUri");
			frmLogin f = new frmLogin(settings);
			f.AccessTokenReceived += f_AccessTokenReceived;
			f.ShowDialog();
		}

		void f_AccessTokenReceived(object sender, AccessTokenReceivedArgs args)
		{
			string authToken = args.Token.Token;

			token = Authorization.GetAccessToken(settings.ApiUri, authToken, settings.ClientId, settings.ClientSecret, settings.RedirectUri);
			lblConnectedUser.Text = token.UserId;
			lblStatus.Text = "Connected";
			lblStatus.ForeColor = Color.Green;
			EnableFormButtons(true);
		}

		private void frmMain_Load(object sender, EventArgs e)
		{
			ClearFeedback();
			EnableFormButtons(false);
			btnLogin.Enabled = false;
			settings = new Settings();
			if (!settings.Load())
			{
				SetSettings();
			}
			else
			{
				btnLogin.Enabled = true;
			}

		}

		private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			SetSettings();
		}



		#endregion eventHandlers

		#region methods
		
		private void ShowFeedback(string message)
		{
			lblFeedback.Text = message;
		}

		private void ClearFeedback()
		{
			ShowFeedback(string.Empty);
		}

		private void SetSettings()
		{
			new SettingsForm().ShowDialog();
			if (!settings.Load())
			{
				ShowFeedback("Settings have not been set. Go to Tools -> Options to save application settings.");
			}
			else
			{
				btnLogin.Enabled = true;
			}
		}

		private void EnableFormButtons(bool enabled)
		{
			foreach (Control c in grpForms.Controls)
			{
				//if (c is Button)
				//{
					c.Enabled = enabled;
				//}
			}
		}
		
		#endregion methods

		

		
	}
}
