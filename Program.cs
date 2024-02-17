namespace BoxingCasting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var t1 = new Thing();
            t1.data = 42;
            Console.WriteLine($"Thing with an integer: {t1.Process(42)}");

            var t2 = new Thing();
            t2.data = "apple";
            Console.WriteLine($"Thing with a string: {t2.Process("apple")}");



            var gt1 = new GenericThing<int>();
            gt1.data = 42;
            Console.WriteLine($"GenericThing with an integer {gt1.Process(42)}");


            var gt2 = new GenericThing<string>();
            gt2.data = "apple";
            Console.WriteLine($"GenericThing with a string {gt2.Process("apple")}");

            object a1 = 1;
            object a2 = 1;

            if (a1 == a2)
            {
                Console.WriteLine("Equals");

            }
            else
            { 
                Console.WriteLine("Not Equals"); 
            }


        }
    }
}
