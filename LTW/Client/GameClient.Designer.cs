using System.Threading.Tasks;
using System.Threading;
using GUISharp.Logging;
using static LTW.Constants.GameParams;
using LTW.Screens;

namespace LTW.Client
{
	partial class GameClient
	{

		//-------------------------------------------------
		#region Initialize Method's Region
		protected override void InitializeComponents()
		{
			//---------------------------------------------
			this.IsBorderless = true;
			this.CalculateRates();
			//---------------------------------------------
			//news:
			this.CurrentScreen = new FirstLoadingScreen(this);
			//---------------------------------------------
			//names:
			//status:
			//fontAndTextAligns:
			//priorities:
			//sizes:
			//ownering:
			//locations:
			//movements:
			//colors:
			//enableds:
			//texts:
			//images:
			//applyAndShow:
			//events:
			//---------------------------------------------
			//addRanges:
			//---------------------------------------------
			//finalBlow:
			Task.Run(() =>
			{
				Thread.Sleep(1000);
				this.CurrentScreen.InitializeComponents();
			});
			//---------------------------------------------
			
			
		}
		#endregion
		//-------------------------------------------------
		#region Graphical Method's Region
			// some methods here
		#endregion
		//-------------------------------------------------
		#region event Method's Region
			// some methods here
		#endregion
		//-------------------------------------------------
		#region overrided Method's Region
			// some methods here
		#endregion
		//-------------------------------------------------
		#region ordinary Method's Region
		private void CalculateRates()
		{
			var w = this.GetDevice().DisplayMode.Width;
			var h = this.GetDevice().DisplayMode.Height;
			Woto_WRate = (float)WOTO_STD_WIDTH / (float)w;
			Woto_HRate = (float)WOTO_STD_HEIGHT / (float)h;
		}
		#endregion
		//-------------------------------------------------
		#region Get Method's Region
			// some methods here
		#endregion
		//-------------------------------------------------
		#region Set Method's Region
			// some methods here
		#endregion
		//-------------------------------------------------

	}
}
