using System.Security.Policy;

namespace Calculator
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
            this.number1 = new System.Windows.Forms.Button();
            this.erase = new System.Windows.Forms.Button();
            this.number8 = new System.Windows.Forms.Button();
            this.number7 = new System.Windows.Forms.Button();
            this.number6 = new System.Windows.Forms.Button();
            this.number5 = new System.Windows.Forms.Button();
            this.number4 = new System.Windows.Forms.Button();
            this.number3 = new System.Windows.Forms.Button();
            this.number2 = new System.Windows.Forms.Button();
            this.equals = new System.Windows.Forms.Button();
            this.squareRoot = new System.Windows.Forms.Button();
            this.plus = new System.Windows.Forms.Button();
            this.ceButton = new System.Windows.Forms.Button();
            this.modulo = new System.Windows.Forms.Button();
            this.plusMinus = new System.Windows.Forms.Button();
            this.inverse = new System.Windows.Forms.Button();
            this.dot = new System.Windows.Forms.Button();
            this.square = new System.Windows.Forms.Button();
            this.divide = new System.Windows.Forms.Button();
            this.multiply = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.Button();
            this.cButton = new System.Windows.Forms.Button();
            this.number0 = new System.Windows.Forms.Button();
            this.number9 = new System.Windows.Forms.Button();
            this.panel = new System.Windows.Forms.Panel();
            this.currentExpressionTextBox = new System.Windows.Forms.TextBox();
            this.historyButton = new System.Windows.Forms.Button();
            this.textBox = new System.Windows.Forms.TextBox();
            this.historyPanel = new System.Windows.Forms.Panel();
            this.historyTextBox = new System.Windows.Forms.TextBox();
            this.panel.SuspendLayout();
            this.historyPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // number1
            // 
            this.number1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.number1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.number1.Location = new System.Drawing.Point(1, 240);
            this.number1.Name = "number1";
            this.number1.Size = new System.Drawing.Size(80, 55);
            this.number1.TabIndex = 0;
            this.number1.Text = "1";
            this.number1.UseVisualStyleBackColor = false;
            this.number1.Click += new System.EventHandler(this.numberClicked);
            // 
            // erase
            // 
            this.erase.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.erase.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.erase.Location = new System.Drawing.Point(161, 185);
            this.erase.Name = "erase";
            this.erase.Size = new System.Drawing.Size(80, 55);
            this.erase.TabIndex = 1;
            this.erase.Text = "⌫";
            this.erase.UseVisualStyleBackColor = false;
            this.erase.Click += new System.EventHandler(this.eraseButtonClicked);
            // 
            // number8
            // 
            this.number8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.number8.Location = new System.Drawing.Point(81, 350);
            this.number8.Name = "number8";
            this.number8.Size = new System.Drawing.Size(80, 55);
            this.number8.TabIndex = 2;
            this.number8.Text = "8";
            this.number8.UseVisualStyleBackColor = true;
            this.number8.Click += new System.EventHandler(this.numberClicked);
            // 
            // number7
            // 
            this.number7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.number7.Location = new System.Drawing.Point(1, 350);
            this.number7.Name = "number7";
            this.number7.Size = new System.Drawing.Size(80, 55);
            this.number7.TabIndex = 3;
            this.number7.Text = "7";
            this.number7.UseVisualStyleBackColor = true;
            this.number7.Click += new System.EventHandler(this.numberClicked);
            // 
            // number6
            // 
            this.number6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.number6.Location = new System.Drawing.Point(161, 295);
            this.number6.Name = "number6";
            this.number6.Size = new System.Drawing.Size(80, 55);
            this.number6.TabIndex = 4;
            this.number6.Text = "6";
            this.number6.UseVisualStyleBackColor = true;
            this.number6.Click += new System.EventHandler(this.numberClicked);
            // 
            // number5
            // 
            this.number5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.number5.Location = new System.Drawing.Point(81, 295);
            this.number5.Name = "number5";
            this.number5.Size = new System.Drawing.Size(80, 55);
            this.number5.TabIndex = 5;
            this.number5.Text = "5";
            this.number5.UseVisualStyleBackColor = true;
            this.number5.Click += new System.EventHandler(this.numberClicked);
            // 
            // number4
            // 
            this.number4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.number4.Location = new System.Drawing.Point(1, 295);
            this.number4.Name = "number4";
            this.number4.Size = new System.Drawing.Size(80, 55);
            this.number4.TabIndex = 6;
            this.number4.Text = "4";
            this.number4.UseVisualStyleBackColor = true;
            this.number4.Click += new System.EventHandler(this.numberClicked);
            // 
            // number3
            // 
            this.number3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.number3.Location = new System.Drawing.Point(161, 240);
            this.number3.Name = "number3";
            this.number3.Size = new System.Drawing.Size(80, 55);
            this.number3.TabIndex = 7;
            this.number3.Text = "3";
            this.number3.UseVisualStyleBackColor = true;
            this.number3.Click += new System.EventHandler(this.numberClicked);
            // 
            // number2
            // 
            this.number2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.number2.Location = new System.Drawing.Point(81, 240);
            this.number2.Name = "number2";
            this.number2.Size = new System.Drawing.Size(80, 55);
            this.number2.TabIndex = 8;
            this.number2.Text = "2";
            this.number2.UseVisualStyleBackColor = true;
            this.number2.Click += new System.EventHandler(this.numberClicked);
            // 
            // equals
            // 
            this.equals.BackColor = System.Drawing.SystemColors.Highlight;
            this.equals.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.equals.Location = new System.Drawing.Point(241, 405);
            this.equals.Name = "equals";
            this.equals.Size = new System.Drawing.Size(80, 55);
            this.equals.TabIndex = 9;
            this.equals.Text = "=";
            this.equals.UseVisualStyleBackColor = false;
            this.equals.Click += new System.EventHandler(this.equalsClicked);
            // 
            // squareRoot
            // 
            this.squareRoot.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.squareRoot.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.squareRoot.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.squareRoot.Location = new System.Drawing.Point(81, 130);
            this.squareRoot.Name = "squareRoot";
            this.squareRoot.Size = new System.Drawing.Size(80, 55);
            this.squareRoot.TabIndex = 10;
            this.squareRoot.Text = "√";
            this.squareRoot.UseVisualStyleBackColor = false;
            this.squareRoot.Click += new System.EventHandler(this.functionClicked);
            // 
            // plus
            // 
            this.plus.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.plus.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.plus.Location = new System.Drawing.Point(241, 350);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(80, 55);
            this.plus.TabIndex = 11;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = false;
            this.plus.Click += new System.EventHandler(this.operatorClicked);
            // 
            // ceButton
            // 
            this.ceButton.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ceButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ceButton.Location = new System.Drawing.Point(1, 185);
            this.ceButton.Name = "ceButton";
            this.ceButton.Size = new System.Drawing.Size(80, 55);
            this.ceButton.TabIndex = 12;
            this.ceButton.Text = "CE";
            this.ceButton.UseVisualStyleBackColor = false;
            this.ceButton.Click += new System.EventHandler(this.ceButtonClicked);
            // 
            // modulo
            // 
            this.modulo.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.modulo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.modulo.Location = new System.Drawing.Point(1, 130);
            this.modulo.Name = "modulo";
            this.modulo.Size = new System.Drawing.Size(80, 55);
            this.modulo.TabIndex = 13;
            this.modulo.Text = "%";
            this.modulo.UseVisualStyleBackColor = false;
            this.modulo.Click += new System.EventHandler(this.operatorClicked);
            // 
            // plusMinus
            // 
            this.plusMinus.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.plusMinus.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.plusMinus.Location = new System.Drawing.Point(1, 405);
            this.plusMinus.Name = "plusMinus";
            this.plusMinus.Size = new System.Drawing.Size(80, 55);
            this.plusMinus.TabIndex = 14;
            this.plusMinus.Text = " ±";
            this.plusMinus.UseVisualStyleBackColor = false;
            this.plusMinus.Click += new System.EventHandler(this.functionClicked);
            // 
            // inverse
            // 
            this.inverse.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.inverse.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.inverse.Location = new System.Drawing.Point(241, 130);
            this.inverse.Name = "inverse";
            this.inverse.Size = new System.Drawing.Size(80, 55);
            this.inverse.TabIndex = 15;
            this.inverse.Text = "1/χ";
            this.inverse.UseVisualStyleBackColor = false;
            this.inverse.Click += new System.EventHandler(this.functionClicked);
            // 
            // dot
            // 
            this.dot.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.dot.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dot.Location = new System.Drawing.Point(161, 405);
            this.dot.Name = "dot";
            this.dot.Size = new System.Drawing.Size(80, 55);
            this.dot.TabIndex = 16;
            this.dot.Text = ".";
            this.dot.UseVisualStyleBackColor = false;
            this.dot.Click += new System.EventHandler(this.numberClicked);
            // 
            // square
            // 
            this.square.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.square.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.square.Location = new System.Drawing.Point(161, 130);
            this.square.Name = "square";
            this.square.Size = new System.Drawing.Size(80, 55);
            this.square.TabIndex = 17;
            this.square.Text = "χ2";
            this.square.UseVisualStyleBackColor = false;
            this.square.Click += new System.EventHandler(this.functionClicked);
            // 
            // divide
            // 
            this.divide.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.divide.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.divide.Location = new System.Drawing.Point(241, 185);
            this.divide.Name = "divide";
            this.divide.Size = new System.Drawing.Size(80, 55);
            this.divide.TabIndex = 18;
            this.divide.Text = "÷";
            this.divide.UseVisualStyleBackColor = false;
            this.divide.Click += new System.EventHandler(this.operatorClicked);
            // 
            // multiply
            // 
            this.multiply.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.multiply.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.multiply.Location = new System.Drawing.Point(241, 240);
            this.multiply.Name = "multiply";
            this.multiply.Size = new System.Drawing.Size(80, 55);
            this.multiply.TabIndex = 19;
            this.multiply.Text = "×";
            this.multiply.UseVisualStyleBackColor = false;
            this.multiply.Click += new System.EventHandler(this.operatorClicked);
            // 
            // minus
            // 
            this.minus.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.minus.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.minus.Location = new System.Drawing.Point(241, 295);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(80, 55);
            this.minus.TabIndex = 20;
            this.minus.Text = "-";
            this.minus.UseVisualStyleBackColor = false;
            this.minus.Click += new System.EventHandler(this.operatorClicked);
            // 
            // cButton
            // 
            this.cButton.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.cButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cButton.Location = new System.Drawing.Point(81, 185);
            this.cButton.Name = "cButton";
            this.cButton.Size = new System.Drawing.Size(80, 55);
            this.cButton.TabIndex = 21;
            this.cButton.Text = "C";
            this.cButton.UseVisualStyleBackColor = false;
            this.cButton.Click += new System.EventHandler(this.cButtonClicked);
            // 
            // number0
            // 
            this.number0.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.number0.Location = new System.Drawing.Point(81, 405);
            this.number0.Name = "number0";
            this.number0.Size = new System.Drawing.Size(80, 55);
            this.number0.TabIndex = 22;
            this.number0.Text = "0";
            this.number0.UseVisualStyleBackColor = true;
            this.number0.Click += new System.EventHandler(this.numberClicked);
            // 
            // number9
            // 
            this.number9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.number9.Location = new System.Drawing.Point(161, 350);
            this.number9.Name = "number9";
            this.number9.Size = new System.Drawing.Size(80, 55);
            this.number9.TabIndex = 23;
            this.number9.Text = "9";
            this.number9.UseVisualStyleBackColor = true;
            this.number9.Click += new System.EventHandler(this.numberClicked);
            // 
            // panel
            // 
            this.panel.Controls.Add(this.currentExpressionTextBox);
            this.panel.Controls.Add(this.historyButton);
            this.panel.Controls.Add(this.textBox);
            this.panel.Location = new System.Drawing.Point(1, 4);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(320, 120);
            this.panel.TabIndex = 24;
            // 
            // currentExpressionTextBox
            // 
            this.currentExpressionTextBox.BackColor = System.Drawing.SystemColors.WindowText;
            this.currentExpressionTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.currentExpressionTextBox.Enabled = false;
            this.currentExpressionTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.currentExpressionTextBox.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.currentExpressionTextBox.Location = new System.Drawing.Point(48, 17);
            this.currentExpressionTextBox.Multiline = true;
            this.currentExpressionTextBox.Name = "currentExpressionTextBox";
            this.currentExpressionTextBox.Size = new System.Drawing.Size(269, 33);
            this.currentExpressionTextBox.TabIndex = 2;
            this.currentExpressionTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // historyButton
            // 
            this.historyButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.historyButton.FlatAppearance.BorderSize = 0;
            this.historyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.historyButton.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.historyButton.ForeColor = System.Drawing.Color.White;
            this.historyButton.Location = new System.Drawing.Point(0, 0);
            this.historyButton.Name = "historyButton";
            this.historyButton.Size = new System.Drawing.Size(42, 44);
            this.historyButton.TabIndex = 1;
            this.historyButton.Text = "⟲";
            this.historyButton.UseVisualStyleBackColor = false;
            this.historyButton.Click += new System.EventHandler(this.historyClicked);
            // 
            // textBox
            // 
            this.textBox.BackColor = System.Drawing.SystemColors.WindowText;
            this.textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.textBox.Location = new System.Drawing.Point(3, 69);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(314, 48);
            this.textBox.TabIndex = 0;
            this.textBox.Text = "0";
            this.textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // historyPanel
            // 
            this.historyPanel.Controls.Add(this.historyTextBox);
            this.historyPanel.Location = new System.Drawing.Point(1, 54);
            this.historyPanel.Name = "historyPanel";
            this.historyPanel.Size = new System.Drawing.Size(320, 406);
            this.historyPanel.TabIndex = 25;
            this.historyPanel.Visible = false;
            // 
            // historyTextBox
            // 
            this.historyTextBox.Location = new System.Drawing.Point(0, 0);
            this.historyTextBox.BackColor = System.Drawing.SystemColors.ControlText;
            this.historyTextBox.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.historyTextBox.ReadOnly = true;
            this.historyTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.historyTextBox.Multiline = true;
            this.historyTextBox.Name = "historyTextBox";
            this.historyTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.historyTextBox.Size = new System.Drawing.Size(320, 406);
            this.historyTextBox.TabIndex = 0;
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(322, 462);
            this.Controls.Add(this.historyPanel);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.number9);
            this.Controls.Add(this.number0);
            this.Controls.Add(this.cButton);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.multiply);
            this.Controls.Add(this.divide);
            this.Controls.Add(this.square);
            this.Controls.Add(this.dot);
            this.Controls.Add(this.inverse);
            this.Controls.Add(this.plusMinus);
            this.Controls.Add(this.modulo);
            this.Controls.Add(this.ceButton);
            this.Controls.Add(this.plus);
            this.Controls.Add(this.squareRoot);
            this.Controls.Add(this.equals);
            this.Controls.Add(this.number2);
            this.Controls.Add(this.number3);
            this.Controls.Add(this.number4);
            this.Controls.Add(this.number5);
            this.Controls.Add(this.number6);
            this.Controls.Add(this.number7);
            this.Controls.Add(this.number8);
            this.Controls.Add(this.erase);
            this.Controls.Add(this.number1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "Calculator";
            this.Text = "Calculator";
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.historyPanel.ResumeLayout(false);
            this.historyPanel.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private Button number1;
        private Button erase;
        private Button number8;
        private Button number7;
        private Button number6;
        private Button number5;
        private Button number4;
        private Button number3;
        private Button number2;
        private Button equals;
        private Button squareRoot;
        private Button plus;
        private Button ceButton;
        private Button modulo;
        private Button plusMinus;
        private Button inverse;
        private Button dot;
        private Button square;
        private Button divide;
        private Button multiply;
        private Button minus;
        private Button cButton;
        private Button number0;
        private Button number9;
        private Panel panel;
        private TextBox textBox;
        private Button historyButton;
        private Panel historyPanel;
        private TextBox currentExpressionTextBox;
        private TextBox historyTextBox;
    }
}