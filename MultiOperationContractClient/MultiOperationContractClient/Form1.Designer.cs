namespace MultiOperationContractClient
{
    partial class Form1
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
            this.firstNumLabel = new System.Windows.Forms.Label();
            this.firstNumTextBox = new System.Windows.Forms.TextBox();
            this.LastNumLabel = new System.Windows.Forms.Label();
            this.LastNumTextBox = new System.Windows.Forms.TextBox();
            this.AddLabel = new System.Windows.Forms.Label();
            this.AddTextBox = new System.Windows.Forms.TextBox();
            this.SubtractLabel = new System.Windows.Forms.Label();
            this.SubTextBox = new System.Windows.Forms.TextBox();
            this.Calculation = new System.Windows.Forms.GroupBox();
            this.MultiplicationLabel = new System.Windows.Forms.Label();
            this.MutliplicationTextBox = new System.Windows.Forms.TextBox();
            this.DivisionLabel = new System.Windows.Forms.Label();
            this.DivTextBox = new System.Windows.Forms.TextBox();
            this.ModuloLabel = new System.Windows.Forms.Label();
            this.ModuloTextBox = new System.Windows.Forms.TextBox();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Calculation.SuspendLayout();
            this.SuspendLayout();
            // 
            // firstNumLabel
            // 
            this.firstNumLabel.AutoSize = true;
            this.firstNumLabel.Location = new System.Drawing.Point(74, 39);
            this.firstNumLabel.Name = "firstNumLabel";
            this.firstNumLabel.Size = new System.Drawing.Size(53, 13);
            this.firstNumLabel.TabIndex = 0;
            this.firstNumLabel.Text = "Number 1";
            // 
            // firstNumTextBox
            // 
            this.firstNumTextBox.Location = new System.Drawing.Point(160, 36);
            this.firstNumTextBox.Name = "firstNumTextBox";
            this.firstNumTextBox.Size = new System.Drawing.Size(100, 20);
            this.firstNumTextBox.TabIndex = 1;
            // 
            // LastNumLabel
            // 
            this.LastNumLabel.AutoSize = true;
            this.LastNumLabel.Location = new System.Drawing.Point(74, 76);
            this.LastNumLabel.Name = "LastNumLabel";
            this.LastNumLabel.Size = new System.Drawing.Size(53, 13);
            this.LastNumLabel.TabIndex = 2;
            this.LastNumLabel.Text = "Number 2";
            // 
            // LastNumTextBox
            // 
            this.LastNumTextBox.Location = new System.Drawing.Point(160, 76);
            this.LastNumTextBox.Name = "LastNumTextBox";
            this.LastNumTextBox.Size = new System.Drawing.Size(100, 20);
            this.LastNumTextBox.TabIndex = 3;
            // 
            // AddLabel
            // 
            this.AddLabel.AutoSize = true;
            this.AddLabel.Location = new System.Drawing.Point(51, 196);
            this.AddLabel.Name = "AddLabel";
            this.AddLabel.Size = new System.Drawing.Size(45, 13);
            this.AddLabel.TabIndex = 4;
            this.AddLabel.Text = "Addition";
            // 
            // AddTextBox
            // 
            this.AddTextBox.Location = new System.Drawing.Point(118, 193);
            this.AddTextBox.Name = "AddTextBox";
            this.AddTextBox.Size = new System.Drawing.Size(100, 20);
            this.AddTextBox.TabIndex = 5;
            // 
            // SubtractLabel
            // 
            this.SubtractLabel.AutoSize = true;
            this.SubtractLabel.Location = new System.Drawing.Point(51, 234);
            this.SubtractLabel.Name = "SubtractLabel";
            this.SubtractLabel.Size = new System.Drawing.Size(47, 13);
            this.SubtractLabel.TabIndex = 6;
            this.SubtractLabel.Text = "Subtract";
            // 
            // SubTextBox
            // 
            this.SubTextBox.Location = new System.Drawing.Point(118, 231);
            this.SubTextBox.Name = "SubTextBox";
            this.SubTextBox.Size = new System.Drawing.Size(100, 20);
            this.SubTextBox.TabIndex = 7;
            // 
            // Calculation
            // 
            this.Calculation.Controls.Add(this.button2);
            this.Calculation.Controls.Add(this.button1);
            this.Calculation.Controls.Add(this.ModuloTextBox);
            this.Calculation.Controls.Add(this.ModuloLabel);
            this.Calculation.Controls.Add(this.DivTextBox);
            this.Calculation.Controls.Add(this.DivisionLabel);
            this.Calculation.Controls.Add(this.MutliplicationTextBox);
            this.Calculation.Controls.Add(this.MultiplicationLabel);
            this.Calculation.Location = new System.Drawing.Point(12, 132);
            this.Calculation.Name = "Calculation";
            this.Calculation.Size = new System.Drawing.Size(456, 206);
            this.Calculation.TabIndex = 8;
            this.Calculation.TabStop = false;
            this.Calculation.Text = "groupBox1";
            this.Calculation.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // MultiplicationLabel
            // 
            this.MultiplicationLabel.AutoSize = true;
            this.MultiplicationLabel.Location = new System.Drawing.Point(242, 64);
            this.MultiplicationLabel.Name = "MultiplicationLabel";
            this.MultiplicationLabel.Size = new System.Drawing.Size(68, 13);
            this.MultiplicationLabel.TabIndex = 5;
            this.MultiplicationLabel.Text = "Multiplication";
            // 
            // MutliplicationTextBox
            // 
            this.MutliplicationTextBox.Location = new System.Drawing.Point(326, 61);
            this.MutliplicationTextBox.Name = "MutliplicationTextBox";
            this.MutliplicationTextBox.Size = new System.Drawing.Size(100, 20);
            this.MutliplicationTextBox.TabIndex = 6;
            // 
            // DivisionLabel
            // 
            this.DivisionLabel.AutoSize = true;
            this.DivisionLabel.Location = new System.Drawing.Point(242, 102);
            this.DivisionLabel.Name = "DivisionLabel";
            this.DivisionLabel.Size = new System.Drawing.Size(44, 13);
            this.DivisionLabel.TabIndex = 7;
            this.DivisionLabel.Text = "Division";
            // 
            // DivTextBox
            // 
            this.DivTextBox.Location = new System.Drawing.Point(326, 99);
            this.DivTextBox.Name = "DivTextBox";
            this.DivTextBox.Size = new System.Drawing.Size(100, 20);
            this.DivTextBox.TabIndex = 8;
            // 
            // ModuloLabel
            // 
            this.ModuloLabel.AutoSize = true;
            this.ModuloLabel.Location = new System.Drawing.Point(162, 145);
            this.ModuloLabel.Name = "ModuloLabel";
            this.ModuloLabel.Size = new System.Drawing.Size(47, 13);
            this.ModuloLabel.TabIndex = 9;
            this.ModuloLabel.Text = "Modulus";
            // 
            // ModuloTextBox
            // 
            this.ModuloTextBox.Location = new System.Drawing.Point(215, 142);
            this.ModuloTextBox.Name = "ModuloTextBox";
            this.ModuloTextBox.Size = new System.Drawing.Size(100, 20);
            this.ModuloTextBox.TabIndex = 10;
            // 
            // CalculateButton
            // 
            this.CalculateButton.Location = new System.Drawing.Point(296, 76);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(107, 23);
            this.CalculateButton.TabIndex = 9;
            this.CalculateButton.Text = "Calculate";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(341, 142);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Modulus";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(326, 19);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 350);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.SubTextBox);
            this.Controls.Add(this.SubtractLabel);
            this.Controls.Add(this.AddTextBox);
            this.Controls.Add(this.AddLabel);
            this.Controls.Add(this.LastNumTextBox);
            this.Controls.Add(this.LastNumLabel);
            this.Controls.Add(this.firstNumTextBox);
            this.Controls.Add(this.firstNumLabel);
            this.Controls.Add(this.Calculation);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Calculation.ResumeLayout(false);
            this.Calculation.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label firstNumLabel;
        private System.Windows.Forms.TextBox firstNumTextBox;
        private System.Windows.Forms.Label LastNumLabel;
        private System.Windows.Forms.TextBox LastNumTextBox;
        private System.Windows.Forms.Label AddLabel;
        private System.Windows.Forms.TextBox AddTextBox;
        private System.Windows.Forms.Label SubtractLabel;
        private System.Windows.Forms.TextBox SubTextBox;
        private System.Windows.Forms.GroupBox Calculation;
        private System.Windows.Forms.TextBox DivTextBox;
        private System.Windows.Forms.Label DivisionLabel;
        private System.Windows.Forms.TextBox MutliplicationTextBox;
        private System.Windows.Forms.Label MultiplicationLabel;
        private System.Windows.Forms.TextBox ModuloTextBox;
        private System.Windows.Forms.Label ModuloLabel;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

