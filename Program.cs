using System.Reflection;

System.Console.WriteLine("Bine ati venit la Zoo!");
Management management= new Management();
Display display = new Display();
while(true) {
    System.Console.WriteLine("Meniu:");
    System.Console.WriteLine("\tApasati 1 pentru a adauga animale");
    System.Console.WriteLine("\tApasati 2 pentru a adauga ingrijitori");
    System.Console.WriteLine("\tApasati 3 pentru a asigna un ingrijitor pentru un animal");
    System.Console.WriteLine("\tApasati 4 pentru a vedea animalele asignate unui ingrijitor");
    System.Console.WriteLine("\tApasati 5 pentru a afisa ingrijitorii si animalele din gradina zoo");
    System.Console.WriteLine("\tApasati 6 pentru a ingriji un animal");
    System.Console.WriteLine("\tApasati 7 pentru a hrani un animal");
    System.Console.WriteLine("\tApasati 9 pentru a inchide meniul");
    System.Console.WriteLine("Optiunea dorita este: ");
    char option = Console.ReadLine()[0];

    if(option == '1') 
    {
        management.AddAnimals();
    }
    else if(option == '2')
    {
        management.AddZookeepers();
    }
    else if (option == '3')
    {
        management.AssignAnimalToZookeeper();
    }
    else if (option == '4')
    {
        management.AssignedAnimals();
    }
    else if (option == '5')
    {
       display.display(management.Zookeepers, management.Animals);
    }
    else if (option == '6')
    {
       management.CleanHabitat();
    }
    else if (option == '7')
    {
       management.Feed();
    }
    else if(option == '9')
    {
        System.Console.WriteLine("Multumim ca ne-ati vizitat gradina!");
        break;
    }
    
}