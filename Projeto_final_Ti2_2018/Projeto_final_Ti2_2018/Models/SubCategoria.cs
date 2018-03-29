using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Projeto_final_Ti2_2018.Models
{
    public class SubCategoria
    {
        public SubCategoria()
        {
            ListaProdutos = new HashSet<Produto>();
        }
        [Key]
        public int IDSubCategoria { get; set; }

        [Required]
        [StringLength(255)]
        [Display(Name = "Nome: ")]
        public string Nome { get; set; }



        // especificar que um uma categoria está em muitos produtos
        public virtual ICollection<Produto> ListaProdutos { get; set; }

    }
}