using AreasLib.Actions.IActions;
using AreasLib.Models.IModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreasLib.Models
{
    public class Triangle : IFigure
    {
        IConsoleCommunication _consoleCommunic;
        public Triangle(IConsoleCommunication consoleCommunic)
        {
            _consoleCommunic = consoleCommunic;
        }

        public double? GetArea()
        {
            double? a = _consoleCommunic.GetSomeDoubleValueFromUser("Введите длину стороны А");
            if (a == null)
                return null;

            double? b = _consoleCommunic.GetSomeDoubleValueFromUser("Введите длину стороны B");
            if (b == null)
                return null;

            double? c = _consoleCommunic.GetSomeDoubleValueFromUser("Введите длину стороны C");
            if (c == null)
                return null;

            double? p = (a + b + c) / 2;
            return Math.Sqrt((double)(p * (p - a) * (p - b) * (p - c)));
        }

        public bool? IsRectangular()
        {
            double? a = _consoleCommunic.GetSomeDoubleValueFromUser("Введите длину стороны А");
            if (a == null)
                return null;

            double? b = _consoleCommunic.GetSomeDoubleValueFromUser("Введите длину стороны B");
            if (b == null)
                return null;

            double? c = _consoleCommunic.GetSomeDoubleValueFromUser("Введите длину стороны C");
            if (c == null)
                return null;

            if (Math.Pow((double)a, 2) == (Math.Pow((double)b, 2)) + Math.Pow((double)c, 2) ||
                Math.Pow((double)b, 2) == (Math.Pow((double)a, 2)) + Math.Pow((double)c, 2) ||
                Math.Pow((double)c, 2) == (Math.Pow((double)a, 2)) + Math.Pow((double)b, 2))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
