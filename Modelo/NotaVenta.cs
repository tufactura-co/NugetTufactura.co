using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TuFactura.co.Modelo
{
    /// <summary>
    /// Carga  Todos los Objetos que componen la Nota Débito/Crédito de Venta
    /// </summary>
    public class NotaVenta
    {
        /// <summary>
        /// Objeto que contiene los valores de cabecera de la Nota Débito/Crédito
        /// </summary>
        [Display(Name = "Objeto Cabecera")]
        [Required(ErrorMessage = "El Objeto {0} es requerido")]
        public CabeceraNota Cabecera { get; set; }
        /// <summary>
        /// Objeto que contiene los valores para cargar observaciones a la Nota Débito/Crédito. Estas observaciones se cargan en los XML que se envian a la Dian.
        /// </summary>
        [Display(Name = "Objeto Observaciones")]
        public Observaciones Observaciones { get; set; }
        /// <summary>
        /// Lista que contiene las lineas de productos o servicios que componen la Nota Débito/Crédito. Tambien conocido como Detalle de la Nota Débito/Crédito
        /// </summary>
        [Display(Name = "Objeto Items")]
        [Required(ErrorMessage = "El Objeto {0} es requerido")]    
        public IList<ItemNota> Items { get; set; }

        /// <summary>
        /// Lista que registra los impuestos presentes en la Nota Débito/Crédito. Se deben usar los códigos incluidos Resolución 0019 de febrero de 2016 Anexo 1 apartado  8.5. Impuestos registrados en la Factura Electrónica
        /// </summary>
        [Display(Name = "Objeto Impuestos")]
        public IList<ItmsImpuesto> ItmsImpuestos { get; set; }
    }
}
