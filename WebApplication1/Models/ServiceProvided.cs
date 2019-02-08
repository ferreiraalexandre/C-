using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class ServiceProvided
    {
        [Key]
        public long id { get; set; }
        public string Description { get; set; }
        public string Date { get; set; }
        public string Value { get; set; }
        public string Type { get; set; }
    }
}