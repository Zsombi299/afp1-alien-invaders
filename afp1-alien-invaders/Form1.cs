namespace afp1_alien_invaders
{
    public partial class Form1 : Form
    {
        bool gameOn = false;

        public static int ALIEN_ROWS = 2;
        public static int ALIEN_COLS = 2;
        public static int SPACESHIP_DAMAGE = 20;
        public static int ALIEN_HEALTH = 60;
        Player player;
        List<PictureBox> aliens = new List<PictureBox>();
        List<PictureBox> bullets = new List<PictureBox>();
        Button exitButton;

        public Form1()
        {
            KeyPreview = true;
            KeyDown += Form1_KeyDown;
            InitializeComponent();

        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            StartButton.Hide();
            SettingsButton.Hide();
            ExitButton.Hide();
            GameStart();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Exit exitForm = new Exit(this);
            exitForm.ShowDialog();
        }

        void GameStart()
        {
            Image image = Image.FromFile(Path.Combine(Application.StartupPath, "Images", "Spaceship.png"));
            player = new Player(SPACESHIP_DAMAGE, image);
            Spaceship.Image = image;
            SpawnAliens(ALIEN_ROWS, ALIEN_COLS);
            CreateExitButton();

            gameOn = true;
        }

        void SpawnAliens(int r, int c)
        {
            Image alienImage = Image.FromFile(Path.Combine(Application.StartupPath, "Images", "Alien.png"));
            Enemy enemy = new Enemy(ALIEN_HEALTH, "alien" + r + c, alienImage, player);
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    PictureBox pb = new PictureBox()
                    {
                        Location = new Point(j * 100, i * 50),
                        Image = alienImage,
                        SizeMode = PictureBoxSizeMode.StretchImage
                    };
                    Controls.Add(pb);
                    aliens.Add(pb);
                }
            }
        }

        void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (gameOn)
            {
                if (e.KeyCode == Keys.Right || e.KeyCode == Keys.D)
                {
                    Spaceship.Left += 10;
                }
                else if (e.KeyCode == Keys.Left || e.KeyCode == Keys.A)
                {
                    Spaceship.Left -= 10;
                }
                if (e.KeyCode == Keys.B)
                {
                    Shoot();
                }
            }
        }
        void Shoot()
        {
            PictureBox bullet = new()
            {
                Size = new Size(5, 20),
                BackColor = Color.White,
                Location = new Point(
                    Spaceship.Left + Spaceship.Width / 2 - 2,
                    Spaceship.Top - 20
                )
            };
            Controls.Add(bullet);
            bullets.Add(bullet);
        }

        void CreateExitButton()
        {
            exitButton = new Button()
            {
                Text = "Kilépés",
                BackColor = DefaultBackColor,
                Size = new Size(80, 30),
                Location = new Point(20, Height - 100)
            };

            exitButton.Click += (sender, e) => EndGame();

            Controls.Add(exitButton);
        }

        void EndGame()
        {
            gameOn = false;
            exitButton.Hide();
            StartButton.Show();
            StartButton.Text = "Újra";
            SettingsButton.Show();
            ExitButton.Show();
        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            Settings settingsForm = new Settings();
            settingsForm.ShowDialog();
        }
    }
}
