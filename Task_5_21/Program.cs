using System;
using System.Collections.Generic;
using Task_5_21;

class Program
{

    static void Main(string[] args)
    {
        List<Guitar> instruments = new List<Guitar>();

        ElectricGuitar stratocaster = new ElectricGuitar()
        {
            Name = "Stratocaster",
            NumberOfStrings = 6,
            Material = "Alder",
            NumberOfPickups = 3,
            HasWhammyBar = true
        };

        ElectricGuitar lesPaul = new ElectricGuitar()
        {
            Name = "Les Paul",
            NumberOfStrings = 6,
            Material = "Mahogany",
            NumberOfPickups = 2,
            HasWhammyBar = false
        };

        instruments.Add(stratocaster);
        instruments.Add(lesPaul);

        foreach (var instrument in instruments)
        {

            Console.WriteLine(instrument.Info());
            Console.WriteLine(instrument.Play());
            if (instrument is Guitar)
            {
                Guitar guitar = (Guitar)instrument;
                Console.WriteLine("\t{0}", guitar.ChangeStrings());
                Console.WriteLine("\t{0}", guitar.AdjustAction());
                if (instrument is ElectricGuitar)
                {
                    ElectricGuitar electricGuitar = (ElectricGuitar)instrument;
                    Console.WriteLine("\t\t{0}", electricGuitar.TogglePickup(2, true));
                    Console.WriteLine("\t\t{0}", electricGuitar.AddEffects("distortion"));
                }
            }
            Console.WriteLine();
        }

        //Console.ReadKey();
    }
}