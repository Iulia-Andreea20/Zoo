public class Zookeeper {
    public string Nume { get; set; }
    public List<IAnimal> AnimaleAsignate = new List<IAnimal>();

    public void FeedAnimal(IAnimal animal)
    {
        animal.IsFeed = true;
    }

    public void CleanEnclousers(IAnimal animal)
    {
        animal.EnclousersCleaned = true;
    }
}