using System.Diagnostics;

public class Eagle: Fly {
    public string? Nume { get; set; }
    public int Age { get; set; }
    public string? Gender { get; set; }
    public bool IsFeed { get; set; } =  false;
    public bool EnclousersCleaned { get; set; } = false;

    public void Sleeeping()
    {
        System.Console.WriteLine("The eagle is sleeping");
    } 

    public void Eating()
    {
        System.Console.WriteLine("The eagle is eating");
    }

    public void MakingSounds()
    {
        System.Console.WriteLine("The eagle is making sounds!");
    }

    public void IsFlying() {
        System.Console.WriteLine("The eagle is flying!");
    }
}