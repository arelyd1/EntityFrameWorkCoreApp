using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using UdemyElCore.Data.Contexts;

namespace UdemyElCore.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            UdemyContext context = new ();
            //ekleme
            //var entityEntry = context.Products.Add(new Data.Entities.Product
            //{
            //    Name = "diloşş",
            //    Price = 3400
            //});
            //güncelleme
            //var updatedProduct = context.Products.Find(1002);


            //var entityEntry2 = context.Products.Update(new Data.Entities.Product
            //{
            //    Id = 1,
            //    Name = "Bilgisayar"

            //});
            //silme
            //var deleteproduct = context.Products.FirstOrDefault(x => x.Id==1002);
            //var entityEntry = context.Products.Remove(new Data.Entities.Product
            //{
            //    Id = 1
            //}) ;
            //context.SaveChanges();
            return View();
        }
    }
}
