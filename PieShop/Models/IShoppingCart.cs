namespace PieShop.Models;

public interface IShoppingCart
{
    void AddCart(Pie pie);
    int RemoveFromCart(Pie pie);
    List<ShoppingCartItem> GetShoppingCartItems();
    void ClearCart();
    decimal GetShoppingCartTotal();
    List<ShoppingCartItem> ShoppingCartItems { get; set; }
}