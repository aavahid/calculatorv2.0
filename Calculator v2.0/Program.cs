
Console.WriteLine("Kalkulyator v2.0'a xos gelmisiniz");
Console.WriteLine(" ");
Console.WriteLine("1. Toplama");
Console.WriteLine("2. Cixarma");
Console.WriteLine("3. Vurma");
Console.WriteLine("4. Bolme");
Console.WriteLine("5. Proqramdan cixis");
Console.WriteLine(" ");

bool exit = false;

while (!exit)
{
    Console.Write("1-5 arasi seciminizi edin: ");
    int choice = Convert.ToInt32(Console.ReadLine());

    switch (choice)
    {
        case 1:
            Addition();
            break;
        case 2:
            Subtraction();
            break;
        case 3:
            Multiplication();
            break;
        case 4:
            Division();
            break;
        case 5:
            Console.WriteLine(" ");
            Console.WriteLine("Proqramdan cixis ugurla alindi. Sagolun.");
            exit = true;
            break;
        default:
            Console.WriteLine("Sehv secim etdiniz xahis edirik bir daha secin.");
            break;
    }

    Console.WriteLine();
}
    

    static void Addition()
{
    Console.Write("Nece ededin toplanacinin miqdarini daxil edin: ");
    int count = Convert.ToInt32(Console.ReadLine());

    double sum = 0;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"Ededi daxil edin #{i + 1}: ");

        double num = Convert.ToDouble(Console.ReadLine());
        sum += num;
    }

    Console.WriteLine($"Netice: {sum}");
}

static void Subtraction()
{
    Console.Write("Nece ededin cixilacaqinin miqdarini daxil edin: ");
    int count = Convert.ToInt32(Console.ReadLine());

    if (count > 0)
    {
        Console.Write("Ilk ededi daxil edin: ");
        double result = Convert.ToDouble(Console.ReadLine());

        for (int i = 1; i < count; i++)
        {
            Console.Write($"Ededi daxil edin #{i + 1}: ");
            double num = Convert.ToDouble(Console.ReadLine());
            result -= num;
        }

        Console.WriteLine($"Netice: {result}");
    }
    else
    {
        Console.WriteLine("Sehv daxil etdiniz. Xahis edirik daxil edilen reqemi yoxlayib bir daha daxil edin");
    }
}

static void Multiplication()
{
    Console.Write("Vurulacaq ededlerin miqdarini daxil edin: ");
    int count = Convert.ToInt32(Console.ReadLine());

    double product = 1;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"Ededi daxil edin #{i + 1}: ");
        double num = Convert.ToDouble(Console.ReadLine());
        product *= num;
    }

    Console.WriteLine($"Netice: {product}");
}

static void Division()
{
    Console.Write("Bolunecek ededlerin miqdarini daxil edin: ");
    int count = Convert.ToInt32(Console.ReadLine());

    if (count > 0)
    {
        Console.Write("Ilk ededi xadil edin: ");
        double result = Convert.ToDouble(Console.ReadLine());

        for (int i = 1; i < count; i++)
        {
            Console.Write($"Ededi daxil edin#{i + 1}: ");
            double num = Convert.ToDouble(Console.ReadLine());

            if (num != 0)
            {
                result /= num;
            }
            else
            {
                Console.WriteLine("Sehv daxil etdiniz. Xahis edirik daxil edilen reqemi yoxlayib bir daha daxil edin.");
                return;
            }
        }

        Console.WriteLine($"Netice: {result}");
    }
    else
    {
        Console.WriteLine("Sehv Daxil edilme.");
    }
}