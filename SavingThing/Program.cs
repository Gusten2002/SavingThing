using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace SavingThing
{
    class Program
    {
        static void Main(string[] args)
        {
            string [] ans = ("1", "2");
            XmlSerializer cookieSerializer = new XmlSerializer(typeof(cookie));

            string input = Console.ReadLine();

            while (!ans.Contains(input))
            {
                Console.WriteLine("Do you have 1 or 2 cookies?");
                input = Console.ReadLine();
            }
  

            cookie c = new cookie();
            
            FileStream file = File.Open(@"cookies.xml", FileMode.OpenOrCreate);

            cookieSerializer.Serialize(file, c);

            file.Close();
            
            // Console.WriteLine(c.chocolate);

            Console.ReadLine();
        }
    }
}
