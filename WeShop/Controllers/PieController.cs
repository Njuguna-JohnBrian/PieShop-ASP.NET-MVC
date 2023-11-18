using Microsoft.AspNetCore.Mvc;
using WeShop.Models;

namespace WeShop.Controllers;

public class PieController : Controller
{
    private readonly IPieRepository _pieRepository;
    private readonly ICategoryRepository _categoryRepository;

    public PieController(IPieRepository pieRepository, ICategoryRepository categoryRepository)
    {
        _pieRepository = pieRepository;
        _categoryRepository = categoryRepository;
    }

    public IActionResult List()
    {
        return View(_pieRepository.AllPies);
    }
}