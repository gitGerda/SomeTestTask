using AreasLib.Actions.IActions;
using AreasLib.Helpers;
using AreasLib.Helpers.IHelpers;
using AreasLib.Models;
using AreasLib.Models.IModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreasLib.Actions
{
    public class AreasGenerallActions
    {
        IConsoleCommunication _consoleCommunic;
        public AreasGenerallActions(IConsoleCommunication consoleCommunic)
        {
            _consoleCommunic = consoleCommunic;
        }
        public double GetAreaOfSomeFigure()
        {
            Console.WriteLine();
            var radius = _consoleCommunic.GetSomeDoubleValueFromUser("Введите радиус");
            return 0;
        }

    }
}
