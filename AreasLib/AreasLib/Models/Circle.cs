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
        /*        public double R;
                public Circle(double R)
                {
                    if (R < 0)
                    {
                        throw new Exception();
                    }
                    this.R = R;
                }
        */
        public double GetArea(params double[] p)
        {
            /*            return Math.PI * Math.Pow(R, 2);
            */
            return 0;
        }
    }
}
