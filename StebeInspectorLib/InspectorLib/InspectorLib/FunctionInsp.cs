using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InspectorLib
{
    public class FunctionInsp
    {
       public string inst = "Иванов И.И.Зиронов Т.А.Миронов А.В. Васильев В.И. ";
/// <summary>
/// Функция вывода имени главного инспектора
/// </summary>
        public void GetInspector()
        {
            Console.WriteLine("Главный инспектор Васильев Василий Иванович");
        }
      /// <summary>
      /// Функция вывода названия инспекции
      /// </summary>
        public void GetСarInspection()
        {
            Console.WriteLine("Автоинспекция г. Чита");
        }
        /// <summary>
        /// Функция изменения имени главного инспектора  
        /// </summary>
        public void SetInspector()
        {
            Console.WriteLine($"Изменить главного инспектора");
            string fullname = "Васильев Василий Иванович";
            fullname = fullname.Replace(fullname, Console.ReadLine());
            Console.WriteLine($"Главный инспектор {fullname}") ;
        }
        /// <summary>
        /// Функция генерирующая номер машины
        /// </summary>
        public void GenerateNumber()
        {
            Console.WriteLine($"Генирация номера");
            Random rand = new Random();
           string symbol = Convert.ToString((char)rand.Next('A', 'Z' + 1));
            int Number = rand.Next(100,999);
            int code = 75;
            Console.WriteLine($"Ваш номер {symbol.ToUpper()}{Number}{code}");
        }
        /// <summary>
        /// Функция вывода списка инспекторов
        /// </summary>
        public void GetWorker()
        {
            Console.WriteLine($"Список инспекторов {inst}");
        }
        /// <summary>
        /// Функция добавления новых инспекторов
        /// </summary>
        public void AddWorker()
        {
            Console.WriteLine("Добавить нового инспектора");
            string name = Console.ReadLine();
            inst = String.Concat(inst, ";" +name);
            Console.WriteLine(inst);
        }
    }
}





