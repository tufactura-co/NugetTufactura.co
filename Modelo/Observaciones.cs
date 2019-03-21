using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TuFactura.co.Modelo
{
    /// <summary>
    /// Contiene todos los objetos y propiedades necesarias para Crear las observaciones a las Factura de Venta o Nota Débito/Crédito.
    /// </summary>
    public class Observaciones
    {
        /// <summary>
        /// Lista que carga las observaciones de la Factura o Nota. Estas observaciones son enviadas a la Dian en el XML de la Factura o Nota.
        /// </summary>
        [Display(Name = "Lista observaciones")]
        //[Required(ErrorMessage = "El campo {0} es requerido")]
        public IList<string> Lista { get; set; }
        public Observaciones()
        {
            Lista = new List<string>();
           
        }
    }
}
