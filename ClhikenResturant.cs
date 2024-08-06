using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Mnager
{
    public class ChikenResturant : Resturant
    {
        public override Burger CreateBurger()
        {
            return new ChikenBurger();
        }
    }
}
