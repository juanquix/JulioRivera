using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JulioRivero.Tesis.Entities;
using System.Data.Entity;

namespace JulioRivero.Tesis.EFContext
{
    public class TesisContext:DbContext
    {
        public TesisContext():base("name=DefaultConnection")
        {
            Database.SetInitializer<TesisContext>(new DropCreateDatabaseIfModelChanges<TesisContext>());
            //Database.SetInitializer<TesisContext>(new CreateDatabaseIfNotExists<TesisContext>());
        }
        public DbSet<Impairment> Impairments { get; set;  }
        public DbSet<Deficiency> Deficiencys { get; set; }

      //  public System.Data.Entity.DbSet<JulioRivero.Tesis.WebMVC.Models.DeficiencyViewModel> DeficiencyViewModels { get; set; }

        // public System.Data.Entity.DbSet<JulioRivero.Tesis.WebMVC.Models.ImparirmentViewModel> ImparirmentViewModels { get; set; }
    }
}
