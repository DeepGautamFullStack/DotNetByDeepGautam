using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSPractice
{
    class Animal
    {
        public double Hieght { get; set; }
        public double  Weight { get; set; }
        public string Name { get; set; }
        public string Sound { get; set; }
        public Animal()
        {
            this.Hieght = 0;
            this.Weight = 0;
            this.Name = "No Name";
            this.Sound = "No sound";
            numOfAnimals++;
        }
        public Animal(double hieght,double wieght,string name,string sound)
        {
            this.Hieght = hieght;
            this.Weight = wieght;
            this.Name = name;
            this.Sound = sound;
            numOfAnimals++;  
        }
        static int numOfAnimals = 0;
        public static int GetNumofAnimals()
        {
            return numOfAnimals;
        }
        public string toString()
        {
            return string.Format("{0} is {1} inches tall, weighs {2} lbs and like to say {3} ",Name,Hieght,Weight,Sound);
        }
        static void Main(string[] args)
        {
            Animal spot = new Animal(15, 10, "spot", "woof");
            Console.WriteLine("{0} says {1}",spot.Name,spot.Sound);
            Console.WriteLine("No of animals is  "+ Animal.GetNumofAnimals());
            Console.WriteLine(spot.toString());

            Console.ReadLine();

        }
    }
}
