public class Display: Management {
    public void display(List<Zookeeper> Zookeepers, List<IAnimal> Animals)
    {
         System.Console.WriteLine("Ingrijitorii gradinii zoologice sunt urmatorii: ");
        foreach (Zookeeper zookeeper in Zookeepers)
        {
            System.Console.WriteLine(zookeeper.Nume);
        }
        System.Console.WriteLine("\n");

        System.Console.WriteLine("Animalele din gradina zoologica sunt urmatoarele: ");
        System.Console.WriteLine("Nume\tIsFeed\tEnclousersCleaned");
        foreach (IAnimal animal in Animals)
        {
            System.Console.WriteLine(animal.Nume + " " + animal.IsFeed + " " + animal.EnclousersCleaned);
        }
        System.Console.WriteLine("\n");
    }
}