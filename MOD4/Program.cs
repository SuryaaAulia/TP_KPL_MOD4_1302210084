using System;

class KodePos
{
    public enum Kelurahan {Batununggal, Kujangsari, Mengger, Wates, Cijaura, Jatisari, Margasari, Sekejati, Kebonwaru, Maleer, Samoja}
    public static int getKodePos(Kelurahan kel)
    {
        int[] kodePos = { 40266, 40287, 40267, 40256, 40287, 40286, 40286, 40286, 40272, 40274, 40273 };
        return kodePos[(int)kel];

    }
}

class DoorMachine
{
    public enum statusKunci { Terkunci, Terbuka }
}

public class main
{
    static void Main(String[] args)
    {
        KodePos.Kelurahan kel = KodePos.Kelurahan.Batununggal;
        int kodePos = KodePos.getKodePos(kel);
        Console.WriteLine("Kode Pos "+ kel +": "+ kodePos+"\n");

        String todo = "";
        Console.ReadLine();
        DoorMachine.statusKunci state = DoorMachine.statusKunci.Terkunci;
        if (state == DoorMachine.statusKunci.Terkunci || state == DoorMachine.statusKunci.Terbuka && todo != null && todo == "BukaPintu")
        {
            Console.WriteLine("Pintu tidak terkunci");
            state = DoorMachine.statusKunci.Terbuka;
        }
        else if (state == DoorMachine.statusKunci.Terkunci || state == DoorMachine.statusKunci.Terbuka && todo != null && todo == "KunciPintu")
        {
            Console.WriteLine("Pintu terkunci");
            state = DoorMachine.statusKunci.Terkunci;
        }
    }
}
