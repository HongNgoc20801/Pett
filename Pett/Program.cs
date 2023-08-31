using Pett;

namespace Pett;

class Program
{
    private static void Main(string[] args)
    {
        PetDatabase database = PetDatabase.Instance;



        Console.Write("Enter the name of the pet to search for: ");
        string searchName = Console.ReadLine();



        List<Pet> foundPets = database.FindPetsByName(searchName);



        if (foundPets.Count > 0)
        {
            Console.WriteLine("Pets found:");
            foreach (Pet pet in foundPets)
            {
                Console.WriteLine(pet);
            }
        }
        else
        {
            Console.WriteLine("No pets found by that name.");
        }



    }
}