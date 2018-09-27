using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JulioRivero.Tesis.WebMVC.Models
{
    public class DeficiencyViewModel
    {
        public int Id { get; set; }
        public string Kind { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

      // public ICollection<Imparirment> imparirments { get; set; }
    }
}