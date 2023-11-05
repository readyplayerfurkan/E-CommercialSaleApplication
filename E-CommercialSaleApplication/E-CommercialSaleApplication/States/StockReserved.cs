using E_CommercialSaleApplication.Context;
using E_CommercialSaleApplication.States.Abstract;

namespace E_CommercialSaleApplication.States;

public class StockReserved : SaleState
{
    private SaleApplication _context;
    public StockReserved(SaleApplication context)
        => _context = context;
    
    public override void AddToCart()
        => Console.WriteLine("Bu adımda ürün ekleyemezsiniz.");

    public override void CheckStock(int productAmount)
        => Console.WriteLine("Stok zaten kontrol edilmiştir.");

    public override void EditCart(int newProductAmount)
        => Console.WriteLine("Bu adımda sepeti güncelleyemezsiniz.");

    public override void PayForAllProducts(int customerBalance)
    {
        if (customerBalance > (_context.ProductAmount * _context.ProductPrice))
        {
            Console.WriteLine("Ödeme başaralı bir şekilde gerçekleşmiştir.");
            _context.SetOrderCompleted();
        }
        else
        {
            Console.WriteLine("Bakiyeniz yetersizdir. Lütfen ürün miktarını güncelleyiniz");
            _context.SetOrderFailed();
        }
    }

    public override void SendProducts()
        => Console.WriteLine("Ödeme adımının tamamlanmasını bekleyin.");
}