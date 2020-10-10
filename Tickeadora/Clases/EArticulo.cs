using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tickeadora.Clases
{
    public class EArticulo
    {
        public int Numero { get; set; }
        public string Descripcion { get; set; }
        public decimal Cantidad { get; set; }
        public decimal PrecioUnitario { get; set; }
        public decimal PrecioNeto { get; set; }
        public decimal Importe { get; set; }
    }
}
