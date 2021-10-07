namespace Domain.Aggregate
{
    public class Product
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public int Quantity { get; set; }

        public int ShopListID { get; set; }

        public virtual ShopList ShopList { get; set; }

        public bool IsChecked { get; set; }
    }
}