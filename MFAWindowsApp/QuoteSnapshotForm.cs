using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using TradeStation.SystemTeam.Tools.WebAPI.WebAPIClient;
using TradeStation.SystemTeam.Tools.WebAPI.WebAPIClient.V2;
using TradeStation.SystemTeam.Tools.WebAPI.WebAPIObjects;

namespace TradeStation.SystemTeam.Tools.WebAPI.MFAWindowsApp
{
	public partial class QuoteSnapshotForm : Form
	{
		private QuoteListener _listener;
		private Client _client; 
		private List<Quote> _quotes = new List<Quote>(255);

		public QuoteSnapshotForm(AccessToken token, Uri apiRoot)
		{
			InitializeComponent();
			_client = new Client(token, apiRoot);
		}

		#region eventHandlers

		private void btnClose_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void btnStart_Click(object sender, EventArgs e)
		{
			GetSnapshot(); 
		}

		private void btnStop_Click(object sender, EventArgs e)
		{
			ShowFeedback("Stopping Listener.");
			_listener.Stop();
			ShowFeedback("Listener Stopped.");
		}

		private void dgvSymbols_CellValueChanged(object sender, DataGridViewCellEventArgs e)
		{
			if (e.ColumnIndex == 0)
			{
				_quotes = new List<Quote>(255);
				for (int row = 0; row < dgvSymbols.Rows.Count; row++)
				{
					if (dgvSymbols[0, row].Value != null && !string.IsNullOrEmpty(dgvSymbols[0, row].Value.ToString()))
					{
						_quotes.Add(new Quote { Symbol = dgvSymbols[0, row].Value.ToString().ToUpper() });
					}
				}

				GetSnapshot();
			}
		}

		void listener_Timeout(object sender, HttpEventArgs args)
		{
			ShowFeedback("Timeout accessing stream. Listener is stopped.");
			_listener.Stop();
		}

		private void MultiQuotes_received(object sender, QuoteReceivedEventArgs args)
		{
			Quote quote = args.Quote;
			ShowFeedback(quote.Symbol);
			for (int rowIndex = 0; rowIndex < dgvSymbols.Rows.Count; rowIndex++)
			{
				// empty "Add" row will be null
				if (dgvSymbols[0, rowIndex].Value != null &&
					dgvSymbols[0, rowIndex].Value.ToString().ToUpper() == quote.Symbol.ToUpper())
				{
					dgvSymbols[1, rowIndex].Value = quote.Exchange;
					dgvSymbols[2, rowIndex].Value = quote.BidPriceDisplay;
					dgvSymbols[3, rowIndex].Value = quote.AskPriceDisplay;
					dgvSymbols[4, rowIndex].Value = quote.LastPriceDisplay;
					dgvSymbols[5, rowIndex].Value = quote.HighPriceDisplay;
					dgvSymbols[6, rowIndex].Value = quote.LowPriceDisplay;
					dgvSymbols[7, rowIndex].Value = quote.OpenPriceDisplay;
					dgvSymbols[8, rowIndex].Value = quote.ClosePriceDisplay;
					Application.DoEvents();
					break;
				}
			}
		}

		private void QuoteSnapshotForm_Load(object sender, EventArgs e)
		{
			ClearFeedback();
			_listener = _client.GetQuoteListener();
			_listener.QuoteReceived += MultiQuotes_received;
			_listener.Timeout += listener_Timeout;
			btnStart.Enabled = true;
			btnStop.Enabled = true;
			ConfigDataGridView();
		}

		#endregion eventHandlers

		#region methods

		private void ConfigDataGridView()
		{
			LoadTestSymbols();
			dgvSymbols.AutoGenerateColumns = false;
			dgvSymbols.AllowUserToAddRows = true;
			dgvSymbols.AllowUserToDeleteRows = true;
			dgvSymbols.ReadOnly = false;
			BindingList<Quote> quoteList = new BindingList<Quote>(_quotes) { AllowRemove = true, AllowNew = true };
			dgvSymbols.DataSource = quoteList;

			dgvSymbols.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Symbol", DataPropertyName = "Symbol", ReadOnly = false });
			dgvSymbols.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Exchange", DataPropertyName = "Exchange", ReadOnly = true });
			dgvSymbols.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Bid", DataPropertyName = "BidPriceDisplay", ReadOnly = true });
			dgvSymbols.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Ask", DataPropertyName = "AskPriceDisplay", ReadOnly = true });
			dgvSymbols.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Last", DataPropertyName = "LastPriceDisplay", ReadOnly = true });
			dgvSymbols.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "High", DataPropertyName = "HighPriceDisplay", ReadOnly = true });
			dgvSymbols.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Low", DataPropertyName = "LowPriceDisplay", ReadOnly = true });
			dgvSymbols.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Open", DataPropertyName = "OpenPriceDisplay", ReadOnly = true });
			dgvSymbols.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Close", DataPropertyName = "ClosePriceDisplay", ReadOnly = true });
		}

		private void GetSnapshot()
		{
			ShowFeedback("Connecting...");
			string quotesList = string.Join(",", _quotes.Select(s => s.Symbol));
			try
			{
				_listener.GetQuoteSnapshot(quotesList);
			}
			catch (Exception ex)
			{
				_listener.Stop();
				ShowFeedback("Exception requesting quote streams." + ex);
			}
		}

		private void LoadTestSymbols()
		{
			int level = 0;
			DirectoryInfo root = new DirectoryInfo(AppDomain.CurrentDomain.BaseDirectory);
			FileInfo symbolFile = null;
			while (root != null && level < 3 && symbolFile == null)
			{
				string path = Path.Combine(root.FullName, "SampleSymbols.txt");
				if (File.Exists(path))
				{
					symbolFile = new FileInfo(path);
				}
				else
				{
					root = root.Parent;
				}

				level++;
			}

			if (symbolFile != null)
			{
				using (StreamReader reader = new StreamReader(symbolFile.FullName))
				{
					string symbol;
					while ((symbol = reader.ReadLine()) != null)
					{
						_quotes.Add(new Quote { Symbol = symbol });
					}
					reader.Close();
				}
			}
		}

		#region feedback

		private void ShowFeedback(string message)
		{
			if (lblFeedback.InvokeRequired)
			{
				lblFeedback.Invoke((MethodInvoker)(() => ShowFeedback(message)));
			}
			else
				lblFeedback.Text = message;
		}

		private void ClearFeedback()
		{
			ShowFeedback(string.Empty);
		}

		#endregion feedback

		

		

		#endregion methods
	}
}
