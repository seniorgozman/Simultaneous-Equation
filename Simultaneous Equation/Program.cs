namespace Simultaneous_Equation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Solve for simultaneous equation");
            Console.WriteLine("Enter X1, the coeffient of x in equation one ");
            Console.WriteLine("Enter Y1, the coeffient of y in equation one");
            Console.WriteLine("Enter Z1, the constant in equation one");
            Console.WriteLine("Enter X2, the coeffient of x in equation two");
            Console.WriteLine("Enter Y2, the coeffient of y in equation two");
            Console.WriteLine("Enter Z2, the constant in equation two");
            var eq = int.Parse (Console.ReadLine());
            var go = int.Parse (Console.ReadLine());
            var goz = int.Parse (Console.ReadLine());
            var ma = int.Parse (Console.ReadLine());
            var man = int.Parse (Console.ReadLine());
            var sen = int.Parse (Console.ReadLine());
            // The Makaty wants to test my code..... Extra extra
            var chi = man * eq;
            var doz = man * go;
            var zola = man * goz;
            var odi = go * ma;
            var dija = go * man;
            var melo = go * sen;
            var berr = chi - odi;
            var berry = zola - melo;
            var makaty = berry / berr;
            var fra = ma * go;
            var amarachi = ma * goz;
            var fav = eq * man;
            var ebere = eq * sen;
            var dodo = fra - fav;
            var ony = amarachi - ebere;
            var deber = ony / dodo;
            Console.WriteLine("The value of Y is");
            Console.WriteLine(deber);
            Console.WriteLine("the value of X is");
            Console.WriteLine(makaty);

        }
    }
}
