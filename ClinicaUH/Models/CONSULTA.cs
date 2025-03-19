using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace CLINICAUH.Models

{
    public class Consulta
    {
        public int IdConsulta { get; set; }
        public int IdPaciente { get; set; }
        public int IdMedico { get; set; }
        public DateTime FechaAtencion { get; set; }
        public TimeSpan HoraAtencion { get; set; }
        public string Consultorio { get; set; }
    }
}
