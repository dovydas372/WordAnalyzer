namespace WordAnalyzer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\Users\PMAC\Desktop\PROGRAMAVIMAS\C# pamokos\tekstas.txt";

            try
            {
                string fileText = File.ReadAllText(filePath);

             

                
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

       
    }
}
