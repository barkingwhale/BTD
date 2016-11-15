using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BTD.states;

namespace BTD
{
    class Program
    {
        static void Main(string[] args)
        {
            // imediately launch in the game statemanager.  it will handle when to exit
            while (GameStateManager.Instance.Update()) {}

            // prompt so console doesn't disappear immediately
            //Console.WriteLine("\nGame is over.  Hit any key to close console.");
            //Console.ReadLine();

            // pause so we can see the goodbye message
            System.Threading.Thread.Sleep(1500);
        }
    }
}
