public class Elephant: IAnimal {
    public string Nume { get; set; }
    public int Age { get; set; }
    public string Gender { get; set; }    
    public bool IsFeed { get; set; } =  false;
    public bool EnclousersCleaned { get; set; } = false;

    public void Sleeeping()
    {
        System.Console.WriteLine("The elephant is sleeping");
    } 

    public void Eating()
    {
        System.Console.WriteLine("The elephant is eating");
    }

    public void MakingSounds()
    {
        System.Console.WriteLine("The elephant is making sounds!");
    }
}