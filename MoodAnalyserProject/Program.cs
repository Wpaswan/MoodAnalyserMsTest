using MoodAnalyserProject;

public class Mood
{
    static void Main(string[] args)
    {
        MoodAnalyserClass obj = new MoodAnalyserClass("sad");
        Customer customer = new Customer(1,"Dablu");
        customer.Test();
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