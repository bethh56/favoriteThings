using System;
using System.Collections.Generic;
using System.Text;

namespace favoriteThings.FavoriteThings
{
    class Animals
    {
        public string AnimalType { get; set;}

        public string Name { get; set; }

        public Animals(string typeOfAnimal, string name)
        {
            AnimalType = typeOfAnimal;
            Name = name;
            Console.WriteLine($"One of my favorite things is {name}, my {typeOfAnimal}.");
        }

    }
}
