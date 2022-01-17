using System;
using System.Linq;
using System.Text; 




namespace lab_fundamente
{
    public class P294
    {
        public static void Main()
        {

            //Cerinţa
            // Se dă un şir cu n elemente, numere naturale. Să se verifice dacă oglinditul primului element apare printre celelalte elemente ale șirului.

            // Date de intrare
            // Programul citește de la tastatură numărul n, iar apoi cele n elemente ale şirului, separate prin spaţii.

            // Date de ieşire
            // Programul afișează pe ecran mesajul DA, dacă există în şir elemente egale cu oglinditul primului element, respectiv NU în caz contrar.

            // Restricţii şi precizări
            // 1 ≤ n ≤ 100
            // elementele şirului vor avea cel mult 9 cifre





            int[] arr = new int[100]; 
            int i;  


            Console.WriteLine("introduceti numarul de elemente din array");
            int n = Convert.ToInt32(Console.ReadLine());


  
            Console.Write("{0} elemente in array :\n", n);  
            for(i=0; i<n; i++)  
            {  
                Console.Write("numarul ales : - {0} : ",i);
                arr[i] = Convert.ToInt32(Console.ReadLine());  		
            }  
        
            Console.Write("\nelementele din array sunt: ");  
            for(i=0; i<n; i++)  
            {  
                Console.Write("{0}  ", arr[i]);  
            } 

            Console.Write("\n");

            Console.WriteLine("primul el este {0}", arr[0]);


            int rev = 0;  

            int j = arr[0];

            while(j > 0)  
            {  

                int rem = j % 10;  
                rev = (rev * 10) + rem;  
                j = j / 10;  

            }  

            Console.WriteLine("oglinda numarului ales este {0}", rev);


            if (rev == n)
            {
                Console.WriteLine("DA");
            }
            else
            {
                Console.WriteLine("NO");
            }

        }


        


















    }
}