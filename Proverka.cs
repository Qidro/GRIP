using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//модуль проверки
namespace Kalk
{
    public class Proverka
    {
       public double prov()

        {
            double a;
            do
            {
                try
                {
                    
                    a = Convert.ToDouble(Console.ReadLine());
                    return a;

                }
                catch (Exception)
                {
                    Console.WriteLine("\nОшибка вводы");
                }
            } while (true);
        }
    }
}
