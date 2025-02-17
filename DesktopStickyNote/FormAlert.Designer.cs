using DesktopStickyNote.Properties;

namespace DesktopStickyNote
{
    partial class FormAlert
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
            this.panelBarLeft = new System.Windows.Forms.Panel();
            this.panelBarRight = new System.Windows.Forms.Panel();
            this.panelBarButtom = new System.Windows.Forms.Panel();
            this.panelBarTop = new System.Windows.Forms.Panel();
            this.labelCategory = new System.Windows.Forms.Label();
            this.richTextBoxMessage = new System.Windows.Forms.RichTextBox();
            this.buttonRemainLater = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelRemainAfter = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelEventDate = new System.Windows.Forms.Label();
            this.linkLabelRemoveEvent = new System.Windows.Forms.LinkLabel();
            this.linkLabelNextDay = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBarLeft
            // 
            this.panelBarLeft.BackColor = System.Drawing.SystemColors.Control;
            this.panelBarLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelBarLeft.Location = new System.Drawing.Point(0, 0);
            this.panelBarLeft.Name = "panelBarLeft";
            this.panelBarLeft.Size = new System.Drawing.Size(2, 196);
            this.panelBarLeft.TabIndex = 1;
            // 
            // panelBarRight
            // 
            this.panelBarRight.BackColor = System.Drawing.SystemColors.Control;
            this.panelBarRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelBarRight.Location = new System.Drawing.Point(399, 0);
            this.panelBarRight.Name = "panelBarRight";
            this.panelBarRight.Size = new System.Drawing.Size(2, 196);
            this.panelBarRight.TabIndex = 3;
            // 
            // panelBarButtom
            // 
            this.panelBarButtom.BackColor = System.Drawing.SystemColors.Control;
            this.panelBarButtom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBarButtom.Location = new System.Drawing.Point(2, 194);
            this.panelBarButtom.Name = "panelBarButtom";
            this.panelBarButtom.Size = new System.Drawing.Size(397, 2);
            this.panelBarButtom.TabIndex = 5;
            // 
            // panelBarTop
            // 
            this.panelBarTop.BackColor = System.Drawing.SystemColors.Control;
            this.panelBarTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBarTop.Location = new System.Drawing.Point(2, 0);
            this.panelBarTop.Name = "panelBarTop";
            this.panelBarTop.Size = new System.Drawing.Size(397, 4);
            this.panelBarTop.TabIndex = 6;
            // 
            // labelCategory
            // 
            this.labelCategory.BackColor = System.Drawing.Color.Transparent;
            this.labelCategory.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.labelCategory.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelCategory.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCategory.ForeColor = System.Drawing.Color.White;
            this.labelCategory.Location = new System.Drawing.Point(2, 4);
            this.labelCategory.Name = "labelCategory";
            this.labelCategory.Size = new System.Drawing.Size(397, 49);
            this.labelCategory.TabIndex = 7;
            this.labelCategory.Text = "Category";
            this.labelCategory.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelCategory_MouseDown);
            this.labelCategory.MouseMove += new System.Windows.Forms.MouseEventHandler(this.labelCategory_MouseMove);
            this.labelCategory.MouseUp += new System.Windows.Forms.MouseEventHandler(this.labelCategory_MouseUp);
            // 
            // richTextBoxMessage
            // 
            this.richTextBoxMessage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(54)))), ((int)(((byte)(60)))));
            this.richTextBoxMessage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxMessage.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxMessage.ForeColor = System.Drawing.Color.Gold;
            this.richTextBoxMessage.Location = new System.Drawing.Point(49, 56);
            this.richTextBoxMessage.Name = "richTextBoxMessage";
            this.richTextBoxMessage.ReadOnly = true;
            this.richTextBoxMessage.Size = new System.Drawing.Size(340, 79);
            this.richTextBoxMessage.TabIndex = 10;
            this.richTextBoxMessage.Text = "Message/Details";
            // 
            // buttonRemainLater
            // 
            this.buttonRemainLater.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRemainLater.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonRemainLater.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRemainLater.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRemainLater.ForeColor = System.Drawing.Color.Yellow;
            this.buttonRemainLater.Location = new System.Drawing.Point(250, 152);
            this.buttonRemainLater.Name = "buttonRemainLater";
            this.buttonRemainLater.Size = new System.Drawing.Size(144, 36);
            this.buttonRemainLater.TabIndex = 0;
            this.buttonRemainLater.Text = "Remain Later";
            this.buttonRemainLater.UseVisualStyleBackColor = true;
            this.buttonRemainLater.Click += new System.EventHandler(this.buttonRemainLater_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(9, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "Event Date";
            // 
            // labelRemainAfter
            // 
            this.labelRemainAfter.AutoSize = true;
            this.labelRemainAfter.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRemainAfter.ForeColor = System.Drawing.Color.White;
            this.labelRemainAfter.Location = new System.Drawing.Point(251, 136);
            this.labelRemainAfter.Name = "labelRemainAfter";
            this.labelRemainAfter.Size = new System.Drawing.Size(140, 12);
            this.labelRemainAfter.TabIndex = 15;
            this.labelRemainAfter.Text = "Next alert after 00.05 hour";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DesktopStickyNote.Properties.Resources.group_message_64;
            this.pictureBox1.Location = new System.Drawing.Point(8, 57);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // labelEventDate
            // 
            this.labelEventDate.AutoSize = true;
            this.labelEventDate.BackColor = System.Drawing.Color.Transparent;
            this.labelEventDate.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEventDate.ForeColor = System.Drawing.Color.Gold;
            this.labelEventDate.Location = new System.Drawing.Point(9, 153);
            this.labelEventDate.Name = "labelEventDate";
            this.labelEventDate.Size = new System.Drawing.Size(83, 16);
            this.labelEventDate.TabIndex = 14;
            this.labelEventDate.Text = "04-Jan-95";
            // 
            // linkLabelRemoveEvent
            // 
            this.linkLabelRemoveEvent.AutoSize = true;
            this.linkLabelRemoveEvent.Font = new System.Drawing.Font("Verdana", 6.75F);
            this.linkLabelRemoveEvent.LinkColor = System.Drawing.Color.Tomato;
            this.linkLabelRemoveEvent.Location = new System.Drawing.Point(9, 175);
            this.linkLabelRemoveEvent.Name = "linkLabelRemoveEvent";
            this.linkLabelRemoveEvent.Size = new System.Drawing.Size(107, 12);
            this.linkLabelRemoveEvent.TabIndex = 17;
            this.linkLabelRemoveEvent.TabStop = true;
            this.linkLabelRemoveEvent.Text = "Done/Remove Event";
            this.linkLabelRemoveEvent.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelRemoveEvent_LinkClicked);
            // 
            // linkLabelNextDay
            // 
            this.linkLabelNextDay.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelNextDay.LinkColor = System.Drawing.Color.Yellow;
            this.linkLabelNextDay.Location = new System.Drawing.Point(121, 152);
            this.linkLabelNextDay.Name = "linkLabelNextDay";
            this.linkLabelNextDay.Size = new System.Drawing.Size(124, 35);
            this.linkLabelNextDay.TabIndex = 18;
            this.linkLabelNextDay.TabStop = true;
            this.linkLabelNextDay.Text = "Next Day";
            this.linkLabelNextDay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.linkLabelNextDay.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelNextDay_LinkClicked);
            // 
            // FormAlert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(54)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(401, 196);
            this.Controls.Add(this.linkLabelNextDay);
            this.Controls.Add(this.linkLabelRemoveEvent);
            this.Controls.Add(this.labelEventDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonRemainLater);
            this.Controls.Add(this.richTextBoxMessage);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelCategory);
            this.Controls.Add(this.panelBarTop);
            this.Controls.Add(this.panelBarButtom);
            this.Controls.Add(this.panelBarRight);
            this.Controls.Add(this.panelBarLeft);
            this.Controls.Add(this.labelRemainAfter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAlert";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAlert";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelBarLeft;
        private System.Windows.Forms.Panel panelBarRight;
        private System.Windows.Forms.Panel panelBarButtom;
        private System.Windows.Forms.Panel panelBarTop;
        private System.Windows.Forms.Label labelCategory;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RichTextBox richTextBoxMessage;
        private System.Windows.Forms.Button buttonRemainLater;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelRemainAfter;
        private System.Windows.Forms.Label labelEventDate;
        private System.Windows.Forms.LinkLabel linkLabelRemoveEvent;
        private System.Windows.Forms.LinkLabel linkLabelNextDay;
    }
}