namespace Assignment1_TroyM
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            textBoxGameSale = new TextBox();
            richTextBoxEntries = new RichTextBox();
            textBoxAverage = new TextBox();
            buttonCalculate = new Button();
            buttonClear = new Button();
            buttonExit = new Button();
            labelDayDisplay = new Label();
            toolTip1 = new ToolTip(components);
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 23);
            label1.Name = "label1";
            label1.Size = new Size(129, 20);
            label1.TabIndex = 0;
            label1.Text = "Video Game Sales";
            label1.Click += label1_Click;
            // 
            // textBoxGameSale
            // 
            textBoxGameSale.AcceptsReturn = true;
            textBoxGameSale.Location = new Point(151, 20);
            textBoxGameSale.Name = "textBoxGameSale";
            textBoxGameSale.Size = new Size(169, 27);
            textBoxGameSale.TabIndex = 1;
            toolTip1.SetToolTip(textBoxGameSale, "Enter sales");
            textBoxGameSale.TextChanged += textBoxGameSale_TextChanged;
            // 
            // richTextBoxEntries
            // 
            richTextBoxEntries.Location = new Point(16, 66);
            richTextBoxEntries.Name = "richTextBoxEntries";
            richTextBoxEntries.ReadOnly = true;
            richTextBoxEntries.Size = new Size(408, 242);
            richTextBoxEntries.TabIndex = 5;
            richTextBoxEntries.TabStop = false;
            richTextBoxEntries.Text = "";
            richTextBoxEntries.TextChanged += richTextBoxEntries_TextChanged;
            // 
            // textBoxAverage
            // 
            textBoxAverage.BorderStyle = BorderStyle.FixedSingle;
            textBoxAverage.Enabled = false;
            textBoxAverage.Location = new Point(16, 329);
            textBoxAverage.Name = "textBoxAverage";
            textBoxAverage.Size = new Size(408, 27);
            textBoxAverage.TabIndex = 6;
            textBoxAverage.TabStop = false;
            textBoxAverage.TextAlign = HorizontalAlignment.Center;
            textBoxAverage.TextChanged += textBoxAverage_TextChanged;
            // 
            // buttonCalculate
            // 
            buttonCalculate.Location = new Point(16, 378);
            buttonCalculate.Name = "buttonCalculate";
            buttonCalculate.Size = new Size(120, 29);
            buttonCalculate.TabIndex = 2;
            buttonCalculate.Text = "E&nter";
            toolTip1.SetToolTip(buttonCalculate, "Calculate weekly average");
            buttonCalculate.UseVisualStyleBackColor = true;
            buttonCalculate.Click += buttonCalculate_Click;
            // 
            // buttonClear
            // 
            buttonClear.Location = new Point(160, 378);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(120, 29);
            buttonClear.TabIndex = 3;
            buttonClear.Text = "&Reset";
            toolTip1.SetToolTip(buttonClear, "Reset application");
            buttonClear.UseVisualStyleBackColor = true;
            buttonClear.Click += buttonClear_Click;
            // 
            // buttonExit
            // 
            buttonExit.Location = new Point(304, 378);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(120, 29);
            buttonExit.TabIndex = 4;
            buttonExit.Text = "E&xit";
            toolTip1.SetToolTip(buttonExit, "Close Application");
            buttonExit.UseVisualStyleBackColor = true;
            buttonExit.Click += buttonExit_Click;
            // 
            // labelDayDisplay
            // 
            labelDayDisplay.AutoSize = true;
            labelDayDisplay.Location = new Point(376, 23);
            labelDayDisplay.Name = "labelDayDisplay";
            labelDayDisplay.Size = new Size(47, 20);
            labelDayDisplay.TabIndex = 7;
            labelDayDisplay.Text = "Day 1";
            labelDayDisplay.Click += labelDayDisplay_Click;
            // 
            // Form1
            // 
            AcceptButton = buttonCalculate;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(445, 424);
            Controls.Add(labelDayDisplay);
            Controls.Add(buttonExit);
            Controls.Add(buttonClear);
            Controls.Add(buttonCalculate);
            Controls.Add(textBoxAverage);
            Controls.Add(richTextBoxEntries);
            Controls.Add(textBoxGameSale);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Average Weekly Video Game Sales";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxGameSale;
        private RichTextBox richTextBoxEntries;
        private TextBox textBoxAverage;
        private Button buttonCalculate;
        private Button buttonClear;
        private Button buttonExit;
        private Label labelDayDisplay;
        private ToolTip toolTip1;
    }
}