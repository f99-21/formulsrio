﻿using System.ComponentModel.DataAnnotations;

namespace formulsrio.Models
{
    public class tipo_equipo
    {
        [Key]

        public int id_tipo_equipo { get; set; }

        public string descripcion { get; set; }

        public string estado { get; set; }

    }
}
