class Task2
{
    /* Задание 2
Считать 6 строк и заполнить ими массив. Вывести массив на экран в обратном порядке. */

    static void Main()
    {
        int[] Array = new int [6];
        for (int i = 0; i < Array.Length; i++)
        {
            Array[i] = Convert.ToInt32(Console.ReadLine());
        }
        for (int i = 5; i >= 0; i--)
        {
            Console.WriteLine(Array[i]);
        }
    }
}