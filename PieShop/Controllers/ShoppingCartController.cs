using Microsoft.AspNetCore.Mvc;
using PieShop.Models;

namespace PieShop.Controllers;

public class ShoppingCartController : Controller
{
    private readonly IPieRepository _pieRepository;
    private readonly ICategoryRepository _categoryRepository;


    public ShoppingCartController(IPieRepository pieRepository, ICategoryRepository categoryRepository)
    {
        _pieRepository = pieRepository;
        _categoryRepository = categoryRepository;
    }
}