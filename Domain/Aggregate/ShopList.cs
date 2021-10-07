using System.Collections.Generic;

namespace Domain.Aggregate
{
    public class ShopList
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Owner { get; set; }
        public decimal IdealValue { get; set; }
        public decimal MaxValue { get; set; }
        public virtual List<Product> Products { get; set; }


        public decimal CalculateTotalValue()
        {
            decimal totalValue = 0;
            if (Products != null)
            {
                foreach (var product in Products)
                {
                    if (product.Price > 0 && product.IsChecked)
                    {
                       totalValue += product.Price * product.Quantity;
                    }
                    else if (product.Price > 0)
                    {
                        totalValue -= product.Price;
                    }
                }
            }

            return totalValue;
        }
    }
}