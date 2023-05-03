using Microsoft.AspNetCore.Mvc;

namespace la_mia_pizzeria_static.Controllers
{
    public class PizzaController : Controller
    {
        List<Pizza> pizze = new List<Pizza>
            {
                new Pizza(1, "Pizza Margherita", "Bella buona", "https://www.nicesurgelati.it/wp-content/uploads/2018/05/pizza_margherita_nice.jpg", 6),
                new Pizza(2, "Pizza Diavola", "Bella buona", "https://www.nicesurgelati.it/wp-content/uploads/2018/05/pizza_margherita_nice.jpg", 8),
                new Pizza(3, "Pizza Bufala", "Bella buona", "https://www.nicesurgelati.it/wp-content/uploads/2018/05/pizza_margherita_nice.jpg", 8),
            };

        public IActionResult Index()
        { 
            return View(pizze);
        }

        public IActionResult Details(int id) 
        { 
            var pizza = pizze.FirstOrDefault(p => p.Id == id);

            if (pizza == null)
            {
                return NotFound();
            }

            return View(pizza);
        }

    }
}
