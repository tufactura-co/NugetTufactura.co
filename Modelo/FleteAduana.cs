using System.ComponentModel.DataAnnotations;

namespace TuFactura.co.Modelo
{
    /// <summary>
    /// Contiene todos los objetos y propiedades necesarias para Cargar los cobros de fletes y las Aduanas a las Factura de  Exportaciones.
    /// </summary>
    public class FleteAduana
    {
        /// <summary>
        /// Propiedad que carga el rótulo o label  Flete. Se usa solo para la representación gráfica de la Factura o Nota.
        /// </summary> 
        [Display(Name = "Rotulo Flete")]      
        public string RotuloFlete { get; set; }
        /// <summary>
        /// Propiedad que carga el rótulo o label  Aduana. Se usa solo para la representación gráfica de la Factura o Nota.
        /// </summary> 
        [Display(Name = "Rotulo Aduana")]
        public string RotuloAduana { get; set; }
        /// <summary>
        /// Propiedad que carga el rótulo o label Seguro. Se usa solo para la representación gráfica de la Factura o Nota.
        /// </summary> 
        [Display(Name = "Rotulo Seguro")]
        public string RotuloSeguro { get; set; }
        /// <summary>
        /// Propiedad que carga el Valor Flete. Se usa solo para la representación gráfica de la Factura o Nota.
        /// </summary> 
        [Display(Name = "Valor Flete")]
        public string Flete { get; set; }
        /// <summary>
        /// Propiedad que carga el Valor Aduana. Se usa solo para la representación gráfica de la Factura o Nota.
        /// </summary> 
        [Display(Name = "Valor Aduana")]
        public string Aduana { get; set; }
        /// <summary>
        /// Propiedad que carga el Valor Seguro. Se usa solo para la representación gráfica de la Factura o Nota.
        /// </summary> 
        [Display(Name = "Valor Seguro")]
        public string Seguro { get; set; }
        /// <summary>
        /// Propiedad que carga la moneda de la Aduana. Se usa solo para la representación gráfica de la Factura o Nota.
        /// </summary> 
        [Display(Name = "Moneda Aduna")]
        public string MonedaAduna { get; set; }
        /// <summary>
        /// Propiedad que carga la moneda del Flete. Se usa solo para la representación gráfica de la Factura o Nota.
        /// </summary> 
        [Display(Name = "Moneda Flete")]
        public string MonedaFlete { get; set; }
        /// <summary>
        /// Propiedad que carga la moneda del Seguro. Se usa solo para la representación gráfica de la Factura o Nota.
        /// </summary> 
        [Display(Name = "Moneda Seguro")]
        public string MonedaSeguro { get; set; }
        public FleteAduana()
        {

        }
    }
}
