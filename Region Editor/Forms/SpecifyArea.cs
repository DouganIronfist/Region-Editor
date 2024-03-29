﻿/****************************************************************************************************
 * 
 *   Filename    : SpecifyArea.cs
 *   
 *   Description : Form that allows users to modify region area settings
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
using System.Windows.Forms;

namespace Region_Editor
{
    internal partial class SpecifyArea : Form
    {
        #region Variables
        internal bool Canceled = false;
        private int mapWidth = 0;
        private int mapHeight = 0;

        internal Rectangle Area = new Rectangle(-1,-1,-1,-1);
        internal int zMin = 9999;
        #endregion

        #region Constructor
        internal SpecifyArea()
        {
            InitializeComponent();
        }
        #endregion

        #region Initialize
        internal void Initialize(int width, int height)
        {
            Initialize(width, height, new Rectangle(-1, -1, -1, -1), 9999);
        }

        internal void Initialize(int width, int height, Rectangle oldArea, int oldMin)
        {
            mapWidth = width;
            mapHeight = height;
            Area = oldArea;
            zMin = oldMin;

            if (oldArea.X != -1)
            {
                x.Text = oldArea.X.ToString();
                y.Text = oldArea.Y.ToString();
                w.Text = oldArea.Width.ToString();
                h.Text = oldArea.Height.ToString();
            }

            if (oldMin != 9999)
                ZMin.Text = oldMin.ToString();
        }
        #endregion

        #region setbutton_Click
        private void setbutton_Click(object sender, EventArgs e)
        {
            int mX = -1;
            int mY = -1;
            int mW = -1;
            int mH = -1;
            int mZ = 9999;

            try { mX = Convert.ToInt32(x.Text); }
            catch { }

            try { mY = Convert.ToInt32(y.Text); }
            catch { }

            try { mW = Convert.ToInt32(w.Text); }
            catch { }

            try { mH = Convert.ToInt32(h.Text); }
            catch { }

            try { mZ = (ZMin.Text == "" ? 9999 :Convert.ToInt32(ZMin.Text)); }
            catch { }

            if (mX < 0 || mX > mapWidth || mY < 0 || mY > mapHeight || mX + mW <= 0 || mX + mW > mapWidth || mY + mH <= 0 || mY + mH > mapHeight)
            {
                MessageBox.Show("Invalid area specified.  Out of map bounds.");
                return;
            }

            Area = new Rectangle(mX, mY, mW, mH);
            zMin = mZ;

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
