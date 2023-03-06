using AreasLib.Models.IModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreasLib.Actions.IActions
{
    public interface IAreasGenerallActions
    {
        public double GetAreaOfSomeFigure(IFigure figure);
    }
}
