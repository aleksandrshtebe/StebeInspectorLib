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

/// Функция вывода имени главного инспектора

        public void GetInspector()
        {
            Console.WriteLine("Главный инспектор Васильев Василий Иванович");
        }
      
      /// Функция вывода названия инспекции
      
        public void GetСarInspection()
        {
            Console.WriteLine("Автоинспекция г. Чита");
        }
        
        /// Функция изменения имени главного инспектора  
        
        public void SetInspector()
        {
            Console.WriteLine($"Изменить главного инспектора");
            string fullname = "Васильев Василий Иванович";
            fullname = fullname.Replace(fullname, Console.ReadLine());
            Console.WriteLine($"Главный инспектор {fullname}") ;
        }
        
        /// Функция генерирующая номер машины
        
        public void GenerateNumber()
        {
            Console.WriteLine($"Генирация номера");
            Random rand = new Random();
           string symbol = Convert.ToString((char)rand.Next('A', 'Z' + 1));
            int Number = rand.Next(100,999);
            int code = 75;
            Console.WriteLine($"Ваш номер {symbol.ToUpper()}{Number}{code}");
        }
        
        /// Функция вывода списка инспекторов
        
        public void GetWorker()
        {
            Console.WriteLine($"Список инспекторов {inst}");
        }
        
        /// Функция добавления новых инспекторов
        
        public void AddWorker()
        {
            Console.WriteLine("Добавить нового инспектора");
            string name = Console.ReadLine();
            inst = String.Concat(inst, ";" +name);
            Console.WriteLine(inst);
        }
    }
}





