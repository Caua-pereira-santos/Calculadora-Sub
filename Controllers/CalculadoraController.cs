using system;
using System.Collections.Generic;
using System.Ling;
using System.Web;
using System.Web.Mvc;

namespace Calculadora.Controllers
{
    public class CalculadoraController : Controller
    {
        [httpGet]
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Index(CalculadoraViewModel calculadoraViewModel)
        {
            
            ModelState.Clear();
            calculadoraViewModel.Resultado = calculadoraViewModel.num1 + calculadoraViewModel.Num2;
            return View(calculadoraViewModel);
        }
    }
}