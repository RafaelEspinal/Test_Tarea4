using System.Web.Mvc;
using Tarea4.Models;
namespace Tarea4.Controllers
{
    public class ConversiónController : Controller
    {
        // GET: Conversión
        public ActionResult convertirLongitudes()
        {
            return View();
        }
        public ActionResult convertirTemperatura()
        {
            return View();
        }

        public ActionResult convertirMasa()
        {
            return View();
        }

        public ActionResult convertirDatos()
        {
            return View();
        }

        [HttpPost]
        public ActionResult convertirLongitudes(conver con)
        {

            string ver = con.unidades1.ToString() + con.unidades2.ToString();


            switch (ver)
            {
                //pulgadas    Pulgadas= Centimetro, Metros, Kilometros, Millas ,Pies
                case "PulgadasCentimetro":
                    con.num2 = con.num1 * 2.54;
                   
                    break;

                case "PulgadasMetros":
                    con.num2 = con.num1 * 0.0254;
                    break;

                case "PulgadasKilometros":
                    con.num2 = con.num1 * 0.0000254;
                    break;

                case "PulgadasMillas":
                    con.num2 = con.num1 * 0.0000157828;
                    break;

                case "PulgadasPies":
                    con.num2 = con.num1 * 0.083333;
                    break;

                case "PulgadasPulgadas":
                    con.num2 = con.num1 = con.num1;
                    break;

                // Centimetro  = Pulgadas, Metros, Kilometros, Millas ,Pies

                case "CentimetroPulgadas":
                    con.num2 = con.num1 * 0.393701;
                    break;

                case "CentimetroMetros":
                    con.num2 = con.num1 * 0.01;
                    break;

                case "CentimetroKilometros":
                    con.num2 = con.num1 * 0.00001;
                    break;

                case "CentimetroMillas":
                    con.num2 = con.num1 * 0.0000062137;
                    break;

                case "CentimetroPies":
                    con.num2 = con.num1 * 0.032808;
                    break;

                case "CentimetroCentimetro":
                    con.num2 = con.num1 = con.num1;
                    break;

                // Metros   = Pulgadas, Centimetro, Kilometros, Millas ,Pies

                case "MetrosPulgadas":
                    con.num2 = con.num1 * 39.3701;
                    break;

                case "MetrosCentimetro":
                    con.num2 = con.num1 * 100;
                    break;

                case "MetrosKilometros":
                    con.num2 = con.num1 * 0.001;
                    break;

                case "MetrosMillas":
                    con.num2 = con.num1 * 0.00062137;
                    break;

                case "MetrosPies":
                    con.num2 = con.num1 * 3.2808;
                    break;

                case "MetrosMetros":
                    con.num2 = con.num1 = con.num1;
                    break;

                // Kilometros    = Pulgadas, Centimetro, Metros, Millas ,Pies

                case "KilometrosPulgadas":
                    con.num2 = con.num1 * 39370.08;
                    break;

                case "KilometrosCentimetro":
                    con.num2 = con.num1 * 100000;
                    break;

                case "KilometrosMetros":
                    con.num2 = con.num1 * 1000;
                    break;

                case "KilometrosMillas":
                    con.num2 = con.num1 * 0.621371;
                    break;

                case "KilometrosPies":
                    con.num2 = con.num1 * 3280.84;
                    break;

                case "KilometrosKilometros":
                    con.num2 = con.num1 = con.num1;
                    break;

                //  Millas = Pulgadas, Centimetro, Kilometros ,Metros,Pies

                case "MillasPulgadas":
                    con.num2 = con.num1 * 63360;
                    break;

                case "MillasCentimetro":
                    con.num2 = con.num1 * 160934.4;
                    break;

                case "MillasKilometros":
                    con.num2 = con.num1 * 1.6093;
                    break;

                case "MillasMillas":
                    con.num2 = con.num1 = con.num1;
                    break;

                case "MillasPies":
                    con.num2 = con.num1 * 5280;
                    break;

                case "MillasMetros":
                    con.num2 = con.num1 * 1609.34;
                    break;


                // Pies  = Pulgadas, Centimetro, Kilometros ,Metros,Millas

                case "PiesPulgadas":
                    con.num2 = con.num1 * 12;
                    break;

                case "PiesCentimetro":
                    con.num2 = con.num1 * 30.48;
                    break;

                case "PiesKilometros":
                    con.num2 = con.num1 * 0.0003048;
                    break;

                case "PiesMetros":
                    con.num2 = con.num1 * 0.3048;
                    break;

                case "PiesMillas":
                    con.num2 = con.num1 * 0.00018939;
                    break;

                case "PiesPies":
                    con.num2 = con.num1 = con.num1;
                    break;

                default:
                    con.num2 = 0;
                    break;
            }



            return View(con);
        }


        [HttpPost]
        public ActionResult convertirTemperatura(conver con)
        {
            string ver = con.temp1.ToString() + con.temp2.ToString();

            switch (ver)
            {
                //Celcius = Farenheit, Kelvin
                case "CelciusFarenheit":
                    con.num2 = con.num1 * 1.8 + 32;
                    break;

                case "CelciusKelvin":
                    con.num2 = con.num1 + 273.15;
                    break;

                case "CelciusCelcius":
                    con.num2 = con.num1 = con.num1;
                    break;

                // Farenheit  = Celcius, Kelvin

                case "FarenheitCelcius":
                    con.num2 = (con.num1 -32) * 5/9 ;
                    break;

                case "FarenheitKelvin":
                    con.num2 = (con.num1 + 459.67) * 5/9;
                    break;


                case "FarenheitFarenheit":
                    con.num2 = con.num1 = con.num1;
                    break;

                //Kelvin   = Celcius, Farenheit

                case "KelvinCelcius":
                    con.num2 = con.num1 - 273.15;
                    break;

                case "KelvinFarenheit":
                    con.num2 = con.num1 * 9/5 - 459.67;
                    break;


                case "KelvinKelvin":
                    con.num2 = con.num1 = con.num1;
                    break;


                default:
                    con.num2 = 0;
                    break;
            }
            return View(con);
        }

       

        [HttpPost]
        public ActionResult convertirMasa(conver con)
        {

            string ver = con.masa1.ToString() + con.masa2.ToString();


                    switch (ver)
                    {
        
                //Gramo = Kilogramo, Onza y Libra

                case "GramoKilogramo":
                            con.num2 = con.num1 / 1000;
                            break;

                        case "GramoOnza":
                            con.num2 = con.num1 / 28.35;
                            break;

                        case "GramoLibra":
                            con.num2 = con.num1 / 454;
                            break;

                        case "GramoGramo":
                            con.num2 = con.num1 = con.num1;
                            break;

                //Kilogramo  = Gramo, Onza y Libra


                case "KilogramoGramo":
                    con.num2 = con.num1 * 1000;
                    break;

                case "KilogramoOnza":
                    con.num2 = con.num1 *  35.274;
                    break;

                case "KilogramoLibra":
                    con.num2 = con.num1 * 2.205;
                    break;

                case "KilogramoKilogramo":
                    con.num2 = con.num1 = con.num1;
                    break;

                // Onza   = Gramo, Kilogramo y Libra


                case "OnzaGramo":
                    con.num2 = con.num1 * 28.3495;
                    break;

                case "OnzaKilogramo":
                    con.num2 = con.num1 * 0.02835;
                    break;

                case "OnzaLibra":
                    con.num2 = con.num1 * 0.0625;
                    break;

                case "OnzaOnza":
                    con.num2 = con.num1 = con.num1;
                    break;

                //  Libra    = Gramo, Kilogramo y Onza


                case "LibraGramo":
                    con.num2 = con.num1 * 454;
                    break;

                case "LibraKilogramo":
                    con.num2 = con.num1 / 2.205;
                    break;

                case "LibraOnza":
                    con.num2 = con.num1 * 16;
                    break;

                case "LibraLibra":
                    con.num2 = con.num1 = con.num1;
                    break;
                default:
                            con.num2 = 0;
                            break;
                    }

            return View(con);
        }

        [HttpPost]
        public ActionResult convertirDatos(conver con)
        {
            string ver = con.Datos1.ToString() + con.Datos2.ToString();


            switch (ver)
            {
                // Bit = Byte, Kilobyte, Megabyte, Gigabyte, Terabyte

                case "BitByte":
                    con.num2 = con.num1 / 8;
                    break;

                case "BitKilobyte":
                    con.num2 = con.num1 / 8000;
                    break;

                case "BitMegabyte":
                    con.num2 = con.num1 / 8e+6;
                    break;

                case "BitGigabyte":
                    con.num2 = con.num1 / 8e+9;
                    break;

                case "BitTerabyte":
                    con.num2 = con.num1 / 8e+12;
                    break;

                case "BitBit":
                    con.num2 = con.num1 = con.num1;
                    break;

                // Byte  = Bit, Kilobyte, Megabyte, Gigabyte, Terabyte


                case "ByteBit":
                    con.num2 = con.num1 * 8;
                    break;

                case "ByteKilobyte":
                    con.num2 = con.num1 / 1000;
                    break;

                case "ByteMegabyte":
                    con.num2 = con.num1 / 1e+6;
                    break;

                case "ByteGigabyte":
                    con.num2 = con.num1 / 1e+9;
                    break;

                case "ByteTerabyte":
                    con.num2 = con.num1 / 1e+12;
                    break;

                case "ByteByte":
                    con.num2 = con.num1 = con.num1;
                    break;

                // Kilobyte  = Bit, Byte, Megabyte, Gigabyte, Terabyte

                case "KilobyteBit":
                    con.num2 = con.num1 * 8000;
                    break;

                case "KilobyteByte":
                    con.num2 = con.num1 * 1000;
                    break;

                case "KilobyteMegabyte":
                    con.num2 = con.num1 / 1000;
                    break;

                case "KilobyteGigabyte":
                    con.num2 = con.num1 / 1e+6;
                    break;

                case "KilobyteTerabyte":
                    con.num2 = con.num1 / 1e+9;
                    break;

                case "KilobyteKilobyte":
                    con.num2 = con.num1 = con.num1;
                    break;

                // Megabyte   = Bit, Byte, Kilobyte, Gigabyte, Terabyte

                case "MegabyteBit":
                    con.num2 = con.num1 * 8e+6;
                    break;

                case "MegabyteByte":
                    con.num2 = con.num1 * 1e+6;
                    break;

                case "MegabyteKilobyte":
                    con.num2 = con.num1 * 1000;
                    break;

                case "MegabyteGigabyte":
                    con.num2 = con.num1 / 1000;
                    break;

                case "MegabyteTerabyte":
                    con.num2 = con.num1 / 1e+6;
                    break;

                case "MegabyteMegabyte":
                    con.num2 = con.num1 = con.num1;
                    break;

                // Gigabyte    = Bit, Byte, Kilobyte, Megabyte, Terabyte

                case "GigabyteBit":
                    con.num2 = con.num1 * 8e+9;
                    break;

                case "GigabyteByte":
                    con.num2 = con.num1 * 1e+9;
                    break;

                case "GigabyteKilobyte":
                    con.num2 = con.num1 * 1e+6;
                    break;

                case "GigabyteMegabyte":
                    con.num2 = con.num1 * 1000;
                    break;

                case "GigabyteTerabyte":
                    con.num2 = con.num1 / 1000;
                    break;

                case "GigabyteGigabyte":
                    con.num2 = con.num1 = con.num1;
                    break;

                // Terabyte     = Bit, Byte, Kilobyte, Megabyte, Gigabyte

                case "TerabyteBit":
                    con.num2 = con.num1 * 8e+12;
                    break;

                case "TerabyteByte":
                    con.num2 = con.num1 * 1e+12;
                    break;

                case "TerabyteKilobyte":
                    con.num2 = con.num1 * 1e+9;
                    break;

                case "TerabyteMegabyte":
                    con.num2 = con.num1 * 1e+6;
                    break;


                case "TerabyteGigabyte":
                    con.num2 = con.num1 * 1000;
                    break;

                case "TerabyteTerabyte":
                    con.num2 = con.num1 = con.num1;
                    break;
                default:
                    con.num2 = 0;
                    break;
            }

            return View(con);

        }
    }

}