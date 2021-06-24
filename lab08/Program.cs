namespace lab08
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var animalGeneric = new AnimalGeneric<Animal>();
            animalGeneric.Add(new Cat
            {
                Id = 12,
                Name = "Do",
                Dob = "welcome"
            });
            
            animalGeneric.Add(new Cat
            {
                Id = 12,
                Name = "nui",
                Dob = "Welcome"
            });
            animalGeneric.Add(new Cat
            {
                Id = 12,
                Name = "ngo",
                Dob = "Welcome"
            });
            animalGeneric.Add(new Dog()
            {
                Id = 12,
                Name = "ngao",
                Dob = "ga"
            });
            
            animalGeneric.ShowInformation();




        }
    }
}