using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter text:");
        string inputText = Console.ReadLine();

        int wordCount = 0;
        int characterCount = 0;
        int numberCount = 0;
        int specialCharacterCount = 0;
        int sentenceCount = 0;
        int totalWordsInSentences = 0;
        int totalCharactersInSentences = 0;

        string[] words = inputText.Split(' ');

        foreach (string word in words)
        {
            wordCount++;
            characterCount += word.Length;

            foreach (char c in word)
            {
                if (Char.IsDigit(c))
                {
                    numberCount++;
                }
                else if (!Char.IsLetterOrDigit(c))
                {
                    specialCharacterCount++;
                }
            }
        }

        string[] sentences = inputText.Split('.');

        foreach (string sentence in sentences)
        {
            sentenceCount++;

            string[] sentenceWords = sentence.Split(' ');

            totalWordsInSentences += sentenceWords.Length;

            foreach (string word in sentenceWords)
            {
                totalCharactersInSentences += word.Length;
            }
        }

        double averageWordsPerSentence = (double)totalWordsInSentences / sentenceCount;
        double averageCharactersPerSentence = (double)totalCharactersInSentences / sentenceCount;

        Console.WriteLine($"Word Count: {wordCount}");
        Console.WriteLine($"Character Count: {characterCount}");
        Console.WriteLine($"Number Count: {numberCount}");
        Console.WriteLine($"Special Character Count: {specialCharacterCount}");
        Console.WriteLine($"Sentence Count: {sentenceCount}");
        Console.WriteLine($"Words per Sentence: {averageWordsPerSentence:F3}");
        Console.WriteLine($"Characters per Sentence: {averageCharactersPerSentence:F4}");
    }
}

