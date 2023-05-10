
//Основная программа
namespace Kalk;
public class Program//делаем класс публичным
{
    static void Main(string[] args)
    {   
        Proverka p = new Proverka();//Обьявляем обьект класса
        Vichiclani v = new Vichiclani();//Обьявляем обьект класса
        int n = 0;
        double a=0, b=0, res;
        do
        {
            Console.WriteLine("\nВыберите операцию:\n1-сложение\n2-вычитание\n3-умножение\n4-деление\n9-выход ");
            n = Convert.ToInt32(p.prov());
            if (n > 0 && n < 5)//проверка: хочет ли пользователь использовать калькулятор.
		{
                Console.WriteLine  ("\nВведиет два числа для работы с вычислением\n");
                Console.Write("a=");
                a = p.prov();
                Console.Write("b=");
                b = p.prov();
            }
            if (n == 4)//Проверка на деление на ноль
            {
                while (b == 0)// Пока делитель равен нулю цикл будет требовать ввод значение снова
                {
                    Console.WriteLine ("\n Деление на ноль не должно присутсвовать! Введите значение b еще раз:");

                    b = p.prov();
                }
            }
            switch (n)//выполнение действия, зависимое от выбора пользователя
            {
                case 1:
                     res = v.add(a, b);
                    Console.WriteLine("{0}+{1}={2}",a,b,res);
                    break;
                case 2:
                    res = v.sub(a, b);
                    Console.WriteLine("{0}-{1}={2}", a, b, res);
                    break;
                case 3:
                    res = v.mul(a, b);
                    Console.WriteLine("{0}*{1}={2}", a, b, res);
                    break;
                case 4:
                    
                    
                        res = v.div(a, b);
                        Console.WriteLine("{0}/{1}={2}", a, b, res);
                    
                        Console.WriteLine("Деление на ноль невозможно");
                    
                    break;
                case 9:
                    
                    Console.WriteLine("Выход");
                        break;
                default:
                    Console.WriteLine("Ошибка выбора операции");
                    break;
            }

        } while (n!=9);
        Console.ReadKey();



    }
}
