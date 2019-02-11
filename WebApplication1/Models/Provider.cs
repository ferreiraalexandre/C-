using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class Provider
    {
        public long ProviderId {get; set;}

        [Display(Name = "Nome")]
        public string Name {get; set;}

        [Display(Name = "Estado")]
        public string State {get; set;}

        [Display(Name = "Cidade")]
        public string City {get; set;}
    }
}