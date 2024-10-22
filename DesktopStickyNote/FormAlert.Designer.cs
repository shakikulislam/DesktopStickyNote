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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAlert));
            this.panelBarLeft = new System.Windows.Forms.Panel();
            this.panelBarRight = new System.Windows.Forms.Panel();
            this.panelBarButtom = new System.Windows.Forms.Panel();
            this.panelBarTop = new System.Windows.Forms.Panel();
            this.labelCategory = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.richTextBoxMessage = new System.Windows.Forms.RichTextBox();
            this.buttonRemainLater = new System.Windows.Forms.Button();
            this.buttonDone = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelToDate = new System.Windows.Forms.Label();
            this.labelRemainAfter = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
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
            this.panelBarRight.Location = new System.Drawing.Point(368, 0);
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
            this.panelBarButtom.Size = new System.Drawing.Size(366, 2);
            this.panelBarButtom.TabIndex = 5;
            // 
            // panelBarTop
            // 
            this.panelBarTop.BackColor = System.Drawing.SystemColors.Control;
            this.panelBarTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBarTop.Location = new System.Drawing.Point(2, 0);
            this.panelBarTop.Name = "panelBarTop";
            this.panelBarTop.Size = new System.Drawing.Size(366, 4);
            this.panelBarTop.TabIndex = 6;
            // 
            // labelCategory
            // 
            this.labelCategory.BackColor = System.Drawing.Color.Transparent;
            this.labelCategory.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelCategory.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCategory.ForeColor = System.Drawing.Color.White;
            this.labelCategory.Location = new System.Drawing.Point(2, 4);
            this.labelCategory.Name = "labelCategory";
            this.labelCategory.Size = new System.Drawing.Size(366, 49);
            this.labelCategory.TabIndex = 7;
            this.labelCategory.Text = "Category";
            this.labelCategory.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelCategory_MouseDown);
            this.labelCategory.MouseMove += new System.Windows.Forms.MouseEventHandler(this.labelCategory_MouseMove);
            this.labelCategory.MouseUp += new System.Windows.Forms.MouseEventHandler(this.labelCategory_MouseUp);
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
            // richTextBoxMessage
            // 
            this.richTextBoxMessage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(54)))), ((int)(((byte)(60)))));
            this.richTextBoxMessage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxMessage.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxMessage.ForeColor = System.Drawing.Color.Gold;
            this.richTextBoxMessage.Location = new System.Drawing.Point(49, 56);
            this.richTextBoxMessage.Name = "richTextBoxMessage";
            this.richTextBoxMessage.ReadOnly = true;
            this.richTextBoxMessage.Size = new System.Drawing.Size(313, 79);
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
            this.buttonRemainLater.Location = new System.Drawing.Point(219, 152);
            this.buttonRemainLater.Name = "buttonRemainLater";
            this.buttonRemainLater.Size = new System.Drawing.Size(144, 36);
            this.buttonRemainLater.TabIndex = 0;
            this.buttonRemainLater.Text = "Remain Later";
            this.buttonRemainLater.UseVisualStyleBackColor = true;
            this.buttonRemainLater.Click += new System.EventHandler(this.buttonRemainLater_Click);
            // 
            // buttonDone
            // 
            this.buttonDone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDone.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.buttonDone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDone.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDone.ForeColor = System.Drawing.Color.Yellow;
            this.buttonDone.Location = new System.Drawing.Point(111, 152);
            this.buttonDone.Name = "buttonDone";
            this.buttonDone.Size = new System.Drawing.Size(102, 36);
            this.buttonDone.TabIndex = 1;
            this.buttonDone.Text = "Done";
            this.buttonDone.UseVisualStyleBackColor = true;
            this.buttonDone.Click += new System.EventHandler(this.buttonDone_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(9, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "Last Date";
            // 
            // labelToDate
            // 
            this.labelToDate.AutoSize = true;
            this.labelToDate.BackColor = System.Drawing.Color.Transparent;
            this.labelToDate.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelToDate.ForeColor = System.Drawing.Color.Gold;
            this.labelToDate.Location = new System.Drawing.Point(9, 170);
            this.labelToDate.Name = "labelToDate";
            this.labelToDate.Size = new System.Drawing.Size(83, 16);
            this.labelToDate.TabIndex = 14;
            this.labelToDate.Text = "10-Jan-24";
            // 
            // labelRemainAfter
            // 
            this.labelRemainAfter.AutoSize = true;
            this.labelRemainAfter.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRemainAfter.ForeColor = System.Drawing.Color.White;
            this.labelRemainAfter.Location = new System.Drawing.Point(221, 136);
            this.labelRemainAfter.Name = "labelRemainAfter";
            this.labelRemainAfter.Size = new System.Drawing.Size(140, 12);
            this.labelRemainAfter.TabIndex = 15;
            this.labelRemainAfter.Text = "Next alert after 00.05 hour";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(124, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 16;
            this.label2.Text = "Remove Event";
            // 
            // FormAlert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(54)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(370, 196);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelToDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonDone);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAlert";
            this.ShowIcon = false;
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
        private System.Windows.Forms.Button buttonDone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelToDate;
        private System.Windows.Forms.Label labelRemainAfter;
        private System.Windows.Forms.Label label2;
    }
}