using System;
using System.Collections.Generic;
using System.Text;

namespace CarLotSimulator
{
    internal class Car
    {
        public Car()
        {
            CarLot.numberOfCars++; //Class name.Static Member++;
        }
        public Car(string make, string model, int year, string engineNoise, string honkNoise, bool isDriveable) //this line of code didn't exist before, when I first turned this assingment in.        {//I made a note to the course instructors that my fourth variation of construct calling for the properties of this already defined class wasn't functioning properly; this specific form
            Make = make; //of syntax was what I later suspected to be the culprit. Without the class being assigned with parameters that it calls for consequently in its scope, despite them
            Model = model; //being seemingly redundant to the same fields and properties already defined below this scope, the fourth construct car variant needed this 'guidance', from its originating class, in order to run.
            Year = year; //again, methods and classes written in this way will force the scope to pass whatever parameters were expressed within its parentheses. 
            EngineNoise = engineNoise;
            HonkNoise = honkNoise;
            IsDriveable = isDriveable;
        }


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
