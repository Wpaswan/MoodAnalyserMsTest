using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyserProject;

namespace MoodAnalyserTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Mood Analyze = new Mood();
            string expected = "Sad";
            string actual = Analyze.AnalyzeMood("I am in Sad Mood");
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod2()
        {
            Mood analyzer = new Mood();
            string expected = "Happy";
            string actual = analyzer.AnalyzeMood(" I am in any mood");
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void GivenMoodHappy_ShouldReturnHappy()
        {
            MoodAnalyserClass obj = new MoodAnalyserClass("HAPPY");
            string result = obj.analyseMood();
            Assert.AreEqual("HAPPY", result);

        }

        [TestMethod]
        [ExpectedException(typeof(MoodAnalyserCustomException))]
        public void GivenMoodNull_ShouldThrowException()
        {
            MoodAnalyserClass obj = new MoodAnalyserClass(null);
            string result = obj.analyseMood();
            //Assert.AreEqual("123", result);

        }


        [TestMethod]
        public void GivenMoodHappy_ShouldReturnNull()
        {
            MoodAnalyserClass obj = new MoodAnalyserClass("null");
            string result = obj.analyseMood();
            Assert.AreEqual("HAPPY", result);

        }
        //Test case 4.1 given mood analyser class should return object
        [TestMethod]
        public void GivenMoodClass_ShouldReturnObject()
        {
            object expected = new MoodAnalyserClass();
            object obj = MoodAnalyserFactory.CreateMoodAnalyser("MoodAnalyserProject.MoodAnalyserClass", "MoodAnalyserClass");
        }

    }
}