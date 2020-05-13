using System;
using System.Collections.Generic;
using System.Text;

namespace NewInCSharp8
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Type { get; set; }
        public string Region { get; set; }
        public Employee ReportsTo { get; set; }

     
    }

public static  class PropertyPatternSample
    {
        public static bool IsUSBasedWithUKManager(Employee e)
        {
            return e is {Region:"US",ReportsTo:{Region:"UK"} };
        }

        public static bool IsUSBasedWithUKManager(object o)
        {
            return o is Employee e &&
                   e is { Region: "US", ReportsTo: { Region: "UK" } };
        }
    }
}
