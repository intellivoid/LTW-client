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

using System.Threading.Tasks;
using System.Threading;
using LTW.Screens;
using static LTW.Constants.GameParams;

namespace LTW.Client
{
	partial class GameClient
	{

		//-------------------------------------------------
		#region Initialize Method's Region
		protected override void InitializeComponents()
		{
			//---------------------------------------------
			this.IsBorderless = true;
			ContentManager.RootDirectory = GameData;
			this.CalculateRates();
			//---------------------------------------------
			//news:
			this.CurrentScreen = new FirstLoadingScreen(this);
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
			Task.Run(() =>
			{
				Thread.Sleep(1000);
				this.CurrentScreen.InitializeComponents();
			});
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
			// some methods here
		#endregion
		//-------------------------------------------------
		#region ordinary Method's Region
		private void CalculateRates()
		{
			float w = this.GetDevice().DisplayMode.Width;
			float h = this.GetDevice().DisplayMode.Height;
			Woto_WRate = WOTO_STD_WIDTH / w;
			Woto_HRate = WOTO_STD_HEIGHT / h;
			PWidth = (int)(Woto_WRate * Width);
			PHeight = (int)(Woto_HRate * Height);
		}
		#endregion
		//-------------------------------------------------
		#region Get Method's Region
			// some methods here
		#endregion
		//-------------------------------------------------
		#region Set Method's Region
			// some methods here
		#endregion
		//-------------------------------------------------

	}
}
