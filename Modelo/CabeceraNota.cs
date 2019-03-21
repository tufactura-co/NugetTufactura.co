using System.ComponentModel.DataAnnotations;

namespace TuFactura.co.Modelo
{
    /// <summary>
    /// Contiene todos los objetos y propiedades necesarias para Crear la Cabecera de la Nota Débito/Crédito.
    /// </summary>
    public class CabeceraNota
    {
        /// <summary>
        /// Propiedad Utilizada para vincular un consecutivo interno y único para el nit del facturador. Este campo se utiliza para validar que no se envie dos veces o mas el mismo documento. Esta referencia se muestra se muestra en el portal de Clientes. A demás se permite el filtrado por este campo.
        /// </summary>
        [Display(Name = "Documento Interno Nota")]
        [Required(ErrorMessage = "El campo {0} es requerido")]
        [StringLength(100, ErrorMessage = "El campo {0} debe tener entre {2} y {1} caracteres", MinimumLength = 1)]
        public string DocumentoReferencia1 { get; set; }
        /// <summary>
        /// Propiedad Utilizada para cargar valores de referencia necesarios para la representación gráfica de la Nota Débito/Crédito. Cada facturador da su significdo.
        /// </summary>
        [Display(Name = "Referencia 2")]
        public string DocumentoReferencia2 { get; set; }
        /// <summary>
        /// Propiedad Utilizada para cargar valores de referencia necesarios para la representación gráfica de la Nota Débito/Crédito. Cada facturador da su significdo.
        /// </summary>
        [Display(Name = "Referencia 3")]
        public string DocumentoReferencia3 { get; set; }
        /// <summary>
        /// Propiedad Utilizada para cargar valores de referencia necesarios para la representación gráfica de la Nota Débito/Crédito. Cada facturador da su significdo.
        /// </summary>
        [Display(Name = "Referencia 4")]
        public string DocumentoReferencia4 { get; set; }
        
        /// <summary>
        /// Propiedad que carga el tipo de Nota a Crear: Nota Débito ó Crédito. C para Nota Crédito y D Para nota Débito. Se debe enviar la Letra en MAYÚSCULA 
        /// </summary>
        [Display(Name = "Tipo Nota")]
        [Required(ErrorMessage = "El campo {0} es requerido")]
        [StringLength(1, ErrorMessage = "El campo {0} debe tener entre {2} y {1} caracteres", MinimumLength = 1)]
        public string NotaTipo { get; set; }

        /// <summary>
        /// Propiedad utilizada para cargar el subtotal de la Nota Débito/Crédito. Es la suma del total de cada uno de los items que componen las líneas de productos o detalle de la Nota Débito/Crédito sin impuestos. Se utiliza como separador decimal el punto(.) NO USAR SEPARADORES DE MILES
        /// </summary>
        [Display(Name = "Subtotal")]
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public decimal Subtotal { get; set; }

        /// <summary>
        /// Propiedad utilizada para cargar La Base de la Nota Débito/Crédito. El el Subtotal menos los descuentos y demas cobros. Es el valor utilizado para calcular los impuestos. Se utiliza como separador decimal el punto(.) NO USAR SEPARADORES DE MILES
        /// </summary>
        [Display(Name = "Base")]
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public decimal Base { get; set; }

        /// <summary>
        /// Propiedad utilizada para cargar el total de  descuentos presentes en la Nota Débito/Crédito. Se utiliza como separador decimal el punto(.) NO USAR SEPARADORES DE MILES
        /// </summary>
        [Display(Name = "Descuentos")]
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public decimal Descuentos { get; set; }

        /// <summary>
        /// Propiedad utilizada para cargar el total de  abonos o pagos parciales presentes en la Nota Débito/Crédito. Se utiliza como separador decimal el punto(.) NO USAR SEPARADORES DE MILES
        /// </summary>
        [Display(Name = "Abonos")]
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public decimal Abonos { get; set; }

        /// <summary>
        /// Propiedad utilizada para cargar el total(COP) en pesos de la Nota Débito/Crédito. Se utiliza como separador decimal el punto(.) NO USAR SEPARADORES DE MILES
        /// </summary>
        [Display(Name = "Cargos")]
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public decimal Cargos { get; set; }

        /// <summary>
        /// Propiedad utilizada para cargar el total de Impuestos Retenidos presentes en la Nota Débito/Crédito. Se utiliza como separador decimal el punto(.) NO USAR SEPARADORES DE MILES
        /// </summary>
        [Display(Name = "Impuestos Retenidos")]
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public decimal ImpuestosRetenidos { get; set; }

        /// <summary>
        /// Propiedad utilizada para cargar el total de la Nota Débito/Crédito. Se utiliza como separador decimal el punto(.) NO USAR SEPARADORES DE MILES
        /// </summary>
        [Display(Name = "Total")]
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public decimal Total { get; set; }


        /// <summary>
        /// Propiedad utilizada para cargar el número de resolución de Nota Débito/Crédito utilizado para Emitir la Nota Débito/Crédito. Si no se proporciona el sistema tomara una según criterios configurados. Si el obligado a facturar solo tiene una resolución de Nota Débito/Crédito no es necesario enviar ningun valor.
        /// </summary>
        public string NumeroResolucionNota { get; set; }

        /// <summary>
        /// Propiedad utilizada para cargar el número de la factura a la cual se le aplicara la Nota Débito/Crédito. Debe incluirse el Prefijo si la factura maneja prefijo. Este campo debe ser único por cada NIT facturador.
        /// </summary>
        [Display(Name = "Consecutivo Factura ")]
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public string ConsecutivoFactura { get; set; }


        /// <summary>
        /// Propiedad utilizada para cargar el Código del tipo de moneda de toda la Nota Débito/Crédito. Si no se proporciona el sistema tomara el peso Colombiano como codigo de moneda, COP. Se debe usar el estándar ISO 4217
        /// </summary> 
        [Display(Name = "Código Móneda Nota")]
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public string CodigoMonedaNota { get; set; }


        /// <summary>
        /// Propiedad utilizada para cargar el Código de Tipo de establecimiento donde se genera el Documento. Si no se proporciona el sistema asignará E-02 que corresponde a "Establecimiento de comercio". Se deben usar los códigos incluidos Resolución 0019 de febrero de 2016 Anexo 1 apartado 8.16. Tipos de establecimientos
        /// </summary>  
        [Display(Name = "Código Establecimiento")]
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public string CodigoEstablecimiento { get; set; }

        /// <summary>
        /// Propiedad utilizada como bandera para cargar Documentos en ambiente productivo para que sean procesados paso a paso y se pueda validar toda la trazabilidad del documento. (Recepción de la información, Generación de la Factura, Firma de la Factura, Entrega de la factura a la Dian). Este Valor debe ser igual a Cero 0 cuando ya se hayan surtido las pruebas.  
        /// </summary>
        [Display(Name = "Tiempo Espera Emisión")]
        [Range(0, 1, ErrorMessage = "El valor {0} Debe estar entre {1} y {2}.")]
        public int TiempoEsperaEmision { get; set; }

        /// <summary>
        /// Propiedad utilizada para cargar correos Eletrónicos Adicionales a los que registra el tercero o adquiriente en el momento de su creacion o actualización. Estos correos aplicaran solo para la Nota Débito/Crédito Actual. Para poner mas de un correo se deben separar las direcciones por punto y coma (;): corre1@micorreo.com;correo2@micorreo.com.  
        /// </summary>
        [Display(Name = "Tiempo Espera Emisión")]
        public string CodigoNotificacionAdicional { get; set; }

        /// <summary>
        /// Propiedad utilizada para cargar el código del concepto asociado a la Nota Débito/Crédito. Se deben usar los códigos incluidos Resolución 0019 de febrero de 2016 Anexo 1 apartado 8.3.Concepto de Notas crédito y 8.4.Concepto de Notas débito
        /// </summary>
        [Display(Name = "Codigo Concepto Nota")]
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public string CodigoConceptoNota { get; set; }
        /// <summary>
        /// Propiedad utilizada para cargar el total en pesos Colombianos de la Nota Débito/Crédito.
        /// </summary>
        [Display(Name = "Total COP")]        
        public decimal TotalCop { get; set; }
    }
}
