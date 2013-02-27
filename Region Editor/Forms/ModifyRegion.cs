/****************************************************************************************************
 * 
 *   Filename    : ModifyRegion.cs
 *   
 *   Description : Form that allows users to modify region settings
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
using System.Windows.Forms;

namespace Region_Editor
{
    internal partial class ModifyRegion : Form
    {
        #region Variables
        internal bool Canceled = false;
        internal Region ModdedRegion = new Region();

        private string allowedString = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890_";
        #endregion

        #region Constructor
        internal ModifyRegion()
        {
            InitializeComponent();

            foreach (string s in Parameters.Music)
                music.Items.Add(s);

            foreach (string s in Parameters.RegionTypes)
                regionType.Items.Add(s);
        }
        #endregion

        #region Initialize
        internal void Initialize(Region region)
        {
            ModdedRegion = region;

            if (region.Name != null)
                regionName.Text = region.Name;

            if (region.Priority != 9999)
                priority.Text = region.Priority.ToString();

            if (region.Type != null)
                regionType.Text = region.Type;

            if (region.RuneName != null)
                runeName.Text = region.RuneName;

            if (region.MusicName != null)
                music.Text = region.MusicName;

            if (region.GoLocation.X != 9999)
            {
                goX.Text = region.GoLocation.X.ToString();
                goY.Text = region.GoLocation.Y.ToString();
                goZ.Text = region.GoLocationZ.ToString();
            }

            if (region.Entrance.X != 9999)
            {
                entranceX.Text = region.Entrance.X.ToString();
                entranceY.Text = region.Entrance.Y.ToString();
            }

            if (region.MinZRange != 9999)
                minZRange.Text = region.MinZRange.ToString();

            if (!region.LogoutDelayActive)
                disableLogoutDelay.Checked = true;

            if (region.GuardsDisabled)
                disableGuards.Checked = true;

            if (region.SmartNoHousing)
                smartNoHousing.Checked = true;

            if (region.QuestType != null)
                questType.Text = region.QuestType;

            if (region.QuestMin != null)
                questIncomplete.Text = region.QuestMin;

            if (region.QuestComplete != null)
                questComplete.Text = region.QuestComplete;

            if (region.QuestMessage != 0)
                questMessage.Text = region.QuestMessage.ToString();
        }
        #endregion

        #region setButton_Click
        private void setButton_Click(object sender, EventArgs e)
        {
            if (regionName.Text != "")
                ModdedRegion.Name = regionName.Text;
            else
                ModdedRegion.Name = null;

            if (priority.Text != "")
            {
                try { ModdedRegion.Priority = Convert.ToInt32(priority.Text); }
                catch { ModdedRegion.Priority = 9999; }
            }
            else
                ModdedRegion.Priority = 9999;

            if (regionType.Text != "")
            {
                ModdedRegion.Type = regionType.Text;

                if (!Parameters.RegionTypes.Contains(regionType.Text))
                    Parameters.RegionTypes.Add(regionType.Text);
            }
            else
                ModdedRegion.Type = null;

            if (runeName.Text != "")
                ModdedRegion.RuneName = runeName.Text;
            else
                ModdedRegion.RuneName = null;

            if (music.Text != "")
                ModdedRegion.MusicName = music.Text;
            else
                ModdedRegion.MusicName = null;

            if (goX.Text != "" && goY.Text != "" && goZ.Text != "")
            {
                try
                {
                    ModdedRegion.GoLocation = new Point(Convert.ToInt32(goX.Text), Convert.ToInt32(goY.Text));
                    ModdedRegion.GoLocationZ = Convert.ToInt32(goZ.Text);
                }
                catch
                {
                    ModdedRegion.GoLocation = new Point(9999, 9999);
                    ModdedRegion.GoLocationZ = 9999;
                }
            }
            else
            {
                ModdedRegion.GoLocation = new Point(9999, 9999);
                ModdedRegion.GoLocationZ = 9999;
            }

            if (entranceX.Text != "" && entranceY.Text != "")
            {
                try
                {
                    ModdedRegion.Entrance = new Point(Convert.ToInt32(entranceX.Text), Convert.ToInt32(entranceY.Text));
                }
                catch
                {
                    ModdedRegion.Entrance = new Point(9999, 9999);
                }
            }
            else
            {
                ModdedRegion.Entrance = new Point(9999, 9999);
            }

            if (minZRange.Text != "")
            {
                try { ModdedRegion.MinZRange = Convert.ToInt32(minZRange.Text); }
                catch { ModdedRegion.MinZRange = 9999; }
            }
            else
                ModdedRegion.MinZRange = 9999;

            ModdedRegion.LogoutDelayActive = !disableLogoutDelay.Checked;
            ModdedRegion.GuardsDisabled = disableGuards.Checked;
            ModdedRegion.SmartNoHousing = smartNoHousing.Checked;

            if (questType.Text != "")
                ModdedRegion.QuestType = questType.Text;
            else
                ModdedRegion.QuestType = null;

            if (questIncomplete.Text != "")
                ModdedRegion.QuestMin = questIncomplete.Text;
            else
                ModdedRegion.QuestMin = null;

            if (questComplete.Text != "")
                ModdedRegion.QuestComplete = questComplete.Text;
            else
                ModdedRegion.QuestComplete = null;

            if (questMessage.Text != "")
            {
                try { ModdedRegion.QuestMessage = Convert.ToInt32(questMessage.Text); }
                catch { ModdedRegion.QuestMessage = 0; }
            }
            else
                ModdedRegion.QuestMessage = 0;

            Close();
        }
        #endregion

        #region cancelButton_Click
        private void cancelButton_Click(object sender, EventArgs e)
        {
            Canceled = true;
            Close();
        }
        #endregion

        #region regionType_TextChanged
        private void regionType_TextChanged(object sender, EventArgs e)
        {
            List<char> invalid = new List<char>();

            // Determine if invalid characters are present
            foreach (char c in Text)
                if (allowedString.IndexOf(c) < 0 && !invalid.Contains(c))
                    invalid.Add(c);

            // Determine if invalid characters are present
            foreach (char c in Text)
                if (allowedString.IndexOf(c) < 0 && !invalid.Contains(c))
                    invalid.Add(c);

            StringBuilder sb = new StringBuilder(Text);

            // Filter out the invalid characters from the text
            foreach (char c in invalid)
                sb.Replace(c.ToString(), "");

            Text = sb.ToString();
        }
        #endregion

        #region regionType_KeyPress
        private void regionType_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;

                // If the key pressed is in the allowed list, then process the keypress
                foreach (char c in allowedString)
                    if (e.KeyChar == c)
                        e.Handled = false;
            }
        }
        #endregion
    }
}
