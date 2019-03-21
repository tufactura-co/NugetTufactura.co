using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TuFactura.co.Modelo
{
    /// <summary>
    /// Contiene todos los objetos y propiedades necesarias para cargar Anexos una  Factura de Venta o Nota Débito/Crédito.
    /// </summary>
    public class AnexoInput
    {
        /// <summary>
        /// Propiedad que permite cargar el id del documento (Factura o Nota Débito/Crédito) al cual se le van a cargar la lista de adjunto
        /// </summary>
        [Display(Name = "Id Documento")]
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public string DocId { get; set; }
        /// <summary>
        /// Valor Correspondiente al identificador del suscriptor. Este Valor es generado cuando el obligado a facturara se registra en https://tufactura.co/ e Inicia el proceso de facturación Con el Proveedor Tecnológico Software Estratégico
        /// </summary>
        [Display(Name = "Suscriptor")]
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public string Suscriptor { get; set; }

        /// <summary>
        /// Propiedad que carga la lista de archivos adjuntos que seran cargados como anexos al Documento 
        /// </summary>
        [Display(Name = "Lista Adjuntos")]
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public IList<AdjuntoInput> Adjuntos { get; set; }
        public AnexoInput()
        {
            Adjuntos = new List<AdjuntoInput>();
           

        }
    }

    public class Anexo: AnexoInput
    {
        public int DocumentoTipo { get; set; }
        public new IList<Adjunto> Adjuntos { get; set; }

        public DateTime DocumentoCreado;
        private void FechaDocumento()
        {
            DocumentoCreado = DateTime.Now;
        }
        public  Anexo(AnexoInput Entrada)
        {
            DocumentoTipo = 8;
            DocId = Entrada.DocId;
            //Adjuntos = Entrada.Adjuntos;
            FechaDocumento();
            Suscriptor = Entrada.Suscriptor;
            List<Adjunto> TempAdjuntos =new List<Adjunto>(); 

            foreach (var Adj in Entrada.Adjuntos)
            {
                Adjunto NuevoAdjunto = new Adjunto();
                NuevoAdjunto.AdjuntoId = Guid.NewGuid().ToString().ToUpper();
                NuevoAdjunto.B64 = Adj.B64;
                NuevoAdjunto.NombreArchivo = Adj.NombreArchivo;
                NuevoAdjunto.TipoArchivo = Adj.TipoArchivo;
                TempAdjuntos.Add(NuevoAdjunto);
            }
            Adjuntos = TempAdjuntos;

        }

    }
}
