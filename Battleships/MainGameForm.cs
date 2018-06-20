using Battleships.Properties;
using System;
using System.Threading;
using System.Windows.Forms;

namespace Battleships
{
    public partial class MainGameForm : Form
    {
        int mouseCellX;
        int mouseCellY;

        Player yourPlayer;
        Player opponentPlayer;

        public MainGameForm()
        {
            InitializeComponent();            
            MaximizeBox = false;           
            CenterToScreen();

            deck1PictureBox.Image = Resources.bg;
            deck2PictureBox.Image = Resources.bg;
            
            Text = "Battleship: Sink the ships!";
            yourPlayer = Game.player1;
            opponentPlayer = Game.player2;
            
            mouseCellX = -1;
            mouseCellY = -1;
        }

        
        private void deckPictureBoxClick(object sender, EventArgs e)
        {

            if (mouseCellX != -1 && mouseCellY != -1 && !opponentPlayer.RevealedCells[mouseCellX, mouseCellY])
            {
                
                if (Game.PerformAttack(mouseCellX, mouseCellY, yourPlayer, opponentPlayer))
                {
                    deck1PictureBox.Refresh();
                    MessageBox.Show("Честитки"+ "! Победивте во " + Game.roundCount + " рунди!", "Battleship: Game Over!");                    
                    Dispose();

                    GlobalContext.MainMenuForm.Location = Location;
                    GlobalContext.MainMenuForm.Show();
                }
                else
                {
                    
                    deck1PictureBox.Refresh();
                 
                                                    
                        int[] aiMove = Game.AIChooseCellToHit(yourPlayer);
                        if (Game.PerformAttack(aiMove[0], aiMove[1], opponentPlayer, yourPlayer))
                        {
                           
                            for (int currentShip = 0; currentShip < 5; currentShip++)
                            {
                                opponentPlayer.ShipLeftCells[currentShip] = 0;
                            }
                         
                            deck2PictureBox.Refresh();
                            MessageBox.Show("Изгубивте во " + Game.roundCount + " рунди!", "Battleship: Game Over!");
                            Dispose();

                            GlobalContext.MainMenuForm.Location = Location;
                            GlobalContext.MainMenuForm.Show();
                        }
                        else
                        {
                            Game.roundCount++;
                            deck2PictureBox.Refresh();
                        }
                    
                  
                }                
            }
            
        }

        private void deck1PictureBoxMouseMove(object sender, MouseEventArgs e)
        {
           
            if (GraphicContext.GetCoorX(this, deck1PictureBox) != -1 && GraphicContext.GetCoorY(this, deck1PictureBox) != -1)
            {
               
                if (GraphicContext.GetCell(GraphicContext.GetCoorX(this, deck1PictureBox)) != mouseCellX || GraphicContext.GetCell(GraphicContext.GetCoorY(this, deck1PictureBox)) != mouseCellY)
                {
                   
                    mouseCellX = GraphicContext.GetCell(GraphicContext.GetCoorX(this, deck1PictureBox));
                    mouseCellY = GraphicContext.GetCell(GraphicContext.GetCoorY(this, deck1PictureBox));
                    deck1PictureBox.Refresh();
                    GraphicContext.DrawOuterFrameCell(mouseCellX, mouseCellY, 5, this, deck1PictureBox);
                }
            }
            else
            {
                mouseCellX = -1;
                mouseCellY = -1;                
                deck1PictureBox.Refresh();  
            }
        }
        
        private void deck1PictureBoxPaint(object sender, PaintEventArgs e)
        {
            GraphicContext.DrawSunkenShips(opponentPlayer.ShipSet, opponentPlayer.ShipLeftCells, e);
            GraphicContext.DrawDeckStatus(opponentPlayer.RevealedCells, opponentPlayer.ShipSet, e);

            if (opponentPlayer.LastRevieledCells[0] != -1 && opponentPlayer.LastRevieledCells[1] != -1)
            {
                GraphicContext.DrawOuterFrameCell(opponentPlayer.LastRevieledCells[0], opponentPlayer.LastRevieledCells[1], 6, e);
            }
        }

        private void deck2PictureBoxPaint(object sender, PaintEventArgs e)
        {
            GraphicContext.DrawShipSet(yourPlayer.ShipSet, e);
            GraphicContext.DrawDeckStatus(yourPlayer.RevealedCells, yourPlayer.ShipSet, e);

            if (yourPlayer.LastRevieledCells[0] != -1 && yourPlayer.LastRevieledCells[1] != -1)
            {
                GraphicContext.DrawOuterFrameCell(yourPlayer.LastRevieledCells[0], yourPlayer.LastRevieledCells[1], 7, e);
            }
        }


        private void MainMenuFormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult quitToMainMenu = MessageBox.Show("Дали сакате да се вратите на главното мени?", "Battleship: Quitting game", MessageBoxButtons.YesNo);
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
