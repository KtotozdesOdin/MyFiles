using Npgsql;
using System.Web;
namespace DBConnection
{
    partial class Form1
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
            menuStrip1 = new MenuStrip();
            btn_Menu = new ToolStripMenuItem();
            btn_DBConnection = new ToolStripMenuItem();
            btn_closeConnection = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { btn_Menu });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // btn_Menu
            // 
            btn_Menu.DropDownItems.AddRange(new ToolStripItem[] { btn_DBConnection, btn_closeConnection });
            btn_Menu.Name = "btn_Menu";
            btn_Menu.Size = new Size(50, 20);
            btn_Menu.Text = "Menu";
            // 
            // btn_DBConnection
            // 
            btn_DBConnection.Name = "btn_DBConnection";
            btn_DBConnection.Size = new Size(180, 22);
            btn_DBConnection.Text = "DBConection";
            btn_DBConnection.Click += btn_DBConnection_Click;
            // 
            // btn_closeConnection
            // 
            btn_closeConnection.Name = "btn_closeConnection";
            btn_closeConnection.Size = new Size(180, 22);
            btn_closeConnection.Text = "Close Connection";
            btn_closeConnection.Click += btn_closeConnection_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem btn_Menu;
        private ToolStripMenuItem btn_DBConnection;
        private ToolStripMenuItem btn_closeConnection;
    }
}
