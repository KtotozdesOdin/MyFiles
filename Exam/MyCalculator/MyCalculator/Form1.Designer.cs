namespace MyCalculator
{
    partial class Calculator
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
            components = new System.ComponentModel.Container();
            groupBox1 = new GroupBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            button16 = new Button();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button0 = new Button();
            buttonPlus = new Button();
            buttonMinus = new Button();
            buttonMultiple = new Button();
            buttonDivide = new Button();
            buttonClear = new Button();
            buttonSqrt = new Button();
            buttonPow2 = new Button();
            buttonSin = new Button();
            buttonCos = new Button();
            buttonTan = new Button();
            buttonCtg = new Button();
            buttonFactorial = new Button();
            buttonResult = new Button();
            buttonPow = new Button();
            buttonReverse = new Button();
            buttonСubeRoot = new Button();
            buttonEQN = new Button();
            menuStrip1 = new MenuStrip();
            менюToolStripMenuItem = new ToolStripMenuItem();
            ToolStripMenuItemExit = new ToolStripMenuItem();
            режимToolStripMenuItem = new ToolStripMenuItem();
            стандартныйToolStripMenuItem = new ToolStripMenuItem();
            инженерныйToolStripMenuItem = new ToolStripMenuItem();
            toolTip1 = new ToolTip(components);
            tableLayoutPanel2 = new TableLayoutPanel();
            textBoxInput = new TextBox();
            textBoxPower = new TextBox();
            labelOutPut = new Label();
            tableLayoutPanel1.SuspendLayout();
            menuStrip1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Dock = DockStyle.Bottom;
            groupBox1.FlatStyle = FlatStyle.Flat;
            groupBox1.Location = new Point(0, 203);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(384, 258);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 5;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Controls.Add(button16, 1, 5);
            tableLayoutPanel1.Controls.Add(button1, 1, 4);
            tableLayoutPanel1.Controls.Add(button2, 2, 4);
            tableLayoutPanel1.Controls.Add(button3, 3, 4);
            tableLayoutPanel1.Controls.Add(button4, 1, 3);
            tableLayoutPanel1.Controls.Add(button5, 2, 3);
            tableLayoutPanel1.Controls.Add(button6, 3, 3);
            tableLayoutPanel1.Controls.Add(button7, 1, 2);
            tableLayoutPanel1.Controls.Add(button8, 2, 2);
            tableLayoutPanel1.Controls.Add(button9, 3, 2);
            tableLayoutPanel1.Controls.Add(button0, 2, 5);
            tableLayoutPanel1.Controls.Add(buttonPlus, 4, 4);
            tableLayoutPanel1.Controls.Add(buttonMinus, 4, 3);
            tableLayoutPanel1.Controls.Add(buttonMultiple, 4, 2);
            tableLayoutPanel1.Controls.Add(buttonDivide, 4, 1);
            tableLayoutPanel1.Controls.Add(buttonClear, 3, 1);
            tableLayoutPanel1.Controls.Add(buttonSqrt, 2, 1);
            tableLayoutPanel1.Controls.Add(buttonPow2, 1, 1);
            tableLayoutPanel1.Controls.Add(buttonSin, 0, 1);
            tableLayoutPanel1.Controls.Add(buttonCos, 0, 2);
            tableLayoutPanel1.Controls.Add(buttonTan, 0, 3);
            tableLayoutPanel1.Controls.Add(buttonCtg, 0, 4);
            tableLayoutPanel1.Controls.Add(buttonFactorial, 0, 5);
            tableLayoutPanel1.Controls.Add(buttonResult, 3, 5);
            tableLayoutPanel1.Controls.Add(buttonPow, 0, 0);
            tableLayoutPanel1.Controls.Add(buttonReverse, 1, 0);
            tableLayoutPanel1.Controls.Add(buttonСubeRoot, 2, 0);
            tableLayoutPanel1.Controls.Add(buttonEQN, 3, 0);
            tableLayoutPanel1.Location = new Point(-94, 116);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.Size = new Size(476, 339);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // button16
            // 
            button16.Dock = DockStyle.Fill;
            button16.FlatStyle = FlatStyle.Popup;
            button16.Location = new Point(98, 283);
            button16.Name = "button16";
            button16.Size = new Size(89, 53);
            button16.TabIndex = 24;
            button16.Text = ".";
            button16.UseVisualStyleBackColor = true;
            button16.Click += button16_Click_1;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Location = new Point(98, 227);
            button1.Name = "button1";
            button1.Size = new Size(89, 50);
            button1.TabIndex = 0;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Dock = DockStyle.Fill;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Location = new Point(193, 227);
            button2.Name = "button2";
            button2.Size = new Size(89, 50);
            button2.TabIndex = 1;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Dock = DockStyle.Fill;
            button3.FlatStyle = FlatStyle.Popup;
            button3.Location = new Point(288, 227);
            button3.Name = "button3";
            button3.Size = new Size(89, 50);
            button3.TabIndex = 2;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Dock = DockStyle.Fill;
            button4.FlatStyle = FlatStyle.Popup;
            button4.Location = new Point(98, 171);
            button4.Name = "button4";
            button4.Size = new Size(89, 50);
            button4.TabIndex = 3;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Dock = DockStyle.Fill;
            button5.FlatStyle = FlatStyle.Popup;
            button5.Location = new Point(193, 171);
            button5.Name = "button5";
            button5.Size = new Size(89, 50);
            button5.TabIndex = 4;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Dock = DockStyle.Fill;
            button6.FlatStyle = FlatStyle.Popup;
            button6.Location = new Point(288, 171);
            button6.Name = "button6";
            button6.Size = new Size(89, 50);
            button6.TabIndex = 5;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Dock = DockStyle.Fill;
            button7.FlatStyle = FlatStyle.Popup;
            button7.Location = new Point(98, 115);
            button7.Name = "button7";
            button7.Size = new Size(89, 50);
            button7.TabIndex = 6;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Dock = DockStyle.Fill;
            button8.FlatStyle = FlatStyle.Popup;
            button8.Location = new Point(193, 115);
            button8.Name = "button8";
            button8.Size = new Size(89, 50);
            button8.TabIndex = 7;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.Dock = DockStyle.Fill;
            button9.FlatStyle = FlatStyle.Popup;
            button9.Location = new Point(288, 115);
            button9.Name = "button9";
            button9.Size = new Size(89, 50);
            button9.TabIndex = 8;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // button0
            // 
            button0.Dock = DockStyle.Fill;
            button0.FlatStyle = FlatStyle.Popup;
            button0.Location = new Point(193, 283);
            button0.Name = "button0";
            button0.Size = new Size(89, 53);
            button0.TabIndex = 9;
            button0.Text = "0";
            button0.UseVisualStyleBackColor = true;
            button0.Click += button0_Click;
            // 
            // buttonPlus
            // 
            buttonPlus.Dock = DockStyle.Fill;
            buttonPlus.FlatStyle = FlatStyle.Popup;
            buttonPlus.Location = new Point(383, 227);
            buttonPlus.Name = "buttonPlus";
            buttonPlus.Size = new Size(90, 50);
            buttonPlus.TabIndex = 11;
            buttonPlus.Text = "+";
            toolTip1.SetToolTip(buttonPlus, "Сложение");
            buttonPlus.UseVisualStyleBackColor = true;
            buttonPlus.Click += buttonPlus_Click;
            // 
            // buttonMinus
            // 
            buttonMinus.Dock = DockStyle.Fill;
            buttonMinus.FlatStyle = FlatStyle.Popup;
            buttonMinus.Location = new Point(383, 171);
            buttonMinus.Name = "buttonMinus";
            buttonMinus.Size = new Size(90, 50);
            buttonMinus.TabIndex = 12;
            buttonMinus.Text = "-";
            toolTip1.SetToolTip(buttonMinus, "Вычитание");
            buttonMinus.UseVisualStyleBackColor = true;
            buttonMinus.Click += buttonMinus_Click;
            // 
            // buttonMultiple
            // 
            buttonMultiple.Dock = DockStyle.Fill;
            buttonMultiple.FlatStyle = FlatStyle.Popup;
            buttonMultiple.Location = new Point(383, 115);
            buttonMultiple.Name = "buttonMultiple";
            buttonMultiple.Size = new Size(90, 50);
            buttonMultiple.TabIndex = 13;
            buttonMultiple.Text = "*";
            toolTip1.SetToolTip(buttonMultiple, "Умножение");
            buttonMultiple.UseVisualStyleBackColor = true;
            buttonMultiple.Click += buttonMultiple_Click;
            // 
            // buttonDivide
            // 
            buttonDivide.Dock = DockStyle.Fill;
            buttonDivide.FlatStyle = FlatStyle.Popup;
            buttonDivide.Location = new Point(383, 59);
            buttonDivide.Name = "buttonDivide";
            buttonDivide.Size = new Size(90, 50);
            buttonDivide.TabIndex = 14;
            buttonDivide.Text = "/";
            toolTip1.SetToolTip(buttonDivide, "Деление");
            buttonDivide.UseVisualStyleBackColor = true;
            buttonDivide.Click += buttonDivide_Click;
            // 
            // buttonClear
            // 
            buttonClear.BackColor = Color.FromArgb(255, 128, 128);
            buttonClear.Dock = DockStyle.Fill;
            buttonClear.FlatStyle = FlatStyle.Popup;
            buttonClear.Location = new Point(288, 59);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(89, 50);
            buttonClear.TabIndex = 16;
            buttonClear.Text = "C";
            toolTip1.SetToolTip(buttonClear, "Сброс");
            buttonClear.UseVisualStyleBackColor = false;
            buttonClear.Click += buttonClear_Click;
            // 
            // buttonSqrt
            // 
            buttonSqrt.BackColor = Color.FromArgb(255, 192, 128);
            buttonSqrt.Dock = DockStyle.Fill;
            buttonSqrt.FlatStyle = FlatStyle.Popup;
            buttonSqrt.Location = new Point(193, 59);
            buttonSqrt.Name = "buttonSqrt";
            buttonSqrt.Size = new Size(89, 50);
            buttonSqrt.TabIndex = 17;
            buttonSqrt.Text = "Sqrt";
            toolTip1.SetToolTip(buttonSqrt, "Квадратный корень");
            buttonSqrt.UseVisualStyleBackColor = false;
            buttonSqrt.Click += buttonSqrt_Click;
            // 
            // buttonPow2
            // 
            buttonPow2.BackColor = Color.FromArgb(255, 192, 128);
            buttonPow2.Dock = DockStyle.Fill;
            buttonPow2.FlatStyle = FlatStyle.Popup;
            buttonPow2.Location = new Point(98, 59);
            buttonPow2.Name = "buttonPow2";
            buttonPow2.Size = new Size(89, 50);
            buttonPow2.TabIndex = 18;
            buttonPow2.Text = "x^2";
            toolTip1.SetToolTip(buttonPow2, "Возведение в квадрат");
            buttonPow2.UseVisualStyleBackColor = false;
            buttonPow2.Click += buttonPow2_Click;
            // 
            // buttonSin
            // 
            buttonSin.BackColor = Color.FromArgb(255, 192, 128);
            buttonSin.Dock = DockStyle.Fill;
            buttonSin.FlatStyle = FlatStyle.Popup;
            buttonSin.Location = new Point(3, 59);
            buttonSin.Name = "buttonSin";
            buttonSin.Size = new Size(89, 50);
            buttonSin.TabIndex = 19;
            buttonSin.Text = "sin";
            toolTip1.SetToolTip(buttonSin, "Синус");
            buttonSin.UseVisualStyleBackColor = false;
            buttonSin.Visible = false;
            buttonSin.Click += buttonSin_Click;
            // 
            // buttonCos
            // 
            buttonCos.BackColor = Color.FromArgb(255, 192, 128);
            buttonCos.Dock = DockStyle.Fill;
            buttonCos.FlatStyle = FlatStyle.Popup;
            buttonCos.Location = new Point(3, 115);
            buttonCos.Name = "buttonCos";
            buttonCos.Size = new Size(89, 50);
            buttonCos.TabIndex = 20;
            buttonCos.Text = "cos";
            toolTip1.SetToolTip(buttonCos, "Косинус");
            buttonCos.UseVisualStyleBackColor = false;
            buttonCos.Visible = false;
            buttonCos.Click += buttonCos_Click;
            // 
            // buttonTan
            // 
            buttonTan.BackColor = Color.FromArgb(255, 192, 128);
            buttonTan.Dock = DockStyle.Fill;
            buttonTan.FlatStyle = FlatStyle.Popup;
            buttonTan.Location = new Point(3, 171);
            buttonTan.Name = "buttonTan";
            buttonTan.Size = new Size(89, 50);
            buttonTan.TabIndex = 21;
            buttonTan.Text = "tan";
            toolTip1.SetToolTip(buttonTan, "Тангенс");
            buttonTan.UseVisualStyleBackColor = false;
            buttonTan.Visible = false;
            buttonTan.Click += buttonTan_Click;
            // 
            // buttonCtg
            // 
            buttonCtg.BackColor = Color.FromArgb(255, 192, 128);
            buttonCtg.Dock = DockStyle.Fill;
            buttonCtg.FlatStyle = FlatStyle.Popup;
            buttonCtg.Location = new Point(3, 227);
            buttonCtg.Name = "buttonCtg";
            buttonCtg.Size = new Size(89, 50);
            buttonCtg.TabIndex = 22;
            buttonCtg.Text = "ctg";
            toolTip1.SetToolTip(buttonCtg, "Котангенс");
            buttonCtg.UseVisualStyleBackColor = false;
            buttonCtg.Visible = false;
            buttonCtg.Click += buttonCtg_Click;
            // 
            // buttonFactorial
            // 
            buttonFactorial.BackColor = Color.FromArgb(255, 192, 128);
            buttonFactorial.Dock = DockStyle.Fill;
            buttonFactorial.FlatStyle = FlatStyle.Popup;
            buttonFactorial.Location = new Point(3, 283);
            buttonFactorial.Name = "buttonFactorial";
            buttonFactorial.Size = new Size(89, 53);
            buttonFactorial.TabIndex = 23;
            buttonFactorial.Text = "n!";
            toolTip1.SetToolTip(buttonFactorial, "Факториал");
            buttonFactorial.UseVisualStyleBackColor = false;
            buttonFactorial.Visible = false;
            buttonFactorial.Click += buttonFactorial_Click;
            // 
            // buttonResult
            // 
            buttonResult.BackColor = Color.FromArgb(224, 224, 224);
            tableLayoutPanel1.SetColumnSpan(buttonResult, 2);
            buttonResult.Dock = DockStyle.Fill;
            buttonResult.FlatStyle = FlatStyle.Popup;
            buttonResult.Location = new Point(288, 283);
            buttonResult.Name = "buttonResult";
            buttonResult.Size = new Size(185, 53);
            buttonResult.TabIndex = 10;
            buttonResult.Text = "=";
            buttonResult.UseVisualStyleBackColor = false;
            buttonResult.Click += buttonResult_Click;
            // 
            // buttonPow
            // 
            buttonPow.BackColor = Color.FromArgb(255, 192, 128);
            buttonPow.Dock = DockStyle.Fill;
            buttonPow.FlatStyle = FlatStyle.Popup;
            buttonPow.Location = new Point(3, 3);
            buttonPow.Name = "buttonPow";
            buttonPow.Size = new Size(89, 50);
            buttonPow.TabIndex = 25;
            buttonPow.Text = "x^y";
            toolTip1.SetToolTip(buttonPow, "Возведение в степень");
            buttonPow.UseVisualStyleBackColor = false;
            buttonPow.Visible = false;
            buttonPow.Click += buttonPow_Click;
            // 
            // buttonReverse
            // 
            buttonReverse.BackColor = Color.FromArgb(255, 192, 128);
            buttonReverse.Dock = DockStyle.Fill;
            buttonReverse.FlatStyle = FlatStyle.Popup;
            buttonReverse.Location = new Point(98, 3);
            buttonReverse.Name = "buttonReverse";
            buttonReverse.Size = new Size(89, 50);
            buttonReverse.TabIndex = 26;
            buttonReverse.Text = "1/x";
            toolTip1.SetToolTip(buttonReverse, "Обратное значение");
            buttonReverse.UseVisualStyleBackColor = false;
            buttonReverse.Visible = false;
            buttonReverse.Click += buttonReverse_Click;
            // 
            // buttonСubeRoot
            // 
            buttonСubeRoot.BackColor = Color.FromArgb(255, 192, 128);
            buttonСubeRoot.Dock = DockStyle.Fill;
            buttonСubeRoot.FlatStyle = FlatStyle.Popup;
            buttonСubeRoot.Location = new Point(193, 3);
            buttonСubeRoot.Name = "buttonСubeRoot";
            buttonСubeRoot.Size = new Size(89, 50);
            buttonСubeRoot.TabIndex = 27;
            buttonСubeRoot.Text = "x^1/3";
            toolTip1.SetToolTip(buttonСubeRoot, "Кубический корень");
            buttonСubeRoot.UseVisualStyleBackColor = false;
            buttonСubeRoot.Visible = false;
            buttonСubeRoot.Click += buttonСubeRoot_Click;
            // 
            // buttonEQN
            // 
            buttonEQN.BackColor = Color.FromArgb(255, 192, 128);
            tableLayoutPanel1.SetColumnSpan(buttonEQN, 2);
            buttonEQN.Dock = DockStyle.Fill;
            buttonEQN.FlatStyle = FlatStyle.Popup;
            buttonEQN.Location = new Point(288, 3);
            buttonEQN.Name = "buttonEQN";
            buttonEQN.Size = new Size(185, 50);
            buttonEQN.TabIndex = 28;
            buttonEQN.Text = "EQN";
            toolTip1.SetToolTip(buttonEQN, "Квадратное уравнение");
            buttonEQN.UseVisualStyleBackColor = false;
            buttonEQN.Visible = false;
            buttonEQN.Click += buttonEQN_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { менюToolStripMenuItem, режимToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(384, 24);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            // 
            // менюToolStripMenuItem
            // 
            менюToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ToolStripMenuItemExit });
            менюToolStripMenuItem.Name = "менюToolStripMenuItem";
            менюToolStripMenuItem.Size = new Size(53, 20);
            менюToolStripMenuItem.Text = "Меню";
            // 
            // ToolStripMenuItemExit
            // 
            ToolStripMenuItemExit.Name = "ToolStripMenuItemExit";
            ToolStripMenuItemExit.Size = new Size(109, 22);
            ToolStripMenuItemExit.Text = "Выход";
            ToolStripMenuItemExit.Click += ToolStripMenuItemExit_Click;
            // 
            // режимToolStripMenuItem
            // 
            режимToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { стандартныйToolStripMenuItem, инженерныйToolStripMenuItem });
            режимToolStripMenuItem.Name = "режимToolStripMenuItem";
            режимToolStripMenuItem.Size = new Size(57, 20);
            режимToolStripMenuItem.Text = "Режим";
            // 
            // стандартныйToolStripMenuItem
            // 
            стандартныйToolStripMenuItem.Name = "стандартныйToolStripMenuItem";
            стандартныйToolStripMenuItem.Size = new Size(148, 22);
            стандартныйToolStripMenuItem.Text = "Стандартный";
            стандартныйToolStripMenuItem.Click += стандартныйToolStripMenuItem_Click;
            // 
            // инженерныйToolStripMenuItem
            // 
            инженерныйToolStripMenuItem.Name = "инженерныйToolStripMenuItem";
            инженерныйToolStripMenuItem.Size = new Size(148, 22);
            инженерныйToolStripMenuItem.Text = "Инженерный";
            инженерныйToolStripMenuItem.Click += инженерныйToolStripMenuItem_Click;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel2.BackColor = Color.White;
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 36.363636F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 9.090909F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 54.5454559F));
            tableLayoutPanel2.Controls.Add(textBoxInput, 0, 0);
            tableLayoutPanel2.Controls.Add(textBoxPower, 1, 0);
            tableLayoutPanel2.Controls.Add(labelOutPut, 2, 0);
            tableLayoutPanel2.Location = new Point(4, 27);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(375, 83);
            tableLayoutPanel2.TabIndex = 4;
            // 
            // textBoxInput
            // 
            textBoxInput.BorderStyle = BorderStyle.None;
            textBoxInput.Dock = DockStyle.Fill;
            textBoxInput.Font = new Font("Segoe UI", 12F);
            textBoxInput.Location = new Point(3, 3);
            textBoxInput.Multiline = true;
            textBoxInput.Name = "textBoxInput";
            textBoxInput.Size = new Size(130, 77);
            textBoxInput.TabIndex = 0;
            // 
            // textBoxPower
            // 
            textBoxPower.BorderStyle = BorderStyle.None;
            textBoxPower.Dock = DockStyle.Fill;
            textBoxPower.Font = new Font("Segoe UI", 12F);
            textBoxPower.Location = new Point(139, 3);
            textBoxPower.Multiline = true;
            textBoxPower.Name = "textBoxPower";
            textBoxPower.Size = new Size(28, 77);
            textBoxPower.TabIndex = 1;
            // 
            // labelOutPut
            // 
            labelOutPut.Dock = DockStyle.Fill;
            labelOutPut.Font = new Font("Segoe UI", 16F);
            labelOutPut.Location = new Point(173, 0);
            labelOutPut.Name = "labelOutPut";
            labelOutPut.Size = new Size(199, 83);
            labelOutPut.TabIndex = 2;
            labelOutPut.TextAlign = ContentAlignment.BottomRight;
            // 
            // Calculator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(384, 461);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(groupBox1);
            Controls.Add(menuStrip1);
            Cursor = Cursors.Hand;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Calculator";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            TopMost = true;
            Load += Form1_Load;
            tableLayoutPanel1.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private GroupBox groupBox1;
        private TableLayoutPanel tableLayoutPanel1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button0;
        private Button buttonResult;
        private Button buttonPlus;
        private Button buttonMinus;
        private Button buttonMultiple;
        private Button buttonDivide;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem менюToolStripMenuItem;
        private ToolStripMenuItem ToolStripMenuItemExit;
        private Button buttonClear;
        private Button buttonSqrt;
        private Button buttonPow2;
        private Button buttonSin;
        private Button buttonCos;
        private Button buttonTan;
        private Button buttonCtg;
        private Button buttonFactorial;
        private ToolStripMenuItem режимToolStripMenuItem;
        private ToolStripMenuItem стандартныйToolStripMenuItem;
        private ToolStripMenuItem инженерныйToolStripMenuItem;
        private Button button16;
        private ToolTip toolTip1;
        private Button buttonPow;
        private Button buttonReverse;
        private Button buttonСubeRoot;
        private Button buttonEQN;
        private TableLayoutPanel tableLayoutPanel2;
        private TextBox textBoxInput;
        private TextBox textBoxPower;
        private Label labelOutPut;
    }
}
