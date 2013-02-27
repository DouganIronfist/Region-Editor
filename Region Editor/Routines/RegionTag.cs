/****************************************************************************************************
 * 
 *   Filename    : RegionTag.cs
 *   
 *   Description : Utility class used to assign tags to regions for internal use
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

namespace Region_Editor
{
    internal struct RegionTag
    {
        #region Variables
        private Region _Parent;
        internal Region Parent { get { return _Parent; } set { _Parent = value; } }

        private int _Index;
        internal int Index { get { return _Index; } set { _Index = value; } }

        private string _Reference;
        internal string Reference { get { return _Reference; } set { _Reference = value; } }

        private Region _OwnRegion;
        internal Region OwnRegion { get { return _OwnRegion; } set { _OwnRegion = value; } }
        #endregion

        #region Constructor
        internal RegionTag(Region parent)
        {
            _Parent = parent;
            _Index = -1;
            _Reference = "";
            _OwnRegion = parent;
        }

        internal RegionTag(Region parent, string reference)
        {
            _Parent = parent;
            _Index = -1;
            _Reference = reference;
            _OwnRegion = parent;
        }

        internal RegionTag(Region parent, string reference, int index)
        {
            _Parent = parent;
            _Index = index;
            _Reference = reference;
            _OwnRegion = parent;
        }

        internal RegionTag(Region parent, string reference, int index, Region ownregion)
        {
            _Parent = parent;
            _Index = index;
            _Reference = reference;
            _OwnRegion = ownregion;
        }
        #endregion
    }
}
