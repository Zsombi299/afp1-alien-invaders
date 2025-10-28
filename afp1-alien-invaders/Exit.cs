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
    public partial class Exit : Form
    {
        Form1 form1;
        public Exit(Form1 form1)
        {
            this.form1 = form1;
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            form1.Close();
            Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
