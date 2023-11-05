using E_CommercialSaleApplication.Context;

namespace E_CommercialSaleApplication
{
    class Program
    {
        static void Main()
        {
            SaleApplication saleApp = new();

            Console.WriteLine("--Stoğun yetersiz olduğu senaryo--");
            saleApp.AddToCart();
            saleApp.CheckStock(300);
            saleApp.EditCart(200);
            saleApp.PayForAllProducts(200);
            saleApp.SendProducts();
            Console.WriteLine("*******");
            Console.WriteLine("");
            
            Console.WriteLine("--Bakiyenin yetersiz olduğu senaryo--");
            saleApp.AddToCart();
            saleApp.CheckStock(150);
            saleApp.PayForAllProducts(100);
            saleApp.EditCart(100);
            saleApp.PayForAllProducts(100);
            saleApp.SendProducts();
            Console.WriteLine("****************");
            Console.WriteLine("");
        }
    }
}