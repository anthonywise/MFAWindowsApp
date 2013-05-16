using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TradeStation.SystemTeam.Tools.WebAPI.WebAPIClient;
using TradeStation.SystemTeam.Tools.WebAPI.WebAPIClient.V2;
using TradeStation.SystemTeam.Tools.WebAPI.WebAPIObjects; 

namespace TradeStation.SystemTeam.Tools.WebAPI.MFAWindowsApp
{
	public partial class AdHocForm : Form
	{
		private readonly Client _client;

		public AdHocForm(AccessToken token, Uri apiRoot)
		{
			InitializeComponent();
			_client = new Client(token, apiRoot);
			_client.SymbolSuggestCompleted += client_SymbolSuggestCompleted;
			_client.GetSymbolCompleted += client_GetSymbolCompleted;
			_client.GetQuotesCompleted += client_GetQuotesCompleted;
			_client.SymbolNotFound += client_SymbolNotFound;
		}

		#region eventHandlers

		private void AdHocForm_Load(object sender, EventArgs e)
		{
			ClearFeedback();
			lblSymbolSearchFeedback.Text = string.Empty;
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void btnGetQuote_Click(object sender, EventArgs e)
		{
			List<Quote> quotes = _client.GetQuotes(txtSymbols.Text);
			dgQuote.DataSource = quotes;
		}

		private void btnGetSymbol_Click(object sender, EventArgs e)
		{
			if (cboSymbol.Text.Length > 0)
			{
				_client.GetSymbolAsync(cboSymbol.Text);
			}
		}

		private void cboSymbol_TextUpdate(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(cboSymbol.Text))
				cboSymbol.Items.Clear();
			else if (cboSymbol.Text.Length > 1)
			{
				AssetType assType = AssetType.UK;
				if (optEQ.Checked)
					assType = AssetType.EQ;
				else if (optFX.Checked)
					assType = AssetType.FX;
				else if (optIdx.Checked)
					assType = AssetType.IX;

				List<Symbol> symbols = _client.SymbolSuggest(cboSymbol.Text, 20, CountryCode.US, assType);
				client_SymbolSuggestCompleted(this, new GetSymbolListCompletedArgs(symbols));

			}
		}

		void client_GetQuotesCompleted(object sender, GetQuoteListCompletedArgs args)
		{
			throw new NotImplementedException();
		}

		private void client_GetSymbolCompleted(object sender, GetSymbolCompletedArgs args)
		{
			if (dgSymbols.InvokeRequired)
			{
				dgSymbols.Invoke((MethodInvoker)(() => client_GetSymbolCompleted(sender, args)));
			}
			else
			{
				List<Symbol> symbols = new List<Symbol> { args.Symbol };
				dgSymbols.DataSource = symbols;
			}
		}

		void client_SymbolNotFound(object sender, SymbolNotFoundArgs args)
		{
			if (lblFeedback.InvokeRequired)
			{
				lblFeedback.Invoke((MethodInvoker)(() => client_SymbolNotFound(sender, args)));
			}
			else
			{
				lblSymbolSearchFeedback.Text = string.Format("Symbol not found: {0}.", args.Symbol);
			}

		}

		private void client_SymbolSuggestCompleted(object sender, GetSymbolListCompletedArgs args)
		{
			if (cboSymbol.InvokeRequired)
			{
				cboSymbol.Invoke((MethodInvoker)(() => client_SymbolSuggestCompleted(sender, args)));
			}
			else
			{
				cboSymbol.Items.Clear();
				foreach (Symbol s in args.Symbols)
				{
					cboSymbol.Items.Add(s.Name);
				}
				// next line puts the cursor at the end of the cbo text, prevents the cursor from being set back to the first position after the items are loaded if the user is typing
				cboSymbol.Select(cboSymbol.Text.Length, 0);
			}
		}
		
		#endregion eventHandlers

		

		


		

		

		#region methods

		private void ShowFeedback(string feedback)
		{
			if (lblFeedback.InvokeRequired)
			{
				lblFeedback.Invoke((MethodInvoker)(() => ShowFeedback(feedback)));
			}
			else
			{
				lblFeedback.Text = feedback;
			}
		}

		private void ClearFeedback()
		{
			ShowFeedback(string.Empty);
		}
		
		#endregion methods

		

		
	}
}
