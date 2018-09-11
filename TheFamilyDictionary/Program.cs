using System;
using System.Collections.Generic;

namespace TheFamilyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            //Define a Dictionary that contains information about several members of your family. Use the following example as a template.
            Dictionary<string, Dictionary<string, string>> myFamily = new Dictionary<string, Dictionary<string, string>>();

            myFamily.Add("sister", new Dictionary<string, string>(){
                {"name", "Megan"},
                {"age", "22"}
            });

            myFamily.Add("brother", new Dictionary<string, string>(){
                {"name", "Corban"},
                {"age", "27"}
            });

            myFamily.Add("mother", new Dictionary<string, string>(){
                {"name", "Michelle"},
                {"age", "51"}
            });

            myFamily.Add("father", new Dictionary<string, string>(){
                {"name", "Kevin"},
                {"age", "55"}
            });

            //Next, iterate over each item in myFamily and produce the following output. Krista is my sister and is 42 years old.

            foreach (var member in myFamily)
            {
                var name = member.Value["name"];
                var relation = member.Key;
                var age = member.Value["age"];

                Console.WriteLine($"{ name } is my { relation } and is { age } years old.");
            }
            Console.ReadLine();
        }
    }
}
