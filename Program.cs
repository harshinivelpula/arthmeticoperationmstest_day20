namespace ArthmeticOperation
{
    class Program
    {
        public static void Main(string[] args)
        {
            Add add = new Add();
            Add.ReferenceEquals(add, add);

            UnitTest1 unitTest1 = new UnitTest1();
            UnitTest1.ReferenceEquals(unitTest1, add);
        }
    }

    internal class UnitTest1
    {
    }
}