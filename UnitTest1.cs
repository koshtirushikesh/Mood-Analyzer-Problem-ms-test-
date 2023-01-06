using MoodAnalyzerProblem;

namespace TestMoodAnalyserProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Arrange 
            string mood = "I am in Sad Mood";
            string expexctedoutput = "sad";

            MoodAnalyser obj = new MoodAnalyser();
            // Act
            string actualoutput = obj.AnalyzeMood(mood);
            //Arrang
            Assert.AreEqual(expexctedoutput, actualoutput);
        }

        [TestMethod]
        public void TestMethod2()
        {
            // Arrange 
            string mood = "I am in Any Mood";
            string expexctedoutput = "happy";

            MoodAnalyser obj = new MoodAnalyser();
            // Act
            string actualoutput = obj.AnalyzeMood(mood);
            //Arrang
            Assert.AreEqual(expexctedoutput, actualoutput);
        }
    }
}