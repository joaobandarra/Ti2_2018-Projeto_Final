using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Projeto_final_Ti2_2018.Models
{
    public class Categoria
    {
        public Categoria()
        {
            ListaSubCategorias = new HashSet<SubCategoria>();
        }
        [Key]
        public int IDCategoria { get; set; }

        [Required]
        [StringLength(255)]
        [Display(Name = "Designação: ")]
        public string Nome { get; set; }



        // especificar que um uma categoria está em muitos produtos
        public virtual ICollection<SubCategoria> ListaSubCategorias { get; set; }
    }

}
