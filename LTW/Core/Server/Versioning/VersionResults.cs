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

using System.Text.Json.Serialization;

namespace LTW.Core.Server.Versioning
{
	public sealed class VersionResults
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

		[JsonPropertyName("is_acceptable")]
		public bool IsAcceptable { get; set; }
		
		[JsonPropertyName("data_download_link")]
		public string DataDownloadLink { get; set; }

		[JsonPropertyName("app_download_link")]
		public string AppDownloadLink { get; set; }


		[JsonPropertyName("server_time")]
		public string ServerTime { get; set; }
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
			// some members here
		#endregion
		//-------------------------------------------------
		#region Destructor's Region
			// some members here
		#endregion
		//-------------------------------------------------
	}
}