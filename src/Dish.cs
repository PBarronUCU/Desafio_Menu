using System.Diagnostics;
using System.Security.Cryptography;

namespace Ucu.Poo.Restaurant
{

    /// <summary>
    /// Representa un platillo individual en el menú del restaurante.
    /// </summary>
    public class Dish
    {
        public string Name;
        public double Price;
        public bool Isvegetarian;

        public Dish(string name, double price, bool isvegetarian)
        {
            Name = name;
            Price = price;
            Isvegetarian = isvegetarian;
            
        }
    }
}