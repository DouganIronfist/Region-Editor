namespace Region_Editor
{
    partial class SpecifyArea
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SpecifyArea));
            this.label1 = new System.Windows.Forms.Label();
            this.x = new Region_Editor.FilteredTextBox();
            this.setbutton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.y = new Region_Editor.FilteredTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.w = new Region_Editor.FilteredTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.h = new Region_Editor.FilteredTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ZMin = new Region_Editor.FilteredTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "X";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // x
            // 
            this.x.AllowedChars = "1234567890";
            this.x.Location = new System.Drawing.Point(30, 4);
            this.x.MaxLength = 4;
            this.x.Name = "x";
            this.x.Size = new System.Drawing.Size(43, 20);
            this.x.TabIndex = 1;
            // 
            // setbutton
            // 
            this.setbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.setbutton.Location = new System.Drawing.Point(432, 4);
            this.setbutton.Name = "setbutton";
            this.setbutton.Size = new System.Drawing.Size(42, 20);
            this.setbutton.TabIndex = 10;
            this.setbutton.TabStop = false;
            this.setbutton.Text = "Set";
            this.setbutton.UseVisualStyleBackColor = true;
            this.setbutton.Click += new System.EventHandler(this.setbutton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(480, 4);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(53, 20);
            this.cancelButton.TabIndex = 11;
            this.cancelButton.TabStop = false;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // y
            // 
            this.y.AllowedChars = "1234567890";
            this.y.Location = new System.Drawing.Point(102, 4);
            this.y.MaxLength = 4;
            this.y.Name = "y";
            this.y.Size = new System.Drawing.Size(43, 20);
            this.y.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(79, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Y";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // w
            // 
            this.w.AllowedChars = "1234567890";
            this.w.Location = new System.Drawing.Point(192, 4);
            this.w.MaxLength = 4;
            this.w.Name = "w";
            this.w.Size = new System.Drawing.Size(43, 20);
            this.w.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(151, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Width";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // h
            // 
            this.h.AllowedChars = "1234567890";
            this.h.Location = new System.Drawing.Point(285, 4);
            this.h.MaxLength = 4;
            this.h.Name = "h";
            this.h.Size = new System.Drawing.Size(43, 20);
            this.h.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(241, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Height";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ZMin
            // 
            this.ZMin.AllowedChars = "1234567890-";
            this.ZMin.Location = new System.Drawing.Point(374, 4);
            this.ZMin.MaxLength = 4;
            this.ZMin.Name = "ZMin";
            this.ZMin.Size = new System.Drawing.Size(43, 20);
            this.ZMin.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(334, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Z Min";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SpecifyArea
            // 
            this.AcceptButton = this.setbutton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(538, 27);
            this.Controls.Add(this.ZMin);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.h);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.w);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.y);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.setbutton);
            this.Controls.Add(this.x);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SpecifyArea";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Specify Region Area";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private FilteredTextBox x;
        private System.Windows.Forms.Button setbutton;
        private System.Windows.Forms.Button cancelButton;
        private FilteredTextBox y;
        private System.Windows.Forms.Label label2;
        private FilteredTextBox w;
        private System.Windows.Forms.Label label3;
        private FilteredTextBox h;
        private System.Windows.Forms.Label label4;
        private FilteredTextBox ZMin;
        private System.Windows.Forms.Label label5;
    }
}