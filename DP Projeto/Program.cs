using System;

interface OperacaoMatematica
{
    int Calcular(int x, int y);
}

class Adicao : OperacaoMatematica
{
    public int Calcular(int x, int y)
    {
        return x + y;
    }
}

class Subtracao : OperacaoMatematica
{
    public int Calcular(int x, int y)
    {
        return x - y;
    }
}

class Divisao : OperacaoMatematica
{
    public int Calcular(int x, int y)
    {
        return x / y;
    }
}

class Multiplicacao : OperacaoMatematica
{
    public int Calcular(int x, int y)
    {
        return x * y;
    }
}

class MateContext
{
    private OperacaoMatematica _operacaoMate;

    public MateContext(OperacaoMatematica operacaoMate)
    {
        this._operacaoMate = operacaoMate;
    }

    public void ExecuteoperacaoMate(int x, int y)
    {
        int result = this._operacaoMate.Calcular(x, y);
        Console.WriteLine($"Resultado: {result}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        MateContext MateContext = new MateContext(new Adicao());
        MateContext.ExecuteoperacaoMate(10, 5);

        MateContext = new MateContext(new Multiplicacao());
        MateContext.ExecuteoperacaoMate(10, 5);

        MateContext = new MateContext(new Divisao());
        MateContext.ExecuteoperacaoMate(10, 5);

        MateContext = new MateContext(new Subtracao());
        MateContext.ExecuteoperacaoMate(10, 5);
    }
}
