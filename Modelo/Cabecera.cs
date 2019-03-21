using System.ComponentModel.DataAnnotations;

namespace TuFactura.co.Modelo
{
    /// <summary>
    /// Contiene Todas las Propiedades neecsraias para crear la Cabecera de una Factura de Venta.
    /// </summary>
    public class Cabecera
    {
        /// <summary>
        /// Propiedad Utilizada para cargar valores de referencia necesarios para la representación gráfica de la Factura. Cada facturador da su significdo.
        /// </summary>
        [Display(Name = "Referencia 1")]
        public string DocumentoReferencia1 { get; set; }
        /// <summary>
        /// Propiedad Utilizada para cargar valores de referencia necesarios para la representación gráfica de la Factura. Cada facturador da su significdo.
        /// </summary>
        [Display(Name = "Referencia 2")]
        public string DocumentoReferencia2 { get; set; }
        /// <summary>
        /// Propiedad Utilizada para cargar valores de referencia necesarios para la representación gráfica de la Factura. Cada facturador da su significdo.
        /// </summary>
        [Display(Name = "Referencia 3")]
        public string DocumentoReferencia3 { get; set; }
        /// <summary>
        /// Propiedad Utilizada para cargar valores de referencia necesarios para la representación gráfica de la Factura. Cada facturador da su significdo.
        /// </summary>
        [Display(Name = "Referencia 4")]
        public string DocumentoReferencia4 { get; set; }
        /// <summary>
        /// Propiedad Utilizada para cargar valores de referencia necesarios para la representación gráfica de la Factura. Cada facturador da su significdo.
        /// </summary>
        [Display(Name = "Referencia 5")]
        public string DocumentoReferencia5 { get; set; }
        /// <summary>
        /// Propiedad Utilizada para cargar valores de referencia necesarios para la representación gráfica de la Factura. Cada facturador da su significdo.
        /// </summary>
        [Display(Name = "Referencia 6")]
        public string DocumentoReferencia6 { get; set; }
        /// <summary>
        /// Propiedad Utilizada para cargar valores de referencia necesarios para la representación gráfica de la Factura. Cada facturador da su significdo.
        /// </summary>
        [Display(Name = "Referencia 7")]
        public string DocumentoReferencia7 { get; set; }
        /// <summary>
        /// Propiedad Utilizada para cargar valores de referencia necesarios para la representación gráfica de la Factura. Cada facturador da su significdo.
        /// </summary>
        [Display(Name = "Referencia 8")]
        public string DocumentoReferencia8 { get; set; }
        /// <summary>
        /// Propiedad Utilizada para cargar valores de referencia necesarios para la representación gráfica de la Factura. Cada facturador da su significdo.
        /// </summary>
        [Display(Name = "Referencia 9")]
        public string DocumentoReferencia9 { get; set; }
        /// <summary>
        /// Propiedad Utilizada para vincular un consecutivo interno y único para el nit del facturador. Este campo se utiliza para validar que no se envie dos veces o mas el mismo documento. Esta referencia se muestra se muestra en el portal de Clientes. A demás se permite el filtrado por este campo.
        /// </summary>
        [Display(Name = "Documento Interno")]
        [Required(ErrorMessage = "El campo {0} es requerido")]
        [StringLength(100, ErrorMessage = "El campo {0} debe tener entre {2} y {1} caracteres", MinimumLength = 1)]
        public string DocumentoReferencia10 { get; set; }
        /// <summary>
        /// Propiedad Utilizada para cargar valores de referencia necesarios para la representación gráfica de la Factura. Cada facturador da su significdo.
        /// </summary>
        [Display(Name = "Referencia 11")]
        public string DocumentoReferencia11 { get; set; }
        /// <summary>
        /// Propiedad utilizada para cargar el subtotal de la factura. Es la suma del total de cada uno de los items que componen las líneas de productos o detalle de la factura sin impuestos. Se utiliza como separador decimal el punto(.) NO USAR SEPARADORES DE MILES
        /// </summary>
        [Display(Name = "Subtotal")]
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public decimal Subtotal { get; set; }
        /// <summary>
        /// Propiedad utilizada para cargar La Base de la factura. El el Subtotal menos los descuentos y demas cobros. Es el valor utilizado para calcular los impuestos. Se utiliza como separador decimal el punto(.) NO USAR SEPARADORES DE MILES
        /// </summary>
        [Display(Name = "Base")]
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public decimal Base { get; set; }
        /// <summary>
        /// Propiedad utilizada para cargar el total de  descuentos presentes en la Factura. Se utiliza como separador decimal el punto(.) NO USAR SEPARADORES DE MILES
        /// </summary>
        [Display(Name = "Descuentos")]
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public decimal Descuentos { get; set; }
        /// <summary>
        /// Propiedad utilizada para cargar el total de  abonos o pagos parciales presentes en la Factura. Se utiliza como separador decimal el punto(.) NO USAR SEPARADORES DE MILES
        /// </summary>
        [Display(Name = "Abonos")]
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public decimal Abonos { get; set; }
        /// <summary>
        /// Propiedad utilizada para cargar el total(COP) en pesos de la Factura. Se utiliza como separador decimal el punto(.) NO USAR SEPARADORES DE MILES
        /// </summary>
        [Display(Name = "Cargos")]
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public decimal Cargos { get; set; }
        /// <summary>
        /// Propiedad utilizada para cargar el total de Impuestos Retenidos presentes en la Factura. Se utiliza como separador decimal el punto(.) NO USAR SEPARADORES DE MILES
        /// </summary>
        [Display(Name = "Impuestos Retenidos")]
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public decimal ImpuestosRetenidos { get; set; }
        /// <summary>
        /// Propiedad utilizada para cargar el total de la Factura. Se utiliza como separador decimal el punto(.) NO USAR SEPARADORES DE MILES
        /// </summary>
        [Display(Name = "Total")]
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public decimal Total { get; set; }
        /// <summary>
        /// Propiedad utilizada para cargar el total de plazo en dias de las facturas a credito
        /// </summary>
        [Display(Name = "Plazo Credito")]
        public string PlazoCredito { get; set; }
        /// <summary>
        /// Propiedad utilizada para cargar el número de resolución de facturación  utilizado para Emitir la Factura. Si no se proporciona el sistema tomara una según criterios configurados. Si el obligado a facturar solo tiene una resolución de facturación no es necesario enviar ningun valor.
        /// </summary>
        [Display(Name = "Numero Resolución Facturación")]
        public string NumeroResolucion { get; set; }
        /// <summary>
        /// Propiedad utilizada para cargar el Código del tipo de moneda de toda la factura Electrónica. Si no se proporciona el sistema tomara el peso Colombiano como codigo de moneda, COP. Se debe usar el estándar ISO 4217
        /// </summary>  
        [Display(Name = "Código Móneda Factura")]
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public string CodigoMonedaFactura { get; set; }
        /// <summary>
        /// Propiedad utilizada para cargar el Código de Tipo de establecimiento donde se genera el Documento. Si no se proporciona el sistema asignará E-02 que corresponde a "Establecimiento de comercio". Se deben usar los códigos incluidos Resolución 0019 de febrero de 2016 Anexo 1 apartado 8.16. Tipos de establecimientos
        /// </summary>  
        [Display(Name = "Código Establecimiento")]
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public string CodigoEstablecimiento { get; set; }
        /// <summary>
        /// Propiedad utilizada para cargar el documento del tercero o Adquiriente de la Factura. No se debe incluir el dígito de verificación. Valores Permitidos enteros de 0 a 9223372036854775807
        /// </summary>
        [Display(Name = "Documento")]
        [Required(ErrorMessage = "El campo {0} es requerido.")]
        public long Documento { get; set; }
        /// <summary>
        /// Propiedad utilizada como bandera para cargar Documentos en ambiente productivo para que sean procesados paso a paso y se pueda validar toda la trazabilidad del documento. (Recepción de la información, Generación de la Factura, Firma de la Factura, Entrega de la factura a la Dian). Este Valor debe ser igual a Cero 0 cuando ya se hayan surtido las pruebas.  
        /// </summary>
        [Display(Name = "Tiempo Espera Emisión")]
        [Range(0, 1, ErrorMessage = "El valor {0} Debe estar entre {1} y {2}.")]
        public int TiempoEsperaEmision { get; set; }
        /// <summary>
        /// Propiedad utilizada para cargar correos Eletrónicos Adicionales a los que registra el tercero o adquiriente en el momento de su creacion o actualización. Estos correos aplicaran solo para la factura Actual. Para poner mas de un correo se deben separar las direcciones por punto y coma (;): corre1@micorreo.com;correo2@micorreo.com.  
        /// </summary>
        [Display(Name = "Tiempo Espera Emisión")]
        public string CodigoNotificacionAdicional { get; set; }
        /// <summary>
        /// Propiedad utilizada para cargar el tipo de factura. se usa la siguiente notación: Factura Exportación E; Factura Importación I; Factura Contingencia O; Factura Factura de Venta V. Las letras deben estar en Mayúsculas 
        /// </summary>
        [Display(Name = "Tipo Factura")]
        [Required(ErrorMessage = "El campo {0} es requerido")]
        [StringLength(1, ErrorMessage = "El campo {0} debe tener entre {2} y {1} caracteres", MinimumLength = 1)]
        public string TipoFactura { get; set; }
        /// <summary>
        /// Propiedad utilizada para cargar la taza de Cambio Negociada de la moneda de la factura. Aplica solo para las facturas que menejan moneda diferente a COP peso Colombiano. La taza representativa de mercado  de la moneda es calculada por la plataforma y se agrega al xml que se envia a la Dian.
        /// </summary>
        [Display(Name = "Taza De Cambio Negociada")]
        public string TazaDeCambio { get; set; }

        public Cabecera()
        {

        }
    }
}
