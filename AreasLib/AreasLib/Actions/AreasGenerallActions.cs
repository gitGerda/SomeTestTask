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
        public double? GetAreaOfSomeFigure(IFigure figure)
        {
            if (figure is Circle)
            {
                var _circle = new Circle(_consoleCommunic);
                return _circle.GetArea();
            }
            else if (figure is Triangle)
            {
                var _triangle = new Triangle(_consoleCommunic);
                return _triangle.GetArea();
            }
            else
            {
                throw new Exception("Error: Unsupported figure");
            }
        }

    }
}
