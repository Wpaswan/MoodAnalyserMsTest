using MoodAnalyserProject;

public class Mood
{
    static void Main(string[] args)
    {
        MoodAnalyserClass obj = new MoodAnalyserClass("sad");
    }

    public string AnalyzeMood(String Message)
    {
        string mood;
        if (Message.Contains("Sad"))
            return mood = "Sad";
        else
            return "Happy";
    }
}