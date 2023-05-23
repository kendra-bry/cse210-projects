namespace OnlineOrdering
{
    public class Product
    {
        private string _name;
        private string _id;
        private double _price;
        private int _quantity;

        public Product(string name, double price, int quantity)
        {
            _name = name;
            _id = Convert.ToBase64String(Guid.NewGuid().ToByteArray()); ;
            _price = price;
            _quantity = quantity;
        }

        public string GetProductInfo()
        {
            return $"Product: {_name}\nId: {_id}\n";
        }

        public double CalculatePrice()
        {
            return _price * _quantity;
        }
    }
}