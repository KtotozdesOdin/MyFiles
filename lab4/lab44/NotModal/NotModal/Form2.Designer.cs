﻿namespace NotModal
{
    partial class Form2
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
            textBoxF21 = new TextBox();
            textBoxF22 = new TextBox();
            textBoxF23 = new TextBox();
            buttonF2 = new Button();
            SuspendLayout();
            // 
            // textBoxF21
            // 
            textBoxF21.Location = new Point(38, 12);
            textBoxF21.Name = "textBoxF21";
            textBoxF21.Size = new Size(100, 23);
            textBoxF21.TabIndex = 0;
            // 
            // textBoxF22
            // 
            textBoxF22.Location = new Point(38, 67);
            textBoxF22.Name = "textBoxF22";
            textBoxF22.Size = new Size(100, 23);
            textBoxF22.TabIndex = 1;
            // 
            // textBoxF23
            // 
            textBoxF23.Location = new Point(38, 123);
            textBoxF23.Name = "textBoxF23";
            textBoxF23.Size = new Size(100, 23);
            textBoxF23.TabIndex = 2;
            // 
            // buttonF2
            // 
            buttonF2.Location = new Point(53, 174);
            buttonF2.Name = "buttonF2";
            buttonF2.Size = new Size(75, 23);
            buttonF2.TabIndex = 3;
            buttonF2.Text = "button1";
            buttonF2.UseVisualStyleBackColor = true;
            buttonF2.Click += buttonF2_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonF2);
            Controls.Add(textBoxF23);
            Controls.Add(textBoxF22);
            Controls.Add(textBoxF21);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxF21;
        private TextBox textBoxF22;
        private TextBox textBoxF23;
        private Button buttonF2;
    }
}