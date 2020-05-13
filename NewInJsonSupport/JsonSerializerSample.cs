using System;
using System.IO;
using System.Text.Json;

namespace NewInJsonSupport
{
    public class Course
    {
        public string CourseName { get; set; }
        public string Language { get; set; }

        public Author Author { get; set; }
    }
    public class Author
    {
        public string FirstName { get; set; }   
        public string lastName { get; set; }   

    }
    public static class JsonSerializerSample
    {
        public static void RunSample()
        {
            Console.WriteLine("serializer sample ");
            var courseText = File.ReadAllText("sample.json");
            var course = JsonSerializer.Deserialize<Course>(courseText,
                new JsonSerializerOptions {PropertyNamingPolicy = JsonNamingPolicy.CamelCase});

            Console.WriteLine("course name {0} language {1}",course.CourseName,course.Language);
        }
    }
}
