namespace MoodAnalyzerProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How are you feeling today ");
            string mood =  Console.ReadLine();

            MoodAnalyser moodAnalyser = new MoodAnalyser();
            //Console.WriteLine(moodAnalyser.AnalyzeMood());
            Console.WriteLine(moodAnalyser.AnalyzeMood(mood));
        }
    }
}