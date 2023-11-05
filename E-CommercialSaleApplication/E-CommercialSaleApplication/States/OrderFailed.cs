using E_CommercialSaleApplication.Context;
using E_CommercialSaleApplication.States.Abstract;

namespace E_CommercialSaleApplication.States;

public class OrderFailed : SaleState
{
    private SaleApplication _context;
    public OrderFailed(SaleApplication context)
        => _context = context;
    
    public override void AddToCart()
        => Console.WriteLine("Bu adımda ürün ekleyemezsiniz.");

    public override void CheckStock(int productAmount)
        => Console.WriteLine("Ürün stoğu zaten kontrol edilmiştir.");

    public override void EditCart(int newProductAmount)
    {
        _context.ProductAmount = newProductAmount;
        Console.WriteLine("Ürün miktarı güncellenmiştir. Ödeme adımına geçiliyor.");
        _context.SetStockReserved();
    }

    public override void PayForAllProducts(int customerBalance)
        => Console.WriteLine("Bu adımda ödeme yapamazsınız.");

    public override void SendProducts()
        => Console.WriteLine("Bu adımda gönderim yapamazsınız.");
}