using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VeloOnline.Models
{
    public class Cart
    {
        private List<CartLine> lineCollection = new List<CartLine>();

        public void AddItem(Bike bike, int quantity)
        {
            CartLine line = lineCollection
                            .FirstOrDefault(x => x.Bike.BikeId == bike.BikeId);
            if (line == null)
            {
                lineCollection.Add(new CartLine
                {
                    Bike = bike,
                    Quantity = quantity
                });

            }
            else
            {
                line.Quantity += quantity;
            }
        }

        public void RemoveItem(Bike bike, int quantity)
        {
            CartLine line = lineCollection
                            .FirstOrDefault(x => x.Bike.BikeId == bike.BikeId);
            if (line != null && --line.Quantity == 0)
            {
                line.Quantity = 0;
            }
        }

        public decimal ComputeTotalValue()
        {
            return lineCollection.Sum(x => x.Bike.Price * x.Quantity);
        }

        public void RemoveLine(Bike bike)
        {
            lineCollection.RemoveAll(x => x.Bike.BikeId == bike.BikeId);
        }
        public void Clear()
        {
            lineCollection.Clear();
        }
        public IEnumerable<CartLine> Lines => lineCollection;
    }


    public class CartLine
    {
        public Bike Bike { get; set; }
        public int Quantity { get; set; }
    }
}
