namespace HW_1;
class Program
{
    static void Main(string[] args)
    {

        if (args.Length == 3)
        {

            int result = 0;
            int num1 = int.Parse(args[0]);
            string operation = args[1];
            int num2 = int.Parse(args[2]);

            if (operation == "+")
            {
                result = num1 + num2;
            }
            else if (operation == "-")
            {
                result = num1 - num2;
            }
            else if (operation == "/")
            {
                result = num1 / num2;
            }
            else if (operation == "x")
            {
                result = num1 * num2;
            }
            Console.WriteLine($"Результат: {num1} {operation} {num2} = {result}");
        }
        else
            Console.WriteLine("Введите: число знак(+ - / x) число");

    }
}

