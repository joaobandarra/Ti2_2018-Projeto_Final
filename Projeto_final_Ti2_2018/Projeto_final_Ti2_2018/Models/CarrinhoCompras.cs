using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Projeto_final_Ti2_2018.Models
{
    public class CarrinhoCompras
    {
        public CarrinhoCompras()
        {
            ListaCarrinhoComprasProdutos = new HashSet<CarrinhoComprasProdutos>();
        }


        // cria um atributo para funcionar como FK, na BD
        // e relaciona-o com o atributo anterior
        [Key]
        [ForeignKey("Cliente")]
        public int ClienteFK { get; set; }
        // relaciona o objeto Cliente com um objeto CarrinhoCompras
        public virtual Cliente Cliente { get; set; }


        // especificar que um carrinho de compras tem muitos Carrinhos de compras/produto
        public virtual ICollection<CarrinhoComprasProdutos> ListaCarrinhoComprasProdutos { get; set; }
    }

}
