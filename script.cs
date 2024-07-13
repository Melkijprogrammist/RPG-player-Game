using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_play
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Создание переменных
            string PlayerName;
            int playerHealth = 100;
            int playerDamaged = 10;
            int enemyHealth = 50;
            int enemyDamaged = 5;

            Console.WriteLine("Добро пожаловать, в консольную игру!");
            Console.WriteLine("Введите свой ник:");
            PlayerName = Console.ReadLine();

            Console.WriteLine($"Добро пожаловать,{PlayerName}!");
            // Цикл здоровья при аттаке противника
            while (playerHealth > 0 && enemyHealth > 0)
            {
                Console.WriteLine($"Здоровье игрока, {playerHealth}!");
                Console.WriteLine($"Здоровье врага, {enemyHealth}");

                Console.WriteLine("Выбирите ваши действия:");
                Console.WriteLine("Аттака");
                Console.WriteLine("Бег");
                int choise = int.Parse(Console.ReadLine());

                if (choise == 2)
                {
                    Console.WriteLine("Вас аттаковал Враг!");
                    enemyHealth -= enemyDamaged;
                    Console.WriteLine($"Враг может быть {enemyDamaged} опасен!");

                    Console.WriteLine("Враг аттаковал вас!");
                    playerHealth -= enemyDamaged;
                    Console.WriteLine($"Вы можете быть{enemyDamaged} опасны");
                }
                else if (choise == 2)
                {
                    Console.WriteLine("Вы убежали от врага");
                    break;
                }
            }
            if (playerHealth > 0)
            {
                Console.WriteLine("Вы победили врага! Отлично!");
            }
            else
            {
                Console.WriteLine("Вы упустили врага! Вы проиграли!");
            }
            Console.WriteLine("Спасибо за игру!");
        }
    }
}
