namespace WordAnalyzer
{
    internal class Program
    {
        static void Main(string[] args)
        {

            File.WriteAllText("newFile.txt", "words analyzer");

            var words = new List<string>
            {
                "apple", "banana", "orange", "grape", "pear",
                "table", "chair", "window", "door", "floor",
                "river", "mountain", "forest", "ocean", "desert",
                "computer", "keyboard", "screen", "mouse", "printer",
                "music", "guitar", "piano", "drums", "violin",
                "happy", "quick", "bright", "silent", "strong", "strong","strong"
            };

            string text = string.Join(Environment.NewLine, words);

            File.AppendAllText("newFile.txt", text);



        }
    }
}
