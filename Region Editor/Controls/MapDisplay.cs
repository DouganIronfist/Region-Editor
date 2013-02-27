/****************************************************************************************************
 * 
 *   Filename    : MapDisplay.cs
 *   
 *   Description : PictureBox control that displays the current map at the specified location with
 *                 the specified scaling.
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
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

using OpenUO.Ultima;

namespace Region_Editor
{
    internal class MapDisplay : PictureBox
    {
        #region Variables
        private bool _Initialized = false;
        internal bool Initialized { get { return _Initialized; } set { _Initialized = value; Invalidate(); } }

        private int _TileWidth = 18;
        internal int TileWidth { get { return _TileWidth; } }

        private Hashtable MapCoordinates = new Hashtable();
        private bool LeftMousePressed = false;
        private Point HighlightBegin = new Point(-1, -1);
        private Point HighlightEnd = new Point(-1, -1);
        private Point LastClicked = new Point(-1, -1);
        private int ScaledSize = 30;
        #endregion

        #region Properties
        private Point _Upper_Coordinate = new Point(0, 0);
        private Point _Hover_Coordinate = new Point(0, 0);
        private Rectangle _HighlightedArea = new Rectangle(0, 0, 0, 0);
        private Scaling _Scale = Scaling.Scale30;

        [Bindable(true), Category("Behavior"), DefaultValue(typeof(Point), "0,0"), Description("The coordinate of the UO map in the upper left corner.")]
        public Point Upper_Coordinate
        {
            get { return _Upper_Coordinate; }
            set
            {
                _Upper_Coordinate = value;
                Refresh();
            }
        }

        [Bindable(true), Category("Behavior"), DefaultValue(typeof(Point), "0,0"), Description("The coordinate of the UO map that the user is hovering over.")]
        public Point Hover_Coordinate
        {
            get { return _Hover_Coordinate; }
        }

        [Bindable(true), Category("Behavior"), DefaultValue(typeof(Rectangle), "0,0,0,0"), Description("The area of the UO map that the user has highlighted.")]
        public Rectangle HighlightedArea
        {
            get { return _HighlightedArea; }
            set
            {
                _HighlightedArea = value;
                LeftMousePressed = false;
                HighlightBegin = new Point(_HighlightedArea.X, _HighlightedArea.Y);
                HighlightEnd = new Point(_HighlightedArea.X + _HighlightedArea.Width, _HighlightedArea.Y + _HighlightedArea.Height);
            }
        }

        [Bindable(true), Category("Behavior"), DefaultValue(typeof(Scaling), "Full"), Description("The scale at which the map should be displayed.")]
        public Scaling MapScale
        {
            get { return _Scale; }
            set
            {
                _Scale = value;

                switch (_Scale)
                {
                    case Scaling.Scale30:
                        ScaledSize = 30;
                        break;
                    case Scaling.Scale20:
                        ScaledSize = 20;
                        break;
                    case Scaling.Scale10:
                        ScaledSize = 10;
                        break;
                    case Scaling.Scale5:
                        ScaledSize = 5;
                        break;
                    case Scaling.Scale4:
                        ScaledSize = 4;
                        break;
                    case Scaling.Scale3:
                        ScaledSize = 3;
                        break;
                    case Scaling.Scale2:
                        ScaledSize = 2;
                        break;
                }

                _TileWidth = Width / ScaledSize;

                Invalidate();
            }
        }
        #endregion

        #region Events
        [Category("Action"), Description("Occurs when the user moves the mouse over a new coordinate")]
        public event EventHandler HoverCoordinatedChanged;
        #endregion

        #region Constructor
        internal MapDisplay()
        {
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            SetStyle(ControlStyles.UserMouse, true);
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.SupportsTransparentBackColor, false);

            TabStop = false;
        }
        #endregion

        #region OnPaint
        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);

            pe.Graphics.Clear(Color.Black);

            if (!Initialized)
                return;

            TileMatrix matrix = null;

            if (Parameters.CurrentMap != null)
                matrix = Parameters.CurrentMap.Tiles;

            bool tilesHighlite = false;
            MapCoordinates = new Hashtable();

            for (int x = 0; x < _TileWidth; x++)
            {
                for (int y = 0; y < _TileWidth; y++)
                {
                    int upperX = x * ScaledSize;
                    int upperY = y * ScaledSize;

                    Bitmap bmp = null;

                    if (matrix != null)
                        bmp = Cache.GetTile(matrix.GetLandTile(_Upper_Coordinate.X + x, _Upper_Coordinate.Y + y).Id, (int)MapScale);

                    if (bmp == null)
                    {
                        bmp = new Bitmap(ScaledSize, ScaledSize);
                        Graphics g = Graphics.FromImage(bmp);
                        g.Clear(Color.Black);
                        g.Dispose();
                    }

                    Rectangle area = new Rectangle(upperX, upperY, ScaledSize, ScaledSize);

                    if (_HighlightedArea.Contains(_Upper_Coordinate.X + x, _Upper_Coordinate.Y + y))
                        tilesHighlite = true;
                    else
                        tilesHighlite = false;

                    pe.Graphics.DrawImage(bmp, upperX, upperY);

                    if (tilesHighlite)
                        pe.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(100, Color.Yellow)), area);

                    MapCoordinates[area] = new Point(_Upper_Coordinate.X + x, _Upper_Coordinate.Y + y);
                }
            }
        }
        #endregion

        #region OnDoubleClick
        protected override void OnDoubleClick(EventArgs e)
        {
            base.OnDoubleClick(e);

            if (Parent is RegionEditor)
                ((RegionEditor)Parent).GotoLocation(LastClicked.X, LastClicked.Y, 0, 0);
        }
        #endregion

        #region OnMouseDown
        protected override void OnMouseDown(MouseEventArgs e)
        {
            Point coord = new Point(-1,-1);

            foreach (DictionaryEntry entry in MapCoordinates)
            {
                if (entry.Key is Rectangle && ((Rectangle)entry.Key).Contains(e.Location))
                {
                    if (entry.Value is Point)
                    {
                        coord = new Point(((Point)entry.Value).X, ((Point)entry.Value).Y);
                    }
                }
            }

            LastClicked = coord;

            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                LeftMousePressed = true;

                if (HighlightBegin.X != -1 && ModifierKeys == Keys.Shift && coord.X != -1)
                {
                    HighlightEnd = coord;
                }
                else
                {
                    if (HighlightBegin.X != -1)
                    {
                        HighlightBegin = new Point(-1, -1);
                        HighlightEnd = new Point(-1, -1);
                        _HighlightedArea = new Rectangle(0, 0, 0, 0);
                        Invalidate();
                    }

                    if (coord.X != -1)
                    {
                        HighlightBegin = coord;
                    }
                }
            }

            if (HighlightBegin.X != -1 && HighlightEnd.X != -1)
            {
                Point start = new Point(HighlightBegin.X, HighlightBegin.Y);
                Point end = new Point(HighlightEnd.X, HighlightEnd.Y);
                FixPoints(ref start, ref end);
                _HighlightedArea = new Rectangle(start.X, start.Y, end.X - start.X + 1, end.Y - start.Y + 1);

                Invalidate();
            }

            base.OnMouseDown(e);
        }
        #endregion

        #region OnMouseUp
        protected override void OnMouseUp(MouseEventArgs e)
        {
            LeftMousePressed = false;

            base.OnMouseUp(e);
        }
        #endregion

        #region OnMouseMove
        protected override void OnMouseMove(MouseEventArgs e)
        {
            foreach (DictionaryEntry entry in MapCoordinates)
            {
                if (entry.Key is Rectangle && ((Rectangle)entry.Key).Contains(e.Location))
                {
                    if (entry.Value is Point)
                    {
                        Point coord = new Point(((Point)entry.Value).X, ((Point)entry.Value).Y);

                        if (coord != _Hover_Coordinate)
                        {
                            _Hover_Coordinate = coord;

                            if (HoverCoordinatedChanged != null)
                                HoverCoordinatedChanged(this, new EventArgs());
                        }

                        if (LeftMousePressed)
                        {
                            if (HighlightBegin.X == -1)
                                HighlightBegin = coord;

                            HighlightEnd = coord;

                            Point start = new Point(HighlightBegin.X, HighlightBegin.Y);
                            Point end = new Point(HighlightEnd.X, HighlightEnd.Y);
                            FixPoints(ref start, ref end);
                            _HighlightedArea = new Rectangle(start.X, start.Y, end.X - start.X + 1, end.Y - start.Y + 1);

                            Invalidate();
                        }
                    }
                }
            }

            base.OnMouseMove(e);
        }
        #endregion

        #region FixPoints
        private void FixPoints(ref Point top, ref Point bottom)
        {
            if (bottom.X < top.X)
            {
                int swap = top.X;
                top.X = bottom.X;
                bottom.X = swap;
            }

            if (bottom.Y < top.Y)
            {
                int swap = top.Y;
                top.Y = bottom.Y;
                bottom.Y = swap;
            }
        }
        #endregion
    }
}
