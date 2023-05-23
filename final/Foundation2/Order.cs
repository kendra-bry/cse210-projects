namespace OnlineOrdering
{
    public class Order
    {
        private List<Product> _products;
        private Customer _customer;

        public Order(Customer customer)
        {
            _customer = customer;
            _products = new List<Product>();
        }

        public Customer GetCustomer()
        {
            return _customer;
        }

        public void AddProduct(Product product)
        {
            _products.Add(product);
        }

        public void DisplayTotalCost()
        {
            double total = 0;
            foreach (Product product in _products)
            {
                total += product.CalculatePrice();
            }

            total += CalculateShippingCost();

            Console.WriteLine($"\nOrder Total: ${total}\n");
        }

        public void DisplayPackingLabel()
        {
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("\t    Packing Label\n");
            foreach (Product product in _products)
            {
                Console.WriteLine(product.GetProductInfo());
            }
            Console.WriteLine("-------------------------------------");
        }

        public void DisplayShippingLabel()
        {
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("\t    Shipping Label\n");
            Console.WriteLine($"Customer: {_customer.GetName()}");
            Console.WriteLine($"{_customer.GetAddress().GetAddressString()}");
            Console.WriteLine("-------------------------------------");
        }

        private int CalculateShippingCost()
        {
            int shippingCost;

            if (GetCustomer().GetAddress().IsLocatedInUSA())
            {
                shippingCost = 5;
            }
            else
            {
                shippingCost = 35;
            }

            return shippingCost;
        }
    }
}