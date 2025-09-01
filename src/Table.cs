using System.Collections.Generic;

namespace Ucu.Poo.Restaurant
{
    /// <summary>
    /// Representa una mesa en el restaurante.
    /// </summary>
    public class Table
    {
        private List<Dish> order = new List<Dish>();
        private int Number {get; set;}
        private bool IsOccupied {get; set;}

        public Table(int num)
        {
            Number = num;
            IsOccupied = false;
        }

        public void AddToOrder(Dish dish)
        {
            order.Add(dish);
        }
        
        
        public void Occupy()
        {
            IsOccupied = true;
        }
        
        public void Free()
        {
            IsOccupied = false;
            order.Clear();
        }
        
        public bool HasOrders()
        {
            bool resultado;
            if (order.Count == 0)
            {
                resultado = false;
                
                
            }
            else
            {
                resultado = true;
            }
            return resultado;
        }   
    }
}