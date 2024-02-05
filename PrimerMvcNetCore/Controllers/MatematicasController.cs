using Microsoft.AspNetCore.Mvc;

namespace PrimerMvcNetCore.Controllers
{
    public class MatematicasController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult SumarNumerosGet(int numero1, int numero2)
        {
            int suma = numero1 + numero2;
            ViewData["RESULTADO"] = "El resultado de " + numero1 + " y " + numero2 + " es: " + suma;
            return View();
        }
        public IActionResult SumarNumerosPost()
        {
            return View();
        }
        [HttpPost]
        public IActionResult SumarNumerosPost(int numero1, int numero2)
        {
            int suma = numero1 + numero2;
            ViewData["RESULTADO"] ="La suma de " + numero1 + " y "+ numero2+ " es " + suma;
            return View();
        }

        public IActionResult ConjeturaCollatz()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ConjeturaCollatz(int numero)
        {   
            //Declaramos un model apra enviarlo a la vista
            List<int> numeros = new List<int>();
            while(numero != 1)
            {
                if(numero % 2 == 0)
                {
                    numero = numero / 2;
                }
                else
                {
                    numero = numero * 3 + 1;
                }
                numeros.Add(numero);
            }
            //Devolvemos el model a la vista
            return View(numeros);
        }
    }
}
