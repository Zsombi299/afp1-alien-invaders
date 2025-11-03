namespace afp1_alien_invaders
{
    partial class Settings
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
            AlienRowsNumber = new TrackBar();
            AlienRows = new Label();
            AlienRowsOne = new Label();
            AlienRowsTen = new Label();
            AlienColsNumber = new TrackBar();
            AliensHealthNumber = new TrackBar();
            AlienColsOne = new Label();
            AlienColsTen = new Label();
            AliensHealthTen = new Label();
            AliensHealthTwoHundred = new Label();
            AlienCols = new Label();
            AliensHealth = new Label();
            SaveButton = new Button();
            CancelButton = new Button();
            SpaceshipDamage = new Label();
            SpaceshipDamageNumber = new TrackBar();
            SpaceshipDamageTen = new Label();
            SpaceshipDamageHundred = new Label();
            ((System.ComponentModel.ISupportInitialize)AlienRowsNumber).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AlienColsNumber).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AliensHealthNumber).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SpaceshipDamageNumber).BeginInit();
            SuspendLayout();
            // 
            // AlienRowsNumber
            // 
            AlienRowsNumber.Location = new Point(216, 74);
            AlienRowsNumber.Name = "AlienRowsNumber";
            AlienRowsNumber.Size = new Size(130, 56);
            AlienRowsNumber.TabIndex = 0;
            // 
            // AlienRows
            // 
            AlienRows.AutoSize = true;
            AlienRows.Location = new Point(26, 74);
            AlienRows.Name = "AlienRows";
            AlienRows.Size = new Size(137, 20);
            AlienRows.TabIndex = 1;
            AlienRows.Text = "Űrlény sorok száma";
            // 
            // AlienRowsOne
            // 
            AlienRowsOne.AutoSize = true;
            AlienRowsOne.Location = new Point(193, 74);
            AlienRowsOne.Name = "AlienRowsOne";
            AlienRowsOne.Size = new Size(17, 20);
            AlienRowsOne.TabIndex = 2;
            AlienRowsOne.Text = "1";
            // 
            // AlienRowsTen
            // 
            AlienRowsTen.AutoSize = true;
            AlienRowsTen.Location = new Point(363, 77);
            AlienRowsTen.Name = "AlienRowsTen";
            AlienRowsTen.Size = new Size(25, 20);
            AlienRowsTen.TabIndex = 3;
            AlienRowsTen.Text = "10";
            // 
            // AlienColsNumber
            // 
            AlienColsNumber.Location = new Point(216, 127);
            AlienColsNumber.Name = "AlienColsNumber";
            AlienColsNumber.Size = new Size(130, 56);
            AlienColsNumber.TabIndex = 4;
            // 
            // AliensHealthNumber
            // 
            AliensHealthNumber.Location = new Point(216, 179);
            AliensHealthNumber.Maximum = 200;
            AliensHealthNumber.Minimum = 10;
            AliensHealthNumber.Name = "AliensHealthNumber";
            AliensHealthNumber.Size = new Size(130, 56);
            AliensHealthNumber.TabIndex = 5;
            AliensHealthNumber.TickFrequency = 20;
            AliensHealthNumber.Value = 10;
            // 
            // AlienColsOne
            // 
            AlienColsOne.AutoSize = true;
            AlienColsOne.Location = new Point(193, 137);
            AlienColsOne.Name = "AlienColsOne";
            AlienColsOne.Size = new Size(17, 20);
            AlienColsOne.TabIndex = 6;
            AlienColsOne.Text = "1";
            // 
            // AlienColsTen
            // 
            AlienColsTen.AutoSize = true;
            AlienColsTen.Location = new Point(363, 137);
            AlienColsTen.Name = "AlienColsTen";
            AlienColsTen.Size = new Size(25, 20);
            AlienColsTen.TabIndex = 7;
            AlienColsTen.Text = "10";
            // 
            // AliensHealthTen
            // 
            AliensHealthTen.AutoSize = true;
            AliensHealthTen.Location = new Point(187, 179);
            AliensHealthTen.Name = "AliensHealthTen";
            AliensHealthTen.Size = new Size(25, 20);
            AliensHealthTen.TabIndex = 8;
            AliensHealthTen.Text = "10";
            // 
            // AliensHealthTwoHundred
            // 
            AliensHealthTwoHundred.AutoSize = true;
            AliensHealthTwoHundred.Location = new Point(367, 186);
            AliensHealthTwoHundred.Name = "AliensHealthTwoHundred";
            AliensHealthTwoHundred.Size = new Size(33, 20);
            AliensHealthTwoHundred.TabIndex = 9;
            AliensHealthTwoHundred.Text = "200";
            // 
            // AlienCols
            // 
            AlienCols.AutoSize = true;
            AlienCols.Location = new Point(26, 137);
            AlienCols.Name = "AlienCols";
            AlienCols.Size = new Size(161, 20);
            AlienCols.TabIndex = 10;
            AlienCols.Text = "Űrlény oszlopok száma";
            // 
            // AliensHealth
            // 
            AliensHealth.AutoSize = true;
            AliensHealth.Location = new Point(26, 186);
            AliensHealth.Name = "AliensHealth";
            AliensHealth.Size = new Size(103, 20);
            AliensHealth.TabIndex = 11;
            AliensHealth.Text = "Űrlények élete";
            // 
            // SaveButton
            // 
            SaveButton.Location = new Point(35, 308);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(94, 29);
            SaveButton.TabIndex = 12;
            SaveButton.Text = "Mentés";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;
            // 
            // CancelButton
            // 
            CancelButton.Location = new Point(325, 308);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(94, 29);
            CancelButton.TabIndex = 13;
            CancelButton.Text = "Mégse";
            CancelButton.UseVisualStyleBackColor = true;
            CancelButton.Click += CancelButton_Click;
            // 
            // SpaceshipDamage
            // 
            SpaceshipDamage.AutoSize = true;
            SpaceshipDamage.Location = new Point(27, 231);
            SpaceshipDamage.Name = "SpaceshipDamage";
            SpaceshipDamage.Size = new Size(113, 20);
            SpaceshipDamage.TabIndex = 14;
            SpaceshipDamage.Text = "Sebzés mértéke";
            // 
            // SpaceshipDamageNumber
            // 
            SpaceshipDamageNumber.Location = new Point(216, 231);
            SpaceshipDamageNumber.Maximum = 100;
            SpaceshipDamageNumber.Minimum = 10;
            SpaceshipDamageNumber.Name = "SpaceshipDamageNumber";
            SpaceshipDamageNumber.Size = new Size(130, 56);
            SpaceshipDamageNumber.TabIndex = 15;
            SpaceshipDamageNumber.TickFrequency = 20;
            SpaceshipDamageNumber.Value = 10;
            // 
            // SpaceshipDamageTen
            // 
            SpaceshipDamageTen.AutoSize = true;
            SpaceshipDamageTen.Location = new Point(187, 238);
            SpaceshipDamageTen.Name = "SpaceshipDamageTen";
            SpaceshipDamageTen.Size = new Size(25, 20);
            SpaceshipDamageTen.TabIndex = 16;
            SpaceshipDamageTen.Text = "10";
            // 
            // SpaceshipDamageHundred
            // 
            SpaceshipDamageHundred.AutoSize = true;
            SpaceshipDamageHundred.Location = new Point(364, 238);
            SpaceshipDamageHundred.Name = "SpaceshipDamageHundred";
            SpaceshipDamageHundred.Size = new Size(33, 20);
            SpaceshipDamageHundred.TabIndex = 17;
            SpaceshipDamageHundred.Text = "100";
            // 
            // Settings
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(450, 372);
            Controls.Add(SpaceshipDamageHundred);
            Controls.Add(SpaceshipDamageTen);
            Controls.Add(SpaceshipDamageNumber);
            Controls.Add(SpaceshipDamage);
            Controls.Add(CancelButton);
            Controls.Add(SaveButton);
            Controls.Add(AliensHealth);
            Controls.Add(AlienCols);
            Controls.Add(AliensHealthTwoHundred);
            Controls.Add(AliensHealthTen);
            Controls.Add(AlienColsTen);
            Controls.Add(AlienColsOne);
            Controls.Add(AliensHealthNumber);
            Controls.Add(AlienColsNumber);
            Controls.Add(AlienRowsTen);
            Controls.Add(AlienRowsOne);
            Controls.Add(AlienRows);
            Controls.Add(AlienRowsNumber);
            Name = "Settings";
            Text = "Settings";
            ((System.ComponentModel.ISupportInitialize)AlienRowsNumber).EndInit();
            ((System.ComponentModel.ISupportInitialize)AlienColsNumber).EndInit();
            ((System.ComponentModel.ISupportInitialize)AliensHealthNumber).EndInit();
            ((System.ComponentModel.ISupportInitialize)SpaceshipDamageNumber).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TrackBar AlienRowsNumber;
        private Label AlienRows;
        private Label AlienRowsOne;
        private Label AlienRowsTen;
        private TrackBar AlienColsNumber;
        private TrackBar AliensHealthNumber;
        private Label AlienColsOne;
        private Label AlienColsTen;
        private Label AliensHealthTen;
        private Label AliensHealthTwoHundred;
        private Label AlienCols;
        private Label AliensHealth;
        private Button SaveButton;
        private Button CancelButton;
        private Label SpaceshipDamage;
        private TrackBar SpaceshipDamageNumber;
        private Label SpaceshipDamageTen;
        private Label SpaceshipDamageHundred;
    }
}