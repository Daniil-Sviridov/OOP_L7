﻿

/*
 * 
 * 1.Определить интерфейс IСoder, который полагает методы поддержки шифрования строк. 
    В интерфейсе объявляются два метода Encode() и Decode(), используемые для шифрования и дешифрования строк. 
    Создать класс ACoder, реализующий интерфейс ICoder. Класс шифрует строку посредством сдвига каждого символа на одну «алфавитную» позицию выше. 
    (В результате такого сдвига буква А становится буквой Б). Создать класс BCoder, реализующий интерфейс ICoder. 
    Класс шифрует строку, выполняя замену каждой буквы, стоящей в алфавите на i-й позиции, на букву того же регистра, расположенную в алфавите на i-й позиции с конца алфавита. 
    (Например, буква В заменяется на букву Э. Написать программу, демонстрирующую функционирование классов).
 *
 */

namespace OOP_L7
{
    public class Program
    {
        static void Main(string[] args)
        {

            ACoder coder = new ACoder();

            string str = "В Санкт-Петербурге прошли обыски из-за уборки снега";
            coder.Encode(ref str);
            Console.WriteLine(str);

            coder.Decode(ref str);
            Console.WriteLine(str);

            Console.WriteLine();

            BCoder coderb = new BCoder();

            string strB = "Что делать, если QR-код недействителен";

            coderb.Encode(ref strB);
            Console.WriteLine(strB);

            coderb.Decode(ref strB);
            Console.WriteLine(strB);

        }
    }
}
