using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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



        // especificar que um uma subcategoria está em muitos produtos
        public virtual ICollection<Produto> ListaProdutos { get; set; }




        //***********************************************************
        // criar as chaves forasteiras
        //***********************************************************
        // cria um atributo para funcionar como FK, na BD
        // e relaciona-o com o atributo anterior
        [ForeignKey("Categoria")]
        public int IDCategoriaFK { get; set; }
        // relaciona o objeto Carrinho compras com um objeto carrinho compras produto
        public virtual Categoria Categoria { get; set; }

        //***********************************************************
    }
}