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
            ListaProdutos = new HashSet<Produto>();
        }
        [Key]
        public int IDCategoria { get; set; }

        [Required]
        [StringLength(255)]
        [Display(Name = "Nome: ")]
        public string Nome { get; set; }



        // especificar que um uma categoria está em muitos produtos
        public virtual ICollection<Produto> ListaProdutos { get; set; }
    }

}
}