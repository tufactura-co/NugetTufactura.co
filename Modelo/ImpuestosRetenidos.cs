using System.ComponentModel.DataAnnotations;

namespace TuFactura.co.Modelo
{
    /// <summary>
    /// Contiene todos los objetos y propiedades necesarias para Crear la lista de impuestos retenidos en la Factura de Venta o Notas Débito/Crédito.
    /// </summary>
    public class ImpuestosRetenidos
    {
        /// <summary>
        /// Valor auto incrementado por cada impuesto Retenido Presente en la Factura.
        /// </summary>
        [Display(Name = "Id Items")]
        //[Required(ErrorMessage = "La Propiedad {0} es requerido")]
        public string IdItems { get; set; }
        /// <summary>
        /// Propiedad Utilizada para cargar el valor del impuesto retenido. Se Usa solo para la representacion Gráfica de la Factura. Este valor se muestra en el formato y tal cual es recibido.
        /// </summary>
        [Display(Name = "Valor Impuesto")]
        //[Required(ErrorMessage = "La Propiedad {0} es requerido")]
        public string ValorImpuesto { get; set; }
        /// <summary>
        ///  Propiedad Utilizada para cargar el nombre del impuesto retenido. Se Usa solo para la representacion Gráfica de la Factura. Este valor se muestra tal cual es recibido. Ejemplo Retefuente.
        /// </summary>
        [Display(Name = "Nombre Impuesto")]
        //[Required(ErrorMessage = "La Propiedad {0} es requerido")]
        public string NombreImpuesto { get; set; }
        /// <summary>
        ///  Propiedad Utilizada para cargar el Código de la Divisa. Se Usa solo para la representacion Gráfica de la Factura. Se debe usar el estándar ISO 4217
        /// </summary>
        [Display(Name = "Codigo Moneda")]
        //[Required(ErrorMessage = "La Propiedad {0} es requerido")]
        public string IdCodigoMonedaItems { get; set; }
    }
}
