using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car

            Car Vehicle1 = new Car(); //variation #1 of 4. Standard member initializiation.
            Vehicle1.Make = "Honda";
            Vehicle1.Model = "CR-V";
            Vehicle1.Year = 2021;
            Vehicle1.EngineNoise = "Calm";
            Vehicle1.HonkNoise = "Honk";
            Vehicle1.IsDriveable = true;

            var Vehicle2 = new Car(); //variation #2 of 4.
            Vehicle2.Make = "Honda";
            Vehicle2.Model = "HR-V";
            Vehicle2.Year = 2021;
            Vehicle2.EngineNoise = "Quiet";
            Vehicle2.HonkNoise = "Beep";
            Vehicle2.IsDriveable = true;

            Car Vehicle3 = new Car() {Make = "Honda",  Model = "Pilot", Year = 2021, EngineNoise = "Loud", HonkNoise = "Gun Shot", IsDriveable = true}; //variation # 3 of 4. Object initializer syntax.

            // var Vehicle4 = new Car("Honda", "Accord", 2020, "Soft", "Horn", true); variation #4 of 4. Couldn't get this one to work for some reason; Class it's based from isn't registering some of the properties.

            CarLot lot = new CarLot();
            lot.CarList.Add(Vehicle1);
            lot.CarList.Add(Vehicle2);
            lot.CarList.Add(Vehicle3);
            // lot.CarList.Add(Vehicle4);

            //*************BONUS*************//
            Console.WriteLine("A forked car lot simulator program.");

            // Set the properties utilizing the 3 different ways we learned about, one way for each car
            Console.WriteLine();
            Console.WriteLine("Auto vehicle Engine Expression.");
            Console.WriteLine();
            Console.WriteLine($"{Vehicle1.Make} {Vehicle1.Model}, {Vehicle1.Year}'s engine presumably sounds like:");
            Vehicle1.MakeEngineNoise();
            Console.WriteLine();
            Console.WriteLine($"{Vehicle2.Make} {Vehicle2.Model}, {Vehicle2.Year}'s engine presumably sounds like:");
            Vehicle2.MakeEngineNoise();
            Console.WriteLine();
            Console.WriteLine($"{Vehicle3.Make} {Vehicle3.Model}, {Vehicle3.Year}'s engine presumably sounds like:");
            Vehicle3.MakeEngineNoise();
            // Vehicle4.MakeEngineNoise();
            Console.WriteLine();
            Console.WriteLine("Auto vehicle Honk expression.");
            Console.WriteLine();
            Console.WriteLine($"{Vehicle1.Make} {Vehicle1.Model}, {Vehicle1.Year}'s honk presumably sounds like:");
            Vehicle1.MakeHonknoise();
            Console.WriteLine();
            Console.WriteLine($"{Vehicle2.Make} {Vehicle2.Model}, {Vehicle2.Year}'s honk presumably sounds like:");
            Vehicle2.MakeHonknoise();
            Console.WriteLine();
            Console.WriteLine($"{Vehicle3.Make} {Vehicle3.Model}, {Vehicle3.Year}'s honk presumably sounds like:");
            Vehicle3.MakeHonknoise();
            // Vehicle4.MakeHonknoise();
            Console.WriteLine();
            //*************BONUS X 2*************//
            foreach (var car in lot.CarList)
            {
                Console.WriteLine("A bit more redundancy. Practice makes perfect.");
                Console.WriteLine();
                Console.WriteLine($"{car.Make}, {car.Model}, {car.Year}. How's the engine sound? {car.EngineNoise}. How does it honk? {car.HonkNoise}. Is it driveable? {car.IsDriveable}.");
                Console.WriteLine();
            }
            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
        }
    }
}
