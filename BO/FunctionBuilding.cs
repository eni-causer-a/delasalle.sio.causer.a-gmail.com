using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class FunctionBuilding : Building
    {
        public List<Action> Actions() { return null; }
        public override int? CellNb()
        {
            throw new NotImplementedException();
        }
    }
}
