namespace exercice_2
{
    internal class Program
    {
        public static void Main()
        {
            Console.WriteLine("écrivez un mot:");
            var userInput = Console.ReadLine();
            var userInputUpper = ConvertToUpper(userInput);
            Console.WriteLine("Mot en majuscule: "+userInputUpper);
        }

        public static string ConvertToUpper(string text)
        {
            return text.ToUpper();
        }
    }
}