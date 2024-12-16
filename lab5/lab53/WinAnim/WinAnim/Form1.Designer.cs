namespace WinAnim
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
            btnAW_BLEND = new Button();
            btnHOR_AW_SLIDE = new Button();
            btnCenter_AW_SLIDE = new Button();
            SuspendLayout();
            // 
            // btnAW_BLEND
            // 
            btnAW_BLEND.Location = new Point(43, 24);
            btnAW_BLEND.Name = "btnAW_BLEND";
            btnAW_BLEND.Size = new Size(111, 59);
            btnAW_BLEND.TabIndex = 0;
            btnAW_BLEND.Text = "Проявление";
            btnAW_BLEND.UseVisualStyleBackColor = true;
            // 
            // btnHOR_AW_SLIDE
            // 
            btnHOR_AW_SLIDE.Location = new Point(43, 117);
            btnHOR_AW_SLIDE.Name = "btnHOR_AW_SLIDE";
            btnHOR_AW_SLIDE.Size = new Size(111, 60);
            btnHOR_AW_SLIDE.TabIndex = 1;
            btnHOR_AW_SLIDE.Text = "Горизонтальное появление";
            btnHOR_AW_SLIDE.UseVisualStyleBackColor = true;
            // 
            // btnCenter_AW_SLIDE
            // 
            btnCenter_AW_SLIDE.Location = new Point(43, 216);
            btnCenter_AW_SLIDE.Name = "btnCenter_AW_SLIDE";
            btnCenter_AW_SLIDE.Size = new Size(111, 49);
            btnCenter_AW_SLIDE.TabIndex = 2;
            btnCenter_AW_SLIDE.Text = "Появление из центра ";
            btnCenter_AW_SLIDE.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCenter_AW_SLIDE);
            Controls.Add(btnHOR_AW_SLIDE);
            Controls.Add(btnAW_BLEND);
            Name = "Form1";
            Text = "Анимация формы ";
            ResumeLayout(false);
        }

        #endregion

        private Button btnAW_BLEND;
        private Button btnHOR_AW_SLIDE;
        private Button btnCenter_AW_SLIDE;
    }
}
