/* Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3 */
Console.Clear();
Console.WriteLine("КАКОЕ КОЛИЧЕСТВО ЧИСЕЛ БУДЕТ ВВЕДЕНО ? ");
int a = int.Parse(Console.ReadLine());

int sum = 0;
Console.WriteLine("ВВЕДИТЕ ЧИСЛА ");
int[] array = new int[a];
for (int i = 0; i < array.Length; i++)
{
    array[i] = int.Parse(Console.ReadLine());
    if (array[i] > 0) sum += 1;
}
Console.WriteLine($"ВВЕДЕНО {sum} ЧИСЕЛ БОЛЬШЕ 0");