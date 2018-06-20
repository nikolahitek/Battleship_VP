using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace Battleships
{
    public partial class MainMenuForm : Form
    {
        string FileName;

        public MainMenuForm()
        {
            InitializeComponent();
            MaximizeBox = false;
            CenterToScreen();
        }

        private void QuitButtonClick(object sender, EventArgs e)
        {
            Application.Exit();
        }  
        
        private void MainMenuFormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void buttonEasy_Click(object sender, EventArgs e)
        {
            Game.Initialize();
            Game.AICleverness = 3;
            // Initialize players.
            Game.player1 = new Player();
            Game.player2 = new Player();

            ShipDeploymentForm shipDeploymentForm = new ShipDeploymentForm();
            shipDeploymentForm.Location = Location;
            shipDeploymentForm.Show();

            Hide();
        }

        private void buttonMedium_Click(object sender, EventArgs e)
        {
            Game.Initialize();
            Game.AICleverness = 7;
            // Initialize players.
            Game.player1 = new Player();
            Game.player2 = new Player();

            ShipDeploymentForm shipDeploymentForm = new ShipDeploymentForm();
            shipDeploymentForm.Location = Location;
            shipDeploymentForm.Show();

            Hide();
        }

        private void buttonHard_Click(object sender, EventArgs e)
        {
            Game.Initialize();
            Game.AICleverness = 10;
            // Initialize players.
            Game.player1 = new Player();
            Game.player2 = new Player();

            ShipDeploymentForm shipDeploymentForm = new ShipDeploymentForm();
            shipDeploymentForm.Location = Location;
            shipDeploymentForm.Show();

            Hide();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
