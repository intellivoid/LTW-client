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
			//int Width = 768, Height = 384;
			//Image i = new Bitmap(Width, Height);
			//var g = Graphics.FromImage(i);
			//g.DrawString("Hello World", new Font("Arial", 12), Brushes.Black, new PointF(0, 0));
			//g.DrawLine(Pens.Black, new PointF(0, 0), new PointF(100, 100));

			//int XStartPolygon = 10, YStartPolygon = 10;
            //var WidthOfPolygon = 8 * (Width / 10);
            //var HeightOfPolygon = 8 * (Height / 10);
            //var LeanOfPolygon = 36;
			//g.SmoothingMode = SmoothingMode.HighQuality;
            //g.FillPolygon(new SolidBrush(Color.FromArgb(80, Color.Black)), new Point[]
            //{
            //    new Point(XStartPolygon, YStartPolygon),
            //    new Point(XStartPolygon + LeanOfPolygon, YStartPolygon + HeightOfPolygon),
            //    new Point(XStartPolygon + LeanOfPolygon + WidthOfPolygon, YStartPolygon + HeightOfPolygon),
            //    new Point(XStartPolygon + WidthOfPolygon, YStartPolygon)
            //});
			//i.Save("test.png");

			AppLogger.Enabled = true;
			var game = new GameClient();
			game.Start();
		}
	}
}