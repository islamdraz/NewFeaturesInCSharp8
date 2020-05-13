using System;
using System.Buffers;
using System.Text;
using System.Text.Json;

namespace NewInJsonSupport
{
    public static class JsonWriterSample
    {
        public static void RunSample()
        {
            Console.WriteLine("*** Utf8JsonWriter sample");

            var buffer = new ArrayBufferWriter<byte>();
            using var json = new Utf8JsonWriter(buffer,new JsonWriterOptions{Indented = true});

            PopulateJson(json);
            json.Flush();

            var output = buffer.WrittenSpan.ToArray();
            var ourJson = Encoding.UTF8.GetString(output);
            Console.WriteLine(ourJson);

        }

        private static void PopulateJson(Utf8JsonWriter json)
        {
            json.WriteStartObject();

            json.WritePropertyName("courseName");
            json.WriteStringValue("Build your own Application Framework");

            json.WriteString("language","C#");
            json.WriteStartObject("author");
            json.WriteString("firstName","islam");
            json.WriteString("lastName","Draz");
            json.WriteEndObject();

            json.WriteEndObject();
        }
    }
}
