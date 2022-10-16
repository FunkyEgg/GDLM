using GDLM;

namespace GDLM
{
    class Gdlm
    {
        public static void Main(string[] args)
        {
            bool exit = false;

            while (!exit)
            {
                Console.Write("Please input an option => ");
                string? input = Console.ReadLine();

                switch (input)
                {
                    case "exit":
                        exit = true;
                        continue;
                    default:
                        Console.WriteLine("Invalid option");
                        continue;
                }
            }
        }
    }
}