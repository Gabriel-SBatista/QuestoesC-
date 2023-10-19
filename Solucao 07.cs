using System;

public interface IAnimal
{
    void FazerBarulho();
}

public class Leao : IAnimal
{
    public void FazerBarulho()
    {
        Console.WriteLine("O le�o ruge alto!");
    }
}

public class Macaco : IAnimal
{
    public void FazerBarulho()
    {
        Console.WriteLine("O macaco faz sons engra�ados!");
    }
}