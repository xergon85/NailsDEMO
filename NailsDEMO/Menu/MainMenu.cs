﻿namespace NailsDEMO.Menu
{
    internal class MainMenu(Simulation simulation) : BaseMenu(simulation)
    {
        public override void Run()
        {
            Console.Write(MenuHelper.ClearScreen +
                "1: Start Simulation\n" +
                "2: Human Menu\n" +
                "3: Exit\n" +
                "> ");

            string? input = Console.ReadLine();

            switch (input)
            {
                case "1": simulation.ChangeMenu(new SimulationMenu(simulation)); break;

                case "2": simulation.ChangeMenu(new HumansMenu(simulation)); break;

                case "3": simulation.Exit(); break;
            }
        }
    }
}
