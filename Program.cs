using System;


namespace Ex_Proposto{
    class Program
    {
        static void Main(string[] args)
        {

            System.Console.WriteLine("Enter client data: ");
            System.Console.WriteLine("Name: ");
            string name = Console.ReadLine();
            System.Console.WriteLine("Email: ");
            string email = Console.ReadLine();
            System.Console.WriteLine("Birth date (DD/MM/YYYY): ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());

            Client client = new Client(name, email, birthDate);
            System.Console.WriteLine("Enter Order data: ");
            System.Console.WriteLine("Status:");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());
            Order order = new Order(DateTime.Now, status, client);

            System.Console.WriteLine("How many items to this order? :");
            int Counter = int.Parse(Console.ReadLine());


            for(int i = 0; i < Counter; i++)
            {
                System.Console.WriteLine($"Enter #{i + 1} item data:");
                System.Console.WriteLine($"Product name:");
                string Pname = Console.ReadLine();
                System.Console.WriteLine($"Product price:");
                double price = double.Parse(Console.ReadLine());

                System.Console.WriteLine($"Quantity:");
                int quantity = int.Parse(Console.ReadLine()); 
                Product product = new Product(Pname, price);
                OrderItem orderItem = new OrderItem(quantity, price, product);

                order.AddItem(orderItem);

            }

            Console.WriteLine();
            Console.WriteLine("ORDER SUMMARY:");
            Console.WriteLine(order);

        }
    }
}