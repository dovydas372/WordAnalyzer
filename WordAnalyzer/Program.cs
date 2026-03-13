namespace WordAnalyzer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\Users\PMAC\Desktop\PROGRAMAVIMAS\C# pamokos\NewWordAnalyzer\Words.txt";

            try
            {
                string fileText = File.ReadAllText(filePath);
                var wordsCounter = new CountingWords();
                var result = wordsCounter.CountWords(fileText);
             
                PrintDictionary(result);
                
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Failas nerastas.");
            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine("Nėra teisės pasiekti šio failo.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Įvyko klaida: {ex.Message}");
            }
        }

        static void PrintDictionary(Dictionary<string, int> dictionary)
        {
            foreach (var element in dictionary.OrderByDescending(x => x.Value))
            {
                Console.WriteLine($"Word: {element.Key}, times found: {element.Value}");
            }
        }

    }
}
