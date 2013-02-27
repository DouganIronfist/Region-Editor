/****************************************************************************************************
 * 
 *   Filename    : ModifySpawn.cs
 *   
 *   Description : Form that allows users to modify spawn settings
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
using System.Windows.Forms;

namespace Region_Editor
{
    internal partial class ModifySpawn : Form
    {
        #region Variables
        internal bool Canceled = false;
        internal Spawn Spawn = new Spawn();
        #endregion

        #region Constructor
        internal ModifySpawn()
        {
            InitializeComponent();
        }
        #endregion

        #region Initialize
        internal void Initialize(Spawn spawn)
        {
            Spawn = spawn;

            id.Text = spawn.SpawnID.ToString();
            type.Text = spawn.SpawnType;
            min.Text = spawn.SpawnMinSeconds.ToString();
            max.Text = spawn.SpawnMaxSeconds.ToString();
            amount.Text = spawn.SpawnAmount.ToString();
        }
        #endregion

        #region setButton_Click
        private void setButton_Click(object sender, EventArgs e)
        {
            if (id.Text == "" || type.Text == "" || min.Text == "" || max.Text == "" || amount.Text == "")
            {
                MessageBox.Show("All fields must to completed before saving.");
                return;
            }

            int _id;
            int _min;
            int _max;
            int _amount;

            try { _id = Convert.ToInt32(id.Text); }
            catch { _id = 0; }

            try { _min = Convert.ToInt32(min.Text); }
            catch { _min = 0; }

            try { _max = Convert.ToInt32(max.Text); }
            catch { _max = 0; }

            try { _amount = Convert.ToInt32(amount.Text); }
            catch { _amount = 0; }

            Spawn = new Spawn(_id, type.Text, _min, _max, _amount);

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
    }
}
