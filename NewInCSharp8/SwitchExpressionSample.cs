using System;
using System.Collections.Generic;
using System.Text;

namespace NewInCSharp8
{
    public class Circle
    {
        public int Radius { get; set; }
        public Circle(int radius) => Radius = radius;
    }

    public class Rectangle
    {
        public int Length { get; set; }
        public int Width { get; set; }
        public Rectangle(int length,int width) => (Length,Width) = (length,width);
    }

    public class Triangle
    {
        public int Side1 { get; set; }
        public int Side2 { get; set; }
        public int Side3 { get; set; }
        public Triangle(int side1, int side2,int side3) => (Side1, Side2,Side3) = (side1, side2,side3);
    }
    public static class SwitchExpressionSample
    {
        public static string DisplayShap(object shap)
        {
            string result = shap switch
            {
                Rectangle r => $"Rectangle (l={r.Length} w={r.Width})",
                Circle c => $"Circle r={c.Radius}",
                Triangle t => $"Triangle {t.Side1} {t.Side2} {t.Side3}",
                _=>$"Unknown Shape"
            };

            return result;
        }

        /// <summary>
        /// this is expression bodied method
        /// </summary>
        /// <param name="shap"></param>
        /// <returns></returns>
        public static string DisplayShap2(object shap)=>
         shap switch
            {
                
                Rectangle r2 => r2 switch
                {
                    _ when r2.Length == r2.Width => "Square!",
                    _ => ""
                },
                Circle c => $"Circle r={c.Radius}",
                Triangle t => $"Triangle {t.Side1} {t.Side2} {t.Side3}",
                _ => $"Unknown Shape"
            };

        
    }
}
