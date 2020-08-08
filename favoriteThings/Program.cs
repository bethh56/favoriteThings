using favoriteThings.FavoriteThings;
using System;

namespace favoriteThings
{
    class Program
    {
        static void Main(string[] args)
        {
         
            var animal = new Animals("dog", "Boomer");

            var pie = new Baking()
            {
                _isMade = true,
                _isWarm = true,
                _LatticeCrust = true,
                typeOfPie = PieFlavor.Apple
            };

            pie.PieTypes();


            var coffee = new Coffee()
            {
                _drinkIsWarm = false,
                Type = "Cold Brew",
                CoffeeShop = "Frothy Monkey"
            };

            var coldDayCoffee = new Coffee()
            {
                _drinkIsWarm = true,
                Type = "Cortado",
                CoffeeShop = "Fido"
            };

            coffee.CoffeeDrink();
            coldDayCoffee.CoffeeDrink();

            var music = new Music()
            {
                MusicGenre = Genre.Rock,
                Album = "Born and Raised",
                Artist = "John Mayer"
            };

            music.ListeningTo();
        }
        
    }
}
