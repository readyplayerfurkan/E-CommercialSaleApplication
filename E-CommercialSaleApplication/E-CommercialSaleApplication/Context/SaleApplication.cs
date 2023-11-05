using E_CommercialSaleApplication.States;
using E_CommercialSaleApplication.States.Abstract;

namespace E_CommercialSaleApplication.Context;

public class SaleApplication
{
    private SaleState noOrder;
    private SaleState suspended;
    private SaleState stockReserved;
    private SaleState orderCanceled;
    private SaleState orderFailed;
    private SaleState orderCompleted;

    private SaleState state;

    public SaleApplication()
    {
        noOrder = new NoOrder(this);
        suspended = new Suspended(this);
        stockReserved = new StockReserved(this);
        orderCanceled = new OrderCancelled(this);
        orderFailed = new OrderFailed(this);
        orderCompleted = new OrderCompleted(this);

        state = noOrder;
    }

    public int ProductStock { get; set; } = 200;
    public int ProductAmount { get; set; } = 0;
    public int ProductPrice { get; set; } = 1;

    #region ChangeStageMethods
    
    public void SetNoOrder()
        => state = noOrder;
    public void SetSuspended()
        => state = suspended;
    public void SetStockReserved()
        => state = stockReserved;
    public void SetOrderCanceled()
        => state = orderCanceled;
    public void SetOrderFailed()
        => state = orderFailed;
    public void SetOrderCompleted()
        => state = orderCompleted;

    #endregion

    #region MethodsForStages

    public void AddToCart()
        => state.AddToCart();
    public void CheckStock(int productAmount)
        => state.CheckStock(productAmount);
    public void EditCart(int newProductAmount)
        => state.EditCart(newProductAmount);
    public void PayForAllProducts(int productPrice)
        => state.PayForAllProducts(productPrice);
    public void SendProducts()
        => state.SendProducts();

    #endregion
}