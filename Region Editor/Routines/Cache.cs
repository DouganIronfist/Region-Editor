/****************************************************************************************************
 * 
 *   Filename    : Cache.cs
 *   
 *   Description : Static utility class that manages the tile image cache
 *
 *   Copyright (C) 2013  Dougan Ironfist
 *
 *   This program is free software: you can redistribute it and/or modify
 *   it under the terms of the GNU General Public License as published by
 *   the Free Software Foundation, either version 3 of the License, or
 *   (at your option) any later version.
 *
 *   This program is distributed in the hope that it will be useful,
 *   but WITHOUT ANY WARRANTY; without even the implied warranty of
 *   MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 *   GNU General Public License for more details.
 *
 *   You should have received a copy of the GNU General Public License
 *   along with this program.  If not, see <http://www.gnu.org/licenses/>.
 *   
 ***************************************************************************************************/

using System;
using System.Collections;
using System.Drawing;

namespace Region_Editor
{
    internal class Cache
    {
        #region Variables
        private static Hashtable TileCache = new Hashtable();
        #endregion

        #region GetColor
        internal static Color GetColor(int id)
        {
            if (TileCache[id] != null)
                return ((TileInfo)TileCache[id]).Color;
            else
                return InitializeTile(id).Color;
        }
        #endregion

        #region GetTile
        internal static Bitmap GetTile(int id, int scale)
        {
            if (TileCache[id] != null)
                return ((TileInfo)TileCache[id]).Images[scale];
            else
                return InitializeTile(id).Images[scale];
        }
        #endregion

        #region InitializeTile
        private static TileInfo InitializeTile(int id)
        {
            Bitmap bmp = Parameters.GetLand(id);

            if (bmp == null)
            {
                bmp = new Bitmap(44, 44);
                Graphics g = Graphics.FromImage(bmp);
                g.Clear(Color.Black);
                g.Dispose();
            }

            Bitmap[] images = new Bitmap[8];

            Color c = bmp.GetPixel(22, 22);

            images[0] = RotateTile(bmp, -45, 2, 2);
            images[1] = RotateTile(bmp, -45, 3, 3);
            images[2] = RotateTile(bmp, -45, 4, 4);
            images[3] = RotateTile(bmp, -45, 5, 5);
            images[4] = RotateTile(bmp, -45, 10, 10);
            images[5] = RotateTile(bmp, -45, 20, 20);
            images[6] = RotateTile(bmp, -45, 30, 30);

            TileInfo ti = new TileInfo(c, images);
            TileCache[id] = ti;

            bmp.Dispose();

            return ti;
        }
        #endregion

        #region GetTile
        internal static Bitmap GetTile(int id)
        {
            Bitmap bmp = Parameters.GetLand(id);

            if (bmp == null)
            {
                bmp = new Bitmap(44, 44);
                Graphics g = Graphics.FromImage(bmp);
                g.Clear(Color.Black);
                g.Dispose();
            }

            return RotateTile(bmp, -45, 30, 30);
        }
        #endregion

        #region RotateTile
        private static Bitmap RotateTile(Bitmap b, float angle, int width, int height)
        {
            Bitmap bmp = new Bitmap(44, 44);
            Graphics g = Graphics.FromImage(bmp);

            g.TranslateTransform((float)b.Width / 2, (float)b.Height / 2);
            g.RotateTransform(angle);
            g.TranslateTransform(-(float)b.Width / 2, -(float)b.Height / 2);
            g.DrawImage(b, 0, 0, 44, 44);
            g.Dispose();

            Bitmap newBmp = new Bitmap(width, height);
            g = Graphics.FromImage(newBmp);
            g.DrawImage(bmp, 0, 0, new RectangleF(6, 7, 30, 30), GraphicsUnit.Pixel);
            g.Dispose();

            return newBmp;
        }
        #endregion
    }
}