namespace _20241105_InterfacesTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");

            Print(null);

            Test1 c1 = new Test1();

            Console.ForegroundColor = ConsoleColor.Green;
            Print(c1);

            //Test2 c2 = new Test2(new double[] { 3.23, 98.72, 9.3 });
            Test2 c2 = new Test2(3.23, 98.72, 9.3);

            Console.ForegroundColor = ConsoleColor.Cyan;
            Print(c2);

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("foreach (double item in c2):");
            foreach (double item in c2)
            {
                Console.Write("{0} ", item);
            }
            Console.WriteLine();
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(" while (iter.MoveNext()):");
            IEnumerator<double> iter = c2.GetEnumerator();
            while (iter.MoveNext())
            {
                Console.Write("{0} ", iter.Current);
            }
            Console.WriteLine();
        }

        // use
        // c - інтерфейсне посилання
        public static void Print(IContainer c)
        {
            //if (c is null)    // RTTI
            if (c == null)
            {
                Console.WriteLine("Empty");
                return;
            }

            for (int i = 0; i < c.Size; i++)
            {
                Console.Write($"{c[i]} ");
            }
            Console.WriteLine();
        }
    }
}