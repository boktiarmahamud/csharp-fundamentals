using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCSharp
{
    internal class FileHandling
    {
        public static void Main(string[] args)
        {
            FileInfo fileInfo = new FileInfo("I://example.txt");
            // create file stream
            FileStream fileStream = fileInfo.Open(FileMode.OpenOrCreate, FileAccess.ReadWrite);

            // stream writer to write data to the file
            StreamWriter streamWriter = new StreamWriter(fileStream);
            streamWriter.WriteLine("Hello, this is a test file.");
            streamWriter.Close();

            Console.WriteLine("File created and data written successfully.");

            // Read from file
            
            Console.WriteLine("Read from file");
            string filePath = "I://example1.txt";
            FileStream readFileStream = new FileStream(
            filePath,
            FileMode.Open,
            FileAccess.Read
        );
            StreamReader streamReader = new StreamReader(readFileStream);
            string content = streamReader.ReadToEnd();
            streamReader.Close();
            Console.WriteLine("File Content:");
            Console.WriteLine(content);
        }
    }
}
