using E_CommercialSaleApplication.Context;
using E_CommercialSaleApplication.States.Abstract;

namespace E_CommercialSaleApplication.States;

public class OrderCompleted : SaleState
{
    private SaleApplication _context;
    public OrderCompleted(SaleApplication context)
        => _context = context;
    
    public override void AddToCart()
        => Console.WriteLine("Bu adımda ürün ekleyemezsiniz.");

    public override void CheckStock(int productAmount)
        => Console.WriteLine("Ürün stoğu zaten kontrol edilmiştir.");

    public override void EditCart(int newProductAmount)
        => Console.WriteLine("Bu adımda sepeti güncelleyemezsiniz");

    public override void PayForAllProducts(int customerBalance)
        => Console.WriteLine("Ödeme zaten yapıldı.");
    
    public override void SendProducts()
    {
        Console.WriteLine("Ürünler başarılı bir şekilde kargolanmıştır.");
        _context.SetNoOrder();    
    }
}