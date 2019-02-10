using System;
using System.IO;

namespace UsingDisposeExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"c:\Users\formacion\Documents\Curso\deberes.rtf";
            try
            {
                using (FileStream fs = File.OpenRead(path))
                {
                    Console.WriteLine("Reading file {0}", path);
                }
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex);
            }

            DisposableClass dc = new DisposableClass();
            dc.Dispose();
        }
    }
}
