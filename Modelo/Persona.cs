using System.ComponentModel.DataAnnotations;

namespace TuFactura.co.Modelo
{
    public class Persona
    {
        [Display (Name = "Documento")]
        [Required(ErrorMessage = "El campo {0} es requerido.")]
        public long? Documento { get; set; }
        
        /// <summary>
        /// Indica si el tercero es Natural(2), juridico(1) o  gran contribuyente(3).
        /// </summary>
        [Display(Name = "Tipo Persona")]
        [Required(ErrorMessage = "El campo {0} es requerido")]
        //[StringLength(1, ErrorMessage = "El campo {0} debe tener entre {2} y {1} caracteres", MinimumLength = 1)]
        [Range(1, 3, ErrorMessage = "El valor {0} Debe estar entre {1} y {2}.")]        
        public int TipoPersona { get; set; }

        [StringLength(500, ErrorMessage = "El campo {0} debe tener entre {2} y {1} caracteres", MinimumLength = 2)]
        public string NPrimerNombre { get; set; }

        //[StringLength(500, ErrorMessage = "El campo {0} debe tener entre {2} y {1} caracteres", MinimumLength = 2)]
        public string NSegundoNombre { get; set; }

        [StringLength(500, ErrorMessage = "El campo {0} debe tener entre {2} y {1} caracteres", MinimumLength = 2)]
        public string NPrimerApellido { get; set; }


        //[StringLength(500, ErrorMessage = "El campo {0} debe tener entre {2} y {1} caracteres", MinimumLength = 2)]
        public string NSegundoApellido { get; set; }


          
        public string NGenero { get; set; }

        public string NExpedicionDocumento { get; set; }

        public int? PDigitoVerificacion { get; set; }

    
        [Display(Name = "Dirección")]
        [Required(ErrorMessage = "El campo {0} es requerido")]
        [StringLength(100, ErrorMessage = "El campo Dirección debe tener entre {2} y {1} caracteres", MinimumLength = 5)]
        public string PDireccion { get; set; }


        [Display(Name = "Email")]
        [Required(ErrorMessage = "El campo {0} es requerido")]
        [StringLength(500, ErrorMessage = "El campo {0} debe tener entre {2} y {1} caracteres", MinimumLength = 5)]
        public string PEmail { get; set; }

        [Display(Name = "Movil")]
        public string PMovil { get; set; }

        [Display(Name = "Telefono")]
        [Required(ErrorMessage = "El campo {0} es requerido")]        
       // [Range(0,99999999999, ErrorMessage = "El valor {0} Debe estar entre {1} y {2}.")]
       // [StringLength(10, ErrorMessage = "El campo {0} debe tener entre {2} y {1} caracteres", MinimumLength = 7)]
        public long PTelefono { get; set; }

        [Display(Name = "Código Documento")]
        [Required(ErrorMessage = "El campo {0} es requerido")]
        [StringLength(16, ErrorMessage = "El campo {0} debe tener entre {2} y {1} caracteres", MinimumLength = 1)]       
        public string DCodigoDocumento { get; set; }


        [Display(Name = "Código Tributario")]
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public int RCodigoTributario { get; set; }

        [StringLength(100, ErrorMessage = "El campo {0} debe tener entre {2} y {1} caracteres", MinimumLength = 3)]
        public string RCodigoRepresentacion { get; set; }

        [StringLength(100, ErrorMessage = "El campo {0} debe tener entre {2} y {1} caracteres", MinimumLength = 3)]
        public string JRazonSocial { get; set; }

        [StringLength(100, ErrorMessage = "El campo {0} debe tener entre {2} y {1} caracteres", MinimumLength = 3)]
        public string NOtrosNombres { get; set; }

        [Display(Name = "Nombre Departamento")]
        //[StringLength(100, ErrorMessage = "El campo {0} debe tener entre {2} y {1} caracteres", MinimumLength = 3)]
        public string DNombreDepartamento { get; set; }

        public string TercModificadoPor { get; set; }


        [Display(Name = "Nombre Ciudad")]
        [Required(ErrorMessage = "El campo {0} es requerido")]
        [StringLength(100, ErrorMessage = "El campo {0} debe tener entre {2} y {1} caracteres", MinimumLength = 3)]
        public string CNombreCiudad { get; set; }


        [Display(Name = "Código Pais")]
        [Required(ErrorMessage = "El campo {0} es requerido")]
        [MinLength(2, ErrorMessage = "El campo {0} debe contener {1} caracteres")]
        public string CodigoPais { get; set; }


        [StringLength(100, ErrorMessage = "El campo {0} debe tener entre {2} y {1} caracteres", MinimumLength = 1)]
        public string PersReferencia1 { get; set; }


        [StringLength(100, ErrorMessage = "El campo {0} debe tener entre {2} y {1} caracteres", MinimumLength = 1)]
        public string PersReferencia2 { get; set; }

        [StringLength(100, ErrorMessage = "El campo {0} debe tener entre {2} y {1} caracteres", MinimumLength = 1)]
        public string PersReferencia3 { get; set; }

    }
}
