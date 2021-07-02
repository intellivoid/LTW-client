
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using GUISharp.GUIObjects.Texts;
using GUISharp.Controls.Elements;
using GUISharp.GUIObjects.Resources;
using GUISharp.SandBox;
using GUISharp.Controls;
using GUISharp.Logging;
using GUISharp.WotoProvider.Enums;
using GUISharp.GUIObjects.Graphics;

namespace LTW.Screens
{
	partial class FirstLoadingScreen
	{
		//-------------------------------------------------
		#region Initialize Method's Region
		public override void InitializeComponents()
		{
			AppLogger.Log("step8");
			
			if (this.Initialized)
			{
				return;
			}
			else
			{
				this.Initialized = true;
			}
			//---------------------------------------------
			//news:
			this.MyRes = new WotoRes(typeof(FirstLoadingScreen));
			this.FirstFlatElement = new FlatElement(this, 
				ElementMovements.NoMovements);
			this.FirstFlatElement.SetLabelName(FirstLabelNameInRes);
			this.ChangeBackground(this.LoadBackground());
			AppLogger.Log("step9");

			//---------------------------------------------
			//names:
			//status:
			//fontAndTextAligns:
			this.FirstFlatElement.ChangeFont(this.FontManager.GetSprite(GUISharp_Fonts.GUISharp_tt_regular, 26));
			this.FirstFlatElement.ChangeAlignmation(StringAlignmation.MiddleCenter);
			//priorities:
			this.FirstFlatElement.ChangePriority(ElementPriority.Low);
			//sizes:
			this.FirstFlatElement.ChangeSize(this.Client.Width / 6,
				this.Client.Height / 6);
			//ownering:
			//locations:
			this.FirstFlatElement.ChangeLocation((Client.Width - FirstFlatElement.Width) -
				(2 * SandBoxBase.from_the_edge),
				(Client.Height - FirstFlatElement.Height) - SandBoxBase.from_the_edge);
			//movements:
			//colors:
			this.FirstFlatElement.ChangeForeColor(Color.DarkSeaGreen);
			//enableds:
			this.FirstFlatElement.Enable();
			//texts:
			this.FirstFlatElement.SetLabelText();
			//images:
			this.FirstFlatElement.ChangeImage();
			//applyAndShow:
			this.FirstFlatElement.Apply();
			this.FirstFlatElement.Show();
			//events:
			//---------------------------------------------
			//addRanges:
			AppLogger.Log("step10");
			this.AddElements(this.FirstFlatElement);
			AppLogger.Log("step11");
			//---------------------------------------------
			//finalBlow:
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
		public override void Dispose()
		{

		}
		#endregion
		//-------------------------------------------------
		#region ordinary Method's Region
			// some methods here
		#endregion
		//-------------------------------------------------
		#region Get Method's Region
		private Texture2D LoadBackground()
		{



			return null;
		}
		#endregion
		//-------------------------------------------------
		#region Set Method's Region
			// some methods here
		#endregion
		//-------------------------------------------------
	}
}