﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JulioRivero.Tesis.Entities
{
    public class Deficiency
    {
        public int Id { get; set; }
        public string Kind { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public ICollection<Impairment> imparirments { get; set; }
    }
}
