namespace BitcoinTrader
{
    partial class BitTrex
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
            this.btnGetMarketSummary = new System.Windows.Forms.Button();
            this.txbResult = new System.Windows.Forms.TextBox();
            this.txbBitcoinName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnGetMarketSummary
            // 
            this.btnGetMarketSummary.Location = new System.Drawing.Point(143, 37);
            this.btnGetMarketSummary.Name = "btnGetMarketSummary";
            this.btnGetMarketSummary.Size = new System.Drawing.Size(128, 23);
            this.btnGetMarketSummary.TabIndex = 0;
            this.btnGetMarketSummary.Text = "Get Market Summary";
            this.btnGetMarketSummary.UseVisualStyleBackColor = true;
            this.btnGetMarketSummary.Click += new System.EventHandler(this.btnGetMarketSummary_Click);
            // 
            // txbResult
            // 
            this.txbResult.Location = new System.Drawing.Point(12, 81);
            this.txbResult.Multiline = true;
            this.txbResult.Name = "txbResult";
            this.txbResult.Size = new System.Drawing.Size(633, 337);
            this.txbResult.TabIndex = 1;
            // 
            // txbBitcoinName
            // 
            this.txbBitcoinName.Location = new System.Drawing.Point(12, 39);
            this.txbBitcoinName.Name = "txbBitcoinName";
            this.txbBitcoinName.Size = new System.Drawing.Size(116, 20);
            this.txbBitcoinName.TabIndex = 2;
            this.txbBitcoinName.Text = "BTC-LTC";
            // 
            // BitTrex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 446);
            this.Controls.Add(this.txbBitcoinName);
            this.Controls.Add(this.txbResult);
            this.Controls.Add(this.btnGetMarketSummary);
            this.Name = "BitTrex";
            this.Text = "BitTrex";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGetMarketSummary;
        private System.Windows.Forms.TextBox txbResult;
        private System.Windows.Forms.TextBox txbBitcoinName;
    }
}

