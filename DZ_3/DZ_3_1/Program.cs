using System;

namespace DZ_3
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Правила игры:
             * Загадывается число от 12 до 120, причём случайным образом. Назовём его gameNumber.
             * Игроки по очереди выбирают число от одного до четырёх. Пусть это число обозначается как userTry.
             * UserTry после каждого хода вычитается из gameNumber, а само gameNumber выводится на экран.
             * Если после хода игрока gameNumber равняется нулю, то походивший игрок оказывается победителем.
             * 
             * Перед началом игры вам необходимо вывести её правила на экран. После того как игроки
             * ознакомились с правилами, необходимо сделать так, чтобы игроки могли представиться. Каждый
             * игрок должен видеть, когда его ход, а когда ход оппонента, поэтому перед ходом игрока
             * выводится его имя и приглашение к вводу. И, само собой, после окончания игры стоит поздравить
             * победителя и предложить реванш.
            */

            Random rand = new Random();

            int gameNumber;
            string user1;
            string user2;
            int userTry;

            Console.WriteLine("Провила игры: \nЗагадывается число \nИгрокам необходимо ввести чило от 1 до 4" +
                                "\nВведеное число будет отниматься от загаданного" +
                                "\nЕсли после хода игрока загаданное чило равно 0, то игрок побеждает.");

            Console.Write("\nВведите имя первого игрока: ");
            user1 = Console.ReadLine();

            Console.Write("\nВведите имя второго игрока: ");
            user2 = Console.ReadLine();

            while (true)
            {
                gameNumber = rand.Next(12, 121);
                Console.WriteLine($"\nНачальное число {gameNumber}");
                while (gameNumber > 0)
                {
                    Console.WriteLine($"\nИгрок {user1} введите число от 1 до 4");
                    userTry = Convert.ToInt32(Console.ReadLine());

                    if (4 < userTry || userTry < 1)
                    {
                        Console.WriteLine("\nВы нарушили правила игры, переход хода");
                    }
                    else
                    {
                        gameNumber -= userTry;

                        if (gameNumber < 0)
                        {
                            Console.WriteLine($"\nВы нарушили правила игры, переход хода");
                            gameNumber += userTry;
                        }
                        if (gameNumber == 0)
                        {
                            Console.WriteLine($"\nИгрок {user1} победил");
                            Console.ReadKey();
                            break;
                        }
                        Console.WriteLine($"\nТекущее число {gameNumber}");
                    }

                    Console.WriteLine($"\nИгрок {user2} введите число от 1 до 4");
                    userTry = Convert.ToInt32(Console.ReadLine());

                    if (4 < userTry || userTry < 1)
                    {
                        Console.WriteLine("\nВы нарушили правила игры, переход хода");
                    }
                    else
                    {
                        gameNumber -= userTry;

                        if (gameNumber < 0)
                        {
                            Console.WriteLine($"\nВы нарушили правила игры, переход хода");
                            gameNumber += userTry;
                        }
                        if (gameNumber == 0)
                        {
                            Console.WriteLine($"\nИгрок {user2} победил");
                            Console.ReadKey();
                            break;
                        }
                        Console.WriteLine($"\nТекущее число {gameNumber}");
                    }
                }
                Console.WriteLine("Вы хотите продолжить?: y - да");
                var userInput = Console.ReadKey();
                if (userInput.KeyChar != 'Y' && userInput.KeyChar != 'y')
                {
                    break;
                }
            }
        }
    }
}
