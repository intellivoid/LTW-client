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

using GUISharp.Screens;
using GUISharp.Controls.Elements;
using GUISharp.GUIObjects.WMath;
using Microsoft.Xna.Framework.Media;
using LTW.Client;
using LTW.Controls;

namespace LTW.Screens
{
	public sealed partial class MainMenuScreen : Screen
	{
		//-------------------------------------------------
		#region Constant's Region
		private const string FirstLabelNameInRes = "Label1";
		private const string StartItemNameInRes = "Item1";
		private const string SettingsItemNameInRes = "Item2";
		private const string ExitItemNameInRes = "Item3";
		private const string BackgroundFileNameInRes = "Aincrad";
		private const string StoryOfThePastFileNameInRes = "s_/s_290720212001";
		private const string ToTheGrandLineFileNameInRes = "s_/s_290720212002";
		#endregion
		//-------------------------------------------------
		#region static Properties Region
		#endregion
		//-------------------------------------------------
		#region Properties Region
		public bool Initialized { get; private set; }
		public FlatElement FirstFlatElement { get; private set; }
		public MenuItem StartItem { get; private set; }
		public MenuItem SettingsItem { get; private set; }
		public MenuItem ExitItem { get; private set; }
		public GameClient GameClient { get; }
		public ListW<Song> Songs { get; private set; }
		public int CurrentMusicIndex { get; private set; }
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
		public MainMenuScreen(GameClient client) : base(client)
		{
			GameClient = client;
		}
		#endregion
		//-------------------------------------------------
		#region Destructor's Region
			// some members here
		#endregion
		//-------------------------------------------------
	}
}