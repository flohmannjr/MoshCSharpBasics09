using System;
using System.IO;
using System.Text;

namespace MoshCSharpBasics09
{
    class Program
    {
        static void Main(string[] args)
        {
            //var path = @"c:\users\fred\documents\visual studio 2015\Projects\MoshCSharpBasics09\MoshCSharpBasics09\";
            //var exercise = "Program.cs";
            var path = @"c:\users\fred\documents\";
            var exercise = "TombRaider.log";
            var fullPath = path + exercise;

            var exerciseContent = File.ReadAllText(fullPath);
            var words = exerciseContent.Split(' ');
            var longestWord = "";

            foreach (var word in words)
                if (word.Length > longestWord.Length)
                    longestWord = word;

            var output = new StringBuilder();

            output
                .Append("File: " + fullPath)
                .AppendLine()
                .Append("Word count: " + words.Length)
                .AppendLine()
                .Append("Longest word: " + longestWord);

            Console.WriteLine(output);
        }
    }
}
