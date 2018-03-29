using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Projeto_final_Ti2_2018.Models
{
    public class TipoEnvio
    {
        public TipoEnvio()
        {
            ListaEncomendas = new HashSet<Encomenda>();

        }

        [Key]
        [Display(Name = "ID: ")]
        public int ID { set; get; }

        [Required]
        [StringLength(255)]
        [Display(Name = "Tipo de Envio: ")]
        public string TiposEnvio { set; get; }


        // especificar que um cliente faz muitas encomendas
        public virtual ICollection<Encomenda> ListaEncomendas { get; set; }
    }
}