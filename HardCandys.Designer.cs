
namespace AarfansCandyStore_AarfanH3
{
    partial class HardCandys
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
            this.HardCandyChoiceLabel = new System.Windows.Forms.Label();
            this.CandyFlavorCombo = new System.Windows.Forms.ComboBox();
            this.MainScreenButton = new System.Windows.Forms.Button();
            this.ChocoPriceLabel = new System.Windows.Forms.Label();
            this.CandyPriceCombo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // HardCandyChoiceLabel
            // 
            this.HardCandyChoiceLabel.AutoSize = true;
            this.HardCandyChoiceLabel.Location = new System.Drawing.Point(112, 68);
            this.HardCandyChoiceLabel.Name = "HardCandyChoiceLabel";
            this.HardCandyChoiceLabel.Size = new System.Drawing.Size(156, 15);
            this.HardCandyChoiceLabel.TabIndex = 0;
            this.HardCandyChoiceLabel.Text = "Select the hard candy flavor:";
            // 
            // CandyFlavorCombo
            // 
            this.CandyFlavorCombo.BackColor = System.Drawing.SystemColors.Window;
            this.CandyFlavorCombo.FormattingEnabled = true;
            this.CandyFlavorCombo.Items.AddRange(new object[] {
            "Grape",
            "Peach",
            "Orange",
            "Mango"});
            this.CandyFlavorCombo.Location = new System.Drawing.Point(112, 86);
            this.CandyFlavorCombo.Name = "CandyFlavorCombo";
            this.CandyFlavorCombo.Size = new System.Drawing.Size(156, 23);
            this.CandyFlavorCombo.TabIndex = 1;
            this.CandyFlavorCombo.SelectedIndexChanged += new System.EventHandler(this.CandyFlavorCombo_SelectedIndexChanged);
            // 
            // MainScreenButton
            // 
            this.MainScreenButton.BackColor = System.Drawing.Color.White;
            this.MainScreenButton.ForeColor = System.Drawing.Color.Black;
            this.MainScreenButton.Location = new System.Drawing.Point(112, 308);
            this.MainScreenButton.Name = "MainScreenButton";
            this.MainScreenButton.Size = new System.Drawing.Size(156, 23);
            this.MainScreenButton.TabIndex = 2;
            this.MainScreenButton.Text = "Return to main screen";
            this.MainScreenButton.UseVisualStyleBackColor = false;
            this.MainScreenButton.Click += new System.EventHandler(this.MainScreenButton_Click);
            // 
            // ChocoPriceLabel
            // 
            this.ChocoPriceLabel.AutoSize = true;
            this.ChocoPriceLabel.Location = new System.Drawing.Point(112, 137);
            this.ChocoPriceLabel.Name = "ChocoPriceLabel";
            this.ChocoPriceLabel.Size = new System.Drawing.Size(139, 15);
            this.ChocoPriceLabel.TabIndex = 3;
            this.ChocoPriceLabel.Text = "Select the quantity/price:";
            // 
            // CandyPriceCombo
            // 
            this.CandyPriceCombo.FormattingEnabled = true;
            this.CandyPriceCombo.Items.AddRange(new object[] {
            "20 for $5",
            "50 for $10",
            "120 for $20"});
            this.CandyPriceCombo.Location = new System.Drawing.Point(112, 171);
            this.CandyPriceCombo.Name = "CandyPriceCombo";
            this.CandyPriceCombo.Size = new System.Drawing.Size(156, 23);
            this.CandyPriceCombo.TabIndex = 4;
            this.CandyPriceCombo.SelectedIndexChanged += new System.EventHandler(this.CandyPriceCombo_SelectedIndexChanged);
            // 
            // HardCandys
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CandyPriceCombo);
            this.Controls.Add(this.ChocoPriceLabel);
            this.Controls.Add(this.MainScreenButton);
            this.Controls.Add(this.CandyFlavorCombo);
            this.Controls.Add(this.HardCandyChoiceLabel);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "HardCandys";
            this.Text = "HardCandys";
            this.Load += new System.EventHandler(this.HardCandys_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label HardCandyChoiceLabel;
        private System.Windows.Forms.ComboBox CandyFlavorCombo;
        private System.Windows.Forms.Button MainScreenButton;
        private System.Windows.Forms.Label ChocoPriceLabel;
        private System.Windows.Forms.ComboBox CandyPriceCombo;
    }
}
