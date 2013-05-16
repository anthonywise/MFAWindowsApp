using System;
using System.IO;
using System.Linq;

using Newtonsoft.Json;
using TradeStation.SystemTeam.Tools.WebAPI.WebAPIObjects;

namespace TradeStation.SystemTeam.Tools.WebAPI.MFAWindowsApp
{
	public sealed class Settings
	{
		private const string FileName = "settings.js";
		private string FilePath
		{
			get { return Path.Combine(AppDomain.CurrentDomain.BaseDirectory, FileName); }
		}

		public string ClientId { get; set; }
		public string ClientSecret { get; set; }
		public Uri RedirectUri { get; set; }
		public WebAPIEnvironment Environment { get; set; }
		/// <summary>
		/// Returns the location for the specified webapi environement. If the environment is not set, null is returned
		/// </summary>
		public Uri ApiUri {
			get
			{
				WebAPILocation location = WebAPILocation.WebAPIEnvironments.FirstOrDefault(e => e.Name == Environment);
				if (location != null) return location.Location;
				
				return null; 
			}
		}

		public bool Load()
		{
			if (File.Exists(FilePath))
			{
				string text; 
				using (StreamReader reader = new StreamReader(FilePath))
				{
					text = reader.ReadToEnd(); 
					reader.Close();
				}
				Settings settings = JsonConvert.DeserializeObject<Settings>(text);
				ClientId = settings.ClientId;
				ClientSecret = settings.ClientSecret;
				RedirectUri = settings.RedirectUri;
				Environment = settings.Environment;
				return true;
			}
			
			return false;
		}

		public void Save()
		{
			string text =
				string.Format(
					"{{\"ClientId\":\"{0}\", \"ClientSecret\":\"{1}\", \"RedirectUri\":\"{2}\", \"Environment\":\"{3}\"}}", ClientId,
					ClientSecret, RedirectUri, Environment);
			using (StreamWriter writer = new StreamWriter(FilePath))
			{
				writer.WriteLine(text);
				writer.Close();
			}
		}
	}
}
