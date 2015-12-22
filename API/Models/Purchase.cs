using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace API.Models
{
    public class Purchase
    {
        public int Id { get; set; }
        [Required]
        public int Date { get; set; }
        // Foreign Key
        public int UserId { get; set; }

        public int History { get; set; }
    }
}