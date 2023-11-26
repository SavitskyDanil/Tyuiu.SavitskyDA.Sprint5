using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.SavitskyDA.Sprint5.Task5.V19.Lib
{
    public class DataService : ISprint5Task5V19
    {
        public double LoadFromDataFile(string path)
        {
                double max = -999; 
                double min = 999;
                double res = 0;
                using (StreamReader reader = new StreamReader(path))
                {
                    string line;
                    double utog;
                    while ((line = reader.ReadLine()) != null)
                    {
                        utog = Convert.ToDouble(line);
                        if ((utog > 0 && utog < 10) || (utog < 0 && utog > -10))
                        {
                            max = Math.Max(utog, max);
                            min = Math.Min(utog, min);
                            res = Math.Round (max - min,3);
                        }
                    }
                }
                return res;
        }
    }
}
