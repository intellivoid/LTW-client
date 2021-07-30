// Copyright (C) ALiwoto 2019 - 2020
// This file is subject to the terms and conditions defined in
// file 'LICENSE', which is part of the source code.

using System;
using System.Globalization;
using GUISharp.WotoProvider.EventHandlers;
using GUISharp.Security;
using GUISharp.Controls;
using GUISharp.GUIObjects.WMath;
using GUISharp.Controls.Elements;
using WotoProvider.Interfaces;
using LTW.Constants;

namespace LTW.Core
{
	public class DateProvider : ISecurity, IDateProvider<DateTime, Trigger, StrongString>, IDataProvider<StrongString>
	{
		//-------------------------------------------------
		#region Constant's Region
		public const string ToStringValue	   = "-- Date Provider -- || " +
			"wotoTeam Cor. (C)";
		public const string SecureToString	  = ToStringValue +
			"++ Licensed BY Ali.w ++";
		public const string TriggerName		 = "-- Trigger for Date Provider --";
		public const int DefaultTickInterval	= 1000;
		public const string UnlimitedTimeString = "ＵＢＷ";
		public const string UnlimitedShowing	= "--:--:--";
		#endregion
		//-------------------------------------------------
		#region fields Region
		private DateTime _dateTime;
		#endregion
		//-------------------------------------------------
		#region Properties Region
		public bool IsTicking { get; private set; }
		public bool IsDisposed { get; private set; }
		public Trigger TheTrigger { get; private set; }
		public int TickingInterval { get; private set; }
		public bool IsUnlimited { get; private set; }
		public ListW<GraphicElement> Elements { get; private set; }
		#endregion
		//-------------------------------------------------
		#region Constructor's Region
		/// <summary>
		/// Initializes a new instance of the System.DateTime structure to the specified
		///	year, month, and day.  
		/// </summary>
		/// <param name="year">
		/// The year (1 through 9999).
		/// </param>
		/// <param name="month">
		/// The month (1 through 12).
		/// </param>
		/// <param name="day">
		/// The day (1 through the number of days in month).
		/// </param>
		public DateProvider(int year, int month, int day)
		{
			_dateTime = new DateTime(year, month, day);
		}
		/// <summary>
		/// Initializes a new instance of the System.DateTime structure to the specified
		///	year, month, day, hour, minute, and second.
		/// </summary>
		/// <param name="year">
		/// The year (1 through 9999).
		/// </param>
		/// <param name="month">
		/// The month (1 through 12).
		/// </param>
		/// <param name="day">
		/// The day (1 through the number of days in month).
		/// </param>
		/// <param name="hour">
		/// The hours (0 through 23).
		/// </param>
		/// <param name="minute">
		/// The minutes (0 through 59).
		/// </param>
		/// <param name="second">
		/// The seconds (0 through 59).
		/// </param>
		public DateProvider(int year, int month, int day, int hour, int minute, int second)
		{
			_dateTime = new DateTime(year, month, day, hour, minute, second);
		}
		private DateProvider(DateTime dateTimeValue)
		{
			_dateTime = dateTimeValue;
		}
		private DateProvider()
		{
			IsUnlimited = true;
			_dateTime = DateTime.MinValue;
		}
		#endregion
		//-------------------------------------------------
		#region Ordinary Method's Region
		/// <summary>
		/// Start the ticking.
		/// the ticking unit by default is 1 second.
		/// </summary>
		public void StartTicking()
		{
			StartTicking(DefaultTickInterval);
		}
		public void StartTicking(int milliseconds)
		{
			if (IsTicking)
			{
				return;
			}
			IsTicking = true;
			if (TheTrigger is null)
			{
				TheTrigger = new Trigger()
				{
					Running_Worker = false,
				};
			}
			TheTrigger.Interval = TickingInterval =
				milliseconds;
			TheTrigger.Name = TriggerName;
			TheTrigger.Tag = this;
			TheTrigger.Tick -= TheTriggerWorker;
			TheTrigger.Tick += TheTriggerWorker;
			TheTrigger.Start();
		}
		public void StopTicking()
		{
			if (TheTrigger is null)
			{
				if (IsTicking)
				{
					IsTicking = false;
				}
				return;
			}
			if (IsTicking)
			{
				TheTrigger.Stop();
				IsTicking = false;
			}
			else
			{
				if (!(TheTrigger is null))
				{
					if (TheTrigger.Enabled)
					{
						TheTrigger.Stop();
					}
				}
			}
		}
		public void ChangeTicking(int miliseconds)
		{
			if (IsTicking)
			{
				StopTicking();
				StartTicking(miliseconds);
			}
			else
			{
				TickingInterval = miliseconds;
			}
		}
		public void Dispose()
		{
			if (IsDisposed)
			{
				return;
			}
			StopTicking();
			TheTrigger.Dispose();
		}
		public bool IsEqual(IDateProvider<DateTime, Trigger, StrongString> provider)
		{
			if (IsUnlimited == provider.IsUnlimited)
			{
				return true;
			}
			return _dateTime == provider.GetDateTime();
		}
		public bool IsAfterMe(IDateProvider<DateTime, Trigger, StrongString> provider)
		{
			if (provider.IsUnlimited)
			{
				return false;
			}
			return _dateTime > provider.GetDateTime();
		}
		public bool IsBeforeMe(IDateProvider<DateTime, Trigger, StrongString> provider)
		{
			if (provider.IsUnlimited)
			{
				return false;
			}
			return _dateTime < provider.GetDateTime();
		}
		public void UpdateElements()
		{
			if (this.Elements == null || this.Elements.Length == default)
			{
				return;
			}
			foreach (var e in this.Elements)
			{
				if (e != null && !e.IsDisposed)
				{
					e.SetLabelText(GetString(false));
				}
				else
				{
					this.Elements.Remove(e);
				}
			}
		}
		private void TheTriggerWorker(Trigger sender, TickHandlerEventArgs<Trigger> handler)
		{
			// checking if the ticking parameter is 
			// true or not.
			if (IsTicking)
			{
				// add specified milliseconds to the data provider.
				_dateTime = _dateTime.AddMilliseconds(TickingInterval);
				try
				{
					this.UpdateElements();
				}
				catch
				{
					;
				}
			}
			else
			{
				// check if the trigger is enable or not (ofc it is!)
				// so stop it.
				if (sender.Enabled)
				{
					// stop the trigger from triggering the worker again.
					sender.Stop();
				}
			}
		}
		#endregion
		//-------------------------------------------------
		#region Get Method's Region
		/// <summary>
		/// return the string which contains the information
		/// about this class.
		/// </summary>
		/// <param name="value">
		/// if true,in addition to get the general informations, 
		/// you will get the informations about license.
		/// </param>
		/// <returns>information</returns>
		public StrongString ToString(bool value)
		{
			if (value)
			{
				return SecureToString;
			}
			return ToStringValue;
		}
		public StrongString GetString(bool onlyHour)
		{
			if (IsUnlimited)
			{
				return UnlimitedShowing;
			}
			if (onlyHour)
			{
				return _dateTime.ToString(
					ThereIsConstants.AppSettings.TimeFormat);
			}
			else
			{
				return _dateTime.ToString(
					ThereIsConstants.AppSettings.DateTimeFormat);
			}
		}
		public StrongString GetForServer()
		{
			if (IsUnlimited)
			{
				return UnlimitedTimeString;
			}
			return _dateTime.ToString(
					ThereIsConstants.AppSettings.DateTimeFormat);
		}
		public DateTime GetDateTime()
		{
			return _dateTime;
		}
		#endregion
		//-------------------------------------------------
		#region Set Method's Region
		public void AddElement(object e)
		{
			if (e is GraphicElement g && !g.IsDisposed)
			{
				this.Elements ??= new();
				this.Elements.Add(g);
			}
		}
		#endregion
		//-------------------------------------------------
		#region overrided Method's Region
		public override string ToString()
		{
			return ToStringValue;
		}
		#endregion
		//-------------------------------------------------
		#region static Method's Region
		public static IDateProvider<DateTime, Trigger, StrongString> Parse(StrongString value)
		{
			if (value == UnlimitedTimeString)
			{
				return new DateProvider();
			}
			return
				new DateProvider(DateTime.ParseExact(value.GetValue(),
					ThereIsConstants.AppSettings.DateTimeFormat,
					ThereIsConstants.AppSettings.CultureInfo.DateTimeFormat,
					DateTimeStyles.AssumeUniversal));
		}
		public static IDateProvider<DateTime, Trigger, StrongString> GetUnlimited()
		{
			return new DateProvider();
		}

		#endregion
		//-------------------------------------------------

	}
}
