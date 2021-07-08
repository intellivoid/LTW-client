using GUISharp.Logging;
using GUISharp.Screens;
using GUISharp.Controls.Elements;
using LTW.Client;

namespace LTW.Screens
{
	public sealed partial class FirstLoadingScreen : Screen
	{
		//-------------------------------------------------
		#region Constant's Region
		private const int MAX_BACK_ENTERY = 8;
		private const string FirstLabelNameInRes = "Label1";
		private const string EntryFileNameInRes = "BackEntry";
		#endregion
		//-------------------------------------------------
		#region static Properties Region
			// some members here
		#endregion
		//-------------------------------------------------
		#region Properties Region
		public bool Initialized { get; private set; }
		public FlatElement FirstFlatElement { get; private set;}
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
		public FirstLoadingScreen(GameClient client) : base(client)
		{
			
		}
		#endregion
		//-------------------------------------------------
		#region Destructor's Region
			// some members here
		#endregion
		//-------------------------------------------------
	}
}