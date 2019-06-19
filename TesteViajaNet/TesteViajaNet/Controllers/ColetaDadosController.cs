using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class ColetaDadosController : Controller
    {
        // POST: ColetaDados
        // Envia os dados de navegação para o Banco de Dados
        [HttpPost]
        public ActionResult Index(ParametroColetado dados)
        {



            return new HttpStatusCodeResult(200); 
        }
    }
}