using System;

public class Singleton
{
    private static Singleton instance;

    private Singleton() { }

    public static Singleton Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new Singleton();
            }
            return instance;
        }
    }

    public void PrintMessage()
    {
        Console.WriteLine("Olá mundo!");
    }
}

public class Program
{
    public static void Main()
    {
        Singleton t1 = Singleton.Instance;
        Singleton t2 = Singleton.Instance;

        t1.PrintMessage();
        t2.PrintMessage();

        Console.ReadLine();
    }
}
