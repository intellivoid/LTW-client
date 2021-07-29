using System;
using System.Text.Json;
using System.Text;
using System.Net;
using System.Net.Http;
using System.IO;
using GUISharp.Logging;
using LTW.Constants;
using LTW.Core.Server.Versioning;

namespace LTW.Core.Server
{
	public static class ThereIsServer
	{
		//-------------------------------------------------
		public struct Actions
		{
			public static ServerResponse<VersionResponse> CheckVersion()
			{
				var main = ServerSettings.Manager.GetMainServer();
				var url = main.Url + ServerSettings.GetVersionPath;
				var client = new HttpClient();
				var s = new HttpRequestMessage(HttpMethod.Get, url);
				s.Headers.Add(ServerSettings.UserAgentKey, ServerSettings.UserAgentValue);
				s.Headers.Add(ServerSettings.XSameDomainKey, ServerSettings.XSameDomainValue);
				s.Headers.Add(ServerSettings.LTWVersionKey, ThereIsConstants.AppSettings.AppVersion);
				s.Headers.Add(ServerSettings.LTWVersionHashKey, ThereIsConstants.AppSettings.VersionHash);
				try
				{
					var resp = client.Send(s);
					var sr = resp.Content.ReadAsStream();
					var reader = new StreamReader(sr, Encoding.UTF8);
					var str = reader.ReadToEnd();
					var ver = JsonSerializer.Deserialize(str, typeof(VersionResponse));
					if (ver is VersionResponse verR)
					{
						return new(verR);
					}
					return new(ErrorType.UnknownError);
				}
				catch (HttpRequestException)
				{
					return new(ErrorType.NoInternet);
				}
				catch (Exception e)
				{
					AppLogger.Log("ThereIsServer.CheckVersion: ", e);
					return new(ErrorType.ServerUnavailable);
				}
			}
		}
		//-------------------------------------------------
		public struct ServerSettings
		{
			//---------------------------------------------
			#region Constant's Region
			internal const string UserAgentKey = "User-Agent";
			internal const string UserAgentValue = "ltw-client";

			internal const string XSameDomainKey = "X-Same-Domain";
			internal const string XSameDomainValue = "1";

			internal const string LTWVersionKey = "ltw_version";
			internal const string LTWVersionHashKey = "ltw_version_hash";


			internal const string GetVersionPath = "get_version";
			#endregion
			//---------------------------------------------
			//---------------------------------------------
			//---------------------------------------------
			//---------------------------------------------
			internal static ServerManager Manager { get; } = new();
		}
		//-------------------------------------------------
		public struct GameObjects
		{

		}
		//-------------------------------------------------
	}
}