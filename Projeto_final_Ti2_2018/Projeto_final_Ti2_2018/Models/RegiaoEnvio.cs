using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Projeto_final_Ti2_2018.Models
{
    public class RegiaoEnvio
    {

        [Key]
        [Display(Name = "ID: ")]
        public int IDRegiaoEnvio { set; get; }

        [Required]
        [StringLength(30)]
        [Display(Name = "Nome da Região: ")]
        public string NomeRegiao { set; get; }
    }
}