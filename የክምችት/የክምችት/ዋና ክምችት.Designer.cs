namespace የክምችት
{
    partial class ዋና_ክምችት
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
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.ቁሶችToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ክምችትToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ሪፖርትToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.የቁሶችዝርዝርሪፖርትToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.የክምችትዝርዘርሪፖርToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 431);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(659, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel.Text = "Status";
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ቁሶችToolStripMenuItem,
            this.ክምችትToolStripMenuItem,
            this.ሪፖርትToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(659, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // ቁሶችToolStripMenuItem
            // 
            this.ቁሶችToolStripMenuItem.Name = "ቁሶችToolStripMenuItem";
            this.ቁሶችToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.ቁሶችToolStripMenuItem.Text = "ቁሶች";
            this.ቁሶችToolStripMenuItem.Click += new System.EventHandler(this.ቁሶችToolStripMenuItem_Click);
            // 
            // ክምችትToolStripMenuItem
            // 
            this.ክምችትToolStripMenuItem.Name = "ክምችትToolStripMenuItem";
            this.ክምችትToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.ክምችትToolStripMenuItem.Text = "ክምችት";
            // 
            // ሪፖርትToolStripMenuItem
            // 
            this.ሪፖርትToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.የቁሶችዝርዝርሪፖርትToolStripMenuItem,
            this.የክምችትዝርዘርሪፖርToolStripMenuItem});
            this.ሪፖርትToolStripMenuItem.Name = "ሪፖርትToolStripMenuItem";
            this.ሪፖርትToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.ሪፖርትToolStripMenuItem.Text = "ሪፖርት";
            // 
            // የቁሶችዝርዝርሪፖርትToolStripMenuItem
            // 
            this.የቁሶችዝርዝርሪፖርትToolStripMenuItem.Name = "የቁሶችዝርዝርሪፖርትToolStripMenuItem";
            this.የቁሶችዝርዝርሪፖርትToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.የቁሶችዝርዝርሪፖርትToolStripMenuItem.Text = "የቁሶች ዝርዝር ሪፖርት";
            // 
            // የክምችትዝርዘርሪፖርToolStripMenuItem
            // 
            this.የክምችትዝርዘርሪፖርToolStripMenuItem.Name = "የክምችትዝርዘርሪፖርToolStripMenuItem";
            this.የክምችትዝርዘርሪፖርToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.የክምችትዝርዘርሪፖርToolStripMenuItem.Text = "የክምችት ዝርዘር ሪፖርት";
            // 
            // ዋና_ክምችት
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 453);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "ዋና_ክምችት";
            this.Text = "ዋና_ክምችት";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ዋና_ክምችት_FormClosing);
            this.Load += new System.EventHandler(this.ዋና_ክምችት_Load);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem ቁሶችToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ክምችትToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ሪፖርትToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem የቁሶችዝርዝርሪፖርትToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem የክምችትዝርዘርሪፖርToolStripMenuItem;
    }
}



