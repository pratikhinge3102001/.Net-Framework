using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using ViewTypeDemo.Models;

namespace ViewTypeDemo.Components
{
    public class Cart:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            List<Product> products = new List<Product>() { 
                new Product{Id=1,Name="Pencile",Price=5.50f},
            new Product{Id=2,Name ="Pen",Price=10f}
            
            };
            return View(products);
        }


    }
}
