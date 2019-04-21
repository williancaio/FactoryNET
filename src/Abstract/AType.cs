namespace Factory.Abstract
{
    public abstract class AType
    {
        protected string Name { get; set; }

        public abstract void Action();

        public abstract void Print(string value);

        public string Type()
        {
            return "-----------------------------------------";
        }
    }
}
