using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace GeographicalObject
{
    internal class Program
    {
        public abstract class GeoObject : IGeoObject
        {
            public double latitude { get; set; }
            public double longitude { get; set; }
            public string name { get; set; }
            public string description { get; set; }
            public virtual string GetInfo()
            {
                string res;
                res = "Latitude: " + latitude + 
                    "\nLongitude: " + longitude + 
                    "\nName: " + name + 
                    "\nDescription: " + description;
                return res;
            }
        }

        public interface IGeoObject
        {
            double latitude { get; set; }
            double longitude { get; set; }
            string name { get; set; }
            string description { get; set; }
            string GetInfo();
        }

        public class River : GeoObject
        {
            public double velocity = 0;
            public double length = 0;

            public override string GetInfo()
            {
                string res;
                res = base.GetInfo() +
                    "\nVelocity: " + velocity +
                    "\nLength: " + length;
                return res;
            }
        }

        public class Mountain : GeoObject
        {
            public double top = 0;

            public override string GetInfo() 
            {
                string res;
                res = base.GetInfo() +
                    "\nTop: " + top;
                return res;            }
        }

        static void Main(string[] args)
        {
            int failCount = 0;
            bool success = false;
            string userInput = "";
            while ((failCount < 2) & !success)
            {
                Console.WriteLine("Choose type of geoObject you want to create(river/mountain)");
                userInput = Console.ReadLine().Trim().ToLower();
                if (userInput == "river")
                {
                    var userObject = new River();
                    while ((failCount < 2) & !success)
                    {
                        Console.WriteLine("Enter latitude ");
                        string line = Console.ReadLine();
                        double d = 0;
                        if (!double.TryParse(line, out d))
                        {
                            Console.WriteLine("Wrong input");
                            failCount++;
                        }
                        else
                        {
                            success = true;
                            userObject.latitude = d;
                        }
                    }
                    failCount=0; success = false;
                    while ((failCount < 2) & !success)
                    {
                        Console.WriteLine("Enter longitude ");
                        string line = Console.ReadLine();
                        double d = 0;
                        if (!double.TryParse(line, out d))
                        {
                            Console.WriteLine("Wrong input");
                            failCount++;
                        }
                        else
                        {
                            success = true;
                            userObject.longitude = d;
                        }
                    }
                    failCount = 0; success = false;
                    Console.WriteLine("Enter name ");
                    userObject.name = Console.ReadLine();
                    Console.WriteLine("Enter description ");
                    userObject.description = Console.ReadLine();
                    while ((failCount < 2) & !success)
                    {
                        Console.WriteLine("Enter velocity of river flow ");
                        string line = Console.ReadLine();
                        double d = 0;
                        if (!double.TryParse(line, out d))
                        {
                            Console.WriteLine("Wrong input");
                            failCount++;
                        }
                        else
                        {
                            success = true;
                            userObject.velocity = d;
                        }
                    }
                    failCount = 0; success = false;
                    while ((failCount < 2) & !success)
                    {
                        Console.WriteLine("Enter length of river ");
                        string line = Console.ReadLine();
                        double d = 0;
                        if (!double.TryParse(line, out d))
                        {
                            Console.WriteLine("Wrong input");
                            failCount++;
                        }
                        else
                        {
                            success = true;
                            userObject.length = d;
                        }
                    }
                    Console.WriteLine(userObject.GetInfo());
                    success = true;
                }
                else if (userInput == "mountain")
                {
                    var userObject = new Mountain();
                    while ((failCount < 2) & !success)
                    {
                        Console.WriteLine("Enter latitude ");
                        string line = Console.ReadLine();
                        double d = 0;
                        if (!double.TryParse(line, out d))
                        {
                            Console.WriteLine("Wrong input");
                            failCount++;
                        }
                        else
                        {
                            success = true;
                            userObject.latitude = d;
                        }
                    }
                    failCount = 0; success = false;
                    while ((failCount < 2) & !success)
                    {
                        Console.WriteLine("Enter longitude ");
                        string line = Console.ReadLine();
                        double d = 0;
                        if (!double.TryParse(line, out d))
                        {
                            Console.WriteLine("Wrong input");
                            failCount++;
                        }
                        else
                        {
                            success = true;
                            userObject.longitude = d;
                        }
                    }
                    failCount = 0; success = false;
                    Console.WriteLine("Enter name ");
                    userObject.name = Console.ReadLine();
                    Console.WriteLine("Enter description ");
                    userObject.description = Console.ReadLine();
                    while ((failCount < 2) & !success)
                    {
                        Console.WriteLine("Enter the height of top of mountain ");
                        string line = Console.ReadLine();
                        double d = 0;
                        if (!double.TryParse(line, out d))
                        {
                            Console.WriteLine("Wrong input");
                            failCount++;
                        }
                        else
                        {
                            success = true;
                            userObject.top = d;
                        }
                    }
                    Console.WriteLine(userObject.GetInfo());
                    success = true;
                }
                else
                {
                    Console.WriteLine("Only river/mountain are available to create");
                    failCount++;
                }
            }
            Console.ReadKey();
        }
    }
}
