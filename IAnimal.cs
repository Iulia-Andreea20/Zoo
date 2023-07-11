public interface IAnimal {
    public string Nume { get; set; }
    public int Age { get; set; }
    public string Gender { get; set; }

    public bool IsFeed { get; set; }

    public bool EnclousersCleaned { get; set; }

    public void Sleeeping();

    public void Eating();

    public void MakingSounds();
}