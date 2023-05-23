namespace OnlineOrdering
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Order> orders = new();

            Address addy1 = new("123 Easy Street", "Sunnyville", "CA", "USA");
            Customer cust1 = new("Jackson Harris", addy1);
            Order order1 = new(cust1);
            order1.AddProduct(new Product("Stapler", 10.50, 3));
            order1.AddProduct(new Product("Binder", 2.99, 5));
            order1.AddProduct(new Product("Pen", .99, 2));
            orders.Add(order1);

            Address addy2 = new("ABC Main Street", "Copenhagen", "Sjaeland", "DK");
            Customer cust2 = new("Hans Andersen", addy2);
            Order order2 = new(cust2);
            order2.AddProduct(new Product("Printer", 110.89, 2));
            order2.AddProduct(new Product("Scanner", 75.50, 1));
            order2.AddProduct(new Product("Shredder", 20.99, 2));
            orders.Add(order2);

            foreach (Order order in orders)
            {
                order.DisplayPackingLabel();
                order.DisplayShippingLabel();
                order.DisplayTotalCost();
            }
        }
    }

}
