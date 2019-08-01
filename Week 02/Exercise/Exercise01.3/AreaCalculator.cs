
using System.Collections.Generic;

namespace Exercise013
{
    public class AreaCalculator
    {
        public static List<double> Area(IShape[] shapes)
        {
            List<double> area = new List<double>();
            foreach (var shape in shapes)
            {
                area.Add(shape.Area());
            }

            return area;
        }
    }
}