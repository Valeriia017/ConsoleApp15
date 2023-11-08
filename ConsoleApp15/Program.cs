using System;

abstract class Parent
{
    protected int pole1;

    public Parent(int pole1)
    {
        this.pole1 = pole1;
    }

    public abstract string Info();
    public abstract int Metod();
}

class Child1 : Parent
{
    private int pole2;

    public Child1(int pole1, int pole2) : base(pole1)
    {
        this.pole2 = pole2;
    }

    public override string Info()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        return $"Мінімальна допомога: {pole1},  Група: {pole2}";
    }

    public override int Metod()
    {
        if (pole2 == 1)
        {
            return pole1 * 3;
        }
        else
        {
            return pole1 * 2;
        }
    }
}

class Child2 : Parent
{
    private int pole3;

    public Child2(int pole1, int pole3) : base(pole1)
    {
        this.pole3 = pole3;
    }

    public override string Info()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        return $"Мінімальна допомога: {pole1},  Кількість дітей: {pole3}";
    }

    public override int Metod()
    {
        if (pole3 >= 3 && pole3 <= 5)
        {
            return (int)(pole1 * 1.3);
        }
        else if (pole3 > 5)
        {
            return (int)(pole1 * 1.5);
        }
        else
        {
            return pole1;
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();

        for (int i = 0; i < 5; i++)
        {
            int pole1 = random.Next(100, 1000);
            int type = random.Next(1, 3);

            if (type == 1)
            {
                int pole2 = random.Next(1, 4);
                Child1 child1 = new Child1(pole1, pole2);
                Console.WriteLine(child1.Info());
                Console.WriteLine($"Розмір допомоги: {child1.Metod()}");
            }
            else
            {
                int pole3 = random.Next(1, 10);
                Child2 child2 = new Child2(pole1, pole3);
                Console.WriteLine(child2.Info());
                Console.WriteLine($"Розмір допомоги: {child2.Metod()}");
            }
        }
    }
}