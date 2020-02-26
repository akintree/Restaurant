using System;

namespace Restaurant
{
    class Program
    {
        static void Main(string[] args)
        {
            MenuItem Ravioli = new MenuItem();
            Ravioli.Name = "Ravioli";
            Ravioli.Price = 9;
            Ravioli.Description = "choice of beef or cheese with either marinara or garlic cream sauce";
            MenuItem ChocolateCake = new MenuItem();
            ChocolateCake.Name = "Chocolate Cake";

            Menu.AddToMenu(Ravioli);
            Menu.AddToMenu(ChocolateCake);
            Menu.RemoveFromMenu(ChocolateCake);

            Menu.PrintMenu();

        }
    }
}
