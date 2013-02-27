namespace Region_Editor
{
    partial class ModifyRegion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModifyRegion));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.regionType = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.music = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.disableLogoutDelay = new System.Windows.Forms.CheckBox();
            this.disableGuards = new System.Windows.Forms.CheckBox();
            this.smartNoHousing = new System.Windows.Forms.CheckBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.questType = new Region_Editor.FilteredTextBox();
            this.questMessage = new Region_Editor.FilteredTextBox();
            this.questComplete = new Region_Editor.FilteredTextBox();
            this.questIncomplete = new Region_Editor.FilteredTextBox();
            this.setButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.minZRange = new Region_Editor.FilteredTextBox();
            this.entranceY = new Region_Editor.FilteredTextBox();
            this.entranceX = new Region_Editor.FilteredTextBox();
            this.goZ = new Region_Editor.FilteredTextBox();
            this.goY = new Region_Editor.FilteredTextBox();
            this.goX = new Region_Editor.FilteredTextBox();
            this.runeName = new Region_Editor.FilteredTextBox();
            this.priority = new Region_Editor.FilteredTextBox();
            this.regionName = new Region_Editor.FilteredTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Region Name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(258, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Priority";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(4, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Region Type";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // regionType
            // 
            this.regionType.FormattingEnabled = true;
            this.regionType.Location = new System.Drawing.Point(90, 25);
            this.regionType.Name = "regionType";
            this.regionType.Size = new System.Drawing.Size(223, 21);
            this.regionType.Sorted = true;
            this.regionType.TabIndex = 5;
            this.regionType.TextChanged += new System.EventHandler(this.regionType_TextChanged);
            this.regionType.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.regionType_KeyPress);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(4, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Rune Name";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // music
            // 
            this.music.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.music.FormattingEnabled = true;
            this.music.Location = new System.Drawing.Point(90, 68);
            this.music.Name = "music";
            this.music.Size = new System.Drawing.Size(223, 21);
            this.music.Sorted = true;
            this.music.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(4, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Music";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(4, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Go Location";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(90, 90);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(15, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = "X";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(148, 90);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(15, 20);
            this.label8.TabIndex = 13;
            this.label8.Text = "Y";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(210, 90);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(15, 20);
            this.label9.TabIndex = 15;
            this.label9.Text = "Z";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(148, 111);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(15, 20);
            this.label10.TabIndex = 20;
            this.label10.Text = "Y";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(90, 111);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(15, 20);
            this.label11.TabIndex = 18;
            this.label11.Text = "X";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(4, 111);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(59, 20);
            this.label12.TabIndex = 17;
            this.label12.Text = "Entrance";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // disableLogoutDelay
            // 
            this.disableLogoutDelay.AutoSize = true;
            this.disableLogoutDelay.Location = new System.Drawing.Point(7, 132);
            this.disableLogoutDelay.Name = "disableLogoutDelay";
            this.disableLogoutDelay.Size = new System.Drawing.Size(127, 17);
            this.disableLogoutDelay.TabIndex = 24;
            this.disableLogoutDelay.Text = "Disable Logout Delay";
            this.disableLogoutDelay.UseVisualStyleBackColor = true;
            // 
            // disableGuards
            // 
            this.disableGuards.AutoSize = true;
            this.disableGuards.Location = new System.Drawing.Point(7, 150);
            this.disableGuards.Name = "disableGuards";
            this.disableGuards.Size = new System.Drawing.Size(98, 17);
            this.disableGuards.TabIndex = 25;
            this.disableGuards.Text = "Disable Guards";
            this.disableGuards.UseVisualStyleBackColor = true;
            // 
            // smartNoHousing
            // 
            this.smartNoHousing.AutoSize = true;
            this.smartNoHousing.Location = new System.Drawing.Point(7, 168);
            this.smartNoHousing.Name = "smartNoHousing";
            this.smartNoHousing.Size = new System.Drawing.Size(112, 17);
            this.smartNoHousing.TabIndex = 26;
            this.smartNoHousing.Text = "Smart No Housing";
            this.smartNoHousing.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(4, 16);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(68, 20);
            this.label14.TabIndex = 0;
            this.label14.Text = "Quest Type";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label15
            // 
            this.label15.Location = new System.Drawing.Point(4, 37);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(144, 20);
            this.label15.TabIndex = 2;
            this.label15.Text = "Quest Objective (Incomplete)";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label16
            // 
            this.label16.Location = new System.Drawing.Point(4, 58);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(144, 20);
            this.label16.TabIndex = 4;
            this.label16.Text = "Quest Objective (Complete)";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label17
            // 
            this.label17.Location = new System.Drawing.Point(4, 79);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(88, 20);
            this.label17.TabIndex = 6;
            this.label17.Text = "Quest Message";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.questType);
            this.groupBox1.Controls.Add(this.questMessage);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.questComplete);
            this.groupBox1.Controls.Add(this.questIncomplete);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Location = new System.Drawing.Point(7, 186);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(383, 104);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Quest Region Fields";
            // 
            // questType
            // 
            this.questType.AllowedChars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890_";
            this.questType.Location = new System.Drawing.Point(154, 16);
            this.questType.MaxLength = 255;
            this.questType.Name = "questType";
            this.questType.Size = new System.Drawing.Size(223, 20);
            this.questType.TabIndex = 1;
            // 
            // questMessage
            // 
            this.questMessage.AllowedChars = "1234567890";
            this.questMessage.Location = new System.Drawing.Point(154, 79);
            this.questMessage.MaxLength = 8;
            this.questMessage.Name = "questMessage";
            this.questMessage.Size = new System.Drawing.Size(110, 20);
            this.questMessage.TabIndex = 7;
            // 
            // questComplete
            // 
            this.questComplete.AllowedChars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890_";
            this.questComplete.Location = new System.Drawing.Point(154, 58);
            this.questComplete.MaxLength = 255;
            this.questComplete.Name = "questComplete";
            this.questComplete.Size = new System.Drawing.Size(223, 20);
            this.questComplete.TabIndex = 5;
            // 
            // questIncomplete
            // 
            this.questIncomplete.AllowedChars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890_";
            this.questIncomplete.Location = new System.Drawing.Point(154, 37);
            this.questIncomplete.MaxLength = 255;
            this.questIncomplete.Name = "questIncomplete";
            this.questIncomplete.Size = new System.Drawing.Size(223, 20);
            this.questIncomplete.TabIndex = 3;
            // 
            // setButton
            // 
            this.setButton.Location = new System.Drawing.Point(119, 296);
            this.setButton.Name = "setButton";
            this.setButton.Size = new System.Drawing.Size(75, 23);
            this.setButton.TabIndex = 28;
            this.setButton.Text = "Set";
            this.setButton.UseVisualStyleBackColor = true;
            this.setButton.Click += new System.EventHandler(this.setButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(200, 296);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 29;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // minZRange
            // 
            this.minZRange.AllowedChars = "1234567890-";
            this.minZRange.Location = new System.Drawing.Point(251, 111);
            this.minZRange.MaxLength = 3;
            this.minZRange.Name = "minZRange";
            this.minZRange.Size = new System.Drawing.Size(34, 20);
            this.minZRange.TabIndex = 23;
            // 
            // entranceY
            // 
            this.entranceY.AllowedChars = "1234567890";
            this.entranceY.Location = new System.Drawing.Point(170, 111);
            this.entranceY.MaxLength = 4;
            this.entranceY.Name = "entranceY";
            this.entranceY.Size = new System.Drawing.Size(35, 20);
            this.entranceY.TabIndex = 21;
            // 
            // entranceX
            // 
            this.entranceX.AllowedChars = "1234567890";
            this.entranceX.Location = new System.Drawing.Point(107, 111);
            this.entranceX.MaxLength = 4;
            this.entranceX.Name = "entranceX";
            this.entranceX.Size = new System.Drawing.Size(35, 20);
            this.entranceX.TabIndex = 19;
            // 
            // goZ
            // 
            this.goZ.AllowedChars = "1234567890-";
            this.goZ.Location = new System.Drawing.Point(231, 90);
            this.goZ.MaxLength = 4;
            this.goZ.Name = "goZ";
            this.goZ.Size = new System.Drawing.Size(35, 20);
            this.goZ.TabIndex = 16;
            // 
            // goY
            // 
            this.goY.AllowedChars = "1234567890";
            this.goY.Location = new System.Drawing.Point(169, 90);
            this.goY.MaxLength = 4;
            this.goY.Name = "goY";
            this.goY.Size = new System.Drawing.Size(35, 20);
            this.goY.TabIndex = 14;
            // 
            // goX
            // 
            this.goX.AllowedChars = "1234567890";
            this.goX.Location = new System.Drawing.Point(107, 90);
            this.goX.MaxLength = 4;
            this.goX.Name = "goX";
            this.goX.Size = new System.Drawing.Size(35, 20);
            this.goX.TabIndex = 12;
            // 
            // runeName
            // 
            this.runeName.Location = new System.Drawing.Point(90, 47);
            this.runeName.MaxLength = 255;
            this.runeName.Name = "runeName";
            this.runeName.Size = new System.Drawing.Size(162, 20);
            this.runeName.TabIndex = 7;
            // 
            // priority
            // 
            this.priority.AllowedChars = "1234567890";
            this.priority.Location = new System.Drawing.Point(302, 4);
            this.priority.MaxLength = 3;
            this.priority.Name = "priority";
            this.priority.Size = new System.Drawing.Size(34, 20);
            this.priority.TabIndex = 3;
            // 
            // regionName
            // 
            this.regionName.Location = new System.Drawing.Point(90, 4);
            this.regionName.MaxLength = 255;
            this.regionName.Name = "regionName";
            this.regionName.Size = new System.Drawing.Size(162, 20);
            this.regionName.TabIndex = 1;
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(210, 111);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(35, 20);
            this.label13.TabIndex = 30;
            this.label13.Text = "Z Min";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ModifyRegion
            // 
            this.AcceptButton = this.setButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(395, 320);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.setButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.smartNoHousing);
            this.Controls.Add(this.disableGuards);
            this.Controls.Add(this.disableLogoutDelay);
            this.Controls.Add(this.minZRange);
            this.Controls.Add(this.entranceY);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.entranceX);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.goZ);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.goY);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.goX);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.music);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.runeName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.regionType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.priority);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.regionName);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ModifyRegion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add/Modify Region";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private FilteredTextBox regionName;
        private System.Windows.Forms.Label label2;
        private FilteredTextBox priority;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox regionType;
        private FilteredTextBox runeName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox music;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private FilteredTextBox goX;
        private FilteredTextBox goY;
        private System.Windows.Forms.Label label8;
        private FilteredTextBox goZ;
        private System.Windows.Forms.Label label9;
        private FilteredTextBox entranceY;
        private System.Windows.Forms.Label label10;
        private FilteredTextBox entranceX;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private FilteredTextBox minZRange;
        private System.Windows.Forms.CheckBox disableLogoutDelay;
        private System.Windows.Forms.CheckBox disableGuards;
        private System.Windows.Forms.CheckBox smartNoHousing;
        private System.Windows.Forms.Label label14;
        private FilteredTextBox questType;
        private FilteredTextBox questIncomplete;
        private System.Windows.Forms.Label label15;
        private FilteredTextBox questComplete;
        private System.Windows.Forms.Label label16;
        private FilteredTextBox questMessage;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button setButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label label13;
    }
}