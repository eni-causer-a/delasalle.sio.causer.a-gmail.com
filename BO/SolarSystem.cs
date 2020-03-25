using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class SolarSystem : IDbEntity
    {
        public long? Id { get => throw new NotImplementedException(); }
        [StringLength(20, MinimumLength = 5)]
        public string nom { get; set; }
        public virtual List<Planet> planets { get; set; }
    }
}
