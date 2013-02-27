namespace Region_Editor
{
    partial class RegionEditor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegionEditor));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mULFilePathToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.regionsxmlLocationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.reloadRegionsFromFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveRegionsToFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.compatible = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.facetList = new System.Windows.Forms.ComboBox();
            this.ShowMapButton = new System.Windows.Forms.Button();
            this.renderProgress = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.locationLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.facetView = new System.Windows.Forms.TreeView();
            this.newRegion = new System.Windows.Forms.Button();
            this.modifyRegion = new System.Windows.Forms.Button();
            this.removeRegion = new System.Windows.Forms.Button();
            this.addSpawn = new System.Windows.Forms.Button();
            this.removeSpawn = new System.Windows.Forms.Button();
            this.addSubRegion = new System.Windows.Forms.Button();
            this.addArea = new System.Windows.Forms.Button();
            this.removeArea = new System.Windows.Forms.Button();
            this.areaModify = new System.Windows.Forms.Button();
            this.modifySpawn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.goButton = new System.Windows.Forms.Button();
            this.clearFacet = new System.Windows.Forms.Button();
            this.goY = new Region_Editor.FilteredTextBox();
            this.goX = new Region_Editor.FilteredTextBox();
            this.scaleSlider = new Region_Editor.Slider();
            this.ySlider = new Region_Editor.Slider();
            this.xSlider = new Region_Editor.Slider();
            this.mapDisplay = new Region_Editor.MapDisplay();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mapDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.optionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1008, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mULFilePathToolStripMenuItem,
            this.regionsxmlLocationToolStripMenuItem,
            this.toolStripMenuItem1,
            this.reloadRegionsFromFileToolStripMenuItem,
            this.saveRegionsToFileToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // mULFilePathToolStripMenuItem
            // 
            this.mULFilePathToolStripMenuItem.Name = "mULFilePathToolStripMenuItem";
            this.mULFilePathToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.mULFilePathToolStripMenuItem.Text = "MUL File Path";
            this.mULFilePathToolStripMenuItem.Click += new System.EventHandler(this.mULFilePathToolStripMenuItem_Click);
            // 
            // regionsxmlLocationToolStripMenuItem
            // 
            this.regionsxmlLocationToolStripMenuItem.Name = "regionsxmlLocationToolStripMenuItem";
            this.regionsxmlLocationToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.regionsxmlLocationToolStripMenuItem.Text = "Regions.xml Location";
            this.regionsxmlLocationToolStripMenuItem.Click += new System.EventHandler(this.regionsxmlLocationToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(204, 6);
            // 
            // reloadRegionsFromFileToolStripMenuItem
            // 
            this.reloadRegionsFromFileToolStripMenuItem.Name = "reloadRegionsFromFileToolStripMenuItem";
            this.reloadRegionsFromFileToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.reloadRegionsFromFileToolStripMenuItem.Text = "Reload Regions From File";
            this.reloadRegionsFromFileToolStripMenuItem.Click += new System.EventHandler(this.reloadRegionsFromFileToolStripMenuItem_Click);
            // 
            // saveRegionsToFileToolStripMenuItem
            // 
            this.saveRegionsToFileToolStripMenuItem.Name = "saveRegionsToFileToolStripMenuItem";
            this.saveRegionsToFileToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.saveRegionsToFileToolStripMenuItem.Text = "Save Regions To File";
            this.saveRegionsToFileToolStripMenuItem.Click += new System.EventHandler(this.saveRegionsToFileToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.compatible});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "&Options";
            // 
            // compatible
            // 
            this.compatible.CheckOnClick = true;
            this.compatible.Name = "compatible";
            this.compatible.Size = new System.Drawing.Size(281, 22);
            this.compatible.Text = "Enable Compatibility with Older Clients";
            this.compatible.CheckedChanged += new System.EventHandler(this.compatible_CheckedChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Location = new System.Drawing.Point(598, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 21);
            this.label1.TabIndex = 12;
            this.label1.Text = "Facet";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // facetList
            // 
            this.facetList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.facetList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.facetList.FormattingEnabled = true;
            this.facetList.Items.AddRange(new object[] {
            "Felucca",
            "Trammel",
            "Ilshenar",
            "Malas",
            "Tokuno",
            "Ter Mur"});
            this.facetList.Location = new System.Drawing.Point(634, 31);
            this.facetList.Name = "facetList";
            this.facetList.Size = new System.Drawing.Size(121, 21);
            this.facetList.TabIndex = 13;
            this.facetList.TabStop = false;
            this.facetList.SelectedIndexChanged += new System.EventHandler(this.facetList_SelectedIndexChanged);
            // 
            // ShowMapButton
            // 
            this.ShowMapButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ShowMapButton.Location = new System.Drawing.Point(761, 30);
            this.ShowMapButton.Name = "ShowMapButton";
            this.ShowMapButton.Size = new System.Drawing.Size(75, 23);
            this.ShowMapButton.TabIndex = 14;
            this.ShowMapButton.TabStop = false;
            this.ShowMapButton.Text = "Map Display";
            this.ShowMapButton.UseVisualStyleBackColor = true;
            this.ShowMapButton.Click += new System.EventHandler(this.ShowMapButton_Click);
            // 
            // renderProgress
            // 
            this.renderProgress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.renderProgress.Location = new System.Drawing.Point(842, 30);
            this.renderProgress.Name = "renderProgress";
            this.renderProgress.Size = new System.Drawing.Size(157, 23);
            this.renderProgress.TabIndex = 15;
            this.renderProgress.Visible = false;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.Location = new System.Drawing.Point(9, 612);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Location :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // locationLabel
            // 
            this.locationLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.locationLabel.Location = new System.Drawing.Point(69, 612);
            this.locationLabel.Name = "locationLabel";
            this.locationLabel.Size = new System.Drawing.Size(79, 20);
            this.locationLabel.TabIndex = 4;
            this.locationLabel.Text = "0, 0";
            this.locationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.Location = new System.Drawing.Point(388, 612);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Map Scale";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // facetView
            // 
            this.facetView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.facetView.Location = new System.Drawing.Point(601, 57);
            this.facetView.Name = "facetView";
            this.facetView.Size = new System.Drawing.Size(398, 513);
            this.facetView.TabIndex = 16;
            this.facetView.TabStop = false;
            this.facetView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.facetView_AfterSelect);
            this.facetView.DoubleClick += new System.EventHandler(this.facetView_DoubleClick);
            // 
            // newRegion
            // 
            this.newRegion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.newRegion.Location = new System.Drawing.Point(601, 570);
            this.newRegion.Name = "newRegion";
            this.newRegion.Size = new System.Drawing.Size(95, 20);
            this.newRegion.TabIndex = 17;
            this.newRegion.TabStop = false;
            this.newRegion.Text = "New Region";
            this.newRegion.UseVisualStyleBackColor = true;
            this.newRegion.Click += new System.EventHandler(this.newRegion_Click);
            // 
            // modifyRegion
            // 
            this.modifyRegion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.modifyRegion.Enabled = false;
            this.modifyRegion.Location = new System.Drawing.Point(803, 570);
            this.modifyRegion.Name = "modifyRegion";
            this.modifyRegion.Size = new System.Drawing.Size(95, 20);
            this.modifyRegion.TabIndex = 19;
            this.modifyRegion.TabStop = false;
            this.modifyRegion.Text = "Modify Region";
            this.modifyRegion.UseVisualStyleBackColor = true;
            this.modifyRegion.Click += new System.EventHandler(this.modifyRegion_Click);
            // 
            // removeRegion
            // 
            this.removeRegion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.removeRegion.Enabled = false;
            this.removeRegion.Location = new System.Drawing.Point(904, 570);
            this.removeRegion.Name = "removeRegion";
            this.removeRegion.Size = new System.Drawing.Size(95, 20);
            this.removeRegion.TabIndex = 20;
            this.removeRegion.TabStop = false;
            this.removeRegion.Text = "Remove Region";
            this.removeRegion.UseVisualStyleBackColor = true;
            this.removeRegion.Click += new System.EventHandler(this.removeRegion_Click);
            // 
            // addSpawn
            // 
            this.addSpawn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addSpawn.Enabled = false;
            this.addSpawn.Location = new System.Drawing.Point(601, 591);
            this.addSpawn.Name = "addSpawn";
            this.addSpawn.Size = new System.Drawing.Size(95, 20);
            this.addSpawn.TabIndex = 21;
            this.addSpawn.TabStop = false;
            this.addSpawn.Text = "Add Spawn";
            this.addSpawn.UseVisualStyleBackColor = true;
            this.addSpawn.Click += new System.EventHandler(this.addSpawn_Click);
            // 
            // removeSpawn
            // 
            this.removeSpawn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.removeSpawn.Enabled = false;
            this.removeSpawn.Location = new System.Drawing.Point(803, 591);
            this.removeSpawn.Name = "removeSpawn";
            this.removeSpawn.Size = new System.Drawing.Size(95, 20);
            this.removeSpawn.TabIndex = 23;
            this.removeSpawn.TabStop = false;
            this.removeSpawn.Text = "Remove Spawn";
            this.removeSpawn.UseVisualStyleBackColor = true;
            this.removeSpawn.Click += new System.EventHandler(this.removeSpawn_Click);
            // 
            // addSubRegion
            // 
            this.addSubRegion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addSubRegion.Enabled = false;
            this.addSubRegion.Location = new System.Drawing.Point(702, 570);
            this.addSubRegion.Name = "addSubRegion";
            this.addSubRegion.Size = new System.Drawing.Size(95, 20);
            this.addSubRegion.TabIndex = 18;
            this.addSubRegion.TabStop = false;
            this.addSubRegion.Text = "Add SubRegion";
            this.addSubRegion.UseVisualStyleBackColor = true;
            this.addSubRegion.Click += new System.EventHandler(this.addSubRegion_Click);
            // 
            // addArea
            // 
            this.addArea.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addArea.Enabled = false;
            this.addArea.Location = new System.Drawing.Point(904, 591);
            this.addArea.Name = "addArea";
            this.addArea.Size = new System.Drawing.Size(95, 20);
            this.addArea.TabIndex = 24;
            this.addArea.TabStop = false;
            this.addArea.Text = "Add Area";
            this.addArea.UseVisualStyleBackColor = true;
            this.addArea.Click += new System.EventHandler(this.addArea_Click);
            // 
            // removeArea
            // 
            this.removeArea.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.removeArea.Enabled = false;
            this.removeArea.Location = new System.Drawing.Point(702, 612);
            this.removeArea.Name = "removeArea";
            this.removeArea.Size = new System.Drawing.Size(95, 20);
            this.removeArea.TabIndex = 26;
            this.removeArea.TabStop = false;
            this.removeArea.Text = "Remove Area";
            this.removeArea.UseVisualStyleBackColor = true;
            this.removeArea.Click += new System.EventHandler(this.removeArea_Click);
            // 
            // areaModify
            // 
            this.areaModify.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.areaModify.Enabled = false;
            this.areaModify.Location = new System.Drawing.Point(601, 612);
            this.areaModify.Name = "areaModify";
            this.areaModify.Size = new System.Drawing.Size(95, 20);
            this.areaModify.TabIndex = 25;
            this.areaModify.TabStop = false;
            this.areaModify.Text = "Modify Area";
            this.areaModify.UseVisualStyleBackColor = true;
            this.areaModify.Click += new System.EventHandler(this.areaModify_Click);
            // 
            // modifySpawn
            // 
            this.modifySpawn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.modifySpawn.Enabled = false;
            this.modifySpawn.Location = new System.Drawing.Point(702, 591);
            this.modifySpawn.Name = "modifySpawn";
            this.modifySpawn.Size = new System.Drawing.Size(95, 20);
            this.modifySpawn.TabIndex = 22;
            this.modifySpawn.TabStop = false;
            this.modifySpawn.Text = "Modify Spawn";
            this.modifySpawn.UseVisualStyleBackColor = true;
            this.modifySpawn.Click += new System.EventHandler(this.modifySpawn_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.Location = new System.Drawing.Point(154, 612);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "X";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.Location = new System.Drawing.Point(213, 612);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Y";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // goButton
            // 
            this.goButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.goButton.Location = new System.Drawing.Point(271, 612);
            this.goButton.Name = "goButton";
            this.goButton.Size = new System.Drawing.Size(32, 20);
            this.goButton.TabIndex = 9;
            this.goButton.Text = "Go";
            this.goButton.UseVisualStyleBackColor = true;
            this.goButton.Click += new System.EventHandler(this.goButton_Click);
            // 
            // clearFacet
            // 
            this.clearFacet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.clearFacet.Location = new System.Drawing.Point(904, 612);
            this.clearFacet.Name = "clearFacet";
            this.clearFacet.Size = new System.Drawing.Size(95, 20);
            this.clearFacet.TabIndex = 27;
            this.clearFacet.TabStop = false;
            this.clearFacet.Text = "Clear Facet";
            this.clearFacet.UseVisualStyleBackColor = true;
            this.clearFacet.Click += new System.EventHandler(this.clearFacet_Click);
            // 
            // goY
            // 
            this.goY.AllowedChars = "1234567890";
            this.goY.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.goY.Location = new System.Drawing.Point(233, 612);
            this.goY.MaxLength = 4;
            this.goY.Name = "goY";
            this.goY.Size = new System.Drawing.Size(32, 20);
            this.goY.TabIndex = 8;
            // 
            // goX
            // 
            this.goX.AllowedChars = "1234567890";
            this.goX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.goX.Location = new System.Drawing.Point(174, 612);
            this.goX.MaxLength = 4;
            this.goX.Name = "goX";
            this.goX.Size = new System.Drawing.Size(32, 20);
            this.goX.TabIndex = 6;
            // 
            // scaleSlider
            // 
            this.scaleSlider.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.scaleSlider.Location = new System.Drawing.Point(452, 611);
            this.scaleSlider.Maximum = 6;
            this.scaleSlider.MaximumSize = new System.Drawing.Size(1000, 22);
            this.scaleSlider.MinimumSize = new System.Drawing.Size(100, 22);
            this.scaleSlider.Name = "scaleSlider";
            this.scaleSlider.Size = new System.Drawing.Size(100, 22);
            this.scaleSlider.TabIndex = 11;
            this.scaleSlider.TabStop = false;
            this.scaleSlider.SliderMoveComplete += new System.EventHandler(this.scaleSlider_SliderMoveComplete);
            // 
            // ySlider
            // 
            this.ySlider.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ySlider.Location = new System.Drawing.Point(558, 30);
            this.ySlider.MaximumSize = new System.Drawing.Size(22, 1000);
            this.ySlider.MinimumSize = new System.Drawing.Size(22, 100);
            this.ySlider.Name = "ySlider";
            this.ySlider.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.ySlider.Size = new System.Drawing.Size(22, 540);
            this.ySlider.SmallChange = 5;
            this.ySlider.TabIndex = 1;
            this.ySlider.TabStop = false;
            this.ySlider.ValueChanged += new System.EventHandler(this.Slider_ValueChanged);
            this.ySlider.SliderMoveComplete += new System.EventHandler(this.Slider_SliderMoveComplete);
            // 
            // xSlider
            // 
            this.xSlider.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.xSlider.Location = new System.Drawing.Point(12, 576);
            this.xSlider.MaximumSize = new System.Drawing.Size(2000, 22);
            this.xSlider.MinimumSize = new System.Drawing.Size(100, 22);
            this.xSlider.Name = "xSlider";
            this.xSlider.Size = new System.Drawing.Size(540, 22);
            this.xSlider.SmallChange = 5;
            this.xSlider.TabIndex = 2;
            this.xSlider.TabStop = false;
            this.xSlider.ValueChanged += new System.EventHandler(this.Slider_ValueChanged);
            this.xSlider.SliderMoveComplete += new System.EventHandler(this.Slider_SliderMoveComplete);
            // 
            // mapDisplay
            // 
            this.mapDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mapDisplay.Location = new System.Drawing.Point(12, 30);
            this.mapDisplay.MapScale = Region_Editor.Scaling.Scale30;
            this.mapDisplay.Name = "mapDisplay";
            this.mapDisplay.Size = new System.Drawing.Size(540, 540);
            this.mapDisplay.TabIndex = 6;
            this.mapDisplay.TabStop = false;
            this.mapDisplay.HoverCoordinatedChanged += new System.EventHandler(this.mapDisplay_HoverCoordinatedChanged);
            // 
            // RegionEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 637);
            this.Controls.Add(this.clearFacet);
            this.Controls.Add(this.goButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.goY);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.goX);
            this.Controls.Add(this.modifySpawn);
            this.Controls.Add(this.areaModify);
            this.Controls.Add(this.removeArea);
            this.Controls.Add(this.addArea);
            this.Controls.Add(this.addSubRegion);
            this.Controls.Add(this.removeSpawn);
            this.Controls.Add(this.addSpawn);
            this.Controls.Add(this.removeRegion);
            this.Controls.Add(this.modifyRegion);
            this.Controls.Add(this.newRegion);
            this.Controls.Add(this.facetView);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.scaleSlider);
            this.Controls.Add(this.ySlider);
            this.Controls.Add(this.xSlider);
            this.Controls.Add(this.locationLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mapDisplay);
            this.Controls.Add(this.renderProgress);
            this.Controls.Add(this.ShowMapButton);
            this.Controls.Add(this.facetList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "RegionEditor";
            this.Text = "Region Editor 1.0";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RegionEditor_FormClosing);
            this.Shown += new System.EventHandler(this.RegionEditor_Shown);
            this.Resize += new System.EventHandler(this.RegionEditor_Resize);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mapDisplay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mULFilePathToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ShowMapButton;
        private System.Windows.Forms.ProgressBar renderProgress;
        private MapDisplay mapDisplay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label locationLabel;
        private Slider xSlider;
        private Slider ySlider;
        private Slider scaleSlider;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem regionsxmlLocationToolStripMenuItem;
        private System.Windows.Forms.TreeView facetView;
        private System.Windows.Forms.Button newRegion;
        private System.Windows.Forms.Button modifyRegion;
        private System.Windows.Forms.Button removeRegion;
        private System.Windows.Forms.Button addSpawn;
        private System.Windows.Forms.Button removeSpawn;
        private System.Windows.Forms.Button addSubRegion;
        private System.Windows.Forms.Button addArea;
        private System.Windows.Forms.Button removeArea;
        private System.Windows.Forms.Button areaModify;
        private System.Windows.Forms.Button modifySpawn;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem reloadRegionsFromFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveRegionsToFileToolStripMenuItem;
        private FilteredTextBox goX;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private FilteredTextBox goY;
        private System.Windows.Forms.Button goButton;
        private System.Windows.Forms.Button clearFacet;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem compatible;
        internal System.Windows.Forms.ComboBox facetList;
    }
}

