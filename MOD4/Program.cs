using System;

public class KodePos
{
    enum Kelurahan {Batununggal, Kujangsari, Mengger, Wates, Cijaura, Jatisari, Margasari, Sekejati, Kebonwaru, Maleer, Samoja}
    static int getKodePos(Kelurahan kel)
    {
        int[] kodePos = { 40266, 40287, 40267, 40256, 40287, 40286, 40286, 40286, 40272, 40274, 40273 };
        return kodePos[(int)kel];
    }
    static void Main(String[] args)
    {
        Kelurahan kel = Kelurahan.Batununggal;
        Console.WriteLine("Kode pos "+kel+": " + getKodePos(kel));
    }
}

