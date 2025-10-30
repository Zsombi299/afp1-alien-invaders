namespace afp1_alien_invaders
{
    public partial class Form1 : Form
    {
        bool gameOn = false;

        int ALIEN_ROWS = 1;
        int ALIEN_COLS = 1;
        int SPACESHIP_DAMAGE = 20;
        int ALIEN_HEALTH = 60; //ezeket majd késõbb dinamikusan lehet változtatni a beállítások menübõl
        Player player;
        List<PictureBox> aliens = new List<PictureBox>();

        public Form1()
        {
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

            gameOn = true;
        }

        void SpawnAliens(int r, int c)
        {
            Image alienImage = Image.FromFile(Path.Combine(Application.StartupPath, "Images", "Alien.png"));
            Enemy enemy = new Enemy(ALIEN_HEALTH, "alien" + r + c, alienImage, player);
            int i = 0, j = 0;
            while (i < r)
            {
                while (j < c)
                {
                    PictureBox pb = new PictureBox()
                    {
                        Size = new Size(20, 20),
                        Location = new Point(c * 30, r * 30),
                        Image = alienImage,
                        SizeMode = PictureBoxSizeMode.AutoSize
                    };
                    Controls.Add(pb);
                    aliens.Add(pb);
                    j++;
                }
                i++;
            }
        }

    }
}
