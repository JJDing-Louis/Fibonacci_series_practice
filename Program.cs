using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Fibonacci_series_practice
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();
            string input_num = string.Empty;
            string input_ans;
            Console.WriteLine("費氏數列");
            //string input_num;
            do
            {
                Console.Write("\n請輸入一個數字:");
                input_num = Console.ReadLine();
                stopwatch.Restart();
                Console.WriteLine($"==========================================\nList計算答案: {Fibonacci_list(int.Parse(input_num))}");
                Console.WriteLine($"List計算，執行時間: {stopwatch.ElapsedTicks}\n==========================================");
                stopwatch.Restart();
                Console.WriteLine($"Array計算答案: {Fibonacci_array(int.Parse(input_num))}");
                Console.Write($"Array計算，執行時間: {stopwatch.ElapsedTicks}\n\n請問是否繼續? (y/n) ");
                input_ans = Console.ReadLine();
            } while (input_ans.Equals("y"));

            ///List的資料結構版本
            long Fibonacci_list(int num)
            {
                List<long> list = new List<long>() { 0, 1 };
                long value;

                for (int i = 1; i < num; i++)
                {
                    value = list[i - 1] + list[i];
                    list.Add(value);
                }

                return list[num];
                stopwatch.Stop();
            }
            ///Array的資料結構的版本
            long Fibonacci_array(int num)
            {
                stopwatch.Restart();
                long[] array = new long[num + 2];
                array[0] = 0;
                array[1] = 1;
                for (int i = 0; i < num; i++)
                {
                    array[i + 2] = array[i] + array[i + 1];
                }

                return array[num];
                stopwatch.Stop();
            }
            ///不重複運算的版本
            /*
            Console.WriteLine("費氏數列");
            string ans;
            List<long> list = new List<long>() { 0, 1 };
            do
            {
                Console.Write("\n請輸入一個數字:");
                string input_num = Console.ReadLine();
                Console.WriteLine($"\n計算答案: {Fibonacci_list(int.Parse(input_num))}\n==========================================");
                Console.Write("請問是否繼續? (y/n) ");
                ans = Console.ReadLine();
            } while (ans == "y" ? true : false);

            long Fibonacci_list(int num)
            {
                if (num >= list.Count) { for (int i = list.Count; i < num + 1; i++) { list.Add(list[i - 2] + list[i - 1]); } }
                return list[num];
            }
            */
        }
    }
}