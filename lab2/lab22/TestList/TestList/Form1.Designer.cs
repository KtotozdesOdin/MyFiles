﻿namespace TestList
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
            groupBox1 = new GroupBox();
            memberList = new CheckedListBox();
            peopleList = new ComboBox();
            buttonAdd = new Button();
            buttonDelete = new Button();
            buttonSort = new Button();
            btn_download_data = new Button();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(146, 21);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Список участников";
            // 
            // memberList
            // 
            memberList.FormattingEnabled = true;
            memberList.Location = new Point(12, 48);
            memberList.Name = "memberList";
            memberList.Size = new Size(120, 94);
            memberList.TabIndex = 1;
            // 
            // peopleList
            // 
            peopleList.FormattingEnabled = true;
            peopleList.Items.AddRange(new object[] { "Иванов Иван Иванович", "Петров Петр Петрович", "Сидоров Евгений Сергеевич", "Смирнов Павел Алексеевич" });
            peopleList.Location = new Point(12, 163);
            peopleList.Name = "peopleList";
            peopleList.Size = new Size(120, 23);
            peopleList.TabIndex = 2;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(223, 48);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(91, 23);
            buttonAdd.TabIndex = 3;
            buttonAdd.Text = "Добавить";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(223, 90);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(91, 23);
            buttonDelete.TabIndex = 4;
            buttonDelete.Text = "Удалить";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonSort
            // 
            buttonSort.Location = new Point(223, 203);
            buttonSort.Name = "buttonSort";
            buttonSort.Size = new Size(91, 23);
            buttonSort.TabIndex = 5;
            buttonSort.Text = "Сортировка";
            buttonSort.UseVisualStyleBackColor = true;
            buttonSort.Click += buttonSort_Click;
            // 
            // btn_download_data
            // 
            btn_download_data.Location = new Point(223, 163);
            btn_download_data.Name = "btn_download_data";
            btn_download_data.Size = new Size(91, 23);
            btn_download_data.TabIndex = 6;
            btn_download_data.Text = "Загрузить данные";
            btn_download_data.UseVisualStyleBackColor = true;
            btn_download_data.Click += btn_download_data_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(380, 257);
            Controls.Add(btn_download_data);
            Controls.Add(buttonSort);
            Controls.Add(buttonDelete);
            Controls.Add(buttonAdd);
            Controls.Add(peopleList);
            Controls.Add(memberList);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "Form1";
            Text = "Работа со списками";
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private CheckedListBox memberList;
        private ComboBox peopleList;
        private Button buttonAdd;
        private Button buttonDelete;
        private Button buttonSort;
        private Button btn_download_data;
    }
}