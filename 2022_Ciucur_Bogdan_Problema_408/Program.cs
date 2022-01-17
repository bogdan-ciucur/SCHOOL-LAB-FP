using System;
using System.Linq;
using System.Text; 




namespace lab_fundamente
{
    public class P408
    {
        public static void Main()
        {
            
            // Se citește un număr natural n. Să se determine numărul de divizori ai oglinditului lui n.

            // Date de intrare
            // Programul citește de la tastatură numărul n.

            // Date de ieşire
            // Programul afișează pe ecran numărul D, reprezentând rezultatul cerut.

            // Restricţii şi precizări
            // 1 ≤ n ≤ 1.000.000.000

            Console.WriteLine("introduceti valoarea lui n pentru a-i afla divizorii");

            int n = Convert.ToInt32(Console.ReadLine());



            // if (n == 1 || n == 2 || n = 3 || n = 4 || n = 5 || n = 5 || n = 6 || n = 7 || n = 8 || n = 9)
            // {
            //     Console.WriteLine("ai ales nr bun");
            // }





            
            if (n < 10)
            {


                Console.WriteLine("numarul {0} nu poate fi oglindit", n);

                for(int divisor = 1; divisor <= n; divisor++)
                {

                if ((n % divisor) == 0)
                {
                    Console.WriteLine($"divizorii numarului {n} sunt  {divisor}", divisor);
                }

                }

            }
            else 
            {
                int rev = 0;  

                while(n > 0)  
                {  

                    int rem = n % 10;  
                    rev = (rev * 10) + rem;  
                    n = n / 10;  

                }  

                Console.WriteLine("oglinda numarului ales este {0}", rev);

                for(int divisor = 1; divisor <= rev; divisor++)
                {

                if ((rev % divisor) == 0)
                {
                    Console.WriteLine($"divizorii numarului {rev} sunt  {divisor}", divisor);
                }

                }


            }









        }
    }
}
