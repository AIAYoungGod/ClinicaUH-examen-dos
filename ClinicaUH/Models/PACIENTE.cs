using System;

namespace CLINICAUH.Models
{
    public class Paciente
    {
        public int IdPaciente { get; set; }
        public string Cedula { get; set; }
        public string Nombre { get; set; }
        public string PrimerApellido { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public int Edad { get; set; }
        public string Telefono { get; set; }
    }
}
