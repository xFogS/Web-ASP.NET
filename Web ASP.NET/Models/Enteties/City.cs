﻿using System.ComponentModel.DataAnnotations.Schema;

namespace Web_ASP.NET.Models.Enteties
{
    public class City
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string? Name { get; set; } = null!;
        public int? AreaId { get; set; }
        [ForeignKey("AreaId")]
        public Area? Area { get; set; }
        List<CityCityTypeLink>? Links { get; set; }
    }
}
