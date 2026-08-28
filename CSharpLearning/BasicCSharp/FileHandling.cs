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
        }
    }
}
