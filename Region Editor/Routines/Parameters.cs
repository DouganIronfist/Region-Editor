/****************************************************************************************************
 * 
 *   Filename    : Parameters.cs
 *   
 *   Description : Utility class that manages the application settings and OpenUO interface
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
using System.IO;
using System.Xml;

using OpenUO.Core.Patterns;
using OpenUO.Ultima;
using OpenUO.Ultima.Windows.Forms;

namespace Region_Editor
{
    internal class Parameters
    {
        #region Variables
        private static string _MulPath = "";
        internal static string MulPath { get { return _MulPath; } set { _MulPath = value; SetMulPath(); } }

        private static string _RegionsFile = "";
        internal static string RegionsFile { get { return _RegionsFile; } set { _RegionsFile = value; } }

        private static bool _Compatibility = false;
        internal static bool Compatibility { get { return _Compatibility; } set { _Compatibility = value; SetMap(); } }

        private static IoCContainer container;
        private static Maps maps;
        private static InstallLocation location;
        private static ArtworkFactory factory;

        private static Map currentMap;
        internal static Map CurrentMap { get { return currentMap; } }

        private static int mapIndex;
        internal static int MapIndex { get { return mapIndex; } set { mapIndex = value; SetMap(); } }

        private static List<string> music = new List<string>();
        internal static List<string> Music { get { return music; } }

        private static List<string> regionTypes = new List<string>();
        internal static List<string> RegionTypes { get { return regionTypes; } }
        #endregion

        #region Map Definitions
        private static Map Felucca
        {
            get
            {
                if (maps == null)
                    return null;

                if (Compatibility)
                    return new Map(location, 0, 0, 6144, 4096);
                else
                    return new Map(location, 0, 0, 7168, 4096);
            }
        }

        private static Map Trammel
        {
            get
            {
                if (maps == null)
                    return null;

                if (Compatibility)
                    return new Map(location, 1, 1, 6144, 4096);
                else
                    return new Map(location, 1, 1, 7168, 4096);
            }
        }

        private static Map Ilshenar
        {
            get
            {
                if (maps == null)
                    return null;

                return maps.Ilshenar; 
            }
        }

        private static Map Malas
        {
            get
            {
                if (maps == null)
                    return null;

                return maps.Malas;
            }
        }

        private static Map Tokuno
        {
            get
            {
                if (maps == null)
                    return null;

                return maps.Tokuno;
            }
        }

        private static Map TerMur
        {
            get
            {
                if (maps == null)
                    return null;

                return new Map(location, 5, 5, 1280, 4096);
            }
        }
        #endregion

        #region SetMulPath
        private static void SetMulPath()
        {
            location = new InstallLocation(_MulPath);
            container = new IoCContainer();

            container.RegisterModule<UltimaSDKCoreModule>();
            container.RegisterModule<UltimaSDKBitmapModule>();

            maps = new Maps(location);
            factory = new ArtworkFactory(location, container);

            SetMap();
        }
        #endregion

        #region SetMap
        private static void SetMap()
        {
            switch (mapIndex)
            {
                case 0:
                    currentMap = Felucca;
                    break;
                case 1:
                    currentMap = Trammel;
                    break;
                case 2:
                    currentMap = Ilshenar;
                    break;
                case 3:
                    currentMap = Malas;
                    break;
                case 4:
                    currentMap = Tokuno;
                    break;
                case 5:
                    currentMap = TerMur;
                    break;
            }
        }
        #endregion

        #region GetLand
        internal static Bitmap GetLand(int id)
        {
            if (factory == null)
                    return null;

            return factory.GetLand<Bitmap>(id);
        }
        #endregion

        #region LoadConfig
        internal static void LoadConfig()
        {
            if (!System.IO.File.Exists("config.xml"))
                return;

            try
            {
                XmlDocument doc = new XmlDocument();
                doc.Load("config.xml");

                XmlElement root = doc["config"];

                if (root == null)
                    return;

                foreach (XmlElement entry in root.SelectNodes("music"))
                    if (entry.HasAttribute("name"))
                        music.Add(entry.GetAttribute("name"));

                foreach (XmlElement entry in root.SelectNodes("regiontype"))
                    if (entry.HasAttribute("name"))
                        regionTypes.Add(entry.GetAttribute("name"));
            }
            catch { }
        }
        #endregion

        #region LoadParameters
        internal static void LoadParameters()
        {
            if (!System.IO.File.Exists("params.xml"))
                return;

            try
            {
                XmlDocument doc = new XmlDocument();
                doc.Load("params.xml");

                XmlElement root = doc["RegionEditor"];

                if (root == null)
                    return;

                MulPath = Regions.ReadString(root["mulpath"], "path");
                RegionsFile = Regions.ReadString(root["script"], "file");
                Compatibility = Regions.ReadBoolean(root["client"], "compatibilitymode", false);
            }
            catch { }
        }
        #endregion

        #region SaveParameters
        internal static void SaveParameters()
        {
            try
            {
                XmlTextWriter writer = new XmlTextWriter("params.xml", System.Text.Encoding.UTF8);

                writer.Formatting = Formatting.Indented;
                writer.WriteStartDocument();

                writer.WriteStartElement("RegionEditor");

                if (MulPath != "")
                {
                    writer.WriteStartElement("mulpath");

                    writer.WriteStartAttribute("path");
                    writer.WriteValue(_MulPath);
                    writer.WriteEndAttribute();

                    writer.WriteEndElement();
                }

                if (RegionsFile != "")
                {
                    writer.WriteStartElement("script");

                    writer.WriteStartAttribute("file");
                    writer.WriteValue(_RegionsFile);
                    writer.WriteEndAttribute();

                    writer.WriteEndElement();
                }

                if (Compatibility)
                {
                    writer.WriteStartElement("client");

                    writer.WriteStartAttribute("compatibilitymode");
                    writer.WriteValue(Compatibility);
                    writer.WriteEndAttribute();

                    writer.WriteEndElement();
                }

                writer.WriteEndElement();

                writer.WriteEndDocument();

                writer.Close();
            }
            catch { }
        }
        #endregion
    }
}
