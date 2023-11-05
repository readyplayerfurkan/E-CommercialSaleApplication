using E_CommercialSaleApplication.Context;
using E_CommercialSaleApplication.States.Abstract;

namespace E_CommercialSaleApplication.States;

public class OrderCancelled : SaleState
{
    private SaleApplication _context;
    public OrderCancelled(SaleApplication context)
        => _context = context;
    
    public override void AddToCart()
        => Console.WriteLine("Bu adımda ürün ekleyemezsiniz.");

    public override void CheckStock(int productAmount)
        => Console.WriteLine("Lütfen adet miktarını güncelleyin");

    public override void EditCart(int newProductAmount)
    {
        _context.ProductAmount = newProductAmount;
        _context.SetSuspended();
        _context.CheckStock(_context.ProductAmount);
    }

    public override void PayForAllProducts(int customerBalance)
        => Console.WriteLine("Bu adımda ödeme yapamazsınız.");

    public override void SendProducts()
        => Console.WriteLine("Lütfen stoğun güncellemesini bekleyin.");
}