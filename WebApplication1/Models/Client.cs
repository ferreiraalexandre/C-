using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Client
    {
        [Key]
        public long id { get; set; }
        public string Name { get; set;}
        public string Distict { get; set;}
        public string City { get; set; }
        public string State { get; set; }
    }
}