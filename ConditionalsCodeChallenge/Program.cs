using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalsCodeChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            // Bronze:
            // Part 1 - print every letter of the word "supercalifraglisticexpialidocious"
            // to the console, one at a time.
            // Part 2 - Next, do the same, exeptonly print the letter if it is an "i"
            // if it is any other letter, print "Not an i"

            //P1: Suggestion? use Console.WriteLine to print out: char S = "s" 
            //nothing to not repeat char and that "s" and "S" are different char
            //P2: if else statement? if char = "i" console.Write(i);
            // else Console.WriteLine("Not an i");


            //Console.WriteLine(printsupercalifraglisticexpialidocious);  // string of authors
            //print.Add(poppins);
            //string word ("supercalifragilisticexpialidocious");
            char[] charArray = "word".ToCharArray();


            foreach (char letter in charArray)
            {

                if ("i" != "i")
                {
                    Console.WriteLine("Not an i)";
                }
                else
                {
                    Console.WriteLine(letter);
                }
                foreach (charletter in charArray)
                {
                    Console.WriteLine(letter);
                }

                Console.ReadKey();


                // silver:
                // After thst, print the number of letters in the word
                //(do this with code, not by counting manually and hard-coding the number).

                // Suggestion?



                //Gold:
                // In Part 2 of Bronze, also determine if the letter is "L".
                //if it is , print"L"
                // Suggestion? As above if char = "i" Consolewrite(i);
                //if char = "I"console.write(I);
                //Else Console.writeLine("Not an "i" or a "I".)
            }
        }
}
