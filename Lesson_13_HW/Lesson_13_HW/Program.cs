using static Lesson_13_HW.Program;

namespace Lesson_13_HW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customerInfo = new Customer { CustomerFullName = "Tommy Kotik", CustomerAge = 22, CustomerEmail = "Kotic@gml.com", 
            CustomerPhoneNumber = "+380(099)314221578", CustomerAddres = "Some Adress", CustomerCity = "Construct City" };
            customerInfo.PrintCustomerInfo();

            Seller sellerInfo = new Seller { SellerFullName = "Asterix Rudawski", SellerAge = 36,
            SellerEmail = "Asterix.Rudawski@gml.com", SellerPhone = "+380(099)751498637", SellerCompanyName = "Asterix's Electro - Shop"};
            sellerInfo.PrintSellerInfo();

            Order orderInfo = new Order { OrderId = 14233, OrderName = "New Nvidia RTX 4090", CustomerName = "Tommy Kotik", orderTime = DateTime.Now.AddMinutes(2)};
            orderInfo.OrderInfo(orderInfo.OrderId, orderInfo.OrderName, orderInfo.CustomerName, orderInfo.orderTime);

            ItemsForSale ItemsforSale = new ItemsForSale { ItemsName = "\n Videocards\n Motherboards\n Processors\n Processors\n Power Supply\n Phones\n" };
            ItemsforSale.forSale();

        }

        public struct Customer
        {
            public string CustomerFullName;
            public int CustomerAge;
            public string CustomerPhoneNumber;
            public string CustomerEmail;
            public string CustomerCity;
            public string CustomerAddres;

            public void PrintCustomerInfo()
            {
                Console.WriteLine($"About You!\n Your Full Name: {CustomerFullName}\n Your Age: {CustomerAge}\n Your Phone Number: {CustomerPhoneNumber}\n " +
                    $"Your Email: {CustomerEmail}\n Your City: \"{CustomerCity}\" and Adress: \"{CustomerAddres}\"\n");
            }
        }

        public struct Seller
        {
            public string SellerFullName;
            public int SellerAge;
            public string SellerPhone;
            public string SellerEmail;
            public string SellerCompanyName;

            public void PrintSellerInfo()
            {
                Console.WriteLine($"About Our Seller!\n Seller Full Name: {SellerFullName}\n Seller Age: {SellerAge}\n " +
                    $"Seller Phone: {SellerPhone}\n Seller Email: {SellerEmail}\n Seller's Company Name: \"{SellerCompanyName}\"\n");
            }
        }

        public record Order
        {
            public int OrderId;
            public string OrderName;
            public DateTime orderTime;
            public string CustomerName;

            public void OrderInfo(int orderId, string orderName, string customerName, DateTime orderTime)
            {
                Console.WriteLine($"About \"{customerName}\" Order:\n Order Id: {orderId}\n About Order: \"{orderName}\" is on the way and you'll be able to get your order in this day: {orderTime}\n");
            }

        }

        public record ItemsForSale
        {
            public string ItemsName;
            public void Items(string itemsName) => ItemsName = itemsName;
            public void forSale() => Console.WriteLine($"Check out our items!\n Our Items: {ItemsName}");
        }

    }
}