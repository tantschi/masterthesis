namespace MathParserTK
{
	using System;

    class Program
    {
        static void Main(string[] args)
        {
			MathParser parser = new MathParser();
			System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();

			string s1 = "pi+5*5+5*3-5*5-5*3"; // "pi+5*5+5*3-5*5-5*3+1E1"
			string s2 = "sin(cos(tg(sh(ch(th(100))))))";
			bool isRadians = false;			

			sw.Start();
			double d1 = parser.Parse(s1, isRadians);
			double d2 = parser.Parse(s2, isRadians);
			sw.Stop();

			Console.WriteLine(d1); // 13.141592...
			Console.WriteLine(d2); // 0.0174524023974442
			Console.WriteLine(sw.ElapsedTicks);
			Console.ReadKey(true);
        }
    }
}
