using Microsoft.AspNetCore.Mvc;
using MvcApiNuggetTiendaZapatillasJPL.Services;
using NuggetTiendaZapatillasJPL.Models;

namespace MvcApiNuggetTiendaZapatillasJPL.Controllers
{
    public class ZapatillasController : Controller
    {
        private ServiceApiZapatillas service;

        public ZapatillasController(ServiceApiZapatillas service)
        {
            this.service = service;
        }


        //METODO PARA SACAR TODAS LAS ZAPAS
        public async Task<IActionResult> Index()
        {

            List<Zapatilla> cubos =
                await this.service.GetZapatillassAsync();
            return View(cubos);

        }

        //METODO PARA BUSCAR CUBO POR MARCA
        public async Task<IActionResult> FindCuboAsync(int id)
        {
            Zapatilla zapa = await this.service.FindZapatillaAsync(id);
            return View(zapa);
        }
    }
}
