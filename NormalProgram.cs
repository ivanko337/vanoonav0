using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace консольный_калькулятор_для_Вики
{
    class NormalProgram
    {
        static int StartIndexOfOirstNumber;
        static int LengthOfFirstNumber;
        static int StartIndexOfSecondNumber;
        static int LengthOfSecondNumber;

        static bool CheckInput(string line)
        {
            bool answer = true;

            // Проверяет, нет ли во входящеё строке букв
            for (int i = 0; i < line.Length; i++)
            {
                if (CheckInputLine(line[i])) answer = false; 
            }

            return answer;
        }

        // Проверяет, нет ли в входящей строке символов
        static bool CheckInputLine(char symb)
        {
            bool answer = true;

            char[] Symbols = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z',
                                'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z',
                                'а', 'б', 'в', 'г', 'д', 'е', 'ё', 'ж', 'з', 'и', 'й', 'к', 'л', 'м', 'н', 'о', 'п', 'р', 'с', 'т', 'у', 'ф', 'х', 'ц', 'ч', 'ш', 'щ', 'ъ', 'ы', 'ь', 'э', 'ю', 'я',
                                'А', 'Б', 'В', 'Г', 'Д', 'Е', 'Ё', 'Ж', 'З', 'И', 'Й', 'К', 'Л', 'М', 'Н', 'О', 'П', 'Р', 'С', 'Т', 'У', 'Ф', 'Х', 'Ц', 'Ч', 'Ш', 'Щ', 'Ъ', 'Ы', 'Ь', 'Э', 'Ю', 'Я',
                                '@', '$', '&', '(', ')', '?', '|', '"', '\'', ';', '~', '`'};

            // В случае, если входящий символ не буква, то возвращается true, иначе - false
            for (int i = 0; i < Symbols.Length; i++)
            {
                if (symb == Symbols[i])
                    answer = false;
            }

            return answer;
        }
    }
}
