using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Tarea4.Controllers
{
    public class FiltrosController : Controller
    {
        // GET: Filtros
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Peliculas()
        {
            return View();
        }

        public ActionResult Musica()
        {
            return View();
        }
    }
}