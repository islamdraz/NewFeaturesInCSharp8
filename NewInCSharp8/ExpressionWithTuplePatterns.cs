using System;
using System.Collections.Generic;
using System.Text;

namespace NewInCSharp8
{
    public enum Color
    {
        Unknown,
        Red,
        Blue,
        Green,
        Purple,
        Orange,
        Brown,
        Yellow
    }
public   static class ExpressionWithTuplePatterns
    {
        /// <summary>
        /// switch expression with tuple pattern
        /// </summary>
        /// <param name="c1"></param>
        /// <param name="c2"></param>
        /// <returns></returns>
        public static Color GetColor(Color c1, Color c2)
        {
            return  (c1,c2) switch
            {
                (Color.Blue,Color.Brown)=> Color.Purple,
                (Color.Red,Color.Brown)=> Color.Yellow,
                (Color.Orange,Color.Brown)=> Color.Green,
                (_,_) when c1==c2=>c1,
                _=>Color.Unknown
            };
        }
    }
}
