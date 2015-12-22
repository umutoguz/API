using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace API.Models
{
    public class Cart
    {
        public int Id { get; set; }
        [Required]
        public int Date { get; set; }
        // Foreign Key
        public int UserId { get; set; }
    }
}