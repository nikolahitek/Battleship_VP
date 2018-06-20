using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Battleships
{
    public static class GlobalContext
    {
       
        public static MainMenuForm MainMenuForm { get; set; }

        // Method for generating random numbers.
        public static int RandomNumber(int max)
        {
            Random random = new Random();
            return random.Next(max);
        }
    }
}
