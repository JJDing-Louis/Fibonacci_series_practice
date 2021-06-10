# Fibonacci_series_practice
Practice coding fibonacci_series with C#

# 費氏數列(費波那契數列)
1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233
![](https://i.imgur.com/PDm0s4m.png)

參考資料: [維基百科 - 費氏數列](https://zh.wikipedia.org/wiki/%E6%96%90%E6%B3%A2%E9%82%A3%E5%A5%91%E6%95%B0%E5%88%97)

# C# 實作方式
## List的資料結構
```cs    
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
}
```

## Array的資料結構
```cs    
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
}
```

## 不重複運算的版本
```cs  
Console.WriteLine("費氏數列");
string ans;
List<long> list = new List<long>() { 0, 1 };
do
{   Console.Write("\n請輸入一個數字:");
    string input_num = Console.ReadLine();
    Console.WriteLine($"\n計算答案: {Fibonacci_list(int.Parse(input_num))}\n==========================================");
    Console.Write("請問是否繼續? (y/n) ");
    ans = Console.ReadLine();
} while (ans == "y" ? true : false);

long Fibonacci_list(int num)
{   if (num >= list.Count){for (int i = list.Count; i < num+1; i++){list.Add(list[i - 2] + list[i-1]);}}
    return list[num];
}

```
