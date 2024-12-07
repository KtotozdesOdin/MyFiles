namespace bible3
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            button2 = new Button();
            checkBox2 = new CheckBox();
            checkBox1 = new CheckBox();
            numericUpDown4 = new NumericUpDown();
            numericUpDown3 = new NumericUpDown();
            label7 = new Label();
            numericUpDown2 = new NumericUpDown();
            label6 = new Label();
            numericUpDown1 = new NumericUpDown();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            tabPage2 = new TabPage();
            richTextBox1 = new RichTextBox();
            checkBox3 = new CheckBox();
            button1 = new Button();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Left;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(307, 411);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(button2);
            tabPage1.Controls.Add(checkBox2);
            tabPage1.Controls.Add(checkBox1);
            tabPage1.Controls.Add(numericUpDown4);
            tabPage1.Controls.Add(numericUpDown3);
            tabPage1.Controls.Add(label7);
            tabPage1.Controls.Add(numericUpDown2);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(numericUpDown1);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(textBox3);
            tabPage1.Controls.Add(textBox2);
            tabPage1.Controls.Add(textBox1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(299, 383);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Книги";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.FlatStyle = FlatStyle.Popup;
            button2.Location = new Point(64, 352);
            button2.Name = "button2";
            button2.Size = new Size(129, 23);
            button2.TabIndex = 4;
            button2.Text = "Добавить";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(138, 314);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(133, 19);
            checkBox2.TabIndex = 3;
            checkBox2.Text = "Возвращено в срок";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(18, 314);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(75, 19);
            checkBox1.TabIndex = 3;
            checkBox1.Text = "Наличие";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // numericUpDown4
            // 
            numericUpDown4.Location = new Point(160, 260);
            numericUpDown4.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numericUpDown4.Name = "numericUpDown4";
            numericUpDown4.Size = new Size(120, 23);
            numericUpDown4.TabIndex = 2;
            // 
            // numericUpDown3
            // 
            numericUpDown3.Location = new Point(160, 220);
            numericUpDown3.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numericUpDown3.Name = "numericUpDown3";
            numericUpDown3.Size = new Size(120, 23);
            numericUpDown3.TabIndex = 2;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(8, 262);
            label7.Name = "label7";
            label7.Size = new Size(109, 15);
            label7.TabIndex = 1;
            label7.Text = "Срок пользования";
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(160, 179);
            numericUpDown2.Maximum = new decimal(new int[] { 2100, 0, 0, 0 });
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(120, 23);
            numericUpDown2.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(8, 222);
            label6.Name = "label6";
            label6.Size = new Size(83, 15);
            label6.TabIndex = 1;
            label6.Text = "Инвентарный";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(160, 145);
            numericUpDown1.Maximum = new decimal(new int[] { 2000, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(120, 23);
            numericUpDown1.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(8, 181);
            label5.Name = "label5";
            label5.Size = new Size(73, 15);
            label5.TabIndex = 1;
            label5.Text = "Год издания";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(8, 147);
            label4.Name = "label4";
            label4.Size = new Size(54, 15);
            label4.TabIndex = 1;
            label4.Text = "Страниц";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(8, 108);
            label3.Name = "label3";
            label3.Size = new Size(81, 15);
            label3.TabIndex = 1;
            label3.Text = "Издательство";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 67);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 1;
            label2.Text = "Название";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 25);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 1;
            label1.Text = "Автор";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(117, 105);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(163, 23);
            textBox3.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(117, 64);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(163, 23);
            textBox2.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(117, 22);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(163, 23);
            textBox1.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(299, 383);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Журналы";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(313, 0);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(341, 357);
            richTextBox1.TabIndex = 1;
            richTextBox1.Text = "";
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(524, 380);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(92, 19);
            checkBox3.TabIndex = 3;
            checkBox3.Text = "Сортировка";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Popup;
            button1.Location = new Point(355, 376);
            button1.Name = "button1";
            button1.Size = new Size(122, 23);
            button1.TabIndex = 4;
            button1.Text = "Просмотр";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(654, 411);
            Controls.Add(button1);
            Controls.Add(checkBox3);
            Controls.Add(richTextBox1);
            Controls.Add(tabControl1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Form1";
            Text = "Библиотека";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown4).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private Label label1;
        private TextBox textBox1;
        private TabPage tabPage2;
        private RichTextBox richTextBox1;
        private Label label3;
        private Label label2;
        private TextBox textBox3;
        private TextBox textBox2;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
        private NumericUpDown numericUpDown4;
        private NumericUpDown numericUpDown3;
        private Label label7;
        private NumericUpDown numericUpDown2;
        private Label label6;
        private NumericUpDown numericUpDown1;
        private Label label5;
        private Label label4;
        private CheckBox checkBox3;
        private Button button1;
        private Button button2;
    }
}
