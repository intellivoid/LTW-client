using GUISharp.Logging;
using LTW.Screens;

namespace LTW.Client
{
	partial class GameClient
	{

		//-------------------------------------------------
		#region Initialize Method's Region
		protected override void InitializeComponents()
		{
			AppLogger.Log("step6");
			//---------------------------------------------
			this.IsBorderless = true;
			//---------------------------------------------
			//news:
			this.CurrentScreen = new FirstLoadingScreen(this);
			AppLogger.Log("step7");
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
			this.CurrentScreen.InitializeComponents();
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
			// some methods here
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