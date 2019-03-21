using System.ComponentModel.DataAnnotations;

namespace TuFactura.co.Modelo
{
    /// <summary>
    /// Contiene todos los objetos y propiedades necesarias para Crear la lista de impuestos reportados en la Factura de Venta o Nota Débito/Crédito.
    /// </summary>
    public class ItmsImpuesto
    {
        /// <summary>
        /// Valor auto incrementado por cada impuesto de la Factura o Nota. Los items en la Nota Débito/Crédito o factura son ordenados por este campo tanto en el xml como en la representacion Gráfica. Los impuestos se deben Agrupar por codigo de impuesto y tarifa.
        /// </summary> 
        [Display(Name = "Id Item")]
        //[Required(ErrorMessage = "El campo {0} es requerido")]      
        public string IdItems { get; set; }
        /// <summary>
        /// Valor que carga la base utilizada para el cánculo del impuesto. Se utiliza como separador decimal el punto(.) NO USAR SEPARADORES DE MILES
        /// </summary>       
       // [Required(ErrorMessage = "El campo {0} es requerido")]
        [Display(Name = "Base Impuesto")]
        public decimal BaseImpuesto { get; set; }
        /// <summary>
        /// Propiedad Utilizada para cargar el valor del impuesto a reportar. Se utiliza como separador decimal el punto(.) NO USAR SEPARADORES DE MILES
        /// </summary>         
        //[Required(ErrorMessage = "El campo {0} es requerido")]
        [Display(Name = "Valor Impuesto")]
        public decimal ValorImpuesto { get; set; }
        /// <summary>
        /// Propiedad Utilizada para cargar la tarifa del impuesto a reportar. solo se deben cargar números. Por ejemplo si es el 19% se registra 19, el 1% se registra el 1, el 0.1% se regitra 0.1 . Se utiliza como separador decimal el punto(.) NO USAR SEPARADORES DE MILES. Se debe agrupar por este campo.
        /// </summary> 
       //[Required(ErrorMessage = "El campo {0} es requerido")]    
        [Display(Name = "Tarifa Impuesto")]
        public string TarifaImpuesto { get; set; }
        /// <summary>
        /// Valor que carga el codigo que representa el tipo de impuesto a reportar. Se deben usar los códigos incluidos Resolución 0019 de febrero de 2016 Anexo 1 apartado 8.5. Impuestos registrados en la Factura Electrónica. este campo junto con la tarifa del impuesto crean un Grupo. si en la factura se tiene Impuestos codigo 01 (IVA) de tariafa del 19, 8 etc. Se creara un registro por cada Grupo. Uno Para el IVA del 19 y otro para el IVA del 8 respectivamente.
        /// </summary> 
        ///  [Display(Name = "Id Item")]
       // [Required(ErrorMessage = "El campo {0} es requerido")]
        [Display(Name = "Codigo Impuesto")]
        public string CodigoImpuesto { get; set; }
       
    }

}
