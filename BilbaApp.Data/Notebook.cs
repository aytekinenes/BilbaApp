using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilbaApp.Data
{
    public class Notebook
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        public string ImageUrl { get; set; }
        public int Price { get; set; }

        public List<Spec> Spec { get; set; }
    }
    public class Spec
    {
        public int Id { get; set; }
        [Required]
        public string Spesifications { get; set; }
    }
}
