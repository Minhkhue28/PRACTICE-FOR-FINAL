using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Numerics;

namespace PRACTICE_FOR_FINAL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int y;

            // Nhập y từ người dùng
            Console.Write("Enter y (from -5 to 5): ");
            while (!int.TryParse(Console.ReadLine(), out y) || y < -5 || y > 5)
            {
                Console.Write("Invalid input! Please enter y between -5 and 5: ");
            }

            // Tính x
            int x = y * y + 2 * y + 1;

            // In kết quả
            Console.WriteLine($"x = y^2 + 2y + 1 = {x}");
            //P1(); 


            //MATRIX 
            Console.WriteLine("Create matrix");
            Console.Write("The amount of rows: ");
            int rows;
            while (!int.TryParse(Console.ReadLine(), out rows))
            {
                Console.Write("Input rows again: ");
            }
            Console.Write("The amount of column: ");
            int columns;
            while (!int.TryParse(Console.ReadLine(), out columns))
            {
                Console.Write("Input columns again: ");
            }
            int[,] matrix = new int[rows, columns];
            P2(matrix, rows, columns);

            //print row, col 
            int pr;
            Console.Write("Row to print: ");
            string print_r = Console.ReadLine();
            while (!int.TryParse(print_r, out pr))
            {
                Console.Write("Printing row: ");
                print_r = Console.ReadLine();
            }
            Console.Write("Coloumn to print: ");
            string print_c = Console.ReadLine();
            int pc;
            while (!int.TryParse(print_c, out pc))
            {
                Console.Write("Printing column: ");
                print_c = Console.ReadLine();
            }
            PRINT_C_R(matrix, pr, pc);
        }

        static void P1()
        {
            Console.WriteLine("FIND SUM OF 2 NUMS");
            Console.Write("Input A: ");
            string a = Console.ReadLine();
            double number1;
            while (!double.TryParse(a, out number1))
            {
                Console.Write("Input a again: ");
            }

            Console.Write("Input B: ");
            string b = Console.ReadLine();
            double number2;
            while (!double.TryParse(b, out number2))
            {
                Console.Write("Input b again: ");
            }
            double sum = number1 + number2;
            Console.WriteLine($"SUM: {sum}");
        }

        //CREATE MATRIX 
        static void P2(int[,] matrix, int rows, int columns)
        {
            Random rnd = new Random();
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    matrix[i, j] = rnd.Next(0, 100);
                }

            }

            Console.WriteLine($"Matrix {rows} x {columns}: ");
            Print(matrix);

        }

        static void Print(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"{matrix[i, j],4}");
                }
                Console.WriteLine();
            }
        }

        static void PRINT_C_R(int[,] matrix, int pr, int pc)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                if (i == pr)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        Console.Write($"{matrix[i - 1, j],4} ");
                    }

                }
            }
            Console.WriteLine();

            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                if (i == pc)
                {
                    for (int j = 0; j < matrix.GetLength(0); j++)
                    {
                        Console.WriteLine($"{matrix[j, i - 1],4} ");
                    }

                }
            }
        }

        //7.	Nhập vào 1 dãy các số nguyên. In ra 1 số kết quả sau:  số lượng số âm, tổng số số âm,
        //số lượng số dương, tổng số dương trong mảng 
        static void dem()
        {
            Console.WriteLine("Nhap so luong phan tu cua day: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] nums = new int [n];
            Console.WriteLine("Nhap cac so nguyen:");
            for (int i = 0;i < n;i++)
            {
                Console.Write($"Number {i+1}: ");
                nums[i] = Convert.ToInt32(Console.ReadLine());
            }
            int am = 0;
            int duong = 0;
            int tongam = 0;
            int tongduong = 0; 

            foreach (int num in nums)
            {
                if (num < 0)
                {
                    am++;
                    tongam += tongam; 
                }
                else if  (num > 0)
                {
                    duong++;
                    tongduong += tongduong; 
                }
            }
            Console.Write($"So luong so am: {am}");
            Console.WriteLine($"Tong so am: {tongam}");
            Console.WriteLine($"So luong so duong: {duong}");
            Console.WriteLine($"Tong so duong: {tongduong}");
        }
    }
}
