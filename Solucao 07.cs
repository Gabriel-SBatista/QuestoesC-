using System;

public interface IAnimal
{
    void FazerBarulho();
}

public class Leao : IAnimal
{
    public void FazerBarulho()
    {
        Console.WriteLine("O leão ruge alto!");
    }
}

public class Macaco : IAnimal
{
    public void FazerBarulho()
    {
        Console.WriteLine("O macaco faz sons engraçados!");
    }
}