using System;

namespace консольный_калькулятор_для_Вики
{
    class Program
    {
        static int CountOfFirstNumber;
        static int CountOfSecondNumber;

        // Если что-то где-то не так перевёл или неправильно написал, то исправь)
        static void Main(string[] args)
        {
            WriteHelp();
            Console.WriteLine();
            Console.WriteLine("Введите выражение со знаком");
            string input = Console.ReadLine();
            if (input == "--help") WriteHelp(); // Вывод пояснительного сообщения
            //else if()
            else if (CheckNumber(input[0])) /*continue;*/ Console.WriteLine("чёт вы накасячили с первым числом");

        }

        static void WriteHelp()
        {
            Console.WriteLine("");
        }

        // Возвращает знак
        static void GetSign(string str)
        {
            // Инициализирую переменную, потому что ищу char в строке, а записывать char в 
            // не проинициализируванную переменную string нельзя.
            string answer = "";

            // Если первый символ не число, то выходит из метода
            if (CheckNumber(str[0])) return;

            // Ищу знак в строке
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == '-' && str[i + 1] == ' ' && CheckNumber(str[i + 1]))
                    answer += str[i];
            }
        }

        // Находит первые цифры чисел и записывает их в поля CountOfFirstNumber и CountOfSecondNumber.
        static void SetCountsOfNumbersInInputLine(string line)
        {
            for(int i = 0; i < line.Length; i++)
            {
                if (CheckNumber(line[i]))
                {
                    CountOfFirstNumber = i;
                    break;
                }
            }
            
            for(int i = CountOfFirstNumber++; i < line.Length; i++)
            {
                if(CheckNumber(line[i]))
                {
                    CountOfSecondNumber = i;
                    break;
                }
            }
        }
        
        // Возвращает true, если переданный символ - цифра.
        static bool CheckNumber(char simbol)
        {
            if (simbol == '0' || simbol == '1' || simbol == '2' || simbol == '3' || simbol == '4' ||
                simbol == '5' || simbol == '6' || simbol == '7' || simbol == '8' || simbol == '9')
                return true;
            else
                return false;
        }

        // Проверяет, нет ли в входящей строке символов
        static bool CheckNumber(string str)
        {
            char[] Symbols = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z',
                                'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z'};

            for(int i = CountOfFirstNumber; i < str.Length; i++)
            {
                if (str[i + 1] == ' ' || str[i + 1] == '-' || str[i + 1] == '+' || str[i + 1] == '/' || str[i + 1] == '*' || str[i + 1] == '!')
                    break;
                for(int j = 0; j < Symbols.Length; j++)
                {
                    if (str[i] == Symbols[j])
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}
