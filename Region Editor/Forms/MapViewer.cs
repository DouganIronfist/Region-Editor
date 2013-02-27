/****************************************************************************************************
 * 
 *   Filename    : MapViewer.cs
 *   
 *   Description : Form that displays rendered world maps
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
    internal partial class MapViewer : Form
    {
        #region Variables
        internal RegionEditor Editor = null;
        private Point ClickLocation;
        #endregion

        #region Constructor
        internal MapViewer()
        {
            InitializeComponent();
        }
        #endregion

        #region renderMapAgainToolStripMenuItem_Click
        private void renderMapAgainToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Editor.ForceRender(this);
        }
        #endregion

        #region mapImage_MouseDown
        private void mapImage_MouseDown(object sender, MouseEventArgs e)
        {
            ClickLocation = e.Location;
        }
        #endregion

        #region mapImage_DoubleClick
        private void mapImage_DoubleClick(object sender, EventArgs e)
        {
            int realX = (int)(((double)Parameters.CurrentMap.Width / (double)mapImage.Width) * (double)ClickLocation.X);
            int realY = (int)(((double)Parameters.CurrentMap.Height / (double)mapImage.Height) * (double)ClickLocation.Y);

            Editor.GotoLocation(realX, realY, 0, 0);
        }
        #endregion
    }
}
