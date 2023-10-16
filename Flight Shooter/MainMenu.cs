using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flight_Shooter
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            NewGame GameWindow = new NewGame();
            GameWindow.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Instruction GameWindow = new Instruction();
            GameWindow.Show();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
