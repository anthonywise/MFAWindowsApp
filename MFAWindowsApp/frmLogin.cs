using System;
using System.Windows.Forms;

using TradeStation.SystemTeam.Tools.WebAPI.WebAPIObjects;

namespace TradeStation.SystemTeam.Tools.WebAPI.MFAWindowsApp
{
	public partial class frmLogin : Form
	{
		private Settings settings; 
		public event AccessTokenReceivedHandler AccessTokenReceived;

		protected void OnAccessTokenReceived(object sender, AccessTokenReceivedArgs args)
		{
			if (AccessTokenReceived != null) AccessTokenReceived(sender, args); 
		}

		public frmLogin(Settings settings)
		{
			InitializeComponent();
			this.settings = settings;
		}

		void MFABrowser_Navigated(object sender, WebBrowserNavigatedEventArgs e)
		{
			const string urlToken = "?code="; 
			string url = e.Url.ToString();
			if (url.ToLower().Contains(urlToken))
			{
				string tokenValue = url.Substring(url.IndexOf(urlToken) + urlToken.Length); 
				AccessToken token = new AccessToken();
				token.Token = tokenValue;
				OnAccessTokenReceived(this, new AccessTokenReceivedArgs(token)); 
				MFABrowser.Stop(); 
				Close(); 
			}
		}

		private void frmLogin_Load(object sender, EventArgs e)
		{
			MFABrowser.Navigated += MFABrowser_Navigated;
		
			string path = string.Format("{0}v2/authorize/?client_id={1}&response_type=code&redirect_uri={2}", settings.ApiUri, settings.ClientId, settings.RedirectUri); 
			MFABrowser.Navigate(path);
		}

	}
}
