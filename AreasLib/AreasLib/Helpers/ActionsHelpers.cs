using AreasLib.Helpers.IHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreasLib.Helpers
{
    public class ActionsHelpers : IActionsHelpers
    {
        public string? ConsoleReadLineWrapper()
        {
            return Console.ReadLine();
        }
    }
}
