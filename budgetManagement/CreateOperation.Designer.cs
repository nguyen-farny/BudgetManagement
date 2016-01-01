namespace budgetManagement
{
    partial class CreateOperation
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
            this.Montant = new System.Windows.Forms.Label();
            this.Ajouter = new System.Windows.Forms.Button();
            this.titreBox = new System.Windows.Forms.TextBox();
            this.Annuler = new System.Windows.Forms.Button();
            this.titre = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dataSet1 = new System.Data.DataSet();
            this.montantBox = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.montantBox)).BeginInit();
            this.SuspendLayout();
            // 
            // Montant
            // 
            this.Montant.AutoSize = true;
            this.Montant.BackColor = System.Drawing.Color.Transparent;
            this.Montant.Font = new System.Drawing.Font("Arial", 14F);
            this.Montant.ForeColor = System.Drawing.Color.White;
            this.Montant.Location = new System.Drawing.Point(35, 99);
            this.Montant.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Montant.Name = "Montant";
            this.Montant.Size = new System.Drawing.Size(140, 32);
            this.Montant.TabIndex = 1;
            this.Montant.Text = "Montant : ";
            // 
            // Ajouter
            // 
            this.Ajouter.BackColor = System.Drawing.Color.White;
            this.Ajouter.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Ajouter.FlatAppearance.BorderSize = 3;
            this.Ajouter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.Ajouter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Ajouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Ajouter.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ajouter.ForeColor = System.Drawing.Color.DarkCyan;
            this.Ajouter.Location = new System.Drawing.Point(84, 238);
            this.Ajouter.Name = "Ajouter";
            this.Ajouter.Size = new System.Drawing.Size(90, 40);
            this.Ajouter.TabIndex = 4;
            this.Ajouter.Text = "Ajouter";
            this.Ajouter.UseVisualStyleBackColor = false;
            this.Ajouter.Click += new System.EventHandler(this.Ajouter_Click);
            // 
            // titreBox
            // 
            this.titreBox.BackColor = System.Drawing.Color.White;
            this.titreBox.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titreBox.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.titreBox.Location = new System.Drawing.Point(168, 36);
            this.titreBox.Name = "titreBox";
            this.titreBox.Size = new System.Drawing.Size(200, 40);
            this.titreBox.TabIndex = 1;
            this.titreBox.TextChanged += new System.EventHandler(this.titreBox_TextChanged);
            this.titreBox.Validating += new System.ComponentModel.CancelEventHandler(this.titreBox_Validating);
            // 
            // Annuler
            // 
            this.Annuler.BackColor = System.Drawing.Color.White;
            this.Annuler.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Annuler.FlatAppearance.BorderSize = 3;
            this.Annuler.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.Annuler.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Annuler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Annuler.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Annuler.ForeColor = System.Drawing.Color.DarkCyan;
            this.Annuler.Location = new System.Drawing.Point(236, 238);
            this.Annuler.Name = "Annuler";
            this.Annuler.Size = new System.Drawing.Size(90, 40);
            this.Annuler.TabIndex = 5;
            this.Annuler.Text = "Annuler";
            this.Annuler.UseVisualStyleBackColor = false;
            this.Annuler.Click += new System.EventHandler(this.Annuler_Click_1);
            // 
            // titre
            // 
            this.titre.AutoSize = true;
            this.titre.BackColor = System.Drawing.Color.Transparent;
            this.titre.Font = new System.Drawing.Font("Arial", 14F);
            this.titre.ForeColor = System.Drawing.Color.White;
            this.titre.Location = new System.Drawing.Point(35, 36);
            this.titre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.titre.Name = "titre";
            this.titre.Size = new System.Drawing.Size(92, 32);
            this.titre.TabIndex = 9;
            this.titre.Text = "Titre : ";
            // 
            // date
            // 
            this.date.AutoSize = true;
            this.date.BackColor = System.Drawing.Color.Transparent;
            this.date.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date.ForeColor = System.Drawing.Color.White;
            this.date.Location = new System.Drawing.Point(37, 165);
            this.date.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(97, 32);
            this.date.TabIndex = 10;
            this.date.Text = "Date : ";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CalendarForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.dateTimePicker.Location = new System.Drawing.Point(168, 162);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 35);
            this.dateTimePicker.TabIndex = 3;
            this.dateTimePicker.Value = new System.DateTime(2016, 1, 1, 0, 0, 0, 0);
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "NewDataSet";
            // 
            // montantBox
            // 
            this.montantBox.DecimalPlaces = 2;
            this.montantBox.Location = new System.Drawing.Point(168, 100);
            this.montantBox.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.montantBox.Minimum = new decimal(new int[] {
            1000000000,
            0,
            0,
            -2147483648});
            this.montantBox.Name = "montantBox";
            this.montantBox.Size = new System.Drawing.Size(200, 35);
            this.montantBox.TabIndex = 2;
            this.montantBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.montantBox.ThousandsSeparator = true;
            this.montantBox.ValueChanged += new System.EventHandler(this.montantBox_ValueChanged);
            this.montantBox.Validating += new System.ComponentModel.CancelEventHandler(this.montantBox_Validating);
            // 
            // CreateOperation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(428, 319);
            this.Controls.Add(this.montantBox);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.date);
            this.Controls.Add(this.titre);
            this.Controls.Add(this.Annuler);
            this.Controls.Add(this.titreBox);
            this.Controls.Add(this.Ajouter);
            this.Controls.Add(this.Montant);
            this.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CreateOperation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ajouter une opération";
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.montantBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Montant;
        private System.Windows.Forms.Button Ajouter;
        private System.Windows.Forms.TextBox titreBox;
        private System.Windows.Forms.Button Annuler;
        private System.Windows.Forms.Label titre;
        private System.Windows.Forms.Label date;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Data.DataSet dataSet1;
        private System.Windows.Forms.NumericUpDown montantBox;
    }
}

