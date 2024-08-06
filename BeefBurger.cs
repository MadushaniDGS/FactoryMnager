using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Mnager
{
    public class BeefBurger : Burger
    {
        public override void Prepare()
        {
            Console.WriteLine("I'm preparing Beef Burger");
        }
    }
}
