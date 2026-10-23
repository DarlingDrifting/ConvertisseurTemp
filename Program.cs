namespace convertisseur_temp;

class Program
{
    static void Main(string[] args)
    {
        // Créez un programme sur console qui converti une température rentrée par l’utilisateur dans l’unité de son choix.
        // Deux sens de conversion doivent être possibles : soit de degrés Celsius vers Fahrenheit, soit de degrés Fahrenheit vers Celsius.
        float temp = 0.0f;

        Console.WriteLine("=== CONVERTISSEUR DE TEMPERATURE ===");
        Console.WriteLine("Choix de convertion : (tapez 1 ou 2)");
        Console.WriteLine("1. Celsius vers Fahrenheit \n2. Fahrenheit vers Celcius");
        int choice = Convert.ToInt32(Console.ReadLine());

        if (choice == 1)
        {
            Console.WriteLine("Veuillez entrer la température en °Celsius sans renseigner l'unité (ex : 26,3) :");
            temp = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Votre température vaut : " + ((temp * 9 / 5) + 32) + "°F");
        }
        else
        {
            Console.WriteLine("Veuillez entrer la température en °Fahrenheit sans renseigner l'unité (ex : 26,3) :");
            temp = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Votre température vaut : " + ((temp - 32) * 5/9) + "°C");
        }
        Console.WriteLine("Merci d'avoir utilisé notre convertisseur ! ");
    }
}