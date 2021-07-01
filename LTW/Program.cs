using System;
using LTW.Client;

namespace LTW
{
	public static class Program
	{
		
		[STAThread]
		private static void Main()
		{
			var game = new GameClient();
			game.Start();
		}
	}
}