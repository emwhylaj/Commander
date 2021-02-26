using System.Collections.Generic;
using Commander.Models;

namespace Commander.Data
{
    public class MockCommanderRepo : ICommanderRepo
    {
        public IEnumerable<Command> GetAllCommands()
        {
            var commands = new List<Command>
            {
                new Command { Id = 0, HowTo = "Boil an egg", Line = "Boil water", PlatForm = "Kettle and Pan" },
                new Command { Id = 1, HowTo = "Cut Bread", Line = "Get a knife", PlatForm = "knife & chopping board" },
                new Command { Id = 2, HowTo = "Boil an egg", Line = "Boil water", PlatForm = "Kettle and cup" }
            };
            return commands;
        }

        public Command GetCommandById(int id)
        {
            return new Command { Id = 0, HowTo = "Boil an egg", Line = "Boil water", PlatForm = "Kettle and Pan" };
        }
    }

}
