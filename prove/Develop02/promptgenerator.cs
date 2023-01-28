public class Promptgenerator {
    private string[] _prompt = {
        "What is a song you truly enjoy and how did it effect you spiritually?",
        "What is one of the most intriguing things you've ever eaten?",
        "What is something someone did for you today that you really appreciate?",
        "What is one of your most embarrassing moments that you've ever had?",
        "If you had a superpower of your choice, what would you choose?"
    };

    public string Prompt() {
        Random randomGenerator = new Random();
        number = randomGenerator.Next(0,_prompt);
        return _prompt[number];
    }
}