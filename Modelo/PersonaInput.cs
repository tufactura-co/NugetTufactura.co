using System.Collections.Generic;

namespace TuFactura.co.Modelo
{
    public class PersonaInput
    {
        public Solicitud Solicitud { get; set; }
        public List<Persona> Persona { get; set; }
        // public IList<CasillaRut> CasillasRut { get; set; }
        public PersonaInput()
        {
            Solicitud = new Solicitud();
            Persona = new List<Persona>();
        }
    }
}
