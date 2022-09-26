void Zadacha13()
    {
        Console.WriteLine("Введите число: ");
        int number = Convert.ToInt32(Console.ReadLine());
        number = Math.Abs(number);
        if(number >= 100)
            {
                string str = number.ToString();
                Console.WriteLine(str[2]);
            }
        else
            {
                Console.WriteLine("Третьей цифры нет");
            }

    }

Zadacha13();