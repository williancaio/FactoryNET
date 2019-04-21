using Factory.Abstract;
using System;

namespace Factory.Types
{
    public class TypeA : AType
    {
        public TypeA()
        {
            this.Name = "TypeA";
        }

        public override void Action()
        {
            Console.WriteLine("Action Type A");
        }

        public override void Print(string value)
        {
            Console.WriteLine("Type A - " + value);
        }
    }
}