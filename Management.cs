using System.Reflection;
using System.Runtime.InteropServices.Marshalling;

public class Management {

    public List<Zookeeper> Zookeepers = new List<Zookeeper>();
    public List<IAnimal> Animals = new List<IAnimal>();
    public void AssignAnimalToZookeeper()
    {
        System.Console.WriteLine("Intoduceti numele ingrijitorului");
        string numeIngrijitor = Console.ReadLine();
        

            Zookeeper findZookeeper = Zookeepers.Find(n => n.Nume == numeIngrijitor);

            if(findZookeeper != null)
            {
                System.Console.WriteLine("Intoduceti numele animalului");
                string numeAnimal = Console.ReadLine();

                IAnimal findAnimalInVector = Animals.Find(n => n.Nume == numeAnimal);

                if(findAnimalInVector == null)
                {
                    System.Console.WriteLine("Animalul nu exista!");
                   
                }

                IAnimal findAnimal = findZookeeper.AnimaleAsignate.Find(n => n.Nume == numeAnimal);
                if(findAnimal != null)
                {
                    System.Console.WriteLine("Animalul este deja asignat!");
                    
                }

                findZookeeper.AnimaleAsignate.Add(findAnimalInVector);
                System.Console.WriteLine("Animalul a fost adaugat cu succes!"); 
                
            }
            else
            {
                System.Console.WriteLine("Ingrijitorul nu exista!");
            }
        
    }

    public void AddAnimals()
    {
        Lion leu1 = new Lion(){Nume = "Leo1", Age = 1, Gender = "Masculin"};
        Animals.Add(leu1);

        Lion leu2 = new Lion(){Nume = "Leo2", Age = 2, Gender = "Feminin"};
        Animals.Add(leu2);

        Elephant elephant1 = new Elephant(){Nume = "Elephant1", Age = 3, Gender = "Feminin"};
        Animals.Add(elephant1);

        Elephant elephant2 = new Elephant(){Nume = "Elephant2", Age = 1, Gender = "Masculin"};
        Animals.Add(elephant2);

        Eagle eagle1 = new Eagle(){Nume = "Eagle1", Age = 1, Gender = "Masculin"};
        Animals.Add(eagle1);

        Tiger tiger1 = new Tiger(){Nume = "Tiger1", Age = 2, Gender = "Feminin"};
        Animals.Add(tiger1);

        Giraffe giraffe1 = new Giraffe(){Nume = "Giraffe1", Age = 3, Gender = "Masculin"};
        Animals.Add(giraffe1);

        System.Console.WriteLine("Animalele au fost adaugate cu succes!");
    }

    public void AddZookeepers()
    {
        Zookeeper zookeeper1 = new Zookeeper(){Nume = "Stefan"};
        Zookeepers.Add(zookeeper1);

        Zookeeper zookeeper2 = new Zookeeper(){Nume = "Ana"};
        Zookeepers.Add(zookeeper2);

        Zookeeper zookeeper3 = new Zookeeper(){Nume = "Andrei"};
        Zookeepers.Add(zookeeper3);

        System.Console.WriteLine("Ingrijitorii au fost adaugati cu succes!");
    }

    public void AssignedAnimals()
    {
        System.Console.WriteLine("Intoduceti numele ingrijitorului pentru care vreti sa adaugati animalele asignate: ");
        string numeIngrijitor = Console.ReadLine();
        
        Zookeeper findZookeeper = Zookeepers.Find(n => n.Nume == numeIngrijitor);

        System.Console.WriteLine("Animalele asignate sunt: ");
        if(findZookeeper != null)
        {
            foreach(IAnimal animal in findZookeeper.AnimaleAsignate)
            {
                System.Console.WriteLine(animal.Nume);
            }
        }
    }

    public void CleanHabitat()
    {
        System.Console.WriteLine("Intoduceti numele animalului pe care vreti sa-l ingrijiti: ");
        string numeAnimal = Console.ReadLine();

        foreach(Zookeeper findZookeeper in Zookeepers)
        {
            IAnimal findAnimal = findZookeeper.AnimaleAsignate.Find(n => n.Nume == numeAnimal)!;
            if(findAnimal!= null)
            {
                findZookeeper.CleanEnclousers(findAnimal);
            }
        }

    }

    public void Feed()
    {
        System.Console.WriteLine("Intoduceti numele animalului pe care vreti sa-l ingrijiti: ");
        string numeAnimal = Console.ReadLine();

        foreach(Zookeeper findZookeeper in Zookeepers)
        {
            IAnimal findAnimal = findZookeeper.AnimaleAsignate.Find(n => n.Nume == numeAnimal)!;
            if(findAnimal!= null)
            {
                findZookeeper.FeedAnimal(findAnimal);
            }
        }

    }
}