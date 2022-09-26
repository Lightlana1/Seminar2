void Zadacha15()
    {
        Console.WriteLine("Введите номер дня недели: от 1 до 7");
        int number = Convert.ToInt32(Console.ReadLine());
        if(number == 6)
            {
                Console.WriteLine("Шестой день недели суббота - выходной");
            }
        if(number == 7)
            {
                Console.WriteLine("Седьмой день недели воскресенье - выходной");
            }
        else 
            {
                if(number == 1)
                {
                    Console.WriteLine("Первый день недели понедельник - рабочий день");
                }
                if(number == 2)
                {
                    Console.WriteLine("Второй день недели вторник - рабочий день");
                }
                if(number == 3)
                {
                    Console.WriteLine("Третий день недели среда - рабочий день");
                }
                if(number == 4)
                {
                    Console.WriteLine("Четвертый день недели четверг - рабочий день");
                }
                if(number == 5)
                {
                    Console.WriteLine("Пятый день недели пятница - рабочий день");
                }
            }
        if(number > 7 || number < 1)
        {
            Console.WriteLine("Вы ввели неверное число");
        }

    }

Zadacha15();