using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tickeadora.Clases
{
    public class EFactura
    {
        public int Numero { get; set; }
        public string Nombre { get; set; }
        public string Rfc { get; set; }
        public string Direccion { get; set; }
        public decimal Subtotal { get; set; }
        public decimal Iva { get; set; }
        public decimal Total { get; set; }
        public DateTime FechaTicket { get; set; }

        //Creamos una lista con una nueva Instancia de la clase Articulo
        //esta lista contendra el detalle de la factura
        public List<EArticulo> Detail = new List<EArticulo>();
    }
}
