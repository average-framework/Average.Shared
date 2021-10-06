using System.Collections.Generic;

namespace Average.Shared.Models
{
    public class CommandModel
    {
        public string Name { get; set; }
        public string[] Alias { get; set; }

        public CommandModel()
        {

        }

        public CommandModel(string name, string[] alias)
        {
            Name = name;
            Alias = alias;
        }
    }
}
