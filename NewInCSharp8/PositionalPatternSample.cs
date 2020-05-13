using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using System.Text;

namespace NewInCSharp8
{
    /// <summary>
    /// to use position patterns you must add the deconstruct method to the classes 
    /// </summary>
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Teacher HomeRoomTeacher { get; set; }
        public int GradeLevel { get; set; }

        public Student(string firstName, string lastName, Teacher homeRoomTeacher,int gradeLevel)
        {
            FirstName = firstName;
            LastName = lastName;
            HomeRoomTeacher = homeRoomTeacher;
            GradeLevel = gradeLevel;
        }

        /// <summary>
        /// deconstruct method should be named as deconstruct and the parameters are out parameters 
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="homeRoomTeacher"></param>
        /// <param name="gradeLevel"></param>
        public void Deconstruct(out string firstName,out string lastName,out Teacher homeRoomTeacher,out int gradeLevel)
        {
            firstName = FirstName;
            lastName = FirstName;
            homeRoomTeacher = HomeRoomTeacher;
            gradeLevel = GradeLevel;
        }
    }
    public class Teacher
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Position { get; set; }

        public Teacher(string firstName,string lastName,string position)
        {
            FirstName = firstName;
            LastName = lastName;
            Position = position;
        }

        public void Deconstruct(out string firstName, out string lastName, out string position)
        {
            firstName = FirstName;
            lastName = LastName;
            position = Position;
        }
    }
 public  static class PositionalPatternSample
    {
        
        public static bool IsInSeventhGrandMath(Student s)
        {
            // this _ is called discards
            //all cases are valid
            return s is Student(_, _, Teacher(_,_,"Math"), 7);
            return s is Student(_, _, (_,_,"Math"), 7);
            return s is (_, _, (_,_,"Math"), 7);
        }
    }
}
