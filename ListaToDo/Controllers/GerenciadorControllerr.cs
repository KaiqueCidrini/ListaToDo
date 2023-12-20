using Microsoft.AspNetCore.Mvc;

namespace ListaToDo.Controllers
{
    public class GerenciadorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Criar()
        {
            return View();
        }

        public IActionResult Apagar()
        {
            return View();
        }

        public IActionResult Concluido()
        {
            return View();
        }
    }
}
