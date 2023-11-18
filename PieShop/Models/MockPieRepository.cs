namespace PieShop.Models;

public class MockPieRepository : IPieRepository
{
    private readonly ICategoryRepository _categoryRepository = new MockCategoryRepository();


    public IEnumerable<Pie> AllPies => new List<Pie>
    {
        new()
        {
            PieId = 1, Name = "Strawberry Pie", Price = 15.95M, ShortDescription = "Delicious Indulgence",
            LongDescription =
                "Indulge in the sweet symphony of summer with our luscious Strawberry Pie, a delightful confluence of ripe, juicy strawberries nestled in a golden, flaky crust. " +
                "Savor the season with each bite, as this delectable treat captures the essence of sun-kissed berries in every mouthwatering slice.",
            Category = _categoryRepository.AllCategories.ToList()[0],
            ImageUrl =
                "https://res.cloudinary.com/duaeqqpu7/image/upload/v1700223517/BethanyPieShop/hm0gxbtxxby1n5uaedxo.jpg",
            IsPieOfTheWeek = false,
            ImageThumbnailUrl =
                "https://res.cloudinary.com/duaeqqpu7/image/upload/v1700223470/BethanyPieShop/pb7mkyxsduvgmimvoqwn.jpg"
        },
        new()
        {
            PieId = 2, Name = "Key Lime Pie", Price = 14.95M, ShortDescription = "Tangy Bliss",
            LongDescription =
                ": Experience a burst of citrusy delight with our Key Lime Pie. Each velvety bite is a zesty celebration, a" +
                "s the smooth lime filling harmonizes with a buttery graham cracker crust. It's a refreshing treat for every palate.",
            Category = _categoryRepository.AllCategories.ToList()[1],
            ImageUrl =
                "https://res.cloudinary.com/duaeqqpu7/image/upload/v1700224289/BethanyPieShop/adnnx6jowg2uxphdlf9b.jpg",
            IsPieOfTheWeek = false,
            ImageThumbnailUrl =
                "https://res.cloudinary.com/duaeqqpu7/image/upload/v1700224287/BethanyPieShop/fljrskoom4fujjij3lwe.jpg"
        },
        new()
        {
            PieId = 3, Name = "Apple Caramel Pie", Price = 16.50M, ShortDescription = "Sweet Elegance",
            LongDescription =
                "Fall in love with the divine combination of crisp apples and rich caramel in our Apple Caramel Pie. " +
                "The layers of sweetness are encased in a flaky pastry, creating a symphony of flavors that will leave you craving more.",
            Category = _categoryRepository.AllCategories.ToList()[0],
            ImageUrl =
                "https://res.cloudinary.com/duaeqqpu7/image/upload/v1700224547/BethanyPieShop/z1moclx58ppfqtxw2wtb.jpg",
            IsPieOfTheWeek = false,
            ImageThumbnailUrl =
                "https://res.cloudinary.com/duaeqqpu7/image/upload/v1700224545/BethanyPieShop/d6bopbtu5ps4680prf0j.jpg"
        },
        new()
        {
            PieId = 4, Name = "Chocolate Pecan Pie", Price = 17.95M, ShortDescription = "Decadent Delight",
            LongDescription =
                "Indulge in the ultimate chocolate experience with our Chocolate Pecan Pie. Velvety chocolate meets the crunch of pecans, nestled in a buttery crust. " +
                "It's a luxurious treat for chocolate enthusiasts.",
            Category = _categoryRepository.AllCategories.ToList()[1],
            ImageUrl =
                "https://res.cloudinary.com/duaeqqpu7/image/upload/v1700224712/BethanyPieShop/x4dpj1fdo65drmhc3nkw.jpg",
            IsPieOfTheWeek = true,
            ImageThumbnailUrl =
                "https://res.cloudinary.com/duaeqqpu7/image/upload/v1700224771/BethanyPieShop/rkkw5xullwbwualguwmd.jpg"
        },
        new()
        {
            PieId = 5, Name = "Blueberry Cheesecake Pie", Price = 18.99M, ShortDescription = "Creamy Perfection",
            LongDescription =
                "Elevate your dessert experience with our Blueberry Cheesecake Pie. " +
                "A velvety layer of cream cheese meets a burst of juicy blueberries, creating a heavenly fusion that will tantalize your taste buds",
            Category = _categoryRepository.AllCategories.ToList()[2],
            ImageUrl =
                "https://res.cloudinary.com/duaeqqpu7/image/upload/v1700224859/BethanyPieShop/hwtiae9yd125v6ekpacq.jpg",
            IsPieOfTheWeek = false,
            ImageThumbnailUrl =
                "https://res.cloudinary.com/duaeqqpu7/image/upload/v1700225013/BethanyPieShop/g7hfnriwxmpx9pfm4kvy.jpg"
        },
        new()
        {
            PieId = 6, Name = "Cherry Almond Pie", Price = 15.75M, ShortDescription = "Nutty Sweetness",
            LongDescription =
                "Embark on a flavor adventure with our Cherry Almond Pie. Succulent cherries mingle with the crunch of almonds, all embraced by a golden crust. " +
                "It's a delightful balance of fruity sweetness and nutty richness.",
            Category = _categoryRepository.AllCategories.ToList()[2],
            ImageUrl =
                "https://res.cloudinary.com/duaeqqpu7/image/upload/v1700225085/BethanyPieShop/g6jstfozlguifgvmn5bh.jpg",
            IsPieOfTheWeek = true,
            ImageThumbnailUrl =
                "https://res.cloudinary.com/duaeqqpu7/image/upload/v1700225155/BethanyPieShop/gdnfqm0dehrzptinmilz.jpg"
        },
    };

    public IEnumerable<Pie> PiesOfTheWeek
    {
        get { return AllPies.Where(p => p.IsPieOfTheWeek); }
    }

    public Pie? GetPieById(int pieId) => AllPies.FirstOrDefault(p => p.PieId == pieId);

    public IEnumerable<Pie> SearchPies(string searchQuery)
    {
        throw new NotImplementedException();
    }
}