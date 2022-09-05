using System;
using System.Collections.Generic;
using System.Text;

namespace CarLotSimulator
{
    internal class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string EngineNoise { get; set; }
        public string HonkNoise { get; set; }
        public bool IsDriveable { get; set; }


        public void MakeEngineNoise()
        {
            Console.WriteLine($"{EngineNoise}.");
        }
        public void MakeHonknoise()
        {
            Console.WriteLine($"{HonkNoise}.");
        }
    }
}
