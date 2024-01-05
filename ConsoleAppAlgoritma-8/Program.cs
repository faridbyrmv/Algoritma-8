namespace ConsoleAppAlgoritma_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //    Console.Write("Bir eded daxil edin");
            //    int eded = Convert.ToInt32(Console.ReadLine());

            //    //Algoritma cagrilir
            //    TekVeCutYoxlamasi(eded);

            //}
            //static void TekVeCutYoxlamasi(int eded)
            //{
            //    if (eded % 2 == 0)
            //    {
            //        Console.WriteLine("Daxil etdiyiniz eded cutdur. ");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Daxil etdiyiniz eded tekdir. ");
            //    }


            //    Console.Write("Birinci eded daxil edin: ");
            //    int birinciEded = Convert.ToInt32(Console.ReadLine());

            //    Console.Write("Ikinci eded daxil edin: ");
            //    int ikinciEded = Convert.ToInt32(Console.ReadLine());

            //    //Algoritma Cagrilir
            //    BolumYoxlamasi(birinciEded, ikinciEded);
            //}

            //static void BolumYoxlamasi(int birinciEded, int ikinciEded)
            //{
            //    if (birinciEded % ikinciEded == 0)
            //    {
            //        Console.WriteLine("Birinci eded ikinci edede tam bolunur. ");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Birinci eded ikinci edede tam bolunmur. ");
            //    }


            //    Console.Write("Bir eded daxil edin: ");
            //    int eded = Convert.ToInt32(Console.ReadLine());

            //    //Algoritma cagirilir
            //    SonuncuReqemiYoxla(eded);
            //}

            //static void SonuncuReqemiYoxla(int eded)
            //{
            //    if (eded % 10 == 7)
            //    {
            //        Console.WriteLine("Beli 7 ile qurtarir. ");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Xeyr 7 ile qurtarmir. ");
            //    }


            //    Console.Write("Iki reqemli eded daxil edin: ");
            //    int eded = Convert.ToInt32(Console.ReadLine());

            //    //Algoritma cagirlir
            //    ReqemleriYoxla(eded);
            //}

            //static void ReqemleriYoxla(int eded)
            //{
            //    int birinciReqem = eded / 10;
            //    int ikinciReqem = eded % 10;

            //    if (birinciReqem == ikinciReqem)
            //    {
            //        Console.WriteLine("Beli ededin reqemleri eynidir. ");
            //    }
            //    else
            //    {
            //        {
            //            Console.WriteLine("Xeyr ededin reqemeri eyni deyildir. ");
            //        }
            //    }


            Console.Write("Iki reqemli eded daxil edin: ");
            int eded = Convert.ToInt32(Console.ReadLine());

            //Algoritma cagrilir
            HasilYoxla(eded);
        }

        static void HasilYoxla(int eded)
        {
            int cem = 0;
            int tempEded = eded;

            while (tempEded > 0)
            {
                int reqem = tempEded % 10;
                cem += reqem;
                tempEded /= 10;
            }

            if (cem % 2 == 0)
            {
                Console.WriteLine("Reqemlerin hasil: " + cem);
            }
            else
            {
                Console.WriteLine("Ededde tek reqem movcuddur. ");
            }
        }
    }
}