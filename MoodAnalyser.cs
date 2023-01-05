using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MoodAnalyzerProblem
{
    public class MoodAnalyser
    {
        public static string MoodAnalyserPatternOfSad = "sad";
        public static string MoodAnalyserPatternOfHappy = "happy";


        public string AnalyzeMood()
        {
            string MoodInput1 = "I am in Sad Mood";
            string MoodInput2 = "I am in Any Mood";

            if (Regex.IsMatch(MoodInput1, MoodAnalyserPatternOfSad, RegexOptions.IgnoreCase))
            {
                return "sad";

            }
            else if (Regex.IsMatch(MoodInput2, MoodAnalyserPatternOfHappy, RegexOptions.IgnoreCase))
            {
                return "happy";
            }
            else
            {
                return "happy";
            }
        }

        public string AnalyzeMood(string MoodInput) 
        {
            if (Regex.IsMatch(MoodInput, MoodAnalyserPatternOfSad, RegexOptions.IgnoreCase))
            {
                return "sad";

            }
            else if (Regex.IsMatch(MoodInput, MoodAnalyserPatternOfHappy, RegexOptions.IgnoreCase))
            {
                return "sad";
            }
            else
            {
                return "happy";
            }
        }
    }
}
