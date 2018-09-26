using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rockpaperscissorslizardspock
{
    class ComputerPlayer : Player
    {using System;
        {
            public override void SetGestures()
            {

                Console.WriteLine("Enter your gesture: Rock, Paper, Scissors, Lizard, Spock");


                if (gestures == "rock")
                {
                    if (computerPlayer == "lizard" || playerHuman == "scissors");
                    {
                        Console.WriteLine("You Win!");
                    }
                   else if (computerPlayer == "paper")
                    {
                        Console.WriteLine("You Lose!");
                        lose++;
                    }
                    else if (computerPlayern == "spock")
                    {
                        Console.WriteLine("You Lose!");
                        lose++;
                    }
                }
                else if (playerGesture == "paper")
                {
                    if (computerPlayer == "spock")
                    {
                        Console.WriteLine("You Win!");
                        win++;
                    }
                    else if (computerPlayer == "rock")
                    {
                        Console.WriteLine("You Win!");
                        win++;
                    }
                    else if (computerPlayer == "lizard")
                    {
                        Console.WriteLine("You Lose!");
                        lose++;
                    }
                    else if (playerHuman == "scissors")
                    {
                        Console.WriteLine("You Lose!");
                        lose++;
                    }
                }
                else if (playerGesture == "scissors")
                {
                    if (playerHuman == "paper")
                    {
                        Console.WriteLine("You Win!");
                        win++;
                    }
                    else if (playerHuman == "lizard")
                    {
                        Console.WriteLine("You Win!");
                        win++;
                    }
                    else if (playerHuman == "rock")
                    {
                        Console.WriteLine("You Lose!");
                        lose++;
                    }
                    else if (playerHuman == "spock")
                    {
                        Console.WriteLine("You Lose!);
    
                        lose++;
                    }
                }
                else if (playerGesture == "lizard")
                {
                    if (playerHuman == "paper")
                    {
                        Console.WriteLine("You Win!");
                        win++;
                    }
                    else if (playerHuman == "spock")
                    {
                        Console.WriteLine("You Win!");
                        win++;
                    }
                    else if (playerHuman == "scissors")
                    {
                        Console.WriteLine("You Lose!");
                        lose++;
                    }
                    else if (playerHuman == "rock")
                    {
                        Console.WriteLine("You Lose!");
                        lose++;
                    }
                }
                else if (playerGesture == "spock")
                {
                    if (playerHuman == "rock")
                    {
                        Console.WriteLine("You Win!");
                        win++;
                    }
                    else if (playerHuman == "scissors")
                    {
                        Console.WriteLine("You Win!");
                        win++;
                    }
                    else if (playerHuman == "paper")
                    {
                        Console.WriteLine("You Lose!");
                        lose++;
                    }
                    else if (playerHuman == "lizard")
                    {
                        Console.WriteLine("You Lose!");
                        lose++;
                    }
                }

            }

        }

    }
}
