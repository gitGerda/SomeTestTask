using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreasLib.Models.IModels
{
    /// <summary>
    /// Фигура
    /// </summary>
    public interface IFigure
    {
        /// <summary>
        /// Функция вычисления площади
        /// </summary>
        /// <returns></returns>
        double? GetArea();
    }
}
