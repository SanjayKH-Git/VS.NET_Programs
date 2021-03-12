using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace CSharp_Shell
{

	public class Program
	{
		static void Upper(int[,] Matrix, int rows, int cols)
		{
			Console.WriteLine("\nUpper Triangular Matrix=");
			for (int i = 0; i < rows; i++)
			{
				for (int j = 0; j < cols; j++)
				{
					if (i > j)
						Console.Write("0 ");
					else
						Console.Write(Matrix[i, j] + " ");
				}
				Console.WriteLine();

			}
		}
		static void Lower(int[,] Matrix, int rows, int cols)
		{
			Console.WriteLine("\nLower Triangular Matrix = ");

			for (int i = 0; i < rows; i++)
			{
				for (int j = 0; j < cols; j++)
				{
					if (i < j)
						Console.Write("0 ");
					else
						Console.Write(Matrix[i, j] + " ");
				}
				Console.WriteLine();
			}
		}
		public static void Main()
		{

			Console.Write("Rows= ");
			int rows = int.Parse(Console.ReadLine());
			Console.Write("Cols= ");
			int cols = int.Parse(Console.ReadLine());
			int[,] Matrix = new int[rows, cols];
			for (int i = 0; i < rows; i++)
			{
				for (int j = 0; j < cols; j++)
				{
					Console.Write("Matrix[{0}][{1}]=", i, j);
					Matrix[i, j] = int.Parse(Console.ReadLine());
				}
			}
			Console.WriteLine("Matrix:");
			for (int i = 0; i < rows; i++)
			{
				for (int j = 0; j < cols; j++)
				{
					Console.Write(Matrix[i, j] + " ");
				}
				Console.WriteLine();
			}
			Upper(Matrix, rows, cols);
			Lower(Matrix, rows, cols);

		}
	}
}