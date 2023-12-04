using System;
using System.Collections.Generic;

public class ScriptureLibrary 
{
    // List of all scriptures in the library
    public List<Scripture> Scriptures {get; private set;} 

    // Constructor to initialize the scripture library and add predefined scriptures 
    public ScriptureLibrary() 
    {
        Scriptures = new List<Scripture>();
        // Add scriptures to the library 
        //Each scripture is created with a Reference object and the scripture text
        Scriptures.Add(new Scripture(new Reference("John", 3, 16),
        "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life."));
        Scriptures.Add(new Scripture(new Reference("Alma", 36, 3),
        "And now, O my son Helaman, behold, thou art in thy youth, and therefore, I beseech of thee that thou wilt hear my words and learn of me; for I do know that whosoever shall put their trust in God shall be supported in their trials, and their troubles, and their afflictions, and shall be lifted up at the last day."));
        Scriptures.Add(new Scripture(new Reference("Matthew", 11, 28-30),
        "28 Come unto me, all ye that labour and are heavy laden, and I will give you rest. 29 Take my yoke upon you, and learn of me; for I am meek and lowly in heart: and ye shall find rest unto your souls. 30 For my yoke is easy, and my burden is light."));
        Scriptures.Add(new Scripture(new Reference("John", 14, 27), 
        "Peace I leave with you, my peace I give unto you: not as the world giveth, give I unto you. Let not your heart be troubled, neither let it be afraid."));
        Scriptures.Add(new Scripture(new Reference("1 Corinthians", 13, 13), 
        "And now abideth faith, hope, charity these three; but the greatest of these is charity."));
    }

    // Method to display the list of scriptures in the library with their references
    public void DisplayScriptures()
    {
        for (int i = 0; i <Scriptures.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {Scriptures[i].GetReference()}");
        }
    }

    // Method to get a scripture by its index in the list
    public Scripture GetScripture(int index)
    {
        return index >= 0 && index < Scriptures.Count ? Scriptures[index] : null;
    }
}