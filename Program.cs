namespace Canvas_3;

class Program
{
    static void Main(string[] args)
    
    {
        string restart = "yes";
        do           
            {
                int lenght = 0;
                Console.WriteLine("\nEnter a sentence to count the amount of letter\n");
                foreach (var sentenceLenght in Console.ReadLine()) if (char.IsLetter(sentenceLenght)) lenght++;
                Console.WriteLine($"sentence is {lenght} letters long");  
            
                Console.WriteLine("\n Do you want to enter another sentence? Yes or No\n");
                restart = Console.ReadLine().ToLower();
            }while (restart == "YES" || restart == "yes");
    
    }
}