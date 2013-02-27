/****************************************************************************************************
 * 
 *   Filename    : TileInfo.cs
 *   
 *   Description : Data structure that contains tile info
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
using System.Drawing;

namespace Region_Editor
{
    internal struct TileInfo
    {
        #region Variables
        private Color _Color;
        internal Color Color { get { return _Color; } }

        private Bitmap[] _Images;
        internal Bitmap[] Images { get { return _Images; } }
        #endregion

        #region Constructor
        internal TileInfo(Color color, Bitmap[] images)
        {
            _Color = color;
            _Images = images;
        }
        #endregion
    }
}
