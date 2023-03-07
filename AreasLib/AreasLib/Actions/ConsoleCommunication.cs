using AreasLib.Actions.IActions;
using AreasLib.Helpers;
using AreasLib.Helpers.IHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreasLib.Actions
{
    public class ConsoleCommunication : IConsoleCommunication
    {
        IActionsHelpers _helpers;
        public ConsoleCommunication(IActionsHelpers helpers)
        {
            _helpers = helpers;
        }
        public double? GetSomeDoubleValueFromUser(string messageToUser)
        {
            Console.WriteLine($">> {messageToUser}");
            Console.WriteLine("*** Введите Q для выхода ***");
            while (true)
            {
                try
                {
                    Console.Write(">> ");
                    var response = _helpers.ConsoleReadLineWrapper();
                    if (response == "Q")
                    {
                        return null;
                    }

                    var result = Convert.ToDouble(response);
                    if (result < 0)
                    {
                        throw new Exception();
                    }

                    return result;
                }
                catch
                {
                    Console.WriteLine("Введены некорректные данные. Повторите ввод.");
                }
            }
        }
    }
}
