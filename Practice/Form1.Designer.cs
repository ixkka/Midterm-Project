namespace Practice
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
            displayTxtBox = new TextBox();
            addBtn = new Button();
            subtractBtn = new Button();
            multiplyBtn = new Button();
            divideBtn = new Button();
            equalsBtn = new Button();
            zeroBtn = new Button();
            decimalPtBtn = new Button();
            oneBtn = new Button();
            twoBtn = new Button();
            threeBtn = new Button();
            sixBtn = new Button();
            fiveBtn = new Button();
            fourBtn = new Button();
            sevenBtn = new Button();
            eightBtn = new Button();
            nineBtn = new Button();
            clearButton = new Button();
            backspcBtn = new Button();
            SuspendLayout();
            // 
            // displayTxtBox
            // 
            displayTxtBox.BackColor = SystemColors.Window;
            displayTxtBox.BorderStyle = BorderStyle.FixedSingle;
            displayTxtBox.Font = new Font("Segoe UI", 15F);
            displayTxtBox.Location = new Point(20, 20);
            displayTxtBox.Multiline = true;
            displayTxtBox.Name = "displayTxtBox";
            displayTxtBox.ReadOnly = true;
            displayTxtBox.Size = new Size(318, 96);
            displayTxtBox.TabIndex = 0;
            displayTxtBox.TextAlign = HorizontalAlignment.Right;
            displayTxtBox.TextChanged += textBox1_TextChanged;
            // 
            // addBtn
            // 
            addBtn.Font = new Font("Segoe UI", 20F);
            addBtn.Location = new Point(263, 446);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(75, 75);
            addBtn.TabIndex = 1;
            addBtn.Text = "+";
            addBtn.UseVisualStyleBackColor = true;
            addBtn.Click += addBtn_Click;
            // 
            // subtractBtn
            // 
            subtractBtn.Font = new Font("Segoe UI", 20F);
            subtractBtn.Location = new Point(263, 365);
            subtractBtn.Name = "subtractBtn";
            subtractBtn.Size = new Size(75, 75);
            subtractBtn.TabIndex = 2;
            subtractBtn.Text = "-";
            subtractBtn.UseVisualStyleBackColor = true;
            subtractBtn.Click += subtractButton_Click;
            // 
            // multiplyBtn
            // 
            multiplyBtn.Font = new Font("Segoe UI", 20F);
            multiplyBtn.Location = new Point(263, 284);
            multiplyBtn.Name = "multiplyBtn";
            multiplyBtn.Size = new Size(75, 75);
            multiplyBtn.TabIndex = 3;
            multiplyBtn.Text = "*";
            multiplyBtn.UseVisualStyleBackColor = true;
            multiplyBtn.Click += multiplyBtn_Click;
            // 
            // divideBtn
            // 
            divideBtn.Font = new Font("Segoe UI", 20F);
            divideBtn.Location = new Point(263, 203);
            divideBtn.Name = "divideBtn";
            divideBtn.Size = new Size(75, 75);
            divideBtn.TabIndex = 4;
            divideBtn.Text = "/";
            divideBtn.UseVisualStyleBackColor = true;
            divideBtn.Click += divideBtn_Click;
            // 
            // equalsBtn
            // 
            equalsBtn.Font = new Font("Segoe UI", 20F);
            equalsBtn.Location = new Point(182, 446);
            equalsBtn.Name = "equalsBtn";
            equalsBtn.Size = new Size(75, 75);
            equalsBtn.TabIndex = 5;
            equalsBtn.Text = "=";
            equalsBtn.UseVisualStyleBackColor = true;
            equalsBtn.Click += equalsBtn_Click;
            // 
            // zeroBtn
            // 
            zeroBtn.Font = new Font("Segoe UI", 20F);
            zeroBtn.Location = new Point(20, 446);
            zeroBtn.Name = "zeroBtn";
            zeroBtn.Size = new Size(75, 75);
            zeroBtn.TabIndex = 6;
            zeroBtn.Text = "0";
            zeroBtn.UseVisualStyleBackColor = true;
            zeroBtn.Click += zeroBtn_Click;
            // 
            // decimalPtBtn
            // 
            decimalPtBtn.Font = new Font("Segoe UI", 20F);
            decimalPtBtn.Location = new Point(101, 446);
            decimalPtBtn.Name = "decimalPtBtn";
            decimalPtBtn.Size = new Size(75, 75);
            decimalPtBtn.TabIndex = 7;
            decimalPtBtn.Tag = "";
            decimalPtBtn.Text = ".";
            decimalPtBtn.UseVisualStyleBackColor = true;
            decimalPtBtn.Click += decimalPtBtn_Click;
            // 
            // oneBtn
            // 
            oneBtn.Font = new Font("Segoe UI", 20F);
            oneBtn.Location = new Point(20, 365);
            oneBtn.Name = "oneBtn";
            oneBtn.Size = new Size(75, 75);
            oneBtn.TabIndex = 9;
            oneBtn.Text = "1";
            oneBtn.UseVisualStyleBackColor = true;
            oneBtn.Click += oneBtn_Click;
            // 
            // twoBtn
            // 
            twoBtn.Font = new Font("Segoe UI", 20F);
            twoBtn.Location = new Point(101, 365);
            twoBtn.Name = "twoBtn";
            twoBtn.Size = new Size(75, 75);
            twoBtn.TabIndex = 10;
            twoBtn.Text = "2";
            twoBtn.UseVisualStyleBackColor = true;
            twoBtn.Click += twoBtn_Click;
            // 
            // threeBtn
            // 
            threeBtn.Font = new Font("Segoe UI", 20F);
            threeBtn.Location = new Point(182, 365);
            threeBtn.Name = "threeBtn";
            threeBtn.Size = new Size(75, 75);
            threeBtn.TabIndex = 11;
            threeBtn.Text = "3";
            threeBtn.UseVisualStyleBackColor = true;
            threeBtn.Click += threeBtn_Click;
            // 
            // sixBtn
            // 
            sixBtn.Font = new Font("Segoe UI", 20F);
            sixBtn.Location = new Point(182, 284);
            sixBtn.Name = "sixBtn";
            sixBtn.Size = new Size(75, 75);
            sixBtn.TabIndex = 12;
            sixBtn.Text = "6";
            sixBtn.UseVisualStyleBackColor = true;
            sixBtn.Click += sixBtn_Click;
            // 
            // fiveBtn
            // 
            fiveBtn.Font = new Font("Segoe UI", 20F);
            fiveBtn.Location = new Point(101, 284);
            fiveBtn.Name = "fiveBtn";
            fiveBtn.Size = new Size(75, 75);
            fiveBtn.TabIndex = 13;
            fiveBtn.Text = "5";
            fiveBtn.UseVisualStyleBackColor = true;
            fiveBtn.Click += fiveBtn_Click;
            // 
            // fourBtn
            // 
            fourBtn.Font = new Font("Segoe UI", 20F);
            fourBtn.Location = new Point(20, 284);
            fourBtn.Name = "fourBtn";
            fourBtn.Size = new Size(75, 75);
            fourBtn.TabIndex = 14;
            fourBtn.Text = "4";
            fourBtn.UseVisualStyleBackColor = true;
            fourBtn.Click += fourBtn_Click;
            // 
            // sevenBtn
            // 
            sevenBtn.Font = new Font("Segoe UI", 20F);
            sevenBtn.Location = new Point(20, 203);
            sevenBtn.Name = "sevenBtn";
            sevenBtn.Size = new Size(75, 75);
            sevenBtn.TabIndex = 15;
            sevenBtn.Text = "7";
            sevenBtn.UseVisualStyleBackColor = true;
            sevenBtn.Click += sevenBtn_Click;
            // 
            // eightBtn
            // 
            eightBtn.Font = new Font("Segoe UI", 20F);
            eightBtn.Location = new Point(101, 203);
            eightBtn.Name = "eightBtn";
            eightBtn.Size = new Size(75, 75);
            eightBtn.TabIndex = 16;
            eightBtn.Text = "8";
            eightBtn.UseVisualStyleBackColor = true;
            eightBtn.Click += eightBtn_Click;
            // 
            // nineBtn
            // 
            nineBtn.Font = new Font("Segoe UI", 20F);
            nineBtn.Location = new Point(182, 203);
            nineBtn.Name = "nineBtn";
            nineBtn.Size = new Size(75, 75);
            nineBtn.TabIndex = 17;
            nineBtn.Text = "9";
            nineBtn.UseVisualStyleBackColor = true;
            nineBtn.Click += nineBtn_Click;
            // 
            // clearButton
            // 
            clearButton.Font = new Font("Segoe UI", 20F);
            clearButton.Location = new Point(182, 122);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(75, 75);
            clearButton.TabIndex = 18;
            clearButton.Text = "C";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += clearButton_Click;
            // 
            // backspcBtn
            // 
            backspcBtn.Font = new Font("Segoe UI", 20F);
            backspcBtn.Location = new Point(263, 122);
            backspcBtn.Name = "backspcBtn";
            backspcBtn.Size = new Size(75, 75);
            backspcBtn.TabIndex = 19;
            backspcBtn.Text = "←";
            backspcBtn.UseVisualStyleBackColor = true;
            backspcBtn.Click += backspcBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(357, 544);
            Controls.Add(backspcBtn);
            Controls.Add(clearButton);
            Controls.Add(nineBtn);
            Controls.Add(eightBtn);
            Controls.Add(sevenBtn);
            Controls.Add(fourBtn);
            Controls.Add(fiveBtn);
            Controls.Add(sixBtn);
            Controls.Add(threeBtn);
            Controls.Add(twoBtn);
            Controls.Add(oneBtn);
            Controls.Add(decimalPtBtn);
            Controls.Add(zeroBtn);
            Controls.Add(equalsBtn);
            Controls.Add(divideBtn);
            Controls.Add(multiplyBtn);
            Controls.Add(subtractBtn);
            Controls.Add(addBtn);
            Controls.Add(displayTxtBox);
            Name = "Form1";
            Text = "Calculator";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox displayTxtBox;
        private Button addBtn;
        private Button subtractBtn;
        private Button multiplyBtn;
        private Button divideBtn;
        private Button equalsBtn;
        private Button zeroBtn;
        private Button decimalPtBtn;
        private Button oneBtn;
        private Button twoBtn;
        private Button threeBtn;
        private Button sixBtn;
        private Button fiveBtn;
        private Button fourBtn;
        private Button sevenBtn;
        private Button eightBtn;
        private Button nineBtn;
        private Button clearButton;
        private Button backspcBtn;
    }
}
