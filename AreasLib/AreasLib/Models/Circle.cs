using AreasLib.Actions.IActions;
using AreasLib.Models.IModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreasLib.Models
{
    public class Circle : IFigure
    {
        IConsoleCommunication _consoleCommunic;
        public Circle(IConsoleCommunication consoleCommunic)
        {
            _consoleCommunic = consoleCommunic;
        }
        public double? GetArea()
        {
            double? radius = _consoleCommunic.GetSomeDoubleValueFromUser("Введите радиус");
            if (radius == null)
                return null;

            return Math.PI * Math.Pow((double)radius, 2);
        }
    }
}
