using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.DeminDA.Sprint6.Task6.V6.Lib
{
    public class DataService : ISprint6Task6V6
    {
        public string CollectTextFromFile(string path)
        
        {
            // Читаем весь файл в строку
            string content = File.ReadAllText(path, Encoding.UTF8);

            // Разделяем строку на слова по пробелам и знакам пунктуации
            string[] words = content.Split(new[] { ' ', ',', '.', ';', ':', '?', '!', '\n', '\r' },
                StringSplitOptions.RemoveEmptyEntries);

            // Формируем результирующую строку
            StringBuilder result = new StringBuilder();

            foreach (string word in words)
            {
                // Проверяем, содержит ли слово символ "b"
                if (word.Contains("b"))
                {
                    // Добавляем слово в результирующую строку с пробелом
                    result.Append(word).Append(" ");
                }
            }

            return result.ToString().Trim(); // Возвращаем результирующую строку без лишних пробелов
        }

    }
}
