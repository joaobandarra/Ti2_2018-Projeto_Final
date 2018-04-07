using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Projeto_final_Ti2_2018.Models
{
    public class DBSuperGes : DbContext
    {

        
        //**********************************************************
        //  informar a entity framework que as classes abaixo 
        //  descritas devem ser associadas a uma base de dados
        //**********************************************************

        public virtual DbSet<Cliente> Clientes { get; set; }

        public virtual DbSet<Encomenda> Encomendas { get; set; }

        public virtual DbSet<SubCategoria> SubCatergorias { get; set; }

        public virtual DbSet<CarrinhoCompras> CarrinhoCompras { get; set; }

        public virtual DbSet<CarrinhoComprasProdutos> CarrinhoComprasProdutos { get; set; }

        public virtual DbSet<Produto> Produtos { get; set; }

        public virtual DbSet<EncomendaProduto> EncomendaProdutos { get; set; }

        public virtual DbSet<TipoEnvio> TiposEnvio { get; set; }

        public virtual DbSet<RegiaoEnvio> RegiaoEnvio { get; set; }

        public virtual DbSet<Categoria> Categorias { get; set; }



    }
}