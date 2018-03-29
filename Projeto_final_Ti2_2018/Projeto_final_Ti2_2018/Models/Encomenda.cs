using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Projeto_final_Ti2_2018.Models
{
    public class Encomenda
    {








        // vai representar os dados da tabela das Encomendas

        // criar o construtor desta classe
        // e carregar a lista de encomendas/produto   
        public Encomenda()
        {
            ListaProdutosDaEncomenda = new HashSet<EncomendaProduto>();

        }

        [Key]
        [Display(Name = "ID: ")]
       
        public int IDEncomenda { get; set; }

        [Required]
        [Column(TypeName = "date")]
        [Display(Name = "Data de Criação da Encomenda: ")]
        public DateTime DataCriacaoEncomenda { get; set; }

        // [Required]
        [Column(TypeName = "date")]
        [Display(Name = "Data de Envio da Encomenda: ")]
        public DateTime? DataEnvioEncomenda { get; set; }

        [Required]
        [StringLength(255)]
        [Display(Name = "Estado da Compra: ")]
        public string EstadoCompra { get; set; }

        [Required]
        [Display(Name = "Custo de envio: ")]
        public double CustoEnvio { get; set; }

        [Required]
        [StringLength(255)]
        [Display(Name = "Morada de Faturação: ")]
        public string MoradaFaturacao { get; set; }

        [Required]
        [StringLength(255)]
        [Display(Name = "Codigo Postal de Faturação: ")]
        //    [RegularExpression("[0-9]{4}-[0-9]{3}( [A-Za-záéíóúàèìòùçâêîôûãõäëïöüñ])*", ErrorMessage = "O Código de Postal tem de ser escrito da seguinte forma XXXX-XXX")]
        public string CodPostalFaturacao { get; set; }

        [Required]
        [StringLength(255)]
        [Display(Name = "Morada de Entrega: ")]
        public string MoradaEntrega { get; set; }

        [Required]
        [StringLength(255)]
        [Display(Name = "Codigo Postal de Entrega: ")]
        //    [RegularExpression("[0-9]{4}-[0-9]{3}( [A-Za-záéíóúàèìòùçâêîôûãõäëïöüñ])*", ErrorMessage = "O Código de Postal tem de ser escrito da seguinte forma XXXX-XXX")]
        public string CodigoPostalEntrega { get; set; }

        //***********************************************************
        // relaciona o objeto Cliente com um objeto Encomenda
        // cria um atributo para funcionar como FK, na BD
        // e relaciona-o com o atributo anterior
        [ForeignKey("Cliente")]
        public int ClienteFK { get; set; }
        public virtual Cliente Cliente { get; set; }

        //***********************************************************
        // relaciona o objeto TiposEnvio com um objeto Encomenda
        // cria um atributo para funcionar como FK, na BD
        // e relaciona-o com o atributo anterior
        [ForeignKey("TipoEnvio")]
        public int TipoEnvioFK { get; set; }
        public virtual TipoEnvio TipoEnvio { get; set; }

        //***********************************************************
        // relaciona o objeto RegiaoEnvio com um objeto Encomenda
        // cria um atributo para funcionar como FK, na BD
        // e relaciona-o com o atributo anterior
        [ForeignKey("RegiaoEnvio")]
        public int RegiaoEnvioFK { get; set; }
        public virtual RegiaoEnvio RegiaoEnvio { get; set; }

        //***********************************************************
        // especificar que uma Encomenda tem muitos Produtos
        public virtual ICollection<EncomendaProduto> ListaProdutosDaEncomenda { get; set; }
    }




}
}