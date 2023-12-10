using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.DeminDA.Sprint6.Task6.V6.Lib
{
    public class DataService : ISprint6Task6V6
    {
        public string CollectTextFromFile(string path)
        
        {
            string result = "";
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    if (line.Contains('b'))
                    {
                        result = result +  " "+ line;
                    }
                }
            }

            return result;
        }
    }
}
