using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_7_23_Assign_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose an One:");
            Console.WriteLine("1. Create");
            Console.WriteLine("2. Read");
            Console.WriteLine("3. Append");
            Console.WriteLine("4. Delete");
            int operation = int.Parse(Console.ReadLine());
            switch (operation)
            {
                case 1:
                    Console.WriteLine("Enter the file name: ");
                    string createFileName = Console.ReadLine();
                    Console.WriteLine("Enter the content: ");
                    string createContent = Console.ReadLine();
                    CreateFile(createFileName, createContent);
                    break;
                case 2:
                    Console.WriteLine("Enter the file name: ");
                    string readFileName = Console.ReadLine();
                    ReadFile(readFileName);
                    break;
                case 3:
                    Console.WriteLine("Enter the file name: ");
                    string appendFileName = Console.ReadLine();
                    Console.WriteLine("Enter the content to append: ");
                    string appendContent = Console.ReadLine();
                    AppendToFile(appendFileName, appendContent);
                    break;
                case 4:
                    Console.WriteLine("Enter the file name: ");
                    string deleteFileName = Console.ReadLine();
                    DeleteFile(deleteFileName);
                    break;
                default:
                    Console.WriteLine("Invalid operation selected.");
                    break;
            }
        }
        static void CreateFile(string fName, string content)
        {
            string fPath = fName + ".txt";
            using (StreamWriter writer = File.CreateText(fPath))
            {
                Console.Write(content);
            }
            Console.WriteLine($"File '{fName}' created successfully.");
        }
        static void ReadFile(string fName)
        {
            string fPath = fName + ".txt";
            if (File.Exists(fPath))
            {
                string content = File.ReadAllText(fPath);
                Console.WriteLine($"Content of file '{fName}':");
                Console.WriteLine(content);
            }
            else
            {
                Console.WriteLine($"File '{fName}' does not exist.");
            }
        }
        static void AppendToFile(string fName, string content)
        {
            string fPath = fName + ".txt";
            if (File.Exists(fPath))
            {
                using (StreamWriter writer = File.AppendText(fPath))
                {
                    Console.Write(content);
                }

                Console.WriteLine($"Content appended to file '{fName}' successfully.");
            }
            else
            {
                Console.WriteLine($"File '{fName}' does not exist.");
            }
        }
        static void DeleteFile(string fName)
        {
            string filePath = fName + ".txt";
            if (File.Exists(filePath))
            {
                File.Delete(filePath);
                Console.WriteLine($"File '{fName}' deleted successfully.");
            }
            else
            {
                Console.WriteLine($"File '{fName}' does not exist.");
            }
            Console.ReadKey();
        }
    }
}
    

