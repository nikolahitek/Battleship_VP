using Battleships.Properties;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Battleships
{
    public partial class ShipDeploymentForm : Form
    {
        int mouseCellX;
        int mouseCellY;
        int currentShip;
        bool shipRotation;
        bool[] shipDeployed = new bool[5];

        Player player;

        public ShipDeploymentForm()
        {
            InitializeComponent();
            MaximizeBox = false;
            CenterToParent();
            deckPictureBox.Image = Resources.bg;

            mouseCellX = -1;
            mouseCellY = -1;
            currentShip = -1;
            shipRotation = true;
                       
            if (Game.playerSwitch)
            {
                player = Game.player1;
            }
            else
            {
                player = Game.player2;
            }
        }
        
        private void DeckPictureBoxMouseMove(object sender, MouseEventArgs e)
        {
            
            if (currentShip != -1)
            {
                
                if (GraphicContext.GetCoorX(this, deckPictureBox) != -1 && GraphicContext.GetCoorY(this, deckPictureBox) != -1)
                {
                   
                    if (GraphicContext.GetCell(GraphicContext.GetCoorX(this, deckPictureBox)) != mouseCellX || GraphicContext.GetCell(GraphicContext.GetCoorY(this, deckPictureBox)) != mouseCellY)
                    {
                        
                        mouseCellX = GraphicContext.GetCell(GraphicContext.GetCoorX(this, deckPictureBox));
                        mouseCellY = GraphicContext.GetCell(GraphicContext.GetCoorY(this, deckPictureBox));
                        
                        deckPictureBox.Refresh();

                        
                        if (shipRotation)
                        {
                            
                            for (int i = 0; i < Game.shipLengths[currentShip]; i++)
                            {
                                
                                if (mouseCellX + i <= 9)
                                {
                                    GraphicContext.DrawInnerFrameCell(mouseCellX + i, mouseCellY, currentShip, this, deckPictureBox);
                                }
                                else
                                {
                                    break;
                                }
                            }
                        }
                        else
                        {
                            
                            for (int i = 0; i < Game.shipLengths[currentShip]; i++)
                            {
                                if (mouseCellY + i <= 9)
                                {
                                    GraphicContext.DrawInnerFrameCell(mouseCellX, mouseCellY + i, currentShip, this, deckPictureBox);
                                }
                                else
                                {
                                    break;
                                }
                            }
                        }
                    }
                }
                else
                {
                    
                    if (mouseCellX != -1 || mouseCellY != -1)
                    {
                        mouseCellX = -1;
                        mouseCellY = -1;

                       
                        deckPictureBox.Refresh();
                    }

                }
            }
        }
      
        private void DeckPictureBoxClick(object sender, EventArgs e)
        {
            if (currentShip != -1 && mouseCellX != -1 && mouseCellY != -1)
            {
                if (Game.CanThereBeShip(currentShip, mouseCellX, mouseCellY, shipRotation, player.ShipSet))
                {
                    
                    shipRotateButton.Enabled = false;                   
                    shipDeployed[currentShip] = true;

                    switch (currentShip)
                    {
                        case 0:
                            {
                                deployShip0Button.Enabled = false;
                                deleteShip0Button.Enabled = true;
                                break;
                            }
                        case 1:
                            {
                                deployShip1Button.Enabled = false;
                                deleteShip1Button.Enabled = true;
                                break;
                            }
                        case 2:
                            {
                                deployShip2Button.Enabled = false;
                                deleteShip2Button.Enabled = true;
                                break;
                            }
                        case 3:
                            {
                                deployShip3Button.Enabled = false;
                                deleteShip3Button.Enabled = true;
                                break;
                            }
                        case 4:
                            {
                                deployShip4Button.Enabled = false;
                                deleteShip4Button.Enabled = true;
                                break;
                            }
                    }

                    
                    Game.DeployShip(currentShip, mouseCellX, mouseCellY, shipRotation, player.ShipSet);                   
                    deckPictureBox.Refresh();                    
                    currentShip = -1;

                   
                    bool areAllShipsDeployed = true;
                    foreach (bool isDeployed in shipDeployed)
                    {
                        if (!isDeployed)
                        {
                           
                            areAllShipsDeployed = false;
                        }
                    }

                    if (areAllShipsDeployed)
                    {
                        doneButton.Enabled = true;
                    }
                }
            }
        }
        
        private void Ship0ButtonClick(object sender, EventArgs e)
        {
            currentShip = 0;
            shipRotateButton.Enabled = true;
        }

        private void Ship1ButtonClick(object sender, EventArgs e)
        {
            currentShip = 1;
            shipRotateButton.Enabled = true;
        }

        private void Ship2ButtonClick(object sender, EventArgs e)
        {
            currentShip = 2;
            shipRotateButton.Enabled = true;
        }

        private void Ship3ButtonClick(object sender, EventArgs e)
        {
            currentShip = 3;
            shipRotateButton.Enabled = true;
        }

        private void Ship4ButtonClick(object sender, EventArgs e)
        {
            currentShip = 4;
            shipRotateButton.Enabled = true;
        }

        private void DeleteShip0ButtonClick(object sender, EventArgs e)
        {
           
            Game.DeleteShip(0, player.ShipSet);          
            deckPictureBox.Refresh();
            deployShip0Button.Enabled = true;
            deleteShip0Button.Enabled = false;
            doneButton.Enabled = false;
        }

        private void DeleteShip1ButtonClick(object sender, EventArgs e)
        {
            Game.DeleteShip(1, player.ShipSet);
            deckPictureBox.Refresh();
            deployShip1Button.Enabled = true;
            deleteShip1Button.Enabled = false;
            doneButton.Enabled = false;
        }

        private void DeleteShip2ButtonClick(object sender, EventArgs e)
        {
            Game.DeleteShip(2, player.ShipSet);
            deckPictureBox.Refresh();
            deployShip2Button.Enabled = true;
            deleteShip2Button.Enabled = false;
            doneButton.Enabled = false;
        }

        private void DeleteShip3ButtonClick(object sender, EventArgs e)
        {
            Game.DeleteShip(3, player.ShipSet);
            deckPictureBox.Refresh();
            deployShip3Button.Enabled = true;
            deleteShip3Button.Enabled = false;
            doneButton.Enabled = false;
        }

        private void DeleteShip4ButtonClick(object sender, EventArgs e)
        {
            Game.DeleteShip(4, player.ShipSet);
            deckPictureBox.Refresh();
            deployShip4Button.Enabled = true;
            deleteShip4Button.Enabled = false;
            doneButton.Enabled = false;
        }
        
        private void ShipRotateButtonClick(object sender, EventArgs e)
        {
            shipRotation = !shipRotation;
        }

        private void DoneButtonClick(object sender, EventArgs e)
        {
           
                Game.AIDeployShips();
                MainGameForm mainGame = new MainGameForm();
                mainGame.Location = Location;
                mainGame.Show();               
                Dispose();
                       
        }

        private void DeckPictureBoxPaint(object sender, PaintEventArgs e)
        {
            GraphicContext.DrawShipSet(player.ShipSet, e);
        }

        private void ShipDeploymentFormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult quitToMainMenu = MessageBox.Show("Дали навистина сакате да се вратите до главното мени?", "Battleship: Quitting game", MessageBoxButtons.YesNo);
            if (quitToMainMenu == DialogResult.Yes)
            {
                GlobalContext.MainMenuForm.Location = Location;
                GlobalContext.MainMenuForm.Show();
            }
            else
            {               
                e.Cancel = true;
            }
        }
    }
}
