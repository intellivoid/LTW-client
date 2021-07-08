/*
 * This file is part of LTW Project (https://github.com/intellivoid/LTW-client).
 * Copyright (c) 2019-2021 WotoTeam.
 *
 * This library is free software: you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation, version 2.
 *
 * This library is distributed in the hope that it will be useful, but
 * WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the GNU
 * General Public License for more details.
 *
 * You should have received a copy of the GNU General Public License
 * along with this source code of library. 
 * If not, see <http://www.gnu.org/licenses/>.
 */

using GUISharp.Client;
using GUISharp.Logging;
using LTW.Constants;

namespace LTW.Client
{
	public sealed partial class GameClient : GUIClient
	{
		//-------------------------------------------------
		#region Constant's Region
		public const string GameData = "GameData";
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
			MakeSingleRunner();
			ThereIsConstants.Forming.GameClient = this;
		}
		#endregion
		//-------------------------------------------------
		#region Destructor's Region
			// some members here
		#endregion
		//-------------------------------------------------
	}
}