using System;
using System.Collections.Generic;
using System.Text;

namespace favoriteThings.FavoriteThings
{
    class Baking
    {
        public PieFlavor typeOfPie { get; set; }

        public bool _LatticeCrust = true;

        public bool _isWarm = true;

        public bool _isMade = true;

        public void PieTypes()
        {
            Console.WriteLine("Another thing I enjoy to do is bake. Let's see what is made!");
            if (_isMade)
            {
                if (_isWarm && _LatticeCrust)
                {
                    Console.WriteLine($"The best way to serve {typeOfPie} pie is warm and with lattice crust.");
                } else
                {
                    Console.WriteLine($"The best way to serve {typeOfPie} pie is after it has been in the fridge for awhile.");
                }
            } else
            {
                Console.WriteLine("I have not made a pie yet!");
            }
          
        }


    }

    enum PieFlavor
    {
        Apple,
        Blueberry,
        Strawberry,
        Pumpkin,
    }
}
