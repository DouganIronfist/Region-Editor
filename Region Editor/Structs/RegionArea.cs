/****************************************************************************************************
 * 
 *   Filename    : RegionArea.cs
 *   
 *   Description : Data structure that contains area info
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
    internal struct RegionArea
    {
        #region Variables
        private Rectangle _Area;
        private int _ZMin;

        internal Rectangle Area { get { return _Area; } set { _Area = value; } }
        internal int ZMin { get { return _ZMin; } set { _ZMin = value; } }
        #endregion

        #region Constructor
        internal RegionArea(Rectangle area) : this(area, 9999)
        {
        }

        internal RegionArea(Rectangle area, int zMin)
        {
            _Area = area;
            _ZMin = zMin;
        }
        #endregion
    }
}
