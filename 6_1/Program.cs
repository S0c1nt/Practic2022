using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> words = new Dictionary<string, string>();
            words.Add("БАНАН", "Высокое тропическое растение с большимилистьями, а также его удлиненный и слегка изогнутый сладкий мучнистый плод,растущий в соплодии");
            words.Add("АДСКИЙ", "О чем-н. неприятном: оченьсильный, а также невыносимый");
            words.Add("ЛАРЕЦ", "Искусно сделанный, украшенный ящичек для хранениядрагоценностей");
            words.Add("ЮНИОР", " Спортсмен-юноша, участник соревнований в своей возрастнойгруппе");
            words.Add("ЭКЗАМЕНАТОР", "Преподаватель, принимающий экзамен");
            words.Add("ЭЛЕВАТОР", "Зернохранилище с механическим оборудованием дляприема, очистки, сушки, отгрузки зерна");
            words.Add("МАЗУРКА", "Польский народный, сценический и бальный танец, а такжемузыка в ритме этого танца");
            words.Add("КАЗИНО", "То же, что игорный дом");
            words.Add("ЖЕЛЕЗА", "Орган, вырабатывающий и выделяющий гормоны или другие вещества, обеспе-чивающие жизнедеятельностьорганизма");
            words.Add("ЗАБАРАХЛИТЬ", "Начать барахлить");
            words.Add("РАЗВЕДКА", "Обследование чего-н. со специальной целью");
            words.Add("ШВЕДЫ", "Народ, составляющий основное население Швеции");
            words.Add("ЯКШАТЬСЯ", "Общаться,знаться");
            words.Add("УВЕДОМИТЬ", "То же, что известить");
            words.Add("НАВИТЬ", "Намотать на что-н");
            words.Add("ЮРОК", "Небольшая таежная певчая птица, внешне сходная сзябликом, род вьюрка");
            words.Add("ОБЕСПАМЯТЕТЬ", "Лишиться памяти, способностипомнить");
            words.Add("ЙОГУРТ", "Заквашенное молоко с различными добавками");
            words.Add("ФЕДЕРАЛИЗМ", "Принцип государственного устройства, основанного на федерации");
            words.Add("ЗАВУЧ", "Заведующий учебной частью, заместительдиректора школы по учебно-воспитательной работе");

            string userInput = "";

            while (true)
            {
                Console.Write("Введите слово: ");
                userInput = Console.ReadLine().ToUpper();

                if (words.ContainsKey(userInput))
                    Console.WriteLine(words[userInput]);
                else
                    Console.WriteLine("Такого слова нет");
            }
        }
    }
}
