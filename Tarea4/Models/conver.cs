using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Tarea4.Models
{
    public class conver
    {
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public double num1 { set; get; }
        public double num2 { set; get; }

        public long1 unidades1 { set; get; }
        public long2 unidades2 { set; get; }

        public temperatura1 temp1 { set; get; }
        public temperatura2 temp2 { set; get; }

        public massa1 masa1 { set; get; }
        public massa2 masa2 { set; get; }
        public data1 Datos1 { set; get; }
        public data2 Datos2 { set; get; }


        // mira aqui cree 2 lista s

    }

    public enum long1
                {
                    Centimetro, Pies, Pulgadas, Metros, Kilometros , Millas
                } 
    
     public enum long2
    {
                    Centimetro, Pies, Pulgadas, Metros, Kilometros , Millas
                }

    public enum temperatura1
    {
        Celcius, Farenheit, Kelvin
    }

    public enum temperatura2
    {
        Celcius, Farenheit, Kelvin
    }

    public enum massa1
    {
        Gramo, Kilogramo, Onza, Libra
    }

    public enum massa2
    {
        Gramo, Kilogramo, Onza, Libra
    }


    public enum data1
    {
        Bit, Byte, Kilobyte, Megabyte, Gigabyte, Terabyte
    }
    public enum data2
    {
        Bit, Byte, Kilobyte, Megabyte, Gigabyte, Terabyte
    }

}