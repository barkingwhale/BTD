using BTD.states;

namespace BTD
{
    class Program
    {
        static void Main(string[] args)
        {
            // start up the statemanager and keep processing until 
            // it tells us to exit
            while (GameStateManager.Instance.Update()) {}

            // pause so we can see the goodbye message
            System.Threading.Thread.Sleep(1500);
        }
    }
}
