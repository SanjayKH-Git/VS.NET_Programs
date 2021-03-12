using System;


namespace sinx
{
	public class Program
	{

		public static void Main()
		{
			Console.Write("Enter Angle(in degree)= ");
			int x = int.Parse(Console.ReadLine()), sign = 1, n = 1;
			decimal res = 0;
			double rad = x * (Math.PI / 180.0);  //convert  Degree To Radian  

			for (long po = 1; n <= 10; po += 2)
			{
				res += (decimal)(sign * (Math.Pow(rad, po)) / fact(po));
				n += 1;
				sign *= -1;
         	}

			Console.Write("sin({0})= {1}", x, res);
		}
		static long fact(long p)
		{
			if (p >= 1)
				return (p * fact(p - 1));
			
			return 1;
		}


	}
}
