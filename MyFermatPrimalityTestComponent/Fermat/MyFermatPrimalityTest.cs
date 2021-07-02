using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fermat
{
    public partial class MyFermatPrimalityTest : Component
    {
        public MyFermatPrimalityTest()
        {
            InitializeComponent();
        }

        public MyFermatPrimalityTest(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
        //n bir asal sayı ise her a doğal sayısı için " a^n-1 % n = 1 "  şeklindedir. 

        /// <summary>
        /// 
        /// </summary>
        /// <param name="a">Herhangi doğal sayı</param>
        /// <param name="n">Test edilecek sayının bir eksiği</param>
        /// <param name="p">Test edilecek sayı</param>
        /// <returns></returns>
        private int power(int a, int n, int p)
        {
           
            int rtn = 1;
            a = a % p;

            while (n > 0)
            {
                Console.WriteLine("rtn"+rtn);
                // n tek ise, sonuçla 'a'yı çarp
                if ((n % 2) == 1)
                    rtn = (rtn * a) % p;

                n = n / 2; 
                a = (a * a) % p;
            }
            return rtn;
        }

        /// <summary>
        /// Fermat Küçük Teoremi ile asal sayı olup olmadığını anladığımız metot
        /// </summary>
        /// <param name="n">Asal olup olmadığı denenecek sayı</param>
        /// <param name="k">Herhangi bir doğal sayı</param>
        /// <returns>n asal ise true değeri değilse false değeri gönderir</returns>
        public bool isPrime(int n, int k)
        {
            //4'e kadar olan doğal sayıların asallık durumuna göre boole değer döndürüyor.
            if (n <= 1 || n == 4) return false;
            if (n <= 3) return true;

            // k kez dene 
            while (k > 0)
            {
                // Random doğal sayı belirleniyor
                Random rand = new Random();
                // Random sayı 0 olabileceği için +2 ekleniyor. n sayısı en düşük 4 olabileceği için 4 çıkarıldı. 
                int a = 2 + (int)(rand.Next() % (n - 4));
                // Fermat Küçük Teoremi için gerekli parametreler power metoduna gönderilerek gelen mod değeri 1'den farklıysa false döndürüyor.
                Console.WriteLine("a"+a);
                if (power(a, n - 1, n) != 1)  
                    return false;

                k--;
            }

            return true;
        }
        //https://www.matematiksel.org/carmicheal-sayilari/
    }
}
