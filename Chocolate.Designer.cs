namespace AarfansCandyStore_AarfanH3
{
    partial class Chocolate
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
            this.ChocolateChoiceLabel = new System.Windows.Forms.Label();
            this.ChocolateChoiceCombo = new System.Windows.Forms.ComboBox();
            this.MainScreenButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ChocolatePriceCombo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // ChocolateChoiceLabel
            // 
            this.ChocolateChoiceLabel.AutoSize = true;
            this.ChocolateChoiceLabel.Location = new System.Drawing.Point(95, 74);
            this.ChocolateChoiceLabel.Name = "ChocolateChoiceLabel";
            this.ChocolateChoiceLabel.Size = new System.Drawing.Size(149, 15);
            this.ChocolateChoiceLabel.TabIndex = 0;
            this.ChocolateChoiceLabel.Text = "Pick the Chocolate Choice:";
            // 
            // ChocolateChoiceCombo
            // 
            this.ChocolateChoiceCombo.FormattingEnabled = true;
            this.ChocolateChoiceCombo.Items.AddRange(new object[] {
            "Milk Chocolate",
            "Dark Chocolate",
            "White Chocolate"});
            this.ChocolateChoiceCombo.Location = new System.Drawing.Point(95, 92);
            this.ChocolateChoiceCombo.Name = "ChocolateChoiceCombo";
            this.ChocolateChoiceCombo.Size = new System.Drawing.Size(209, 23);
            this.ChocolateChoiceCombo.TabIndex = 1;
            this.ChocolateChoiceCombo.SelectedIndexChanged += new System.EventHandler(this.ChocolateChoiceCombo_SelectedIndexChanged);
            // 
            // MainScreenButton
            // 
            this.MainScreenButton.Location = new System.Drawing.Point(95, 321);
            this.MainScreenButton.Name = "MainScreenButton";
            this.MainScreenButton.Size = new System.Drawing.Size(137, 23);
            this.MainScreenButton.TabIndex = 2;
            this.MainScreenButton.Text = "Return to main screen";
            this.MainScreenButton.UseVisualStyleBackColor = true;
            this.MainScreenButton.Click += new System.EventHandler(this.MainScreenButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Select quantity/price:";
            // 
            // ChocolatePriceCombo
            // 
            this.ChocolatePriceCombo.FormattingEnabled = true;
            this.ChocolatePriceCombo.Items.AddRange(new object[] {
            "2 bars for $3",
            "7 bars for $10",
            "12 bars for $15"});
            this.ChocolatePriceCombo.Location = new System.Drawing.Point(95, 156);
            this.ChocolatePriceCombo.Name = "ChocolatePriceCombo";
            this.ChocolatePriceCombo.Size = new System.Drawing.Size(209, 23);
            this.ChocolatePriceCombo.TabIndex = 4;
            this.ChocolatePriceCombo.SelectedIndexChanged += new System.EventHandler(this.ChocolatePriceCombo_SelectedIndexChanged);
            // 
            // Chocolate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ChocolatePriceCombo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MainScreenButton);
            this.Controls.Add(this.ChocolateChoiceCombo);
            this.Controls.Add(this.ChocolateChoiceLabel);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Chocolate";
            this.Text = "Chocolate";
            this.Load += new System.EventHandler(this.Chocolate_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ChocolateChoiceLabel;
        private System.Windows.Forms.ComboBox ChocolateChoiceCombo;
        private System.Windows.Forms.Button MainScreenButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ChocolatePriceCombo;
    }
}
