using System;

namespace kalkulator
{
    class kalkulator
    {
        public static double DoOperation(double num1, double num2, string op)
        {
            double result = double.NaN;
            switch (op)
            {
                case "+":
                    Console.WriteLine($"Hasilnya: {num1} + {num2}= " + (num1 + num2));
                    break;
                case "-":
                    Console.WriteLine($"Hasilnya: {num1} - {num2}= " + (num1 - num2));
                    break;
                case "*":
                    Console.WriteLine($"Hasilnya: {num1} * {num2}= " + (num1 * num2));
                    break;
                case "/":
                    while (num2 == 0)
                    {
                        Console.WriteLine("Masukkan kecuali angka 0");
                        num2 = Convert.ToUInt32(Console.ReadLine());
                    }
                    Console.WriteLine($"Hasilnya: {num1} * {num2}= " + (num1 / num2));
                    break;
            }
            return result;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            bool endApp = false;
            Console.WriteLine("Percobaan kalkulator");
            Console.WriteLine("Masukkan angka pertama, dan ketik enter");
            while (!endApp)
            {
                string numInput1 = "";
                string numInput2 = "";
                double result = 0;

                Console.Write("masukkan angka dan tekan enter: ");
                numInput1 = Console.ReadLine();
                double cleanNum1 = 0;
                while (!double.TryParse(numInput1, out cleanNum1))
                {
                    Console.Write("Masukkan tidak valid, harus bernilai integer");
                    numInput1 = Console.ReadLine();
                }
                Console.Write("Masukkan angka kedua dan tekan enter");
                numInput2 = Console.ReadLine();
                double cleanNum2 = 0;
                while (!double.TryParse(numInput2, out cleanNum2))
                {
                    Console.Write("Masukkan tidak valid, harus bernilai integer");
                    numInput2 = Console.ReadLine();

                }

                Console.WriteLine("Pilih dulu :");
                Console.WriteLine("\t+ - Tambah");
                Console.WriteLine("\t- - Kurang");
                Console.WriteLine("\t* - Kali");
                Console.WriteLine("\t/ - Bagi");
                Console.Write("Pilihan ?");
                string op = Console.ReadLine();
                try
                {
                    result = kalkulator.DoOperation(cleanNum1, cleanNum2, op);
                    if (double.IsNaN(result))
                    {
                        Console.WriteLine("Operasi ini akan menghasilkan perhitungan error.\n");
                    }
                    else
                    {
                        Console.WriteLine("Hasilnya : {0:0.##}\n", result);
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Oh no! An exception occured trying to do the math.\n - Details: " + e.Message);
                }
                Console.Write("Press 'n' and Enter to close the app, or press any key: ");
                if (Console.ReadLine() == "n") endApp = true;
                Console.WriteLine("\n");

            }
            return;
        }
    }




}
