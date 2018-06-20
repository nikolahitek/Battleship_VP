using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;
using System.Media;
using System.Threading;

namespace Battleships
{
   
       public static class Program
    {
              
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            // Initialize the main menu and run the application.
            MainMenuForm mainMenuForm = new MainMenuForm();
            GlobalContext.MainMenuForm = mainMenuForm;
            Application.Run(mainMenuForm);
        }
    }
}
