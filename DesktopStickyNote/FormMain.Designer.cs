﻿namespace DesktopStickyNote
{
    partial class FormMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.pictureBoxSettings = new System.Windows.Forms.PictureBox();
            this.panelFooter = new System.Windows.Forms.Panel();
            this.linkLabelTotalEvent = new System.Windows.Forms.LinkLabel();
            this.richTextBoxNote = new System.Windows.Forms.RichTextBox();
            this.toolTipMain = new System.Windows.Forms.ToolTip(this.components);
            this.timerRemainder = new System.Windows.Forms.Timer(this.components);
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSettings)).BeginInit();
            this.panelFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.LightGray;
            this.panelTitleBar.Controls.Add(this.pictureBoxLogo);
            this.panelTitleBar.Controls.Add(this.pictureBoxSettings);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(0, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(220, 40);
            this.panelTitleBar.TabIndex = 0;
            this.panelTitleBar.MouseLeave += new System.EventHandler(this.FormMain_MouseLeave);
            this.panelTitleBar.MouseHover += new System.EventHandler(this.FormMain_MouseHover);
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxLogo.Image = global::DesktopStickyNote.Properties.Resources.logo;
            this.pictureBoxLogo.Location = new System.Drawing.Point(5, 5);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(30, 30);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo.TabIndex = 4;
            this.pictureBoxLogo.TabStop = false;
            // 
            // pictureBoxSettings
            // 
            this.pictureBoxSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxSettings.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxSettings.Image = global::DesktopStickyNote.Properties.Resources.settings_32;
            this.pictureBoxSettings.Location = new System.Drawing.Point(187, 8);
            this.pictureBoxSettings.Name = "pictureBoxSettings";
            this.pictureBoxSettings.Size = new System.Drawing.Size(25, 25);
            this.pictureBoxSettings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxSettings.TabIndex = 3;
            this.pictureBoxSettings.TabStop = false;
            this.toolTipMain.SetToolTip(this.pictureBoxSettings, "Settings");
            this.pictureBoxSettings.Click += new System.EventHandler(this.pictureBoxSettings_Click);
            // 
            // panelFooter
            // 
            this.panelFooter.BackColor = System.Drawing.Color.LightGray;
            this.panelFooter.Controls.Add(this.linkLabelTotalEvent);
            this.panelFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFooter.Location = new System.Drawing.Point(0, 378);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Size = new System.Drawing.Size(220, 26);
            this.panelFooter.TabIndex = 1;
            this.panelFooter.MouseLeave += new System.EventHandler(this.FormMain_MouseLeave);
            this.panelFooter.MouseHover += new System.EventHandler(this.FormMain_MouseHover);
            // 
            // linkLabelTotalEvent
            // 
            this.linkLabelTotalEvent.AutoSize = true;
            this.linkLabelTotalEvent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLabelTotalEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelTotalEvent.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabelTotalEvent.Location = new System.Drawing.Point(5, 5);
            this.linkLabelTotalEvent.Name = "linkLabelTotalEvent";
            this.linkLabelTotalEvent.Size = new System.Drawing.Size(93, 16);
            this.linkLabelTotalEvent.TabIndex = 0;
            this.linkLabelTotalEvent.TabStop = true;
            this.linkLabelTotalEvent.Text = "Total Events 0";
            this.linkLabelTotalEvent.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelTotalEvent_LinkClicked);
            // 
            // richTextBoxNote
            // 
            this.richTextBoxNote.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxNote.BackColor = System.Drawing.SystemColors.Menu;
            this.richTextBoxNote.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxNote.Location = new System.Drawing.Point(6, 46);
            this.richTextBoxNote.Name = "richTextBoxNote";
            this.richTextBoxNote.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.richTextBoxNote.Size = new System.Drawing.Size(231, 326);
            this.richTextBoxNote.TabIndex = 2;
            this.richTextBoxNote.Text = "";
            this.richTextBoxNote.TextChanged += new System.EventHandler(this.richTextBoxNote_TextChanged);
            this.richTextBoxNote.MouseLeave += new System.EventHandler(this.FormMain_MouseLeave);
            this.richTextBoxNote.MouseHover += new System.EventHandler(this.FormMain_MouseHover);
            // 
            // timerRemainder
            // 
            this.timerRemainder.Enabled = true;
            this.timerRemainder.Interval = 1000;
            this.timerRemainder.Tick += new System.EventHandler(this.timerRemainder_Tick);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(220, 404);
            this.Controls.Add(this.richTextBoxNote);
            this.Controls.Add(this.panelFooter);
            this.Controls.Add(this.panelTitleBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.ShowInTaskbar = false;
            this.Text = "Desktop Sticky Note";
            this.TopMost = true;
            this.MouseLeave += new System.EventHandler(this.FormMain_MouseLeave);
            this.MouseHover += new System.EventHandler(this.FormMain_MouseHover);
            this.panelTitleBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSettings)).EndInit();
            this.panelFooter.ResumeLayout(false);
            this.panelFooter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Panel panelFooter;
        private System.Windows.Forms.PictureBox pictureBoxSettings;
        private System.Windows.Forms.ToolTip toolTipMain;
        private System.Windows.Forms.RichTextBox richTextBoxNote;
        private System.Windows.Forms.Timer timerRemainder;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.LinkLabel linkLabelTotalEvent;
    }
}

