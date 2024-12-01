namespace Romb
{
    partial class ParentForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            MdiMenu = new MenuStrip();
            FileMenuItem = new ToolStripMenuItem();
            NewMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            WindowMenuItem = new ToolStripMenuItem();
            WindowCascadeMenuItem = new ToolStripMenuItem();
            WindowTileMenuItem = new ToolStripMenuItem();
            ParentTextBox = new RichTextBox();
            MdiMenu.SuspendLayout();
            SuspendLayout();
            // 
            // MdiMenu
            // 
            MdiMenu.Items.AddRange(new ToolStripItem[] { FileMenuItem, WindowMenuItem });
            MdiMenu.Location = new Point(0, 0);
            MdiMenu.MdiWindowListItem = WindowMenuItem;
            MdiMenu.Name = "MdiMenu";
            MdiMenu.Size = new Size(609, 24);
            MdiMenu.TabIndex = 3;
            MdiMenu.Text = "menuStrip1";
            // 
            // FileMenuItem
            // 
            FileMenuItem.DropDownItems.AddRange(new ToolStripItem[] { NewMenuItem, exitToolStripMenuItem });
            FileMenuItem.Name = "FileMenuItem";
            FileMenuItem.Size = new Size(37, 20);
            FileMenuItem.Text = "&File";
            // 
            // NewMenuItem
            // 
            NewMenuItem.Name = "NewMenuItem";
            NewMenuItem.Size = new Size(98, 22);
            NewMenuItem.Text = "&New";
            NewMenuItem.Click += NewMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(98, 22);
            exitToolStripMenuItem.Text = "&Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // WindowMenuItem
            // 
            WindowMenuItem.DropDownItems.AddRange(new ToolStripItem[] { WindowCascadeMenuItem, WindowTileMenuItem });
            WindowMenuItem.Name = "WindowMenuItem";
            WindowMenuItem.Size = new Size(66, 20);
            WindowMenuItem.Text = " &Window";
            // 
            // WindowCascadeMenuItem
            // 
            WindowCascadeMenuItem.Name = "WindowCascadeMenuItem";
            WindowCascadeMenuItem.Size = new Size(118, 22);
            WindowCascadeMenuItem.Text = "&Cascade";
            WindowCascadeMenuItem.Click += WindowCascadeMenuItem_Click;
            // 
            // WindowTileMenuItem
            // 
            WindowTileMenuItem.Name = "WindowTileMenuItem";
            WindowTileMenuItem.Size = new Size(118, 22);
            WindowTileMenuItem.Text = "&Tile";
            WindowTileMenuItem.Click += WindowTileMenuItem_Click;
            // 
            // ParentTextBox
            // 
            ParentTextBox.Dock = DockStyle.Fill;
            ParentTextBox.Location = new Point(0, 24);
            ParentTextBox.Name = "ParentTextBox";
            ParentTextBox.Size = new Size(609, 477);
            ParentTextBox.TabIndex = 5;
            ParentTextBox.Text = "";
            // 
            // ParentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Blue;
            ClientSize = new Size(609, 501);
            Controls.Add(ParentTextBox);
            Controls.Add(MdiMenu);
            IsMdiContainer = true;
            MainMenuStrip = MdiMenu;
            Name = "ParentForm";
            Text = "ParentForm ";
            MdiMenu.ResumeLayout(false);
            MdiMenu.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip MdiMenu;
        private ToolStripMenuItem FileMenuItem;
        private ToolStripMenuItem NewMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem WindowMenuItem;
        private ToolStripMenuItem WindowCascadeMenuItem;
        private ToolStripMenuItem WindowTileMenuItem;
        private RichTextBox ParentTextBox;
    }
}
