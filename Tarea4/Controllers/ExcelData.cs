using System;

namespace Tarea4.Controllers
{
    internal class ExcelData
    {
        private string fileSrc;

        public ExcelData(string fileSrc)
        {
            this.fileSrc = fileSrc;
        }

        internal object getData(string worksheet)
        {
            throw new NotImplementedException();
        }
    }
}