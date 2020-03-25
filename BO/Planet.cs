using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class Planet : IDbEntity 
    {
        public long? Id { get => throw new NotImplementedException(); }
        [StringLength(20, MinimumLength = 5)]
        public string name { get; set; }
        [Range(0, int.MaxValue)]
        public int? caseNumber { get; set; }

        [MaxRessources(ErrorMessage = "For a planet the number of ressources cant exceed 4")]
        public virtual List<Ressource> ressources { get; set; }
        public virtual List<Building> buildings { get; set; }

    }

    public class MaxRessources : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            var list = value as IList;
            if (list != null)
            {
                return list.Count <= 4;
            }
            return false;
        }
    }

}
