using Microsoft.AspNetCore.Mvc;

namespace la_mia_pizzeria_static.Controllers
{
    public class PizzaController : Controller
    {
        public IActionResult Index()
        {
            List<Pizza> pizze = new List<Pizza>
            {
                new Pizza("Pizza Margherita", "Bella buona", "https://www.nicesurgelati.it/wp-content/uploads/2018/05/pizza_margherita_nice.jpg", 6),
                new Pizza("Pizza Diavola", "Bella buona", "https://www.nicesurgelati.it/wp-content/uploads/2018/05/pizza_margherita_nice.jpg", 8),
                new Pizza("Pizza Bufala", "Bella buona", "https://www.nicesurgelati.it/wp-content/uploads/2018/05/pizza_margherita_nice.jpg", 8),
            };
            return View(pizze);
        }

    }
}
