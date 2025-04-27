﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NugetJerseyHubRGO.Models
{
    [Table("ETIQUETA")]
    public class Etiqueta
    {
        [Key]
        [Column("idEtiqueta")]
        public int IdEtiqueta { get; set; }
        [Column("etiqueta")]
        public string TxtEtiqueta { get; set; }
    }
}
