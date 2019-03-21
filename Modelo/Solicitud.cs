using System;

using System.ComponentModel.DataAnnotations;

namespace TuFactura.co.Modelo
{
    /// <summary>
    /// Cargar Los Parámetros necesarios para hacer la petición al servicio
    /// </summary>
    public class Solicitud
    {
        /// <summary>
        /// Valor Tipo Guid que identifica de manera unica cada petición. Se recomienda que tenga la estructura: 00000000-0000-0000-0000-000000000000
        /// </summary>
        [Display(Name = "Identificador Sesion")]
        [Required(ErrorMessage = "El Campo {0} es requerido")]
        public string Nonce { get; set; }
        /// <summary>
        /// Valor Correspondiente al identificador del suscriptor. Este Valor es generado cuando el obligado a facturara se registra en https://tufactura.co/ e Inicia el proceso de facturación Con el Proveedor Tecnológico Software Estratégico
        /// </summary>
        [Display(Name = "Identificador Suscriptor")]
        [Required(ErrorMessage = "El Campo {0} es requerido")]
        public string Suscriptor { get; set; }

        public Solicitud()
        {
            Nonce = Guid.NewGuid().ToString();
            Suscriptor = string.Empty;
        }
    }
}
