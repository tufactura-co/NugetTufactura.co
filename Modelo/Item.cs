using System.ComponentModel.DataAnnotations;

namespace TuFactura.co.Modelo
{
    /// <summary>
    /// Linea de producto de la Factura o item del detalle de la Factuta
    /// </summary>
    public class Item
    {
       public Item() { }


        /// <summary>
        /// Valor auto incrementado por cada linea de producto o item de la Factura o Nota. Los items en la Factura son ordenados por este campo tanto en el xml como en la representacion Gráfica
        /// </summary>    
        [Display(Name = "Id Item")]
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public string IdItems { get; set; }
        /// <summary>
        /// Valor que carga la cantidad del producto y/o servicio facturado. Se utiliza como separador decimal el punto(.) NO USAR SEPARADORES DE MILES
        /// </summary> 
        [Display(Name = "Cantidad")]
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public decimal Cantidad { get; set; }

        /// <summary>
        /// Valor que carga la presentación del producto y/o servicio facturado. Ejemplo: Unidades, Caja, Docena, Kilo, Gramo
        /// </summary> 
        [Display(Name = "Presentación")]     
        public string Presentacion { get; set; }


        /// <summary>
        /// Valor que carga el codigo Ean ó Upc  del producto y/o servicio facturado
        /// </summary> 
        [Display(Name = "Código EanUpc")]
        public string EanUpc { get; set; }
        /// <summary>
        /// Propiedad Utilizada para cargar valores de referencia necesarios para la representación gráfica de la Factura. Cada facturador da su significdo.
        /// </summary>
        [Display(Name = "Referencia Uno")]
        public string ReferenciaUno { get; set; }
        /// <summary>
        /// Propiedad Utilizada para cargar valores de referencia necesarios para la representación gráfica de la Factura. Cada facturador da su significdo.
        /// </summary>
        [Display(Name = "Referencia dos")]
        public string ReferenciaDos { get; set; }
        /// <summary>
        /// Propiedad Utilizada para cargar valores de referencia necesarios para la representación gráfica de la Factura. Cada facturador da su significdo.
        /// </summary>
        [Display(Name = "Referencia tres")]
        public string ReferenciaTres { get; set; }
        /// <summary>
        /// Propiedad Utilizada para cargar la referencia Del Producto.
        /// </summary>
        [Display(Name = "Referencia")]
        public string Referencia { get; set; }

        /// <summary>
        /// Propiedad Utilizada para cargar el serial o seriales del producto y/o servicio facturado. Cuando el elemento tenga un serial para control de activo se debe asociar en la factura. Si el producto o servicio tiene mas de un serial se pueden poner todos en esta misma linea separados por espacios o tabulaciones.
        /// </summary>
        [Display(Name = "Serial")]
        public string Serial { get; set; }

        /// <summary>
        /// Propiedad Utilizada para cargar la descripción  del producto y/o servicio facturado.
        /// </summary>
        [Display(Name = "Descripción")]
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public string Descripcion { get; set; }
        /// <summary>
        /// Propiedad Utilizada para cargar el valor unitario  del producto y/o servicio facturado sin impuestos.
        /// </summary>
        [Display(Name = "Valor Unitario item")]
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public decimal ValorUnitario { get; set; }
        /// <summary>
        /// Propiedad Utilizada para cargar el SubTotal  del producto y/o servicio facturado sin impuestos. es el equivalente a Cantidad*ValorUnitario. Este valor debe llegar Calculado.
        /// </summary>
        [Display(Name = "Subtotal Item")]
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public decimal SubTotal { get; set; }
        /// <summary>
        /// Propiedad Utilizada para cargar el valor total  del producto y/o servicio facturado sin impuestos. es el equivalente a Cantidad*ValorUnitario. Este valor debe llegar Calculado. Nota Este Campo sera utilizado cuando la Dian Solicite especificar los impuestos a nivel de línea de producto, Por el momento sera el mismo valor del SubTotal.
        /// </summary>
        [Display(Name = "Valor Total Item")]
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public decimal ValorTotal { get; set; }
    }
}
