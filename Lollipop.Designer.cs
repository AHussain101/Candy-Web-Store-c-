
namespace AarfansCandyStore_AarfanH3
{
    partial class Lollipop
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
            this.FlavorLabel = new System.Windows.Forms.Label();
            this.LolliFlavorCombo = new System.Windows.Forms.ComboBox();
            this.ReturnToMainButton = new System.Windows.Forms.Button();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.LollipopPriceCombo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // FlavorLabel
            // 
            this.FlavorLabel.AutoSize = true;
            this.FlavorLabel.Location = new System.Drawing.Point(101, 73);
            this.FlavorLabel.Name = "FlavorLabel";
            this.FlavorLabel.Size = new System.Drawing.Size(117, 15);
            this.FlavorLabel.TabIndex = 0;
            this.FlavorLabel.Text = "Select lollipop flavor:";
            // 
            // LolliFlavorCombo
            // 
            this.LolliFlavorCombo.FormattingEnabled = true;
            this.LolliFlavorCombo.Items.AddRange(new object[] {
            "Lemon",
            "Strawberry",
            "Grape",
            "Orange",
            "Watermelon"});
            this.LolliFlavorCombo.Location = new System.Drawing.Point(101, 91);
            this.LolliFlavorCombo.Name = "LolliFlavorCombo";
            this.LolliFlavorCombo.Size = new System.Drawing.Size(135, 23);
            this.LolliFlavorCombo.TabIndex = 1;
            this.LolliFlavorCombo.SelectedIndexChanged += new System.EventHandler(this.LolliFlavorCombo_SelectedIndexChanged);
            // 
            // ReturnToMainButton
            // 
            this.ReturnToMainButton.Location = new System.Drawing.Point(101, 314);
            this.ReturnToMainButton.Name = "ReturnToMainButton";
            this.ReturnToMainButton.Size = new System.Drawing.Size(135, 23);
            this.ReturnToMainButton.TabIndex = 2;
            this.ReturnToMainButton.Text = "Return to main Screen";
            this.ReturnToMainButton.UseVisualStyleBackColor = true;
            this.ReturnToMainButton.Click += new System.EventHandler(this.ReturnToMainButton_Click);
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Location = new System.Drawing.Point(101, 159);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(121, 15);
            this.PriceLabel.TabIndex = 3;
            this.PriceLabel.Text = "Select Quantity/Price:";
            // 
            // LollipopPriceCombo
            // 
            this.LollipopPriceCombo.FormattingEnabled = true;
            this.LollipopPriceCombo.Items.AddRange(new object[] {
            "10 for $3",
            "20 for $5",
            "30 for $9"});
            this.LollipopPriceCombo.Location = new System.Drawing.Point(101, 177);
            this.LollipopPriceCombo.Name = "LollipopPriceCombo";
            this.LollipopPriceCombo.Size = new System.Drawing.Size(135, 23);
            this.LollipopPriceCombo.TabIndex = 4;
            this.LollipopPriceCombo.SelectedIndexChanged += new System.EventHandler(this.LollipopPriceCombo_SelectedIndexChanged);
            // 
            // Lollipop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LollipopPriceCombo);
            this.Controls.Add(this.PriceLabel);
            this.Controls.Add(this.ReturnToMainButton);
            this.Controls.Add(this.LolliFlavorCombo);
            this.Controls.Add(this.FlavorLabel);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Lollipop";
            this.Text = "Lollipop";
            this.Load += new System.EventHandler(this.Lollipop_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FlavorLabel;
        private System.Windows.Forms.ComboBox LolliFlavorCombo;
        private System.Windows.Forms.Button ReturnToMainButton;
        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.ComboBox LollipopPriceCombo;
    }
}
