using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace WoDota2
{
    class Program
    {
        static void Main(string[] args)
        {
            Character Pul1 = new Puladin
               (800, 400, 80);
            Character Pul_enemy = new Puladin
            (800, 400, 80);

            Character Pr1 = new Priest
            (400, 900, 30);
            Character Pr_enemy = new Priest
            (400, 900, 30);

            Character R1 = new Rogue
            (360, 500, 100);
            Character R_enemy = new Rogue
            (360, 500, 100);

            Character Sh1 = new Rogue
            (500, 700, 50);

            Character sh_enemy = new Rogue
            (500, 700, 50);
            List<Character> AllCharacters=new List<Character>();
            AllCharacters.Add(Pul1);
            AllCharacters.Add(Pul_enemy);
            AllCharacters.Add(Pr1);
            AllCharacters.Add(Pr_enemy);
            AllCharacters.Add(Sh1);
            AllCharacters.Add(sh_enemy);
            AllCharacters.Add(R1);
            AllCharacters.Add(R_enemy);
            {
                Console.WriteLine("Приветствую в игре WoDota");
                Console.WriteLine(" для продолжениря нажмите любую клавишу");
                Console.ReadKey();
                while (Pul1.HPP + Pr1.HPP + Sh1.HPP + R1.HPP > 0 && Pul_enemy.HPP + Pr_enemy.HPP + sh_enemy.HPP + R_enemy.HPP > 0)
                {
                    
                    Console.WriteLine("вы ходите по очереди одним из четырех персонажей которые перечисленны ниже");
                    Console.WriteLine("1.Паладин 2. Жрец 3.Шаман 4. Разбойник");


                    // выбор пероснажа
                    string a = Console.ReadLine();
                    switch (a)
                    {
                        case "1":
                            Console.WriteLine("паладин с DMG: 80");
                            Console.WriteLine("кого вы хотите атаковать?");
                            switch (a)
                            {
                                case "1":
                                    Pul1.target = Pul_enemy;
                                    Pul1.Attack();
                                    break;
                                case "2":
                                    Pul1.target = Pr_enemy;
                                    Pul1.Attack();
                                    break;
                                case "3":
                                    Pul1.target = sh_enemy;
                                    Pul1.Attack();
                                    break;
                                case "4":
                                    Pul1.target = R_enemy;
                                    Pul1.Attack();
                                    break;

                            }
                            break;
                        case "2":
                            Console.WriteLine("Жрец c DMG: 30 и XPP: 400");
                            switch (a)
                            {
                                case "1":
                                    Pr1.target = Pul_enemy;
                                    Pr1.Attack();
                                    break;
                                case "2":
                                    Pr1.target = Pr_enemy;
                                    Pr1.Attack();
                                    break;
                                case "3":
                                    Pr1.target = sh_enemy;
                                    Pr1.Attack();
                                    break;
                                case "4":
                                    Pr1.target = R_enemy;
                                    Pr1.Attack();
                                    break;



                            }
                            break;
                        case "3":
                            Console.WriteLine("Шаман с DMG: 50 и XPP: 500");
                            switch (a)
                            {
                                case "1":
                                    Sh1.target = Pul_enemy;
                                    Sh1.Attack();
                                    break;
                                case "2":
                                    Sh1.target = Pr_enemy;
                                    Sh1.Attack();
                                    break;
                                case "3":
                                    Sh1.target = sh_enemy;
                                    Sh1.Attack();
                                    break;
                                case "4":
                                    Sh1.target = R_enemy;
                                    Sh1.Attack();
                                    break;



                            }
                            break;
                        case "4":
                            Console.WriteLine("Разбойник с DMG: 100 и XPP: 360");
                            Console.WriteLine("кого атаукет!");
                            a = Console.ReadLine();
                            switch (a)
                            {
                                case "1":
                                    R1.target = Pul_enemy;
                                    R1.Attack();
                                    break;
                                case "2":
                                    R1.target = Pr_enemy;
                                    R1.Attack();
                                    break;
                                case "3":
                                    R1.target = sh_enemy;
                                    R1.Attack();
                                    break;
                                case "4":
                                    R1.target = R_enemy;
                                    R1.Attack();
                                    break;



                            }
                            break;


                    }


                    String l = Console.ReadLine();
                    switch (l)
                    {
                        case "1":
                            Console.WriteLine("паладин с DMG: 80 и XPP: 800");
                            switch (l)
                            {
                                case "1":
                                    Pul_enemy.target = Pul1.target;
                                    Sh1.Attack();
                                    break;
                                case "2":
                                    Pul_enemy.target = Pr1;
                                    Pul_enemy.Attack();
                                    break;
                                case "3":
                                    Pul_enemy.target = Sh1;
                                    Pul_enemy.Attack();
                                    break;
                                case "4":
                                    Pul_enemy.target = R1;
                                    Pul_enemy.Attack();
                                    break;

                            }
                            break;
                        case "2":
                            Console.WriteLine("Жрец c DMG: 30 и XPP: 400");
                            switch (l)
                            {
                                case "1":
                                    Pr_enemy.target = Pul1;
                                    Pr_enemy.Attack();
                                    break;
                                case "2":
                                    Pr_enemy.target = Pr1;
                                    Pr_enemy.Attack();
                                    break;
                                case "3":
                                    Pr_enemy.target = Sh1;
                                    Sh1.Attack();
                                    break;
                                case "4":
                                    Pr_enemy.target = R1;
                                    Pr_enemy.Attack();
                                    break;



                            }
                            break;
                        case "3":
                            Console.WriteLine("Шаман с DMG: 50 и XPP: 500");
                            switch (l)
                            {
                                case "1":
                                    sh_enemy.target = Pul1;
                                    sh_enemy.Attack();
                                    break;
                                case "2":
                                    sh_enemy.target = Pr1;
                                    sh_enemy.Attack();
                                    break;
                                case "3":
                                    sh_enemy.target = Sh1;
                                    Sh1.Attack();
                                    break;
                                case "4":
                                    sh_enemy.target = R1;
                                    sh_enemy.Attack();
                                    break;



                            }
                            break;
                        case "4":
                            Console.WriteLine("Разбойник с DMG: 100 и XPP: 360");
                            Console.WriteLine("кого атаукет!");
                            l = Console.ReadLine();
                            switch (l)
                            {
                                case "1":
                                    R_enemy.target = Pul1;
                                    R1.Attack();
                                    break;
                                case "2":
                                    R_enemy.target = Pr1;
                                    R_enemy.Attack();
                                    break;
                                case "3":
                                    R_enemy.target = Sh1;
                                    R_enemy.Attack();
                                    break;
                                case "4":
                                    R_enemy.target = R1;
                                    R_enemy.Attack();
                                    break;



                            }
                            break;


                    }
                }




                String s = Console.ReadLine();
                Console.WriteLine("кого атаукет!");
                s = Console.ReadLine();
                switch (s)
                {
                    case "1":
                        Console.WriteLine("паладин с DMG: 80 и XPP: 800");
                        break;
                    case "2":
                        Console.WriteLine("Жрец c DMG: 30 и XPP: 400");
                        break;
                    case "3":
                        Console.WriteLine("Шаман с DMG: 50 и XPP: 500");
                        break;
                    case "4":
                        Console.WriteLine("Разбойник с DMG: 100 и XPP: 360");
                        break;



                }
                Console.WriteLine("Ход комаенды противника!");

                // победа Тьмы
                bool Q = false;
                // победа света
                bool P = false;
                Console.ReadLine();
                while (Q == false && P == false)
                {
                    Console.ReadLine();
                    if (Q == false)
                        Console.WriteLine("выиграла ваша команда. Поздравляю!");
                    else
                        Console.WriteLine("выиграла команада света и вы проиграли. Но не растраивайтесь, потренеруйтесь и вы обязательно выиграйте!");



                }
                Log.Update(AllCharacters);



            }
        }
    }
}

