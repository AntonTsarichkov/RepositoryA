namespace Lab4
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Ecosystem ecosystem = new Ecosystem();
            ecosystem.AddOrganism(new Animal(100, 2, 10, 5));
            ecosystem.AddOrganism(new Plant(50, 5, 3, 4));
            ecosystem.AddOrganism(new Microorganism(20, 1, 1, 3));
            Console.WriteLine($"{ecosystem.Organims.Count} initial quantity of organism");
            for (int i = 0; i < 20; i++) 
            {
                ecosystem.Simulation();
                Console.WriteLine($"{ecosystem.Organims.Count} organisms are alive after {i + 1} days");
            }
            Console.WriteLine("Simulation had finished!");
        }
    }
}
