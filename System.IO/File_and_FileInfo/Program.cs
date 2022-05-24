using System;
using System.IO;

namespace File_and_FileInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = Path.Combine(Environment.CurrentDirectory +"\\teste.txt");
            using var sw = File.CreateText(path);
            sw.WriteLine("Esta é a 1 linha");
            sw.WriteLine("Esta é a 2 linha");
            sw.WriteLine("Esta é a 3 linha");
            sw.WriteLine("Esta é a 4 linha");
        }
    }
}
