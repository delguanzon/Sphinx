using System;
using System.Collections.Generic;
using Sphinx.Models;

public class Program
{
    public static void Main()
    {
        Riddles riddle = new Riddles();
        int tries = 0;
        Console.WriteLine("Sphinx: Welcome! In order to proceed you must answer my Riddle.");
        Console.WriteLine("Sphinx: You'll get three tries.");
        
        Console.WriteLine(riddle.GetRiddle());

        

        for(int ctr = 1; ctr <= 3 ; ctr++)
        {
            Console.WriteLine("{Sphinx: Answer me these:");
            string answer = Console.ReadLine();
            if (riddle.checkAnswer(answer))
            {
                Console.WriteLine("Sphinx: Congrats! Your answer, {0} , is correct", answer);
                break;
            }
            else
            {
                Console.WriteLine("Sphinx: WRONG ! That's {0} out of 3", ctr);
                
            }
            tries = ctr;
        }

        if (tries == 3)
        {
            Console.WriteLine("\nSphinx: YOU SHALL NOT PASS");
        }
        else
        {
            Console.WriteLine("Sphinx: YOU SHALL PASS!");
            Console.WriteLine("Sphinx: Unless you want another riddle?[Y][N]");
            string answer = Console.ReadLine();
            if(answer.Trim().ToLower() == "y")
            {
                Main();
            }
        }

    }
}