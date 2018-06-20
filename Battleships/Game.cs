using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Battleships
{
   public static class Game
    {
        // AI cleverness, 1 for dumb, 10 for mastermind.
        public static int AICleverness { get; set; }
        // Ship lengths.
        public static int[] shipLengths = new int[5] { 2, 3, 3, 4, 5 };
           
        // [true] player1's move / [false] player2's move.
        public static bool playerSwitch;
        // Round count.
        public static int roundCount;

        // Player information.
        public static Player player1;
        public static Player player2;

        // Inicalize the game.
        static public void Initialize()
        {
            playerSwitch = true;
            roundCount = 1;
        }
        // Method returns whether a cell can contain a ship.
        // First implementation is dedicated for the ship deployment.
        static public bool CanThereBeShip(int currentShip, int cellX, int cellY, bool isHorizontal, int[,] shipSet)
        {
            // Is the index of the most upper-left cell within the bounds.
            if (cellX < 0 || cellY < 0)
            {
                return false;
            }

            if (isHorizontal)
            {
                if (cellX + Game.shipLengths[currentShip] - 1 <= 9)
                {
                    // Searching for an invalid layout on the grid.
                    for (int i = Math.Max(0, cellX - 1); i <= Math.Min(9, cellX + Game.shipLengths[currentShip]); i++)
                    {
                        for (int j = Math.Max(0, cellY - 1); j <= Math.Min(9, cellY + 1); j++)
                        {
                            if (shipSet[i, j] != -1)
                            {
                                // Invalid layout found.
                                return false;
                            }
                        }
                    }

                    // Invalid layout not found.
                    return true;
                }
                else
                {
                    // Out of the bounds of the grid.
                    return false;
                }
            }
            else
            {
                // Vertical validation.
                if (cellY + Game.shipLengths[currentShip] - 1 <= 9)
                {
                    // Searching for an invalid layout on the grid.
                    for (int i = Math.Max(0, cellX - 1); i <= Math.Min(9, cellX + 1); i++)
                    {
                        for (int j = Math.Max(0, cellY - 1); j <= Math.Min(9, cellY + Game.shipLengths[currentShip]); j++)
                        {
                            if (shipSet[i, j] != -1)
                            {
                                // Invalid layout found.
                                return false;
                            }
                        }
                    }

                    // Invalid layout not found.
                    return true;
                }
                else
                {
                    // Out of the bounds of the grid.
                    return false;
                }
            }
        }

        // Method returns whether a cell can contain a ship.
        // Second implementation is dedicated for AI logic.
        static public bool CanThereBeShip(int currentShip, int cellX, int cellY, bool isHorizontal, Player player)
        {
            // Is the index of the most upper-left cell within the bounds.
            if (cellX < 0 || cellY < 0)
            {
                return false;
            }

            if (isHorizontal)
            {
                if (cellX + Game.shipLengths[currentShip] - 1 <= 9)
                {
                    // Searching for an invalid layout on the grid.
                    for (int i = Math.Max(0, cellX - 1); i <= Math.Min(9, cellX + Game.shipLengths[currentShip]); i++)
                    {
                        for (int j = Math.Max(0, cellY - 1); j <= Math.Min(9, cellY + 1); j++)
                        {
                            // Ship position cells.
                            if (i >= cellX && i < cellX + shipLengths[currentShip] && j == cellY)
                            {
                                // If the cell is revealed and there is water or a sunken ship.
                                if ((player.RevealedCells[i, j] && player.ShipSet[i, j] == -1) || (player.ShipSet[i, j] != -1 && player.ShipLeftCells[player.ShipSet[i, j]] == 0))
                                {
                                    // Invalid layout found.
                                    return false;
                                }

                            }
                            // Neighbouring cells.
                            else
                            {
                                // If there is a neighbouring revealed ship cell.
                                if (player.RevealedCells[i, j] && player.ShipSet[i, j] != -1)
                                {
                                    // Invalid layout found.
                                    return false;
                                }
                            }
                        }
                    }

                    // Invalid layout not found.
                    return true;
                }
                else
                {
                    // Out of the bounds of the grid.
                    return false;
                }
            }
            else
            {
                // Vertical validation.
                if (cellY + Game.shipLengths[currentShip] - 1 <= 9)
                {
                    // Searching for an invalid layout on the grid.
                    for (int i = Math.Max(0, cellX - 1); i <= Math.Min(9, cellX + 1); i++)
                    {
                        for (int j = Math.Max(0, cellY - 1); j <= Math.Min(9, cellY + Game.shipLengths[currentShip]); j++)
                        {
                            // Ship position cells.
                            if (j >= cellY && j < cellY + shipLengths[currentShip] && i == cellX)
                            {
                                // If the cell is revealed and there is water or a sunken ship.
                                if (player.RevealedCells[i, j] && (player.ShipSet[i, j] == -1) || (player.ShipSet[i, j] != -1 && player.ShipLeftCells[player.ShipSet[i, j]] == 0))
                                {
                                    // Invalid layout found.
                                    return false;
                                }

                            }
                            // Neighbouring cells.
                            else
                            {
                                // If there is a neighbouring revealed ship cell.
                                if (player.RevealedCells[i, j] && player.ShipSet[i, j] != -1)
                                {
                                    // Invalid layout found.
                                    return false;
                                }
                            }
                        }
                    }

                    // Invalid layout not found.
                    return true;
                }
                else
                {
                    // Out of the bounds of the grid.
                    return false;
                }
            }
        }

        // Deploy a ship into a ship set.
        static public void DeployShip(int currentShip, int cellX, int cellY, bool isHorizontal, int[,] shipSet)
        {
            if (isHorizontal)
            {
                for (int i = 0; i < Game.shipLengths[currentShip]; i++)
                {
                    // Deploy into a ship set.
                    shipSet[cellX + i, cellY] = currentShip;
                }
            }
            else
            {
                for (int i = 0; i < Game.shipLengths[currentShip]; i++)
                {
                    // Deploy into a ship set.
                    shipSet[cellX, cellY + i] = currentShip;
                }
            }

        }

        // Delete a ship from a ship set, dedicated for the deployment for delete ship functionality.
        static public void DeleteShip(int currentShip, int[,] shipSet)
        {
            for (int x = 0; x < 10; x++)
            {
                for (int y = 0; y < 10; y++)
                {
                    if (shipSet[x, y] == currentShip)
                    {
                        shipSet[x, y] = -1;
                    }
                }
            }
        }

        // Random ship deployment.
        static public void AIDeployShips()
        {
            // Stepwise through all ships.
            for (int currentShip = 0; currentShip < 5; currentShip++)
            {
                // Inicializating the list of possibilities.
                List<int[]> possibilities = new List<int[]>();
                List<bool> rotationAspects = new List<bool>();

                // For all cells in grid 10 x 10.
                for (int x = 0; x < 10; x++)
                {
                    for (int y = 0; y < 10; y++)
                    {
                        // Is there a valid horizontal layout at [x,y] in the current grid?
                        if (CanThereBeShip(currentShip, x, y, true, player2.ShipSet))
                        {
                            // Add into possibilities, [x, y].
                            possibilities.Add(new int[2] { x, y });
                            // At this index, add the horizontal rotation aspect.
                            rotationAspects.Add(true);
                        }

                        // Is there a valid vertical layout at [x,y] in the current grid?
                        if (CanThereBeShip(currentShip, x, y, false, player2.ShipSet))
                        {
                            // Add into possibilities, [x, y].
                            possibilities.Add(new int[2] { x, y });
                            // At this index, add the vertical rotation aspect.
                            rotationAspects.Add(false);
                        }
                    }
                }

                // Choosing possibility.
                int numberOfChosen = GlobalContext.RandomNumber(possibilities.Count);

                // Deploy the ship into the ship set.
                DeployShip(currentShip, possibilities[numberOfChosen][0], possibilities[numberOfChosen][1], rotationAspects[numberOfChosen], Game.player2.ShipSet);
            }
        }

        // Adds probability to all the spots the ship can be deployed.
        static private void probabilitySetAddShip(int currentShip, int cellX, int cellY, bool isHorizontal, int[,] probabilitySet)
        {
            for (int i = 0; i < shipLengths[currentShip]; i++)
            {
                if (isHorizontal)
                {
                    probabilitySet[cellX + i, cellY]++;
                }
                else
                {
                    probabilitySet[cellX, cellY + i]++;
                }
            }
        }

        // AI method for choosing a cell to hit.
        static public int[] AIChooseCellToHit(Player player)
        {
            // Prepared array of ship cell probabilities and its inicialization
            int[,] probabilitySet = new int[10, 10];
            for (int x = 0; x < 10; x++)
            {
                for (int y = 0; y < 10; y++)
                {
                    probabilitySet[x, y] = 0;
                }
            }

            // Revieled cells of partially revieled ships.
            List<int[]> partialRevealedCells = new List<int[]>();

            for (int x = 0; x < 10; x++)
            {
                for (int y = 0; y < 10; y++)
                {
                    if (player.RevealedCells[x, y] && player.ShipSet[x, y] != -1 && player.ShipLeftCells[player.ShipSet[x, y]] != 0)
                    {
                        // Partially revealed ship found at [x, y].
                        partialRevealedCells.Add(new int[2] { x, y });
                    }
                }
            }

            // Are there any partially revealed ships?
            if (partialRevealedCells.Count != 0)
            {
                // For every revealed cell of a partially revealed ship.
                foreach (int[] partialReveleadCell in partialRevealedCells)
                {
                    // Calculate the cross probability.
                    for (int currentShip = 0; currentShip < 5; currentShip++)
                    {
                        // For all the available ships left.
                        if (player.ShipLeftCells[currentShip] != 0)
                        {
                            // Apply cross search for each parial revealation cell.
                            for (int coorOffset = 0; coorOffset < shipLengths[currentShip]; coorOffset++)
                            {
                                if (CanThereBeShip(currentShip, partialReveleadCell[0] - coorOffset, partialReveleadCell[1], true, player))
                                {
                                    probabilitySetAddShip(currentShip, partialReveleadCell[0] - coorOffset, partialReveleadCell[1], true, probabilitySet);
                                }
                                if (CanThereBeShip(currentShip, partialReveleadCell[0], partialReveleadCell[1] - coorOffset, false, player))
                                {
                                    probabilitySetAddShip(currentShip, partialReveleadCell[0], partialReveleadCell[1] - coorOffset, false, probabilitySet);
                                }
                            }
                        }
                    }
                }
            }
            else
            {
                // No partially revealed ship found.
                for (int currentShip = 0; currentShip < 5; currentShip++)
                {
                    // For all the available ships left.
                    if (player.ShipLeftCells[currentShip] != 0)
                    {
                        for (int x = 0; x < 10; x++)
                        {
                            for (int y = 0; y < 10; y++)
                            {
                                // Validate the possible deployment and if valid add it to the probabilities.
                                if (CanThereBeShip(currentShip, x, y, true, player))
                                {
                                    probabilitySetAddShip(currentShip, x, y, true, probabilitySet);
                                }
                                if (CanThereBeShip(currentShip, x, y, false, player))
                                {
                                    probabilitySetAddShip(currentShip, x, y, false, probabilitySet);
                                }
                            }
                        }
                    }
                }
            }

            /*
             * Basic idea of the algorith is simple--choose a random cell among all the cells
             * with the top percentile. The percentile threshold is defined by the AICleverness.
            */

            // Find the maximum possibility of a cell to contain a ship.
            int maxPossibility = -1;
            for (int x = 0; x < 10; x++)
            {
                for (int y = 0; y < 10; y++)
                {
                    if (probabilitySet[x, y] > maxPossibility && !player.RevealedCells[x, y])
                    {
                        maxPossibility = probabilitySet[x, y];
                    }
                }
            }

            // Collect all the cells with a favourable probability to contain a ship.
            List<int[]> favourableCells = new List<int[]>();
            for (int x = 0; x < 10; x++)
            {
                for (int y = 0; y < 10; y++)
                {
                    // Is there any partially revealed cell?
                    if (partialRevealedCells.Count != 0)
                    {
                        // Collect the cell that have the best possibility of being a ship cell.
                        if (probabilitySet[x, y] == maxPossibility && !player.RevealedCells[x, y])
                        {
                            favourableCells.Add(new int[] { x, y });
                        }
                    }
                    else
                    {
                        // Collect the cells that have favourable possibility of being a ship cell.
                        if (probabilitySet[x, y] >= Math.Max((maxPossibility / 10 * AICleverness), 1) && !player.RevealedCells[x, y])
                        {
                            favourableCells.Add(new int[] { x, y });
                        }
                    }
                }
            }

            // Return a random cell out of all fabourable cells.
            return favourableCells[GlobalContext.RandomNumber(favourableCells.Count)];
        }

        // Perform an attack of a player on a player at a given cell.
        // [true] if game is over and the attacker won / [false] if not.
        static public bool PerformAttack(int cellX, int cellY, Player attacker, Player attacked)
        {
            
            // Mark the cell as revealed.
            attacked.RevealedCells[cellX, cellY] = true;

          
            // Mark the lastly revealed cell.
            attacked.LastRevieledCells[0] = cellX;
            attacked.LastRevieledCells[1] = cellY;

            // Is the attack a hit?
            if (attacked.ShipSet[cellX, cellY] != -1)
            {              
                // Decrease the amount of cells left for the ship that has been hit.
                attacked.ShipLeftCells[attacked.ShipSet[cellX, cellY]]--;

                if (attacked.ShipLeftCells[attacked.ShipSet[cellX, cellY]] == 0)
                {
                    // The ship was completely shot down.
                    attacked.ShipsLeft--;

                    // How many neighbouring cells has been revealed with the sunken ship.
                    int extraRevealedCells = 0;

                    // Reveal neighbouring cells of the sunken ship.
                    for (int x = 0; x < 10; x++)
                    {
                        for (int y = 0; y < 10; y++)
                        {
                            if (attacked.ShipSet[x, y] == attacked.ShipSet[cellX, cellY])
                            {
                                try
                                {
                                    if (!attacked.RevealedCells[x - 1, y - 1])
                                    {
                                        attacked.RevealedCells[x - 1, y - 1] = true;
                                        extraRevealedCells++;
                                    }
                                }
                                catch { };

                                try
                                {
                                    if (!attacked.RevealedCells[x - 1, y])
                                    {
                                        attacked.RevealedCells[x - 1, y] = true;
                                        extraRevealedCells++;
                                    }
                                }
                                catch { };

                                try
                                {
                                    if (!attacked.RevealedCells[x - 1, y + 1])
                                    {
                                        attacked.RevealedCells[x - 1, y + 1] = true;
                                        extraRevealedCells++;
                                    }
                                }
                                catch { };

                                try
                                {
                                    if (!attacked.RevealedCells[x, y - 1])
                                    {
                                        attacked.RevealedCells[x, y - 1] = true;
                                        extraRevealedCells++;
                                    }
                                }
                                catch { };

                                try
                                {
                                    if (!attacked.RevealedCells[x, y + 1])
                                    {
                                        attacked.RevealedCells[x, y + 1] = true;
                                        extraRevealedCells++;
                                    }
                                }
                                catch { };

                                try
                                {
                                    if (!attacked.RevealedCells[x + 1, y - 1])
                                    {
                                        attacked.RevealedCells[x + 1, y - 1] = true;
                                        extraRevealedCells++;
                                    }
                                }
                                catch { };

                                try
                                {
                                    if (!attacked.RevealedCells[x + 1, y])
                                    {
                                        attacked.RevealedCells[x + 1, y] = true;
                                        extraRevealedCells++;
                                    }
                                }
                                catch { };

                                try
                                {
                                    if (!attacked.RevealedCells[x + 1, y + 1])
                                    {
                                        attacked.RevealedCells[x + 1, y + 1] = true;
                                        extraRevealedCells++;
                                    }
                                }
                                catch { };
                            }
                        }
                    }

                  

                    // Is the game over?
                    if (attacked.ShipsLeft == 0)
                    {
                        return true;
                    }
                    else
                    {
                        // Else return a false, some ships are left
                        return false;
                    }
                }
                else
                {
                    //There are some ship cells left in this ship, so that Game dont end

                    return false;
                }
            }
            else
            {
                return false;
            }

        }
    }
}
