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
			AppLogger.Log(Environment.OSVersion.Platform);
			AppLogger.Log("step1");
			var game = new GameClient();
			AppLogger.Log("step2");
			game.Start();
			AppLogger.Log("step3");
		}
	}
}