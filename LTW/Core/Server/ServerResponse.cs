

namespace LTW.Core.Server
{
	public sealed class ServerResponse<T>
		where T: class, IServerable
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
		public bool Success { get; internal set; }
		public bool IsFailed
		{
			get
			{
				return Error != ErrorType.NoError;
			}
		}
		public T Data { get; }
		public ErrorType Error { get; } = ErrorType.NoError;
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
		public ServerResponse(ErrorType error)
		{
			Error = error;
		}
		public ServerResponse(T data)
		{
			Data = data;
			Success = true;
		}
		#endregion
		//-------------------------------------------------
		#region Destructor's Region
			// some members here
		#endregion
		//-------------------------------------------------
	}
}