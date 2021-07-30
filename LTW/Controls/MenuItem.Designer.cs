using System.Drawing;
using Microsoft.Xna.Framework.Graphics;
using GUISharp.Constants;
using GUISharp.WotoProvider.Enums;

namespace LTW.Controls
{
	partial class MenuItem
	{
		//-------------------------------------------------
		#region Initialize Method's Region
		private void InitializeComponent()
		{
			//---------------------------------------------
			//news:
			//---------------------------------------------
			//names:
			//status:
			//fontAndTextAligns:
			//priorities:
			//sizes:
			this.ChangeSize();
			//ownering:
			//locations:
			//movements:
			//colors:
			this.ChangeBorder(ButtonColors.Custom);
			//enableds:
			//texts:
			//images:
			this.ChangeImage(GetTexture2D());
			//applyAndShow:
			//events:
			//---------------------------------------------
			//addRanges:
			//---------------------------------------------
			//finalBlow:
			//---------------------------------------------
		}
		#endregion
		//-------------------------------------------------
		#region Graphical Method's Region
		private Texture2D GetTexture2D()
		{
			if (_main_menu_item_texture != null && !_main_menu_item_texture.IsDisposed)
			{
				return _main_menu_item_texture;
			}
			int w = (int)(QUALITY_OFFSET * this.Width);
			int h = (int)(QUALITY_OFFSET * this.Height);
			using (var i = new Bitmap(w, h))
			{
				var g = Graphics.FromImage(i);
				PointF[] UnlimitedPointsWorks = new PointF[]
				{
					new(w / 6, default),			// 0
					new(w, default),				// 1
					new(w - (w / 6), h),	// 2
					new(default, h),				// 3
				};
				g.FillPolygon(new SolidBrush(Color.FromArgb(80, Color.Black)), UnlimitedPointsWorks);
				g.Save();
				_main_menu_item_texture = i.ToTexture2D();
				g.Dispose();
				//i.Save("test2.png");
			}

			return _main_menu_item_texture;
		}
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
			// some methods here
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