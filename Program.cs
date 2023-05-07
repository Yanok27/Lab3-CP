using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LAB3_CP_.Models;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using LAB3_CP_.Data;
using LAB3_CP_.Factories.Abstract;

namespace LAB3_CP_
{
    public class Program
    {
        static void Main(string[] args)
        {
            var memoryFinder = new FindMemory();
            var foundMemory1 = memoryFinder.Find("Kingston HyperX", "RAM001", 500);
            Console.WriteLine(foundMemory1.GetInfo());
            var hardDriveFinder = new FindHardDrive();
            Console.WriteLine(hardDriveFinder.Find("Seagate Barracuda", "HD001", 1500));
        }
    }
    
}