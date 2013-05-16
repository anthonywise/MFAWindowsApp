using System;

using TradeStation.SystemTeam.Tools.WebAPI.WebAPIObjects;

namespace TradeStation.SystemTeam.Tools.WebAPI.MFAWindowsApp
{
	public class AccessTokenReceivedArgs : EventArgs
	{
		public AccessToken Token { get; private set; }

		public AccessTokenReceivedArgs(AccessToken token)
		{
			Token = token;
		}
	}

	public delegate void AccessTokenReceivedHandler(object sender, AccessTokenReceivedArgs args); 

}
