using GUISharp.Client;
using GUISharp.Logging;

namespace LTW.Client
{
	public sealed partial class GameClient : GUIClient
	{
		//-------------------------------------------------
		#region Constant's Region
			// some members here
		#endregion
		//-------------------------------------------------
		#region static Properties Region
			// some members here
		#endregion
		//-------------------------------------------------
		#region Properties Region
			// some members here
		#endregion
		//-------------------------------------------------
		#region static field's Region
			// some members here
		#endregion
		//-------------------------------------------------
		#region field's Region
			// some members here
		#endregion
		//-------------------------------------------------
		#region static event field's Region
			// some members here
		#endregion
		//-------------------------------------------------
		#region event field's Region
			// some members here
		#endregion
		//-------------------------------------------------
		#region Constructor's Region
		public GameClient() : base(ClientSizeMode.FullScreen)
		{
			AppLogger.Log("step4");
			MakeSingleRunner();
			AppLogger.Log("step5");
		}
		#endregion
		//-------------------------------------------------
		#region Destructor's Region
			// some members here
		#endregion
		//-------------------------------------------------
	}
}