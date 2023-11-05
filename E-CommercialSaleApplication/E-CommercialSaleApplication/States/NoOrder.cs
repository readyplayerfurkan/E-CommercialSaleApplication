using E_CommercialSaleApplication.Context;
using E_CommercialSaleApplication.States.Abstract;

namespace E_CommercialSaleApplication.States;

public class NoOrder : SaleState
{
    private SaleApplication _context;
    public NoOrder(SaleApplication context)
        => _context = context;
    
    public override void AddToCart()
    {
        Console.WriteLine("Ürününüz sepete eklenmiştir.");    
        _context.SetSuspended();
    }

    public override void CheckStock(int productAmount)
        => Console.WriteLine("Lütfen sepete bir ürün ekleyeniz.");

    public override void EditCart(int newProductAmount)
        => Console.WriteLine("Lütfen sepete bir ürün ekleyeniz.");

    public override void PayForAllProducts(int customerBalance)
        => Console.WriteLine("Lütfen sepete bir ürün ekleyeniz.");

    public override void SendProducts()
        => Console.WriteLine("Lütfen sepete bir ürün ekleyeniz.");
}