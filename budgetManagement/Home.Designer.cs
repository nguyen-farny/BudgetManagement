namespace budgetManagement
{
    partial class Home
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelSolde = new System.Windows.Forms.Label();
            this.createOperation = new System.Windows.Forms.Button();
            this.detail = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.labelSolde);
            this.groupBox1.Controls.Add(this.createOperation);
            this.groupBox1.Controls.Add(this.detail);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(13, 12);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(568, 172);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // labelSolde
            // 
            this.labelSolde.AutoSize = true;
            this.labelSolde.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSolde.Location = new System.Drawing.Point(188, 99);
            this.labelSolde.Name = "labelSolde";
            this.labelSolde.Size = new System.Drawing.Size(45, 29);
            this.labelSolde.TabIndex = 10;
            this.labelSolde.Text = "0 €";
            // 
            // createOperation
            // 
            this.createOperation.Location = new System.Drawing.Point(332, 99);
            this.createOperation.Name = "createOperation";
            this.createOperation.Size = new System.Drawing.Size(187, 40);
            this.createOperation.TabIndex = 9;
            this.createOperation.Text = "Ajouter une opération";
            this.createOperation.UseVisualStyleBackColor = true;
            this.createOperation.Click += new System.EventHandler(this.createOperation_Click);
            // 
            // detail
            // 
            this.detail.Location = new System.Drawing.Point(332, 32);
            this.detail.Name = "detail";
            this.detail.Size = new System.Drawing.Size(187, 40);
            this.detail.TabIndex = 8;
            this.detail.Text = "Voir le détail du compte";
            this.detail.UseVisualStyleBackColor = true;
            this.detail.Click += new System.EventHandler(this.detail_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(50, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 29);
            this.label2.TabIndex = 7;
            this.label2.Text = "Soldes: ";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 306);
            this.Controls.Add(this.groupBox1);
            this.Name = "Home";
            this.Text = "Budget Management";
            this.Load += new System.EventHandler(this.Home_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelSolde;
        private System.Windows.Forms.Button createOperation;
        private System.Windows.Forms.Button detail;
        private System.Windows.Forms.Label label2;
    }
}