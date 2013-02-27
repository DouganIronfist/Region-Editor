/****************************************************************************************************
 * 
 *   Filename    : Facet.cs
 *   
 *   Description : Utility class that manages the regions defined for a facet
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
using System.Collections.Generic;

namespace Region_Editor
{
    internal class Facet
    {
        #region Variables
        private string _Name = "";
        internal string Name { get { return _Name; } set { _Name = value; } }

        private List<Region> _Regions = new List<Region>();
        internal List<Region> Regions { get { return _Regions; } set { _Regions = value; } }
        #endregion

        #region Constructor
        internal Facet(string name)
        {
            _Name = name;
        }
        #endregion

        #region SortRegions
        internal void SortRegions()
        {
            Regions.Sort(Region.CompareByName);
        }
        #endregion
    }
}
