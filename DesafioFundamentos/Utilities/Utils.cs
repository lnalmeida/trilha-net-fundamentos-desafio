namespace DesafioFundamentos.Utilities;

public class Utils
{
    public static string ReadLimitAndUpperInput(int maxLength)
    {
        string input = String.Empty;
        while (true)
        {
            ConsoleKeyInfo keyInfo = Console.ReadKey(intercept: true);

            if ( (keyInfo.Key == ConsoleKey.Enter))
            {
                break;
            }
            else if (input.Length < maxLength)
            {
                char upperChar = Char.ToUpper(keyInfo.KeyChar);
                Console.Write(upperChar);
                input += upperChar;
            }
        }

        return input;
    }
}