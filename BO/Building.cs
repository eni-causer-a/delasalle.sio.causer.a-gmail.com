using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public abstract class  Building : IDbEntity
    {
        public long? Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        [StringLength(20, MinimumLength = 5)]
        public string name { get; set; }
        [Range(0, int.MaxValue)]
        public int? level { get; set; }

        public abstract int? CellNb();
        
        public virtual List<Ressource> TotalCost() { return null; }

        public virtual List<Ressource> NextCost() { return null; }

    }
}
