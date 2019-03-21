using System.ComponentModel.DataAnnotations;

namespace TuFactura.co.Modelo
{

    /// <summary>
    /// Contiene todos los objetos y propiedades necesarias para Crear los Datos de Envio de a la Factura de Venta.
    /// </summary>
    public class DatosEnvio
    {

       
        /// <summary>
        /// Propiedad que carga la direccion de Envio.
        /// </summary>
        [Display(Name = "Direción Envio")]
        //[Required(ErrorMessage = "El campo {0} es requerido")]
        public string DirecionEnvio { get; set; }
        /// <summary>
        /// Propiedad que carga el departamento o estado de Envio.
        /// </summary>
        [Display(Name = "Departamento Envio")]
        public string DepartamentoEnvio { get; set; }
        /// <summary>
        /// Propiedad que carga el Municipio de Envio.
        /// </summary>
        [Display(Name = "Municipio Envio")]
        public string MunicipioEnvio { get; set; }
        /// <summary>
        /// Propiedad que carga la Ciudad de Envio.
        /// </summary>
        [Display(Name = "Ciudad Envio")]
        //[Required(ErrorMessage = "El campo {0} es requerido")]
        public string CiudadEnvio { get; set; }
        /// <summary>
        /// Propiedad que carga el país de Envio. Se debe usar el estándar ISO 3166-1, en formato 2 dígitos; 
        /// </summary>
        [Display(Name = "Código Pais")]
        //[Required(ErrorMessage = "El campo {0} es requerido")]
        public string CodigoPais { get; set; }
        /// <summary>
        /// Propiedad que carga el Lugar De Entrega o estado de Envio.
        /// </summary>
        [Display(Name = "Lugar De Entrega")]
        public string LugarDeEntrega { get; set; }
        /// <summary>
        /// Propiedad que carga El teléfono de envio.
        /// </summary>
        [Display(Name = "Teléfono")]        
        public string Telefono { get; set; }
    }
}
