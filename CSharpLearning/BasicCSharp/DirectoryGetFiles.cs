using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Reflection.Metadata;

namespace BasicCSharp
{
    internal class DirectoryGetFiles
    {
        public static void Main(string[] args)
        {
            // Directory .GetFiles() method is used to get the list of files in a directory
            string directoryPath = "I://Documents";
            string[] files = Directory.GetFiles(directoryPath);

            foreach(string file in files)
            {
                Console.WriteLine(file);
            }

            // copy data one file to another file
            string sourceFilePath = "I://Documents//example.txt";
            string destinationFilePath = "I://Documents//example1.txt";

            File.Copy(sourceFilePath, destinationFilePath, true);
            Console.WriteLine("Copied data from " + sourceFilePath + " to " + destinationFilePath);

            // Handling exceptions

            Console.WriteLine("Handoling exceptions");
            string filePath = "I://Document//example.txt";
            try
            {
                string content = File.ReadAllText(filePath);
                Console.WriteLine("Content of the file: " + content);
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine($"File not found: {ex.Message}");
            }
            catch (UnauthorizedAccessException ex)
            {
                Console.WriteLine($"Access denied: {ex.Message}");
            }
            catch (IOException ex)
            {
                Console.WriteLine($"IO error: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }
    }
}
