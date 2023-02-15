string input;

int solveFormula()
{
    int result = 0;
    do
    {
        if (input == " ")
        {
            result = 0;
        }
        else if (!(input.Contains("+") || input.Contains("-")))
        {
            result = int.Parse(input);
        }
        else if (input.Contains("+"))
        {
            int x = input.IndexOf("+");

            int left = int.Parse(input.Substring(0, x));
            int right = int.Parse(input.Substring(x + 1));

            result = left + right;
            input = input.Substring(x + 1);
            
        }
        else if (input.Contains("-"))
        {
            int x = input.IndexOf("-");

            int left = int.Parse(input.Substring(0, x));
            int right = int.Parse(input.Substring(x + 1));

            result = left - right;
            input = input.Substring(x + 1);

        }
    } while (input.Contains("+") || input.Contains("-"));
    return result;
}

System.Console.WriteLine("Please enter a Formula");
input = Console.ReadLine()!;
input = input.Replace("  ", "");
int result=solveFormula();
System.Console.WriteLine("your result is " + result);