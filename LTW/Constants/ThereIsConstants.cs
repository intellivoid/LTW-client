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
using System.IO;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.IO.MemoryMappedFiles;
using System.Globalization;
using WotoProvider;
using WotoProvider.Interfaces;
using LTW.Client;
using GUISharp.Controls;
using GUISharp.Security;

namespace LTW.Constants
{
#pragma warning disable CA1401
	[ComVisible(false)]
	public static class ThereIsConstants
	{
		public struct Actions
		{
			
			internal static void ClearingPlayerProfile()
			{
				throw new NotImplementedException();
			}

			internal static StrongString OSの伊にファーエー所運()
			{
				throw new NotImplementedException();
			}

			internal static IDateProvider<DateTime, Trigger, StrongString> ToDateTime(StrongString strongString)
			{
				throw new NotImplementedException();
			}
		}
		public struct Path
		{
			//---------------------------------------------
			/// <summary>
			/// The Application name.
			/// </summary>
			public const string App_Name = "LTW";
			/// <summary>
			/// The Format Flies.
			/// </summary>
			public const string FilesEnd_Name = ".LTW";
			/// <summary>
			/// Use it in the <see cref="SerializableAttribute"/> Classes.
			/// like: <see cref="ProfileInfo"/>
			/// </summary>
			public const string NotSet = "notSet";
#if __LINUX__
			/// <summary>
			/// The Double Slash that you should use before the names in paths.
			/// if and only if the os is Unix.
			/// </summary>
			public const string DoubleSlash = "/";
#elif __WINDOWS__
			/// <summary>
			/// The Double Slash that you should use before the names in paths.
			/// if and only if the os is windows.
			/// </summary>
			public const string DoubleSlash = @"\";
#else
#error Unsupported Platform.
#endif
			public const string GameData = "GameData";
			//---------------------------------------------
			public static string Here
			{
				//get => Directory.GetCurrentDirectory();
				get => AppContext.BaseDirectory;
			}
			public static string Datas_Path
			{
				get => Here + GameData;
			}
			public static string AccountInfo_File_Path { get; internal set; }
			public static string ProfileInfo_File_Path { get; internal set; }
			public static string Profile_Folder_Path { get; internal set; }
			//---------------------------------------------
		}
		public struct ResourcesName
		{
			/// <summary>
			/// With Separate Character, please do NOT use it again.
			/// </summary>
			public const string End_Res_Name = Separate_Character + "Name";
			/// <summary>
			/// The name of FirstLable for Form1 in the Resources without _name;
			/// </summary>
			public const string FirstLabelNameInRes = "Label1";
			public const string Separate_Character = "_";
			//--------------------Labels----------------------------------

			//----------------------------------------------
			public const string Item1ForMainMenuNameInRes = "Item1";
			public const string Item2ForMainMenuNameInRes = "Item2";
			public const string Item3ForMainMenuNameInRes = "Item3";
			public const string Item4ForMainMenuNameInRes = "Item4";
			//-------------------Buttons----------------------------------
		}
		public struct Forming
		{
			public static GameClient GameClient
			{
				get
				{
					return AppSettings.GameClient;
				}
				set
				{
					AppSettings.GameClient = value;
				}
			}
		}
		public struct AppSettings
		{
			//--------------------------------------
			//-----------------
			/// <summary>
			/// E = English, J = Japanese
			/// </summary>
			public static char Language { get; set; } = 'E';
			/// <summary>
			/// Please Notice that this is not an Index,
			/// so it should start with 1,
			/// and also the maximum value of this int would be: 
			/// <see cref="MAXIMUM_PROFILE"/>. <code></code>
			/// Use it in ???
			/// </summary>
			public static int CurrentProfileNum { get; set; } = 1;
			
			public static CultureInfo CultureInfo { get; set; } = new CultureInfo("en-US");
			//-----------------
			//--------------------------------------
			public static bool IsShowingClosedSandBox { get; set; } = false;
			//public static NoInternetConnectionSandBox ConnectionClosedSandBox { get; set; }
			//--------------------------------------
			//-----------------
			public const string AppVersion = "2.1.1.5014";
			public const string VersionHash = 
				"f302bd7ffacbd295194f86620002b8250e8e9be0233a8055bcebc82c8612843ff9e0f09e42015d5e75581cc93d4c29a91388ed411641b543c8fb7b5a26a2a8b8";
			public const string AppVerCodeName = "5014Re";
			public const string CompanyName = "wotoTeam";
			public const string CompanyCopyRight = "© wotoTeam - 2021";
			public const string DateTimeFormat = "ddd, dd MMM yyyy HH:mm:ss 'GMT'";
			public const string TimeFormat = "HH:mm:ss";
			public const string TimeRequestURL = @"https://microsoft.com";
			public const string ConnectionURL = @"http://google.com/generate_204";
			public const string DateHeaderKey = "date";
			//-----------------
			public const int MAXIMUM_PROFILE = 64;
			//-----------------
			public const StringSplitOptions SplitOption = StringSplitOptions.RemoveEmptyEntries;
			//-------------------------------------
			/// <summary>
			/// Determine whether <see cref="GlobalTiming"/>, has been set with 
			/// interner: <see cref="TimeRequestURL"/>, or not.
			/// </summary>
			public static bool DateTimeSettedWithNet { get; set; } = false;
			/// <summary>
			/// The Time Worker.
			/// </summary>
			public static Trigger TimeWorker { get; set; } = new Trigger();
			/// <summary>
			/// Global Timing worker.
			/// it will add seconds to the 
			/// <see cref="GlobalTiming"/>
			/// </summary>
			public static Trigger GlobalTimingWorker { get; set; }
			public static MemoryMappedFile Memory { get; internal set; }
			/// <summary>
			/// Global Date and Time Parameter.
			/// </summary>
			public static IDateProvider<DateTime, Trigger, StrongString> GlobalTiming { get; set; }
			/// <summary>
			/// the default time out for database.
			/// </summary>
			public static TimeSpan DefaultDataBaseTimeOut { get; } = new TimeSpan(0, 0, 6);
			/// <summary>
			/// The Game Client of the game.
			/// this is after the main form.
			/// </summary>
			public static GameClient GameClient { get; set; }
			public static WotoCreation WotoCreation { get; set; }
			//--------------------------------------
			public static IDECoderProvider<StrongString, QString> DECoder { get; set; }
			//--------------------------------------
			/// <summary>
			/// The Spaces between two GameControls in the game.
			/// the unit is pixel.
			/// </summary>
			public const int Between_GameControls = 4;
			//--------------------------------------
		}
	}
#pragma warning restore CA1401
}
