using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class Client
    {
        public long ClientId {get; set;}

        [Display(Name ="Nome")]
        public string Name {get; set;}

        [Display(Name = "Estado")]
        public string State {get; set;}

        [Display(Name = "Cidade")]
        public string City {get; set;}

        [Display(Name = "Bairro")] 
        public string Neighborhood { get; set;}

        public virtual ICollection<ServiceProvided> ServiceProvided {get; set;}
    }
}