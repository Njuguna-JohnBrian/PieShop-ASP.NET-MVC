namespace PieShop.Models;

public class ShoppingCartItem
{
    public int ShoppingCartItemId { get; set; }
    public Pie Pie { get; set; } = default!;
    public string? ShoppingCartId { get; set; }
}