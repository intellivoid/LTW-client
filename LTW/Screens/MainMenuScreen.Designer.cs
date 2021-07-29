/*
 * This file is part of LTW Project (https://github.com/intellivoid/LTW-client).
 * Copyright (c) 2019-2021 WotoTeam.
 *
 * This game client is free software: you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation, version 2.
 *
 * This game client is distributed in the hope that it will be useful, but
 * WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the GNU
 * General Public License for more details.
 *
 * You should have received a copy of the GNU General Public License
 * along with this source code of game client. 
 * If not, see <http://www.gnu.org/licenses/>.
 */

using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using GUISharp.SandBox;
using GUISharp.Controls;
using GUISharp.GUIObjects.Texts;
using GUISharp.Controls.Elements;
using GUISharp.GUIObjects.Resources;
using LTW.Constants;
using LTW.Core.Server;
using LTW.SandBoxes.ErrorSandBoxes;
using static LTW.Constants.ThereIsConstants;

namespace LTW.Screens
{
	partial class MainMenuScreen
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
			this.MyRes = new WotoRes(typeof(MainMenuScreen));
			this.FirstFlatElement = new FlatElement(this, 
				ElementMovements.NoMovements);
			this.FirstFlatElement.SetLabelName(FirstLabelNameInRes);
			//LTW.SandBoxes.LoginProfileSandBox test = new();
			//LTW.SandBoxes.ErrorSandBoxes.ConnectionClosedSandBox test = new();
			//LTW.SandBoxes.ErrorSandBoxes.LogedOutDoneSandBox test = new();
			//LTW.SandBoxes.ErrorSandBoxes.LogOutWarningSandBox test = new();
			//LTW.SandBoxes.ErrorSandBoxes.NoInternetConnectionSandBox test = new();
			//LTW.SandBoxes.ErrorSandBoxes.ProfileLoadFailedSandBox test = new();
			//LTW.SandBoxes.ErrorSandBoxes.ProfileWrongSandBox test = new();
			//LTW.SandBoxes.ErrorSandBoxes.UserAlreadyExistSandBox test = new();
			int num;
			int nowH = DateTime.Now.ToLocalTime().Hour;
			if (nowH < 19 && nowH > 7)
			{
				num = 1;
			}
			else
			{
				num = 2;
			}
			this.ChangeBackgroundRes(BackgroundFileNameInRes + num);
			//---------------------------------------------
			//names:
			//status:
			//fontAndTextAligns:
			this.FirstFlatElement.ChangeFont(this.FontManager.GetSprite(GUISharp_Fonts.GUISharp_tt_regular, 26));
			this.FirstFlatElement.ChangeAlignmation(StringAlignmation.MiddleCenter);
			//priorities:
			this.FirstFlatElement.ChangePriority(ElementPriority.Low);
			//sizes:
			this.FirstFlatElement.ChangeSize(this.Client.PWidth / 6,
				this.Client.PHeight / 6);
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
			//test.Enable();
			this.FirstFlatElement.Enable();
			//texts:
			//this.FirstFlatElement.SetLabelText(ThereIsConstants.AppSettings.GlobalTiming.GetString(false));
			//images:
			//this.FirstFlatElement.ChangeImageContent();
			//applyAndShow:
			this.FirstFlatElement.Apply();
			this.FirstFlatElement.Show();
			//test.Apply();
			//test.Show();
			//events:
			//---------------------------------------------
			//addRanges:
			AppSettings.GlobalTiming.AddElement(this.FirstFlatElement);
			this.AddElements(this.FirstFlatElement);
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
		#if OLD_FIRST_LOADING_MODULE_ALGORITHM
		private void CheckForVersion()
		{
			var v = ThereIsServer.Actions.CheckVersion();

			if (v.IsFailed || v.Data == null || !v.Data.Success)
			{
				var n = NoInternetConnectionSandBox.PrepareNoInternetSandBox();
				this.AddElement(n);
				return;
			}
			

			if (v.Data.Results.IsAcceptable)
			{
				this.RemoveElements(true);
				this.OnDone();
			}
			//---------------------------------------------
			//news:
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
			//---------------------------------------------
		}
		#endif // OLD_FIRST_LOADING_MODULE_ALGORITHM
		#endregion
		//-------------------------------------------------
		#region Get Method's Region
		private void LoadBackground()
		{
			
		}
		#endregion
		//-------------------------------------------------
		#region Set Method's Region
			// some methods here
		#endregion
		//-------------------------------------------------
	}
}