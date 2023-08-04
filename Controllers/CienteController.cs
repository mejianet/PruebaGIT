using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CienteController : Controller
    {
        //public IActionResult Index()
        //{
        //    return View();
        //}

        [HttpGet]
        public dynamic GetClientes()
        {
            List<Cliente> clientes = new List<Cliente>
            {
                new Cliente()
                {
                    Id = 1,
                    Name = "Miguel",
                    Description = "xcosa"
                },
                new Cliente()
                {
                    Id = 2,
                    Name = "Javier",
                    Description = "xcosa"
                }
            };
            return clientes;
        }
    }
}
