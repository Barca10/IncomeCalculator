namespace IncomeCalculator
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
            this.RateTextBox = new System.Windows.Forms.RichTextBox();
            this.RateLabel = new System.Windows.Forms.Label();
            this.Calculate = new System.Windows.Forms.Button();
            this.IncomeBeforeTaxLabel = new System.Windows.Forms.Label();
            this.IncomeAfterTaxLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // RateTextBox
            // 
            this.RateTextBox.Location = new System.Drawing.Point(121, 44);
            this.RateTextBox.Name = "RateTextBox";
            this.RateTextBox.Size = new System.Drawing.Size(353, 34);
            this.RateTextBox.TabIndex = 0;
            this.RateTextBox.Text = "";
            // 
            // RateLabel
            // 
            this.RateLabel.Location = new System.Drawing.Point(12, 44);
            this.RateLabel.Name = "RateLabel";
            this.RateLabel.Size = new System.Drawing.Size(95, 41);
            this.RateLabel.TabIndex = 1;
            this.RateLabel.Text = "Rate";
            this.RateLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // Calculate
            // 
            this.Calculate.Location = new System.Drawing.Point(121, 149);
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(143, 54);
            this.Calculate.TabIndex = 2;
            this.Calculate.Text = "Submit";
            this.Calculate.UseVisualStyleBackColor = true;
            this.Calculate.Click += new System.EventHandler(this.Calculate_Click);
            // 
            // DisplayValue
            // 
            this.IncomeBeforeTaxLabel.Location = new System.Drawing.Point(132, 281);
            this.IncomeBeforeTaxLabel.Name = "DisplayValue";
            this.IncomeBeforeTaxLabel.Size = new System.Drawing.Size(529, 41);
            this.IncomeBeforeTaxLabel.TabIndex = 3;
            // 
            // label1
            // 
            this.IncomeAfterTaxLabel.AutoSize = false;
            this.IncomeAfterTaxLabel.Location = new System.Drawing.Point(494, 360);
            this.IncomeAfterTaxLabel.Name = "IncomeAfterTaxLabel";
            this.IncomeAfterTaxLabel.Size = new System.Drawing.Size(51, 20);
            this.IncomeAfterTaxLabel.TabIndex = 4;
            this.IncomeAfterTaxLabel.Text = "IncomeAfterTaxLabel";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.IncomeAfterTaxLabel);
            this.Controls.Add(this.IncomeBeforeTaxLabel);
            this.Controls.Add(this.Calculate);
            this.Controls.Add(this.RateLabel);
            this.Controls.Add(this.RateTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox RateTextBox;
        private System.Windows.Forms.Label RateLabel;
        private System.Windows.Forms.Button Calculate;
        private System.Windows.Forms.Label IncomeBeforeTaxLabel;
        private System.Windows.Forms.Label IncomeAfterTaxLabel;
    }
}

