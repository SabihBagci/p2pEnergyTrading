namespace p2pEnergyTrading
    
{
    
    partial class SellPrompt
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
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.EnergyInput = new System.Windows.Forms.NumericUpDown();
            this.PriceInput = new System.Windows.Forms.NumericUpDown();
            this.lblEnergy = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.EnergyInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PriceInput)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConfirm
            // 
            this.btnConfirm.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnConfirm.Location = new System.Drawing.Point(38, 92);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnConfirm.TabIndex = 0;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(119, 92);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // EnergyInput
            // 
            this.EnergyInput.Location = new System.Drawing.Point(88, 18);
            this.EnergyInput.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.EnergyInput.Name = "EnergyInput";
            this.EnergyInput.Size = new System.Drawing.Size(120, 23);
            this.EnergyInput.TabIndex = 2;
            this.EnergyInput.ValueChanged += new System.EventHandler(this.EnergyInput_ValueChanged);
            // 
            // PriceInput
            // 
            this.PriceInput.Location = new System.Drawing.Point(88, 47);
            this.PriceInput.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.PriceInput.Name = "PriceInput";
            this.PriceInput.Size = new System.Drawing.Size(120, 23);
            this.PriceInput.TabIndex = 3;
            this.PriceInput.ValueChanged += new System.EventHandler(this.PriceInput_ValueChanged);
            // 
            // lblEnergy
            // 
            this.lblEnergy.AutoSize = true;
            this.lblEnergy.Location = new System.Drawing.Point(12, 18);
            this.lblEnergy.Name = "lblEnergy";
            this.lblEnergy.Size = new System.Drawing.Size(43, 15);
            this.lblEnergy.TabIndex = 4;
            this.lblEnergy.Text = "Energy";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(12, 41);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(33, 15);
            this.lblPrice.TabIndex = 5;
            this.lblPrice.Text = "Price";
            // 
            // SellPrompt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(232, 150);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblEnergy);
            this.Controls.Add(this.PriceInput);
            this.Controls.Add(this.EnergyInput);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "SellPrompt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Sell Power";
            this.Load += new System.EventHandler(this.SellPrompt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EnergyInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PriceInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.NumericUpDown EnergyInput;
        private System.Windows.Forms.NumericUpDown PriceInput;
        private System.Windows.Forms.Label lblEnergy;
        private System.Windows.Forms.Label lblPrice;
    }
}