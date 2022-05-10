string choiceMainMenu = "";
List<String> employeeList = new List<String>();
do
{
    Console.WriteLine("Välkommen till anställning!");
    Console.WriteLine("Vänligen välj ett av följande alternativ:");
    Console.WriteLine("1. Lägg till anställd");
    Console.WriteLine("2. Visa lista över anställda");
    Console.WriteLine("3. Avsluta\n");
    choiceMainMenu = Console.ReadLine();

    switch (choiceMainMenu)
    {
        case "1":
            Console.Clear();
            Console.WriteLine("Skriv in anställdas förnamn: ");
            String firstName = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Skriv in anställdas efternamn: ");
            String lastName = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Skriv in anställdas lön: ");
            String salary = Console.ReadLine();
            String newEmployee = "Namn: " + firstName + " " + lastName + ", Lön: " + salary;
            employeeList.Add(newEmployee);
            Console.Clear();
            Console.WriteLine("Anställd tillagd, tryck Enter för att fortsätta\n");
            Console.ReadLine();
            Console.Clear();
            break;

        case "2":
            Console.Clear();
            Console.WriteLine("Lista över anställda:");
            for (int i = 0; i < employeeList.Count; i++)
            {
                string s = employeeList[i];
                Console.WriteLine(s);
            }
            Console.WriteLine("\n Klicka Enter för att fortsätta!");
            Console.ReadLine();
            Console.Clear();
            break;

        case "3":
            Console.Clear();
            Console.WriteLine("Stänger programmet");
            break;
        default:
            Console.WriteLine("Felaktig inmatning");
            break;

    }
} while (choiceMainMenu != "3");

Console.WriteLine("Hej då");

