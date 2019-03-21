using System.ComponentModel.DataAnnotations;

namespace TuFactura.co.Modelo
{
    /// <summary>
    /// Contiene todos los objetos y propiedades necesarias para cargar los medios de pago de una  Factura de Venta o Notas Débito/Crédito.
    /// </summary>
    public class FacturaPago
    {
        /// <summary>
        /// Valor auto incrementado por cada medio de pago asociado a la factura.
        /// </summary>
        [Display(Name = "Id Item")]
        //[Required(ErrorMessage = "El campo {0} es requerido")]
        public string IdItems { get; set; }
        /// <summary>
        /// Valor que carga el codigo correspondiente al tipo de pago. Valores de refrencia, Resolución 0019 de febrero de 2016 Anexo 1 apartado 8.6.Medios de pago (Se debe usar el estándar 4461 de UN/CEFACT versión 06B)
        /// </summary>
        [Display(Name = "Código Medio Pago")]
        //[Required(ErrorMessage = "El campo {0} es requerido")]
        public string CodigoMedioPago { get; set; }
        /// <summary>
        /// Valor que carga el valor pagado por dicho medio de pago. Se utiliza como separador decimal el punto(.) NO USAR SEPARADORES DE MILES
        /// </summary>
        [Display(Name = "Valor Medio Pago")]
       // [Required(ErrorMessage = "El campo {0} es requerido")]
        public decimal ValorMedioPago { get; set; }
        /// <summary>
        /// Propiedad utilizada para cargar el Código del tipo de moneda del Pago. Si no se proporciona el sistema tomara el peso Colombiano como codigo de moneda, COP. Se debe usar el estándar ISO 4217
        /// </summary>
        [Display(Name = "Código Moneda Pago")]
       // [Required(ErrorMessage = "El campo {0} es requerido")]
        public string CodigoMonedaFactura { get; set; }
    }
}
