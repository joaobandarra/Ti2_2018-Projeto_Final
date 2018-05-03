using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Projeto_final_Ti2_2018.Models
{
    public class CarrinhoComprasProdutos
    {
        [Key]
        [Display(Name = "ID: ")]
        public int IDcomprasProduto { get; set; }



        [Required]
        [Display(Name = "Quantidade: ")]
        public int Quantidade { set; get; }



        //***********************************************************
        // criar as chaves forasteiras
        //***********************************************************
        // cria um atributo para funcionar como FK, na BD
        // e relaciona-o com o atributo anterior
        [ForeignKey("CarrinhoCompras")]
        public int IDCarrinhoComprasFK { get; set; }
        // relaciona o objeto Carrinho compras com um objeto carrinho compras produto
        public virtual CarrinhoCompras CarrinhoCompras { get; set; }

        //***********************************************************
        [ForeignKey("Produto")]
        public int IDProdutoFK { get; set; }
        // relaciona o objeto Produto com um objeto carrinho compras Produto
        public virtual Produto Produto { get; set; }

    }

}
