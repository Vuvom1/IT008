using System;

interface IThinking
{
    void thinking_behavior();
}

interface IIntelligent
{
    void intelligent_behavior();
}

interface IAbility : IIntelligent, IThinking
{
}

class Mamal
{
    public string characteristics;

    public Mamal(string characteristics)
    {
        this.characteristics = characteristics;
    }

    public virtual void thinking_behavior()
    {
        // Định nghĩa hành vi thinking_behavior cho Mamal
        Console.WriteLine("Mamal thinking behavior");
    }
}

class Whale : Mamal
{
    public Whale(string characteristics) : base(characteristics)
    {
        // Khởi tạo Whale
    }

    public override void thinking_behavior()
    {
        // Định nghĩa thinking_behavior cho Whale
        Console.WriteLine("Whale thinking behavior");
    }
}

class Human : Mamal, IIntelligent
{
    public Human(string characteristics) : base(characteristics)
    {
        // Khởi tạo Human
    }

    public override void thinking_behavior()
    {
        // Định nghĩa thinking_behavior cho Human
        Console.WriteLine("Human thinking behavior");
    }

    public void intelligent_behavior()
    {
        // Định nghĩa intelligent_behavior cho Human
        Console.WriteLine("Human intelligent behavior");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Mamal mamal = new Mamal("Mamal characteristics");
        mamal.thinking_behavior();

        Whale whale = new Whale("Whale characteristics");
        whale.thinking_behavior();

        Human human = new Human("Human characteristics");
        human.thinking_behavior();
        human.intelligent_behavior();
    }
}
