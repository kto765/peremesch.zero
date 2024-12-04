using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите числа через пробел:");
        string input = Console.ReadLine();

        // Преобразуем строку в массив чисел
        string[] parts = input.Split(' ');
        int[] nums = new int[parts.Length];

        try
        {
            for (int i = 0; i < parts.Length; i++)
            {
                nums[i] = int.Parse(parts[i]);
            }

            MoveZeroes(nums);

            Console.WriteLine("Результат:");
            PrintArray(nums);
        }
        catch (FormatException)
        {
            Console.WriteLine("Ошибка: Введите корректные целые числа");
        }
        catch (OverflowException)
        {
            Console.WriteLine("Ошибка: Одно из введенных чисел слишком велико или слишком мало");
        }
    }

    static void MoveZeroes(int[] nums)
    {
        int index = 0;

        // Перемещаем ненулевые элементы
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] != 0)
            {
                nums[index] = nums[i];
                index++;
            }
        }

        // Заполняем оставшиеся позиции нулями
        for (int i = index; i < nums.Length; i++)
        {
            nums[i] = 0;
        }
    }

    static void PrintArray(int[] nums)
    {
        for (int i = 0; i < nums.Length; i++)
        {
            Console.Write(nums[i] + " ");
        }
        Console.WriteLine(); // Добавляем новую строку после вывода
    }
}
