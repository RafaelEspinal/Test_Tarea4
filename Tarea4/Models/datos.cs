using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Tarea4.Models
{
    public class datos
    {
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string Nombre { set; get; }
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string Apellido { set; get; }
        [Range(15, 100)]
        public int Edad { set; get; }
        public string Teléfono { set; get; }

        [Required(ErrorMessage = "Este campo es requerido.")]
        [RegularExpression(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*",
          ErrorMessage = "Dirección de Correo electrónico incorrecta.")]
        public string Correo { set; get; }
        public string Género { set; get; }
        public puesto_trabajo trabajo { set; get; }


       
    }

    public enum puesto_trabajo
    {

       puesto1 , puesto2 , puesto3
    }

}