using Factory.Abstract;
using System;

namespace Factory.Types
{
    public class TypeC : AType
    {
        public TypeC()
        {
            this.Name = "TypeC";
        }

        public override void Action()
        {
            Console.WriteLine("Action Type C");
        }

        public override void Print(string value)
        {
            Console.WriteLine("Type C - " + value);
        }
    }
}
