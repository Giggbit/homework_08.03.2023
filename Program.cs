using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_homework_08._03._2023
{
    class Device {
        public string name { get; set; } 
        public string company { get; set; }
        public int price { get; set; }

        public Device() { }
        public Device(string name, string company, int price) {
            this.name = name;
            this.company = company;
            this.price = price;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            List<Device> device1 = new List<Device>()
            {
                new Device("F50", "Samsung", 550),
                new Device("iPhone 12 pro", "Apple", 1050),
                new Device("TR-S20", "Xiaomi", 230),
                new Device("A53", "Samsung", 700),
                new Device("U12", "Honor", 380),
                new Device("iPhone 10", "Apple", 850)
            };

            var DeviceGroups = from dev in device1
                group dev by dev.company;
            foreach(IGrouping<string, Device> d in DeviceGroups) { 
                Console.WriteLine($"{d.Key}:");
                foreach(var a in d) {
                    Console.WriteLine(a.name);
                }
                Console.WriteLine();
            }


        }
    }
}
