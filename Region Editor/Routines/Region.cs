/****************************************************************************************************
 * 
 *   Filename    : Region.cs
 *   
 *   Description : Utility class that manages the settings for a region
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
using System.Drawing;
using System.Text;

namespace Region_Editor
{
    internal class Region
    {
        #region Variables
        private string _Type = null;
        private int _Priority = 9999;
        private string _Name = null;
        private string _RuneName = null;
        private Point _GoLocation = new Point(9999, 9999);
        private int _GoLocationZ = 0;
        private Point _Entrance = new Point(9999, 9999);
        private string _MusicName = null;
        private int _MinZRange = 9999;
        private bool _LogoutDelayActive = true;
        private bool _GuardsDisabled = false;
        private bool _SmartNoHousing = false;
        private string _QuestType = null;
        private string _QuestMin = null;
        private string _QuestComplete = null;
        private int _QuestMessage = 0;

        private List<RegionArea> _Area = new List<RegionArea>();
        private List<Region> _Regions = new List<Region>();
        private List<Spawn> _Spawns = new List<Spawn>();

        internal string Type { get { return _Type; } set { _Type = value; } }
        internal int Priority { get { return _Priority; } set { _Priority = value; } }
        internal string Name { get { return _Name; } set { _Name = value; } }
        internal string RuneName { get { return _RuneName; } set { _RuneName = value; } }
        internal Point GoLocation { get { return _GoLocation; } set { _GoLocation = value; } }
        internal int GoLocationZ { get { return _GoLocationZ; } set { _GoLocationZ = value; } }
        internal Point Entrance { get { return _Entrance; } set { _Entrance = value; } }
        internal string MusicName { get { return _MusicName; } set { _MusicName = value; } }
        internal int MinZRange { get { return _MinZRange; } set { _MinZRange = value; } }
        internal bool LogoutDelayActive { get { return _LogoutDelayActive; } set { _LogoutDelayActive = value; } }
        internal bool GuardsDisabled { get { return _GuardsDisabled; } set { _GuardsDisabled = value; } }
        internal bool SmartNoHousing { get { return _SmartNoHousing; } set { _SmartNoHousing = value; } }
        internal string QuestType { get { return _QuestType; } set { _QuestType = value; } }
        internal string QuestMin { get { return _QuestMin; } set { _QuestMin = value; } }
        internal string QuestComplete { get { return _QuestComplete; } set { _QuestComplete = value; } }
        internal int QuestMessage { get { return _QuestMessage; } set { _QuestMessage = value; } }

        internal List<RegionArea> Area { get { return _Area; } set { _Area = value; } }
        internal List<Region> Regions { get { return _Regions; } set { _Regions = value; } }
        internal List<Spawn> Spawns { get { return _Spawns; } set { _Spawns = value; } }
        #endregion

        #region Dupe
        internal Region Dupe()
        {
            Region r = new Region();

            r.Type = _Type;
            r.Priority = _Priority;
            r.Name = _Name;
            r.RuneName = _RuneName;
            r.GoLocation = _GoLocation;
            r.GoLocationZ = _GoLocationZ;
            r.Entrance = _Entrance;
            r.MusicName = _MusicName;
            r.MinZRange = _MinZRange;
            r.LogoutDelayActive = _LogoutDelayActive;
            r.GuardsDisabled = _GuardsDisabled;
            r.SmartNoHousing = _SmartNoHousing;
            r.QuestType = _QuestType;
            r.QuestMin = _QuestMin;
            r.QuestComplete = _QuestComplete;
            r.QuestMessage = _QuestMessage;

            return r;
        }
        #endregion

        #region Update
        internal void Update(Region r)
        {
            _Type = r.Type;
            _Priority = r.Priority;
            _Name = r.Name;
            _RuneName = r.RuneName;
            _GoLocation = r.GoLocation;
            _GoLocationZ = r.GoLocationZ;
            _Entrance = r.Entrance;
            _MusicName = r.MusicName;
            _MinZRange = r.MinZRange;
            _LogoutDelayActive = r.LogoutDelayActive;
            _GuardsDisabled = r.GuardsDisabled;
            _SmartNoHousing = r.SmartNoHousing;
            _QuestType = r.QuestType;
            _QuestMin = r.QuestMin;
            _QuestComplete = r.QuestComplete;
            _QuestMessage = r.QuestMessage;
        }
        #endregion

        #region SortRegions
        internal void SortRegions()
        {
            Regions.Sort(CompareByName);
        }
        #endregion

        #region CompareByName
        internal static int CompareByName(Region r1, Region r2)
        {
            if (r1.Name == null)
            {
                if (r2.Name == null)
                    return 0;
                else
                    return -1;
            }
            else
            {
                if (r2.Name == null)
                    return 1;
                else
                    return r1.Name.CompareTo(r2.Name);
            }
        }
        #endregion
    }
}
