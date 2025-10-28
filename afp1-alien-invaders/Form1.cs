namespace afp1_alien_invaders
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            StartButton.Hide();
            SettingsButton.Hide();
            ExitButton.Hide();

        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Exit exitForm = new Exit(this);
            exitForm.ShowDialog();
        }

        
    }
}
