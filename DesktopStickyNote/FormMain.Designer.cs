namespace DesktopStickyNote
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
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.panelFooter = new System.Windows.Forms.Panel();
            this.richTextBoxNote = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(0, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(223, 40);
            this.panelTitleBar.TabIndex = 0;
            this.panelTitleBar.MouseLeave += new System.EventHandler(this.FormMain_MouseLeave);
            this.panelTitleBar.MouseHover += new System.EventHandler(this.FormMain_MouseHover);
            // 
            // panelFooter
            // 
            this.panelFooter.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFooter.Location = new System.Drawing.Point(0, 497);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Size = new System.Drawing.Size(223, 40);
            this.panelFooter.TabIndex = 1;
            this.panelFooter.MouseLeave += new System.EventHandler(this.FormMain_MouseLeave);
            this.panelFooter.MouseHover += new System.EventHandler(this.FormMain_MouseHover);
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
            this.richTextBoxNote.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.richTextBoxNote.Size = new System.Drawing.Size(211, 445);
            this.richTextBoxNote.TabIndex = 2;
            this.richTextBoxNote.Text = "";
            this.richTextBoxNote.TextChanged += new System.EventHandler(this.richTextBoxNote_TextChanged);
            this.richTextBoxNote.MouseLeave += new System.EventHandler(this.FormMain_MouseLeave);
            this.richTextBoxNote.MouseHover += new System.EventHandler(this.FormMain_MouseHover);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(223, 537);
            this.Controls.Add(this.richTextBoxNote);
            this.Controls.Add(this.panelFooter);
            this.Controls.Add(this.panelTitleBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMain";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Desktop Sticky Note";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.MouseLeave += new System.EventHandler(this.FormMain_MouseLeave);
            this.MouseHover += new System.EventHandler(this.FormMain_MouseHover);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Panel panelFooter;
        private System.Windows.Forms.RichTextBox richTextBoxNote;
    }
}

