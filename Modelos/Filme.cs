﻿using Microsoft.AspNetCore.Components.Forms;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RazorPages.Modelos
{
    public class Filme
    {
        public int ID { get; set; }
       
        [StringLength(100, MinimumLength = 3)]
        public string Titulo { get; set; } = string.Empty;

        [Display(Name ="Data de Lançamento")] 
        [DataType(DataType.Date)]
        public DateTime DataLancamento { get; set; }


        [Required(ErrorMessage ="Digite o genero do filme")]
        [StringLength(30, MinimumLength = 3)]
       
        public string Genero { get; set; } = string.Empty;
        
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Preco { get; set; }

        [Range(0,5)]
        public int Pontos { get; set; } = 0;
    }
}
