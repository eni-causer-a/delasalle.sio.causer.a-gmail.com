using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class Ressource : IDbEntity
    {
        public long? Id { get => throw new NotImplementedException(); }
        public PlanetType name { get; set; }
        [Range(0, int.MaxValue)]
        public int? lastQuantity { get; set; }
        public DateTime lastUpdate { get; set; }
    }

    public class DateAfterToday : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            var date = value as DateTime?;
            if (date != null)
            {
                return date >= DateTime.Now;
            }
            return false;
        }
    }
}
