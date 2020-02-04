using System;
using Core;

namespace UI
{
    class Program
    {
        static void Main(string[] args)
        {
            var game = new Game();


            // если состояние насоса поменялось, то выведи новое состояние (isActive)
            game.SubscribeOnPumpChanged((x) => Console.WriteLine("pump is now " + x));
            game.SubscribeOnPumpChanged((x) => Console.WriteLine("pump is now " + x));
            game.SubscribeOnPumpChanged((x) => Console.WriteLine("pump is now " + x));

            game.TogglePumpState();
            game.TogglePumpState();
        }
    }
}
