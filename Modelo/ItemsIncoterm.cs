using System.ComponentModel.DataAnnotations;

namespace TuFactura.co.Modelo
{
    /// <summary>
    /// Contiene todos los objetos y propiedades necesarias para cargar los Incoterm a las Factura de Venta.
    /// </summary>
    public class ItemsIncoterm
    {

        /// <summary>
        /// Valor auto incrementado por cada Incoterm Presente en la Factura.
        /// </summary>
        [Display(Name = "Id Items")]
        //[Required(ErrorMessage = "El Objeto {0} es requerido")]
        public string IdItems { get; set; }
        /// <summary>
        /// Propiedad que carga el codigo del Incoterm presente en la Factura de exportación. Se deben usar los códigos incluidos Resolución 0019 de febrero de 2016 Anexo 1 apartado  8.11. Incoterms 
        /// </summary>
        [Display(Name = "Codigo Incoterms")]
        //[Required(ErrorMessage = "El Objeto {0} es requerido")]
        public string CodigoIncoterms { get; set; }
        /// <summary>
        /// Propiedad que carga una observacion o detalle al Incoterm presente en la Factura de exportación.
        /// </summary>
        [Display(Name = "Detalle IncoTerms")]
        public string DetalleIncoTerms { get; set; }
    }
}
