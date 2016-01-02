namespace budgetManagement
{
    partial class CreateAccount
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
            this.accountName = new System.Windows.Forms.Label();
            this.accountNameInput = new System.Windows.Forms.TextBox();
            this.initialBalance = new System.Windows.Forms.Label();
            this.initialBalanceInput = new System.Windows.Forms.NumericUpDown();
            this.save = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.initialBalanceInput)).BeginInit();
            this.SuspendLayout();
            // 
            // accountName
            // 
            this.accountName.AutoSize = true;
            this.accountName.Location = new System.Drawing.Point(36, 52);
            this.accountName.Name = "accountName";
            this.accountName.Size = new System.Drawing.Size(114, 20);
            this.accountName.TabIndex = 0;
            this.accountName.Text = "Account Name";
            // 
            // accountNameInput
            // 
            this.accountNameInput.Location = new System.Drawing.Point(182, 52);
            this.accountNameInput.Name = "accountNameInput";
            this.accountNameInput.Size = new System.Drawing.Size(232, 26);
            this.accountNameInput.TabIndex = 1;
            this.accountNameInput.TextChanged += new System.EventHandler(this.accountNameInput_TextChanged);
            // 
            // initialBalance
            // 
            this.initialBalance.AutoSize = true;
            this.initialBalance.Location = new System.Drawing.Point(36, 126);
            this.initialBalance.Name = "initialBalance";
            this.initialBalance.Size = new System.Drawing.Size(108, 20);
            this.initialBalance.TabIndex = 2;
            this.initialBalance.Text = "Initial Balance";
            // 
            // initialBalanceInput
            // 
            this.initialBalanceInput.DecimalPlaces = 2;
            this.initialBalanceInput.Location = new System.Drawing.Point(182, 126);
            this.initialBalanceInput.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.initialBalanceInput.Minimum = new decimal(new int[] {
            1000000000,
            0,
            0,
            -2147483648});
            this.initialBalanceInput.Name = "initialBalanceInput";
            this.initialBalanceInput.Size = new System.Drawing.Size(232, 26);
            this.initialBalanceInput.TabIndex = 3;
            this.initialBalanceInput.ThousandsSeparator = true;
            // 
            // save
            // 
            this.save.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.save.Location = new System.Drawing.Point(140, 189);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(174, 37);
            this.save.TabIndex = 4;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // CreateAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 263);
            this.Controls.Add(this.save);
            this.Controls.Add(this.initialBalanceInput);
            this.Controls.Add(this.initialBalance);
            this.Controls.Add(this.accountNameInput);
            this.Controls.Add(this.accountName);
            this.Name = "CreateAccount";
            this.Text = "Create a new account";
            ((System.ComponentModel.ISupportInitialize)(this.initialBalanceInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label accountName;
        private System.Windows.Forms.TextBox accountNameInput;
        private System.Windows.Forms.Label initialBalance;
        private System.Windows.Forms.NumericUpDown initialBalanceInput;
        private System.Windows.Forms.Button save;
    }
}