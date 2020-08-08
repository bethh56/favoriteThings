using System;
using System.Collections.Generic;
using System.Text;

namespace favoriteThings.FavoriteThings
{
    class Coffee
    {
        public string Type { get; set; }

        public string CoffeeShop { get; set; }

        public bool _drinkIsWarm = true;

        public void CoffeeDrink()
        {
            if (_drinkIsWarm == false)
            {
                Console.WriteLine($"I also enjoy drinking {Type} from {CoffeeShop}.");
            } else
            {
                Console.WriteLine($"If it is cold outside, sometimes I will get {Type} from {CoffeeShop} instead");
            }
        }
    }

}
