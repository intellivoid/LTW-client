using System;
using GUISharp.Logging;
using LTW.Client;

namespace LTW
{
	public static class Program
	{
		
		[STAThread]
		private static void Main()
		{
			
			AppLogger.Enabled = true;
			var game = new GameClient();
			game.Start();
		}
	}
}