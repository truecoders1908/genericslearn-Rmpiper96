using System;
using System.Collections.Generic;

namespace genericsLearn
{
    class Program
    {
        static void Main(string[] args)
        {
                                                                        // Generics allows a programmer to define a class with a placeholder for the tpes of its fields, 
                                                                        // methods, parameters, and replace them with a specific type at the time of compiling.

            Bag<char> scrabbleLetters = new Bag<char>();                // Creates a new instance of Bag as scrabbleLetters
            scrabbleLetters.PutItemIntoBag('q');                        // Adds a char to the char array, scrabbleLetters, by passing it through the method of PutItemIntoBag 'q'
            scrabbleLetters.PutItemIntoBag('j');                        // Adds a char to the char array, scrabbleLetters, by passing it through the method of PutItemIntoBag 'j'
            scrabbleLetters.PutItemIntoBag('z');                        // Adds a char to the char array, scrabbleLetters, by passing it through the method of PutItemIntoBag 'z'
            scrabbleLetters.PutItemIntoBag('y');                        // Adds a char to the char array, scrabbleLetters, by passing it through the method of PutItemIntoBag 'y'
            scrabbleLetters.PutItemIntoBag('x');                        // Adds a char to the char array, scrabbleLetters, by passing it through the method of PutItemIntoBag 'x'
            char letterFromBag = scrabbleLetters.GetItemFromBag();      // Sets letterFromBag equal to the char array scrabbleLetters, passed through the Method GetItemFromBag
            Console.WriteLine(letterFromBag);                           // Displays to the console letterFromBag
        }
    }

    class Bag<T>                                                        // A New class is formed and Bag is defined as T
    {
        private List<T> items = new List<T>();                          // A new list, from Bag, is created.

        public void PutItemIntoBag(T item)                              // New method with T (Bag) and item (char)
        {
            items.Add(item);                                            // Adds item to the items list
        }

        public T GetItemFromBag()                                       // New method
        {
            Random rnd = new Random();                                  // Establishes a new random intiger
            int randomIndex = rnd.Next(0, items.Count);                 // Selects a random index position based on the amount of characters in Bag
            T randomItem = items[randomIndex];                          // Sets the index of the item, to be removed.
            items.RemoveAt(randomIndex);                                // Removes the random scabble character from the Bag list
            return randomItem;                                          // Returns the random scrabble letter pulled from Bag
        }
    }
}