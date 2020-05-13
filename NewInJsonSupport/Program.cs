using System;
using System.IO;
using System.Text.Json;

namespace NewInJsonSupport
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**Utf8JsonReader sample");

            var jsonByte = File.ReadAllBytes("sample.json");
            var jsonSpan = jsonByte.AsSpan();

            //this type works with spans only ,
            //so we converted the bytearray to span first
            var json = new Utf8JsonReader(jsonSpan); 

            while (json.Read())
            {
              Console.WriteLine(GetTokenDesc(json)); 
            }

            Console.WriteLine("**********************************************");

            JsonDocumentSample.RunSample();

            Console.WriteLine("**********************************************");

            JsonWriterSample.RunSample();


            Console.WriteLine("**********************************************");

            JsonSerializerSample.RunSample();
        }

        public static string GetTokenDesc(Utf8JsonReader json) => json.TokenType switch
        {
            JsonTokenType.StartObject=>$"Start Object",
            JsonTokenType.EndObject=>"End object",
            JsonTokenType.StartArray=>"Start Array",
            JsonTokenType.EndArray=>"End Array",
            JsonTokenType.PropertyName=>$"Propery:{json.GetString()}",
            JsonTokenType.Comment=>$"comment: {json.GetString()}",
            JsonTokenType.String=>$"comment: {json.GetString()}",
            JsonTokenType.True=>$"comment: {json.GetBoolean()}",
            JsonTokenType.False=>$"comment: {json.GetBoolean()}",
            _=>$"Unknown {json.TokenType}"

        };
    }
}
