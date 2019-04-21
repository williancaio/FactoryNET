using Factory.Abstract;
using System;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            AType type;
            
            type = Factory.Factory.Create(Enum.EType.TypeA);
            type.Action();

            type = Factory.Factory.Create(Enum.EType.TypeB);
            type.Action();

            type = Factory.Factory.Create(Enum.EType.TypeC);
            type.Action();


            Console.ReadLine();
        }
    }
}
