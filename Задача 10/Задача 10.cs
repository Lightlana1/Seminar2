void Zadacha10()
    {
        Console.WriteLine("Введите трехзначное число: ");
        int number = Convert.ToInt32(Console.ReadLine());
    
        if (number < 1000 && number > 99)
            {
                  int tens = number / 10 % 10;
                  Console.WriteLine(""+tens);
            }
        else
            {
                Console.WriteLine("Чиcло введено неверно");
            }

    }

Zadacha10();