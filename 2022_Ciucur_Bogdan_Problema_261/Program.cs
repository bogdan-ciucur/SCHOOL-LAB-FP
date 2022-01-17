namespace lab_fundamente
{
    public class P261
    {
        public static void Main()
        {

            // Cerinţa
            // Se citește un număr natural n. Să se determine numărul de divizori ai oglinditului lui n.

            // Date de intrare
            // Programul citește de la tastatură numărul n.

            // Date de ieşire
            // Programul afișează pe ecran numărul D, reprezentând rezultatul cerut.

            // Restricţii şi precizări
            // 1 ≤ n ≤ 1.000.000.000


            
            // Exemplu
            // Intrare

            // 63
            // Ieșire

            // 9
            // Explicație
            // Oglinditul lui 63 este 36, care are 9 divizori.



            

            using namespace std;
            ifstream cin("intervale.in");
            ofstream cout("intervale.out");
            struct an
            {
                int i , j;
            }
            a[105];


            int n , rez[105] , cnt;


            int main()
            {
                cin >> n;
                for(int i = 1 ; i <= n ; ++i)
                    cin >> a[i].i >> a[i].j;
                for(int i = 1 ; i <= n ; ++i)
                {
                    int ok = 0;
                    for(int j = 1 ; j <= n ; ++j)
                            if(i != j &&(a[i].i < a[j].j && a[i].j > a[j].i)) ok = 1;
                    if(ok == 0) rez[++cnt] = i;
                }
                cout << cnt << "\n";
                for(int i = 1 ; i <= cnt ; ++i)
                    cout << a[rez[i]].i << " " << a[rez[i]].j << "\n";
                return 0;
            }

        }












    }

}
