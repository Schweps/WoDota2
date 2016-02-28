using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WoDota2
{
    public class Log
    {
        public static void Update(List<Character> AllCharacters)
        {
            Console.Clear();
            Console.WriteLine("_____________________________");
            Console.WriteLine("Команда:");
            Console.WriteLine("Хп Паладинна:" + AllCharacters[0].HPP);
            Console.WriteLine("Хп Жреца:" + AllCharacters[2].HPP);
            Console.WriteLine("Хп Шамана :" + AllCharacters[4].HPP);
            Console.WriteLine("Хп Разбойника:" + AllCharacters[6].HPP);
            Console.WriteLine("_____________________________");
            Console.WriteLine("Команда противника:");
            Console.WriteLine("Хп Паладинна противника:" + AllCharacters[1].HPP);
            Console.WriteLine("Хп Жреца противника:" + AllCharacters[3].HPP);
            Console.WriteLine("Хп Шамана противника:" + AllCharacters[5].HPP);
            Console.WriteLine("Хп Разбойника противника:" + AllCharacters[7].HPP);

         

        }
    }
}
