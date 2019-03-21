using System;
using System.ComponentModel.DataAnnotations;

namespace TuFactura.co.Modelo
{
   
    public class AdjuntoInput
    {

        /// <summary>
        /// Propiedad que permite especificar el tipo de archivo adjunto. Valores enteros entre 0 y 2. Para 0 (cero), Representación gráfica de la factura (PDF). 1(uno), Cualquier Archivo que se quiera dejar Disponible para que los adquirientes descarguen del portal. 2(dos), Archivo que sera incluido en el correo de notificación de la factura junto con los tipo 0(cero). Los tipo 2(dos)  mas el tipo 0 no debe ser mayor a 10MB(Regla de los clientes de Correo). Los tipo(dos) deben cargarse antes de la notificación de la Factura o Nota. Los Archivos tipo 1 (uno) solo se podrán cargar antes de que la factura sea: Aprobada/Rechazada o AutoAprobada y el tamaño no puede ser mayor de 14MB por cada Archivo.
        /// </summary>
        [Display(Name = "Tipo Archivo")]
        [Required(ErrorMessage = "El campo {0} es requerido")]
        [Range(0, 2, ErrorMessage = "El valor {0} Debe estar entre {1} y {2}.")]
        public int TipoArchivo { get; set; }  
        /// <summary>
        /// Propiedad que carga el archivo adjunto coddificado en B64.
        /// </summary>
        [Display(Name = "B64 Archivo")]
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public string B64 { get; set; }
        /// <summary>
        /// Propiedad que Carga el nombre del archivo. El nombre del archivo debe contener la Extención del archivo. Este nombre sera el que se mostrara en el portal y en los archivos adjuntos del correo.
        /// </summary>
        [Display(Name = "Nombre de Archivo")]
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public string NombreArchivo { get; set; }
    }
}
