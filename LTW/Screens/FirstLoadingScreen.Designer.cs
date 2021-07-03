using System;
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
using LTW.SandBoxes;

namespace LTW.Screens
{
	partial class FirstLoadingScreen
	{
		//-------------------------------------------------
		#region Initialize Method's Region
		public override void InitializeComponents()
		{
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
			LTW.SandBoxes.LoginProfileSandBox test = new();
			//GUISharp.SandBox.ErrorSandBoxes.ConnectionClosedSandBox test = new();
			var num = DateTime.Now.Second % MAX_BACK_ENTERY;
			this.ChangeBackgroundRes(EntryFileNameInRes + num);
			//---------------------------------------------
			//names:
			//status:
			//fontAndTextAligns:
			this.FirstFlatElement.ChangeFont(this.FontManager.GetSprite(GUISharp_Fonts.GUISharp_tt_regular, 26));
			this.FirstFlatElement.ChangeAlignmation(StringAlignmation.MiddleCenter);
			//priorities:
			this.FirstFlatElement.ChangePriority(ElementPriority.Low);
			//sizes:
			this.FirstFlatElement.ChangeSize(this.Client.Width / 7,
				this.Client.Height / 7);
			//ownering:
			//locations:
			this.FirstFlatElement.ChangeLocation((Client.Width - FirstFlatElement.Width) -
				(2 * SandBoxBase.from_the_edge),
				(Client.Height - FirstFlatElement.Height) -
				(2 * SandBoxBase.from_the_edge));
			//movements:
			//colors:
			this.FirstFlatElement.ChangeForeColor(Color.DarkSeaGreen);
			//enableds:
			test.Enable();
			this.FirstFlatElement.Enable();
			//texts:
			this.FirstFlatElement.SetLabelText();
			//images:
			this.FirstFlatElement.ChangeImage();
			//applyAndShow:
			this.FirstFlatElement.Apply();
			this.FirstFlatElement.Show();
			test.Apply();
			test.Show();
			//events:
			//---------------------------------------------
			//addRanges:
			this.AddElements(this.FirstFlatElement, test);
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