using System;
using System.IO;
using System.Net;

Console.Write("File Name: ");
var FileName = Console.ReadLine();

Console.Write("Type of file: ");
var FileType = Console.ReadLine();

String str = $"{FileName}.{FileType}";

Console.Write("File Text: ");
var FileText = Console.ReadLine();

try
{

    using (StreamWriter writer = File.CreateText(str))
    {
        writer.WriteLine(FileText);
    }
}
catch
{
    Console.WriteLine("Error Code 101");
}

try
{
    Console.WriteLine("Done!");
    Thread.Sleep(1000);
    Environment.Exit(0);
}
catch
{
    Console.WriteLine("Error Code 404 (No reason this would fail :D)");
}

