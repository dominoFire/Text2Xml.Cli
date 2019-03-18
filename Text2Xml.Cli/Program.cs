using System;
using System.IO;
using Text2Xml;

namespace Text2Xml.Cli
{
    class Program
    {
        static void Main(string[] args)
        {
            TextWriter stderr = Console.Error;

            if (args.Length < 1)
            {    
                stderr.WriteLine("Missing arg: filename");
                Environment.Exit(1);
            }

            string filepath = args[0];

            try
            {
                Text2XmlConverter converter = new Text2XmlConverter();
                string xmltext = converter.Parse(filepath);
                Console.WriteLine(xmltext);
            }
            catch (Exception ex)
            {
                stderr.WriteLine("Error: " + ex.Message);
                Environment.Exit(2);
            }
        }
    }
}
