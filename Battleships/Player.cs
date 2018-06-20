using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Battleships
{
    public class Player
    {
        // Locations of the players' ships.
        public int[,] ShipSet { get; set; }
        // Revieled cells
        public bool[,] RevealedCells { get; set; }
        // Last revieled cells.
        public int[] LastRevieledCells { get; set; }
        // Ships cells left.
        public int[] ShipLeftCells { get; set; }
        // Ships left count.
        public int ShipsLeft { get; set; }

        public Player()
        {
            ShipLeftCells = new int[] { 2, 3, 3, 4, 5 };
            ShipsLeft = 5;
            ShipSet = new int[10, 10];
            RevealedCells = new bool[10, 10];

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    ShipSet[i, j] = -1;
                    RevealedCells[i, j] = false;
                }
            }

            LastRevieledCells = new int[2];
            LastRevieledCells[0] = -1;
            LastRevieledCells[1] = -1;
        }
    }
}
