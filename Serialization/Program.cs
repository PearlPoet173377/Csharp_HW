using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;


namespace Serialization
{
    class Program
    {
        public static void Serialize(List<Car> cars, string path)
        {
            XmlSerializer xmlFile = new XmlSerializer(typeof(List<Car>));
            using (Stream fstream = new FileStream(path, FileMode.OpenOrCreate))
            {
                xmlFile.Serialize(fstream, cars);
            }
        }

        public static List<Car> DeSerialize(string path)
        {
            XmlSerializer xmlFile = new XmlSerializer(typeof(List<Car>));

            using (Stream stream = File.OpenRead(path))
            {
                return (List<Car>)xmlFile.Deserialize(stream);
            }
        }


        static void Main(string[] args)
        {
            
            List<Car> car = new List<Car>();
            Car Car_001 = new Car(150, "Car_001");
            Car Car_002 = new Car(280, "Car_002");
            Car Car_003 = new Car(195, "Car_003");
            Car Car_004 = new Car(250, "Car_004");

            car.Add(Car_001);
            car.Add(Car_002);
            car.Add(Car_003);
            car.Add(Car_004);

            string action = "";

            while (true)
            {
                do
                {
                    Console.WriteLine("Choose action:\t" + "1. - Read;\t" + "2. - Write;");
                    action = Console.ReadLine();
                } while (action != "1" && action != "2");

                if (action == "1")
                {

                    string name = "";
                    bool FExists = false;

                    while (!FExists)
                    {
                        
                        Console.WriteLine("Enter file name");
                        name = Console.ReadLine();

                        if (FExists = File.Exists(name))
                        {
                            Console.WriteLine("Not found");
                        }

                        else
                        {
                            Console.WriteLine("Not found. Try again");
                        }
                    }

                    List<Car> cars = DeSerialize(name);
                    Console.WriteLine("Result: ");

                    foreach (var item in cars)
                    {
                        Console.WriteLine($"Model: {item.Model}, Max speed: {item.MaxSpeed}");
                    }

                }

                else if (action == "2")
                {
                    string name = "";
                    Console.WriteLine("Enter file name: ");
                    name = Console.ReadLine();
                    Serialize(car, name);
                    Console.WriteLine("Successfuly!");
                }

                Console.ReadKey();
            }

        }
    }
}