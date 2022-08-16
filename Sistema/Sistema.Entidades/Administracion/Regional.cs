﻿using Sistema.Entidades.Solicitud;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Sistema.Entidades.Administracion
{
    public class Regional
    {
        public int idregional { get; set; }
        [Required]
        [StringLength (50,MinimumLength = 3,ErrorMessage ="El nombre no debe tener mas de 50 caracteres, ni menos de 3 caracteres")]
        public string nombre { get; set; }
        [StringLength(256)]
        public string descripcion { get; set; }
        public bool condicion { get; set; }

        public ICollection<Ordendepago> ordendepago { get; set; }
    }
}
