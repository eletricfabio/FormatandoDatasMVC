using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FormatandoDatasMVC.Models
{
    public class Funcionarios
    {
        [Required]
        [Display(Name = "Telefone")]
        public string TelefoneResidencial { get; set; }

        [Display(Name = "País")]
        public string Pais { get; set; }

        [Display(Name = "Data de Nascimento")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public Nullable<System.DateTime> DataNascimento { get; set; }

        [Display(Name = "Data de Admissão")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public Nullable<System.DateTime> DataAdmissao { get; set; }

        [DataType(DataType.MultilineText)]
        public string Notas { get; set; }
    }
}