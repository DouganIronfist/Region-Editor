/****************************************************************************************************
 * 
 *   Filename    : Spawn.cs
 *   
 *   Description : Data structure that contains spawn info
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
    internal struct Spawn
    {
        #region Variables
        private int _SpawnID;
        private string _SpawnType;
        private int _SpawnMinSeconds;
        private int _SpawnMaxSeconds;
        private int _SpawnAmount;

        internal int SpawnID { get { return _SpawnID; } set { _SpawnID = value; } }
        internal string SpawnType { get { return _SpawnType; } set { _SpawnType = value; } }
        internal int SpawnMinSeconds { get { return _SpawnMinSeconds; } set { _SpawnMinSeconds = value; } }
        internal int SpawnMaxSeconds { get { return _SpawnMaxSeconds; } set { _SpawnMaxSeconds = value; } }
        internal int SpawnAmount { get { return _SpawnAmount; } set { _SpawnAmount = value; } }
        #endregion

        #region Constructor
        internal Spawn(int id, string type, int minSeconds, int maxSeconds, int amount)
        {
            _SpawnID = id;
            _SpawnType = type;
            _SpawnMinSeconds = minSeconds;
            _SpawnMaxSeconds = maxSeconds;
            _SpawnAmount = amount;
        }
        #endregion
    }
}
