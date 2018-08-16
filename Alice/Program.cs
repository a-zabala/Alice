using System;

namespace Alice
{
    class Program
    {
        static void Main(string[] args)
        {
            //store the string from the book
            string sentence = "Alice was beginning to get very tired of sitting by her sister on the bank, and of having nothing to do: once or twice \nshe had peeped into the book her sister was reading, but it had no pictures or conversations in it,‘and what is the use of a book,’ thought Alice ‘without pictures or conversation?’";
            //Print out the sentence
            Console.WriteLine(sentence);
            //Skips a line
            Console.WriteLine("");
            Console.WriteLine("Enter a word and see if it is in the first sentence of Alice in Wonderland...");
            //word to search for is entered
            string word =  Console.ReadLine();
            //changed all words of sentence to uppercase
            sentence = sentence.ToUpper();
            //changes word to uppercase, then checks to see index of the word in the sentence
            int check = sentence.IndexOf(word.ToUpper());

            //Index is -1 if not in the sentence, so ouput not found
            if (check == -1)
            {
                Console.WriteLine($"The word --{word}-- is not in the sentence");
            }
            //For any index other than -1 the word is in the sentence
            else
            {
                Console.WriteLine($"The word --{word}-- is found in the sentence");
            }

            Console.ReadLine();
        }
    }
}
