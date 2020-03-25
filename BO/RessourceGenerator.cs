using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public abstract class RessourceGenerator : Building   
    {
        public abstract List<Ressource> RessourceBySecond();
        public override int? CellNb()
        {
            throw new NotImplementedException();
        }
    }
}
