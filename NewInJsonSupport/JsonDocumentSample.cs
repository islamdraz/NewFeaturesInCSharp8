using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;

namespace NewInJsonSupport
{
   public static class JsonDocumentSample
    {
        public static void RunSample()
        {
            Console.WriteLine("**Json Document sample");
            //jsonDocument could read Span and stream also
            using var stream = File.OpenRead("sample.json");
            using var doc = JsonDocument.Parse(stream);

            var root = doc.RootElement;
            var firstName = root
                .GetProperty("author")
                .GetProperty("firstName")
                .GetString();

            Console.WriteLine($"Author first name : {firstName}");


            EnumerateElement(root);
        }

        private static void EnumerateElement(JsonElement root)
        {
            foreach (var prop in root.EnumerateObject())
            {
                if (prop.Value.ValueKind == JsonValueKind.Object)
                {
                    Console.WriteLine($"{prop.Name}");
                    Console.WriteLine($"Begin Object");
                    EnumerateElement(prop.Value);
                    Console.WriteLine($"End Object");

                }
                else
                {
                    Console.WriteLine($"{prop.Name} : {prop.Value.GetRawText()}");
                }
            }
        }
    }

}
