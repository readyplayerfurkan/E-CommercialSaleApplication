namespace E_CommercialSaleApplication.States.Abstract;

public abstract class SaleState
{
    public abstract void AddToCart();
    public abstract void CheckStock(int productAmount);
    public abstract void EditCart(int newProductAmount);
    public abstract void PayForAllProducts(int customerBalance);
    public abstract void SendProducts();
}