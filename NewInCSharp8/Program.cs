using System;
using System.Linq;

namespace NewInCSharp8
{
    // this project is part of pattern matching 
    class Program
    {
        static void Main(string[] args) 
        {
            // start item is inclusive and end of index is exclusive means  last item is out of array 
         // indexing from the end is relative to the length
            //indexes and ranges
           var numbers = Enumerable.Range(1, 10).ToArray();
           var copy = numbers[..];
           var copy1 = numbers[0..10];
           var copy3 = numbers[0..^0];
           var allButFirst = numbers[1..];
           var lastItemRang = numbers[^1..];
           var lastItemInt = numbers[^1];
           var lastThreeItems = numbers[^3..];


           Index middle = 4;
           Index threeFromEnd = ^3;
           Range customeRange = middle..threeFromEnd;
           var custom = numbers[customeRange];
        }
    }
}
 