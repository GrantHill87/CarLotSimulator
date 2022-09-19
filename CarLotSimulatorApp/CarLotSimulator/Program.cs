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
            Console.WriteLine($"Current number of vehicles created is; {CarLot.numberOfCars}."); //Car constructor has only been called once here.
            Console.WriteLine();
            var Vehicle2 = new Car(); //variation #2 of 4.
            Vehicle2.Make = "Honda";
            Vehicle2.Model = "HR-V";
            Vehicle2.Year = 2021;
            Vehicle2.EngineNoise = "Quiet";
            Vehicle2.HonkNoise = "Beep";
            Vehicle2.IsDriveable = true;
            Console.WriteLine($"Current number of vehicles created is; {CarLot.numberOfCars}."); //Now it has been called twice, but because of how I wrote this script, the manner in which this information is displayed is slightly difficult to decipher when the script is being run.
            Console.WriteLine();
            Car Vehicle3 = new Car() {Make = "Honda",  Model = "Pilot", Year = 2021, EngineNoise = "Loud", HonkNoise = "Gun Shot", IsDriveable = true}; //variation # 3 of 4. Object initializer syntax.
            Console.WriteLine($"Current number of vehicles created is; {CarLot.numberOfCars}."); //This is the third calling.
            Console.WriteLine();
            var Vehicle4 = new Car("Honda", "Accord", 2020, "Soft", "Horn", true); //variation #4 of 4. Couldn't get this one to work for some reason; Class it's based from isn't registering some of the properties.
            //update to the previous problem above (variation #4 of 4); I solved it! Figured it out; essentially when creating a construct that is syntaxed in this manner, it is critical that when building it within
            //its originating class, the class has to be defined in a particular way, whereby the class itself has a series of parameters assigned to it, thereby forcing the class itself,
            CarLot lot = new CarLot(); //when called as a constructor, to have the types of variables its paramters are calling for, passed through it. Yes, it's ineveitably a question of syntax,
            lot.CarList.Add(Vehicle1); //but it is also perhaps a matter of simplicity, in the sense that the fourth variation here (of the construct) was so basic with its format, that it required a little guidance
            lot.CarList.Add(Vehicle2); //from the class in which it was based from. Please refer to the newly written line of code in the Car class section for more information.
            lot.CarList.Add(Vehicle3);
            lot.CarList.Add(Vehicle4);

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
            Console.WriteLine();
            Console.WriteLine($"{Vehicle4.Make} {Vehicle4.Model}, {Vehicle4.Year}'s engine presumably sounds like:");
            Vehicle4.MakeEngineNoise();
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
            Console.WriteLine();
            Console.WriteLine($"{Vehicle4.Make} {Vehicle4.Model}, {Vehicle4.Year}'s honk presumably sounds like:");
            Vehicle4.MakeHonknoise();
            Console.WriteLine();
            //*************BONUS X 2*************//
            Console.WriteLine($"Current number of vehicles created is; {CarLot.numberOfCars}."); //everytime the constructor for a car is called for (created), the car counter should increment by a value 1.
            Console.WriteLine(); //for some reason, this fourth calling didn't register with the static field defined in the CarLot class. total count still suggests one car less than what the actual total is.
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
