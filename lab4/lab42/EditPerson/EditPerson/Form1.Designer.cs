namespace EditPerson
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
            personsListView = new ListView();
            Имя = new ColumnHeader();
            Фамилия = new ColumnHeader();
            Отчество = new ColumnHeader();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            richTextBox1 = new RichTextBox();
            SuspendLayout();
            // 
            // personsListView
            // 
            personsListView.Columns.AddRange(new ColumnHeader[] { Имя, Фамилия, Отчество });
            personsListView.Location = new Point(12, 12);
            personsListView.Name = "personsListView";
            personsListView.Size = new Size(550, 194);
            personsListView.TabIndex = 0;
            personsListView.UseCompatibleStateImageBehavior = false;
            personsListView.View = View.Details;
            // 
            // Имя
            // 
            Имя.Text = "Имя";
            Имя.Width = 180;
            // 
            // Фамилия
            // 
            Фамилия.Text = "Фамилия";
            Фамилия.Width = 180;
            // 
            // Отчество
            // 
            Отчество.Text = "Отчество";
            Отчество.Width = 180;
            // 
            // button1
            // 
            button1.Location = new Point(136, 218);
            button1.Name = "button1";
            button1.Size = new Size(96, 23);
            button1.TabIndex = 1;
            button1.Text = "Добавить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(312, 218);
            button2.Name = "button2";
            button2.Size = new Size(110, 23);
            button2.TabIndex = 2;
            button2.Text = "Редактировать";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.FlatStyle = FlatStyle.System;
            button3.Location = new Point(170, 266);
            button3.Name = "button3";
            button3.Size = new Size(206, 23);
            button3.TabIndex = 3;
            button3.Text = "Просмотреть список";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(12, 308);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(550, 166);
            richTextBox1.TabIndex = 4;
            richTextBox1.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(586, 486);
            Controls.Add(richTextBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(personsListView);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "Form1";
            Text = "Список сотрудников";
            ResumeLayout(false);
        }

        #endregion

        private ListView personsListView;
        private Button button1;
        private Button button2;
        private ColumnHeader Имя;
        private ColumnHeader Фамилия;
        private ColumnHeader Отчество;
        private Button button3;
        private RichTextBox richTextBox1;
    }
}
