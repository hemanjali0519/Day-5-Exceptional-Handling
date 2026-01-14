// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;
using System.IO;
using System.Text;
//write a file using file.Create() method  
//create a file using streamwriter class
//using file.writealltext() method
//read a file using streamreader class
//delete a file using file.delete() method
//check file exists using file.exists() method 
class Program
{
    static void Main()
    {
        string filePath = "example.txt";
        // Create a file using File.Create() method
        using (FileStream fs = File.Create(filePath))
        {
            byte[] info = new UTF8Encoding(true).GetBytes("This is some text in the file.");
            fs.Write(info, 0, info.Length);
        }
        // Create a file using StreamWriter class
        using (StreamWriter sw = new StreamWriter("streamwriter_example.txt"))
        {
            sw.WriteLine("This is a line written using StreamWriter.");
        }
        // Create a file using File.WriteAllText() method
        File.WriteAllText("writealltext_example.txt", "This text is written using File.WriteAllText().");
        // Read a file using StreamReader class
        using (StreamReader sr = new StreamReader(filePath))
        {
            string content = sr.ReadToEnd();
            Console.WriteLine("Content of example.txt:");
            Console.WriteLine(content);
        }
        // Delete a file using File.Delete() method
        File.Delete(filePath);
        Console.WriteLine($"{filePath} has been deleted.");
        // Check if file exists using File.Exists() method
        if (File.Exists(filePath))
        {
            Console.WriteLine($"{filePath} exists.");
        }
        else
        {
            Console.WriteLine($"{filePath} does not exist.");
        }
    }
}