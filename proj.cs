



namespace OnlineBookingApp.Models
{
    public class Product
    {
        public string Name { get; private set; }
        public string Code { get; private set; }
        public int Quantity { get; private set; }
        public decimal Price { get; private set; }
        public decimal Cost => Quantity * Price;

        public Product(string name, string code, int quantity, decimal price)
        {
            Name = name;
            Code = code;
            Quantity = quantity;
            Price = price;
        }
    }
}






namespace OnlineBookingApp.Models
{
    public abstract class Discount
    {
        public abstract bool IsApplicable(DateTime orderDate, List<Product> products);
        public abstract decimal CalculateDiscount(decimal totalCost);
    }
}







namespace OnlineBookingApp.Models
{
    public class PromotionDiscount : Discount
    {
        public override bool IsApplicable(DateTime orderDate, List<Product> products)
        {
            DateTime promotionStart = new DateTime(orderDate.Year, 9, 12, 0, 0, 0);
            DateTime promotionEnd = promotionStart.AddMinutes(256);
            return orderDate >= promotionStart && orderDate <= promotionEnd && products.Count >= 2;
        }

        public override decimal CalculateDiscount(decimal totalCost)
        {
            return totalCost * 0.08m;
        }
    }
}



namespace OnlineBookingApp.Models
{
    public class OnlineBooking
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string PersonalNumber { get; private set; }
        public List<Product> Products { get; private set; }
        public DateTime OrderDate { get; private set; }
        private Discount DiscountPolicy { get; set; }

        public OnlineBooking(string firstName, string lastName, string personalNumber, List<Product> products, DateTime orderDate, Discount discountPolicy)
        {
            FirstName = firstName;
            LastName = lastName;
            PersonalNumber = personalNumber;
            Products = products;
            OrderDate = orderDate;
            DiscountPolicy = discountPolicy;
        }

        public void ApplyDiscount()
        {
            if (DiscountPolicy.IsApplicable(OrderDate, Products))
            {
                Console.WriteLine("Promotion applied:");
                decimal totalCost = 0;
                foreach (var product in Products)
                {
                    totalCost += product.Cost;
                }
                decimal discount = DiscountPolicy.CalculateDiscount(totalCost);
                decimal discountedTotal = totalCost - discount;

                Console.WriteLine($"Customer: {FirstName} {LastName}, Personal Number: {PersonalNumber}");
                Console.WriteLine("Products:");
                foreach (var product in Products)
                {
                    Console.WriteLine($" - {product.Name} (Code: {product.Code}, Quantity: {product.Quantity}, Price: {product.Price}, Cost: {product.Cost})");
                }
                Console.WriteLine($"Order Date: {OrderDate}");
                Console.WriteLine($"Total Cost: {totalCost}");
                Console.WriteLine($"Discount: {discount}");
                Console.WriteLine($"Total after Discount: {discountedTotal}");
            }
            else
            {
                Console.WriteLine($"Customer: {FirstName} {LastName}, Personal Number: {PersonalNumber}");
                Console.WriteLine("Products:");
                foreach (var product in Products)
                {
                    Console.WriteLine($" - {product.Name} (Code: {product.Code}, Quantity: {product.Quantity}, Price: {product.Price}, Cost: {product.Cost})");
                }
                Console.WriteLine($"Order Date: {OrderDate}");
                Console.WriteLine("No promotion applied.");
            }
        }
    }
}






namespace OnlineBookingApp.Models
{
    public class OnlineBooking
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string PersonalNumber { get; private set; }
        public List<Product> Products { get; private set; }
        public DateTime OrderDate { get; private set; }
        private Discount DiscountPolicy { get; set; }

        public OnlineBooking(string firstName, string lastName, string personalNumber, List<Product> products, DateTime orderDate, Discount discountPolicy)
        {
            FirstName = firstName;
            LastName = lastName;
            PersonalNumber = personalNumber;
            Products = products;
            OrderDate = orderDate;
            DiscountPolicy = discountPolicy;
        }

        public void ApplyDiscount()
        {
            if (DiscountPolicy.IsApplicable(OrderDate, Products))
            {
                Console.WriteLine("Promotion applied:");
                decimal totalCost = 0;
                foreach (var product in Products)
                {
                    totalCost += product.Cost;
                }
                decimal discount = DiscountPolicy.CalculateDiscount(totalCost);
                decimal discountedTotal = totalCost - discount;

                Console.WriteLine($"Customer: {FirstName} {LastName}, Personal Number: {PersonalNumber}");
                Console.WriteLine("Products:");
                foreach (var product in Products)
                {
                    Console.WriteLine($" - {product.Name} (Code: {product.Code}, Quantity: {product.Quantity}, Price: {product.Price}, Cost: {product.Cost})");
                }
                Console.WriteLine($"Order Date: {OrderDate}");
                Console.WriteLine($"Total Cost: {totalCost}");
                Console.WriteLine($"Discount: {discount}");
                Console.WriteLine($"Total after Discount: {discountedTotal}");
            }
            else
            {
                Console.WriteLine($"Customer: {FirstName} {LastName}, Personal Number: {PersonalNumber}");
                Console.WriteLine("Products:");
                foreach (var product in Products)
                {
                    Console.WriteLine($" - {product.Name} (Code: {product.Code}, Quantity: {product.Quantity}, Price: {product.Price}, Cost: {product.Cost})");
                }
                Console.WriteLine($"Order Date: {OrderDate}");
                Console.WriteLine("No promotion applied.");
            }
        }
    }
}







