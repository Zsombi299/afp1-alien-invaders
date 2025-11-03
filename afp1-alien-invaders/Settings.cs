using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace afp1_alien_invaders
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            Form1.ALIEN_COLS = AlienColsNumber.Value;
            Form1.ALIEN_ROWS = AlienRowsNumber.Value;
            Form1.ALIEN_HEALTH = AliensHealthNumber.Value;
            Form1.SPACESHIP_DAMAGE = SpaceshipDamageNumber.Value;
            Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
