using System;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using TradeStation.SystemTeam.Tools.WebAPI.WebAPIObjects;

namespace TradeStation.SystemTeam.Tools.WebAPI.MFAWindowsApp
{
	public partial class SettingsForm : Form
	{
		public SettingsForm()
		{
			InitializeComponent();
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			Settings settings = new Settings();
			// if settings.Load fails, there are no settings saved for this application. The user will still be able to set them from frmMain but until then they will be unable to access the API.
			if (!settings.Load())
			{
				if (MessageBox.Show("Close without valid settings?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) ==
					DialogResult.No) { return; }
			}
			Close();
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			Settings settings;
			if (IsValid(out settings))
			{
				settings.Save();
				ShowFeedback("Settings saved.");
				Application.DoEvents();
				Thread.Sleep(2000);
				Close();
			}
		}

		private bool IsValid(out Settings settings)
		{
			settings = new Settings();
			string testGuid;
			// client id
			if (string.IsNullOrEmpty(txtClientId.Text))
			{
				ShowFeedback("Missing Client Id");
				txtClientId.Focus();
				return false;
			}

			settings.ClientId = txtClientId.Text;


			// client secret
			if (string.IsNullOrEmpty(txtClientSecret.Text))
			{
				ShowFeedback("Missing Client Secret");
				txtClientId.Focus();
				return false;
			}

			settings.ClientSecret = txtClientSecret.Text;


			// redirect Uri
			if (string.IsNullOrEmpty(txtRedirect.Text))
			{
				ShowFeedback("Missing Redirect Uri");
				txtClientSecret.Focus();
				return false;
			}
			try
			{
				settings.RedirectUri = new Uri(txtRedirect.Text);
			}
			catch (UriFormatException ex)
			{
				ShowFeedback(ex.Message);
				txtRedirect.Focus();
				return false;
			}

			settings.Environment = (WebAPIEnvironment)Enum.Parse(typeof(WebAPIEnvironment), cboEnvironment.SelectedItem.ToString()); 

			return true;
		}

		private void ShowFeedback(string message)
		{
			lblFeedback.Text = message;
		}

		private void ClearFeedback()
		{
			ShowFeedback(string.Empty);
		}

		private void frmSettings_Load(object sender, EventArgs e)
		{
			cboEnvironment.DataSource = Enum.GetNames(typeof(WebAPIEnvironment));

			Settings settings = new Settings();
			if (settings.Load())
			{
				txtClientId.Text = settings.ClientId.ToString();
				txtClientSecret.Text = settings.ClientSecret.ToString();
				txtRedirect.Text = settings.RedirectUri.ToString();
				cboEnvironment.SelectedItem = cboEnvironment.Items.OfType<WebAPIEnvironment>().First(env => env == settings.Environment);
			}
			else
			{
				ShowFeedback("These settings must be saved before using the application.");
				cboEnvironment.SelectedIndex = 1; // default to staging
			}

			
			
			
		}

		private void txtClientId_TextChanged(object sender, EventArgs e)
		{
			ClearFeedback();
		}

		private void txtClientSecret_TextChanged(object sender, EventArgs e)
		{
			ClearFeedback();
		}

		private void txtRedirect_TextChanged(object sender, EventArgs e)
		{
			ClearFeedback();
		}
	}
}
