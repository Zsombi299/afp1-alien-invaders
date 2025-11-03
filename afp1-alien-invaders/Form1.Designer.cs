namespace afp1_alien_invaders
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            StartButton = new Button();
            SettingsButton = new Button();
            ExitButton = new Button();
            Spaceship = new PictureBox();
            bulletTimer = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)Spaceship).BeginInit();
            SuspendLayout();
            // 
            // StartButton
            // 
            StartButton.Location = new Point(313, 132);
            StartButton.Name = "StartButton";
            StartButton.Size = new Size(147, 29);
            StartButton.TabIndex = 0;
            StartButton.Text = "Játék indítása";
            StartButton.UseVisualStyleBackColor = true;
            StartButton.Click += StartButton_Click;
            // 
            // SettingsButton
            // 
            SettingsButton.Location = new Point(313, 190);
            SettingsButton.Name = "SettingsButton";
            SettingsButton.Size = new Size(147, 29);
            SettingsButton.TabIndex = 1;
            SettingsButton.Text = "Beállítások";
            SettingsButton.UseVisualStyleBackColor = true;
            SettingsButton.Click += SettingsButton_Click;
            // 
            // ExitButton
            // 
            ExitButton.Location = new Point(313, 249);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(147, 29);
            ExitButton.TabIndex = 2;
            ExitButton.Text = "Kilépés";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // Spaceship
            // 
            Spaceship.BackgroundImageLayout = ImageLayout.None;
            Spaceship.Location = new Point(347, 357);
            Spaceship.Name = "Spaceship";
            Spaceship.Size = new Size(76, 36);
            Spaceship.SizeMode = PictureBoxSizeMode.AutoSize;
            Spaceship.TabIndex = 3;
            Spaceship.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(800, 450);
            Controls.Add(Spaceship);
            Controls.Add(ExitButton);
            Controls.Add(SettingsButton);
            Controls.Add(StartButton);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)Spaceship).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button StartButton;
        private Button SettingsButton;
        private Button ExitButton;
        private PictureBox Spaceship;
        private System.Windows.Forms.Timer bulletTimer;
    }
}
