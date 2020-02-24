using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Tarea4.Models;

namespace Tarea4.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Formulario()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Formulario(datos data, HttpPostedFileBase imagen)
        {
            if (ModelState.IsValid)
            {
                string nombreFoto = imagen.FileName;

                imagen.SaveAs(Server.MapPath("/Content/" + nombreFoto));


                @ViewBag.foto = nombreFoto;

                return View("Resivir", data);
            }
            else
            {

                return View("Formulario");
            }
        }
        public ActionResult Resivir(datos data)
        {

            return View(data);
        }
    }
}