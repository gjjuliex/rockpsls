using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rockpaperscissorslizardspock
{
    class Game
    {
        public Player playerOne;
        public Player playerTwo;
        public Game();
    }

    {
        int NumberOfPlayers;
    private NumberOfPlayers();

        Console.WriteLog("How many numbers of players are there?");
        int NumberOfPlayers = 0;

                private void CreatePlayers(int numberOfPlayers)
    {
        if (numberOfPlayers == 1)
        {
            playerOne = new Human();
            playerTwo = new Computer();
        }
        else if (numberOfPlayers == 2)
        {
            playerOne = new Human();
            playerTwo = new Human();
        }

    }
    private int CalculateWinner()
    {
        int score = 3;