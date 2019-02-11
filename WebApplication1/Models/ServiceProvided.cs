using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models
{
    public class ServiceProvided
    {
        public long Id {get; set; }

        [Display(Name = "Descrição do serviço")]
        public string Description {get; set; }

        [Display(Name = "Data de atedimento")]
        public DateTime Date {get; set; }

        [Display(Name = "Valor do serviço")]
        public decimal Value {get; set; }

        [Display(Name = "Tipo de serviço")]
        public string Type {get; set; }

        public long ClientId {get; set; }

        [ForeignKey("ClientId")]
        [Display(Name = "Cliente")]
        public virtual Client Client {get; set; }
    }
}