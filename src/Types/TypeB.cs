using Factory.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Types
{
    public class TypeB : AType
    {
        public TypeB()
        {
            this.Name = "TypeB";
        }

        public override void Action()
        {
            Console.WriteLine("Action Type B");
        }

        public override void Print(string value)
        {
            Console.WriteLine("Type B - " + value);
        }
    }
}
