using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TuFactura.co.Modelo
{
    /// <summary>
    /// Contiene todos los objetos y propiedades necesarias para Crear Una Factura de Venta.
    /// </summary>
    public class FacturaVenta
    {
        /// <summary>
        /// Objeto que contiene los valores de cabecera de la Factura
        /// </summary>
        [Display(Name = "Objeto Cabecera")]
        [Required(ErrorMessage = "El Objeto {0} es requerido")]
        public Cabecera Cabecera { get; set; }
        /// <summary>
        /// Objeto que contiene los valores para cargar observaciones a la Factura Electrónica. Estas observaciones se cargan en los XML que se envian a la Dian.
        /// </summary>
        [Display(Name = "Objeto Observaciones")]
        public Observaciones Observaciones { get; set; }
        /// <summary>
        /// Objeto que contiene los valores para cargar los Datos de envio de los productos. Estos valores solo se usan para la representación gráfica de la Factura. se usa cuando el cliente tiene una dirección de entrega y otra de Facturación.
        /// </summary>
        [Display(Name = "Objeto Datos Envio")]
        public DatosEnvio DatosEnvio { get; set; }
        /// <summary>
        /// Objeto que contiene los valores para cargar los Datos asociados a los difrentes medios de pago de la Factura. (Se debe usar el estándar 4461 de UN/CEFACT versión 06B)
        /// </summary>
        [Display(Name = "Objeto Factura Pagos")]
        public IList<FacturaPago> FacturaPagos { get; set; }
        /// <summary>
        /// Lista que contiene las lineas de productos o servicios que componen la Factura. Tambien conocido como Detalle de la Factura
        /// </summary>
        [Display(Name = "Objeto Items")]
        [Required(ErrorMessage = "El Objeto {0} es requerido")]
        public List<Item> Items { get; set; }
        /// <summary>
        /// Lista que registra los impuestos presentes en la Factura. Se deben usar los códigos incluidos Resolución 0019 de febrero de 2016 Anexo 1 apartado  8.5. Impuestos registrados en la Factura Electrónica
        /// </summary>
        [Display(Name = "Objeto Impuestos")]
        public IList<ItmsImpuesto> ItmsImpuestos { get; set; }
        /// <summary>
        /// Lista que registra las condiciones de entrega para las facturas de exportación. Se deben usar los códigos incluidos Resolución 0019 de febrero de 2016 Anexo 1 apartado  8.11. Incoterms 
        /// </summary>
        [Display(Name = "Objeto Incoterms")]
        public IList<ItemsIncoterm> ItemsIncoterms { get; set; }
        /// <summary>
        /// Objeto que registra los fletes y seguros de las facturas de exportación. Solo se usa en la representación Gráfica de la Factura
        /// </summary>
        [Display(Name = "Objeto FleteAduana")]
        public FleteAduana FleteAduana { get; set; }
        /// <summary>
        /// Lista Utilizada para mostrar los impuestos retenidos en la factura. Solo se usa en la representación Gráfica de la Factura
        /// </summary>
        [Display(Name = "Objeto ImpuestosRetenidos")]
        public IList<ImpuestosRetenidos> ImpuestosRetenidos { get; set; }

        public FacturaVenta()
        {
            Cabecera = new Cabecera();

            DatosEnvio = new DatosEnvio();
            Observaciones = new Observaciones();
            FacturaPagos = new List<FacturaPago>();
            Items = new List<Item>();
            ItmsImpuestos = new List<ItmsImpuesto>();
            ItemsIncoterms = new List<ItemsIncoterm>();
            FleteAduana = new FleteAduana();
            ImpuestosRetenidos = new List<ImpuestosRetenidos>();

        }
    }

}
