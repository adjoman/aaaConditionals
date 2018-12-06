using System;
using System.Collections;
using System.Collections.Generic;

namespace AAAConditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            Motorcycle yamaha = new Motorcycle();
            yamaha.engine   = "1800";
            yamaha.seat     = "double";
            yamaha.fuelTank = "4 gallon";

            Motorcycle harley   = new Motorcycle();
            harley.engine       = "tiny";
            harley.fuelTank     = "4.5 gallons";

            List<string> testList = new List<string>();

            List<Motorcycle> motorcycles = new List<Motorcycle>();
            motorcycles.Add(yamaha);
            motorcycles.Add(harley);

            for(int i =0; i<=100; i++)
            {
                //testList.Add(i.ToString());
            }

            var test = motorcycles.Find(s => s.engine == "tiny");


            foreach(Motorcycle _m in motorcycles)
            {
                Console.WriteLine(_m.engine);
            }

            foreach (string _alpha in testList)
            {
                Console.WriteLine(_alpha);
            }

            }
    }
}
