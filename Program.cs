//1.Palindrome Tekshiruvi:
Console.WriteLine("Satr kiriting=> ");
string str = Console.ReadLine();
bool isPalindrome = true;
for (int i = 0; i < str.Length / 2; i++)
{
    if (str[i] != str[str.Length - i - 1])
    {
        isPalindrome = false;
        break;
    }
}
if (isPalindrome)
{
    Console.WriteLine("Palindrom");
}
else
{
    Console.WriteLine("Palindrom emas");
}
Console.WriteLine();

//2. Temperatura o'girish:
Console.Write("Temperaturani kiriting (Selsiyus)=> ");
double celsius = Convert.ToDouble(Console.ReadLine());
double fahrenheit;
double kelvin;
switch (celsius)
{
    case >= -273.15:
        fahrenheit = celsius * 9 / 5 + 32;
        kelvin = celsius + 273.15;
        Console.WriteLine($"Fahrenheit: {fahrenheit}");
        Console.WriteLine($"Kelvin: {kelvin}");
        break;
    default:
        Console.WriteLine("Noto'g'ri temperatur kiritdingiz!");
        break;
}
Console.WriteLine();

//3. Sonlarni tartiblash:
Console.Write("Sonlarni kiriting (bo'sh joy bilan ajratilgan)=>  ");
string son = Console.ReadLine();
string[] numbers = son.Split(' ');
int[] array = new int[numbers.Length];
for (int i = 0; i < numbers.Length; i++)
{
    array[i] = Convert.ToInt32(numbers[i]);
}
Console.WriteLine("Tartiblangan qator:");
switch (array.Length)
{
    case 0:
        Console.WriteLine("Kiritilgan sonlar yo'q.");
        break;
    case 1:
        Console.WriteLine(array[0]);
        break;
    default:
        Array.Sort(array);
        foreach (int number in array)
        {
            Console.Write(number + " ");
        }
        Console.WriteLine();
        break;
}
Console.WriteLine("Teskari tartib:");
switch (array.Length)
{
    case 0:
        Console.WriteLine("Kiritilgan sonlar yo'q.");
        break;
    case 1:
        Console.WriteLine(array[0]);
        break;
    default:
        Array.Sort(array);
        Array.Reverse(array);
        foreach (int number in array)
        {
            Console.Write(number + " ");
        }
        Console.WriteLine();
        break;
}
Console.WriteLine();

//4. Berilgan matnning simvol sanasini hisoblash: 
Console.Write("Matn kiriting=> ");
string matn = Console.ReadLine();
Dictionary<char, int> characterCount = new Dictionary<char, int>();
foreach (char c in matn)
{
    if (characterCount.ContainsKey(c))
    {
        characterCount[c]++;
    }
    else
    {
        characterCount[c] = 1;
    }
}
Console.WriteLine("Matndagi simvollar va ularning necha marta qaytarilgani:");
foreach (KeyValuePair<char, int> entry in characterCount)
{
    Console.WriteLine($"Simvol: {entry.Key}: {entry.Value} marta,");
}