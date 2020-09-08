using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab8_v8
{
    class Program
    {
        static int Fr(int n) //метод, реализующий вычисление значения функции по рекуррентной формуле
        {
            if (n<=0) 
            {
                return 0;
            }
            else if (n == 1) //F1 = 2
            {
                return 2;
            }                               
            else if (n == 2) //F2 = 1 
            {
                return 1;
            }
            else
            {
                return Fr(n-2)-(n-1)+2*Fr(n-1); //F   -(n-1)+2*F 
            }                                  //  n-2          n-1
        }

        static int F(int n1, int n2, int n) //нерекурсивную версию вычисления значения этой же функции
        {
                return  (n1-(n-1)+2*n2); //F   - (n-1) + 2*F 
                                        //  n-2             n-1
        }

        static void Main()
        {
    //        try
     //       {
                /*1.+	Написать метод, реализующий вычисление значения функции по рекуррентной формуле (в соответствии с вариантом). 
                  2.+	Определить, при каком значении n происходит переполнение стека. 
                  3.+	Реализовать нерекурсивную версию вычисления значения этой же функции. 
                  4.-	Проверьте правильность обоих методов путем вычисления первых нескольких значений функции вручную и сравнения результатов.
                  5.-	Оценить время работы методов при различных значениях n (желательно составив графики).
                */
                //8.	F1=2, F2=1, Fn=F/n-2\‒(n‒1)+2*F/n-1\

                Console.Write("1.\nn = ");
                int n = Convert.ToInt32(Console.ReadLine());
                DateTime dt1 = DateTime.Now; //засекли время до       
                int Fn = 0;

                //рекурсивная
                Console.WriteLine("Рекурсивная: " + Fr(n));

                DateTime dt2 = DateTime.Now; //после
                TimeSpan ts1 = dt2 - dt1; //разница
                Console.WriteLine(ts1.Ticks);

                dt1 = DateTime.Now;//до
                Fn = 0;
                //нерекуррентная
                int F1 = 2, F2 = 1, F3 = Fn;
                for (int i = 3; i <= n; i++)
                {
                    Fn = F(F1, F2, i); //Fn
                    F1 = F2; //n-2
                    F2 = Fn; //n-1
                }

                dt2 = DateTime.Now; //после
                ts1 = dt2 - dt1;//разница
                Console.WriteLine("Нерекурсивная: " + Fn);
                Console.WriteLine(ts1.Ticks); //вывод
                Console.ReadKey();
 /*           }
            catch
            {
                Console.WriteLine("Произошло переполнение");
            }*/
        }
    }
}
