class PemrosesData 
{
    public void DapatkanNilaiTerbesar<T>(T nilai1, T nilai2, T nilai3) 
    {
        float max = 0;
        dynamic n1 = nilai1;
        dynamic n2 = nilai2;
        dynamic n3 = nilai3;

        if (n1 > n2 && n1 > n3)
        {
            max = n1;
        }

        else if (n2 > n1 && n2 > n3)
        {
            max = n2;
        }

        else if (n3 > n1 && n3 > n2)
        {
            max = n3;
        }

        else 
        {
            Console.WriteLine(" tidak ada angka yang di input");  
        }
        Console.WriteLine("Nilai terbesar adalah " + max);
    }

    class utama
    {
        public static void Main(string[] args) 
        {
            //103022300031
            PemrosesData pm = new PemrosesData();
            pm.DapatkanNilaiTerbesar<float>(10, 30, 22);
        }
    }

}