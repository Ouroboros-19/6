class Program
{
    static void Main()
    {
        Random r = new Random();
        int a = 20;
        int[] mas = new int[a];
        int znak = 0, znakPredid = 0, b, k = 0;
        for (int i = 0; i < a; i++)
        {
            mas[i] = r.Next(-3, 3);
            if (mas[i] < 0) Console.ForegroundColor = ConsoleColor.Green;
            if (mas[i] > 0) Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("{0,3}", mas[i]);
            Console.ForegroundColor = ConsoleColor.White;
        }
        Console.WriteLine();
        while (true)
        {
            for (int i = 0; i < a - 1; i++)
                if (mas[i] >= 0 && mas[i + 1] < 0 || mas[i] > 0 && mas[i + 1] == 0)
                {
                    b = mas[i];
                    mas[i] = mas[i + 1];
                    mas[i + 1] = b;
                }

            k = 0;
            if (mas[0] < 0) znakPredid = -1;
            if (mas[0] == 0) znakPredid = 0;
            if (mas[0] > 0) znakPredid = 1;
            for (int i = 1; i < a; i++)
            {
                if (mas[i] < 0) znak = -1;
                if (mas[i] == 0) znak = 0;
                if (mas[i] > 0) znak = 1;
                if (znakPredid <= znak) k++;
                else break;
                znakPredid = znak;
            }
            if (k > a - 2)
                break;
            for (int ii = 0; ii < a; ii++)
            {
                if (mas[ii] < 0) Console.ForegroundColor = ConsoleColor.Green;
                if (mas[ii] > 0) Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("{0,3}", mas[ii]);
                Console.ForegroundColor = ConsoleColor.White;
            }
            Console.WriteLine();
        }
        for (int i = 0; i < a; i++)
        {
            if (mas[i] < 0) Console.ForegroundColor = ConsoleColor.Green;
            if (mas[i] > 0) Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("{0,3}", mas[i]);
            Console.ForegroundColor = ConsoleColor.White;
        }
        Console.WriteLine();
        Console.WriteLine("");
        Console.WriteLine("Повтор?( enter - да; люб. др. клавиша - нет )");
        string povtor = Convert.ToString(Console.ReadLine());
        if (povtor == "")
            Main();
    }
}