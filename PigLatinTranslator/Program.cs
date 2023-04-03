
namespace PigLatinTranslator
{
    //Interface
    interface IPiglatin
    {
        //Translates each word in string
         string TranslateWord(string word);

        //Returns the entire output string after translation
         string TranslateSentence(string sentence);
    }


    //Implementation of interface using class
    internal class PigLatin:IPiglatin
    {

        //Translates word
        public  string TranslateWord(string word)
        {

            //checks if the word is empty
            if (word.Length == 0)
            {
                return "";
            }

            //Hash set to check if the character in the string word is vowel
            HashSet<char> vowels = new HashSet<char>() { 'a', 'e', 'i', 'o', 'u' };

            int startIndexVowel = 0;

            for (; startIndexVowel < word.Length; startIndexVowel++)
            {

               //Break the loop after the first vowel is found
                if (vowels.Contains(Char.ToLower(word[startIndexVowel])))

                {
                    break;
                }

            }


            //The last character is checked to see if its a symbol such as ',' or '?'
            char lastChar = word[word.Length - 1];
            bool symbolFound = true;
            //Check if last char is symbol
            if (('A' <= (lastChar) && lastChar <= 'z'))

            {
                symbolFound = false;
            }

            string outputWord;
            //First letter vowel
            if (startIndexVowel == 0)
            {

                //If the last char is symbol add 'yay' to the word and finally add the symbol
                if (symbolFound)
                {
                    outputWord = word.Substring(0, word.Length - 1) + "yay" + lastChar;
                }
                else
                {
                    outputWord = word + "yay";
                }

            }
            else
            {
                //If the last char is symbol add 'yay' to the word and finally add the symbol
                if (symbolFound)
                {
                    outputWord = word.Substring(startIndexVowel, word.Length - startIndexVowel - 1) + word.Substring(0, startIndexVowel) + "ay" + lastChar;
                }
                else
                {
                    outputWord = word.Substring(startIndexVowel, word.Length - startIndexVowel) + word.Substring(0, startIndexVowel) + "ay";

                }

            }
            return outputWord;

        }

        public  string TranslateSentence(string sentence)
        {
            
            //Split input string into string array of words to iterate
            string[] sentenceSplit = sentence.Split(' ');

            string outputSentense = "";
            foreach (string word in sentenceSplit)
            {
                //After translation, add empty spaces between words
                outputSentense +=  TranslateWord(word) +" ";
                
            }


            //Capitalise the first letter of the final output sentence and then append the rest of the string as it is
            return char.ToUpper(outputSentense[0]) + outputSentense.Substring(1); 
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //Creating object for the interface
            IPiglatin pigLatinObj = new PigLatin();

            Console.WriteLine( pigLatinObj.TranslateSentence(""));


        }
    }
}