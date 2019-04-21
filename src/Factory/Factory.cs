using Factory.Abstract;
using Factory.Enum;
using Factory.Types;
namespace Factory.Factory
{
    public static class Factory
    {
        public static AType Create(EType obj)
        {
            if(obj == EType.TypeA)
            {
                return new TypeA();
            }
            else if (obj == EType.TypeB)
            {
                return new TypeB();
            }else if(obj == EType.TypeC)
            {
                return new TypeC();
            }

            return null;
        }
    }
}
