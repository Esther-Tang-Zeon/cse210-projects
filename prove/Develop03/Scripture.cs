// This class represents the scripture itself and manages a list of `Word` objects.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

public class Scripture
{
    // Fields to store the scripture reference and list of words
    private Reference _reference; // Reference to the scripture (e.g., book, chapter, verse)
    private List<Word> _textWords; // List of words in the scripture text

    // Constructor to initialize the scripture with a reference and text
    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        // Split the text into words and create Word objects for each
        _textWords = text.Split(' ').Select(w => new Word(w)).ToList();
    } 

    // Method to randomly hide a random number of words in the scripture
        public void HideWords()
    {
        Random rand = new Random();

        // Get the indices of all words that are still visible
        var visibleWordIndices = _textWords
                                .Select((word, index) => new { word, index })
                                .Where(x => !x.word.IsHidden())
                                .Select(x => x.index)
                                .ToList();

        // If all words are hidden, exit the method
        if (visibleWordIndices.Count == 0)
        {
            return; // All words are already hidden
        }

        // Randomly determine the number of words to hide (between 1 and 4 or remaining words)
        int numWordsToHide = Math.Min(rand.Next(1, 5), visibleWordIndices.Count);

        for (int i = 0; i < numWordsToHide; i++)
        {
            // Choose a random index from the list of visible word indices
            int randomIndex = rand.Next(visibleWordIndices.Count);
            int wordIndex = visibleWordIndices[randomIndex];
            _textWords[wordIndex].Hide();

            // Remove the chosen index to avoid hiding the same word again
            visibleWordIndices.RemoveAt(randomIndex);
        }
    }

    // Method to display the scripture with hidden words replaced by undercores
    public void Display()
    {
        // Always display the reference first
        Console.Write(_reference.GetReference() + ": ");
        // Then display the scripture text
        foreach (var word in _textWords)
        {
            Console.Write(word.GetRenderedText() + " ");
        }
        Console.WriteLine();
    }

    // Method to check if all words in the scripture are completely hidden 
    public bool IsCompletelyHidden()
    {
        // Check if all words except the first (reference) are hidden
        return _textWords.All(w => w.IsHidden());
    }

    public string GetReference()
    {
        return _reference.GetReference();
    }


}