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
using Microsoft.Xna.Framework.Media;
using GUISharp.SandBox;
using GUISharp.Controls;
using GUISharp.GUIObjects.Texts;
using GUISharp.Controls.Elements;
using GUISharp.GUIObjects.Resources;
using static LTW.Constants.ThereIsConstants;
using LTW.SandBoxes;

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
			this.FirstFlatElement = new(this, ElementMovements.NoMovements);
			this.StartItem = new(this);
			this.SettingsItem = new(this);
			this.ExitItem = new(this);
			this.StartItem = new(this);
			this.LoadBackground();
			this.LoadMusics();
			//---------------------------------------------
			//names:
			this.FirstFlatElement.SetLabelName(FirstLabelNameInRes);
			this.StartItem.SetLabelName(StartItemNameInRes);
			this.SettingsItem.SetLabelName(SettingsItemNameInRes);
			this.ExitItem.SetLabelName(ExitItemNameInRes);
			//status:
			//fontAndTextAligns:
			this.FirstFlatElement.ChangeFont(this.FontManager.GetSprite(GUISharp_Fonts.GUISharp_tt_regular, 26));
			this.StartItem.ChangeFont(this.FontManager.GetSprite(GUISharp_Fonts.old_story_bold_italic, 24));
			this.SettingsItem.ChangeFont(StartItem.Font);
			this.ExitItem.ChangeFont(StartItem.Font);
			this.FirstFlatElement.ChangeAlignmation(StringAlignmation.MiddleCenter);
			this.StartItem.ChangeAlignmation(StringAlignmation.MiddleCenter);
			this.SettingsItem.ChangeAlignmation(StringAlignmation.MiddleCenter);
			this.ExitItem.ChangeAlignmation(StringAlignmation.MiddleCenter);
			//priorities:
			this.FirstFlatElement.ChangePriority(ElementPriority.Low);
			this.StartItem.ChangePriority(ElementPriority.VeryHigh);
			this.SettingsItem.ChangePriority(ElementPriority.VeryHigh);
			this.ExitItem.ChangePriority(ElementPriority.VeryHigh);
			//sizes:
			this.FirstFlatElement.ChangeSize(this.Client.PWidth / 6,
				this.Client.PHeight / 6);
			this.StartItem.ChangeSize(this.Client.PWidth / 4,
				2 * (this.Client.PHeight / 17));
			this.SettingsItem.ChangeSize(this.StartItem.Rectangle.Size);
			this.ExitItem.ChangeSize(this.StartItem.Rectangle.Size);
			//ownering:
			//locations:
			this.FirstFlatElement.ChangeLocation((Client.Width - 
				FirstFlatElement.Width) -
				(2 * SandBoxBase.from_the_edge),
				(Client.Height - FirstFlatElement.Height) -
				(2 * SandBoxBase.from_the_edge));
			this.StartItem.ChangeLocation(this.Client.PWidth / 16,
				2 * (this.Client.PHeight / 19));
			this.SettingsItem.ChangeLocation(this.StartItem.RealX, 
				this.StartItem.RealY + this.StartItem.Height + 
				SandBoxBase.from_the_edge);
			this.ExitItem.ChangeLocation(this.SettingsItem.RealX, 
				this.SettingsItem.RealY + this.SettingsItem.Height + 
				SandBoxBase.from_the_edge);
			//movements:
			this.FirstFlatElement.ChangeMovements(ElementMovements.HorizontalMovements);
			//colors:
			this.FirstFlatElement.ChangeForeColor(Color.DarkSeaGreen);
			this.StartItem.ChangeForeColor(Color.WhiteSmoke);
			this.SettingsItem.ChangeForeColor(Color.WhiteSmoke);
			this.ExitItem.ChangeForeColor(Color.WhiteSmoke);
			//enableds:
			this.FirstFlatElement.Enable();
			this.StartItem.Enable();
			this.StartItem.EnableMouseEnterEffect();
			this.StartItem.Stable();
			this.SettingsItem.Enable();
			this.SettingsItem.EnableMouseEnterEffect();
			this.SettingsItem.Stable();
			this.ExitItem.Enable();
			this.ExitItem.EnableMouseEnterEffect();
			this.ExitItem.Stable();
			//texts:
			this.StartItem.SetLabelText();
			this.SettingsItem.SetLabelText();
			this.ExitItem.SetLabelText();
			//images:
			//this.FirstFlatElement.ChangeImageContent();
			//applyAndShow:
			this.FirstFlatElement.Apply();
			this.FirstFlatElement.Show();
			this.StartItem.Apply();
			this.StartItem.Show();
			this.SettingsItem.Apply();
			this.SettingsItem.Show();
			this.ExitItem.Apply();
			this.ExitItem.Show();
			//test.Apply();
			//test.Show();
			//events:
			this.StartItem.Click			-= this.StartItem_Click;
			this.ExitItem.Click				-= this.ExitItem_Click;
			MediaPlayer.MediaStateChanged	-= MediaPlayer_MediaStateChanged;
			this.StartItem.Click			+= this.StartItem_Click;
			this.ExitItem.Click				+= this.ExitItem_Click;
			MediaPlayer.MediaStateChanged	+= MediaPlayer_MediaStateChanged;
			//---------------------------------------------
			//addRanges:
			AppSettings.GlobalTiming.AddElement(this.FirstFlatElement);
			this.AddElements(this.FirstFlatElement, 
				this.StartItem,
				this.SettingsItem,
				this.ExitItem);
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
		private void MediaPlayer_MediaStateChanged(object sender, EventArgs e)
		{
			if (MediaPlayer.State == MediaState.Stopped && this.Songs != null)
			{
				if (this.CurrentMusicIndex == this.Songs.Length - 1)
				{
					this.CurrentMusicIndex = default;
				}
				else
				{
					this.CurrentMusicIndex++;
				}
				var s = this.Songs[this.CurrentMusicIndex];
				if (s == null || s.IsDisposed)
				{
					return;
				}
				MediaPlayer.Play(s);
			}
		}
		private void ExitItem_Click(object sender, EventArgs e)
		{
			this.Exit();
		}
		
		private void StartItem_Click(object sender, EventArgs e)
		{
			var s = new LoginProfileSandBox();
			s.Enable();
			s.Apply();
			s.Show();
			this.AddElement(s);
		}
		#endregion
		//-------------------------------------------------
		#region overrided Method's Region
		public override void Dispose()
		{
			foreach (var s in this.Songs)
			{
				s?.Dispose();
			}

		}
		public void DisposeSongs()
		{
			if (this.Songs == null)
			{
				return;
			}
			foreach (var s in this.Songs)
			{
				s?.Dispose();
			}
			this.Songs = null;
		}
		#endregion
		//-------------------------------------------------
		#region ordinary Method's Region
		private void LoadMusics()
		{
			this.Songs = new()
			{
				this.ContentManager.Load<Song>(StoryOfThePastFileNameInRes),
				this.ContentManager.Load<Song>(ToTheGrandLineFileNameInRes)
			};
			MediaPlayer.IsRepeating = false;
			MediaPlayer.Play(this.Songs[this.CurrentMusicIndex]);
		}
		private void LoadBackground()
		{
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
		}
		#endregion
		//-------------------------------------------------
		#region Get Method's Region
		#endregion
		//-------------------------------------------------
		#region Set Method's Region
			// some methods here
		#endregion
		//-------------------------------------------------
	}
}