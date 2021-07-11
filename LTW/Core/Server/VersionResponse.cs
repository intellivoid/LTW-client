using System.Text.Json.Serialization;

namespace LTW.Core.Server
{
	public sealed class VersionResponse : IServerable
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