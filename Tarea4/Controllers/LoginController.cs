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
        public ActionResult Formulario(datos data, HttpPostedFileBase imagen, HttpPostedFileBase pdf)
        {
            if (ModelState.IsValid)
            {
                string nombreFoto = imagen.FileName;
                imagen.SaveAs(Server.MapPath("/Content/" + nombreFoto));
                @ViewBag.foto = nombreFoto;

                string nombrepdf = pdf.FileName;
                pdf.SaveAs(Server.MapPath("/Content/" + nombrepdf));
                @ViewBag.pdf = nombrepdf;

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