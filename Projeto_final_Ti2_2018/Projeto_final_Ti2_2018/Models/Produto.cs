﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Projeto_final_Ti2_2018.Models
{
    public class Produto
    {
        public Produto()
        {

            ListaEncomendaProduto = new HashSet<EncomendaProduto>();

            ListaCarrinhoComprasProdutos = new HashSet<CarrinhoComprasProdutos>();
        }

        [Key]
        [Display(Name = "ID: ")]
        public int IDProduto { get; set; }

        [Required]
        [StringLength(255)]
        [Display(Name = "Nome: ")]
        public string Nome { get; set; }

        //[Required]
        [StringLength(255)]
        [Display(Name = "Descrição: ")]
        public string Descricao { get; set; }


        [Required]
        [Display(Name = "Preço: ")]
        public double Preco { get; set; }

        [Required]
        [Display(Name = "IVA: ")]
        public double IVA { get; set; }

        [StringLength(255)]
        [Display(Name = "Fotografia: ")]
        public string Fotografia { get; set; }

        [Required]
        // peso em gramas
        [Display(Name = "Peso (em gramas ou mililitros): ")]
        public double Peso { get; set; }

        [Required]
        // peso em gramas
        [Display(Name = "Stock: ")]
        public int Stock { get; set; }




        //***********************************************************
        // criar as chaves forasteiras
        //***********************************************************
        // cria um atributo para funcionar como FK, na BD
        // e relaciona-o com o atributo anterior
        [ForeignKey("SubCategoria")]
        public int IDSubCategoriaFK { get; set; }
        // relaciona o objeto Carrinho compras com um objeto carrinho compras produto
        public virtual SubCategoria SubCategoria { get; set; }

        //***********************************************************









        // especificar que um produto está em muitas encomendas
        public virtual ICollection<EncomendaProduto> ListaEncomendaProduto { get; set; }

        // especificar que um produto está em muitos carrinhos de compras/produto
        public virtual ICollection<CarrinhoComprasProdutos> ListaCarrinhoComprasProdutos { get; set; }


    
    }
}