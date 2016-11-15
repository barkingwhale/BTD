using BTD.states;

namespace BTD
{
    class Program
    {
        static void Main(string[] args)
        {
            // imediately launch in the game statemanager.  it will handle when to exit
            while (GameStateManager.Instance.Update()) {}

            // pause so we can see the goodbye message
            System.Threading.Thread.Sleep(1500);
        }
    }
}
