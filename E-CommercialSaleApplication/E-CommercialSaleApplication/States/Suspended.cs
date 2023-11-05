using E_CommercialSaleApplication.Context;
using E_CommercialSaleApplication.States.Abstract;

namespace E_CommercialSaleApplication.States;

public class Suspended : SaleState
{
    private SaleApplication _context;

    public Suspended(SaleApplication context)
        => _context = context;
    
    public override void AddToCart()
        => Console.WriteLine("Ürün zaten sepete eklenmiştir.");

    public override void CheckStock(int productAmount)
    {
        _context.ProductAmount = productAmount;
        
        if (_context.ProductStock > _context.ProductAmount)
        {
            Console.WriteLine("Ürün stoğu mevcuttur. Ödeme adımına geçiliyor.");
            _context.ProductStock -= productAmount;
            _context.SetStockReserved();   
        }
        else
        {
            Console.WriteLine("Ürün stoğu almak istediğiniz miktarın altında kalıyor. Lütfen stoğu güncelleyin.");
            _context.SetOrderFailed();
        }
    }

    public override void EditCart(int newProductAmount)
        => Console.WriteLine("Ürün stoğu kontrol ediliyor.");

    public override void PayForAllProducts(int customerBalance)
        => Console.WriteLine("Ürün stoğu kontrol ediliyor.");


    public override void SendProducts()
        => Console.WriteLine("Ürün stoğu kontrol ediliyor.");
}