﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CLINICAUH.Models
{
    public class Medico
    {
        public int IdMedico { get; set; }
        public string Nombre { get; set; }
        public string Especialidad { get; set; }
        public string Telefono { get; set; }
    }
}